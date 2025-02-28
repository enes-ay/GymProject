namespace GymManagement.API.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; } // Monthly, Annual
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

}
