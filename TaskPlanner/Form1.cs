using TaskPlanner.Models;
using TaskPlanner.Services;

namespace TaskPlanner
{
    public partial class Form1 : Form
    {
        private readonly TaskManager taskManager = new TaskManager();

        public Form1()
        {
            InitializeComponent();
            cmbPriority.SelectedIndex = 1;
            AddSampleTasks();
            RefreshList();
        }

        // Примеры задач, чтобы при первом запуске список не был пустым.
        private void AddSampleTasks()
        {
            taskManager.Add("Сдать лабораторную работу №5 по ТРПО", TaskPriority.High);
            taskManager.Add("Настроить GitHub Copilot в VS Code", TaskPriority.Medium).IsDone = true;
            taskManager.Add("Прочитать про Git Flow и GitHub Flow", TaskPriority.Low);
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                MessageBox.Show("Введите название задачи.");
                return;
            }

            taskManager.Add(txtTask.Text, (TaskPriority)cmbPriority.SelectedIndex);
            txtTask.Clear();
            RefreshList();
        }

        private void btnDone_Click(object? sender, EventArgs e)
        {
            int index = lstTasks.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            TaskItem item = taskManager.Tasks[index];
            item.IsDone = !item.IsDone;
            RefreshList();
            lstTasks.SelectedIndex = index;
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            int index = lstTasks.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            taskManager.Remove(taskManager.Tasks[index]);
            RefreshList();
        }

        private void RefreshList()
        {
            lstTasks.Items.Clear();
            foreach (TaskItem item in taskManager.Tasks)
            {
                string mark = item.IsDone ? "[x]" : "[ ]";
                lstTasks.Items.Add($"{mark} {item.Title} ({TaskManager.PriorityToText(item.Priority)})");
            }

            lblStatus.Text = $"Задач: {taskManager.TotalCount}, выполнено: {taskManager.DoneCount}";
        }
    }
}
