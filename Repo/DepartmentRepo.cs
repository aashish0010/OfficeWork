using Microsoft.EntityFrameworkCore;
using OfficeWork.Data;
using OfficeWork.Interface;
using OfficeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Repo
{
    public class DepartmentRepo : IDepartmentInterface
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CreateAttendence(Department attend)
        {
            _context.department.Add(attend);
            
        }

        public void DeleteData(int id)
        {
            var data = _context.department.Find(id);
            _context.department.Remove(data);
        }

        public async Task<IEnumerable<Department>> GetallData()
        {
            return await _context.department.OrderByDescending(d => d.Id).ToListAsync();

        }

        public void SaveAllChange()
        {
            _context.SaveChanges();
            
        }
        public void update( Department dept)
        {
            _context.Update(dept);
        }
    }
}
