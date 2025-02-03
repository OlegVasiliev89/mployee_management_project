using employee_management_project.Controllers;
using employee_management_project.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace employee_management_project
{
    public partial class SearchForm : Form
    {
        private string searchOption = "firstname";

        private SortableBindingList<Employee> sortableSearchResult = new SortableBindingList<Employee>();
        private SortableBindingList<Employee> resultForMainGUI = new SortableBindingList<Employee>();

        public SearchForm()
        {
            InitializeComponent();
            InitializeData();
            
            // Temporarily Initializing the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();
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
            DataSource.Instance.SearchResult.Clear();
            foreach(DataGridViewRow result in SearchResultView.SelectedRows) {
                DataSource.Instance.SearchResult.Add((Employee)result.DataBoundItem);
            }
        }
    }
}
