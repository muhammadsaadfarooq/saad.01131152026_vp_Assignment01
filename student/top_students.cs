using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace student
{
    class top_students
    {
        public void cgpa(string Key,string path)
        {
            List<string> gpaList = new List<string>();
            using (StreamReader file = new StreamReader(path))
            {
                string flag;



                while ((flag = file.ReadLine()) != null)
                {


                    if (Key == flag.Substring(0, 4))
                    {
                        gpaList.Add(flag.Substring(4));

                    }

                }
            }

            gpaList.Sort();
            gpaList.Reverse();

            Console.WriteLine("1: "+gpaList[0]);
            Console.WriteLine("2: "+gpaList[1]);
            Console.WriteLine("3: "+gpaList[2]);



        }

    }
}
