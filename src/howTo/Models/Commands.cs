namespace howTo.Models
{
    public class Commands
    {
        public int Id { get; set; }
        public string HowTo { get; set; } = null!;
        public string Platform { get; set; } = null!;
        public string CommandLine { get; set; } = null!;
    }
}
