using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project.Controllers
{
    public class EmployeeController
    {
        private static EmployeeController _instance;

        private EmployeeController()
        {
        }

        public static EmployeeController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeController();
                }
                return _instance;
            }
        }

        public List<Employee> SearchByOption(string option, object searchValue)
        {
            List<Employee> searchResult = new List<Employee>();

            List<Employee> employees = DataSource.Instance.Employees;

            foreach (Employee employee in employees)
            {
                var prop = employee.GetType().GetProperty(option);
                if (prop != null)
                {
                    var propVal = prop.GetValue(employee, null);
                    if (propVal != null)
                    {
                        string propValStr = propVal.ToString();
                        if (propValStr.Equals(searchValue))
                            searchResult.Add(employee);
                    }
                }
            }

            return searchResult;
        }
    }
}
