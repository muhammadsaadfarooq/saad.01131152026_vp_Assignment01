using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace student
{
    class attendence
    {
        private List<string> nameList = new List<string>();
        public void attend(string Key, string path,string entry_semester)
        {
            
            using (StreamReader file = new StreamReader(path))
            {
                string flag;



                while ((flag = file.ReadLine()) != null)
                {


                    if (Key == flag.Substring(0, 4) && entry_semester==flag.Substring(4))
                    {
                        nameList.Add(flag.Substring(4));
                        
                    }

                }

               
            }
        }

        public void attend_conc(string present="A")
        {
            for(int i=0;i<=nameList.Count;i++)
            {
                Console.WriteLine("Roll Number" +nameList[i] + "is " + present);
            }
        }

       
    }

}
