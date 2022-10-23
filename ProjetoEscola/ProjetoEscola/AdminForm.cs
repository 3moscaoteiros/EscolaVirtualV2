﻿using System;
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

            #region add all classes to tbStudent cbb
            Program.Anos.ForEach(y => y.CLasses.ForEach(c => cbbClassStudent.Items.Add(c.Name)));
            #endregion

            #region update requests List
            //string request = "";


            ////students
            //List<Student> RequestStudents= Program.Anos.SelectMany(y => y.CLasses.ToList().SelectMany(c=>c.students.Where(s=>s.Request==true))).ToList();

            //foreach(Student st in RequestStudents)
            //{
            //    //where to store the request item name?
            //    request = $"id:{st.ID},";
            //    lstRequest.Items.Add(request);
            //}

            ////teachers

            //Program.Anos.ForEach(y => y.subjects.ForEach(s => 
            //{
            //    if (s.teacher.Request == true)
            //    {
            //        //where to store the request item name?
            //        request = $"id:{s.teacher.ID},";
            //        lstRequest.Items.Add(request);
            //    }
            //}));

           

            #endregion

            #region update subjects in TeacherTab

            Program.Anos.ForEach(y => y.subjects.ForEach(s =>
            {
                if(!lstTeacherSubjects.Items.Contains(s.Name))
                lstTeacherSubjects.Items.Add(s.Name);

            }));

            #endregion
        }///////////

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Visible = true;

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

        private void txtNumStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNumTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtChooseYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtPINStudnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
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
                bool exists = false;
                string YearWithTheClass = "";
                #endregion

                #region errors
                if (name == "" || num == "" || nif == "" || adress == "" || contact == "" || cbbClassStudent.Items==null || money == "" || pin == "")
                {
                    MessageBox.Show("Information missing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region check if exists
                //search in list if student exists

                Program.Anos.ForEach(y => y.CLasses.ForEach(c => c.students.ForEach(s =>
                {
                    if (s.ID == num || s.NIF.ToString().Trim() == nif)
                        exists = true;

                })));
             

                //error
                if (exists)
                {
                    
                    txtNumStudent.Text = "";
                    txtNIFStudent.Text = "";


                    MessageBox.Show("User already exists!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region ADD STUDENT TO CLASS AND THEN YEAR

                Student student = new Student()
                {
                    Name = name,
                    Adress = adress,
                    EMAIL = contact,
                    NIF = Convert.ToInt32(nif),
                    ID = $"s{num}",
                    PIN = pin,
                    Request = false

                };

                //cycle list years to see which is the year that has the student's class
                Program.Anos.ForEach(y => y.CLasses.ForEach(c =>
                {
                    if (c.Name == Class)
                        YearWithTheClass = y.year;
                }));
               

                //lambda to add the student
                Program.Anos.Where(y => y.year == YearWithTheClass).FirstOrDefault().CLasses.Where(c=>c.Name==Class).FirstOrDefault().students.Add(student);
                #endregion

                #region reset textboxes
                txtNameStudent.Text = "";
                txtNumStudent.Text = "";
                txtNIFStudent.Text = "";
                txtAdressStudent.Text = "";
                txtContactStudent.Text = "";
                cbbClassStudent.SelectedItem = null;
                txtBalanceStudent.Text = "";
                txtPINStudnet.Text="";
                #endregion

              

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)//////////////
        {
            try
            {
                #region variables
                string name = txtNameTeacher.Text.Trim();
                string num = txtNumTeacher.Text.Trim();
                string nif = txtNIFTeacher.Text.Trim(); ;
                string adress = txtAdressTeacher.Text.Trim();
                string contact = txtContactTeacher.Text.Trim();
                string pin = txtPINTeacher.Text.Trim();
                bool exists = false;
                #endregion

                #region errors
                if (name == "" || num == "" || nif == "" || adress == "" || contact == "" || pin == "" || lstTeacherSubjects.SelectedItems==null)
                {
                    MessageBox.Show("Information missing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region check if exists
                //search in list if teacher exists

                Program.Anos.ForEach(y => y.subjects.ForEach(s=>
                {
                    if (s.teacher.ID == num || s.teacher.NIF.ToString().Trim() == nif)
                        exists = true;

                }));


                //error
                if (exists)
                {

                    txtNumTeacher.Text = "";
                    txtNIFTeacher.Text = "";


                    MessageBox.Show("User already exists!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region ADD TEACHER TO SUBJECTS AND YEARS

                Teacher teacher = new Teacher()
                {
                    Name = name,
                    Adress = adress,
                    EMAIL = contact,
                    NIF = Convert.ToInt32(nif),
                    ID = $"t{num}",
                    PIN = pin,
                    Request = false

                };

                //cycle all selectedSubjects in listBox to add the teacher to all of them

                //selected subjects in ListBox
                foreach (string ss in lstTeacherSubjects.SelectedItems)
                {
                    //existing subjects
                    Program.Anos.ForEach(y1 => y1.subjects.ForEach(s =>
                    {
                        //lambda to add the teacher:
                        if (ss == s.Name)
                        Program.Anos.Where(y2 => y2.subjects.Where(s2 => s2.Name == ss).FirstOrDefault().teacher==teacher);
                        
                    }));
                }

                #endregion

                #region reset textboxes
                txtNameTeacher.Text = "";
                txtNumTeacher.Text = "";
                txtNIFTeacher.Text = "";
                txtAdressTeacher.Text = "";
                txtContactTeacher.Text = "";
                txtPINTeacher.Text = "";
                #endregion
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)////create subjects missing
        {
            try
            {
                string year = txtChooseYear.Text;
                string Class = txtCreateClass.Text;

                #region errors 
                if (year.Trim() == "" || Class.Trim() == "")
                {
                    MessageBox.Show("Info missing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToInt32(year.Trim()) < 5 || Convert.ToInt32(year.Trim()) > 12)
                {
                    MessageBox.Show("Wrong year", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                Class cl = new Class();
                cl.Name = Class;
                //why do I need class id?

                #region verify if class already exists
                //aux variable
                bool hasClass = Program.Anos.Find(y => y.year == year).CLasses.Any(c => c.Name.Contains(Class));

                
                if (hasClass==false)
                {

                    //verify if year exists
                    bool hasYear = Program.Anos.Any(y => y.year == year);

                    if (hasYear)
                    {
                        //add the class to the chosen year
                        Program.Anos.Find(y => y.year == year).CLasses.Add(cl);

                        #region add subjects
                        switch()
                        {








                        }
                        #endregion

                        //update cbb
                        cbbClassStudent.Items.Add(cl.Name.ToString());
                        MessageBox.Show("Class successfully created", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtChooseYear.Text = "";
                        txtCreateClass.Text = "";

                    }
                    else
                    {
                        //create year and class
                        Year createdYear = new Year() { year = year };
                        createdYear.CLasses.Add(cl);
                        Program.Anos.Add(createdYear);

                        #region add subjects

                        #endregion


                        MessageBox.Show("Class successfully created", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtChooseYear.Text = "";
                        txtCreateClass.Text = "";
                    }
                   
                }
                else
                {
                    MessageBox.Show("Class already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
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

        private void btnRequest_Click(object sender, EventArgs e)//////////////////////
        {
            //foreach (string i in lstRequest.SelectedItems)
            //{
            //    string num = i.Split(':')[1].Split(' ')[0];
            //    string firstC = num.ToLower().Substring(0, 1);

            //    //student
            //    //if(firstC == "s")
            //    //{
            //    //    //Program.Anos.Where(y => y.CLasses.Where(c => c.students.
                     



            //    //}
            //    //teacher
            //    //if (firstC == "t")
            //    //{




            //    //}
            //    //remove from lst

            //}
        }
    }
}
