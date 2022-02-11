
namespace eUcionica.RegistryLoginForm
{
    partial class StudentRegistry
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
            this.BtnRegistryStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordStudent = new System.Windows.Forms.TextBox();
            this.txtEmailStudent = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegistryStudent
            // 
            this.BtnRegistryStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistryStudent.Location = new System.Drawing.Point(215, 250);
            this.BtnRegistryStudent.Name = "BtnRegistryStudent";
            this.BtnRegistryStudent.Size = new System.Drawing.Size(150, 50);
            this.BtnRegistryStudent.TabIndex = 7;
            this.BtnRegistryStudent.Text = "Sign up";
            this.BtnRegistryStudent.UseVisualStyleBackColor = true;
            this.BtnRegistryStudent.Click += new System.EventHandler(this.BtnRegistryStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-mail";
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameStudent.Location = new System.Drawing.Point(215, 200);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(150, 29);
            this.txtNameStudent.TabIndex = 6;
            this.txtNameStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // txtPasswordStudent
            // 
            this.txtPasswordStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordStudent.Location = new System.Drawing.Point(215, 150);
            this.txtPasswordStudent.Name = "txtPasswordStudent";
            this.txtPasswordStudent.Size = new System.Drawing.Size(150, 29);
            this.txtPasswordStudent.TabIndex = 5;
            this.txtPasswordStudent.UseSystemPasswordChar = true;
            this.txtPasswordStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
            // 
            // txtEmailStudent
            // 
            this.txtEmailStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailStudent.Location = new System.Drawing.Point(215, 100);
            this.txtEmailStudent.Name = "txtEmailStudent";
            this.txtEmailStudent.Size = new System.Drawing.Size(150, 29);
            this.txtEmailStudent.TabIndex = 4;
            this.txtEmailStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 152);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Password";
            // 
            // lblLoginStudent
            // 
            this.lblLoginStudent.AutoSize = true;
            this.lblLoginStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginStudent.Location = new System.Drawing.Point(175, 50);
            this.lblLoginStudent.Name = "lblLoginStudent";
            this.lblLoginStudent.Size = new System.Drawing.Size(221, 25);
            this.lblLoginStudent.TabIndex = 46;
            this.lblLoginStudent.Text = "Registry your account";
            // 
            // StudentRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.BtnRegistryStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasswordStudent);
            this.Controls.Add(this.txtEmailStudent);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLoginStudent);
            this.Name = "StudentRegistry";
            this.Text = "StudentRegistry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistryStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordStudent;
        private System.Windows.Forms.TextBox txtEmailStudent;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLoginStudent;
    }
}