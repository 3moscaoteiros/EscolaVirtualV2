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
        Year ano = new Year();
        public TeacherForm()
        {
            InitializeComponent();
        }



        private void TeacherForm_Load(object sender, EventArgs e)
        {

            //List<Student> students = (List<Student>)Program.Anos.SelectMany(a => a.CLasses.SelectMany(c => c.students.SelectMany(s => s.grades.Where(b => b.Subject.teacher.ID == txtTeacherNum.Text))));

            //for (int i = 0; i < students.Count; i++)
            //{
            //    lstStudentGrade.Items.Add(students[i].ToString());
            //}

        }
        #region KeyPressEvents

        private void txtSelectGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar =='.' || e.KeyChar == 8)
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

        }
    }
}
