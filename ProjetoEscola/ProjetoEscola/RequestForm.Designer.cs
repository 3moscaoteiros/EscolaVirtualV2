﻿
namespace ProjetoEscola
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.cbbRequest = new System.Windows.Forms.ComboBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbRequest
            // 
            this.cbbRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRequest.FormattingEnabled = true;
            this.cbbRequest.Items.AddRange(new object[] {
            "Name",
            "Num",
            "NIF",
            "Adress",
            "Contact"});
            this.cbbRequest.Location = new System.Drawing.Point(63, 51);
            this.cbbRequest.Name = "cbbRequest";
            this.cbbRequest.Size = new System.Drawing.Size(158, 21);
            this.cbbRequest.TabIndex = 0;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(63, 94);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(158, 20);
            this.txtRequest.TabIndex = 1;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(63, 133);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(158, 23);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "OK";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What do you want to change?";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(285, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.cbbRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestForm";
            this.Text = "Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RequestForm_FormClosed);
            this.Load += new System.EventHandler(this.Request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbRequest;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label1;
    }
}