using System.Text;
using System.Runtime.InteropServices;


namespace JaProject
{
    unsafe class DLLSupporter
    {
        public DLLSupporter()
        {

        }
        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private unsafe static extern void encodeText(char* a, int length); 

        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private unsafe static extern void vectorialEncodeText(char* a, int length); 

        [DllImport("DLL_C.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void cEncodeText(string text, [In, Out] byte[] outF, int s, int e);

        public unsafe string startAsmEncoding(string text, int jump, int start, int end) 
        {
            int extra = end;
            int amount = end;
            int startIndex = 0;

            amount = amount / jump;
            extra = extra % jump;
            if (extra != 0)
            {
                if (extra > start)
                {
                    amount = amount + 1;
                }
            }

            for (int i = 0; i < start; i++)
            {
                if (extra > i)
                {
                    startIndex = startIndex + 1;
                }
                startIndex = startIndex + end / jump;
            }
            char[] test = new char[amount];
            text.CopyTo(startIndex, test, 0, amount);
            fixed (char* partedText = test)
            {
                encodeText(partedText, amount);
                string newText = new string(partedText);
                return newText;
            }
        }

        public unsafe string startVectorialAsmEncoding(string text, int jump, int start, int end) 
        {
            int extra = end;
            int amount = end;
            int startIndex=0;

            amount = amount / jump;
            extra = extra % jump;
            if (extra != 0)
            {               
                if (extra > start)
                {
                    amount = amount + 1;
                }           
            }

           for(int i=0; i<start; i++)
            {
                if(extra>i)
                {
                    startIndex = startIndex + 1;
                }
                startIndex = startIndex + end / jump;
            }
            char[] test = new char[amount];
            text.CopyTo(startIndex, test, 0, amount);
            fixed (char* partedText = test)
            {                
                vectorialEncodeText(partedText, amount);
                string newText = new string(partedText);
                return newText;
            }
        }

        public string startCEncoding(string text, int jump, int start, int end)
        {
            int extra = end;
            int amount = end;
            int startIndex = 0;

            amount = amount / jump;
            extra = extra % jump;
            if (extra != 0)
            {
                if (extra > start)
                {
                    amount = amount + 1;
                }
            }

            for (int i = 0; i < start; i++)
            {
                if (extra > i)
                {
                    startIndex = startIndex + 1;
                }
                startIndex = startIndex + end / jump;
            }
            int endIndex = startIndex + amount;
            byte[] outF = new byte[amount];
            cEncodeText(text, outF, startIndex, endIndex);
            string newText = Encoding.ASCII.GetString(outF);
            return newText;
        }

    }
}
