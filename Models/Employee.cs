using System;
namespace tracking.Models
{
    public class Employee{
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}