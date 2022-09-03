using Humanizer;

namespace CRUD.Web.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public Gender Gender { get; set; } 
    }
}
