using System.Data;
using StudentManagementSystem.Models;
using MySql.Data.MySqlClient;
using StudentManagementSystem.DataAccess;

namespace StudentManagementSystem.Views;

public partial class StudentEnrollmentPage : Form
{
    public StudentEnrollmentPage(Student student)
    {
        InitializeComponent();
        LoadStudent(student);
    }
    private async void LoadStudent(Student student)
    {
        var sqlClient = new SqlClient();
        var courses = await sqlClient.GetAllCourses();
        coursesComboBox.DataSource = courses.Select(c => c.Code +" : " + c.Name).ToArray();
        studentIdTxt.Text = student.Id.ToString();
        nameTxt.Text = $"{student.FirstName} {student.LastName}";
    }
    private async void doneBtn_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }
    private async void enrollBtn_Click(object sender, EventArgs e)
    {
        try
        {
            var sqlClient = new SqlClient();
            var courseCode = coursesComboBox.SelectedItem!.ToString()!.Split(":")[0].Replace(" ", "");
            if (courseCode == null)
                return;
            await sqlClient.EnrollStudentInCourse(int.Parse(studentIdTxt.Text), courseCode);
            MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            MessageBox.Show("This student is already enrolled in the selected course.", "Duplicate Enrollment",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error enrolling student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private async void unenerollBtn_Click(object sender, EventArgs e)
    {
        try
        {
            var sqlClient = new SqlClient();
            var courseCode = coursesComboBox.SelectedItem!.ToString()!.Split(":")[0].Replace(" ", "");
            if (courseCode == null)
                return;
            await sqlClient.UnenrollStudentFromCourse(int.Parse(studentIdTxt.Text), courseCode);
            MessageBox.Show("Student unenrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error unenrolling student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
