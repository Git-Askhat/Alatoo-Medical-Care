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
    public partial class AddPatient : Form
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

        public AddPatient()
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

        private void AddPatient_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 29);

            panelAlpha1.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha2.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha3.BackColor = Color.FromArgb(200, 5, 5, 49);
            panelAlpha4.BackColor = Color.FromArgb(80, 10, 10, 69);

            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Upcoming upcoming = new Upcoming();
            upcoming.Show();
            Visible = false;
        }

        List<string> id = new List<string>() { "180104045", "180104046", "180104047", "180104048", "180104049" };

        List<Student> list = new List<Student>();
        string studentId, disease;

        private void button5_Click(object sender, EventArgs e)
        {
            studentId = textBox1.Text;
            disease = textBox2.Text;

            History history = new History();

            if (id.Contains(studentId))
            {

                list.Add(new Student() { studentId = studentId, name = "Ryan", surname = "Watt", faculty = "wec-17", number = "07033001601", time = "12/11/2021", disease = disease });
                this.Hide();
                history.receiveDatat(list);
                history.Show();

                //textBox1.Text = "";
                //textBox2.Text = "";
            }
        }

        public List<Student> addData()
        {
            return list;
        }
    }
}
