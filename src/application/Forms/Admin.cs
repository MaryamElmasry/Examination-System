using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace application.Forms
{
    public partial class Admin : Form
    {
        public XmlSerializer serializer;
        // Import the necessary Windows API methods
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public Admin()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Release capture to enable normal mouse operation like clicking on buttons
                ReleaseCapture();

                // Send the message to move the form
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnDisplayBranches_Click(object sender, EventArgs e)
        {
            branchesForm.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {

        }
    }
}
