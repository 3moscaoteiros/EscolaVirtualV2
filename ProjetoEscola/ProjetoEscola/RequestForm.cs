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
    public partial class RequestForm : Form
    {
        Teacher LoginTeacher = new Teacher();
        Student LoginStudent = new Student();

        public RequestForm()
        {
            InitializeComponent();
            
        }

        private void Request_Load(object sender, EventArgs e)
        {
            try
            {
                #region search which user has login state
                //students
                Program.Anos.ToList().ForEach(y => y.CLasses.ToList().ForEach(c => c.students.ForEach(s =>
                {
                    if (s.LoginState)
                        LoginStudent = s;
                })));

                //teachers
                if (LoginStudent.ID == null)
                {
                    Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                    {
                        if (s.teacher != null)
                        {
                            if (s.teacher.LoginState)
                                LoginTeacher = s.teacher;
                        }
                    }));
                }
                #endregion
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            bool error = false;
            try
            {
                #region errors
                if(txtRequest.Text.Trim()=="" || cbbRequest.SelectedItem==null)
                {
                    MessageBox.Show("Information missing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(cbbRequest.SelectedItem.ToString()=="Num" && txtRequest.Text.Length!=5)
                {
                    MessageBox.Show("Invalid num/id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                #endregion

                #region change properties
                //if student
                if (LoginStudent != null)
                {
                    switch (cbbRequest.SelectedItem.ToString())
                    {
                        case "Name": LoginStudent.Name = txtRequest.Text; break;
                        case "Num": LoginStudent.ID = txtRequest.Text; break;
                        case "NIF": LoginStudent.NIF = Convert.ToInt32(txtRequest.Text); break;
                        case "Adress": LoginStudent.Adress = txtRequest.Text; break;
                        case "Contact": LoginStudent.EMAIL = txtRequest.Text; break;
                        default: MessageBox.Show("Invalid selected item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); break;

                    }
                    
                }
                //if teacher
                if(LoginTeacher != null)
                {
                    switch (cbbRequest.SelectedItem.ToString())
                    {
                        case "Name":
                             if(txtRequest.Text.Any(c => !char.IsLetter(c)))
                                {
                                    MessageBox.Show("Please insert only letters", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtRequest.Text = "";
                                    error = true;
                                    break;
                                }

                            //add request state and requestInfo to the Teacher
                            LoginTeacher.Request = true;
                            LoginTeacher.RequestInfo = "Name";
                            LoginTeacher.RequestChangeInfo=txtRequest.Text;
                            break;
                        case "Num":
                            if (txtRequest.Text.Any(c => !char.IsDigit(c)))
                            {
                                MessageBox.Show("Please insert only numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtRequest.Text = "";
                                error = true;
                                break;
                            }

                            //add request state and requestInfo to the Teacher
                            LoginTeacher.Request = true;
                            LoginTeacher.RequestInfo = "Num";
                            LoginTeacher.RequestChangeInfo = txtRequest.Text;

                            break;
                        case "NIF":
                            if (txtRequest.Text.Any(c => !char.IsDigit(c)))
                            {
                                MessageBox.Show("Please insert only numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtRequest.Text = "";
                                error = true;
                                break;
                            }

                            //add request state and requestInfo to the Teacher
                            LoginTeacher.Request = true;
                            LoginTeacher.RequestInfo = "NIF";
                            LoginTeacher.RequestChangeInfo = txtRequest.Text;

                            break;
                        case "Adress":
                            //add request state and requestInfo to the Teacher
                            LoginTeacher.Request = true;
                            LoginTeacher.RequestInfo = "Adress";
                            LoginTeacher.RequestChangeInfo = txtRequest.Text;

                            break;
                        case "Contact":
                            //add request state and requestInfo to the Teacher
                            LoginTeacher.Request = true;
                            LoginTeacher.RequestInfo = "Contact";
                            LoginTeacher.RequestChangeInfo = txtRequest.Text;

                            break;

                        default: MessageBox.Show("Invalid selected item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); break;

                    }
                  
                }
                #endregion

                if (error == false)
                {
                    MessageBox.Show("Request has been sent to the admin", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format, Please reinsert a valid text", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid info, Please reinsert a valid one", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void RequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(LoginStudent.ID != null)
            {
                StudentForm student = new StudentForm();
                student.Visible = true;
            }
            else
            {
                TeacherForm teacher = new TeacherForm();
                teacher.Visible = true;
            }
        }
    }
} 
