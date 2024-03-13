namespace application.instructorDialog
{
    partial class EditDialog
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
            QtE = new TextBox();
            label1 = new Label();
            mcqAddEdit1 = new TeacherUserControls.MCQAddEdit();
            button1 = new Button();
            tfAddEdit1 = new TeacherUserControls.TFAddEdit();
            SuspendLayout();
            // 
            // QtE
            // 
            QtE.Location = new Point(232, 63);
            QtE.Name = "QtE";
            QtE.Size = new Size(394, 27);
            QtE.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 66);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Question Text";
            // 
            // mcqAddEdit1
            // 
            mcqAddEdit1.Location = new Point(82, 96);
            mcqAddEdit1.Name = "mcqAddEdit1";
            mcqAddEdit1.Size = new Size(706, 276);
            mcqAddEdit1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(659, 378);
            button1.Name = "button1";
            button1.Size = new Size(129, 60);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tfAddEdit1
            // 
            tfAddEdit1.Location = new Point(127, 96);
            tfAddEdit1.Name = "tfAddEdit1";
            tfAddEdit1.Size = new Size(545, 251);
            tfAddEdit1.TabIndex = 4;
            // 
            // EditDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tfAddEdit1);
            Controls.Add(button1);
            Controls.Add(mcqAddEdit1);
            Controls.Add(label1);
            Controls.Add(QtE);
            Name = "EditDialog";
            Text = "EditDialog";
            Load += EditDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QtE;
        private Label label1;
        private TeacherUserControls.MCQAddEdit mcqAddEdit1;
        private Button button1;
        private TeacherUserControls.TFAddEdit tfAddEdit1;
    }
}