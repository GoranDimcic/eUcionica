namespace eUcionica.Forms
{
    partial class ProfessorView
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
            this.BtnCreateTest = new System.Windows.Forms.Button();
            this.BtnGradeTest = new System.Windows.Forms.Button();
            this.BtnUpdateTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateTest
            // 
            this.BtnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateTest.Location = new System.Drawing.Point(50, 100);
            this.BtnCreateTest.Name = "BtnCreateTest";
            this.BtnCreateTest.Size = new System.Drawing.Size(100, 50);
            this.BtnCreateTest.TabIndex = 0;
            this.BtnCreateTest.Text = "Create test";
            this.BtnCreateTest.UseVisualStyleBackColor = true;
            this.BtnCreateTest.Click += new System.EventHandler(this.BtnCreateTest_Click);
            // 
            // BtnGradeTest
            // 
            this.BtnGradeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGradeTest.Location = new System.Drawing.Point(200, 100);
            this.BtnGradeTest.Name = "BtnGradeTest";
            this.BtnGradeTest.Size = new System.Drawing.Size(100, 50);
            this.BtnGradeTest.TabIndex = 1;
            this.BtnGradeTest.Text = "Grade test";
            this.BtnGradeTest.UseVisualStyleBackColor = true;
            this.BtnGradeTest.Click += new System.EventHandler(this.BtnGradeTest_Click);
            // 
            // BtnUpdateTest
            // 
            this.BtnUpdateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateTest.Location = new System.Drawing.Point(350, 100);
            this.BtnUpdateTest.Name = "BtnUpdateTest";
            this.BtnUpdateTest.Size = new System.Drawing.Size(100, 50);
            this.BtnUpdateTest.TabIndex = 2;
            this.BtnUpdateTest.Text = "Update test";
            this.BtnUpdateTest.UseVisualStyleBackColor = true;
            this.BtnUpdateTest.Click += new System.EventHandler(this.BtnUpdateTest_Click);
            // 
            // ProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.BtnUpdateTest);
            this.Controls.Add(this.BtnGradeTest);
            this.Controls.Add(this.BtnCreateTest);
            this.Name = "ProfessorView";
            this.Text = "ProfessorView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateTest;
        private System.Windows.Forms.Button BtnGradeTest;
        private System.Windows.Forms.Button BtnUpdateTest;
    }
}