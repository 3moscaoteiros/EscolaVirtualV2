namespace ProjetoEscola
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.txtSelectGrade = new System.Windows.Forms.TextBox();
            this.lblGradesManagement = new System.Windows.Forms.Label();
            this.btnApplyGrades = new System.Windows.Forms.Button();
            this.txtTeacherAdress = new System.Windows.Forms.TextBox();
            this.lblTeacherAdress = new System.Windows.Forms.Label();
            this.txtTeacherContact = new System.Windows.Forms.TextBox();
            this.lblTeacherContact = new System.Windows.Forms.Label();
            this.lblChangeDataTeacher = new System.Windows.Forms.Button();
            this.lblTeacherSubject = new System.Windows.Forms.Label();
            this.cbTeacherYears = new System.Windows.Forms.ComboBox();
            this.txtTeacherNIF = new System.Windows.Forms.TextBox();
            this.lblTeacherNIF = new System.Windows.Forms.Label();
            this.txtTeacherNum = new System.Windows.Forms.TextBox();
            this.lblTeacherNum = new System.Windows.Forms.Label();
            this.lblTeacherYears = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesign = new System.Windows.Forms.TextBox();
            this.lblEnterGrade = new System.Windows.Forms.Label();
            this.lstStudentGrade = new System.Windows.Forms.ListBox();
            this.txtTeacherSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSelectGrade
            // 
            this.txtSelectGrade.Location = new System.Drawing.Point(343, 258);
            this.txtSelectGrade.Name = "txtSelectGrade";
            this.txtSelectGrade.Size = new System.Drawing.Size(68, 20);
            this.txtSelectGrade.TabIndex = 77;
            this.txtSelectGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSelectGrade_KeyPress);
            // 
            // lblGradesManagement
            // 
            this.lblGradesManagement.AutoSize = true;
            this.lblGradesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradesManagement.Location = new System.Drawing.Point(310, 15);
            this.lblGradesManagement.Name = "lblGradesManagement";
            this.lblGradesManagement.Size = new System.Drawing.Size(145, 24);
            this.lblGradesManagement.TabIndex = 76;
            this.lblGradesManagement.Text = "Manage Grades";
            // 
            // btnApplyGrades
            // 
            this.btnApplyGrades.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyGrades.Location = new System.Drawing.Point(323, 284);
            this.btnApplyGrades.Name = "btnApplyGrades";
            this.btnApplyGrades.Size = new System.Drawing.Size(104, 31);
            this.btnApplyGrades.TabIndex = 75;
            this.btnApplyGrades.Text = "Apply";
            this.btnApplyGrades.UseVisualStyleBackColor = true;
            this.btnApplyGrades.Click += new System.EventHandler(this.btnApplyGrades_Click);
            // 
            // txtTeacherAdress
            // 
            this.txtTeacherAdress.Location = new System.Drawing.Point(56, 159);
            this.txtTeacherAdress.Name = "txtTeacherAdress";
            this.txtTeacherAdress.ReadOnly = true;
            this.txtTeacherAdress.Size = new System.Drawing.Size(189, 20);
            this.txtTeacherAdress.TabIndex = 73;
            // 
            // lblTeacherAdress
            // 
            this.lblTeacherAdress.AutoSize = true;
            this.lblTeacherAdress.Location = new System.Drawing.Point(12, 162);
            this.lblTeacherAdress.Name = "lblTeacherAdress";
            this.lblTeacherAdress.Size = new System.Drawing.Size(42, 13);
            this.lblTeacherAdress.TabIndex = 72;
            this.lblTeacherAdress.Text = "Adress:";
            // 
            // txtTeacherContact
            // 
            this.txtTeacherContact.Location = new System.Drawing.Point(56, 135);
            this.txtTeacherContact.Name = "txtTeacherContact";
            this.txtTeacherContact.ReadOnly = true;
            this.txtTeacherContact.Size = new System.Drawing.Size(87, 20);
            this.txtTeacherContact.TabIndex = 71;
            // 
            // lblTeacherContact
            // 
            this.lblTeacherContact.AutoSize = true;
            this.lblTeacherContact.Location = new System.Drawing.Point(7, 138);
            this.lblTeacherContact.Name = "lblTeacherContact";
            this.lblTeacherContact.Size = new System.Drawing.Size(47, 13);
            this.lblTeacherContact.TabIndex = 70;
            this.lblTeacherContact.Text = "Contact:";
            // 
            // lblChangeDataTeacher
            // 
            this.lblChangeDataTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeDataTeacher.Location = new System.Drawing.Point(80, 284);
            this.lblChangeDataTeacher.Name = "lblChangeDataTeacher";
            this.lblChangeDataTeacher.Size = new System.Drawing.Size(104, 31);
            this.lblChangeDataTeacher.TabIndex = 69;
            this.lblChangeDataTeacher.Text = "Change data";
            this.lblChangeDataTeacher.UseVisualStyleBackColor = true;
            this.lblChangeDataTeacher.Click += new System.EventHandler(this.lblChangeDataTeacher_Click);
            // 
            // lblTeacherSubject
            // 
            this.lblTeacherSubject.AutoSize = true;
            this.lblTeacherSubject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTeacherSubject.Location = new System.Drawing.Point(8, 188);
            this.lblTeacherSubject.Name = "lblTeacherSubject";
            this.lblTeacherSubject.Size = new System.Drawing.Size(46, 13);
            this.lblTeacherSubject.TabIndex = 67;
            this.lblTeacherSubject.Text = "Subject:";
            // 
            // cbTeacherYears
            // 
            this.cbTeacherYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacherYears.FormattingEnabled = true;
            this.cbTeacherYears.Location = new System.Drawing.Point(56, 211);
            this.cbTeacherYears.Name = "cbTeacherYears";
            this.cbTeacherYears.Size = new System.Drawing.Size(80, 21);
            this.cbTeacherYears.TabIndex = 66;
            // 
            // txtTeacherNIF
            // 
            this.txtTeacherNIF.Location = new System.Drawing.Point(56, 110);
            this.txtTeacherNIF.Name = "txtTeacherNIF";
            this.txtTeacherNIF.ReadOnly = true;
            this.txtTeacherNIF.Size = new System.Drawing.Size(87, 20);
            this.txtTeacherNIF.TabIndex = 65;
            // 
            // lblTeacherNIF
            // 
            this.lblTeacherNIF.AutoSize = true;
            this.lblTeacherNIF.Location = new System.Drawing.Point(23, 113);
            this.lblTeacherNIF.Name = "lblTeacherNIF";
            this.lblTeacherNIF.Size = new System.Drawing.Size(27, 13);
            this.lblTeacherNIF.TabIndex = 64;
            this.lblTeacherNIF.Text = "NIF:";
            // 
            // txtTeacherNum
            // 
            this.txtTeacherNum.Location = new System.Drawing.Point(56, 84);
            this.txtTeacherNum.Name = "txtTeacherNum";
            this.txtTeacherNum.ReadOnly = true;
            this.txtTeacherNum.Size = new System.Drawing.Size(87, 20);
            this.txtTeacherNum.TabIndex = 63;
            // 
            // lblTeacherNum
            // 
            this.lblTeacherNum.AutoSize = true;
            this.lblTeacherNum.Location = new System.Drawing.Point(24, 87);
            this.lblTeacherNum.Name = "lblTeacherNum";
            this.lblTeacherNum.Size = new System.Drawing.Size(32, 13);
            this.lblTeacherNum.TabIndex = 62;
            this.lblTeacherNum.Text = "Num:";
            // 
            // lblTeacherYears
            // 
            this.lblTeacherYears.AutoSize = true;
            this.lblTeacherYears.Location = new System.Drawing.Point(17, 215);
            this.lblTeacherYears.Name = "lblTeacherYears";
            this.lblTeacherYears.Size = new System.Drawing.Size(37, 13);
            this.lblTeacherYears.TabIndex = 61;
            this.lblTeacherYears.Text = "Years:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(56, 58);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.Size = new System.Drawing.Size(189, 20);
            this.txtTeacherName.TabIndex = 60;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(18, 61);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(38, 13);
            this.lblTeacherName.TabIndex = 59;
            this.lblTeacherName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Info";
            // 
            // txtDesign
            // 
            this.txtDesign.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDesign.Location = new System.Drawing.Point(250, -10);
            this.txtDesign.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesign.Multiline = true;
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.ReadOnly = true;
            this.txtDesign.Size = new System.Drawing.Size(8, 347);
            this.txtDesign.TabIndex = 82;
            // 
            // lblEnterGrade
            // 
            this.lblEnterGrade.AutoSize = true;
            this.lblEnterGrade.Location = new System.Drawing.Point(356, 242);
            this.lblEnterGrade.Name = "lblEnterGrade";
            this.lblEnterGrade.Size = new System.Drawing.Size(39, 13);
            this.lblEnterGrade.TabIndex = 78;
            this.lblEnterGrade.Text = "Grade:";
            // 
            // lstStudentGrade
            // 
            this.lstStudentGrade.FormattingEnabled = true;
            this.lstStudentGrade.Location = new System.Drawing.Point(267, 42);
            this.lstStudentGrade.Name = "lstStudentGrade";
            this.lstStudentGrade.Size = new System.Drawing.Size(218, 186);
            this.lstStudentGrade.TabIndex = 86;
            // 
            // txtTeacherSubject
            // 
            this.txtTeacherSubject.Location = new System.Drawing.Point(56, 185);
            this.txtTeacherSubject.Name = "txtTeacherSubject";
            this.txtTeacherSubject.ReadOnly = true;
            this.txtTeacherSubject.Size = new System.Drawing.Size(87, 20);
            this.txtTeacherSubject.TabIndex = 87;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(497, 325);
            this.Controls.Add(this.txtTeacherSubject);
            this.Controls.Add(this.lstStudentGrade);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnterGrade);
            this.Controls.Add(this.txtSelectGrade);
            this.Controls.Add(this.lblGradesManagement);
            this.Controls.Add(this.btnApplyGrades);
            this.Controls.Add(this.txtTeacherAdress);
            this.Controls.Add(this.lblTeacherAdress);
            this.Controls.Add(this.txtTeacherContact);
            this.Controls.Add(this.lblTeacherContact);
            this.Controls.Add(this.lblChangeDataTeacher);
            this.Controls.Add(this.lblTeacherSubject);
            this.Controls.Add(this.cbTeacherYears);
            this.Controls.Add(this.txtTeacherNIF);
            this.Controls.Add(this.lblTeacherNIF);
            this.Controls.Add(this.txtTeacherNum);
            this.Controls.Add(this.lblTeacherNum);
            this.Controls.Add(this.lblTeacherYears);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.lblTeacherName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.Shown += new System.EventHandler(this.TeacherForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSelectGrade;
        private System.Windows.Forms.Label lblGradesManagement;
        private System.Windows.Forms.Button btnApplyGrades;
        private System.Windows.Forms.TextBox txtTeacherAdress;
        private System.Windows.Forms.Label lblTeacherAdress;
        private System.Windows.Forms.TextBox txtTeacherContact;
        private System.Windows.Forms.Label lblTeacherContact;
        private System.Windows.Forms.Button lblChangeDataTeacher;
        private System.Windows.Forms.Label lblTeacherSubject;
        private System.Windows.Forms.ComboBox cbTeacherYears;
        private System.Windows.Forms.TextBox txtTeacherNIF;
        private System.Windows.Forms.Label lblTeacherNIF;
        private System.Windows.Forms.TextBox txtTeacherNum;
        private System.Windows.Forms.Label lblTeacherNum;
        private System.Windows.Forms.Label lblTeacherYears;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesign;
        private System.Windows.Forms.Label lblEnterGrade;
        private System.Windows.Forms.ListBox lstStudentGrade;
        private System.Windows.Forms.TextBox txtTeacherSubject;
    }
}