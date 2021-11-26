
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
    public class DesignationRepo : IDesignationInterface
    {
        private readonly ApplicationDbContext _context;
        public DesignationRepo(ApplicationDbContext context)
        {
            _context = context;
        }
       

        public void CreateDesignation(Designation design)
        {
            _context.designation.Add(design);
        }

        public void DeleteData(int id)
        {
            var data = _context.designation.Find(id);
            _context.designation.Remove(data);
        }

        public async Task<IEnumerable<Designation>> GetallData()
        {
            return await _context.designation.ToListAsync();

        }

        public void SaveAllChange()
        {
            _context.SaveChanges();
            
        }
        public void update( Designation design)
        {
            _context.Update(design);
        }

        

        
    }
}
