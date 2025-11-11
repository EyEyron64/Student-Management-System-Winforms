using StudentManagementSystem.DataAccess;

using StudentManagementSystem.Models;

namespace StudentManagementSystem.Views;
public partial class StudentProfilePage : Form
{
    public StudentProfilePage(Student student)
    {
        InitializeComponent();
        LoadStudent(student);
    }
    private async void LoadStudent(Student student)
    {
        firstNameLbl.Text = student.FirstName;
        lastNameLbl.Text = student.LastName;
        emailLbl.Text = student.Email;
        idLbl.Text = student.Id.ToString();

        var sqlClient = new SqlClient();
        var students = await sqlClient.GetEnrolledCourses(student.Id);
        enrolledCoursesGrid.DataSource = students.ToArray();
    }
    private void backBtn_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }
}
