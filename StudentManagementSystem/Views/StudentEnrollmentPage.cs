using System.Data;

namespace StudentManagementSystem.Views;

public partial class StudentEnrollmentPage : Form
{
    public StudentEnrollmentPage(Student student)
    {
        InitializeComponent();

        var sqlClient = new SqlClient();
        coursesComboBox.DataSource = sqlClient.GetAllCourses().Select(x => x.Key + " : " + x.Value).ToList();

        studentIdTxt.Text = student.Id.ToString();
        nameTxt.Text = $"{student.FirstName} {student.LastName}";
    }

    private void doneBtn_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    private void enrollBtn_Click(object sender, EventArgs e)
    {
        try
        {
            var sqlClient = new SqlClient();
            var courseCode = coursesComboBox.SelectedItem?.ToString()!.Split(" : ")[0];
            if (courseCode == null)
                return;
            sqlClient.EnrollStudentInCourse(int.Parse(studentIdTxt.Text), courseCode);
            MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error enrolling student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void unenerollBtn_Click(object sender, EventArgs e)
    {
        try
        {
            var sqlClient = new SqlClient();
            var courseCode = coursesComboBox.SelectedItem?.ToString()!.Split(" : ")[0];
            if (courseCode == null)
                return;
            sqlClient.UnenrollStudentFromCourse(int.Parse(studentIdTxt.Text), courseCode);
            MessageBox.Show("Student unenrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error unenrolling student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
