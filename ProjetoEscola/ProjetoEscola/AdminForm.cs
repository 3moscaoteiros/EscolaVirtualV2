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
           
            #region update classes in student
            foreach (Year Y in Program.Anos)
            {
                foreach (Class c in Y.CLasses)
                {
                    cbbClassStudent.Items.Add(c.Name);

                }
            }
            #endregion

            
            #region update years in TeacherTab
            foreach (Year y in Program.Anos)
            {
                lstTeacherYears.Items.Add(y.year);
            }
            #endregion



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
            string name = txtNameStudent.Text.Trim();
            string num = txtNumStudent.Text.Trim();
            string nif = txtNIFStudent.Text.Trim(); ;
            string adress = txtAdressStudent.Text.Trim(); 
            string contact = txtContactStudent.Text.Trim();
            string Class = cbbClassStudent.SelectedItem.ToString();
            string money = txtBalanceStudent.Text.Trim();
            string pin = txtPINStudnet.Text.Trim();

            #region errors
            if( name == "" || num == "" || nif == "" || adress == "" || contact == "" || Class == "" || money==""  || pin =="" )
            {
                MessageBox.Show("ERROR", "Information missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            string YearWithTheClass = "";
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

            //percorrer anos para ver qual é o ano que tem a turma
            foreach (Year y in Program.Anos)
            {
                foreach (Class c in y.CLasses)
                {
                    if (c.Name == Class)
                        YearWithTheClass = y.year;
                }
            }



        }

     



        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            string year = txtChooseYear.Text;
            string Class = txtCreateClass.Text;

            #region errors 
            if (year.Trim() != "" || Class.Trim()=="")
            {
                MessageBox.Show("ERROR","Info missing",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(year.Trim()) < 7 || Convert.ToInt32(year.Trim()) >12)
            {
                MessageBox.Show("ERROR", "Wrong year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            Class cl = new Class();
            cl.Name = Class;
            //why do I nedd class id?


            //aux variable
            bool hasClass = Program.Anos.Find(y => y.year == year).CLasses.Any(c => c.Name.Contains(Class));


            //verify if class already exists
            if (!hasClass)
            {
                Program.Anos.Find(y => y.year == year).CLasses.Add(cl);//add the class to the chosen year

                //update cbb
                cbbClassStudent.Items.Add(cl.Name.ToString());
            }
            else
            {
                MessageBox.Show("ERROR", "Class already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


          
                   
        }

        #region btnLeaveClickEvents
        private void btnLeaveStudent_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnLeaveTeacher_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnLeaveClasses_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnLeaveRequests_Click(object sender, EventArgs e)
        {
            
            Close();
        }
        #endregion

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Visible = true;
           
        }

        private void lstTeacherYears_SelectedIndexChanged(object sender, EventArgs e)
        {

            #region update subjects in TeacherTab

            
            //foreach (Year y in Program.Anos)
            //{
            //    foreach (Subject s in y.subjects)
            //    {
            //        lstTeacherSubjects.Items.Add(s.Name.ToString());
            //    }
            //}


            #endregion
        }
    }
}
