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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string num = txtLoginNum.Text;
            string pass = txtLoginPassword.Text;

            //error
            if (num == "" || pass == "")
            {
                MessageBox.Show("Missing information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (firstC.Trim()=="t")
            {
                bool exists = false;
                //search in list if teacher exists
                foreach (Year y in Program.Anos)
                {
                    foreach (Subject s in y.subjects)
                    {
                        if (s.teacher.ID==num)
                            exists = true;
                    }
                }

               

                //error
                if (!exists)
                {
                    txtLoginNum.Text = "";
                    txtLoginPassword.Text = "";

                    MessageBox.Show("Wrong information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //if exists:
                Hide();
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.ShowDialog();

            }

            //if student
            if (firstC.Trim() == "s")
            {
                bool exists = false;
                //search in list if student exists
                foreach (Year y in Program.Anos)
                {
                    foreach (Class c in y.CLasses)
                    {
                        foreach (Student s in c.students)
                        {
                            if (s.ID==num)
                                exists = true;
                        }
                    }
                }


                //error
                if (!exists)
                {
                    txtLoginNum.Text = "";
                    txtLoginPassword.Text = "";

                    MessageBox.Show("Wrong information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //if exists:
                Hide();
                StudentForm studentForm = new StudentForm();
                studentForm.ShowDialog();

            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
