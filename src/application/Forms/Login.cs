using application.Controllers;
using application.Models;
using application.Utilites;
namespace application.Forms
{
    public partial class Login : Form
    {
        //instance of AuthController
        AuthController authController = new AuthController();
        //instance of IntalizeDB
        InitializeDB intalizeDB = new InitializeDB();
        //instance of iti_ExamContext
        iti_ExamContext context = new iti_ExamContext();
        public Login()
        {
            InitializeComponent();
            intalizeDB.AddDummyUserData(context);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check if user is admin -> Static
            if (txtEmail.Text == "omar" && txtPassword.Text == "123")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
                return;
            }
            User user = authController.Login(txtEmail.Text, txtPassword.Text);

            if(user == null)
            {
                MessageBox.Show("Invalid email or password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if user is student
            else if (user.Student !=null)
            {
                Student student = new Student();
                student.Show();
                this.Hide();

            }
            else if (user.Instructor != null)
            {
                //if user is instructor
                Instructor instructor = new Instructor();
                instructor.Show();
                this.Hide();
            }
        }
    }
}
