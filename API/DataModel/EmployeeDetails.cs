using System.Collections.Generic;
using System.Linq;

namespace API.DataModel
{
    public class EmployeeDetails
    {
        public List<Model.EmployeeDetails> GetEmployeeDetails()
        {
            List<Model.EmployeeDetails> employeeDetailsList = new List<Model.EmployeeDetails>();
            using (var context = new EmployeeContext()) {
                employeeDetailsList = context.Employee.OrderBy(emp => emp.EmployeeId).ToList();
            }
            return employeeDetailsList;
        }
        public void InsertEmployee(Model.EmployeeDetails employee)
        {
            using (var context = new EmployeeContext())
            {
                context.Employee.Add(employee);
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(int employeeId, Model.EmployeeDetails updatedEmployeeDetails)
        {
            Model.EmployeeDetails employee = new Model.EmployeeDetails();
            using (var context = new EmployeeContext())
            {
                employee = context.Employee.Where(emp => emp.EmployeeId == employeeId).FirstOrDefault();
            }
            employee = updatedEmployeeDetails;
            using (var context = new EmployeeContext()) {
                context.Employee.Attach(employee);
                context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            Model.EmployeeDetails employeeList= new Model.EmployeeDetails();
            using (var context = new EmployeeContext())
            {
                employeeList = context.Employee.Where(emp => emp.EmployeeId == employeeId).FirstOrDefault();
                context.Employee.Remove(employeeList);
                context.SaveChanges();
            }
        }
    }
}