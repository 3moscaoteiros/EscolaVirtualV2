
namespace ProjetoEscola
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tbAdmin = new System.Windows.Forms.TabControl();
            this.tpStudent = new System.Windows.Forms.TabPage();
            this.txtPINStudnet = new System.Windows.Forms.TextBox();
            this.lblPINStudent = new System.Windows.Forms.Label();
            this.lblChooseClass = new System.Windows.Forms.Label();
            this.cbbClassStudent = new System.Windows.Forms.ComboBox();
            this.txtAdressStudent = new System.Windows.Forms.TextBox();
            this.lblCreateAdress = new System.Windows.Forms.Label();
            this.txtContactStudent = new System.Windows.Forms.TextBox();
            this.lblCreateContact = new System.Windows.Forms.Label();
            this.txtNIFStudent = new System.Windows.Forms.TextBox();
            this.lblCreateNIF = new System.Windows.Forms.Label();
            this.txtNumStudent = new System.Windows.Forms.TextBox();
            this.lblCreateNum = new System.Windows.Forms.Label();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.btnLeaveStudent = new System.Windows.Forms.Button();
            this.txtBalanceStudent = new System.Windows.Forms.TextBox();
            this.lblCreateBalance = new System.Windows.Forms.Label();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.lblCreateStudent = new System.Windows.Forms.Label();
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.txtPINTeacher = new System.Windows.Forms.TextBox();
            this.lblPINTeacher = new System.Windows.Forms.Label();
            this.btnLeaveTeacher = new System.Windows.Forms.Button();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.txtAdressTeacher = new System.Windows.Forms.TextBox();
            this.blbAdressTeacher = new System.Windows.Forms.Label();
            this.txtContactTeacher = new System.Windows.Forms.TextBox();
            this.lblContactTeacher = new System.Windows.Forms.Label();
            this.txtNIFTeacher = new System.Windows.Forms.TextBox();
            this.lblNIFTeacher = new System.Windows.Forms.Label();
            this.txtNumTeacher = new System.Windows.Forms.TextBox();
            this.lblNumTeacher = new System.Windows.Forms.Label();
            this.txtNameTeacher = new System.Windows.Forms.TextBox();
            this.lblNameTeacher = new System.Windows.Forms.Label();
            this.lblCreateTeacher = new System.Windows.Forms.Label();
            this.lstTeacherSubjects = new System.Windows.Forms.ListBox();
            this.lblSubjectsTeacher = new System.Windows.Forms.Label();
            this.tpClasses = new System.Windows.Forms.TabPage();
            this.txtChooseYear = new System.Windows.Forms.TextBox();
            this.btnLeaveClasses = new System.Windows.Forms.Button();
            this.lblClassChooseYear = new System.Windows.Forms.Label();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.lblCreateClass = new System.Windows.Forms.Label();
            this.txtCreateClass = new System.Windows.Forms.TextBox();
            this.tbRequests = new System.Windows.Forms.TabPage();
            this.btnLeaveRequests = new System.Windows.Forms.Button();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lstRequest = new System.Windows.Forms.ListBox();
            this.tbAdmin.SuspendLayout();
            this.tpStudent.SuspendLayout();
            this.tpTeacher.SuspendLayout();
            this.tpClasses.SuspendLayout();
            this.tbRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdmin
            // 
            this.tbAdmin.Controls.Add(this.tpStudent);
            this.tbAdmin.Controls.Add(this.tpTeacher);
            this.tbAdmin.Controls.Add(this.tpClasses);
            this.tbAdmin.Controls.Add(this.tbRequests);
            this.tbAdmin.Location = new System.Drawing.Point(0, 0);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.SelectedIndex = 0;
            this.tbAdmin.Size = new System.Drawing.Size(471, 362);
            this.tbAdmin.TabIndex = 96;
            // 
            // tpStudent
            // 
            this.tpStudent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpStudent.Controls.Add(this.txtPINStudnet);
            this.tpStudent.Controls.Add(this.lblPINStudent);
            this.tpStudent.Controls.Add(this.lblChooseClass);
            this.tpStudent.Controls.Add(this.cbbClassStudent);
            this.tpStudent.Controls.Add(this.txtAdressStudent);
            this.tpStudent.Controls.Add(this.lblCreateAdress);
            this.tpStudent.Controls.Add(this.txtContactStudent);
            this.tpStudent.Controls.Add(this.lblCreateContact);
            this.tpStudent.Controls.Add(this.txtNIFStudent);
            this.tpStudent.Controls.Add(this.lblCreateNIF);
            this.tpStudent.Controls.Add(this.txtNumStudent);
            this.tpStudent.Controls.Add(this.lblCreateNum);
            this.tpStudent.Controls.Add(this.txtNameStudent);
            this.tpStudent.Controls.Add(this.lblNameStudent);
            this.tpStudent.Controls.Add(this.btnLeaveStudent);
            this.tpStudent.Controls.Add(this.txtBalanceStudent);
            this.tpStudent.Controls.Add(this.lblCreateBalance);
            this.tpStudent.Controls.Add(this.btnCreateStudent);
            this.tpStudent.Controls.Add(this.lblCreateStudent);
            this.tpStudent.Location = new System.Drawing.Point(4, 22);
            this.tpStudent.Name = "tpStudent";
            this.tpStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudent.Size = new System.Drawing.Size(463, 336);
            this.tpStudent.TabIndex = 1;
            this.tpStudent.Text = "Student";
            // 
            // txtPINStudnet
            // 
            this.txtPINStudnet.Location = new System.Drawing.Point(107, 234);
            this.txtPINStudnet.MaxLength = 5;
            this.txtPINStudnet.Name = "txtPINStudnet";
            this.txtPINStudnet.Size = new System.Drawing.Size(43, 20);
            this.txtPINStudnet.TabIndex = 123;
            this.txtPINStudnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPINStudnet_KeyPress);
            // 
            // lblPINStudent
            // 
            this.lblPINStudent.AutoSize = true;
            this.lblPINStudent.Location = new System.Drawing.Point(77, 239);
            this.lblPINStudent.Name = "lblPINStudent";
            this.lblPINStudent.Size = new System.Drawing.Size(28, 13);
            this.lblPINStudent.TabIndex = 122;
            this.lblPINStudent.Text = "PIN:";
            // 
            // lblChooseClass
            // 
            this.lblChooseClass.AutoSize = true;
            this.lblChooseClass.Location = new System.Drawing.Point(70, 182);
            this.lblChooseClass.Name = "lblChooseClass";
            this.lblChooseClass.Size = new System.Drawing.Size(35, 13);
            this.lblChooseClass.TabIndex = 121;
            this.lblChooseClass.Text = "Class:";
            // 
            // cbbClassStudent
            // 
            this.cbbClassStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClassStudent.FormattingEnabled = true;
            this.cbbClassStudent.Location = new System.Drawing.Point(107, 179);
            this.cbbClassStudent.Name = "cbbClassStudent";
            this.cbbClassStudent.Size = new System.Drawing.Size(72, 21);
            this.cbbClassStudent.TabIndex = 120;
            // 
            // txtAdressStudent
            // 
            this.txtAdressStudent.Location = new System.Drawing.Point(107, 127);
            this.txtAdressStudent.Name = "txtAdressStudent";
            this.txtAdressStudent.Size = new System.Drawing.Size(168, 20);
            this.txtAdressStudent.TabIndex = 114;
            // 
            // lblCreateAdress
            // 
            this.lblCreateAdress.AutoSize = true;
            this.lblCreateAdress.Location = new System.Drawing.Point(65, 130);
            this.lblCreateAdress.Name = "lblCreateAdress";
            this.lblCreateAdress.Size = new System.Drawing.Size(42, 13);
            this.lblCreateAdress.TabIndex = 113;
            this.lblCreateAdress.Text = "Adress:";
            // 
            // txtContactStudent
            // 
            this.txtContactStudent.Location = new System.Drawing.Point(107, 153);
            this.txtContactStudent.Name = "txtContactStudent";
            this.txtContactStudent.Size = new System.Drawing.Size(87, 20);
            this.txtContactStudent.TabIndex = 112;
            // 
            // lblCreateContact
            // 
            this.lblCreateContact.AutoSize = true;
            this.lblCreateContact.Location = new System.Drawing.Point(60, 156);
            this.lblCreateContact.Name = "lblCreateContact";
            this.lblCreateContact.Size = new System.Drawing.Size(47, 13);
            this.lblCreateContact.TabIndex = 111;
            this.lblCreateContact.Text = "Contact:";
            // 
            // txtNIFStudent
            // 
            this.txtNIFStudent.Location = new System.Drawing.Point(107, 101);
            this.txtNIFStudent.Name = "txtNIFStudent";
            this.txtNIFStudent.Size = new System.Drawing.Size(87, 20);
            this.txtNIFStudent.TabIndex = 109;
            this.txtNIFStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIFStudent_KeyPress);
            // 
            // lblCreateNIF
            // 
            this.lblCreateNIF.AutoSize = true;
            this.lblCreateNIF.Location = new System.Drawing.Point(74, 104);
            this.lblCreateNIF.Name = "lblCreateNIF";
            this.lblCreateNIF.Size = new System.Drawing.Size(27, 13);
            this.lblCreateNIF.TabIndex = 108;
            this.lblCreateNIF.Text = "NIF:";
            // 
            // txtNumStudent
            // 
            this.txtNumStudent.Location = new System.Drawing.Point(107, 76);
            this.txtNumStudent.Name = "txtNumStudent";
            this.txtNumStudent.Size = new System.Drawing.Size(87, 20);
            this.txtNumStudent.TabIndex = 107;
            this.txtNumStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumStudent_KeyPress);
            // 
            // lblCreateNum
            // 
            this.lblCreateNum.AutoSize = true;
            this.lblCreateNum.Location = new System.Drawing.Point(73, 79);
            this.lblCreateNum.Name = "lblCreateNum";
            this.lblCreateNum.Size = new System.Drawing.Size(32, 13);
            this.lblCreateNum.TabIndex = 106;
            this.lblCreateNum.Text = "Num:";
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(107, 50);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(158, 20);
            this.txtNameStudent.TabIndex = 104;
            this.txtNameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameStudent_KeyPress);
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.AutoSize = true;
            this.lblNameStudent.Location = new System.Drawing.Point(67, 53);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(38, 13);
            this.lblNameStudent.TabIndex = 103;
            this.lblNameStudent.Text = "Name:";
            // 
            // btnLeaveStudent
            // 
            this.btnLeaveStudent.Location = new System.Drawing.Point(283, 268);
            this.btnLeaveStudent.Name = "btnLeaveStudent";
            this.btnLeaveStudent.Size = new System.Drawing.Size(69, 31);
            this.btnLeaveStudent.TabIndex = 102;
            this.btnLeaveStudent.Text = "Leave";
            this.btnLeaveStudent.UseVisualStyleBackColor = true;
            this.btnLeaveStudent.Click += new System.EventHandler(this.btnLeaveStudent_Click);
            // 
            // txtBalanceStudent
            // 
            this.txtBalanceStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceStudent.Location = new System.Drawing.Point(107, 206);
            this.txtBalanceStudent.Name = "txtBalanceStudent";
            this.txtBalanceStudent.Size = new System.Drawing.Size(155, 20);
            this.txtBalanceStudent.TabIndex = 99;
            this.txtBalanceStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalanceStudent_KeyPress);
            // 
            // lblCreateBalance
            // 
            this.lblCreateBalance.AutoSize = true;
            this.lblCreateBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateBalance.Location = new System.Drawing.Point(60, 210);
            this.lblCreateBalance.Name = "lblCreateBalance";
            this.lblCreateBalance.Size = new System.Drawing.Size(49, 13);
            this.lblCreateBalance.TabIndex = 98;
            this.lblCreateBalance.Text = "Balance:";
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.Location = new System.Drawing.Point(123, 260);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(107, 45);
            this.btnCreateStudent.TabIndex = 97;
            this.btnCreateStudent.Text = "Create";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // lblCreateStudent
            // 
            this.lblCreateStudent.AutoSize = true;
            this.lblCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateStudent.Location = new System.Drawing.Point(118, 13);
            this.lblCreateStudent.Name = "lblCreateStudent";
            this.lblCreateStudent.Size = new System.Drawing.Size(93, 25);
            this.lblCreateStudent.TabIndex = 96;
            this.lblCreateStudent.Text = "Creation";
            this.lblCreateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpTeacher
            // 
            this.tpTeacher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpTeacher.Controls.Add(this.txtPINTeacher);
            this.tpTeacher.Controls.Add(this.lblPINTeacher);
            this.tpTeacher.Controls.Add(this.btnLeaveTeacher);
            this.tpTeacher.Controls.Add(this.btnCreateTeacher);
            this.tpTeacher.Controls.Add(this.txtAdressTeacher);
            this.tpTeacher.Controls.Add(this.blbAdressTeacher);
            this.tpTeacher.Controls.Add(this.txtContactTeacher);
            this.tpTeacher.Controls.Add(this.lblContactTeacher);
            this.tpTeacher.Controls.Add(this.txtNIFTeacher);
            this.tpTeacher.Controls.Add(this.lblNIFTeacher);
            this.tpTeacher.Controls.Add(this.txtNumTeacher);
            this.tpTeacher.Controls.Add(this.lblNumTeacher);
            this.tpTeacher.Controls.Add(this.txtNameTeacher);
            this.tpTeacher.Controls.Add(this.lblNameTeacher);
            this.tpTeacher.Controls.Add(this.lblCreateTeacher);
            this.tpTeacher.Controls.Add(this.lstTeacherSubjects);
            this.tpTeacher.Controls.Add(this.lblSubjectsTeacher);
            this.tpTeacher.Location = new System.Drawing.Point(4, 22);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeacher.Size = new System.Drawing.Size(463, 336);
            this.tpTeacher.TabIndex = 2;
            this.tpTeacher.Text = "Teacher";
            // 
            // txtPINTeacher
            // 
            this.txtPINTeacher.Location = new System.Drawing.Point(70, 180);
            this.txtPINTeacher.Name = "txtPINTeacher";
            this.txtPINTeacher.Size = new System.Drawing.Size(43, 20);
            this.txtPINTeacher.TabIndex = 138;
            // 
            // lblPINTeacher
            // 
            this.lblPINTeacher.AutoSize = true;
            this.lblPINTeacher.Location = new System.Drawing.Point(36, 183);
            this.lblPINTeacher.Name = "lblPINTeacher";
            this.lblPINTeacher.Size = new System.Drawing.Size(28, 13);
            this.lblPINTeacher.TabIndex = 137;
            this.lblPINTeacher.Text = "PIN:";
            // 
            // btnLeaveTeacher
            // 
            this.btnLeaveTeacher.Location = new System.Drawing.Point(8, 268);
            this.btnLeaveTeacher.Name = "btnLeaveTeacher";
            this.btnLeaveTeacher.Size = new System.Drawing.Size(69, 31);
            this.btnLeaveTeacher.TabIndex = 136;
            this.btnLeaveTeacher.Text = "Leave";
            this.btnLeaveTeacher.UseVisualStyleBackColor = true;
            this.btnLeaveTeacher.Click += new System.EventHandler(this.btnLeaveTeacher_Click);
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeacher.Location = new System.Drawing.Point(85, 217);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(107, 45);
            this.btnCreateTeacher.TabIndex = 135;
            this.btnCreateTeacher.Text = "Create";
            this.btnCreateTeacher.UseVisualStyleBackColor = true;
            this.btnCreateTeacher.Click += new System.EventHandler(this.btnCreateTeacher_Click);
            // 
            // txtAdressTeacher
            // 
            this.txtAdressTeacher.Location = new System.Drawing.Point(70, 128);
            this.txtAdressTeacher.Name = "txtAdressTeacher";
            this.txtAdressTeacher.Size = new System.Drawing.Size(168, 20);
            this.txtAdressTeacher.TabIndex = 134;
            // 
            // blbAdressTeacher
            // 
            this.blbAdressTeacher.AutoSize = true;
            this.blbAdressTeacher.Location = new System.Drawing.Point(28, 130);
            this.blbAdressTeacher.Name = "blbAdressTeacher";
            this.blbAdressTeacher.Size = new System.Drawing.Size(42, 13);
            this.blbAdressTeacher.TabIndex = 133;
            this.blbAdressTeacher.Text = "Adress:";
            // 
            // txtContactTeacher
            // 
            this.txtContactTeacher.Location = new System.Drawing.Point(70, 154);
            this.txtContactTeacher.Name = "txtContactTeacher";
            this.txtContactTeacher.Size = new System.Drawing.Size(87, 20);
            this.txtContactTeacher.TabIndex = 132;
            // 
            // lblContactTeacher
            // 
            this.lblContactTeacher.AutoSize = true;
            this.lblContactTeacher.Location = new System.Drawing.Point(23, 157);
            this.lblContactTeacher.Name = "lblContactTeacher";
            this.lblContactTeacher.Size = new System.Drawing.Size(47, 13);
            this.lblContactTeacher.TabIndex = 131;
            this.lblContactTeacher.Text = "Contact:";
            // 
            // txtNIFTeacher
            // 
            this.txtNIFTeacher.Location = new System.Drawing.Point(70, 107);
            this.txtNIFTeacher.Name = "txtNIFTeacher";
            this.txtNIFTeacher.Size = new System.Drawing.Size(87, 20);
            this.txtNIFTeacher.TabIndex = 130;
            this.txtNIFTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIFTeacher_KeyPress);
            // 
            // lblNIFTeacher
            // 
            this.lblNIFTeacher.AutoSize = true;
            this.lblNIFTeacher.Location = new System.Drawing.Point(41, 108);
            this.lblNIFTeacher.Name = "lblNIFTeacher";
            this.lblNIFTeacher.Size = new System.Drawing.Size(27, 13);
            this.lblNIFTeacher.TabIndex = 129;
            this.lblNIFTeacher.Text = "NIF:";
            // 
            // txtNumTeacher
            // 
            this.txtNumTeacher.Location = new System.Drawing.Point(70, 82);
            this.txtNumTeacher.Name = "txtNumTeacher";
            this.txtNumTeacher.Size = new System.Drawing.Size(87, 20);
            this.txtNumTeacher.TabIndex = 128;
            this.txtNumTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTeacher_KeyPress);
            // 
            // lblNumTeacher
            // 
            this.lblNumTeacher.AutoSize = true;
            this.lblNumTeacher.Location = new System.Drawing.Point(36, 85);
            this.lblNumTeacher.Name = "lblNumTeacher";
            this.lblNumTeacher.Size = new System.Drawing.Size(32, 13);
            this.lblNumTeacher.TabIndex = 127;
            this.lblNumTeacher.Text = "Num:";
            // 
            // txtNameTeacher
            // 
            this.txtNameTeacher.Location = new System.Drawing.Point(70, 57);
            this.txtNameTeacher.Name = "txtNameTeacher";
            this.txtNameTeacher.Size = new System.Drawing.Size(158, 20);
            this.txtNameTeacher.TabIndex = 126;
            this.txtNameTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameTeacher_KeyPress);
            // 
            // lblNameTeacher
            // 
            this.lblNameTeacher.AutoSize = true;
            this.lblNameTeacher.Location = new System.Drawing.Point(30, 64);
            this.lblNameTeacher.Name = "lblNameTeacher";
            this.lblNameTeacher.Size = new System.Drawing.Size(38, 13);
            this.lblNameTeacher.TabIndex = 125;
            this.lblNameTeacher.Text = "Name:";
            // 
            // lblCreateTeacher
            // 
            this.lblCreateTeacher.AutoSize = true;
            this.lblCreateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTeacher.Location = new System.Drawing.Point(80, 21);
            this.lblCreateTeacher.Name = "lblCreateTeacher";
            this.lblCreateTeacher.Size = new System.Drawing.Size(93, 25);
            this.lblCreateTeacher.TabIndex = 124;
            this.lblCreateTeacher.Text = "Creation";
            this.lblCreateTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstTeacherSubjects
            // 
            this.lstTeacherSubjects.FormattingEnabled = true;
            this.lstTeacherSubjects.Location = new System.Drawing.Point(255, 57);
            this.lstTeacherSubjects.Name = "lstTeacherSubjects";
            this.lstTeacherSubjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTeacherSubjects.Size = new System.Drawing.Size(97, 134);
            this.lstTeacherSubjects.TabIndex = 122;
            // 
            // lblSubjectsTeacher
            // 
            this.lblSubjectsTeacher.AutoSize = true;
            this.lblSubjectsTeacher.Location = new System.Drawing.Point(252, 41);
            this.lblSubjectsTeacher.Name = "lblSubjectsTeacher";
            this.lblSubjectsTeacher.Size = new System.Drawing.Size(51, 13);
            this.lblSubjectsTeacher.TabIndex = 121;
            this.lblSubjectsTeacher.Text = "Subjects:";
            // 
            // tpClasses
            // 
            this.tpClasses.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpClasses.Controls.Add(this.txtChooseYear);
            this.tpClasses.Controls.Add(this.btnLeaveClasses);
            this.tpClasses.Controls.Add(this.lblClassChooseYear);
            this.tpClasses.Controls.Add(this.btnCreateClass);
            this.tpClasses.Controls.Add(this.lblCreateClass);
            this.tpClasses.Controls.Add(this.txtCreateClass);
            this.tpClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tpClasses.Location = new System.Drawing.Point(4, 22);
            this.tpClasses.Name = "tpClasses";
            this.tpClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tpClasses.Size = new System.Drawing.Size(463, 336);
            this.tpClasses.TabIndex = 3;
            this.tpClasses.Text = "CreateClasses";
            // 
            // txtChooseYear
            // 
            this.txtChooseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChooseYear.Location = new System.Drawing.Point(95, 46);
            this.txtChooseYear.Name = "txtChooseYear";
            this.txtChooseYear.Size = new System.Drawing.Size(82, 31);
            this.txtChooseYear.TabIndex = 138;
            this.txtChooseYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChooseYear_KeyPress);
            // 
            // btnLeaveClasses
            // 
            this.btnLeaveClasses.Location = new System.Drawing.Point(283, 268);
            this.btnLeaveClasses.Name = "btnLeaveClasses";
            this.btnLeaveClasses.Size = new System.Drawing.Size(69, 31);
            this.btnLeaveClasses.TabIndex = 137;
            this.btnLeaveClasses.Text = "Leave";
            this.btnLeaveClasses.UseVisualStyleBackColor = true;
            this.btnLeaveClasses.Click += new System.EventHandler(this.btnLeaveClasses_Click);
            // 
            // lblClassChooseYear
            // 
            this.lblClassChooseYear.AutoSize = true;
            this.lblClassChooseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassChooseYear.Location = new System.Drawing.Point(25, 49);
            this.lblClassChooseYear.Name = "lblClassChooseYear";
            this.lblClassChooseYear.Size = new System.Drawing.Size(64, 25);
            this.lblClassChooseYear.TabIndex = 4;
            this.lblClassChooseYear.Text = "Year:";
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClass.Location = new System.Drawing.Point(107, 191);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(124, 51);
            this.btnCreateClass.TabIndex = 2;
            this.btnCreateClass.Text = "Create";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // lblCreateClass
            // 
            this.lblCreateClass.AutoSize = true;
            this.lblCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateClass.Location = new System.Drawing.Point(17, 85);
            this.lblCreateClass.Name = "lblCreateClass";
            this.lblCreateClass.Size = new System.Drawing.Size(72, 25);
            this.lblCreateClass.TabIndex = 1;
            this.lblCreateClass.Text = "Class:";
            // 
            // txtCreateClass
            // 
            this.txtCreateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateClass.Location = new System.Drawing.Point(95, 83);
            this.txtCreateClass.Name = "txtCreateClass";
            this.txtCreateClass.Size = new System.Drawing.Size(235, 31);
            this.txtCreateClass.TabIndex = 0;
            // 
            // tbRequests
            // 
            this.tbRequests.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbRequests.Controls.Add(this.btnLeaveRequests);
            this.tbRequests.Controls.Add(this.lblRequest);
            this.tbRequests.Controls.Add(this.btnRequest);
            this.tbRequests.Controls.Add(this.lstRequest);
            this.tbRequests.Location = new System.Drawing.Point(4, 22);
            this.tbRequests.Name = "tbRequests";
            this.tbRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tbRequests.Size = new System.Drawing.Size(463, 336);
            this.tbRequests.TabIndex = 4;
            this.tbRequests.Text = "Requests";
            // 
            // btnLeaveRequests
            // 
            this.btnLeaveRequests.Location = new System.Drawing.Point(283, 268);
            this.btnLeaveRequests.Name = "btnLeaveRequests";
            this.btnLeaveRequests.Size = new System.Drawing.Size(69, 31);
            this.btnLeaveRequests.TabIndex = 137;
            this.btnLeaveRequests.Text = "Leave";
            this.btnLeaveRequests.UseVisualStyleBackColor = true;
            this.btnLeaveRequests.Click += new System.EventHandler(this.btnLeaveRequests_Click);
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(126, 30);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(103, 25);
            this.lblRequest.TabIndex = 120;
            this.lblRequest.Text = "Requests";
            this.lblRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(142, 260);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 39);
            this.btnRequest.TabIndex = 119;
            this.btnRequest.Text = "OK";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lstRequest
            // 
            this.lstRequest.FormattingEnabled = true;
            this.lstRequest.Location = new System.Drawing.Point(97, 58);
            this.lstRequest.Name = "lstRequest";
            this.lstRequest.Size = new System.Drawing.Size(159, 186);
            this.lstRequest.TabIndex = 118;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(368, 333);
            this.Controls.Add(this.tbAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tbAdmin.ResumeLayout(false);
            this.tpStudent.ResumeLayout(false);
            this.tpStudent.PerformLayout();
            this.tpTeacher.ResumeLayout(false);
            this.tpTeacher.PerformLayout();
            this.tpClasses.ResumeLayout(false);
            this.tpClasses.PerformLayout();
            this.tbRequests.ResumeLayout(false);
            this.tbRequests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAdmin;
        private System.Windows.Forms.TabPage tpStudent;
        private System.Windows.Forms.Label lblChooseClass;
        private System.Windows.Forms.ComboBox cbbClassStudent;
        private System.Windows.Forms.TextBox txtAdressStudent;
        private System.Windows.Forms.Label lblCreateAdress;
        private System.Windows.Forms.TextBox txtContactStudent;
        private System.Windows.Forms.Label lblCreateContact;
        private System.Windows.Forms.TextBox txtNIFStudent;
        private System.Windows.Forms.Label lblCreateNIF;
        private System.Windows.Forms.TextBox txtNumStudent;
        private System.Windows.Forms.Label lblCreateNum;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.Button btnLeaveStudent;
        private System.Windows.Forms.TextBox txtBalanceStudent;
        private System.Windows.Forms.Label lblCreateBalance;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Label lblCreateStudent;
        private System.Windows.Forms.TabPage tpTeacher;
        private System.Windows.Forms.TabPage tpClasses;
        private System.Windows.Forms.TabPage tbRequests;
        private System.Windows.Forms.Button btnLeaveTeacher;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.TextBox txtAdressTeacher;
        private System.Windows.Forms.Label blbAdressTeacher;
        private System.Windows.Forms.TextBox txtContactTeacher;
        private System.Windows.Forms.Label lblContactTeacher;
        private System.Windows.Forms.TextBox txtNIFTeacher;
        private System.Windows.Forms.Label lblNIFTeacher;
        private System.Windows.Forms.TextBox txtNumTeacher;
        private System.Windows.Forms.Label lblNumTeacher;
        private System.Windows.Forms.TextBox txtNameTeacher;
        private System.Windows.Forms.Label lblNameTeacher;
        private System.Windows.Forms.Label lblCreateTeacher;
        private System.Windows.Forms.ListBox lstTeacherSubjects;
        private System.Windows.Forms.Label lblSubjectsTeacher;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ListBox lstRequest;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Label lblCreateClass;
        private System.Windows.Forms.TextBox txtCreateClass;
        private System.Windows.Forms.Label lblClassChooseYear;
        private System.Windows.Forms.Button btnLeaveClasses;
        private System.Windows.Forms.Button btnLeaveRequests;
        private System.Windows.Forms.TextBox txtPINStudnet;
        private System.Windows.Forms.Label lblPINStudent;
        private System.Windows.Forms.TextBox txtPINTeacher;
        private System.Windows.Forms.Label lblPINTeacher;
        private System.Windows.Forms.TextBox txtChooseYear;
    }
}