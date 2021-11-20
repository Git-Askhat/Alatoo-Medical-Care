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

        private void Upcoming_Click(object sender, EventArgs e)
        {
            Upcoming upcoming = new Upcoming();
            upcoming.Hide();
            upcoming.Show();
            Visible = false;
        }
    }
}
