﻿using School_DLL;
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
          //cbbClasses.Items.
        }

        private void cbbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
