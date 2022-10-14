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
        public AdminForm()
        {
            InitializeComponent();
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            #region Disable Controls

            txtCreateBalance.Visible = false;
            btnCreateAcc.Enabled = false;
            lstCreateSubjects.Visible = false;
            lstCreateYears.Visible = false;
            lblCreateYear.Visible = false;
            lblbCreateSubject.Visible = false;
            cbbCreateClass.Visible = false;

            #endregion
        }

        #region KeyPressEvents
        private void txtCreateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }


        private void txtCreateNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCreateContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txtCreateBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion

        private void cbCreateS_T_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCreateS_T.SelectedItem.ToString()=="Student")
            {
                txtCreateBalance.Visible = true;
                cbbCreateClass.Visible = true;

            }
            else
            {
                lblCreateYear.Visible = true;
                lblbCreateSubject.Visible = true;
                lstCreateYears.Visible = true;
                lstCreateSubjects.Visible = true;
            }
          
        }
    }
}
