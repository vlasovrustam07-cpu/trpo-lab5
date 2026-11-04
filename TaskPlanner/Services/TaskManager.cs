using TaskPlanner.Models;

namespace TaskPlanner.Services
{
    /// <summary>
    /// Список задач в памяти: добавление, удаление и подсчёт выполненных.
    /// </summary>
    public class TaskManager
    {
        private readonly List<TaskItem> tasks = new List<TaskItem>();

        public IReadOnlyList<TaskItem> Tasks => tasks;

        public int TotalCount => tasks.Count;

        public int DoneCount => tasks.Count(t => t.IsDone);

        /// <summary>
        /// Добавляет задачу. Пустое название не допускается.
        /// </summary>
        public TaskItem Add(string title, TaskPriority priority)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Название задачи не может быть пустым.", nameof(title));
            }

            var item = new TaskItem(title.Trim(), priority);
            tasks.Add(item);
            return item;
        }

        public bool Remove(TaskItem item) => tasks.Remove(item);

        public int RemoveCompleted() => tasks.RemoveAll(t => t.IsDone);

        /// <summary>
        /// Название приоритета для отображения на форме.
        /// </summary>
        public static string PriorityToText(TaskPriority priority) => priority switch
        {
            TaskPriority.High => "Высокий",
            TaskPriority.Medium => "Средний",
            _ => "Низкий",
        };
    }
}
