using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace JaProject
{
    public partial class Encoder : Form
    {
        private const int ASMLIBID = 0;
        private const int VECTORIALASMLIBID = 1;
        private const int CLIBID = 2;
        private const int AMOUNTOFLIBRARIES = 3;
        private const int INPUTID = 0;
        private const int OUTPUTID = 1;
        private const int AMOUNTOFFILES = 2;

        private const string INPUTPARAMETER = "-i";
        private const string OUTPUTPARAMETER = "-o";
        private const string CORESPARAMETER = "-c";
        private const string EXTENSION = ".txt";
        private const string FILTER = "Text|*.txt|All|*.*";
        private const string EMPTYINPUTBOXMESSAGE = "Select your input file path.";
        private const string EMPTYOUTPUTBOXMESSAGE = "Select your output file path.";

        private int cores;

        private string[] startUpMessages = new String[AMOUNTOFFILES];
        private TextBox[] boxes = new TextBox[AMOUNTOFFILES];

        private string inputFilePath;
        public string outputFilePath;

        private StreamReader inputStream;
        private StreamWriter outputStream;

        private Thread[] arrayOfThreads = new Thread[1];

        private ProgressBar[] progressbars = new ProgressBar[AMOUNTOFLIBRARIES];
        
        private Stopwatch[] watches = new Stopwatch[AMOUNTOFLIBRARIES];

        private Label[] timers = new Label[AMOUNTOFLIBRARIES];
        
        public Encoder()
        {
            InitializeComponent();

            setProgressbars();
            setBoxes();
            setWatches();
            setTimers();

            loadStartUpCoresCount();
            loadStartUpBoxes();
            loadStartUpArguments();
        }

        private void setProgressbars()
        {
            progressbars[ASMLIBID] = asmProgressBar;
            progressbars[VECTORIALASMLIBID] = vectorialAsmProgressBar;
            progressbars[CLIBID] = cProgressBar;
        }

        private void setBoxes()
        {
            boxes[INPUTID] = inputBox;
            boxes[OUTPUTID] = outputBox;
        }       

        private void setTimers()
        {
            timers[ASMLIBID] = asmTime;
            timers[VECTORIALASMLIBID] = vectorialAsmTime;
            timers[CLIBID] = cTime;
        }

        private void setWatches()
        {
            for (int i = 0; i < AMOUNTOFLIBRARIES; i++)
            {
                watches[i] = new Stopwatch();
            }
        }

        private void loadStartUpBoxes()
        {
            boxes[INPUTID].Text = EMPTYINPUTBOXMESSAGE;
            boxes[OUTPUTID].Text = EMPTYOUTPUTBOXMESSAGE;
            for (int i = 0; i < AMOUNTOFFILES; i++)
            {
                boxes[i].ForeColor = SystemColors.GrayText;
                boxes[i].BackColor = SystemColors.Window;
            }
        }

        private void loadStartUpCoresCount()
        {
            cores = Environment.ProcessorCount;
            coresCount.Text = cores.ToString();
            coresCountChoicer.Value = cores;
        }

        private void loadStartUpArguments()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1 && args.Length < 8)
            {
                for (int i = 1; i < args.Length; i = i + 2)
                {
                    if (args[i] == INPUTPARAMETER)
                    {
                        loadInputFilePathArgument(args, i);
                    }
                    else if (args[i] == OUTPUTPARAMETER && args[i + 1].Contains(EXTENSION) == true)
                    {
                        loadOutputFileArgument(args, i);
                    }
                    else if (args[i] == CORESPARAMETER)
                    {
                        loadCoresCountArgument(args, i);
                    }
                }
            }
        }

        private void loadInputFilePathArgument(string[] args, int i)
        {
            string tmp;
            tmp = args[i + 1];
            tmp.Remove(0, tmp.Length - 4);
            if (tmp.Contains(EXTENSION) == true)
            {
                inputBox.Text = args[i + 1];
                inputStream = new StreamReader(inputBox.Text);
                inputFilePath = inputStream.ReadToEnd();
            }
            startButtons_Enable();
        }

        private void loadOutputFileArgument(string[] args, int i)
        {
            string tmp;
            tmp = args[i + 1];
            tmp.Remove(0, tmp.Length - 4);
            if (tmp.Contains(EXTENSION) == true)
            {
                outputBox.Text = args[i + 1];
            }
            startButtons_Enable();
        }

        private void loadCoresCountArgument(string[] args, int i)
        {
            cores = Int32.Parse(args[i + 1]);
            startButtons_Enable();
            coresCountChoicer.Value = cores;
            coresCount.Text = cores.ToString();
        }
                
        private void choiceInputFileButton_Click(object sender, EventArgs e)
        {            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = FILTER;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                inputBox.Text = dialog.InitialDirectory + dialog.FileName;
                inputStream = new StreamReader(inputBox.Text);
                inputFilePath = inputStream.ReadToEnd();
            }            
            startButtons_Enable();
        }

        private void choiceOutputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog2 = new OpenFileDialog();
            dialog2.Filter = FILTER;
            if (dialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                outputBox.Text = dialog2.InitialDirectory + dialog2.FileName;
               
            }
            startButtons_Enable();
        }

        private void coresCountChoicer_Scroll(object sender, EventArgs e)
        {
            coresCount.Text = coresCountChoicer.Value.ToString();
            cores = coresCountChoicer.Value;
        }

        private void startButtons_Enable()
        {
            if(inputBox.Text != EMPTYINPUTBOXMESSAGE && outputBox.Text != EMPTYOUTPUTBOXMESSAGE)
            {
                startAsmButton.Enabled = true;
                startVectorialAsmButton.Enabled = true;
                startCButton.Enabled = true;
            }
        }

        private void startButtons_Disable()
        {
            if (inputBox.Text != EMPTYINPUTBOXMESSAGE && outputBox.Text != EMPTYOUTPUTBOXMESSAGE)
            {
                startAsmButton.Enabled = false;
                startVectorialAsmButton.Enabled = false;
                startCButton.Enabled = false;
            }
        }        

        private void startAsmButton_Click(object sender, EventArgs e)
        {
            encodeAndSaveText(ASMLIBID);
            GC.Collect();
        }

        private void startVectorialAsmButton_Click(object sender, EventArgs e)
        {
            encodeAndSaveText(VECTORIALASMLIBID);
            GC.Collect();
        }

        private void startCppButton_Click(object sender, EventArgs e)
        {
            encodeAndSaveText(CLIBID);
            GC.Collect();
        }

        private void encodeAndSaveText(int functionID)
        {
            string[] tab = new string[cores];
            startButtons_Disable();
            prepareThreads(tab, functionID);
            saveText(tab, functionID);
            startButtons_Enable();            
        }

        private void prepareThreads(string[] tab, int id)
        {
            if (arrayOfThreads.Length != cores)
            {
                Array.Resize<Thread>(ref arrayOfThreads, cores);
            }
            progressbars[id].Value = 10;
            for (int i = 0; i < cores; i++)
            {
                arrayOfThreads[i] = new Thread(new ParameterizedThreadStart(runThreads));
            }
            watches[id].Start();
            for (int i = 0; i < cores; i++)
            {
                object arguments = new object[3] { i, tab, id};
                arrayOfThreads[i].Start(arguments);
            }
            for (int i = 0; i < cores; i++)
            {
                arrayOfThreads[i].Join();
            }
            watches[id].Stop();
        }

        private void saveText(string[] tab, int functionID)
        {
            progressbars[functionID].Value = 50;
            using (outputStream = new StreamWriter(outputBox.Text))
            {               
                makeOutputFile(tab);
                outputStream.WriteLine(outputFilePath);                
            }
            progressbars[functionID].Value = 100;
            timers[functionID].Text = (watches[functionID].ElapsedMilliseconds).ToString() + " ms";
            watches[functionID].Reset();
        }

        private void runThreads(object arg)
        {
            Array data = new object[3];
            data = (Array)arg;
            int start = (int)data.GetValue(0);
            string[] tab = (string[])data.GetValue(1);
            int functionID = (int)data.GetValue(2);
            DLLSupporter funkcja = new DLLSupporter();
            switch (functionID)
            {
                case 0:
                    {                        
                        tab[start] = funkcja.startAsmEncoding(inputFilePath, cores, start, inputFilePath.Length);
                        break;
                    }
                case 1:
                    {
                        tab[start] = funkcja.startVectorialAsmEncoding(inputFilePath, cores, start, inputFilePath.Length);
                        break;
                    }
                case 2:
                    {
                        tab[start] = funkcja.startCEncoding(inputFilePath, cores, start, inputFilePath.Length);
                        break;
                    }
            }            
        }

        private void makeOutputFile(string[] tab)
        {
            string results = "";
                   
            for(int i=0; i<cores; i++)
            {
                results = results + tab[i];               
            }
            outputFilePath = results;           
        }
    }
}
