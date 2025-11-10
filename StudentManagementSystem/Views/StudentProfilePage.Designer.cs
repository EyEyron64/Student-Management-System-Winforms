namespace StudentManagementSystem.Views
{
    partial class StudentProfilePage
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
            label1 = new Label();
            lastNameLbl = new Label();
            label3 = new Label();
            firstNameLbl = new Label();
            emailLbl = new Label();
            label4 = new Label();
            label2 = new Label();
            idLbl = new Label();
            label6 = new Label();
            backBtn = new Button();
            enrolledCoursesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)enrolledCoursesGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 38);
            label1.TabIndex = 0;
            label1.Text = "Last Name :";
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(280, 45);
            lastNameLbl.Margin = new Padding(4, 0, 4, 0);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(133, 38);
            lastNameLbl.TabIndex = 1;
            lastNameLbl.Text = "lastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 38);
            label3.TabIndex = 2;
            label3.Text = "First Name :";
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(275, 99);
            firstNameLbl.Margin = new Padding(4, 0, 4, 0);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(138, 38);
            firstNameLbl.TabIndex = 4;
            firstNameLbl.Text = "firstName";
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(676, 45);
            emailLbl.Margin = new Padding(4, 0, 4, 0);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(84, 38);
            emailLbl.TabIndex = 6;
            emailLbl.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 38);
            label4.TabIndex = 5;
            label4.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 99);
            label2.Name = "label2";
            label2.Size = new Size(58, 38);
            label2.TabIndex = 7;
            label2.Text = "ID :";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Location = new Point(676, 99);
            idLbl.Margin = new Padding(4, 0, 4, 0);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(40, 38);
            idLbl.TabIndex = 8;
            idLbl.Text = "id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 179);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(238, 38);
            label6.TabIndex = 9;
            label6.Text = "Enrolled Courses :";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(524, 669);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(156, 50);
            backBtn.TabIndex = 11;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // enrolledCoursesGrid
            // 
            enrolledCoursesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            enrolledCoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            enrolledCoursesGrid.Location = new Point(106, 234);
            enrolledCoursesGrid.Name = "enrolledCoursesGrid";
            enrolledCoursesGrid.ReadOnly = true;
            enrolledCoursesGrid.RowHeadersVisible = false;
            enrolledCoursesGrid.RowHeadersWidth = 62;
            enrolledCoursesGrid.Size = new Size(964, 412);
            enrolledCoursesGrid.TabIndex = 12;
            // 
            // StudentProfilePage
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(enrolledCoursesGrid);
            Controls.Add(backBtn);
            Controls.Add(label6);
            Controls.Add(idLbl);
            Controls.Add(label2);
            Controls.Add(emailLbl);
            Controls.Add(label4);
            Controls.Add(firstNameLbl);
            Controls.Add(label3);
            Controls.Add(lastNameLbl);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StudentProfilePage";
            Text = "StudentProfilePage";
            ((System.ComponentModel.ISupportInitialize)enrolledCoursesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lastNameLbl;
        private Label label3;
        private Label firstNameLbl;
        private Label emailLbl;
        private Label label4;
        private Label label2;
        private Label idLbl;
        private Label label6;
        private Button backBtn;
        private DataGridView enrolledCoursesGrid;
    }
}