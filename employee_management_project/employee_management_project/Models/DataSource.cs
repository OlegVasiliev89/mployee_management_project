using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project.Controllers
{
    public class DataSource
    {
        private static DataSource _instance;

        private List<Employee> _employees = new List<Employee>();

        private DataSource() {
        }

        public static DataSource Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataSource();
                }
                return _instance;
            }
        }

        public void LoadData() {
            Employee test1 = new Employee("test", 10, 1, "HR", 20000.00f);
            Employee test2 = new Employee("test2", 3, 2, "HR", 20000.00f);
            Employee test3 = new Employee("test3", 11, 3, "HR", 20000.00f);
            Employee test4 = new Employee("test4", 15, 1, "HR", 20000.00f);
            Employee test5 = new Employee("test5", 2, 4, "HR", 20000.00f);
            Employee test6 = new Employee("test", 22, 1, "HR", 20000.00f);
            Employee test7 = new Employee("test", 39, 5, "HR", 20000.00f);

            _employees.Add(test1);
            _employees.Add(test2);
            _employees.Add(test3);
            _employees.Add(test4);
            _employees.Add(test5);
            _employees.Add(test6);
            _employees.Add(test7);
        }

        public List<Employee> Employees
        {
            get { return _employees; }
        }
    }
}
