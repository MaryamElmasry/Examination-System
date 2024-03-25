using application.Controllers;
using application.Models;
using application.Utilites;

namespace application.Forms
{
    public partial class Login : Form
    {
        AuthController authController = new AuthController();
        InitializeDB intalizeDB = new InitializeDB();
        iti_ExamContext context = new iti_ExamContext();

        public Login()
        {
            InitializeComponent();
            intalizeDB.AddDummyUserData(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "omar" && txtPassword.Text == "123")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
                return;
            }

            (string userType, int userID) = authController.AuthenticateUser(txtEmail.Text, txtPassword.Text);

            if (userType == "Invalid")
            {
                MessageBox.Show("Invalid email or password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Redirect based on user type
            if (userType == "Student")
            {
                StudentExamForm studentform = new StudentExamForm(userID);
                studentform.Show();
                this.Hide();
            }
            else if (userType == "Instructor")
            {
                InstructorForm instructor = new InstructorForm(new Instructor() { InstructorID = userID });
                instructor.Show();
                this.Hide();
            }
        }

        private void ToogleShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide password
            txtPassword.UseSystemPasswordChar = !ToogleShowPassword.Checked;


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}