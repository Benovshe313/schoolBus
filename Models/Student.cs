
namespace Schoolbus.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ParentId {  get; set; }
        public int ClassId {  get; set; }
        public int? RideId {  get; set; }
        public string HomeAdress {  get; set; }
        public string? OtherAdress {  get; set; }
        public Parent Parent { get; set; }
        public Class Class { get; set; }
    }
}
