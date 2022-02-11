﻿
namespace eUcionica.RegistryLoginForm
{
    partial class StudentLogin
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
            this.lblLoginStudent = new System.Windows.Forms.Label();
            this.BtnLoginAsStudent = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPasswordLoginStudent = new System.Windows.Forms.TextBox();
            this.txtEmailLoginStudent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLoginStudent
            // 
            this.lblLoginStudent.AutoSize = true;
            this.lblLoginStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginStudent.ForeColor = System.Drawing.Color.Black;
            this.lblLoginStudent.Location = new System.Drawing.Point(175, 77);
            this.lblLoginStudent.Name = "lblLoginStudent";
            this.lblLoginStudent.Size = new System.Drawing.Size(138, 25);
            this.lblLoginStudent.TabIndex = 18;
            this.lblLoginStudent.Text = "Student login";
            // 
            // BtnLoginAsStudent
            // 
            this.BtnLoginAsStudent.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginAsStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginAsStudent.Location = new System.Drawing.Point(171, 230);
            this.BtnLoginAsStudent.Name = "BtnLoginAsStudent";
            this.BtnLoginAsStudent.Size = new System.Drawing.Size(150, 50);
            this.BtnLoginAsStudent.TabIndex = 17;
            this.BtnLoginAsStudent.Text = "Login";
            this.BtnLoginAsStudent.UseVisualStyleBackColor = false;
            this.BtnLoginAsStudent.Click += new System.EventHandler(this.BtnLoginAsStudent_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(16, 177);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(50, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail";
            // 
            // txtPasswordLoginStudent
            // 
            this.txtPasswordLoginStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLoginStudent.Location = new System.Drawing.Point(171, 175);
            this.txtPasswordLoginStudent.Name = "txtPasswordLoginStudent";
            this.txtPasswordLoginStudent.Size = new System.Drawing.Size(150, 29);
            this.txtPasswordLoginStudent.TabIndex = 14;
            this.txtPasswordLoginStudent.UseSystemPasswordChar = true;
            // 
            // txtEmailLoginStudent
            // 
            this.txtEmailLoginStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLoginStudent.Location = new System.Drawing.Point(171, 125);
            this.txtEmailLoginStudent.Name = "txtEmailLoginStudent";
            this.txtEmailLoginStudent.Size = new System.Drawing.Size(150, 29);
            this.txtEmailLoginStudent.TabIndex = 13;
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.lblLoginStudent);
            this.Controls.Add(this.BtnLoginAsStudent);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPasswordLoginStudent);
            this.Controls.Add(this.txtEmailLoginStudent);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginStudent;
        private System.Windows.Forms.Button BtnLoginAsStudent;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPasswordLoginStudent;
        private System.Windows.Forms.TextBox txtEmailLoginStudent;
    }
}