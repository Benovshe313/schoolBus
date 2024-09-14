
namespace Schoolbus.Models
{
    internal class Ride
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
