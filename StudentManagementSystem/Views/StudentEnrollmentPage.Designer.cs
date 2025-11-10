namespace StudentManagementSystem.Views
{
    partial class StudentEnrollmentPage
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
            coursesComboBox = new ComboBox();
            enrollBtn = new Button();
            unenerollBtn = new Button();
            doneBtn = new Button();
            studentIdLbl = new Label();
            studentIdTxt = new TextBox();
            nameTxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // coursesComboBox
            // 
            coursesComboBox.FormattingEnabled = true;
            coursesComboBox.Location = new Point(148, 202);
            coursesComboBox.Margin = new Padding(4, 5, 4, 5);
            coursesComboBox.Name = "coursesComboBox";
            coursesComboBox.Size = new Size(537, 46);
            coursesComboBox.TabIndex = 0;
            // 
            // enrollBtn
            // 
            enrollBtn.Location = new Point(227, 300);
            enrollBtn.Margin = new Padding(4, 5, 4, 5);
            enrollBtn.Name = "enrollBtn";
            enrollBtn.Size = new Size(168, 52);
            enrollBtn.TabIndex = 1;
            enrollBtn.Text = "Enroll";
            enrollBtn.UseVisualStyleBackColor = true;
            enrollBtn.Click += enrollBtn_Click;
            // 
            // unenerollBtn
            // 
            unenerollBtn.Location = new Point(428, 300);
            unenerollBtn.Margin = new Padding(4, 5, 4, 5);
            unenerollBtn.Name = "unenerollBtn";
            unenerollBtn.Size = new Size(168, 52);
            unenerollBtn.TabIndex = 2;
            unenerollBtn.Text = "Unenroll";
            unenerollBtn.UseVisualStyleBackColor = true;
            unenerollBtn.Click += unenerollBtn_Click;
            // 
            // doneBtn
            // 
            doneBtn.Location = new Point(332, 383);
            doneBtn.Margin = new Padding(4, 5, 4, 5);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(168, 52);
            doneBtn.TabIndex = 3;
            doneBtn.Text = "Done";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // studentIdLbl
            // 
            studentIdLbl.AutoSize = true;
            studentIdLbl.Location = new Point(148, 59);
            studentIdLbl.Margin = new Padding(4, 0, 4, 0);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.Size = new Size(58, 38);
            studentIdLbl.TabIndex = 4;
            studentIdLbl.Text = "ID :";
            // 
            // studentIdTxt
            // 
            studentIdTxt.Location = new Point(274, 59);
            studentIdTxt.Name = "studentIdTxt";
            studentIdTxt.ReadOnly = true;
            studentIdTxt.Size = new Size(411, 45);
            studentIdTxt.TabIndex = 5;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(274, 110);
            nameTxt.Name = "nameTxt";
            nameTxt.ReadOnly = true;
            nameTxt.Size = new Size(411, 45);
            nameTxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 6;
            label1.Text = "Name :";
            // 
            // StudentEnrollmentPage
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 477);
            Controls.Add(nameTxt);
            Controls.Add(label1);
            Controls.Add(studentIdTxt);
            Controls.Add(studentIdLbl);
            Controls.Add(doneBtn);
            Controls.Add(unenerollBtn);
            Controls.Add(enrollBtn);
            Controls.Add(coursesComboBox);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StudentEnrollmentPage";
            Text = "StudentEnrollmentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox coursesComboBox;
        private Button enrollBtn;
        private Button unenerollBtn;
        private Button doneBtn;
        private Label studentIdLbl;
        private TextBox studentIdTxt;
        private TextBox nameTxt;
        private Label label1;
    }
}