namespace StudentManagementSystem.Views
{
    public partial class AddUpdateStudentPage : Form
    {
        public string FirstName
        {
            get => firstNameTxt.Text;
            set => firstNameTxt.Text = value;
        }
        public string LastName
        {
            get => lastNameTxt.Text;
            set => lastNameTxt.Text = value;
        }
        public string? Email
        {
            get => String.IsNullOrEmpty(emailTxt.Text) ? null : emailTxt.Text;
            set => emailTxt.Text = value;
        }
        public AddUpdateStudentPage()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
