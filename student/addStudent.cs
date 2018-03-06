using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace student
{
    class addStudent
    {
        private StreamWriter obj;
        private string [] Key = {"nam:","rol:","sem:","gpa:","dep:","uni:" };
        
               

        public void write_rollNum(string a_rollNum, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.Write(Key[1]);
            obj.WriteLine(a_rollNum);
            obj.Close();

        }
        public void write_studentName(string a_student, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.Write(Key[0]);
            obj.WriteLine(a_student);
            obj.Close();


        }
        public void write_semester(string a_sem, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.Write(Key[2]);
            obj.WriteLine(a_sem);
            obj.Close();

        }
        public void write_CGPA(string a_CGPA, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.Write(Key[3]);
            obj.WriteLine(a_CGPA);
            obj.Close();

        }
        public void write_Department(string a_dept, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.Write(Key[4]);
            obj.WriteLine(a_dept);
            obj.Close();

        }
        public void write_university(string a_uni, string path)
        {
            obj = File.AppendText(path);
            obj.AutoFlush = true;
            obj.Write(Key[5]);
            obj.WriteLine(a_uni);
            obj.Close();

        }
    }
}
