namespace TeamExplorer.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Stacktrace { get; set; }
        public Charter Charter { get; set; }
    }
}