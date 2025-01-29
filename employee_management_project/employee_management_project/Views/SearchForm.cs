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
            SearchResultView.RowHeadersVisible = false;
        }



        private void NameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            searchOption = "firstname";
        }

        private void IDRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            searchOption = "id";
        }

        private void DpRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            searchOption = "department";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sortableSearchResult.Clear();

            if (searchText.Text.Length <= 0)
            {
                Console.WriteLine("Please input the " + searchOption + "you want to search!");
                return;
            }

           
            string searchValue = searchText.Text;
            List<Employee> searchResult = EmployeeController.Instance.SearchByOption(searchOption, searchValue);

            foreach (Employee em in searchResult)
            {
                sortableSearchResult.Add(em);
            }
        }
    }
}
