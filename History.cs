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
    public partial class History : Form
    {
        List<Student> list = new List<Student>();
        public void setData(List<Student> data)
        {
            list = data;
        }
        public void receiveDatat(List<Student> data)
        {
            foreach (var student in data)
            {
                list.Add(new Student() { studentId = student.studentId, name = student.name, surname = student.surname, faculty = student.faculty, number = student.number,  disease = student.disease, time = student.time });
            }
        }
        public History()
        {
            InitializeComponent();
            list.Add(new Student()
            {
                studentId = "180104045",
                name = "Askhat",
                surname = "Shailoobekov",
                faculty = "com-18",
                number = "0770840965",
                disease = "Head",
                time = "04/01/2022"
            });
            list.Add(new Student()
            {
                studentId = "180104046",
                name = "Liam",
                surname = "Noah",
                faculty = "com-19",
                number = "0500774302",
                disease = "Leg",
                time = "04/01/2022"
            });
            list.Add(new Student()
            {
                studentId = "180104047",
                name = "Oliver",
                surname = "Grimes",
                faculty = "mat-18",
                number = "0990665382",
                disease = "Head",
                time = "04/01/2022"
            });
            list.Add(new Student()
            {
                studentId = "180104048",
                name = "Michael",
                surname = "Wyatt",
                faculty = "wec-18",
                number = "0772568322",
                disease = "Flu",
                time = "05/01/2022"
            });
        }


        private void History_Load(object sender, EventArgs e)
        {
            panelAlpha1.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha2.BackColor = Color.FromArgb(200, 5, 5, 49);
            panelAlpha3.BackColor = Color.FromArgb(80, 10, 10, 69);
            panelAlpha4.BackColor = Color.FromArgb(80, 10, 10, 69);

            AddPatient addPatient = new AddPatient();
            var d = addPatient.addData();
            foreach (var student in d)
            {
                list.Add(new Student() { studentId = student.studentId, name = student.name, surname = student.surname, faculty = student.faculty, disease = student.disease, time = student.time });
            }


            var students = list;
            listView1.Items.Clear();
            foreach (var student in students)
            {
                var row = new string[] { student.name, student.surname, student.faculty, student.number, student.disease, student.time };
                var lv = new ListViewItem(row);

                lv.Tag = student;

                listView1.Items.Add(lv);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
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

        public int count()
        {
            return list.Count;
        }
    }
}
