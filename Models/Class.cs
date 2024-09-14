
namespace Schoolbus.Models
{
    internal class Class
    {
        public int Id { get; set; }
        public string ClassName {  get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
