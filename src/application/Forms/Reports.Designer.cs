namespace application.Forms
{
    partial class ReportsForm
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
            btnSR = new Button();
            label1 = new Label();
            txtDeptID = new TextBox();
            SuspendLayout();
            // 
            // btnSR
            // 
            btnSR.BackColor = Color.Teal;
            btnSR.FlatAppearance.BorderSize = 0;
            btnSR.FlatStyle = FlatStyle.Flat;
            btnSR.Font = new Font("Segoe UI", 11F);
            btnSR.ForeColor = SystemColors.ButtonFace;
            btnSR.Location = new Point(502, 68);
            btnSR.Margin = new Padding(3, 4, 3, 4);
            btnSR.Name = "btnSR";
            btnSR.Size = new Size(267, 48);
            btnSR.TabIndex = 6;
            btnSR.Text = "Generate Students Report";
            btnSR.UseVisualStyleBackColor = false;
            btnSR.Click += this.btnSR_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 77);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 7;
            label1.Text = "Department ID";
            // 
            // txtDeptID
            // 
            txtDeptID.Location = new Point(208, 77);
            txtDeptID.Margin = new Padding(3, 4, 3, 4);
            txtDeptID.Name = "txtDeptID";
            txtDeptID.Size = new Size(246, 27);
            txtDeptID.TabIndex = 8;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDeptID);
            Controls.Add(label1);
            Controls.Add(btnSR);
            Name = "Reports";
            Text = "GenerateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSR;
        private Label label1;
        private TextBox txtDeptID;
    }
}