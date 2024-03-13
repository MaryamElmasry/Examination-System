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
            DeleteQuestbtn = new Button();
            EditQuestbtn = new Button();
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
            courselst.FormattingEnabled = true;
            courselst.Location = new Point(612, 33);
            courselst.Name = "courselst";
            courselst.Size = new Size(151, 28);
            courselst.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 36);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Course";
            // 
            // AddQuestbtn
            // 
            AddQuestbtn.Location = new Point(467, 425);
            AddQuestbtn.Name = "AddQuestbtn";
            AddQuestbtn.Size = new Size(94, 29);
            AddQuestbtn.TabIndex = 3;
            AddQuestbtn.Text = "Add";
            AddQuestbtn.UseVisualStyleBackColor = true;
            AddQuestbtn.Click += AddQuestbtn_Click;
            // 
            // DeleteQuestbtn
            // 
            DeleteQuestbtn.Location = new Point(669, 425);
            DeleteQuestbtn.Name = "DeleteQuestbtn";
            DeleteQuestbtn.Size = new Size(94, 29);
            DeleteQuestbtn.TabIndex = 4;
            DeleteQuestbtn.Text = "Delete";
            DeleteQuestbtn.UseVisualStyleBackColor = true;
            DeleteQuestbtn.Click += DeleteQuestbtn_Click;
            // 
            // EditQuestbtn
            // 
            EditQuestbtn.Location = new Point(569, 425);
            EditQuestbtn.Name = "EditQuestbtn";
            EditQuestbtn.Size = new Size(94, 29);
            EditQuestbtn.TabIndex = 5;
            EditQuestbtn.Text = "Edit";
            EditQuestbtn.UseVisualStyleBackColor = false;
            EditQuestbtn.Click += EditQuestbtn_Click;
            // 
            // QuestionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditQuestbtn);
            Controls.Add(DeleteQuestbtn);
            Controls.Add(AddQuestbtn);
            Controls.Add(label1);
            Controls.Add(courselst);
            Controls.Add(QuestionsGV);
            Name = "QuestionsControl";
            Size = new Size(766, 482);
            ((System.ComponentModel.ISupportInitialize)QuestionsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView QuestionsGV;
        private ComboBox courselst;
        private Label label1;
        private Button AddQuestbtn;
        private Button DeleteQuestbtn;
        private Button EditQuestbtn;
    }
}
