using StudentManagementSystem.DataAccess;

using StudentManagementSystem.Models;

namespace StudentManagementSystem.Views;

public partial class StudentManagementPage : Form
{
    public StudentManagementPage()
    {
        InitializeComponent();
        RefreshStudentGrid();
    }
    private async void RefreshStudentGrid()
    {
        var sqlClient = new SqlClient();
        var students = await sqlClient.GetStudents(searchTxt.Text);
        studentGridView.DataSource = students.ToList();
        studentGridView.Columns["Id"].Visible = false;
        studentGridView.ResetBindings();
    }
    private void searchTxt_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            e.Handled = true;
            RefreshStudentGrid();
            studentGridView.Focus();
        }
    }
    private void clearBtn_Click(object sender, EventArgs e)
    {
        searchTxt.Clear(); RefreshStudentGrid();
    }
    private void viewBtn_Click(object sender, EventArgs e)
    {
        using var studentProfilePage = new StudentProfilePage(
            (Student)studentGridView.SelectedRows[0].DataBoundItem!);
        studentProfilePage.StartPosition = FormStartPosition.CenterParent;
        studentProfilePage.ShowDialog(this);
    }
    private async void addBtn_Click(object sender, EventArgs e)
    {
        using var addPage = new AddUpdateStudentPage();
        addPage.StartPosition = FormStartPosition.CenterParent;

        if (addPage.ShowDialog(this) != DialogResult.OK)
            return;

        var sqlClient = new SqlClient();
        try
        {
            await sqlClient.CreateStudent(addPage.Student);
        }
        catch (Exception)
        {
            MessageBox.Show("An Error Occured During this Operation", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        RefreshStudentGrid();
        }
    private async void updateBtn_Click(object sender, EventArgs e)
    {
        using var updatePage = new AddUpdateStudentPage(
            (Student)studentGridView.SelectedRows[0].DataBoundItem!
        );
        updatePage.StartPosition = FormStartPosition.CenterParent;

        if (updatePage.ShowDialog(this) != DialogResult.OK)
            return;

        var sqlClient = new SqlClient();
        try
        {
            await sqlClient.UpdateStudent(updatePage.Student);
        }
        catch (Exception)
        {
            MessageBox.Show("An Error Occured During this Operation", "Error"
            , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        RefreshStudentGrid();
    }

    private async void deleteBtn_Click(object sender, EventArgs e)
    {
        var sqlClient = new SqlClient();
        try
        {
            await sqlClient.DeleteStudent((int)studentGridView.SelectedRows[0].Cells["Id"].Value);
            MessageBox.Show(this, "Student deleted successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show("An Error Occured During this Operation", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        RefreshStudentGrid();
    }
    
    private async void enrollBtn_Click(object sender, EventArgs e)
    {
        using var enrollPage = new StudentEnrollmentPage(
            (Student)studentGridView.SelectedRows[0].DataBoundItem!);
        enrollPage.StartPosition = FormStartPosition.CenterParent;
        enrollPage.ShowDialog(this);
    }
}
