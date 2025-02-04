using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project.Interfaces
{
    public interface IFileController<T> where T : class
    {
        void ReadFile(string filePath, ref SortableBindingList<T> readResult);

        void WriteFile(string filePath, in SortableBindingList<T> writeResult);
    }
}
