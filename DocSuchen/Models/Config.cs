namespace DocSuchen.Models
{
    public class Config
    {
        public int NumberOfCores { get; set; }
        public string? WorkingDirectory { get; set; }
        public List<string>? AvailableDirectories { get; set; }
    }
}