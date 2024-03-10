namespace application.Forms
{
    partial class AddNewBranch
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
            txtBranchName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(142, 90);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(216, 23);
            txtBranchName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 90);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 1;
            label1.Text = "Branch name";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(142, 139);
            button1.Name = "button1";
            button1.Size = new Size(138, 36);
            button1.TabIndex = 2;
            button1.Text = "Add branch";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddNewBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 227);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtBranchName);
            Name = "AddNewBranch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddNewBranch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBranchName;
        private Label label1;
        private Button button1;
    }
}