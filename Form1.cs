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
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Colors of windowses
            panelOpacityMain.BackColor = Color.FromArgb(80, 0, 0, 59);
            loginPanel.BackColor = Color.FromArgb(200, 0, 0, 0);

            loginPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginPanel.Width, loginPanel.Height, 40, 40));
            loginButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginButton.Width, loginButton.Height, 40, 40));


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginPasword_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string admin, password;
            admin = loginText.Text;
            password = loginPasword.Text;
            HomePage homepage = new HomePage();

            if (admin.Equals("admin") && password.Equals("admin"))
            {
                homepage.Show();

                Visible = false;
            } else if (admin.Equals("") && password.Equals(""))
            {
                label1.Text = "Enter username";
                label2.Text = "Enter password";
            } else
            {
                label3.Text = "Incorrect password or username";
            }
            
        }
    }
}
