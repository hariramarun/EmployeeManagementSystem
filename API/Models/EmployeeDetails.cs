using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class EmployeeDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailId { get; set; }
        public long MobileNumber { get; set; }
        [Key]
        public int EmployeeId { get; set; }
    }
}