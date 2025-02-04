using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_project.Interfaces
{
    public interface IDataController<T>
    {
        void AddItem(T newItem);

        void DeleteItem(T deleteItem);

        void DeleteAll();
    }
}
