
namespace Schoolbus.Models
{
    internal class Bus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number {  get; set; }
        public int SeatCount {  get; set; }
        public Driver Driver { get; set; }
        public int DriverId {  get; set; }
    }
}
