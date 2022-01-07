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
        List<Student> data = new List<Student>();
        public Upcoming()
        {
            InitializeComponent();
            data.Add(new Student()
            {
                studentId = "180104046",
                name = "Liam",
                surname = "Noah",
                faculty = "com-19",
                number = "0500774302",
                disease = "An injection",
                time = "14/01/2022"
            });
            data.Add(new Student()
            {
                studentId = "180104047",
                name = "Oliver",
                surname = "Grimes",
                faculty = "mat-18",
                number = "0990665382",
                disease = "Head",
                time = "16/01/2022"
            });
        }

        public int getSize()
        {
            return data.Count;
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

            AddSquare addSquare = new AddSquare();

            var d = addSquare.dataUpcoming();
            foreach (var student in d)
            {
                data.Add(new Student() { studentId = student.studentId, name = student.name, surname = student.surname, faculty = student.faculty, disease = student.disease, time = student.time });
            }

            var students = data;
            listView1.Items.Clear();
            foreach (var student in students)
            {
                var row = new string[] { student.time, student.name, student.surname, student.faculty, student.number, student.disease };
                var lv = new ListViewItem(row);

                lv.Tag = student;

                listView1.Items.Add(lv);


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSquare addSquare = new AddSquare();
            addSquare.Show();
        }
    }
}
