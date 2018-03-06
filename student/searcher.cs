using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace student
{
    class searcher
    {
       
       
        private int line;


        public void searchline(string Key,string entry, string path)
        {
            file counte = new file();
            using (StreamReader file = new StreamReader(path))
            {
                string flag;
                int counter = 1;

                while ((flag = file.ReadLine()) != null)
                {


                    if (Key == flag.Substring(0, 4))
                    {
                        if (entry == flag.Substring(4))
                        {
                            Console.WriteLine("\n\n\t\t\tSearch  Found = " + flag.Substring(4) + "\n");
                            line = counter;
                          

                        }

                    }
                    else
                    {
                        counter++;
                    }

                }
            }
            

           
        }
        public int line_number()
        {
            return line;
        }


    }
}
