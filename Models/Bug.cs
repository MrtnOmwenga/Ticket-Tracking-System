namespace TicketTrackingSystem.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public bool IsResolved { get; set; }
        public int CreatedById { get; set; }
        public AppUser CreatedBy { get; set; }
    }
}
