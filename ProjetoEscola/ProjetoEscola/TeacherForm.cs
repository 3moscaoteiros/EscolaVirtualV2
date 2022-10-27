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
    public partial class TeacherForm : Form
    {
        Teacher LoginTeacher = new Teacher();
        bool hasStd = false;

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            #region search which teacher has login state

                Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                {
                    if (s.teacher.LoginState)
                        LoginTeacher = s.teacher;
                }));

            #endregion

            #region fill up all info
            txtTeacherName.Text= LoginTeacher.Name;
            txtTeacherNum.Text = LoginTeacher.ID;
            txtTeacherNIF.Text = LoginTeacher.NIF.ToString();
            txtTeacherContact.Text = LoginTeacher.EMAIL;
            txtTeacherAdress.Text = LoginTeacher.Adress;
            #endregion

            #region update subject
            txtTeacherSubject.Text = LoginTeacher.subject.Name;
            #endregion

            #region find teacher years
            List<Year> teacherYears = new List<Year>();
            //find in what years are the teacher's subject
            Program.Anos.ForEach(y => y.subjects.ForEach(s =>
            {
                if (s.Name == LoginTeacher.subject.Name)
                    teacherYears.Add(y);
            }));
            #endregion

            #region add years to cbb
            teacherYears.ForEach(y =>
            {
                cbTeacherYears.Items.Add(y.year);

            });
            #endregion


            #region update students lst
            Program.Anos.ForEach(y =>
            {
                teacherYears.ForEach(ty =>
                {
                    //find teachers years
                    if(y.year==ty.year)
                    {
                        //find teacher students
                        y.CLasses.ForEach(c => c.students.ForEach(s =>
                        {
                            //verify if already exists in lst
                            if (lstStudentGrade.Items.Contains($"{s.Name},{s.ID}"))
                            {
                                //add to listBox
                                lstStudentGrade.Items.Add($"{s.Name},{s.ID}");
                                hasStd = true;
                            }
                        }));
 
                    }

                });

            });


            #endregion

            //List<Student> students = (List<Student>)Program.Anos.SelectMany(a => a.CLasses.SelectMany(c => c.students.SelectMany(s => s.grades.Where(b => b.Subject.teacher.ID == txtTeacherNum.Text))));

            //if (students.Count >= 0)
            //{

            //    for (int i = 0; i < students.Count; i++)
            //    {
            //        lstStudentGrade.Items.Add(students[i].ToString());
            //    }
            //}
            //else
            //    MessageBox.Show("No students found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        #region KeyPressEvents

        private void txtSelectGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Visible = true;
        }

        private void lblChangeDataTeacher_Click(object sender, EventArgs e)
        {
            Hide();
            RequestForm request = new RequestForm();
            request.Visible = true;
        }

        private void TeacherForm_Shown(object sender, EventArgs e)
        {
            if (hasStd == false)
            {
                MessageBox.Show("No students, please tell the administration to create", "Teacher Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApplyGrades_Click(object sender, EventArgs e)
        {
            if(txtSelectGrade.Text.Trim() =="" || lstStudentGrade.SelectedItem==null)
            {
                MessageBox.Show("Information missing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
