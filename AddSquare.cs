using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alatoo_Medical_Care
{
    public partial class AddSquare : Form
    {
        public AddSquare()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 10, 10, 49);

        }

        List<Student> data = new List<Student>();

        string stdId, date_, disease_;
        private void Upcoming_Click(object sender, EventArgs e)
        {
            stdId = studentId.Text.Trim();
            date_ = date.Text.Trim();
            disease_ = date.Text.Trim();

            if (stdId!="" && date_ != "" && disease_ != "") {
                data.Add(new Student() { studentId = stdId, name = "Ryan", surname = "Watt", faculty = "wec-17", number = "07033001601", time = date_, disease = disease_ });
                //Upcoming upcoming = new Upcoming();
                //upcoming.Visible = false;
               // upcoming.Show();
                Visible = false;
            }
        }

        public List<Student> dataUpcoming()
        {
            return data;
        }
    }
}
