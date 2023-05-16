namespace GCH1002_L2.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedData { get; set; }
        public decimal Price { get; set; }
        public string? Genre { get; set; }
    }
}
