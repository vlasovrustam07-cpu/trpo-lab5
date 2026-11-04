namespace TaskPlanner.Models
{
    /// <summary>
    /// Задача в планировщике.
    /// </summary>
    public class TaskItem
    {
        public TaskItem(string title, TaskPriority priority)
        {
            Title = title;
            Priority = priority;
            CreatedAt = DateTime.Now;
        }

        public string Title { get; }

        public TaskPriority Priority { get; }

        public bool IsDone { get; set; }

        public DateTime CreatedAt { get; }
    }
}
