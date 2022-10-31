namespace ProjetoEscola
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.lblStudentSubjects = new System.Windows.Forms.Label();
            this.txtStudentAdress = new System.Windows.Forms.TextBox();
            this.lblStudentAdress = new System.Windows.Forms.Label();
            this.txtStudentContact = new System.Windows.Forms.TextBox();
            this.lblStudentContact = new System.Windows.Forms.Label();
            this.btnChangeDataStudent = new System.Windows.Forms.Button();
            this.txtStudentNIF = new System.Windows.Forms.TextBox();
            this.lblStudentNIF = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.txtStudentYear = new System.Windows.Forms.TextBox();
            this.lblStudentYear = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtdesign1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClassStdnt = new System.Windows.Forms.Label();
            this.txtClassStdnt = new System.Windows.Forms.TextBox();
            this.cbStudentSubjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStudentSubjects
            // 
            this.lblStudentSubjects.AutoSize = true;
            this.lblStudentSubjects.Location = new System.Drawing.Point(14, 138);
            this.lblStudentSubjects.Name = "lblStudentSubjects";
            this.lblStudentSubjects.Size = new System.Drawing.Size(51, 13);
            this.lblStudentSubjects.TabIndex = 65;
            this.lblStudentSubjects.Text = "Subjects:";
            // 
            // txtStudentAdress
            // 
            this.txtStudentAdress.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentAdress.Location = new System.Drawing.Point(67, 161);
            this.txtStudentAdress.Name = "txtStudentAdress";
            this.txtStudentAdress.ReadOnly = true;
            this.txtStudentAdress.Size = new System.Drawing.Size(158, 20);
            this.txtStudentAdress.TabIndex = 64;
            // 
            // lblStudentAdress
            // 
            this.lblStudentAdress.AutoSize = true;
            this.lblStudentAdress.Location = new System.Drawing.Point(21, 164);
            this.lblStudentAdress.Name = "lblStudentAdress";
            this.lblStudentAdress.Size = new System.Drawing.Size(42, 13);
            this.lblStudentAdress.TabIndex = 63;
            this.lblStudentAdress.Text = "Adress:";
            // 
            // txtStudentContact
            // 
            this.txtStudentContact.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentContact.Location = new System.Drawing.Point(67, 186);
            this.txtStudentContact.Name = "txtStudentContact";
            this.txtStudentContact.ReadOnly = true;
            this.txtStudentContact.Size = new System.Drawing.Size(87, 20);
            this.txtStudentContact.TabIndex = 62;
            // 
            // lblStudentContact
            // 
            this.lblStudentContact.AutoSize = true;
            this.lblStudentContact.Location = new System.Drawing.Point(18, 189);
            this.lblStudentContact.Name = "lblStudentContact";
            this.lblStudentContact.Size = new System.Drawing.Size(47, 13);
            this.lblStudentContact.TabIndex = 61;
            this.lblStudentContact.Text = "Contact:";
            // 
            // btnChangeDataStudent
            // 
            this.btnChangeDataStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDataStudent.Location = new System.Drawing.Point(67, 244);
            this.btnChangeDataStudent.Name = "btnChangeDataStudent";
            this.btnChangeDataStudent.Size = new System.Drawing.Size(129, 35);
            this.btnChangeDataStudent.TabIndex = 60;
            this.btnChangeDataStudent.Text = "Change data";
            this.btnChangeDataStudent.UseVisualStyleBackColor = true;
            this.btnChangeDataStudent.Click += new System.EventHandler(this.btnChangeDataStudent_Click);
            // 
            // txtStudentNIF
            // 
            this.txtStudentNIF.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentNIF.Location = new System.Drawing.Point(67, 84);
            this.txtStudentNIF.Name = "txtStudentNIF";
            this.txtStudentNIF.ReadOnly = true;
            this.txtStudentNIF.Size = new System.Drawing.Size(87, 20);
            this.txtStudentNIF.TabIndex = 59;
            // 
            // lblStudentNIF
            // 
            this.lblStudentNIF.AutoSize = true;
            this.lblStudentNIF.Location = new System.Drawing.Point(35, 85);
            this.lblStudentNIF.Name = "lblStudentNIF";
            this.lblStudentNIF.Size = new System.Drawing.Size(27, 13);
            this.lblStudentNIF.TabIndex = 58;
            this.lblStudentNIF.Text = "NIF:";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(268, 93);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(247, 29);
            this.txtBalance.TabIndex = 57;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(272, 66);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(96, 25);
            this.lblBalance.TabIndex = 56;
            this.lblBalance.Text = "Balance:";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(268, 153);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(248, 29);
            this.txtDeposit.TabIndex = 55;
            this.txtDeposit.TextChanged += new System.EventHandler(this.txtDeposit_TextChanged);
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Location = new System.Drawing.Point(268, 214);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(247, 34);
            this.btnTransaction.TabIndex = 54;
            this.btnTransaction.Text = "APPLY";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(268, 125);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(168, 25);
            this.lblDeposit.TabIndex = 53;
            this.lblDeposit.Text = "Deposit amount:";
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentNum.Location = new System.Drawing.Point(67, 58);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.ReadOnly = true;
            this.txtStudentNum.Size = new System.Drawing.Size(87, 20);
            this.txtStudentNum.TabIndex = 52;
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Location = new System.Drawing.Point(32, 61);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(32, 13);
            this.lblStudentNum.TabIndex = 51;
            this.lblStudentNum.Text = "Num:";
            // 
            // txtStudentYear
            // 
            this.txtStudentYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentYear.Location = new System.Drawing.Point(67, 109);
            this.txtStudentYear.Name = "txtStudentYear";
            this.txtStudentYear.ReadOnly = true;
            this.txtStudentYear.Size = new System.Drawing.Size(42, 20);
            this.txtStudentYear.TabIndex = 50;
            // 
            // lblStudentYear
            // 
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Location = new System.Drawing.Point(30, 112);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(32, 13);
            this.lblStudentYear.TabIndex = 49;
            this.lblStudentYear.Text = "Year:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentName.Location = new System.Drawing.Point(67, 33);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(158, 20);
            this.txtStudentName.TabIndex = 48;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(27, 36);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(38, 13);
            this.lblStudentName.TabIndex = 47;
            this.lblStudentName.Text = "Name:";
            // 
            // txtdesign1
            // 
            this.txtdesign1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtdesign1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesign1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdesign1.Location = new System.Drawing.Point(238, -28);
            this.txtdesign1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdesign1.Multiline = true;
            this.txtdesign1.Name = "txtdesign1";
            this.txtdesign1.ReadOnly = true;
            this.txtdesign1.Size = new System.Drawing.Size(8, 347);
            this.txtdesign1.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 84;
            this.label1.Text = "School Card";
            // 
            // lblClassStdnt
            // 
            this.lblClassStdnt.AutoSize = true;
            this.lblClassStdnt.Location = new System.Drawing.Point(27, 214);
            this.lblClassStdnt.Name = "lblClassStdnt";
            this.lblClassStdnt.Size = new System.Drawing.Size(35, 13);
            this.lblClassStdnt.TabIndex = 85;
            this.lblClassStdnt.Text = "Class:";
            // 
            // txtClassStdnt
            // 
            this.txtClassStdnt.BackColor = System.Drawing.SystemColors.Control;
            this.txtClassStdnt.Location = new System.Drawing.Point(67, 211);
            this.txtClassStdnt.Name = "txtClassStdnt";
            this.txtClassStdnt.ReadOnly = true;
            this.txtClassStdnt.Size = new System.Drawing.Size(87, 20);
            this.txtClassStdnt.TabIndex = 86;
            // 
            // cbStudentSubjects
            // 
            this.cbStudentSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentSubjects.FormattingEnabled = true;
            this.cbStudentSubjects.Location = new System.Drawing.Point(67, 132);
            this.cbStudentSubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStudentSubjects.Name = "cbStudentSubjects";
            this.cbStudentSubjects.Size = new System.Drawing.Size(158, 21);
            this.cbStudentSubjects.TabIndex = 87;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(542, 289);
            this.Controls.Add(this.cbStudentSubjects);
            this.Controls.Add(this.txtClassStdnt);
            this.Controls.Add(this.lblClassStdnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdesign1);
            this.Controls.Add(this.lblStudentSubjects);
            this.Controls.Add(this.txtStudentAdress);
            this.Controls.Add(this.lblStudentAdress);
            this.Controls.Add(this.txtStudentContact);
            this.Controls.Add(this.lblStudentContact);
            this.Controls.Add(this.btnChangeDataStudent);
            this.Controls.Add(this.txtStudentNIF);
            this.Controls.Add(this.lblStudentNIF);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtStudentNum);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.txtStudentYear);
            this.Controls.Add(this.lblStudentYear);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudentSubjects;
        private System.Windows.Forms.TextBox txtStudentAdress;
        private System.Windows.Forms.Label lblStudentAdress;
        private System.Windows.Forms.TextBox txtStudentContact;
        private System.Windows.Forms.Label lblStudentContact;
        private System.Windows.Forms.Button btnChangeDataStudent;
        private System.Windows.Forms.TextBox txtStudentNIF;
        private System.Windows.Forms.Label lblStudentNIF;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.TextBox txtStudentYear;
        private System.Windows.Forms.Label lblStudentYear;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtdesign1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClassStdnt;
        private System.Windows.Forms.TextBox txtClassStdnt;
        private System.Windows.Forms.ComboBox cbStudentSubjects;
    }
}