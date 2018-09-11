namespace JaProject
{
    partial class Encoder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxesPanel = new System.Windows.Forms.Panel();
            this.outputBoxPanel = new System.Windows.Forms.Panel();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.choiceOutputFileButton = new System.Windows.Forms.Button();
            this.inputBoxPanel = new System.Windows.Forms.Panel();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.choiceInputFileButton = new System.Windows.Forms.Button();
            this.coresCountChoicerPanel = new System.Windows.Forms.Panel();
            this.valuesOfCoresCountPanel = new System.Windows.Forms.Panel();
            this.minCoresCount = new System.Windows.Forms.Label();
            this.maxCoresCount = new System.Windows.Forms.Label();
            this.coresCountChoicer = new System.Windows.Forms.TrackBar();
            this.coresCount = new System.Windows.Forms.Label();
            this.startAsmPanel = new System.Windows.Forms.Panel();
            this.asmTime = new System.Windows.Forms.Label();
            this.asmProgressBar = new System.Windows.Forms.ProgressBar();
            this.startAsmButton = new System.Windows.Forms.Button();
            this.selectFilesInformationPanel = new System.Windows.Forms.Panel();
            this.selectFilesInformation = new System.Windows.Forms.Label();
            this.selectThreadsInformationPanel = new System.Windows.Forms.Panel();
            this.selectThreadsInformation = new System.Windows.Forms.Label();
            this.startCPanel = new System.Windows.Forms.Panel();
            this.cTime = new System.Windows.Forms.Label();
            this.cProgressBar = new System.Windows.Forms.ProgressBar();
            this.startCButton = new System.Windows.Forms.Button();
            this.countCoresInformation = new System.Windows.Forms.Label();
            this.startVectorialAsmPanel = new System.Windows.Forms.Panel();
            this.vectorialAsmTime = new System.Windows.Forms.Label();
            this.vectorialAsmProgressBar = new System.Windows.Forms.ProgressBar();
            this.startVectorialAsmButton = new System.Windows.Forms.Button();
            this.boxesPanel.SuspendLayout();
            this.outputBoxPanel.SuspendLayout();
            this.inputBoxPanel.SuspendLayout();
            this.coresCountChoicerPanel.SuspendLayout();
            this.valuesOfCoresCountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coresCountChoicer)).BeginInit();
            this.startAsmPanel.SuspendLayout();
            this.selectFilesInformationPanel.SuspendLayout();
            this.selectThreadsInformationPanel.SuspendLayout();
            this.startCPanel.SuspendLayout();
            this.startVectorialAsmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxesPanel
            // 
            this.boxesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxesPanel.Controls.Add(this.outputBoxPanel);
            this.boxesPanel.Controls.Add(this.inputBoxPanel);
            this.boxesPanel.Location = new System.Drawing.Point(12, 36);
            this.boxesPanel.MinimumSize = new System.Drawing.Size(691, 75);
            this.boxesPanel.Name = "boxesPanel";
            this.boxesPanel.Size = new System.Drawing.Size(691, 75);
            this.boxesPanel.TabIndex = 0;
            // 
            // outputBoxPanel
            // 
            this.outputBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBoxPanel.Controls.Add(this.outputBox);
            this.outputBoxPanel.Controls.Add(this.choiceOutputFileButton);
            this.outputBoxPanel.Location = new System.Drawing.Point(0, 42);
            this.outputBoxPanel.MinimumSize = new System.Drawing.Size(691, 33);
            this.outputBoxPanel.Name = "outputBoxPanel";
            this.outputBoxPanel.Size = new System.Drawing.Size(691, 33);
            this.outputBoxPanel.TabIndex = 1;
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Enabled = false;
            this.outputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputBox.Location = new System.Drawing.Point(3, 7);
            this.outputBox.MinimumSize = new System.Drawing.Size(576, 20);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(576, 20);
            this.outputBox.TabIndex = 2;
            // 
            // choiceOutputFileButton
            // 
            this.choiceOutputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choiceOutputFileButton.Location = new System.Drawing.Point(585, 0);
            this.choiceOutputFileButton.Name = "choiceOutputFileButton";
            this.choiceOutputFileButton.Size = new System.Drawing.Size(103, 33);
            this.choiceOutputFileButton.TabIndex = 1;
            this.choiceOutputFileButton.Text = "Select";
            this.choiceOutputFileButton.UseVisualStyleBackColor = true;
            this.choiceOutputFileButton.Click += new System.EventHandler(this.choiceOutputFileButton_Click);
            // 
            // inputBoxPanel
            // 
            this.inputBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBoxPanel.Controls.Add(this.inputBox);
            this.inputBoxPanel.Controls.Add(this.choiceInputFileButton);
            this.inputBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.inputBoxPanel.MinimumSize = new System.Drawing.Size(691, 33);
            this.inputBoxPanel.Name = "inputBoxPanel";
            this.inputBoxPanel.Size = new System.Drawing.Size(691, 33);
            this.inputBoxPanel.TabIndex = 0;
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Enabled = false;
            this.inputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputBox.Location = new System.Drawing.Point(3, 7);
            this.inputBox.MinimumSize = new System.Drawing.Size(576, 20);
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.Size = new System.Drawing.Size(576, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.Tag = "";
            // 
            // choiceInputFileButton
            // 
            this.choiceInputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choiceInputFileButton.Location = new System.Drawing.Point(585, 0);
            this.choiceInputFileButton.Name = "choiceInputFileButton";
            this.choiceInputFileButton.Size = new System.Drawing.Size(103, 33);
            this.choiceInputFileButton.TabIndex = 1;
            this.choiceInputFileButton.Text = "Select";
            this.choiceInputFileButton.UseVisualStyleBackColor = true;
            this.choiceInputFileButton.Click += new System.EventHandler(this.choiceInputFileButton_Click);
            // 
            // coresCountChoicerPanel
            // 
            this.coresCountChoicerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coresCountChoicerPanel.Controls.Add(this.valuesOfCoresCountPanel);
            this.coresCountChoicerPanel.Controls.Add(this.coresCountChoicer);
            this.coresCountChoicerPanel.Location = new System.Drawing.Point(119, 150);
            this.coresCountChoicerPanel.Name = "coresCountChoicerPanel";
            this.coresCountChoicerPanel.Size = new System.Drawing.Size(472, 81);
            this.coresCountChoicerPanel.TabIndex = 1;
            // 
            // valuesOfCoresCountPanel
            // 
            this.valuesOfCoresCountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesOfCoresCountPanel.Controls.Add(this.minCoresCount);
            this.valuesOfCoresCountPanel.Controls.Add(this.maxCoresCount);
            this.valuesOfCoresCountPanel.Location = new System.Drawing.Point(0, 50);
            this.valuesOfCoresCountPanel.Name = "valuesOfCoresCountPanel";
            this.valuesOfCoresCountPanel.Size = new System.Drawing.Size(472, 29);
            this.valuesOfCoresCountPanel.TabIndex = 4;
            // 
            // minCoresCount
            // 
            this.minCoresCount.AutoSize = true;
            this.minCoresCount.Location = new System.Drawing.Point(55, 5);
            this.minCoresCount.Name = "minCoresCount";
            this.minCoresCount.Size = new System.Drawing.Size(13, 13);
            this.minCoresCount.TabIndex = 3;
            this.minCoresCount.Text = "1";
            // 
            // maxCoresCount
            // 
            this.maxCoresCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxCoresCount.AutoSize = true;
            this.maxCoresCount.Location = new System.Drawing.Point(389, 5);
            this.maxCoresCount.Name = "maxCoresCount";
            this.maxCoresCount.Size = new System.Drawing.Size(19, 13);
            this.maxCoresCount.TabIndex = 4;
            this.maxCoresCount.Text = "64";
            // 
            // coresCountChoicer
            // 
            this.coresCountChoicer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coresCountChoicer.Location = new System.Drawing.Point(46, 14);
            this.coresCountChoicer.Maximum = 64;
            this.coresCountChoicer.Minimum = 1;
            this.coresCountChoicer.MinimumSize = new System.Drawing.Size(362, 45);
            this.coresCountChoicer.Name = "coresCountChoicer";
            this.coresCountChoicer.Size = new System.Drawing.Size(362, 45);
            this.coresCountChoicer.TabIndex = 2;
            this.coresCountChoicer.Value = 1;
            this.coresCountChoicer.Scroll += new System.EventHandler(this.coresCountChoicer_Scroll);
            // 
            // coresCount
            // 
            this.coresCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coresCount.AutoSize = true;
            this.coresCount.Location = new System.Drawing.Point(139, 232);
            this.coresCount.Name = "coresCount";
            this.coresCount.Size = new System.Drawing.Size(0, 13);
            this.coresCount.TabIndex = 5;
            // 
            // startAsmPanel
            // 
            this.startAsmPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startAsmPanel.Controls.Add(this.asmTime);
            this.startAsmPanel.Controls.Add(this.asmProgressBar);
            this.startAsmPanel.Controls.Add(this.startAsmButton);
            this.startAsmPanel.Location = new System.Drawing.Point(12, 251);
            this.startAsmPanel.MinimumSize = new System.Drawing.Size(690, 34);
            this.startAsmPanel.Name = "startAsmPanel";
            this.startAsmPanel.Size = new System.Drawing.Size(690, 34);
            this.startAsmPanel.TabIndex = 2;
            // 
            // asmTime
            // 
            this.asmTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asmTime.Location = new System.Drawing.Point(492, 3);
            this.asmTime.Name = "asmTime";
            this.asmTime.Size = new System.Drawing.Size(87, 28);
            this.asmTime.TabIndex = 3;
            this.asmTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asmProgressBar
            // 
            this.asmProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asmProgressBar.Location = new System.Drawing.Point(174, 3);
            this.asmProgressBar.MinimumSize = new System.Drawing.Size(242, 28);
            this.asmProgressBar.Name = "asmProgressBar";
            this.asmProgressBar.Size = new System.Drawing.Size(242, 28);
            this.asmProgressBar.TabIndex = 1;
            // 
            // startAsmButton
            // 
            this.startAsmButton.Enabled = false;
            this.startAsmButton.Location = new System.Drawing.Point(13, 3);
            this.startAsmButton.Name = "startAsmButton";
            this.startAsmButton.Size = new System.Drawing.Size(114, 28);
            this.startAsmButton.TabIndex = 0;
            this.startAsmButton.Text = "Start ASM";
            this.startAsmButton.UseVisualStyleBackColor = true;
            this.startAsmButton.Click += new System.EventHandler(this.startAsmButton_Click);
            // 
            // selectFilesInformationPanel
            // 
            this.selectFilesInformationPanel.Controls.Add(this.selectFilesInformation);
            this.selectFilesInformationPanel.Location = new System.Drawing.Point(12, 12);
            this.selectFilesInformationPanel.Name = "selectFilesInformationPanel";
            this.selectFilesInformationPanel.Size = new System.Drawing.Size(212, 28);
            this.selectFilesInformationPanel.TabIndex = 3;
            // 
            // selectFilesInformation
            // 
            this.selectFilesInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectFilesInformation.AutoSize = true;
            this.selectFilesInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectFilesInformation.Location = new System.Drawing.Point(-1, 7);
            this.selectFilesInformation.Name = "selectFilesInformation";
            this.selectFilesInformation.Size = new System.Drawing.Size(86, 20);
            this.selectFilesInformation.TabIndex = 0;
            this.selectFilesInformation.Text = "Select files";
            // 
            // selectThreadsInformationPanel
            // 
            this.selectThreadsInformationPanel.Controls.Add(this.selectThreadsInformation);
            this.selectThreadsInformationPanel.Location = new System.Drawing.Point(12, 130);
            this.selectThreadsInformationPanel.Name = "selectThreadsInformationPanel";
            this.selectThreadsInformationPanel.Size = new System.Drawing.Size(579, 28);
            this.selectThreadsInformationPanel.TabIndex = 4;
            // 
            // selectThreadsInformation
            // 
            this.selectThreadsInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectThreadsInformation.AutoSize = true;
            this.selectThreadsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectThreadsInformation.Location = new System.Drawing.Point(-1, 7);
            this.selectThreadsInformation.Name = "selectThreadsInformation";
            this.selectThreadsInformation.Size = new System.Drawing.Size(156, 20);
            this.selectThreadsInformation.TabIndex = 0;
            this.selectThreadsInformation.Text = "Select threads count";
            // 
            // startCPanel
            // 
            this.startCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startCPanel.Controls.Add(this.cTime);
            this.startCPanel.Controls.Add(this.cProgressBar);
            this.startCPanel.Controls.Add(this.startCButton);
            this.startCPanel.Location = new System.Drawing.Point(12, 323);
            this.startCPanel.MinimumSize = new System.Drawing.Size(690, 34);
            this.startCPanel.Name = "startCPanel";
            this.startCPanel.Size = new System.Drawing.Size(690, 34);
            this.startCPanel.TabIndex = 5;
            // 
            // cTime
            // 
            this.cTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTime.Location = new System.Drawing.Point(492, 3);
            this.cTime.Name = "cTime";
            this.cTime.Size = new System.Drawing.Size(87, 28);
            this.cTime.TabIndex = 2;
            this.cTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cProgressBar
            // 
            this.cProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cProgressBar.Location = new System.Drawing.Point(174, 3);
            this.cProgressBar.MinimumSize = new System.Drawing.Size(242, 28);
            this.cProgressBar.Name = "cProgressBar";
            this.cProgressBar.Size = new System.Drawing.Size(242, 28);
            this.cProgressBar.TabIndex = 2;
            // 
            // startCButton
            // 
            this.startCButton.Enabled = false;
            this.startCButton.Location = new System.Drawing.Point(13, 3);
            this.startCButton.Name = "startCButton";
            this.startCButton.Size = new System.Drawing.Size(114, 28);
            this.startCButton.TabIndex = 0;
            this.startCButton.Text = "Start C";
            this.startCButton.UseVisualStyleBackColor = true;
            this.startCButton.Click += new System.EventHandler(this.startCppButton_Click);
            // 
            // countCoresInformation
            // 
            this.countCoresInformation.AutoSize = true;
            this.countCoresInformation.Location = new System.Drawing.Point(22, 232);
            this.countCoresInformation.Name = "countCoresInformation";
            this.countCoresInformation.Size = new System.Drawing.Size(111, 13);
            this.countCoresInformation.TabIndex = 6;
            this.countCoresInformation.Text = "Actaul threads count: ";
            // 
            // startVectorialAsmPanel
            // 
            this.startVectorialAsmPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startVectorialAsmPanel.Controls.Add(this.vectorialAsmTime);
            this.startVectorialAsmPanel.Controls.Add(this.vectorialAsmProgressBar);
            this.startVectorialAsmPanel.Controls.Add(this.startVectorialAsmButton);
            this.startVectorialAsmPanel.Location = new System.Drawing.Point(12, 286);
            this.startVectorialAsmPanel.MinimumSize = new System.Drawing.Size(690, 34);
            this.startVectorialAsmPanel.Name = "startVectorialAsmPanel";
            this.startVectorialAsmPanel.Size = new System.Drawing.Size(690, 34);
            this.startVectorialAsmPanel.TabIndex = 7;
            // 
            // vectorialAsmTime
            // 
            this.vectorialAsmTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vectorialAsmTime.Location = new System.Drawing.Point(492, 3);
            this.vectorialAsmTime.Name = "vectorialAsmTime";
            this.vectorialAsmTime.Size = new System.Drawing.Size(87, 28);
            this.vectorialAsmTime.TabIndex = 3;
            this.vectorialAsmTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vectorialAsmProgressBar
            // 
            this.vectorialAsmProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vectorialAsmProgressBar.Location = new System.Drawing.Point(174, 3);
            this.vectorialAsmProgressBar.MinimumSize = new System.Drawing.Size(242, 28);
            this.vectorialAsmProgressBar.Name = "vectorialAsmProgressBar";
            this.vectorialAsmProgressBar.Size = new System.Drawing.Size(242, 28);
            this.vectorialAsmProgressBar.TabIndex = 1;
            // 
            // startVectorialAsmButton
            // 
            this.startVectorialAsmButton.Enabled = false;
            this.startVectorialAsmButton.Location = new System.Drawing.Point(13, 3);
            this.startVectorialAsmButton.Name = "startVectorialAsmButton";
            this.startVectorialAsmButton.Size = new System.Drawing.Size(114, 28);
            this.startVectorialAsmButton.TabIndex = 0;
            this.startVectorialAsmButton.Text = "Start vectorial ASM";
            this.startVectorialAsmButton.UseVisualStyleBackColor = true;
            this.startVectorialAsmButton.Click += new System.EventHandler(this.startVectorialAsmButton_Click);
            // 
            // Encoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 389);
            this.Controls.Add(this.startVectorialAsmPanel);
            this.Controls.Add(this.coresCount);
            this.Controls.Add(this.countCoresInformation);
            this.Controls.Add(this.startCPanel);
            this.Controls.Add(this.selectThreadsInformationPanel);
            this.Controls.Add(this.selectFilesInformationPanel);
            this.Controls.Add(this.startAsmPanel);
            this.Controls.Add(this.coresCountChoicerPanel);
            this.Controls.Add(this.boxesPanel);
            this.MinimumSize = new System.Drawing.Size(731, 428);
            this.Name = "Encoder";
            this.Text = "Encoder ROT13";
            this.boxesPanel.ResumeLayout(false);
            this.outputBoxPanel.ResumeLayout(false);
            this.outputBoxPanel.PerformLayout();
            this.inputBoxPanel.ResumeLayout(false);
            this.inputBoxPanel.PerformLayout();
            this.coresCountChoicerPanel.ResumeLayout(false);
            this.coresCountChoicerPanel.PerformLayout();
            this.valuesOfCoresCountPanel.ResumeLayout(false);
            this.valuesOfCoresCountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coresCountChoicer)).EndInit();
            this.startAsmPanel.ResumeLayout(false);
            this.selectFilesInformationPanel.ResumeLayout(false);
            this.selectFilesInformationPanel.PerformLayout();
            this.selectThreadsInformationPanel.ResumeLayout(false);
            this.selectThreadsInformationPanel.PerformLayout();
            this.startCPanel.ResumeLayout(false);
            this.startVectorialAsmPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel selectFilesInformationPanel;
        private System.Windows.Forms.Panel boxesPanel;
        private System.Windows.Forms.Panel inputBoxPanel;
        private System.Windows.Forms.Panel outputBoxPanel;

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;

        private System.Windows.Forms.Panel selectThreadsInformationPanel;
        private System.Windows.Forms.Panel coresCountChoicerPanel;
        private System.Windows.Forms.Panel valuesOfCoresCountPanel;

        private System.Windows.Forms.TrackBar coresCountChoicer;

        private System.Windows.Forms.Panel startAsmPanel;
        private System.Windows.Forms.Panel startVectorialAsmPanel;
        private System.Windows.Forms.Panel startCPanel;                     
        
        private System.Windows.Forms.Label selectFilesInformation;
        private System.Windows.Forms.Label selectThreadsInformation;
        private System.Windows.Forms.Label countCoresInformation;
        private System.Windows.Forms.Label coresCount;
        private System.Windows.Forms.Label minCoresCount;
        private System.Windows.Forms.Label maxCoresCount;
        private System.Windows.Forms.Label asmTime;
        private System.Windows.Forms.Label vectorialAsmTime;
        private System.Windows.Forms.Label cTime;

        private System.Windows.Forms.Button choiceInputFileButton;
        private System.Windows.Forms.Button choiceOutputFileButton;        
        private System.Windows.Forms.Button startAsmButton;
        private System.Windows.Forms.Button startVectorialAsmButton;
        private System.Windows.Forms.Button startCButton;

        private System.Windows.Forms.ProgressBar asmProgressBar;
        private System.Windows.Forms.ProgressBar vectorialAsmProgressBar;
        private System.Windows.Forms.ProgressBar cProgressBar; 
    }
}

