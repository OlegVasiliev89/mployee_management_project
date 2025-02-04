using employee_management_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project.Controllers
{
    internal class SearchResultController : IDataController<Employee>
    {
        private static SearchResultController _instance;

        private SearchResultController()
        {
        }

        public static SearchResultController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SearchResultController();
                }
                return _instance;
            }
        }

        public void AddItem(Employee newItem)
        {
            DataSource.Instance.SearchResult.Add(newItem);
        }

        public void DeleteAll()
        {
            DataSource.Instance.SearchResult.Clear();
        }

        public void DeleteItem(Employee deleteItem)
        {
            DataSource.Instance.SearchResult.Remove(deleteItem);
        }

        public bool IsIDExist(int id)
        {
            return DataSource.Instance.SearchResult.Any(emp => emp.id == id);
        }
    }
}
