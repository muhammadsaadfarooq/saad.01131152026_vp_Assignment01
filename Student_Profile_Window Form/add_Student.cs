using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace newApp_Student
{
    class add_Student
    {

        private StreamWriter obj;
      


        public void write_data(string user_input, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.WriteLine(user_input);
            obj.Close();

        }
        public void write_data_gpa(string cgpa, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.WriteLine(cgpa);
            obj.Close();

        }
      
    }
}
