using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using employee_management_project.Controllers;
using employee_management_project.Utils;
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

      EmployeeForm employeeForm = new EmployeeForm();
      employeeForm.ShowDialog();
    }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSource.Instance.LoadData();

            UpdateDataView();
        }
        public void UpdateDataView()
        {
            if (DataSource.Instance.SearchResult.Count > 0)
            { // this let's us count the searchform list, if there are more than one item on
              // the list, the searchform list will be loaded to the data grid
                
                dataGridView1.DataSource = DataSource.Instance.SearchResult;  
                exportCSVButton.Visible = true;
            }
            else
            {
                dataGridView1.DataSource = DataSource.Instance.Employees;  
                exportCSVButton.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);// when we click on the search button,
                                                         // we pass the current instance to the searchform
            searchForm.ShowDialog();
        }
        private void exportCSVButton_Click(object sender, EventArgs e)
        {
           //Ignore this button
        }

        private void exportCSVButton_Click_1(object sender, EventArgs e)
        {
            string filePath = exportCSVTextBox.Text.ToString() + ".csv";
            CSVFileHandler.WriteCSVFile(filePath, DataSource.Instance.SearchResult);
            MessageBox.Show("Filtered data exported successfully to " + Path.GetFullPath(filePath));
        }

        private void delSelectionButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Employee selectedEmployee = (Employee)row.DataBoundItem;

                if (selectedEmployee != null)
                {
                    DataSource.Instance.SearchResult.Remove(selectedEmployee);
                }
            }

            UpdateDataView();
        }
    }
}
