
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCreateClass = new System.Windows.Forms.Label();
            this.cbbCreateClass = new System.Windows.Forms.ComboBox();
            this.lstCreateYears = new System.Windows.Forms.ListBox();
            this.lstCreateSubjects = new System.Windows.Forms.ListBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lstRequest = new System.Windows.Forms.ListBox();
            this.txtCreateAdress = new System.Windows.Forms.TextBox();
            this.lblCreateAdress = new System.Windows.Forms.Label();
            this.txtCreateContact = new System.Windows.Forms.TextBox();
            this.lblCreateContact = new System.Windows.Forms.Label();
            this.lblbCreateSubject = new System.Windows.Forms.Label();
            this.txtCreateNIF = new System.Windows.Forms.TextBox();
            this.lblCreateNIF = new System.Windows.Forms.Label();
            this.txtCreateNum = new System.Windows.Forms.TextBox();
            this.lblCreateNum = new System.Windows.Forms.Label();
            this.lblCreateYear = new System.Windows.Forms.Label();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.lblCreateName = new System.Windows.Forms.Label();
            this.btnAdminLeave = new System.Windows.Forms.Button();
            this.lblCreateType = new System.Windows.Forms.Label();
            this.cbCreateS_T = new System.Windows.Forms.ComboBox();
            this.txtCreateBalance = new System.Windows.Forms.TextBox();
            this.lblCreateBalance = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 505);
            this.tabControl1.TabIndex = 96;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCreateClass);
            this.tabPage2.Controls.Add(this.cbbCreateClass);
            this.tabPage2.Controls.Add(this.lstCreateYears);
            this.tabPage2.Controls.Add(this.lstCreateSubjects);
            this.tabPage2.Controls.Add(this.lblRequest);
            this.tabPage2.Controls.Add(this.btnRequest);
            this.tabPage2.Controls.Add(this.lstRequest);
            this.tabPage2.Controls.Add(this.txtCreateAdress);
            this.tabPage2.Controls.Add(this.lblCreateAdress);
            this.tabPage2.Controls.Add(this.txtCreateContact);
            this.tabPage2.Controls.Add(this.lblCreateContact);
            this.tabPage2.Controls.Add(this.lblbCreateSubject);
            this.tabPage2.Controls.Add(this.txtCreateNIF);
            this.tabPage2.Controls.Add(this.lblCreateNIF);
            this.tabPage2.Controls.Add(this.txtCreateNum);
            this.tabPage2.Controls.Add(this.lblCreateNum);
            this.tabPage2.Controls.Add(this.lblCreateYear);
            this.tabPage2.Controls.Add(this.txtCreateName);
            this.tabPage2.Controls.Add(this.lblCreateName);
            this.tabPage2.Controls.Add(this.btnAdminLeave);
            this.tabPage2.Controls.Add(this.lblCreateType);
            this.tabPage2.Controls.Add(this.cbCreateS_T);
            this.tabPage2.Controls.Add(this.txtCreateBalance);
            this.tabPage2.Controls.Add(this.lblCreateBalance);
            this.tabPage2.Controls.Add(this.btnCreateAcc);
            this.tabPage2.Controls.Add(this.lblCreateAcc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCreateClass
            // 
            this.lblCreateClass.AutoSize = true;
            this.lblCreateClass.Location = new System.Drawing.Point(341, 173);
            this.lblCreateClass.Name = "lblCreateClass";
            this.lblCreateClass.Size = new System.Drawing.Size(35, 13);
            this.lblCreateClass.TabIndex = 121;
            this.lblCreateClass.Text = "Class:";
            // 
            // cbbCreateClass
            // 
            this.cbbCreateClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCreateClass.FormattingEnabled = true;
            this.cbbCreateClass.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.cbbCreateClass.Location = new System.Drawing.Point(382, 170);
            this.cbbCreateClass.Name = "cbbCreateClass";
            this.cbbCreateClass.Size = new System.Drawing.Size(72, 21);
            this.cbbCreateClass.TabIndex = 120;
            // 
            // lstCreateYears
            // 
            this.lstCreateYears.FormattingEnabled = true;
            this.lstCreateYears.Location = new System.Drawing.Point(373, 172);
            this.lstCreateYears.Name = "lstCreateYears";
            this.lstCreateYears.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCreateYears.Size = new System.Drawing.Size(81, 82);
            this.lstCreateYears.TabIndex = 119;
            // 
            // lstCreateSubjects
            // 
            this.lstCreateSubjects.FormattingEnabled = true;
            this.lstCreateSubjects.Location = new System.Drawing.Point(382, 261);
            this.lstCreateSubjects.Name = "lstCreateSubjects";
            this.lstCreateSubjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCreateSubjects.Size = new System.Drawing.Size(72, 108);
            this.lstCreateSubjects.TabIndex = 118;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(470, 109);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(103, 25);
            this.lblRequest.TabIndex = 117;
            this.lblRequest.Text = "Requests";
            this.lblRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(475, 311);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 116;
            this.btnRequest.Text = "OK";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // lstRequest
            // 
            this.lstRequest.FormattingEnabled = true;
            this.lstRequest.Location = new System.Drawing.Point(460, 145);
            this.lstRequest.Name = "lstRequest";
            this.lstRequest.Size = new System.Drawing.Size(118, 160);
            this.lstRequest.TabIndex = 115;
            // 
            // txtCreateAdress
            // 
            this.txtCreateAdress.Location = new System.Drawing.Point(161, 216);
            this.txtCreateAdress.Name = "txtCreateAdress";
            this.txtCreateAdress.Size = new System.Drawing.Size(168, 20);
            this.txtCreateAdress.TabIndex = 114;
            // 
            // lblCreateAdress
            // 
            this.lblCreateAdress.AutoSize = true;
            this.lblCreateAdress.Location = new System.Drawing.Point(119, 218);
            this.lblCreateAdress.Name = "lblCreateAdress";
            this.lblCreateAdress.Size = new System.Drawing.Size(42, 13);
            this.lblCreateAdress.TabIndex = 113;
            this.lblCreateAdress.Text = "Adress:";
            // 
            // txtCreateContact
            // 
            this.txtCreateContact.Location = new System.Drawing.Point(161, 242);
            this.txtCreateContact.Name = "txtCreateContact";
            this.txtCreateContact.Size = new System.Drawing.Size(87, 20);
            this.txtCreateContact.TabIndex = 112;
            // 
            // lblCreateContact
            // 
            this.lblCreateContact.AutoSize = true;
            this.lblCreateContact.Location = new System.Drawing.Point(114, 245);
            this.lblCreateContact.Name = "lblCreateContact";
            this.lblCreateContact.Size = new System.Drawing.Size(47, 13);
            this.lblCreateContact.TabIndex = 111;
            this.lblCreateContact.Text = "Contact:";
            // 
            // lblbCreateSubject
            // 
            this.lblbCreateSubject.AutoSize = true;
            this.lblbCreateSubject.Location = new System.Drawing.Point(335, 261);
            this.lblbCreateSubject.Name = "lblbCreateSubject";
            this.lblbCreateSubject.Size = new System.Drawing.Size(51, 13);
            this.lblbCreateSubject.TabIndex = 110;
            this.lblbCreateSubject.Text = "Subjects:";
            // 
            // txtCreateNIF
            // 
            this.txtCreateNIF.Location = new System.Drawing.Point(161, 195);
            this.txtCreateNIF.Name = "txtCreateNIF";
            this.txtCreateNIF.Size = new System.Drawing.Size(87, 20);
            this.txtCreateNIF.TabIndex = 109;
            // 
            // lblCreateNIF
            // 
            this.lblCreateNIF.AutoSize = true;
            this.lblCreateNIF.Location = new System.Drawing.Point(132, 196);
            this.lblCreateNIF.Name = "lblCreateNIF";
            this.lblCreateNIF.Size = new System.Drawing.Size(27, 13);
            this.lblCreateNIF.TabIndex = 108;
            this.lblCreateNIF.Text = "NIF:";
            // 
            // txtCreateNum
            // 
            this.txtCreateNum.Location = new System.Drawing.Point(161, 170);
            this.txtCreateNum.Name = "txtCreateNum";
            this.txtCreateNum.Size = new System.Drawing.Size(87, 20);
            this.txtCreateNum.TabIndex = 107;
            // 
            // lblCreateNum
            // 
            this.lblCreateNum.AutoSize = true;
            this.lblCreateNum.Location = new System.Drawing.Point(127, 173);
            this.lblCreateNum.Name = "lblCreateNum";
            this.lblCreateNum.Size = new System.Drawing.Size(32, 13);
            this.lblCreateNum.TabIndex = 106;
            this.lblCreateNum.Text = "Num:";
            // 
            // lblCreateYear
            // 
            this.lblCreateYear.AutoSize = true;
            this.lblCreateYear.Location = new System.Drawing.Point(335, 173);
            this.lblCreateYear.Name = "lblCreateYear";
            this.lblCreateYear.Size = new System.Drawing.Size(32, 13);
            this.lblCreateYear.TabIndex = 105;
            this.lblCreateYear.Text = "Year:";
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(161, 145);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(158, 20);
            this.txtCreateName.TabIndex = 104;
            // 
            // lblCreateName
            // 
            this.lblCreateName.AutoSize = true;
            this.lblCreateName.Location = new System.Drawing.Point(121, 152);
            this.lblCreateName.Name = "lblCreateName";
            this.lblCreateName.Size = new System.Drawing.Size(38, 13);
            this.lblCreateName.TabIndex = 103;
            this.lblCreateName.Text = "Name:";
            // 
            // btnAdminLeave
            // 
            this.btnAdminLeave.Location = new System.Drawing.Point(249, 325);
            this.btnAdminLeave.Name = "btnAdminLeave";
            this.btnAdminLeave.Size = new System.Drawing.Size(69, 31);
            this.btnAdminLeave.TabIndex = 102;
            this.btnAdminLeave.Text = "Leave";
            this.btnAdminLeave.UseVisualStyleBackColor = true;
            // 
            // lblCreateType
            // 
            this.lblCreateType.AutoSize = true;
            this.lblCreateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateType.Location = new System.Drawing.Point(333, 124);
            this.lblCreateType.Name = "lblCreateType";
            this.lblCreateType.Size = new System.Drawing.Size(34, 13);
            this.lblCreateType.TabIndex = 101;
            this.lblCreateType.Text = "Type:";
            // 
            // cbCreateS_T
            // 
            this.cbCreateS_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreateS_T.FormattingEnabled = true;
            this.cbCreateS_T.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.cbCreateS_T.Location = new System.Drawing.Point(333, 145);
            this.cbCreateS_T.Name = "cbCreateS_T";
            this.cbCreateS_T.Size = new System.Drawing.Size(121, 21);
            this.cbCreateS_T.TabIndex = 100;
            // 
            // txtCreateBalance
            // 
            this.txtCreateBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateBalance.Location = new System.Drawing.Point(161, 268);
            this.txtCreateBalance.Name = "txtCreateBalance";
            this.txtCreateBalance.Size = new System.Drawing.Size(155, 24);
            this.txtCreateBalance.TabIndex = 99;
            // 
            // lblCreateBalance
            // 
            this.lblCreateBalance.AutoSize = true;
            this.lblCreateBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateBalance.Location = new System.Drawing.Point(110, 275);
            this.lblCreateBalance.Name = "lblCreateBalance";
            this.lblCreateBalance.Size = new System.Drawing.Size(49, 13);
            this.lblCreateBalance.TabIndex = 98;
            this.lblCreateBalance.Text = "Balance:";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(125, 317);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(107, 45);
            this.btnCreateAcc.TabIndex = 97;
            this.btnCreateAcc.Text = "Create";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = true;
            this.lblCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.Location = new System.Drawing.Point(171, 109);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(93, 25);
            this.lblCreateAcc.TabIndex = 96;
            this.lblCreateAcc.Text = "Creation";
            this.lblCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(660, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCreateClass;
        private System.Windows.Forms.ComboBox cbbCreateClass;
        private System.Windows.Forms.ListBox lstCreateYears;
        private System.Windows.Forms.ListBox lstCreateSubjects;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ListBox lstRequest;
        private System.Windows.Forms.TextBox txtCreateAdress;
        private System.Windows.Forms.Label lblCreateAdress;
        private System.Windows.Forms.TextBox txtCreateContact;
        private System.Windows.Forms.Label lblCreateContact;
        private System.Windows.Forms.Label lblbCreateSubject;
        private System.Windows.Forms.TextBox txtCreateNIF;
        private System.Windows.Forms.Label lblCreateNIF;
        private System.Windows.Forms.TextBox txtCreateNum;
        private System.Windows.Forms.Label lblCreateNum;
        private System.Windows.Forms.Label lblCreateYear;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Label lblCreateName;
        private System.Windows.Forms.Button btnAdminLeave;
        private System.Windows.Forms.Label lblCreateType;
        private System.Windows.Forms.ComboBox cbCreateS_T;
        private System.Windows.Forms.TextBox txtCreateBalance;
        private System.Windows.Forms.Label lblCreateBalance;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Label lblCreateAcc;
    }
}