using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newApp_Student
{
    public partial class get_userData : Form
    {
        private add_Student add_data = new add_Student();
        private string file_path = "Student.txt";
        private string file_path2 = "cgpa_Student.txt";

        public get_userData()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void get_userData_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //writting to file

            if (textBox1.Text.ToString() == "")
            {
            }
            else
            {

               
                String text_box_data = textBox1.Text.ToString();
                add_data.write_data(text_box_data, file_path);
                text_box_data = textBox2.Text.ToString();
                add_data.write_data(text_box_data, file_path);
                text_box_data = textBox3.Text.ToString();
                add_data.write_data(text_box_data, file_path);
                text_box_data = textBox4.Text.ToString();

                add_data.write_data_gpa(textBox4.Text, file_path2);

                add_data.write_data(text_box_data, file_path);
                text_box_data = textBox5.Text.ToString();
                add_data.write_data(text_box_data, file_path);
                text_box_data = textBox6.Text.ToString();
                add_data.write_data(text_box_data, file_path);
                
                textBox1.Text = "";

                this.Dispose();
            }
                
        }
       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

