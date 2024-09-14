﻿
namespace Schoolbus.Models
{
    internal class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
