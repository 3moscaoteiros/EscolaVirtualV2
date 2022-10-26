using System;
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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Visible = true;
        }

        #region KeyPressEvents
        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        #endregion

        private void StudentForm_Load(object sender, EventArgs e)
        {
            Program.Anos.ForEach(a => a.CLasses.ForEach(c =>
                {
                        if(c.students.Exists(s => s.LoginState == 1))
                        {
                            txtStudentName.Text = c.students.Find(s => s.LoginState == 1).Name.ToString();
                            txtStudentNum.Text = c.students.Find(s => s.LoginState == 1).ID.ToString();
                            txtStudentNIF.Text = c.students.Find(s => s.LoginState == 1).NIF.ToString();
                            txtStudentYear.Text = a.year;
                            txtClassStdnt.Text = c.Name;
                            txtStudentAdress.Text = c.students.Find(s => s.LoginState == 1).Adress.ToString();
                            txtBalance.Text = c.students.Find(s => s.LoginState == 1).Balance.ToString();

                            //Adicionar as discplinas do aluno para a cbb.
                            foreach(Year y in Program.Anos)
                            {
                                //Se o ano letivo for igual ao ano letivo do aluno selecionado anteriormente ,
                                //são colocados para a coleção items da cbb todas as discplinas desse aluno.
                                if (y == a)
                                {
                                    int idx;

                                    for(idx = 0; idx <= y.subjects.Count; idx++)
                                    {
                                        cbStudentSubjects.Items.Add(a.subjects[idx]);
                                    }
                                }
                            }
                        }
                }));
            
        }
    }
}
