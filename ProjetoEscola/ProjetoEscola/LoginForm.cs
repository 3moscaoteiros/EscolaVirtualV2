using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_DLL;

namespace ProjetoEscola
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Program.Anos.Find(s => s.year == "5").subjects.AddRange(new Subject[]

               {
                 new Subject() {id = 0 , Name = "Português" ,
                                         teacher = new Teacher(){ID="t0001", PIN="t0001" } } ,
                 new Subject() {id = 1 , Name = "Matemática",
                                         teacher = new Teacher(){ID="t0002", PIN="t0002"} } ,
                 new Subject() {id = 2 , Name = "Música" ,
                                         teacher = new Teacher(){ID="t0003", PIN="t0003"} } ,
                 new Subject() {id = 3 , Name = "Ciências",
                                         teacher = new Teacher(){ID="t0004", PIN="t0004"} } ,
                 new Subject() {id = 4 , Name = "Fisico-quimica",
                                         teacher = new Teacher(){ID="t0005", PIN="t0005"} } });

            Program.Anos.Find(s => s.year == "6").subjects.AddRange(new Subject[]

                 {
                 new Subject() {id = 0 , Name = "Português" ,
                                         teacher = Program.Anos[0].subjects[0].teacher} ,
                 new Subject() {id = 1 , Name = "Matemática",
                                         teacher = Program.Anos[0].subjects[1].teacher } ,
                 new Subject() {id = 2 , Name = "Música" ,
                                         teacher = Program.Anos[0].subjects[2].teacher } ,
                 new Subject() {id = 3 , Name = "Ciências",
                                         teacher = Program.Anos[0].subjects[3].teacher } ,
                 new Subject() {id = 4 , Name = "Fisico-quimica",
                                         teacher = Program.Anos[0].subjects[4].teacher }
                 });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string num = txtLoginNum.Text;
            string pass = txtLoginPassword.Text;

            //error
            if (num == "" || pass == "")
            {
                MessageBox.Show("Missing information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLoginNum.Text == "00000" && txtLoginPassword.Text == "00000")
              {
                    Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
              }

              //take first char(t or s)
            string firstC = txtLoginNum.Text.ToLower().Substring(0, 1);
           

            //if teacher
            if (firstC=="t")
            {
                //error
                if (!Program.Anos.Exists(s => s.subjects.Exists(v => v.teacher.ID == num))) 
                {
                    txtLoginNum.Text = "";
                    txtLoginPassword.Text = "";

                    MessageBox.Show("Wrong information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if exists:
                    Hide();
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.ShowDialog();
                }
            }

            //if student
            if (firstC == "s")
            {
                //error
                if (!Program.Anos.Exists(s => s.CLasses.Exists(v => v.students.Exists(t => t.ID == num)))) 
                {
                    txtLoginNum.Text = "";
                    txtLoginPassword.Text = "";

                    MessageBox.Show("Wrong information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if exists:
                    Hide();
                    StudentForm studentForm = new StudentForm();
                    studentForm.ShowDialog();
                }
            }
        }

        private void btnLoginInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Num:(s/t) and 4 digits\nPin:5 digits", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
