using OfficeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Interface
{
    public interface IDepartmentInterface
    {
        Task<IEnumerable<Department>> GetallData();
        void CreateAttendence(Department attend);
        void SaveAllChange();
        void DeleteData(int id);
        void update(Department dept);
    }
}
