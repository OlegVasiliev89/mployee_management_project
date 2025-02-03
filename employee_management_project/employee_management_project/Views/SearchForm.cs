using employee_management_project.Controllers;
using employee_management_project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace employee_management_project
{
    public partial class SearchForm : Form
    {
        private string searchOption = "firstname";

        private SortableBindingList<Employee> sortableSearchResult = new SortableBindingList<Employee>();
        private SortableBindingList<Employee> resultForMainGUI = new SortableBindingList<Employee>();
        private MainForm _mainForm; // the reference of the mainform instance is saved here
        public SearchForm(MainForm mainForm) // we pass a reference of the mainform in the
            // construtor of searchform so the mainform is immidietly updated 
        {
            InitializeComponent();
            _mainForm = mainForm; // the construtor saves the instance 
            InitializeData();
        }




        private void InitializeData()
        {
            SearchResultView.DataSource = sortableSearchResult;
        }

        private void FNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SwitchToNormalSearchModel();
            searchOption = "firstname";
        }

        private void LNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SwitchToNormalSearchModel();
            searchOption = "lastname";
        }

        private void IDRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SwitchToNormalSearchModel();
            searchOption = "id";
        }

        private void DpRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SwitchToDpSearchModel();
            searchOption = "department";
        }

        private void SalaryRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SwitchToNormalSearchModel();
            searchOption = "salary";
        }

        private void AgeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SwitchToNormalSearchModel();
            searchOption = "age";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (searchText.Text.Length <= 0)
            {
                MessageBox.Show("Please input the " + searchOption + "you want to search!");
                Console.WriteLine("Please input the " + searchOption + "you want to search!");
                return;
            }

            string searchValue = searchOption.Equals("department") ? departmentDropdownMenu.SelectedItem.ToString() : searchText.Text;
            EmployeeController.Instance.SearchByOption(searchOption, searchValue, ref sortableSearchResult);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void SwitchToDpSearchModel() {
            departmentDropdownMenu.Visible = true;
            searchText.Visible = false;
            searchText.Text = "";
        }

        private void SwitchToNormalSearchModel() {
            departmentDropdownMenu.Visible = false;
            searchText.Visible = true;
        }

        private void PRBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SearchResultView.SelectedRows)
            {
                Employee selectedEmployee = (Employee)row.DataBoundItem; // we cast the data of each row into type Employee

                if (!DataSource.Instance.SearchResult.Any(emp => emp.id == selectedEmployee.id))
                {// we check if any employee ID is in the list, if it isn't we add it to the list
                    DataSource.Instance.SearchResult.Add(selectedEmployee);  
                }
            }

            _mainForm.UpdateDataView(); // we update the list via the public UpdateDataView method
        }
    }
}
