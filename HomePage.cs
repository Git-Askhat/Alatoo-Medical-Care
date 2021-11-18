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
            homePagePanel.BackColor = Color.FromArgb(80, 10, 10, 69);
            historyPanel.BackColor = Color.FromArgb(80, 10, 10, 69);
            addPanel.BackColor = Color.FromArgb(80, 10, 10, 69);
            notificationPanel.BackColor = Color.FromArgb(80, 10, 10, 69);
            history.BackColor = Color.FromArgb(180, 0, 0, 0);
            add.BackColor = Color.FromArgb(180, 0, 0, 0);
            upcoming.BackColor = Color.FromArgb(180, 0, 0, 0);

            history.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, history.Width, history.Height, 40, 40));
            add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, add.Width, add.Height, 40, 40));
            upcoming.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, upcoming.Width, upcoming.Height, 40, 40));

        }

        private void homePagePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void historyPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
