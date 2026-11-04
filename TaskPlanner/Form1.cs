using System.Globalization;
using TaskPlanner.Models;
using TaskPlanner.Services;

namespace TaskPlanner
{
    public partial class Form1 : Form
    {
        private static readonly Color HighPriorityColor = Color.FromArgb(198, 40, 40);
        private static readonly Color MediumPriorityColor = Color.FromArgb(214, 110, 0);
        private static readonly Color LowPriorityColor = Color.FromArgb(46, 125, 50);
        private static readonly Color DoneColor = Color.FromArgb(150, 156, 168);

        private readonly TaskManager taskManager = new TaskManager();
        private readonly Font doneFont;

        // Флаг нужен, чтобы при перестроении списка не срабатывал обработчик ItemChecked.
        private bool isRefreshing;

        public Form1()
        {
            InitializeComponent();
            doneFont = new Font(lvTasks.Font, FontStyle.Strikeout);
            lblSubtitle.Text = "Задачи на " + DateTime.Now.ToString("d MMMM yyyy", new CultureInfo("ru-RU"));
            cmbPriority.SelectedIndex = (int)TaskPriority.Medium;
            AddSampleTasks();
            RefreshList();
            ResizeTitleColumn();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            doneFont.Dispose();
            base.OnFormClosed(e);
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
                MessageBox.Show("Введите название задачи.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTask.Focus();
                return;
            }

            taskManager.Add(txtTask.Text, (TaskPriority)cmbPriority.SelectedIndex);
            txtTask.Clear();
            txtTask.Focus();
            RefreshList();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (lvTasks.SelectedItems.Count == 0)
            {
                return;
            }

            foreach (ListViewItem item in lvTasks.SelectedItems)
            {
                if (item.Tag is TaskItem task)
                {
                    taskManager.Remove(task);
                }
            }

            RefreshList();
        }

        private void btnClearDone_Click(object? sender, EventArgs e)
        {
            taskManager.RemoveCompleted();
            RefreshList();
        }

        // Флажок в строке отмечает задачу выполненной.
        private void lvTasks_ItemChecked(object? sender, ItemCheckedEventArgs e)
        {
            if (isRefreshing || e.Item.Tag is not TaskItem task)
            {
                return;
            }

            task.IsDone = e.Item.Checked;
            ApplyItemStyle(e.Item, task);
            UpdateStatus();
        }

        private void lvTasks_Resize(object? sender, EventArgs e) => ResizeTitleColumn();

        // Колонка «Задача» занимает всю ширину, оставшуюся после остальных колонок.
        private void ResizeTitleColumn()
        {
            int width = lvTasks.ClientSize.Width - colPriority.Width - colCreated.Width;
            colTitle.Width = Math.Max(160, width);
        }

        private void RefreshList()
        {
            isRefreshing = true;
            lvTasks.BeginUpdate();
            lvTasks.Items.Clear();
            foreach (TaskItem task in taskManager.Tasks)
            {
                var item = new ListViewItem(task.Title)
                {
                    Checked = task.IsDone,
                    Tag = task,
                    UseItemStyleForSubItems = false,
                };
                item.SubItems.Add(TaskManager.PriorityToText(task.Priority));
                item.SubItems.Add(task.CreatedAt.ToString("dd.MM HH:mm"));
                ApplyItemStyle(item, task);
                lvTasks.Items.Add(item);
            }

            lvTasks.EndUpdate();
            isRefreshing = false;
            UpdateStatus();
        }

        // Выполненные задачи зачёркнуты и серые, приоритет выделен цветом.
        private void ApplyItemStyle(ListViewItem item, TaskItem task)
        {
            Font font = task.IsDone ? doneFont : lvTasks.Font;
            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
            {
                subItem.Font = font;
                subItem.ForeColor = task.IsDone ? DoneColor : lvTasks.ForeColor;
            }

            if (!task.IsDone)
            {
                item.SubItems[1].ForeColor = GetPriorityColor(task.Priority);
                item.SubItems[2].ForeColor = DoneColor;
            }
        }

        private static Color GetPriorityColor(TaskPriority priority) => priority switch
        {
            TaskPriority.High => HighPriorityColor,
            TaskPriority.Medium => MediumPriorityColor,
            _ => LowPriorityColor,
        };

        private void UpdateStatus()
        {
            lblStatus.Text = taskManager.TotalCount == 0
                ? "Список задач пуст"
                : $"Выполнено {taskManager.DoneCount} из {taskManager.TotalCount}";
        }
    }
}
