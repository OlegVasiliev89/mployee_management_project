using employee_management_project.Interfaces;
using employee_management_project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project.Controllers
{
    public class CSVFileController : IFileController<Employee>
    {
        private static CSVFileController _instance;

        private CSVFileController()
        {
        }

        public static CSVFileController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CSVFileController();
                }
                return _instance;
            }
        }

        public void ReadFile(string filePath, ref SortableBindingList<Employee> searchResult)
        {
            CSVFileHandler.ReadCSVFile<Employee>(filePath, ref searchResult);
        }


        public void WriteFile(string filePath, in SortableBindingList<Employee> writeResult)
        {
            CSVFileHandler.WriteCSVFile<Employee>(filePath, writeResult);
        }
    }
}
