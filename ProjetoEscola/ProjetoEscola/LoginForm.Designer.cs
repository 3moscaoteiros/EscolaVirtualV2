﻿namespace ProjetoEscola
{
    partial class LoginForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginNum = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginNum = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLoginInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(93, 152);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(97, 24);
            this.lblLoginPassword.TabIndex = 10;
            this.lblLoginPassword.Text = "Password:";
            // 
            // lblLoginNum
            // 
            this.lblLoginNum.AutoSize = true;
            this.lblLoginNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginNum.Location = new System.Drawing.Point(93, 92);
            this.lblLoginNum.Name = "lblLoginNum";
            this.lblLoginNum.Size = new System.Drawing.Size(56, 24);
            this.lblLoginNum.TabIndex = 9;
            this.lblLoginNum.Text = "Num:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(96, 179);
            this.txtLoginPassword.MaxLength = 5;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(100, 29);
            this.txtLoginPassword.TabIndex = 8;
            // 
            // txtLoginNum
            // 
            this.txtLoginNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginNum.Location = new System.Drawing.Point(96, 119);
            this.txtLoginNum.MaxLength = 5;
            this.txtLoginNum.Name = "txtLoginNum";
            this.txtLoginNum.Size = new System.Drawing.Size(100, 29);
            this.txtLoginNum.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(97, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 27);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(75, 33);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(142, 31);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnLoginInfo
            // 
            this.btnLoginInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoginInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoginInfo.FlatAppearance.BorderSize = 0;
            this.btnLoginInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLoginInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoginInfo.Image = global::ProjetoEscola.Properties.Resources.icons8_info_30;
            this.btnLoginInfo.Location = new System.Drawing.Point(256, 12);
            this.btnLoginInfo.Name = "btnLoginInfo";
            this.btnLoginInfo.Size = new System.Drawing.Size(34, 35);
            this.btnLoginInfo.TabIndex = 12;
            this.btnLoginInfo.UseVisualStyleBackColor = false;
            this.btnLoginInfo.Click += new System.EventHandler(this.btnLoginInfo_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(302, 297);
            this.Controls.Add(this.btnLoginInfo);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginNum);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginNum);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginNum;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginNum;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLoginInfo;
    }
}

