namespace application.Forms
{
    partial class Branches
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branches));
            gvBranches = new DataGridView();
            panelShowReports = new Panel();
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripPageLabel = new ToolStripLabel();
            panelShow = new Panel();
            btnAddBranch = new Button();
            lblRoleError = new Label();
            picStudent = new PictureBox();
            button3 = new Button();
            lblUserName = new Label();
            lblRole = new Label();
            lblRoleName = new Label();
            lblWelcome = new Label();
            panel3 = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gvBranches).BeginInit();
            panelShowReports.SuspendLayout();
            toolStrip.SuspendLayout();
            panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gvBranches
            // 
            gvBranches.AllowUserToAddRows = false;
            gvBranches.AllowUserToDeleteRows = false;
            gvBranches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvBranches.BackgroundColor = SystemColors.Control;
            gvBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvBranches.Location = new Point(30, 170);
            gvBranches.Margin = new Padding(3, 2, 3, 2);
            gvBranches.Name = "gvBranches";
            gvBranches.ReadOnly = true;
            gvBranches.RowHeadersWidth = 51;
            gvBranches.Size = new Size(630, 235);
            gvBranches.TabIndex = 32;
            // 
            // panelShowReports
            // 
            panelShowReports.Controls.Add(toolStrip);
            panelShowReports.Controls.Add(gvBranches);
            panelShowReports.Dock = DockStyle.Fill;
            panelShowReports.Location = new Point(0, 37);
            panelShowReports.Margin = new Padding(3, 2, 3, 2);
            panelShowReports.Name = "panelShowReports";
            panelShowReports.Size = new Size(675, 456);
            panelShowReports.TabIndex = 47;
            panelShowReports.Tag = "myTheme";
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.None;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripPageLabel });
            toolStrip.Location = new Point(41, 422);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(79, 27);
            toolStrip.TabIndex = 33;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = SystemColors.Control;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(24, 24);
            toolStripButton1.Text = "previous";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(24, 24);
            toolStripButton2.Text = "next";
            // 
            // toolStripPageLabel
            // 
            toolStripPageLabel.Name = "toolStripPageLabel";
            toolStripPageLabel.Size = new Size(19, 24);
            toolStripPageLabel.Text = "00";
            // 
            // panelShow
            // 
            panelShow.Controls.Add(btnAddBranch);
            panelShow.Dock = DockStyle.Top;
            panelShow.Location = new Point(0, 112);
            panelShow.Margin = new Padding(3, 2, 3, 2);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(675, 91);
            panelShow.TabIndex = 46;
            panelShow.Tag = "myTheme";
            // 
            // btnAddBranch
            // 
            btnAddBranch.BackColor = Color.Teal;
            btnAddBranch.FlatAppearance.BorderSize = 0;
            btnAddBranch.FlatStyle = FlatStyle.Flat;
            btnAddBranch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnAddBranch.ForeColor = SystemColors.Control;
            btnAddBranch.ImeMode = ImeMode.NoControl;
            btnAddBranch.Location = new Point(246, 24);
            btnAddBranch.Name = "btnAddBranch";
            btnAddBranch.Size = new Size(166, 40);
            btnAddBranch.TabIndex = 20;
            btnAddBranch.Text = "Add new branch";
            btnAddBranch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddBranch.UseVisualStyleBackColor = false;
            btnAddBranch.Click += btnAddBranch_Click;
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
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblRole.ImeMode = ImeMode.NoControl;
            lblRole.Location = new Point(97, 39);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 18);
            lblRole.TabIndex = 36;
            lblRole.Text = "Page:";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Font = new Font("Microsoft Sans Serif", 11F);
            lblRoleName.ImeMode = ImeMode.NoControl;
            lblRoleName.Location = new Point(188, 40);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(71, 18);
            lblRoleName.TabIndex = 35;
            lblRoleName.Text = "Branches";
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(73, 178, 202);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(675, 37);
            panel3.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.White;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(3, 7);
            label9.Name = "label9";
            label9.Size = new Size(155, 20);
            label9.TabIndex = 8;
            label9.Text = "DisplayBranches Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(lblRoleName);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(picStudent);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblRoleError);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 75);
            panel1.TabIndex = 45;
            // 
            // Branches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelShow);
            Controls.Add(panel1);
            Controls.Add(panelShowReports);
            Controls.Add(panel3);
            Name = "Branches";
            Size = new Size(675, 493);
            Load += Branches_Load;
            ((System.ComponentModel.ISupportInitialize)gvBranches).EndInit();
            panelShowReports.ResumeLayout(false);
            panelShowReports.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvBranches;
        private Panel panelShowReports;
        private Panel panelShow;
        private Button btnAddBranch;
        private Label lblRoleError;
        private PictureBox picStudent;
        private Button button3;
        private Label lblUserName;
        private Label lblRole;
        private Label lblRoleName;
        private Label lblWelcome;
        private Panel panel3;
        private Label label9;
        private Panel panel1;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripPageLabel;
    }
}
