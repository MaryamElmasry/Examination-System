namespace application.Forms.adminForms
{
    partial class ManageInstructorCourses
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
            listBoxInsCourses = new ListBox();
            listBoxBranchCourses = new ListBox();
            btnAddCourse = new Button();
            btnRemoveCourse = new Button();
            SuspendLayout();
            // 
            // listBoxInsCourses
            // 
            listBoxInsCourses.FormattingEnabled = true;
            listBoxInsCourses.Location = new Point(527, 74);
            listBoxInsCourses.Name = "listBoxInsCourses";
            listBoxInsCourses.Size = new Size(207, 204);
            listBoxInsCourses.TabIndex = 0;
            // 
            // listBoxBranchCourses
            // 
            listBoxBranchCourses.FormattingEnabled = true;
            listBoxBranchCourses.Location = new Point(29, 74);
            listBoxBranchCourses.Name = "listBoxBranchCourses";
            listBoxBranchCourses.Size = new Size(207, 204);
            listBoxBranchCourses.TabIndex = 1;
            // 
            // btnAddCourse
            // 
            btnAddCourse.BackColor = Color.Teal;
            btnAddCourse.FlatAppearance.BorderSize = 0;
            btnAddCourse.FlatStyle = FlatStyle.Flat;
            btnAddCourse.Font = new Font("Segoe UI", 11F);
            btnAddCourse.ForeColor = SystemColors.ButtonFace;
            btnAddCourse.Location = new Point(284, 106);
            btnAddCourse.Margin = new Padding(3, 4, 3, 4);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(175, 48);
            btnAddCourse.TabIndex = 6;
            btnAddCourse.Text = "Add ->";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnRemoveCourse
            // 
            btnRemoveCourse.BackColor = Color.Crimson;
            btnRemoveCourse.FlatAppearance.BorderSize = 0;
            btnRemoveCourse.FlatStyle = FlatStyle.Flat;
            btnRemoveCourse.Font = new Font("Segoe UI", 11F);
            btnRemoveCourse.ForeColor = SystemColors.ButtonFace;
            btnRemoveCourse.Location = new Point(284, 199);
            btnRemoveCourse.Margin = new Padding(3, 4, 3, 4);
            btnRemoveCourse.Name = "btnRemoveCourse";
            btnRemoveCourse.Size = new Size(175, 48);
            btnRemoveCourse.TabIndex = 7;
            btnRemoveCourse.Text = "<- Remove";
            btnRemoveCourse.UseVisualStyleBackColor = false;
            btnRemoveCourse.Click += btnRemoveCourse_Click;
            // 
            // ManageInstructorCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 345);
            Controls.Add(btnRemoveCourse);
            Controls.Add(btnAddCourse);
            Controls.Add(listBoxBranchCourses);
            Controls.Add(listBoxInsCourses);
            Name = "ManageInstructorCourses";
            Text = "ManageInstructorCourses";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxInsCourses;
        private ListBox listBoxBranchCourses;
        private Button btnAddCourse;
        private Button btnRemoveCourse;
    }
}