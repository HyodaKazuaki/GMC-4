using System.IO;

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
