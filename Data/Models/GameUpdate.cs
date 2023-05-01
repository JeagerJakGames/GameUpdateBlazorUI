namespace GameUpdateBlazorUI.Data.Models
{
    public class GameUpdate
    {
        public int Id { get; set; } = 0;
        public string? Name { get; set; } = "Name";
        public string? ShortDetails { get; set; } = "ShortDetails";
        public string? FullDetails { get; set; } = "LongDetails";
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
