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
    public partial class top3_students : Form
    {
        private string file_path = "cgpa_Student.txt";
        public top3_students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] positions = new decimal[3];
            Detail_form get_positionss = new Detail_form();
            get_positionss.fetch_rec(file_path);
            positions = get_positionss.get_positions();
            textBox1.Text = Convert.ToString(positions[0]);
            textBox2.Text = Convert.ToString(positions[1]);
            textBox3.Text = Convert.ToString(positions[2]);


        }

        private void top3_students_Load(object sender, EventArgs e)
        {

        }
    }
}
