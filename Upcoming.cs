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
    public partial class Upcoming : Form
    {
        public Upcoming()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Upcoming upcoming = new Upcoming();
            upcoming.Show();
            Visible = false;
        }

        private void Upcoming_Load(object sender, EventArgs e)
        {
            panelAlpha1.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha2.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha3.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha4.BackColor = Color.FromArgb(200, 5, 5, 49);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSquare addSquare = new AddSquare();
            addSquare.Show();
        }
    }
}
