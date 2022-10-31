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
                        if(c.students.Exists(s => s.LoginState == true))
                        {
                            txtStudentName.Text = c.students.Find(s => s.LoginState == true).Name.ToString();
                            txtStudentNum.Text = c.students.Find(s => s.LoginState == true).ID.ToString();
                            txtStudentNIF.Text = c.students.Find(s => s.LoginState == true).NIF.ToString();
                            txtStudentYear.Text = a.year;
                            txtClassStdnt.Text = c.Name;
                            txtStudentAdress.Text = c.students.Find(s => s.LoginState == true).Adress.ToString();
                            txtBalance.Text = c.students.Find(s => s.LoginState == true).Balance.ToString();
                            txtStudentContact.Text = c.students.Find(s => s.LoginState == true).EMAIL.ToString();

                            //Adicionar as discplinas do aluno para a cbb.
                            foreach (Year y in Program.Anos)
                            {
                                //Se o ano letivo for igual ao ano letivo do aluno selecionado anteriormente ,
                                //são colocados para a coleção items da cbb todas as discplinas desse aluno.
                                if (y == a)
                                {
                                    int idx;

                                    for(idx = 0; idx < y.subjects.Count; idx++)
                                    {
                                        cbStudentSubjects.Items.Add(a.subjects[idx].Name.ToString());
                                    }
                                }
                            }
                        }
                }));

        }

        private void btnChangeDataStudent_Click(object sender, EventArgs e)
        {
            Hide();
            RequestForm rqstForm = new RequestForm();
            rqstForm.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            //Verificar se o numero é maior que 0
            //Verificar se o numero não é muito grande 

            try
            {
                if (txtDeposit.Text.Length == 0 && Convert.ToInt32(txtDeposit.Text) == 0)
                {
                    MessageBox.Show("Invalid value , please try again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDeposit.Focus();
                }
            }
            catch (OverflowException){ MessageBox.Show("Value to big , please insert a smaller one!" , "ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Error);}
            catch (FormatException){ MessageBox.Show("No value, please insert a smaller one!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show("Ocurred an expected error , we´ll solve it as soon we can!\nCause: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            int blnce = Convert.ToInt32(txtBalance.Text);
            int dpst = Convert.ToInt32(txtDeposit.Text);

            blnce += dpst;

            txtBalance.Text = blnce.ToString();
            MessageBox.Show("Transaction completed with sucess!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDeposit.Text = "";
        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
