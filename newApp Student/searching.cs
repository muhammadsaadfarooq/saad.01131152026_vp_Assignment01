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
    public partial class searching : Form
    {
        private string file_path = "Student.txt";
        public searching()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detail_form print_screen = new Detail_form();
            print_screen.fetch_rec(file_path);
            print_screen.get_dataline(textBox1.Text);
            print_screen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Detail_form print_screen = new Detail_form();
            print_screen.fetch_rec(file_path);
            print_screen.get_dataline_name(textBox2.Text);
            print_screen.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detail_form print_screen = new Detail_form();
            print_screen.fetch_rec(file_path);
            print_screen.get_dataline_semster(textBox3.Text);
            print_screen.Show();
        }

        private void searching_Load(object sender, EventArgs e)
        {

        }
    }
}
