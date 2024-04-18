namespace BlazorApp
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
        public DateTime TimeCreated { get; set; }
        public DateTime Deadline { get; set; }
       
    }
}
