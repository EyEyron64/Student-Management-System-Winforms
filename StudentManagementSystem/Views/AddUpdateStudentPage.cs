using StudentManagementSystem.Models;

namespace StudentManagementSystem.Views
{
    public partial class AddUpdateStudentPage : Form
    {
        public Student Student { get; set; }
        public AddUpdateStudentPage(Student student)
        {
            InitializeComponent();
            firstNameTxt.Text = student.FirstName;
            lastNameTxt.Text = student.LastName;
            emailTxt.Text = student.Email;
            Student = student;
        }

        public AddUpdateStudentPage()
        {
            InitializeComponent();
            Student = new Student() {FirstName = "", LastName = ""};
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Student.FirstName = firstNameTxt.Text;
            Student.LastName = lastNameTxt.Text;
            Student.Email = emailTxt.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
