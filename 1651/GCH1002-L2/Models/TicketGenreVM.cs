using Microsoft.AspNetCore.Mvc.Rendering;

namespace GCH1002_L2.Models
{
    public class TicketGenreVM
    {
        public List<Ticket>? Tickets { get; set; }
        public SelectList? Genres { get; set; }
        public string? TicketGenre { get; set; }

    }
}
