namespace application.instructorDialog
{
    partial class AddQuetion
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
            textBox1 = new TextBox();
            label1 = new Label();
            MCQRadio = new RadioButton();
            TFRadio = new RadioButton();
            label2 = new Label();
            mcqAddEdit1 = new TeacherUserControls.MCQAddEdit();
            SaveBtn = new Button();
            tfAddEdit1 = new TeacherUserControls.TFAddEdit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.Location = new Point(174, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 34);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 57);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 1;
            label1.Text = "Question Text";
            // 
            // MCQRadio
            // 
            MCQRadio.AutoSize = true;
            MCQRadio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            MCQRadio.Location = new Point(433, 9);
            MCQRadio.Name = "MCQRadio";
            MCQRadio.Size = new Size(129, 32);
            MCQRadio.TabIndex = 2;
            MCQRadio.Text = "MCQRadio";
            MCQRadio.UseVisualStyleBackColor = true;
            MCQRadio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // TFRadio
            // 
            TFRadio.AutoSize = true;
            TFRadio.Checked = true;
            TFRadio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TFRadio.Location = new Point(568, 12);
            TFRadio.Name = "TFRadio";
            TFRadio.Size = new Size(54, 32);
            TFRadio.TabIndex = 3;
            TFRadio.TabStop = true;
            TFRadio.Text = "TF";
            TFRadio.UseVisualStyleBackColor = true;
            TFRadio.CheckedChanged += TFRadio_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(280, 9);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 4;
            label2.Text = "Question Type";
            // 
            // mcqAddEdit1
            // 
            mcqAddEdit1.Location = new Point(148, 92);
            mcqAddEdit1.Name = "mcqAddEdit1";
            mcqAddEdit1.Size = new Size(578, 204);
            mcqAddEdit1.TabIndex = 5;
            mcqAddEdit1.Load += mcqAddEdit1_Load;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.ActiveCaption;
            SaveBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(611, 319);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(115, 49);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // tfAddEdit1
            // 
            tfAddEdit1.Location = new Point(139, 109);
            tfAddEdit1.Name = "tfAddEdit1";
            tfAddEdit1.Size = new Size(578, 204);
            tfAddEdit1.TabIndex = 7;
            // 
            // AddQuetion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(tfAddEdit1);
            Controls.Add(SaveBtn);
            Controls.Add(mcqAddEdit1);
            Controls.Add(label2);
            Controls.Add(TFRadio);
            Controls.Add(MCQRadio);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AddQuetion";
            Text = "AddQuetion";
            Load += AddQuetion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private RadioButton MCQRadio;
        private RadioButton TFRadio;
        private Label label2;
        private TeacherUserControls.MCQAddEdit mcqAddEdit1;
        private Button SaveBtn;
        private TeacherUserControls.TFAddEdit tfAddEdit1;
    }
}