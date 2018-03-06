using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace student
{
    class delete_record
    {
        public void RemoveLineFromTxtFile(string lineContent, string fileName)
        {
            StringBuilder clone= new StringBuilder("");
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (line.Substring(4) != lineContent)
                {
                    clone.Append(line);
                }
            }
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                StreamWriter rewrite = new StreamWriter(fs);
                rewrite.BaseStream.Seek(0, SeekOrigin.Begin);
                rewrite.WriteLine(clone.ToString());
                rewrite.Flush();
                rewrite.Close();
            }
        }
    }
}
