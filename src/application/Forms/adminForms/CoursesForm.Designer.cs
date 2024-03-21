namespace application.Forms.adminForms
{
    partial class CoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesForm));
            lstCourses = new ListBox();
            panel3 = new Panel();
            btnAddCourse = new Button();
            label1 = new Label();
            lblRoleName = new Label();
            lblWelcome = new Label();
            picStudent = new PictureBox();
            button3 = new Button();
            lblUserName = new Label();
            lblRoleError = new Label();
            btnDeleteCourse = new Button();
            btnEditCourse = new Button();
            label3 = new Label();
            label2 = new Label();
            panelShowReports = new Panel();
            panel4 = new Panel();
            btnClose = new Button();
            label9 = new Label();
            panelShow = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnDeleteTopic = new Button();
            txtTopic = new TextBox();
            btnAddTopic = new Button();
            cLTopics = new ListBox();
            cLInstructors = new CheckedListBox();
            clCourseDepts = new CheckedListBox();
            label5 = new Label();
            label4 = new Label();
            txtCourseName = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panelShowReports.SuspendLayout();
            panel4.SuspendLayout();
            panelShow.SuspendLayout();
            SuspendLayout();
            // 
            // lstCourses
            // 
            lstCourses.FormattingEnabled = true;
            lstCourses.ItemHeight = 15;
            lstCourses.Location = new Point(4, 0);
            lstCourses.Name = "lstCourses";
            lstCourses.Size = new Size(169, 364);
            lstCourses.TabIndex = 0;
            lstCourses.SelectedIndexChanged += lstCourses_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Controls.Add(btnAddCourse);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblRoleName);
            panel3.Controls.Add(lblWelcome);
            panel3.Controls.Add(picStudent);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(lblUserName);
            panel3.Controls.Add(lblRoleError);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 75);
            panel3.TabIndex = 51;
            // 
            // btnAddCourse
            // 
            btnAddCourse.BackColor = Color.Teal;
            btnAddCourse.FlatAppearance.BorderSize = 0;
            btnAddCourse.FlatStyle = FlatStyle.Flat;
            btnAddCourse.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddCourse.ForeColor = Color.White;
            btnAddCourse.Location = new Point(624, 21);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(157, 31);
            btnAddCourse.TabIndex = 7;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(97, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 36;
            label1.Text = "Page:";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Font = new Font("Microsoft Sans Serif", 11F);
            lblRoleName.ImeMode = ImeMode.NoControl;
            lblRoleName.Location = new Point(188, 40);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(65, 18);
            lblRoleName.TabIndex = 35;
            lblRoleName.Text = "Courses";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblWelcome.ImeMode = ImeMode.NoControl;
            lblWelcome.Location = new Point(97, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(89, 18);
            lblWelcome.TabIndex = 33;
            lblWelcome.Text = "Welcome: ";
            // 
            // picStudent
            // 
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.ImeMode = ImeMode.NoControl;
            picStudent.Location = new Point(10, 0);
            picStudent.Margin = new Padding(3, 2, 3, 2);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(81, 72);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 28;
            picStudent.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(745, 6);
            button3.Name = "button3";
            button3.Size = new Size(34, 28);
            button3.TabIndex = 30;
            button3.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 11F);
            lblUserName.ImeMode = ImeMode.NoControl;
            lblUserName.Location = new Point(188, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(49, 18);
            lblUserName.TabIndex = 29;
            lblUserName.Text = "Admin";
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.ForeColor = Color.IndianRed;
            lblRoleError.ImeMode = ImeMode.NoControl;
            lblRoleError.Location = new Point(129, 422);
            lblRoleError.MaximumSize = new Size(139, 0);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(0, 15);
            lblRoleError.TabIndex = 27;
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.BackColor = Color.IndianRed;
            btnDeleteCourse.FlatAppearance.BorderSize = 0;
            btnDeleteCourse.FlatStyle = FlatStyle.Flat;
            btnDeleteCourse.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteCourse.ForeColor = Color.White;
            btnDeleteCourse.Location = new Point(661, 85);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(112, 31);
            btnDeleteCourse.TabIndex = 6;
            btnDeleteCourse.Text = "Delete course";
            btnDeleteCourse.UseVisualStyleBackColor = false;
            // 
            // btnEditCourse
            // 
            btnEditCourse.BackColor = Color.Teal;
            btnEditCourse.FlatAppearance.BorderSize = 0;
            btnEditCourse.FlatStyle = FlatStyle.Flat;
            btnEditCourse.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditCourse.ForeColor = Color.White;
            btnEditCourse.Location = new Point(661, 37);
            btnEditCourse.Name = "btnEditCourse";
            btnEditCourse.Size = new Size(112, 31);
            btnEditCourse.TabIndex = 5;
            btnEditCourse.Text = "Update name";
            btnEditCourse.UseVisualStyleBackColor = false;
            btnEditCourse.Click += btnEditCourse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(221, 85);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 4;
            label3.Text = "Course Departments :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(221, 37);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 3;
            label2.Text = "Course name :";
            // 
            // panelShowReports
            // 
            panelShowReports.Controls.Add(panel3);
            panelShowReports.Controls.Add(panel4);
            panelShowReports.Controls.Add(panelShow);
            panelShowReports.Location = new Point(-4, -3);
            panelShowReports.Margin = new Padding(3, 2, 3, 2);
            panelShowReports.Name = "panelShowReports";
            panelShowReports.Size = new Size(808, 456);
            panelShowReports.TabIndex = 53;
            panelShowReports.Tag = "myTheme";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(73, 178, 202);
            panel4.Controls.Add(btnClose);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(808, 37);
            panel4.TabIndex = 50;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ImeMode = ImeMode.NoControl;
            btnClose.Location = new Point(769, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 37);
            btnClose.TabIndex = 37;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.White;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(12, 7);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 8;
            label9.Text = "Courses Form";
            // 
            // panelShow
            // 
            panelShow.Controls.Add(lstCourses);
            panelShow.Controls.Add(button2);
            panelShow.Controls.Add(button1);
            panelShow.Controls.Add(btnDeleteTopic);
            panelShow.Controls.Add(txtTopic);
            panelShow.Controls.Add(btnAddTopic);
            panelShow.Controls.Add(cLTopics);
            panelShow.Controls.Add(cLInstructors);
            panelShow.Controls.Add(clCourseDepts);
            panelShow.Controls.Add(label5);
            panelShow.Controls.Add(label4);
            panelShow.Controls.Add(btnDeleteCourse);
            panelShow.Controls.Add(btnEditCourse);
            panelShow.Controls.Add(label3);
            panelShow.Controls.Add(label2);
            panelShow.Controls.Add(txtCourseName);
            panelShow.Location = new Point(6, 113);
            panelShow.Margin = new Padding(3, 2, 3, 2);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(802, 377);
            panelShow.TabIndex = 50;
            panelShow.Tag = "myTheme";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(504, 185);
            button2.Name = "button2";
            button2.Size = new Size(76, 31);
            button2.TabIndex = 19;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(504, 112);
            button1.Name = "button1";
            button1.Size = new Size(76, 31);
            button1.TabIndex = 18;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDeleteTopic
            // 
            btnDeleteTopic.BackColor = Color.IndianRed;
            btnDeleteTopic.FlatAppearance.BorderSize = 0;
            btnDeleteTopic.FlatStyle = FlatStyle.Flat;
            btnDeleteTopic.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteTopic.ForeColor = Color.White;
            btnDeleteTopic.Location = new Point(504, 293);
            btnDeleteTopic.Name = "btnDeleteTopic";
            btnDeleteTopic.Size = new Size(105, 31);
            btnDeleteTopic.TabIndex = 17;
            btnDeleteTopic.Text = "Delete topic";
            btnDeleteTopic.UseVisualStyleBackColor = false;
            btnDeleteTopic.Click += btnDeleteTopic_Click;
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(618, 264);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(141, 23);
            txtTopic.TabIndex = 16;
            // 
            // btnAddTopic
            // 
            btnAddTopic.BackColor = Color.Teal;
            btnAddTopic.FlatAppearance.BorderSize = 0;
            btnAddTopic.FlatStyle = FlatStyle.Flat;
            btnAddTopic.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddTopic.ForeColor = Color.White;
            btnAddTopic.Location = new Point(504, 256);
            btnAddTopic.Name = "btnAddTopic";
            btnAddTopic.Size = new Size(90, 31);
            btnAddTopic.TabIndex = 15;
            btnAddTopic.Text = "Add topic";
            btnAddTopic.UseVisualStyleBackColor = false;
            btnAddTopic.Click += btnAddTopic_Click;
            // 
            // cLTopics
            // 
            cLTopics.FormattingEnabled = true;
            cLTopics.ItemHeight = 15;
            cLTopics.Location = new Point(378, 230);
            cLTopics.Name = "cLTopics";
            cLTopics.Size = new Size(120, 94);
            cLTopics.TabIndex = 14;
            // 
            // cLInstructors
            // 
            cLInstructors.FormattingEnabled = true;
            cLInstructors.Location = new Point(378, 158);
            cLInstructors.Name = "cLInstructors";
            cLInstructors.Size = new Size(120, 58);
            cLInstructors.TabIndex = 13;
            // 
            // clCourseDepts
            // 
            clCourseDepts.FormattingEnabled = true;
            clCourseDepts.Location = new Point(378, 85);
            clCourseDepts.Name = "clCourseDepts";
            clCourseDepts.Size = new Size(120, 58);
            clCourseDepts.TabIndex = 12;
            clCourseDepts.ItemCheck += clCourseDepts_ItemCheck;
            clCourseDepts.SelectedIndexChanged += clCourseDepts_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(221, 158);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 10;
            label5.Text = "Instructors :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(221, 234);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 8;
            label4.Text = "Course Topics :";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(378, 37);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(185, 23);
            txtCourseName.TabIndex = 1;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(panelShowReports);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CoursesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoursesForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panelShowReports.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstCourses;
        private Panel panel3;
        private Button btnAddCourse;
        private Label label1;
        private Label lblRoleName;
        private Label lblWelcome;
        private PictureBox picStudent;
        private Button button3;
        private Label lblUserName;
        private Label lblRoleError;
        private Button btnDeleteCourse;
        private Button btnEditCourse;
        private Label label3;
        private Label label2;
        private Panel panelShowReports;
        private Panel panel4;
        private Button btnClose;
        private Label label9;
        private Panel panelShow;
        private TextBox txtCourseName;
        private Label label4;
        private Label label5;
        private CheckedListBox clCourseDepts;
        private ListBox cLTopics;
        private CheckedListBox cLInstructors;
        private TextBox txtTopic;
        private Button btnAddTopic;
        private Button btnDeleteTopic;
        private Button button2;
        private Button button1;
    }
}