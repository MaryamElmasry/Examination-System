namespace application.TeacherUserControls
{
    partial class TopicsControl
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
            PrintBtn = new Button();
            Courses = new Label();
            comboBoxClass = new ComboBox();
            dataGridView = new DataGridView();
            Topics = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // PrintBtn
            // 
            PrintBtn.Location = new Point(576, 319);
            PrintBtn.Margin = new Padding(3, 2, 3, 2);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(82, 22);
            PrintBtn.TabIndex = 13;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = true;
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(467, 24);
            Courses.Name = "Courses";
            Courses.Size = new Size(49, 15);
            Courses.TabIndex = 12;
            Courses.Text = "Courses";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(525, 22);
            comboBoxClass.Margin = new Padding(3, 2, 3, 2);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(133, 23);
            comboBoxClass.TabIndex = 11;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged_1;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Topics });
            dataGridView.Location = new Point(3, 53);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(665, 248);
            dataGridView.TabIndex = 10;
            // 
            // Topics
            // 
            Topics.FillWeight = 600F;
            Topics.HeaderText = "Topics";
            Topics.MinimumWidth = 400;
            Topics.Name = "Topics";
            Topics.ReadOnly = true;
            Topics.Width = 600;
            // 
            // TopicsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PrintBtn);
            Controls.Add(Courses);
            Controls.Add(comboBoxClass);
            Controls.Add(dataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TopicsControl";
            Size = new Size(670, 362);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PrintBtn;
        private Label Courses;
        private ComboBox comboBoxClass;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Topics;
    }
}
