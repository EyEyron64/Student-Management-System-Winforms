namespace StudentManagementSystem.Views
{
    partial class AddUpdateStudentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLbl = new Label();
            firstNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            lastNameLbl = new Label();
            emailTxt = new TextBox();
            emailLbl = new Label();
            doneBtn = new Button();
            label1 = new Label();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(35, 140);
            firstNameLbl.Margin = new Padding(4, 0, 4, 0);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(165, 38);
            firstNameLbl.TabIndex = 0;
            firstNameLbl.Text = "First Name :";
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(207, 140);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(515, 45);
            firstNameTxt.TabIndex = 1;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(207, 219);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(515, 45);
            lastNameTxt.TabIndex = 3;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(35, 219);
            lastNameLbl.Margin = new Padding(4, 0, 4, 0);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(161, 38);
            lastNameLbl.TabIndex = 2;
            lastNameLbl.Text = "Last Name :";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(207, 297);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(515, 45);
            emailTxt.TabIndex = 5;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(35, 297);
            emailLbl.Margin = new Padding(4, 0, 4, 0);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(97, 38);
            emailLbl.TabIndex = 4;
            emailLbl.Text = "Email :";
            // 
            // doneBtn
            // 
            doneBtn.Location = new Point(426, 406);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(192, 49);
            doneBtn.TabIndex = 6;
            doneBtn.Text = "Done";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(207, 53);
            label1.Name = "label1";
            label1.Size = new Size(396, 54);
            label1.TabIndex = 7;
            label1.Text = "Enter Student Details";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(207, 406);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(192, 49);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddUpdateStudentPage
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(cancelBtn);
            Controls.Add(label1);
            Controls.Add(doneBtn);
            Controls.Add(emailTxt);
            Controls.Add(emailLbl);
            Controls.Add(lastNameTxt);
            Controls.Add(lastNameLbl);
            Controls.Add(firstNameTxt);
            Controls.Add(firstNameLbl);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddUpdateStudentPage";
            Text = "AddUpdateStudentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLbl;
        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private Label lastNameLbl;
        private TextBox emailTxt;
        private Label emailLbl;
        private Button doneBtn;
        private Label label1;
        private Button cancelBtn;
    }
}