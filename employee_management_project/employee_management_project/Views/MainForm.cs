using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using employee_management_project.Views;

namespace employee_management_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

    private void openEmployeeFormBtn_Click(object sender, EventArgs e) {

      // Create Employee Form and open it onClick
      EmployeeForm employeeForm = new EmployeeForm();
      employeeForm.ShowDialog();
    }
  }
}
