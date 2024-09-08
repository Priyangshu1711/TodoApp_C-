
namespace TodoApp
{
    partial class ToDoList
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
            headingLabel = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            descriptionLabels = new Label();
            titleLable = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headingLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headingLabel.Location = new Point(6, 9);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(907, 92);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "To Do List";
            headingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(6, 131);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(1083, 27);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(6, 183);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(1083, 27);
            descriptionTextBox.TabIndex = 2;
            // 
            // descriptionLabels
            // 
            descriptionLabels.Location = new Point(8, 159);
            descriptionLabels.Name = "descriptionLabels";
            descriptionLabels.Size = new Size(1081, 25);
            descriptionLabels.TabIndex = 3;
            descriptionLabels.Text = "Description:";
            // 
            // titleLable
            // 
            titleLable.Location = new Point(8, 103);
            titleLable.Name = "titleLable";
            titleLable.Size = new Size(1081, 25);
            titleLable.TabIndex = 4;
            titleLable.Text = "Title:";
            // 
            // newButton
            // 
            newButton.Location = new Point(6, 226);
            newButton.Name = "newButton";
            newButton.Size = new Size(288, 37);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(300, 226);
            editButton.Name = "editButton";
            editButton.Size = new Size(259, 37);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += edit_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(565, 226);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(269, 37);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += delete_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(840, 226);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(251, 37);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += save_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = Color.White;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(8, 269);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(1083, 275);
            toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1096, 556);
            Controls.Add(toDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(titleLable);
            Controls.Add(descriptionLabels);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(headingLabel);
            Name = "ToDoList";
            Text = "To Do List";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabels;
        private Label titleLable;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView toDoListView;
    }
}
