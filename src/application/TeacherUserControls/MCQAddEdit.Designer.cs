namespace application.TeacherUserControls
{
    partial class MCQAddEdit
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
            Qr1 = new RadioButton();
            Qr2 = new RadioButton();
            Qr3 = new RadioButton();
            Qr4 = new RadioButton();
            Qc4 = new TextBox();
            Qc3 = new TextBox();
            Qc2 = new TextBox();
            Qc1 = new TextBox();
            SuspendLayout();
            // 
            // Qr1
            // 
            Qr1.AutoSize = true;
            Qr1.Location = new Point(148, 69);
            Qr1.Name = "Qr1";
            Qr1.Size = new Size(17, 16);
            Qr1.TabIndex = 0;
            Qr1.TabStop = true;
            Qr1.UseVisualStyleBackColor = true;
            // 
            // Qr2
            // 
            Qr2.AutoSize = true;
            Qr2.Location = new Point(148, 102);
            Qr2.Name = "Qr2";
            Qr2.Size = new Size(17, 16);
            Qr2.TabIndex = 1;
            Qr2.TabStop = true;
            Qr2.UseVisualStyleBackColor = true;
            // 
            // Qr3
            // 
            Qr3.AutoSize = true;
            Qr3.Location = new Point(148, 135);
            Qr3.Name = "Qr3";
            Qr3.Size = new Size(17, 16);
            Qr3.TabIndex = 2;
            Qr3.TabStop = true;
            Qr3.UseVisualStyleBackColor = true;
            // 
            // Qr4
            // 
            Qr4.AutoSize = true;
            Qr4.Location = new Point(148, 168);
            Qr4.Name = "Qr4";
            Qr4.Size = new Size(17, 16);
            Qr4.TabIndex = 3;
            Qr4.TabStop = true;
            Qr4.UseVisualStyleBackColor = true;
            // 
            // Qc4
            // 
            Qc4.Location = new Point(171, 163);
            Qc4.Name = "Qc4";
            Qc4.Size = new Size(273, 27);
            Qc4.TabIndex = 4;
            // 
            // Qc3
            // 
            Qc3.Location = new Point(171, 130);
            Qc3.Name = "Qc3";
            Qc3.Size = new Size(273, 27);
            Qc3.TabIndex = 5;
            // 
            // Qc2
            // 
            Qc2.Location = new Point(171, 97);
            Qc2.Name = "Qc2";
            Qc2.Size = new Size(273, 27);
            Qc2.TabIndex = 6;
            // 
            // Qc1
            // 
            Qc1.Location = new Point(171, 64);
            Qc1.Name = "Qc1";
            Qc1.Size = new Size(273, 27);
            Qc1.TabIndex = 7;
            // 
            // MCQAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Qc1);
            Controls.Add(Qc2);
            Controls.Add(Qc3);
            Controls.Add(Qc4);
            Controls.Add(Qr4);
            Controls.Add(Qr3);
            Controls.Add(Qr2);
            Controls.Add(Qr1);
            Name = "MCQAddEdit";
            Size = new Size(664, 279);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton Qr1;
        private RadioButton Qr2;
        private RadioButton Qr3;
        private RadioButton Qr4;
        private TextBox Qc4;
        private TextBox Qc3;
        private TextBox Qc2;
        private TextBox Qc1;
    }
}
