using MilleniumTest.Models;

namespace MilleniumTest
{
    public class TodoItem
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime LastChangeDate { get; set; }

        public DateTime? FinishedDate { get; set; }

        public bool IsFinished { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        public PriorityType Priority { get; set; }
    }
}