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
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnCreateStudent.Enabled = false;
            btnCreateTeacher.Enabled = false;
            btnCreateClass.Enabled = false;

        }

        #region KeyPressEvents
        private void txtNameStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar==8)
                e.Handled= false;
            else
                e.Handled= true;
        }

        private void txtNIFStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtContactStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtBalanceStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNameTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNIFTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtContactTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            #region variables
            string name = txtNameStudent.Text;
            string num = txtNumStudent.Text;
            string nif = txtNIFStudent.Text; ;
            string adress = txtAdressStudent.Text; 
            string contact = txtContactStudent.Text;
            string Class = cbbClassStudent.SelectedItem.ToString();
            string money = txtBalanceStudent.Text;
            string pin = txtPINStudnet.Text;
            #endregion

            Student student = new Student()
            {
                Name = name,
                Adress = adress,
                EMAIL = contact,
                NIF = Convert.ToInt32(nif),
                ID = num,
                PIN = pin,
                Request = false
                
            };


            //Program.Anos.Find(y => y.year == year).CLasses.Add(cl);
            //add à turma
            //só consigo add à turma passando pelos anos
            //Program.Anos.Add()

        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            string year= cbbChooseYear.SelectedItem.ToString();
            string Class = txtCreateClass.Text;

            if(cbbChooseYear.SelectedItem == null || Class.Trim()=="")
            {
                MessageBox.Show("ERROR","Info missing",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Class cl = new Class();
            cl.Name = Class;
            //não preciso do id ent pq ele existir?


            //verificar se já existe a turma
            bool hasClass = Program.Anos.Find(y => y.year == year).CLasses.Any(c => c.Name.Contains(Class));

            //add a turma ao ano escolhido
            if(!hasClass)
            Program.Anos.Find(y => y.year == year).CLasses.Add(cl);
            else
            {
                MessageBox.Show("ERROR", "Class already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
                   
        }


    }
}
