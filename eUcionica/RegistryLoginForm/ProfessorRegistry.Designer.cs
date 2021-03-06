
namespace eUcionica.RegistryLoginForm
{
    partial class ProfessorRegistry
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
            this.BtnRegistryProfessor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNameProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPasswordProfessor = new System.Windows.Forms.TextBox();
            this.TxtEmailProfessor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginProfessor = new System.Windows.Forms.Label();
            this.ComboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnRegistryProfessor
            // 
            this.BtnRegistryProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistryProfessor.Location = new System.Drawing.Point(215, 300);
            this.BtnRegistryProfessor.Name = "BtnRegistryProfessor";
            this.BtnRegistryProfessor.Size = new System.Drawing.Size(150, 40);
            this.BtnRegistryProfessor.TabIndex = 9;
            this.BtnRegistryProfessor.Text = "Sign up";
            this.BtnRegistryProfessor.UseVisualStyleBackColor = true;
            this.BtnRegistryProfessor.Click += new System.EventHandler(this.BtnRegistryProfessor_Click);
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
            // TxtNameProfessor
            // 
            this.TxtNameProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameProfessor.Location = new System.Drawing.Point(215, 200);
            this.TxtNameProfessor.Name = "TxtNameProfessor";
            this.TxtNameProfessor.Size = new System.Drawing.Size(150, 29);
            this.TxtNameProfessor.TabIndex = 7;
            this.TxtNameProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
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
            // TxtPasswordProfessor
            // 
            this.TxtPasswordProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasswordProfessor.Location = new System.Drawing.Point(215, 152);
            this.TxtPasswordProfessor.Name = "TxtPasswordProfessor";
            this.TxtPasswordProfessor.Size = new System.Drawing.Size(150, 29);
            this.TxtPasswordProfessor.TabIndex = 6;
            this.TxtPasswordProfessor.UseSystemPasswordChar = true;
            this.TxtPasswordProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
            // 
            // TxtEmailProfessor
            // 
            this.TxtEmailProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailProfessor.Location = new System.Drawing.Point(215, 100);
            this.TxtEmailProfessor.Name = "TxtEmailProfessor";
            this.TxtEmailProfessor.Size = new System.Drawing.Size(150, 29);
            this.TxtEmailProfessor.TabIndex = 5;
            this.TxtEmailProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject";
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
            // lblLoginProfessor
            // 
            this.lblLoginProfessor.AutoSize = true;
            this.lblLoginProfessor.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginProfessor.Location = new System.Drawing.Point(175, 50);
            this.lblLoginProfessor.Name = "lblLoginProfessor";
            this.lblLoginProfessor.Size = new System.Drawing.Size(221, 25);
            this.lblLoginProfessor.TabIndex = 34;
            this.lblLoginProfessor.Text = "Registry your account";
            // 
            // ComboBoxSubjects
            // 
            this.ComboBoxSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubjects.FormattingEnabled = true;
            this.ComboBoxSubjects.Items.AddRange(new object[] {
            "Srpski",
            "Matematika",
            "Engleski",
            "Fizika",
            "Hemija"});
            this.ComboBoxSubjects.Location = new System.Drawing.Point(215, 250);
            this.ComboBoxSubjects.Name = "ComboBoxSubjects";
            this.ComboBoxSubjects.Size = new System.Drawing.Size(150, 32);
            this.ComboBoxSubjects.TabIndex = 8;
            // 
            // ProfessorRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.ComboBoxSubjects);
            this.Controls.Add(this.BtnRegistryProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNameProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPasswordProfessor);
            this.Controls.Add(this.TxtEmailProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLoginProfessor);
            this.Name = "ProfessorRegistry";
            this.Text = "ProfessorRegistry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistryProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNameProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPasswordProfessor;
        private System.Windows.Forms.TextBox TxtEmailProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLoginProfessor;
        private System.Windows.Forms.ComboBox ComboBoxSubjects;
    }
}