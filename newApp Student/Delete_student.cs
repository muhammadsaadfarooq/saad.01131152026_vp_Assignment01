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
    
    public partial class Delete_student : Form
    {
        private string file_path = "Student.txt";
        public Delete_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detail_form update_delete_file = new Detail_form();
            update_delete_file.fetch_rec(file_path);
            update_delete_file.get_dataline_delete(textBox1.Text);

            MessageBox.Show("Record Deleted Sucessfully");
            this.Dispose();
        }

        private void Delete_student_Load(object sender, EventArgs e)
        {

        }
    }
}
