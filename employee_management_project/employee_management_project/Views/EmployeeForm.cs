using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using employee_management_project.Controllers;

namespace employee_management_project.Views {
  public partial class EmployeeForm : Form {

    List<Employee> _employees = new List<Employee>();
    
    public EmployeeForm() {
      InitializeComponent();
    }

    private void idInputBox_TextChanged(object sender, EventArgs e) {
    }

    private void firstNameInputBox_TextChanged(object sender, EventArgs e) {
    }

    private void lastNameInputBox_TextChanged(object sender, EventArgs e) {
    }

    private void departmentDropdownMenu_SelectedIndexChanged(object sender, EventArgs e) {
    }

    private void salaryInputBox_TextChanged(object sender, EventArgs e) {
    }

    private void ageInputBox_TextChanged(object sender, EventArgs e) {
    }

    private void addEmployeeBtn_Click(object sender, EventArgs e) {
      try {
        int id = int.Parse(idInputBox.Text);
        string firstName = firstNameInputBox.Text;
        string lastName = lastNameInputBox.Text;
        string department = departmentDropdownMenu.SelectedItem.ToString();
        float salary = float.Parse(salaryInputBox.Text);
        int age = int.Parse(ageInputBox.Text);

        Employee _newEmployee = new Employee(id, firstName, lastName, department, salary, age);
        _employees.Add(_newEmployee);
        DataSource.Instance.Employees.Add(_newEmployee);

        MessageBox.Show("Employee added successfully!");
        

        // Clear input fields after adding
        idInputBox.Clear();
        firstNameInputBox.Clear();
        lastNameInputBox.Clear();
        salaryInputBox.Clear();
        ageInputBox.Clear();
        departmentDropdownMenu.SelectedIndex = -1; // Reset combo box
      } catch (Exception ex) {
        MessageBox.Show("Error: " + ex.Message);
      }
    }

    private void closeEmployeeFormBtn_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
