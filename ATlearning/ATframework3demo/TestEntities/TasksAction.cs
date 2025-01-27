namespace ATframework3demo.TestEntities
{
    public class TasksAction
    {
        public TasksAction(string title) 
        { 
            Title = title ?? throw new ArgumentNullException(nameof(title)); 
        }
        public string Title { get; set; }
    }
}
