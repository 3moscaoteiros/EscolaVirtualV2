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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtLoginNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginNum.Text != "" || txtLoginPassword.Text != "")
            {
                if (txtLoginNum.Text == "00000" && txtLoginPassword.Text == "00000")
                {
                    Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                   
                }
                else 
                {
                    MessageBox.Show("Wrong information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
                
            }
            else
                MessageBox.Show("Missing information!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
