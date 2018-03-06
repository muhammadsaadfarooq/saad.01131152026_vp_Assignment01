using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace student
{
    class file
    {
       private List<string> students_detail = new List<string>();
       private int count1 = 0;
        public void fetch_rec(string path)
        {
            string flag;

            using (StreamReader file = new StreamReader(path))
            {


                while ((flag = file.ReadLine()) != null)
                {
                    students_detail.Add(flag);
                    count1++;


                }
            }
        }
        public void shoewrecord(int lines,int start, int end)
        {
            for (int i=lines-start;i<lines+end;i++)
            {
                Console.WriteLine(students_detail[i]);
            }
        }

    }
}

