namespace StudentManagementSystem.Views
{
    partial class StudentManagementPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentGridView = new DataGridView();
            searchTxt = new TextBox();
            searchLbl = new Label();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            viewBtn = new Button();
            enrollBtn = new Button();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // studentGridView
            // 
            studentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Location = new Point(200, 122);
            studentGridView.Margin = new Padding(1);
            studentGridView.MultiSelect = false;
            studentGridView.Name = "studentGridView";
            studentGridView.ReadOnly = true;
            studentGridView.RowHeadersVisible = false;
            studentGridView.RowHeadersWidth = 62;
            studentGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentGridView.Size = new Size(769, 456);
            studentGridView.TabIndex = 0;
            studentGridView.TabStop = false;
            // 
            // searchTxt
            // 
            searchTxt.AcceptsReturn = true;
            searchTxt.Font = new Font("Segoe UI", 14F);
            searchTxt.Location = new Point(318, 59);
            searchTxt.Margin = new Padding(1);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(487, 45);
            searchTxt.TabIndex = 1;
            searchTxt.KeyPress += searchTxt_KeyPress;
            // 
            // searchLbl
            // 
            searchLbl.AutoSize = true;
            searchLbl.Location = new Point(201, 59);
            searchLbl.Margin = new Padding(2, 0, 2, 0);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(114, 38);
            searchLbl.TabIndex = 0;
            searchLbl.Text = "Search :";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(200, 599);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(243, 48);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(465, 599);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(243, 48);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(726, 599);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(243, 48);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // viewBtn
            // 
            viewBtn.Location = new Point(598, 653);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(243, 48);
            viewBtn.TabIndex = 8;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // enrollBtn
            // 
            enrollBtn.Location = new Point(336, 653);
            enrollBtn.Name = "enrollBtn";
            enrollBtn.Size = new Size(243, 48);
            enrollBtn.TabIndex = 7;
            enrollBtn.Text = "Enroll";
            enrollBtn.UseVisualStyleBackColor = true;
            enrollBtn.Click += enrollBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(809, 59);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(160, 45);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // StudentManagementPage
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(clearBtn);
            Controls.Add(addBtn);
            Controls.Add(viewBtn);
            Controls.Add(searchLbl);
            Controls.Add(enrollBtn);
            Controls.Add(searchTxt);
            Controls.Add(updateBtn);
            Controls.Add(studentGridView);
            Controls.Add(deleteBtn);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "StudentManagementPage";
            Text = "StudentManagementPage";
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentGridView;
        private TextBox searchTxt;
        private Label searchLbl;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button viewBtn;
        private Button enrollBtn;
        private Button clearBtn;
    }
}
