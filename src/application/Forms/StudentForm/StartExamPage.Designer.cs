namespace application.Forms
{
    partial class StartExamPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartExamPage));
            panelShowReports = new Panel();
            btnNext = new Button();
            btnPrev = new Button();
            qChoice1 = new RadioButton();
            qChoice2 = new RadioButton();
            qChoice4 = new RadioButton();
            qChoice3 = new RadioButton();
            qTitle = new Label();
            panel5 = new Panel();
            txtTimer = new TextBox();
            button5 = new Button();
            btnSubmit = new Button();
            panelShowReports.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelShowReports
            // 
            resources.ApplyResources(panelShowReports, "panelShowReports");
            panelShowReports.BackColor = SystemColors.Control;
            panelShowReports.Controls.Add(btnNext);
            panelShowReports.Controls.Add(btnPrev);
            panelShowReports.Controls.Add(qChoice1);
            panelShowReports.Controls.Add(qChoice2);
            panelShowReports.Controls.Add(qChoice4);
            panelShowReports.Controls.Add(qChoice3);
            panelShowReports.Controls.Add(qTitle);
            panelShowReports.Name = "panelShowReports";
            panelShowReports.Tag = "myTheme";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 7, 95);
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.ForeColor = Color.White;
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.FromArgb(0, 7, 95);
            resources.ApplyResources(btnPrev, "btnPrev");
            btnPrev.ForeColor = Color.White;
            btnPrev.Name = "btnPrev";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // qChoice1
            // 
            resources.ApplyResources(qChoice1, "qChoice1");
            qChoice1.Name = "qChoice1";
            qChoice1.TabStop = true;
            qChoice1.UseVisualStyleBackColor = true;
            qChoice1.CheckedChanged += qChoice1_CheckedChanged;
            // 
            // qChoice2
            // 
            resources.ApplyResources(qChoice2, "qChoice2");
            qChoice2.Name = "qChoice2";
            qChoice2.TabStop = true;
            qChoice2.UseVisualStyleBackColor = true;
            qChoice2.CheckedChanged += qChoice2_CheckedChanged;
            // 
            // qChoice4
            // 
            resources.ApplyResources(qChoice4, "qChoice4");
            qChoice4.Name = "qChoice4";
            qChoice4.TabStop = true;
            qChoice4.UseVisualStyleBackColor = true;
            qChoice4.CheckedChanged += qChoice4_CheckedChanged;
            // 
            // qChoice3
            // 
            resources.ApplyResources(qChoice3, "qChoice3");
            qChoice3.Name = "qChoice3";
            qChoice3.TabStop = true;
            qChoice3.UseVisualStyleBackColor = true;
            qChoice3.CheckedChanged += qChoice3_CheckedChanged;
            // 
            // qTitle
            // 
            resources.ApplyResources(qTitle, "qTitle");
            qTitle.Name = "qTitle";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 7, 95);
            panel5.Controls.Add(txtTimer);
            panel5.Controls.Add(button5);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // txtTimer
            // 
            resources.ApplyResources(txtTimer, "txtTimer");
            txtTimer.Name = "txtTimer";
            txtTimer.ReadOnly = true;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 7, 95);
            resources.ApplyResources(btnSubmit, "btnSubmit");
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Name = "btnSubmit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // StartExamPage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(btnSubmit);
            Controls.Add(panelShowReports);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartExamPage";
            panelShowReports.ResumeLayout(false);
            panelShowReports.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelShowReports;
        private Label qTitle;
        private Panel panel5;
        private RadioButton qChoice1;
        private RadioButton qChoice2;
        private RadioButton qChoice4;
        private RadioButton qChoice3;
        private Button button5;
        private TextBox txtTimer;
        private Button btnPrev;
        private Button btnNext;
        private Button btnSubmit;
    }
}