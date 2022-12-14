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
        Teacher LoggedTeacher = new Teacher();
        bool hasStd = false;

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            try
            {
                //search which teacher has login state

                Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                {
                    if (s.teacher != null)
                    {
                        if (s.teacher.LoginState)
                            LoggedTeacher = s.teacher;
                    }
                }));


                //fill up all info
                txtTeacherName.Text = LoggedTeacher.Name;
                txtTeacherNum.Text = LoggedTeacher.ID;
                txtTeacherNIF.Text = LoggedTeacher.NIF.ToString();
                txtTeacherContact.Text = LoggedTeacher.EMAIL;
                txtTeacherAdress.Text = LoggedTeacher.Adress;
                

                //update subject

                txtTeacherSubject.Text =  Program.Anos.SelectMany(y => y.subjects.Where(s => s.teacher != null && s.teacher.ID == LoggedTeacher.ID)).FirstOrDefault().Name;



                //find teacher years
                List<Year> teacherYears = new List<Year>();

                //find in what years are the teacher's subject
                Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                {
                    if (s.Name == txtTeacherSubject.Text)
                        teacherYears.Add(y);
                }));

                //add years to cbb
                teacherYears.ForEach(y =>
                {
                    if (!cbTeacherYears.Items.Contains(y.year))
                        cbTeacherYears.Items.Add(y.year);

                });

                //update students lst
                Program.Anos.ForEach(y =>
                {
                    teacherYears.ForEach(ty =>
                    {
                    //find teachers years
                    if (y.year == ty.year)
                        {
                            //find teacher classes and students
                            y.CLasses.ForEach(c => c.students.ForEach(s =>
                                {
                                    //if exists grades in the student

                                    if (s.grades.Count!=0)
                                    {
                                        var grade = s.grades.Find(g => g.Subject.Name == txtTeacherSubject.Text).Val;

                                        //verify if already exists in lst(avoid repeating the same student)
                                        if (!lstStudentGrade.Items.Contains($"{s.Name},{s.ID}:{grade}"))
                                        {
                                            //add to listBox
                                            lstStudentGrade.Items.Add($"{s.Name},{s.ID}:{grade}");
                                            hasStd = true;
                                        }
                                    }
                                    else
                                    {
                                        //verify if already exists in lst(avoid repeating the same student)
                                        if (!lstStudentGrade.Items.Contains($"{s.Name},{s.ID}"))
                                        {
                                            //add to listBox
                                            lstStudentGrade.Items.Add($"{s.Name},{s.ID}");
                                            hasStd = true;
                                        }
                                    }

                            }));

                        }

                    });

                });
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void txtSelectGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }


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

            try
            {
                if (txtSelectGrade.Text.Trim() == "")
                {
                    MessageBox.Show("Information missing, please insert a grade", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lstStudentGrade.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a student first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToDouble(txtSelectGrade.Text) < 0 || Convert.ToDouble(txtSelectGrade.Text) > 20)
                {
                    MessageBox.Show("Wrong numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                string studentString = lstStudentGrade.SelectedItem.ToString();
                string name = studentString.Split(',')[0];
                string num = studentString.Split(',')[1].Split(':')[0];
                string subject = Program.Anos.FirstOrDefault().subjects.Find(s => s.teacher.ID == LoggedTeacher.ID).Name;
                double newgrade = Convert.ToDouble(txtSelectGrade.Text);

                //find student class
                Class studentClass = new Class();
                Program.Anos.ForEach(y => y.CLasses.ForEach(c => c.students.ForEach(s =>
                {
                    //find the student 
                    if (s.ID == num)
                        studentClass = c;
                })));

                //change grade
                Program.Anos.Where(y => y.CLasses.SelectMany(c => c.students).Where(s => s.ID == num).FirstOrDefault().grades.Find(g => g.Subject.Name == subject).Val == Math.Round(newgrade, 2));

                //add the grade to the selected item string(missing)
                lstStudentGrade.Items.Insert(lstStudentGrade.SelectedIndex, $"{name},{num}:{newgrade}");
                lstStudentGrade.Items.RemoveAt(lstStudentGrade.SelectedIndex);


                MessageBox.Show("Grade changed", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSelectGrade.Text = "";
                lstStudentGrade.SelectedItem = null;
            }
            catch (Exception error)
            { 
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        
    }
}
