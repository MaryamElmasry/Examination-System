namespace application.Forms.adminForms
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            panelShowReports = new Panel();
            panel3 = new Panel();
            btnAddDept = new Button();
            label1 = new Label();
            lblRoleName = new Label();
            lblWelcome = new Label();
            picStudent = new PictureBox();
            button3 = new Button();
            lblUserName = new Label();
            lblRoleError = new Label();
            panel4 = new Panel();
            btnClose = new Button();
            label9 = new Label();
            panelShow = new Panel();
            button1 = new Button();
            btnEditDept = new Button();
            label3 = new Label();
            label2 = new Label();
            cbBranch = new ComboBox();
            txtDeptName = new TextBox();
            lstDepts = new ListBox();
            panelShowReports.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panel4.SuspendLayout();
            panelShow.SuspendLayout();
            SuspendLayout();
            // 
            // panelShowReports
            // 
            panelShowReports.Controls.Add(panel3);
            panelShowReports.Controls.Add(panel4);
            panelShowReports.Controls.Add(panelShow);
            panelShowReports.Location = new Point(-7, -3);
            panelShowReports.Margin = new Padding(3, 2, 3, 2);
            panelShowReports.Name = "panelShowReports";
            panelShowReports.Size = new Size(808, 456);
            panelShowReports.TabIndex = 52;
            panelShowReports.Tag = "myTheme";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Controls.Add(btnAddDept);
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
            // btnAddDept
            // 
            btnAddDept.BackColor = Color.Teal;
            btnAddDept.FlatAppearance.BorderSize = 0;
            btnAddDept.FlatStyle = FlatStyle.Flat;
            btnAddDept.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddDept.ForeColor = Color.White;
            btnAddDept.Location = new Point(624, 21);
            btnAddDept.Name = "btnAddDept";
            btnAddDept.Size = new Size(157, 31);
            btnAddDept.TabIndex = 7;
            btnAddDept.Text = "Add department";
            btnAddDept.UseVisualStyleBackColor = false;
            btnAddDept.Click += btnAddDept_Click;
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
            lblRoleName.Size = new Size(93, 18);
            lblRoleName.TabIndex = 35;
            lblRoleName.Text = "Departments";
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
            label9.Size = new Size(182, 20);
            label9.TabIndex = 8;
            label9.Text = "DisplayDepartments Form";
            // 
            // panelShow
            // 
            panelShow.Controls.Add(button1);
            panelShow.Controls.Add(btnEditDept);
            panelShow.Controls.Add(label3);
            panelShow.Controls.Add(label2);
            panelShow.Controls.Add(cbBranch);
            panelShow.Controls.Add(txtDeptName);
            panelShow.Controls.Add(lstDepts);
            panelShow.Location = new Point(6, 113);
            panelShow.Margin = new Padding(3, 2, 3, 2);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(802, 344);
            panelShow.TabIndex = 50;
            panelShow.Tag = "myTheme";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(445, 199);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEditDept
            // 
            btnEditDept.BackColor = Color.Teal;
            btnEditDept.FlatAppearance.BorderSize = 0;
            btnEditDept.FlatStyle = FlatStyle.Flat;
            btnEditDept.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditDept.ForeColor = Color.White;
            btnEditDept.Location = new Point(541, 199);
            btnEditDept.Name = "btnEditDept";
            btnEditDept.Size = new Size(90, 31);
            btnEditDept.TabIndex = 5;
            btnEditDept.Text = "Edit";
            btnEditDept.UseVisualStyleBackColor = false;
            btnEditDept.Click += btnEditDept_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(295, 156);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 4;
            label3.Text = "Department Branch :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(295, 108);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "Department name :";
            // 
            // cbBranch
            // 
            cbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranch.FormattingEnabled = true;
            cbBranch.Location = new Point(446, 157);
            cbBranch.Name = "cbBranch";
            cbBranch.Size = new Size(185, 23);
            cbBranch.TabIndex = 2;
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(446, 108);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(185, 23);
            txtDeptName.TabIndex = 1;
            // 
            // lstDepts
            // 
            lstDepts.FormattingEnabled = true;
            lstDepts.ItemHeight = 15;
            lstDepts.Location = new Point(4, 0);
            lstDepts.Name = "lstDepts";
            lstDepts.Size = new Size(169, 334);
            lstDepts.TabIndex = 0;
            lstDepts.SelectedIndexChanged += lstDepts_SelectedIndexChanged;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelShowReports);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Departments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Departments";
            panelShowReports.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelShowReports;
        private Panel panelShow;
        private ListBox lstDepts;
        private Panel panel3;
        private Label label1;
        private Label lblRoleName;
        private Label lblWelcome;
        private PictureBox picStudent;
        private Button button3;
        private Label lblUserName;
        private Label lblRoleError;
        private Panel panel4;
        private Label label9;
        private Button btnClose;
        private Button btnEditDept;
        private Label label3;
        private Label label2;
        private ComboBox cbBranch;
        private TextBox txtDeptName;
        private Button btnAddDept;
        private Button button1;
    }
}