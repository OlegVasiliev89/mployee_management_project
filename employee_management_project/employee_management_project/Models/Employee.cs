using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project
{
    public class Employee
    {
        public string name { set; get; }
        public int age { set; get; }
        public int id { set; get; }

        public string department { set; get; }

        public float salary { set; get; }

        public Employee(string name, int age, int id, string department, float salary) {
            this.name = name;
            this.age = age;
            this.id = id;
            this.department = department;
            this.salary = salary;
        }

        
    }
}
