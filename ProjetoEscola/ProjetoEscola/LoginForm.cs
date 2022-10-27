﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            #region create 5 subjects in year 5 
            Program.Anos.Find(s => s.year == "5").subjects.AddRange(new Subject[]
               {
                 new Subject() { Name = "Português" ,
                                         teacher = new Teacher(){Name="João", ID="t0001", PIN="00000", NIF=412462116,EMAIL="joao@gmail.com",Adress="Rua do João", subject= new Subject(){Name="Português"} } },
                 new Subject() { Name = "Matemática",
                                         teacher = new Teacher(){Name="Manuel",ID="t0002", PIN="00000", NIF=957483650,EMAIL="manuel@gmail.com",Adress="Rua do Manuel", subject= new Subject(){Name="Matemática"} } },
                 new Subject() { Name = "Inglês" ,
                                         teacher = new Teacher(){Name="Jorge",ID="t0003", PIN="00000", NIF=390172831,EMAIL="jorge@gmail.com",Adress="Rua do Jorge", subject= new Subject(){Name="Inglês"} } },
                 new Subject() { Name = "Ciências",
                                         teacher = new Teacher(){Name="Luís",ID="t0004", PIN="00000", NIF=317390817,EMAIL="luis@gmail.com",Adress="Rua do Luís", subject= new Subject(){Name="Ciências"} } },
                 new Subject() { Name = "Educação Física",
                                         teacher = new Teacher(){Name="Rogério",ID="t0005", PIN="00000", NIF=361209382,EMAIL="rogerio@gmail.com",Adress="Rua do Rogério", subject= new Subject(){Name="Educação Física"} } } });

            #endregion

            #region create 5 subjects in year 6
            Program.Anos.Find(s => s.year == "6").subjects.AddRange(new Subject[]

                 {
                 new Subject() { Name = "Português" ,
                                         teacher = Program.Anos[0].subjects[0].teacher} ,
                 new Subject() {Name = "Matemática",
                                         teacher = Program.Anos[0].subjects[1].teacher } ,
                 new Subject() {Name = "Inglês" ,
                                         teacher = Program.Anos[0].subjects[2].teacher } ,
                 new Subject() { Name = "Ciências",
                                         teacher = Program.Anos[0].subjects[3].teacher } ,
                 new Subject() { Name = "Fisico-quimica",
                                         teacher = Program.Anos[0].subjects[4].teacher }
                 });
            
            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string num = txtLoginNum.Text; 
            string pass = txtLoginPassword.Text;

            #region errors
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
                    return;
              }

            if (num.Length != 5 || pass.Length != 5)
            {
                MessageBox.Show("Wrong Information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            //take first char(t or s)
            string firstC = txtLoginNum.Text.Trim().ToLower().Substring(0, 1);
           

            //if teacher
            if (firstC=="t")
            {
                //verify if the pass of the inserted num is incorrect
                if (!Program.Anos.Exists(y => y.subjects.Exists(s => s.teacher.ID == num && s.teacher.PIN == pass)))
                {
                    txtLoginNum.Text = "";
                    txtLoginPassword.Text = "";
                    MessageBox.Show("Wrong information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
                else
                {

                    //if exists:
                    Program.Anos.ForEach(y =>
                    {
                        y.subjects.ForEach(s =>
                        {
                            if (s.teacher.ID == txtLoginNum.Text)
                                s.teacher.LoginState = true;
                        });
                    });

                    Hide();
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.ShowDialog();
                }
            }
            //if student
            if (firstC == "s")
            {
                
                 //verify if the pass of the inserted num is correct
                if (!Program.Anos.Exists(y => y.CLasses.Exists(c=> c.students.Exists(s => s.ID == num && s.PIN == pass)))) 
                {
                    txtLoginNum.Text = "";
                    txtLoginPassword.Text = "";

                    MessageBox.Show("Wrong information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //if exists:
                    Program.Anos.ForEach(y =>
                    {
                        y.CLasses.ForEach(c =>
                        {
                            c.students.Find(s => s.ID == txtLoginNum.Text).LoginState = true;

                        });
                    });

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

        private void txtLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
