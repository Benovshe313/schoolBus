
namespace Schoolbus.Models
{
    internal class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int BusId { get; set; }
        public string HomeAdress { get; set; }
        public string LicenseNumber { get; set; }
        public Bus Bus { get; set; }
        public ICollection<Ride> Rides { get; set; }
    }
}
