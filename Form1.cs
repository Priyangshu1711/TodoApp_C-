using System.Data;

namespace TodoApp
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }
        //Creating the Table.
        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            //Adding Columns.
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //Point our DataGridView(Frontend) to our DataSource(Backend).
            toDoListView.DataSource = todoList;
        }


        private void new_Click(object? sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            //throw new NotImplementedException();

        }

        private void edit_Click(object? sender, EventArgs e)
        {
            isEditing = true;
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
            
            //throw new NotImplementedException();
        }

        private void delete_Click(object? sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}" ,ex);
            }

            //throw new NotImplementedException();
        }

        private void save_Click(object? sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;
                
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text,descriptionTextBox.Text);
            }
            //Clearing fields
            titleTextBox.Text ="";
            descriptionTextBox.Text = "";
            isEditing = false;
            //throw new NotImplementedException();
        }
    }
}
