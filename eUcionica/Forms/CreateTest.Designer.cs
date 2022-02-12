
namespace eUcionica.Forms
{
    partial class CreateTest
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
            this.BtnAddTest = new System.Windows.Forms.Button();
            this.TxtAnswers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuestions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProfessorSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTestName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddTest
            // 
            this.BtnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTest.Location = new System.Drawing.Point(325, 400);
            this.BtnAddTest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddTest.Name = "BtnAddTest";
            this.BtnAddTest.Size = new System.Drawing.Size(150, 40);
            this.BtnAddTest.TabIndex = 9;
            this.BtnAddTest.Text = "Add test";
            this.BtnAddTest.UseVisualStyleBackColor = true;
            this.BtnAddTest.Click += new System.EventHandler(this.BtnAddTest_Click_1);
            // 
            // TxtAnswers
            // 
            this.TxtAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnswers.Location = new System.Drawing.Point(485, 150);
            this.TxtAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAnswers.Multiline = true;
            this.TxtAnswers.Name = "TxtAnswers";
            this.TxtAnswers.Size = new System.Drawing.Size(165, 209);
            this.TxtAnswers.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Answers:";
            // 
            // TxtQuestions
            // 
            this.TxtQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestions.Location = new System.Drawing.Point(150, 151);
            this.TxtQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.TxtQuestions.Multiline = true;
            this.TxtQuestions.Name = "TxtQuestions";
            this.TxtQuestions.Size = new System.Drawing.Size(165, 208);
            this.TxtQuestions.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Questions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // DateTime
            // 
            this.DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.Location = new System.Drawing.Point(485, 45);
            this.DateTime.Margin = new System.Windows.Forms.Padding(2);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(151, 31);
            this.DateTime.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // TxtProfessorSubject
            // 
            this.TxtProfessorSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProfessorSubject.Location = new System.Drawing.Point(150, 51);
            this.TxtProfessorSubject.Name = "TxtProfessorSubject";
            this.TxtProfessorSubject.ReadOnly = true;
            this.TxtProfessorSubject.Size = new System.Drawing.Size(165, 26);
            this.TxtProfessorSubject.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // TxtTestName
            // 
            this.TxtTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTestName.Location = new System.Drawing.Point(150, 101);
            this.TxtTestName.Name = "TxtTestName";
            this.TxtTestName.Size = new System.Drawing.Size(165, 26);
            this.TxtTestName.TabIndex = 6;
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.TxtTestName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtProfessorSubject);
            this.Controls.Add(this.BtnAddTest);
            this.Controls.Add(this.TxtAnswers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label1);
            this.Name = "CreateTest";
            this.Text = "CreateTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddTest;
        private System.Windows.Forms.TextBox TxtAnswers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuestions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProfessorSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTestName;
    }
}