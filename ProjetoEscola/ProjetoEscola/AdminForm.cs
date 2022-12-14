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
    public partial class AdminForm : Form
    {
        Teacher RequestTeacher = new Teacher();
        Student RequestStudent = new Student();

        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                // add all classes to tbStudent cbb
                Program.Anos.ForEach(y => y.CLasses.ForEach(c => cbbClassStudent.Items.Add(c.Name)));
            

                //update requests List
                string request = "";
                bool exists = false;

            
                //students
                List<Student> RequestStudents = Program.Anos.SelectMany(y => y.CLasses.ToList().SelectMany(c => c.students.Where(s => s.Request == true))).ToList();

                foreach (Student st in RequestStudents)
                {
                        if (st.Request == true && exists == false)
                        {
                            request = $"id:{st.ID},{st.RequestInfo}:{st.RequestChangeInfo}";
                            lstRequest.Items.Add(request);
                            exists = true;
                        }
                    
                }


                //teachers
                Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                {
                    
                    if (s.teacher!=null)
                    {
                        if (s.teacher.Request == true && exists == false)
                        {
                                request = $"id:{s.teacher.ID},{s.teacher.RequestInfo}:{s.teacher.RequestChangeInfo}";
                                lstRequest.Items.Add(request);
                                exists = true;
                        }
                    }
                }));

                
                

                //update subjects in TeacherTab

                Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                {
                    if (!lstTeacherSubjects.Items.Contains(s.Name))
                        lstTeacherSubjects.Items.Add(s.Name);

                }));
                

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

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

        private void txtPINTeacher_KeyPress(object sender, KeyPressEventArgs e)
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
                string num = $"s{txtNumStudent.Text.Trim()}";
                string nif = txtNIFStudent.Text.Trim(); ;
                string adress = txtAdressStudent.Text.Trim();
                string contact = txtContactStudent.Text.Trim();
                string Class = cbbClassStudent.SelectedItem.ToString();
                int money = Convert.ToInt32(txtBalanceStudent.Text);
                string pin = txtPINStudnet.Text.Trim();
                bool exists = false;
                string YearWithTheClass = "";
                #endregion

                #region errors
                if (name == "" || num == "" || nif == "" || adress == "" || contact == "" || cbbClassStudent.Items==null || money < 0 || pin == "" || num=="0000")
                {
                    MessageBox.Show("Information missing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nif.Length != 9)
                {
                    MessageBox.Show("Please insert 9 digits at NIF", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pin.Length != 5)
                {
                    MessageBox.Show("Please insert 5 digits at PIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (num == "0000")
                {
                    MessageBox.Show("Invalid number , please try again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumStudent.Focus();
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
                    ID = num,
                    PIN = pin,
                    Request = false,
                    Balance = money,
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

                MessageBox.Show("Student successfully created", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                string name = txtNameTeacher.Text.Trim();
                string num = $"t{txtNumTeacher.Text.Trim()}";
                string nif = txtNIFTeacher.Text.Trim(); ;
                string adress = txtAdressTeacher.Text.Trim();
                string contact = txtContactTeacher.Text.Trim();
                string pin = txtPINTeacher.Text.Trim();
                bool exists = false;
                bool subjectHasTeacher = false;

                //errors
                if (name == "" || num == "" || nif == "" || adress == "" || contact == "" || pin == "")
                {
                    MessageBox.Show("Information missing", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (num == "0000")
                {
                    MessageBox.Show("Invalid number , please try again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumStudent.Focus();
                    return;
                }
                if (lstTeacherSubjects.SelectedItem == null)
                {
                    MessageBox.Show("Please , select a subject!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (nif.Length != 9)
                {
                    MessageBox.Show("Attention , the NIF must have only nine digits!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (pin.Length != 5)
                {
                    MessageBox.Show("Attention , the PIN must have only five digits!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                //check if exists
                Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                {
                    //if the suject has teacher(to avoid looping new created subjects)
                  if (s.teacher != null)
                    {
                  if (s.teacher.ID == num || s.teacher.NIF.ToString().Trim() == nif)
                            exists = true;
                    }

                }));


                //error
                if (exists)
                {

                    txtNumTeacher.Text = "";
                    txtNIFTeacher.Text = "";


                    MessageBox.Show("User already exists!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               

                //ADD TEACHER TO SUBJECTS AND YEARS


                //selected subject in ListBox
                string selectedSubject = lstTeacherSubjects.SelectedItem.ToString();

                Subject subject = new Subject(){ Name = selectedSubject };

                Teacher teacher = new Teacher()
                {
                    Name = name,
                    Adress = adress,
                    EMAIL = contact,
                    NIF = Convert.ToInt32(nif),
                    ID = num,
                    PIN = pin,
                    Request = false,
                };


                //Add the teacher

                Program.Anos.ForEach(y =>
                {
                    foreach (Subject s in y.subjects)
                    {

                        if (s.Name == selectedSubject)
                        {
                            if (s.teacher != null)
                            {
                                subjectHasTeacher = true;
                                break;
                            }

                            s.teacher = teacher;
                            break;
                        }

                    }

                });
                

                if (!subjectHasTeacher)
                {
                   

                    #region reset textboxes
                    txtNameTeacher.Text = "";
                    txtNumTeacher.Text = "";
                    txtNIFTeacher.Text = "";
                    txtAdressTeacher.Text = "";
                    txtContactTeacher.Text = "";
                    txtPINTeacher.Text = "";
                    lstTeacherSubjects.SelectedItem = null;
                    #endregion

                    MessageBox.Show("Teacher successfully created", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Subject already has teacher, please select a different one", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            try
            {
                string year = txtChooseYear.Text;
                string Class = txtCreateClass.Text;
                bool hasClass = false;

                //errors 
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
                

                Class cl = new Class();
                cl.Name = $"{year}:{Class.ToUpper()}";

                //verify if class already exists
                        Program.Anos.ForEach(y => y.CLasses.ForEach(c =>
                        {
                            if (c.Name == $"{year}:{txtCreateClass.Text}")
                            hasClass = true;

                        }));
                

                if (hasClass==false)
                {

                    //verify if year exists
                    bool hasYear = Program.Anos.Any(y => y.year == year);

                    if (hasYear)
                    {
                        //add the class to the chosen year
                        Program.Anos.Find(y => y.year == year).CLasses.Add(cl);

                        
                        //update cbb
                        cbbClassStudent.Items.Add(cl.Name.ToString());

                    }
                    else
                    {
                        //create year and class
                        Year createdYear = new Year() { year = year };
                        createdYear.CLasses.Add(cl);
                        Program.Anos.Add(createdYear);

                        //update cbb
                        cbbClassStudent.Items.Add(cl.Name.ToString());
                    }

                    //add subjects
                    switch (year)
                    {
                        case "7":
                        case "8":
                        case "9":

                            Program.Anos.Find(y => y.year == year).subjects.AddRange(new Subject[]
                            {
                                new Subject() { Name = "Português"} ,
                                new Subject() { Name = "Matemática"} ,
                                new Subject() { Name = "Inglês"} ,
                                new Subject() { Name = "Ciências"} ,
                                new Subject() { Name = "Educação Física" } ,
                                new Subject() { Name = "Fisico-quimica"} }
                            );

                            break;

                        case "10":
                        case "11":
                        case "12":

                            Program.Anos.Find(y => y.year == year).subjects.AddRange(new Subject[]
                            {
                                new Subject() { Name = "Português"} ,
                                new Subject() { Name = "Matemática"} ,
                                new Subject() { Name = "Inglês"} ,
                                new Subject() { Name = "Programação e Sistemas de Informação"} ,
                                new Subject() { Name = "Educação Física" } ,
                                new Subject() { Name = "Arquitetura de Computadores" } ,
                                new Subject() { Name = "Sistemas Operativos" } ,
                                new Subject() { Name = "Fisico-quimica" } ,
                                new Subject() { Name = "Redes de Comunicação"} }
                            );

                            break;

                    }
                    

                    //update subjects in TeacherTab

                    Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                    {
                        if (!lstTeacherSubjects.Items.Contains(s.Name))
                            lstTeacherSubjects.Items.Add(s.Name);

                    }));

                    

                    //messagebox show & texboxes reset
                    MessageBox.Show("Class successfully created", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChooseYear.Text = "";
                    txtCreateClass.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Class already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void btnRequest_Click(object sender, EventArgs e)
        {

            try
            {
                
                //search which user wants the request

                //students
                Program.Anos.ToList().ForEach(y => y.CLasses.ToList().ForEach(c => c.students.ForEach(s =>
                {
                    if (s.Request)
                        RequestStudent = s;
                })));

                //teachers
                if (RequestTeacher.ID == null)
                {
                    Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                    {
                        if (s.teacher != null)
                        {
                            if (s.teacher.Request)
                                RequestTeacher = s.teacher;
                        }
                    }));
                }
                


                    string i = lstRequest.SelectedItem.ToString();
                    string num = i.Trim().Split(',')[0].Split(':')[1];
                    string info = i.Trim().Split(':')[1].Split(',')[1];
                    string firstC = num.ToLower().Substring(0, 1);
                    

                    //update student
                    if (firstC == "s")
                    {

                        Program.Anos.ForEach(y => y.CLasses.ForEach(c => c.students.ForEach(s =>
                        {
                            if (s.ID == num)
                            {

                                switch(info)
                                {
                                    case "Name":RequestStudent.Name = RequestStudent.RequestChangeInfo;
                                        break;
                                    case "Num":
                                        RequestStudent.ID = RequestStudent.RequestChangeInfo;
                                        break;
                                    case "NIF":
                                        RequestStudent.NIF = Convert.ToInt32(RequestStudent.RequestChangeInfo);
                                        break;
                                    case "Adress":
                                        RequestStudent.Adress = RequestStudent.RequestChangeInfo;
                                        break;
                                    case "Contact":
                                        RequestStudent.EMAIL = RequestStudent.RequestChangeInfo;
                                        break;


                                }


                                s.Request = false;
                                s.RequestInfo = null;
                            }
                        })));
                    }
                    //update teacher
                    if (firstC == "t")
                    {
                        Program.Anos.ForEach(y => y.subjects.ForEach(s =>
                        {
                            if (s.teacher.ID == num)
                            {

                                switch (info)
                                {
                                    case "Name":
                                        RequestTeacher.Name = RequestTeacher.RequestChangeInfo;
                                        break;
                                    case "Num":
                                        RequestTeacher.ID = RequestTeacher.RequestChangeInfo;
                                        break;
                                    case "NIF":
                                        RequestTeacher.NIF = Convert.ToInt32(RequestTeacher.RequestChangeInfo);
                                        break;
                                    case "Adress":
                                        RequestTeacher.Adress = RequestTeacher.RequestChangeInfo;
                                        break;
                                    case "Contact":
                                        RequestTeacher.EMAIL = RequestTeacher.RequestChangeInfo;
                                        break;


                                }


                                s.teacher.Request = false;
                                s.teacher.RequestInfo = null;
                            }
                        }));

                    }

                    //remove from lst

                    lstRequest.Items.Remove(i);

                    MessageBox.Show("Request accepted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            //messageBox tip to create classes

            if (!Program.Anos.Any(y => y.CLasses.Any()))
            {
                tbAdmin.SelectedIndex = 2;
                MessageBox.Show("No classes found, please create a class", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private void txtNIFStudent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
