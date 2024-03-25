namespace application.TeacherUserControls
{
    partial class QuestionsControl
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
            QuestionsGV = new DataGridView();
            courselst = new ComboBox();
            label1 = new Label();
            AddQuestbtn = new Button();
            EditQuestbtn = new Button();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)QuestionsGV).BeginInit();
            SuspendLayout();
            // 
            // QuestionsGV
            // 
            QuestionsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsGV.Location = new Point(3, 95);
            QuestionsGV.Name = "QuestionsGV";
            QuestionsGV.RowHeadersWidth = 51;
            QuestionsGV.Size = new Size(760, 324);
            QuestionsGV.TabIndex = 0;
            // 
            // courselst
            // 
            courselst.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            courselst.FormattingEnabled = true;
            courselst.Location = new Point(599, 33);
            courselst.Name = "courselst";
            courselst.Size = new Size(151, 33);
            courselst.TabIndex = 1;
            courselst.SelectedValueChanged += CourseListUpdate;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(468, 36);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "Select Course";
            // 
            // AddQuestbtn
            // 
            AddQuestbtn.BackColor = Color.FromArgb(0, 192, 0);
            AddQuestbtn.Font = new Font("Segoe UI Semibold", 11F);
            AddQuestbtn.Location = new Point(465, 425);
            AddQuestbtn.Name = "AddQuestbtn";
            AddQuestbtn.Size = new Size(96, 39);
            AddQuestbtn.TabIndex = 3;
            AddQuestbtn.Text = "Add";
            AddQuestbtn.UseVisualStyleBackColor = false;
            AddQuestbtn.Click += AddQuestbtn_Click;
            // 
            // EditQuestbtn
            // 
            EditQuestbtn.Font = new Font("Segoe UI Semibold", 11F);
            EditQuestbtn.Location = new Point(569, 425);
            EditQuestbtn.Name = "EditQuestbtn";
            EditQuestbtn.Size = new Size(101, 39);
            EditQuestbtn.TabIndex = 5;
            EditQuestbtn.Text = "Edit";
            EditQuestbtn.UseVisualStyleBackColor = false;
            EditQuestbtn.Click += EditQuestbtn_Click;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.CornflowerBlue;
            Refresh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Refresh.Location = new Point(343, 429);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 33);
            Refresh.TabIndex = 6;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // QuestionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Refresh);
            Controls.Add(EditQuestbtn);
            Controls.Add(AddQuestbtn);
            Controls.Add(label1);
            Controls.Add(courselst);
            Controls.Add(QuestionsGV);
            Name = "QuestionsControl";
            Size = new Size(766, 482);
            Load += QuestionsControl_Load;
            ((System.ComponentModel.ISupportInitialize)QuestionsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView QuestionsGV;
        private ComboBox courselst;
        private Label label1;
        private Button AddQuestbtn;
        private Button EditQuestbtn;
        private Button Refresh;
    }
}
