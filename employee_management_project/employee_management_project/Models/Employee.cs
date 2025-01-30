using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project
{
    public class Employee
    {
        public int id { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string department { set; get; }
        public float salary { set; get; }
        public int age { set; get; }

        public Employee() { }
        public Employee(int id,string firstname, string lastname, string department, float salary, int age) {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.department = department;
            this.salary = salary;
            this.age = age;
        }
    }
}
