using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alatoo_Medical_Care
{
    public partial class HomePage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            homePageOpacity.BackColor = Color.FromArgb(150, 10, 10, 49);

            panelAlpha1.BackColor = Color.FromArgb(200, 5, 5, 49);
            panelAlpha2.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha3.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha4.BackColor = Color.FromArgb(80, 10, 10, 69);


            history.BackColor = Color.FromArgb(180, 0, 0, 0);
            add.BackColor = Color.FromArgb(180, 0, 0, 0);
            upcoming.BackColor = Color.FromArgb(180, 0, 0, 0);

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));

            History hist = new History();
            Upcoming upcom = new Upcoming();

            label1.Text = hist.count().ToString();
            label3.Text = upcom.getSize().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Upcoming upcoming = new Upcoming();
            upcoming.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Upcoming upcoming = new Upcoming();
            upcoming.Show();
            Visible = false;
        }
    }
}
