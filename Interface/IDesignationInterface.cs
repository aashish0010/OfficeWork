using OfficeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Interface
{
    public interface IDesignationInterface
    {
        Task<IEnumerable<Designation>> GetallData();
        void CreateDesignation(Designation design);
        void SaveAllChange();
        void DeleteData(int id);
        void update(Designation design);
    }
}
