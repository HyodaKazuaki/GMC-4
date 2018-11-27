using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GMC_4
{
    class File
    {
        private string FileName = "";

        public void Write(string codeData)
        {
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                sw.Write(codeData);
            }
        }
    }
}
