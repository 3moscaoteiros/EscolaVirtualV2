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
                                         teacher = new Teacher(){ID="t0001", PIN="00000" } } ,
                 new Subject() {id = 1 , Name = "Matemática",
                                         teacher = new Teacher(){ID="t0002", PIN="00000"} } ,
                 new Subject() {id = 2 , Name = "Inglês" ,
                                         teacher = new Teacher(){ID="t0003", PIN="00000"} } ,
                 new Subject() {id = 3 , Name = "Ciências",
                                         teacher = new Teacher(){ID="t0004", PIN="00000"} } ,
                 new Subject() {id = 4 , Name = "Fisico-quimica",
                                         teacher = new Teacher(){ID="t0005", PIN="00000"} } });

            Program.Anos.Find(s => s.year == "6").subjects.AddRange(new Subject[]

                 {
                 new Subject() {id = 0 , Name = "Português" ,
                                         teacher = Program.Anos[0].subjects[0].teacher} ,
                 new Subject() {id = 1 , Name = "Matemática",
                                         teacher = Program.Anos[0].subjects[1].teacher } ,
                 new Subject() {id = 2 , Name = "Inglês" ,
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
                //MAYBE USE FOREACH??? //verify if the pass of the inserted num is correct
                //error
                if (!Program.Anos.Exists(s => s.subjects.Exists(v => v.teacher.ID == num && v.teacher.PIN == pass)))
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
                //MAYBE USE FOREACH??? //verify if the pass of the inserted num is correct
                if (!Program.Anos.Exists(y => y.CLasses.Exists(v => v.students.Exists(s => s.ID == num && s.PIN == pass)))) 
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
