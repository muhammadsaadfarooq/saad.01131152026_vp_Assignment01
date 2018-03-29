using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace newApp_Student
{
    public partial class Detail_form : Form
    {
        private List<string> students_detail = new List<string>();
        add_Student update_obj = new add_Student();
        private string file_path2 = "gpa.txt";



        private int count1 = 0;

        public Detail_form()
        {
            InitializeComponent();
        }
        private void Detail_form_Load(object sender, EventArgs e)
        {

        }



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

        public void get_dataline(string key)
        {
            int var = students_detail.Count;

            for (int i = 0; i < var; i++)
            {
                if (students_detail[i] == key)
                {
                    textBox2.Text = "Roll No-----" + students_detail[i];
                    textBox1.Text = "Name-----" + students_detail[i - 1];
                    textBox3.Text = "Semester-----" + students_detail[i + 1];
                    textBox4.Text = "CGPA-----" + students_detail[i + 2];
                    textBox5.Text = "Department-----" + students_detail[i + 3];
                    textBox6.Text = "University-----" + students_detail[i + 4];

                }

            }


        }
        public void get_dataline_delete(string key)
        {
            List<string> update_students_detail = new List<string>();
            int var = students_detail.Count;

            for (int i = 0; i < var; i++)
            {
                if (students_detail[i] == key)
                {

                    students_detail[i] = "-";
                    students_detail[i - 1] = "-";
                    students_detail[i + 1] = "-";
                    students_detail[i + 2] = "-";
                    students_detail[i + 3] = "-";
                    students_detail[i + 4] = "-";

                }

            }

            for (int i = 0; i < students_detail.Count; i++)
            {
                update_obj.write_data(students_detail[i], file_path2);
            }






        }

        public decimal [] get_positions()
        {
            decimal[] top_positions = new decimal[3];
            students_detail.Sort();
            students_detail.Reverse();

            top_positions[0] = Convert.ToDecimal(students_detail[0]);
            top_positions[1] = Convert.ToDecimal(students_detail[1]);
            top_positions[2] = Convert.ToDecimal(students_detail[2]);

            return top_positions;
        }
        public void get_dataline_name(string key)
        {
            int var = students_detail.Count;

            for (int i = 0; i < var; i++)
            {
                if (students_detail[i] == key)
                {
                    textBox1.Text = "Name-----" + students_detail[i];
                    textBox2.Text = "Roll No-----" + students_detail[i+1];
                    textBox3.Text = "Semester-----" + students_detail[i + 2];
                    textBox4.Text = "CGPA-----" + students_detail[i + 3];
                    textBox5.Text = "Department-----" + students_detail[i + 4];
                    textBox6.Text = "University-----" + students_detail[i + 5];

                }

            }


        }


        //public string [] get_attendnce_data()
        //{
        //    string [] top_positions = new string[30];
        //    for (int i=0; i<students_detail.Count;i++)
        //    {
        //        if (i == 0)
        //        {
        //            top_positions[0] = students_detail[0];
        //        }
        //        else
        //        {
        //            top_positions[i] = students_detail[i];
        //        }
            
                
                
                
        //    }
        //    return top_positions;
        //}


        public void get_dataline_semster(string key)
        {
            int var = students_detail.Count;

            for (int i = 0; i < var; i++)
            {
                if (students_detail[i] == key)
                {
                    textBox2.Text = "Roll No-----" + students_detail[i-1];
                    textBox1.Text = "Name-----" + students_detail[i - 2];
                    textBox3.Text = "Semester-----" + students_detail[i];
                    textBox4.Text = "CGPA-----" + students_detail[i + 1];
                    textBox5.Text = "Department-----" + students_detail[i + 2];
                    textBox6.Text = "University-----" + students_detail[i + 3];

                }

            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
