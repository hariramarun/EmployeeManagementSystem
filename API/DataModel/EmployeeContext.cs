using System.Data.Entity;

namespace API.DataModel
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Model.EmployeeDetails> Employee { get; set; }
    }
}