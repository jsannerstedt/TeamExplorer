using System;

namespace TeamExplorer.Models
{
    public class Charter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public Session Session { get; set; }
    }

    public class Issue
    {
        
    }

    public class Session
    {
        public DateTime Date { get; set; }

        public int Id { get; set; }
    }
}

