
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
            this.lstRequest = new System.Windows.Forms.ListBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblRequest = new System.Windows.Forms.Label();
            this.lstCreateSubjects = new System.Windows.Forms.ListBox();
            this.lstCreateYears = new System.Windows.Forms.ListBox();
            this.cbbCreateClass = new System.Windows.Forms.ComboBox();
            this.lblCreateClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCreateAdress
            // 
            this.txtCreateAdress.Location = new System.Drawing.Point(54, 152);
            this.txtCreateAdress.Name = "txtCreateAdress";
            this.txtCreateAdress.Size = new System.Drawing.Size(168, 20);
            this.txtCreateAdress.TabIndex = 87;
            // 
            // lblCreateAdress
            // 
            this.lblCreateAdress.AutoSize = true;
            this.lblCreateAdress.Location = new System.Drawing.Point(12, 154);
            this.lblCreateAdress.Name = "lblCreateAdress";
            this.lblCreateAdress.Size = new System.Drawing.Size(42, 13);
            this.lblCreateAdress.TabIndex = 86;
            this.lblCreateAdress.Text = "Adress:";
            // 
            // txtCreateContact
            // 
            this.txtCreateContact.Location = new System.Drawing.Point(54, 178);
            this.txtCreateContact.Name = "txtCreateContact";
            this.txtCreateContact.Size = new System.Drawing.Size(87, 20);
            this.txtCreateContact.TabIndex = 85;
            this.txtCreateContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreateContact_KeyPress);
            // 
            // lblCreateContact
            // 
            this.lblCreateContact.AutoSize = true;
            this.lblCreateContact.Location = new System.Drawing.Point(7, 181);
            this.lblCreateContact.Name = "lblCreateContact";
            this.lblCreateContact.Size = new System.Drawing.Size(47, 13);
            this.lblCreateContact.TabIndex = 84;
            this.lblCreateContact.Text = "Contact:";
            // 
            // lblbCreateSubject
            // 
            this.lblbCreateSubject.AutoSize = true;
            this.lblbCreateSubject.Location = new System.Drawing.Point(226, 197);
            this.lblbCreateSubject.Name = "lblbCreateSubject";
            this.lblbCreateSubject.Size = new System.Drawing.Size(51, 13);
            this.lblbCreateSubject.TabIndex = 83;
            this.lblbCreateSubject.Text = "Subjects:";
            // 
            // txtCreateNIF
            // 
            this.txtCreateNIF.Location = new System.Drawing.Point(54, 131);
            this.txtCreateNIF.Name = "txtCreateNIF";
            this.txtCreateNIF.Size = new System.Drawing.Size(87, 20);
            this.txtCreateNIF.TabIndex = 81;
            this.txtCreateNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreateNIF_KeyPress);
            // 
            // lblCreateNIF
            // 
            this.lblCreateNIF.AutoSize = true;
            this.lblCreateNIF.Location = new System.Drawing.Point(25, 132);
            this.lblCreateNIF.Name = "lblCreateNIF";
            this.lblCreateNIF.Size = new System.Drawing.Size(27, 13);
            this.lblCreateNIF.TabIndex = 80;
            this.lblCreateNIF.Text = "NIF:";
            // 
            // txtCreateNum
            // 
            this.txtCreateNum.Location = new System.Drawing.Point(54, 106);
            this.txtCreateNum.Name = "txtCreateNum";
            this.txtCreateNum.Size = new System.Drawing.Size(87, 20);
            this.txtCreateNum.TabIndex = 79;
            // 
            // lblCreateNum
            // 
            this.lblCreateNum.AutoSize = true;
            this.lblCreateNum.Location = new System.Drawing.Point(20, 109);
            this.lblCreateNum.Name = "lblCreateNum";
            this.lblCreateNum.Size = new System.Drawing.Size(32, 13);
            this.lblCreateNum.TabIndex = 78;
            this.lblCreateNum.Text = "Num:";
            // 
            // lblCreateYear
            // 
            this.lblCreateYear.AutoSize = true;
            this.lblCreateYear.Location = new System.Drawing.Point(228, 109);
            this.lblCreateYear.Name = "lblCreateYear";
            this.lblCreateYear.Size = new System.Drawing.Size(32, 13);
            this.lblCreateYear.TabIndex = 77;
            this.lblCreateYear.Text = "Year:";
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(54, 81);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(158, 20);
            this.txtCreateName.TabIndex = 76;
            this.txtCreateName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreateName_KeyPress);
            // 
            // lblCreateName
            // 
            this.lblCreateName.AutoSize = true;
            this.lblCreateName.Location = new System.Drawing.Point(14, 88);
            this.lblCreateName.Name = "lblCreateName";
            this.lblCreateName.Size = new System.Drawing.Size(38, 13);
            this.lblCreateName.TabIndex = 75;
            this.lblCreateName.Text = "Name:";
            // 
            // btnAdminLeave
            // 
            this.btnAdminLeave.Location = new System.Drawing.Point(142, 261);
            this.btnAdminLeave.Name = "btnAdminLeave";
            this.btnAdminLeave.Size = new System.Drawing.Size(69, 31);
            this.btnAdminLeave.TabIndex = 74;
            this.btnAdminLeave.Text = "Leave";
            this.btnAdminLeave.UseVisualStyleBackColor = true;
            // 
            // lblCreateType
            // 
            this.lblCreateType.AutoSize = true;
            this.lblCreateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateType.Location = new System.Drawing.Point(226, 60);
            this.lblCreateType.Name = "lblCreateType";
            this.lblCreateType.Size = new System.Drawing.Size(34, 13);
            this.lblCreateType.TabIndex = 73;
            this.lblCreateType.Text = "Type:";
            // 
            // cbCreateS_T
            // 
            this.cbCreateS_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreateS_T.FormattingEnabled = true;
            this.cbCreateS_T.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.cbCreateS_T.Location = new System.Drawing.Point(226, 81);
            this.cbCreateS_T.Name = "cbCreateS_T";
            this.cbCreateS_T.Size = new System.Drawing.Size(121, 21);
            this.cbCreateS_T.TabIndex = 72;
            this.cbCreateS_T.SelectedIndexChanged += new System.EventHandler(this.cbCreateS_T_SelectedIndexChanged);
            // 
            // txtCreateBalance
            // 
            this.txtCreateBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateBalance.Location = new System.Drawing.Point(54, 204);
            this.txtCreateBalance.Name = "txtCreateBalance";
            this.txtCreateBalance.Size = new System.Drawing.Size(155, 24);
            this.txtCreateBalance.TabIndex = 71;
            this.txtCreateBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreateBalance_KeyPress);
            // 
            // lblCreateBalance
            // 
            this.lblCreateBalance.AutoSize = true;
            this.lblCreateBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateBalance.Location = new System.Drawing.Point(3, 211);
            this.lblCreateBalance.Name = "lblCreateBalance";
            this.lblCreateBalance.Size = new System.Drawing.Size(49, 13);
            this.lblCreateBalance.TabIndex = 70;
            this.lblCreateBalance.Text = "Balance:";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(18, 253);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(107, 45);
            this.btnCreateAcc.TabIndex = 69;
            this.btnCreateAcc.Text = "Create";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = true;
            this.lblCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.Location = new System.Drawing.Point(64, 45);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(93, 25);
            this.lblCreateAcc.TabIndex = 68;
            this.lblCreateAcc.Text = "Creation";
            this.lblCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRequest
            // 
            this.lstRequest.FormattingEnabled = true;
            this.lstRequest.Location = new System.Drawing.Point(353, 81);
            this.lstRequest.Name = "lstRequest";
            this.lstRequest.Size = new System.Drawing.Size(118, 160);
            this.lstRequest.TabIndex = 89;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(368, 247);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 90;
            this.btnRequest.Text = "OK";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(363, 45);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(103, 25);
            this.lblRequest.TabIndex = 91;
            this.lblRequest.Text = "Requests";
            this.lblRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCreateSubjects
            // 
            this.lstCreateSubjects.FormattingEnabled = true;
            this.lstCreateSubjects.Location = new System.Drawing.Point(275, 197);
            this.lstCreateSubjects.Name = "lstCreateSubjects";
            this.lstCreateSubjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCreateSubjects.Size = new System.Drawing.Size(72, 108);
            this.lstCreateSubjects.TabIndex = 92;
            // 
            // lstCreateYears
            // 
            this.lstCreateYears.FormattingEnabled = true;
            this.lstCreateYears.Location = new System.Drawing.Point(266, 108);
            this.lstCreateYears.Name = "lstCreateYears";
            this.lstCreateYears.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCreateYears.Size = new System.Drawing.Size(81, 82);
            this.lstCreateYears.TabIndex = 93;
            // 
            // cbbCreateClass
            // 
            this.cbbCreateClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCreateClass.FormattingEnabled = true;
            this.cbbCreateClass.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.cbbCreateClass.Location = new System.Drawing.Point(275, 106);
            this.cbbCreateClass.Name = "cbbCreateClass";
            this.cbbCreateClass.Size = new System.Drawing.Size(72, 21);
            this.cbbCreateClass.TabIndex = 94;
            // 
            // lblCreateClass
            // 
            this.lblCreateClass.AutoSize = true;
            this.lblCreateClass.Location = new System.Drawing.Point(234, 109);
            this.lblCreateClass.Name = "lblCreateClass";
            this.lblCreateClass.Size = new System.Drawing.Size(35, 13);
            this.lblCreateClass.TabIndex = 95;
            this.lblCreateClass.Text = "Class:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(491, 317);
            this.Controls.Add(this.lblCreateClass);
            this.Controls.Add(this.cbbCreateClass);
            this.Controls.Add(this.lstCreateYears);
            this.Controls.Add(this.lstCreateSubjects);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lstRequest);
            this.Controls.Add(this.txtCreateAdress);
            this.Controls.Add(this.lblCreateAdress);
            this.Controls.Add(this.txtCreateContact);
            this.Controls.Add(this.lblCreateContact);
            this.Controls.Add(this.lblbCreateSubject);
            this.Controls.Add(this.txtCreateNIF);
            this.Controls.Add(this.lblCreateNIF);
            this.Controls.Add(this.txtCreateNum);
            this.Controls.Add(this.lblCreateNum);
            this.Controls.Add(this.lblCreateYear);
            this.Controls.Add(this.txtCreateName);
            this.Controls.Add(this.lblCreateName);
            this.Controls.Add(this.btnAdminLeave);
            this.Controls.Add(this.lblCreateType);
            this.Controls.Add(this.cbCreateS_T);
            this.Controls.Add(this.txtCreateBalance);
            this.Controls.Add(this.lblCreateBalance);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.lblCreateAcc);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ListBox lstRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.ListBox lstCreateSubjects;
        private System.Windows.Forms.ListBox lstCreateYears;
        private System.Windows.Forms.ComboBox cbbCreateClass;
        private System.Windows.Forms.Label lblCreateClass;
    }
}