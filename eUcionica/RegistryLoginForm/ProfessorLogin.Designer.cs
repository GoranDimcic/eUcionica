
namespace eUcionica.RegistryLoginForm
{
    partial class ProfessorLogin
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
            this.BtnLoginAsProfessor = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.TxtPasswordLoginProfessor = new System.Windows.Forms.TextBox();
            this.TxtEmailLoginProfessor = new System.Windows.Forms.TextBox();
            this.lblLoginProfessor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoginAsProfessor
            // 
            this.BtnLoginAsProfessor.BackColor = System.Drawing.Color.Transparent;
            this.BtnLoginAsProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginAsProfessor.Location = new System.Drawing.Point(171, 230);
            this.BtnLoginAsProfessor.Name = "BtnLoginAsProfessor";
            this.BtnLoginAsProfessor.Size = new System.Drawing.Size(150, 40);
            this.BtnLoginAsProfessor.TabIndex = 5;
            this.BtnLoginAsProfessor.Text = "Login";
            this.BtnLoginAsProfessor.UseVisualStyleBackColor = false;
            this.BtnLoginAsProfessor.Click += new System.EventHandler(this.BtnLoginAsProfessor_Click);
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
            this.lblPassword.TabIndex = 2;
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
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            // 
            // TxtPasswordLoginProfessor
            // 
            this.TxtPasswordLoginProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasswordLoginProfessor.Location = new System.Drawing.Point(171, 175);
            this.TxtPasswordLoginProfessor.Name = "TxtPasswordLoginProfessor";
            this.TxtPasswordLoginProfessor.Size = new System.Drawing.Size(150, 29);
            this.TxtPasswordLoginProfessor.TabIndex = 4;
            this.TxtPasswordLoginProfessor.UseSystemPasswordChar = true;
            this.TxtPasswordLoginProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
            // 
            // TxtEmailLoginProfessor
            // 
            this.TxtEmailLoginProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailLoginProfessor.Location = new System.Drawing.Point(171, 125);
            this.TxtEmailLoginProfessor.Name = "TxtEmailLoginProfessor";
            this.TxtEmailLoginProfessor.Size = new System.Drawing.Size(150, 29);
            this.TxtEmailLoginProfessor.TabIndex = 3;
            this.TxtEmailLoginProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
            // 
            // lblLoginProfessor
            // 
            this.lblLoginProfessor.AutoSize = true;
            this.lblLoginProfessor.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginProfessor.ForeColor = System.Drawing.Color.Black;
            this.lblLoginProfessor.Location = new System.Drawing.Point(170, 80);
            this.lblLoginProfessor.Name = "lblLoginProfessor";
            this.lblLoginProfessor.Size = new System.Drawing.Size(156, 25);
            this.lblLoginProfessor.TabIndex = 12;
            this.lblLoginProfessor.Text = "Professor login";
            // 
            // ProfessorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.lblLoginProfessor);
            this.Controls.Add(this.BtnLoginAsProfessor);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.TxtPasswordLoginProfessor);
            this.Controls.Add(this.TxtEmailLoginProfessor);
            this.Name = "ProfessorLogin";
            this.Text = "ProfessorLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoginAsProfessor;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox TxtPasswordLoginProfessor;
        private System.Windows.Forms.TextBox TxtEmailLoginProfessor;
        private System.Windows.Forms.Label lblLoginProfessor;
    }
}