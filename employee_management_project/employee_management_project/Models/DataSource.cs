using employee_management_project.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project.Controllers
{
    public class DataSource
    {
        private static DataSource _instance;

        private SortableBindingList<Employee> _employees = new SortableBindingList<Employee>();
        public SortableBindingList<Employee> SearchResult { get; set; }

        private readonly string filePath = @"..\..\Models\Data.csv";

        private DataSource() {
            SearchResult = new SortableBindingList<Employee>();
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
            //Employee test1 = new Employee(1, "test", "bar", "HR", 1000.00f, 25);
            //Employee test2 = new Employee(2, "test", "bar", "HR", 2000.00f, 25);
            //Employee test3 = new Employee(3, "test", "bar", "HR", 3000.00f, 25);
            //Employee test4 = new Employee(4, "test", "bar", "HR", 4000.00f, 25);
            //Employee test5 = new Employee(5, "test", "bar", "HR", 5000.00f, 25);
            //Employee test6 = new Employee(6, "test", "bar", "HR", 6500.00f, 25);
            //Employee test7 = new Employee(7, "test", "bar", "HR", 7000.00f, 25);

            //_employees.Add(test1);
            //_employees.Add(test2);
            //_employees.Add(test3);
            //_employees.Add(test4);
            //_employees.Add(test5);
            //_employees.Add(test6);
            //_employees.Add(test7);
            CSVFileHandler.ReadCSVFile(filePath, ref _employees);
        }

        public void WriteData(string filePath) {
            CSVFileHandler.WriteCSVFile(filePath, _employees);
        }

        public SortableBindingList<Employee> Employees
        {
            get { return _employees; }
        }
    }
}
