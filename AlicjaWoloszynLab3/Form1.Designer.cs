namespace SQLTest

{
    partial class Form1
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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonViewGrades = new System.Windows.Forms.Button();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonViewCourses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alicja Woloszyn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(485, 334);
            this.dataGridViewData.TabIndex = 1;
            // 
            // buttonViewGrades
            // 
            this.buttonViewGrades.Location = new System.Drawing.Point(549, 52);
            this.buttonViewGrades.Name = "buttonViewGrades";
            this.buttonViewGrades.Size = new System.Drawing.Size(126, 43);
            this.buttonViewGrades.TabIndex = 2;
            this.buttonViewGrades.Text = "View grades";
            this.buttonViewGrades.UseVisualStyleBackColor = true;
            this.buttonViewGrades.Click += new System.EventHandler(this.buttonViewGrades_Click);
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(549, 240);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(126, 20);
            this.textBoxCourseName.TabIndex = 3;
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Location = new System.Drawing.Point(549, 190);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(126, 20);
            this.textBoxTeacherName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "name of lecturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "name of course:";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(549, 284);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(126, 43);
            this.buttonAddCourse.TabIndex = 7;
            this.buttonAddCourse.Text = "Add new course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonViewCourses
            // 
            this.buttonViewCourses.Location = new System.Drawing.Point(549, 343);
            this.buttonViewCourses.Name = "buttonViewCourses";
            this.buttonViewCourses.Size = new System.Drawing.Size(126, 43);
            this.buttonViewCourses.TabIndex = 8;
            this.buttonViewCourses.Text = "View courses";
            this.buttonViewCourses.UseVisualStyleBackColor = true;
            this.buttonViewCourses.Click += new System.EventHandler(this.buttonViewCourses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewCourses);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTeacherName);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.buttonViewGrades);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonViewGrades;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonViewCourses;
    }
}

