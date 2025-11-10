namespace StudentManagementSystem.Views;

public partial class StudentManagementPage : Form
{
    public StudentManagementPage()
    {
        InitializeComponent();
        RefreshStudentGrid();
        studentGridView.Columns["Id"].Visible = false;
    }

    private void RefreshStudentGrid()
    {
        var sqlClient = new SqlClient();

        if (!string.IsNullOrWhiteSpace(searchTxt.Text))
            studentGridView.DataSource = sqlClient.GetStudents(searchTxt.Text).ToList();
        else
            studentGridView.DataSource = sqlClient.GetStudents().ToList();
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

    private void addBtn_Click(object sender, EventArgs e)
    {
        using var addPage = new AddUpdateStudentPage();
        addPage.StartPosition = FormStartPosition.CenterParent;

        if (addPage.ShowDialog(this) != DialogResult.OK)
            return;

        var sqlClient = new SqlClient();

        sqlClient.CreateStudent(new Student
        {
            FirstName = addPage.FirstName,
            LastName = addPage.LastName,
            Email = addPage.Email
        });
        RefreshStudentGrid();
    }

    private void updateBtn_Click(object sender, EventArgs e)
    {
        using var addPage = new AddUpdateStudentPage();
        addPage.StartPosition = FormStartPosition.CenterParent;

        var row = studentGridView.SelectedRows;
        var student = (Student)row[0].DataBoundItem!;

        addPage.FirstName = student.FirstName;
        addPage.LastName = student.LastName;
        addPage.Email = student.Email;

        if (addPage.ShowDialog(this) != DialogResult.OK)
            return;

        student.FirstName = addPage.FirstName;
        student.LastName = addPage.LastName;
        student.Email = addPage.Email;

        var sqlClient = new SqlClient();
        sqlClient.UpdateStudent(student);
        RefreshStudentGrid();
    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        var sqlClient = new SqlClient();
        sqlClient.DeleteStudent((int)studentGridView.SelectedRows[0].Cells["Id"].Value);
        MessageBox.Show(this, "Student deleted successfully!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        RefreshStudentGrid();
    }

    private void enrollBtn_Click(object sender, EventArgs e)
    {
        using var enrollPage = new StudentEnrollmentPage(
            (Student)studentGridView.SelectedRows[0].DataBoundItem!);

        enrollPage.StartPosition = FormStartPosition.CenterParent;
        enrollPage.ShowDialog(this);
    }
}
