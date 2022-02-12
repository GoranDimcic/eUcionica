
namespace eUcionica.Forms
{
    partial class Grade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxTests = new System.Windows.Forms.ComboBox();
            this.ComboBoxStudents = new System.Windows.Forms.ComboBox();
            this.TxtAnswers = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxGrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSubmitGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student";
            // 
            // ComboBoxTests
            // 
            this.ComboBoxTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTests.FormattingEnabled = true;
            this.ComboBoxTests.Location = new System.Drawing.Point(150, 51);
            this.ComboBoxTests.Name = "ComboBoxTests";
            this.ComboBoxTests.Size = new System.Drawing.Size(165, 28);
            this.ComboBoxTests.TabIndex = 3;
            this.ComboBoxTests.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTests_SelectedIndexChanged);
            // 
            // ComboBoxStudents
            // 
            this.ComboBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStudents.FormattingEnabled = true;
            this.ComboBoxStudents.Location = new System.Drawing.Point(150, 101);
            this.ComboBoxStudents.Name = "ComboBoxStudents";
            this.ComboBoxStudents.Size = new System.Drawing.Size(165, 28);
            this.ComboBoxStudents.TabIndex = 4;
            this.ComboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStudents_SelectedIndexChanged);
            // 
            // TxtAnswers
            // 
            this.TxtAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnswers.Location = new System.Drawing.Point(150, 151);
            this.TxtAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAnswers.Multiline = true;
            this.TxtAnswers.Name = "TxtAnswers";
            this.TxtAnswers.Size = new System.Drawing.Size(165, 200);
            this.TxtAnswers.TabIndex = 5;
            // 
            // TxtResult
            // 
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.Location = new System.Drawing.Point(450, 151);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(2);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(165, 200);
            this.TxtResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Result";
            // 
            // ComboBoxGrade
            // 
            this.ComboBoxGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxGrade.FormattingEnabled = true;
            this.ComboBoxGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComboBoxGrade.Location = new System.Drawing.Point(650, 200);
            this.ComboBoxGrade.Name = "ComboBoxGrade";
            this.ComboBoxGrade.Size = new System.Drawing.Size(156, 28);
            this.ComboBoxGrade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Grade";
            // 
            // BtnSubmitGrade
            // 
            this.BtnSubmitGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitGrade.Location = new System.Drawing.Point(325, 400);
            this.BtnSubmitGrade.Name = "BtnSubmitGrade";
            this.BtnSubmitGrade.Size = new System.Drawing.Size(150, 40);
            this.BtnSubmitGrade.TabIndex = 8;
            this.BtnSubmitGrade.Text = "Submit";
            this.BtnSubmitGrade.UseVisualStyleBackColor = true;
            this.BtnSubmitGrade.Click += new System.EventHandler(this.BtnSubmitGrade_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.BtnSubmitGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtAnswers);
            this.Controls.Add(this.ComboBoxStudents);
            this.Controls.Add(this.ComboBoxTests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Grade";
            this.Text = "Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxTests;
        private System.Windows.Forms.ComboBox ComboBoxStudents;
        private System.Windows.Forms.TextBox TxtAnswers;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSubmitGrade;
    }
}