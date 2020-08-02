using System.Collections.Generic;
using System.Web.Http;

namespace SampleAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public List<API.Model.EmployeeDetails> GetEmployee()
        {
            return new API.DataModel.EmployeeDetails().GetEmployeeDetails();
        }

        public void Put([FromBody] API.Model.EmployeeDetails employee)
        {
            API.DataModel.EmployeeDetails emp = new API.DataModel.EmployeeDetails();
            emp.InsertEmployee(employee);
        }

        public void Post(int employeeId, [FromBody] API.Model.EmployeeDetails employee)
        {
            new API.DataModel.EmployeeDetails().UpdateEmployee(employeeId, employee);
        }

        public void Delete(int employeeId)
        {
            new API.DataModel.EmployeeDetails().DeleteEmployee(employeeId);
        }
    }
}
