namespace StudentManagementSystem.Views;

public partial class StudentProfilePage : Form
{
    public StudentProfilePage(Student student)
    {
        InitializeComponent();

        firstNameLbl.Text = student.FirstName;
        lastNameLbl.Text = student.LastName;
        emailLbl.Text = student.Email;
        idLbl.Text = student.Id.ToString();

        var sqlClient = new SqlClient();
        enrolledCoursesGrid.DataSource = sqlClient.GetEnrolledCourses(student.Id).ToList();

        enrolledCoursesGrid.Columns["Key"].HeaderText = "Course Code";
        enrolledCoursesGrid.Columns["Value"].HeaderText = "Course Name";
    }
    private void backBtn_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }
}
