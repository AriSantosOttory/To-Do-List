using System;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            string task = TaskTextBox.Text;
            if (!string.IsNullOrEmpty(task))
            {
                TaskListBox.Items.Add(task);
                TaskTextBox.Clear();
            }
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex >= 0)
            {
                TaskListBox.Items.RemoveAt(TaskListBox.SelectedIndex);
            }
        }

        private void ClearTasksButton_Click(object sender, EventArgs e)
        {
            TaskListBox.Items.Clear();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
