namespace application.TeacherUserControls
{
    partial class TFAddEdit
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
            TrueBtn = new RadioButton();
            FalseBtn = new RadioButton();
            SuspendLayout();
            // 
            // TrueBtn
            // 
            TrueBtn.AutoSize = true;
            TrueBtn.Location = new Point(232, 60);
            TrueBtn.Name = "TrueBtn";
            TrueBtn.Size = new Size(58, 24);
            TrueBtn.TabIndex = 0;
            TrueBtn.TabStop = true;
            TrueBtn.Text = "True";
            TrueBtn.UseVisualStyleBackColor = true;
            // 
            // FalseBtn
            // 
            FalseBtn.AutoSize = true;
            FalseBtn.Location = new Point(232, 90);
            FalseBtn.Name = "FalseBtn";
            FalseBtn.Size = new Size(62, 24);
            FalseBtn.TabIndex = 1;
            FalseBtn.TabStop = true;
            FalseBtn.Text = "False";
            FalseBtn.UseVisualStyleBackColor = true;
            // 
            // TFAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FalseBtn);
            Controls.Add(TrueBtn);
            Name = "TFAddEdit";
            Size = new Size(664, 279);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton TrueBtn;
        private RadioButton FalseBtn;
    }
}
