
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeWork.Data;
using OfficeWork.Interface;
using OfficeWork.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeWork.Controllers
{
    public class DepartmentController : Controller
    {
        
        private readonly IDepartmentInterface _department;
        private readonly ApplicationDbContext _context;
        
        public DepartmentController(IDepartmentInterface department, ApplicationDbContext context)
        {
            _department = department;
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public async Task<IActionResult> Getdata()
        {
            
            var obj = await _department.GetallData();
            return Json(new { data = obj });

            
            
        }
        public async Task<IActionResult> Create(int id = 0)
        {
            if (id == 0)
            {
                return View(new Department());
            }
            else
            {
                var bMS = await _context.department.FindAsync(id);
                if (bMS == null)
                {
                    return NotFound();
                }
                return Json(bMS);
            }

        }
        [HttpPost]
        public async Task<IActionResult> Create(int id,Department department)
        {
            if(id == 0)
            {
                var currentUserId = User.Identity.GetUserId();
                var data = new Department
                {
                    DepartmentName = department.DepartmentName,
                    Headid = department.Headid,
                    Companyid = department.Companyid,
                    Clientid = currentUserId,
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                };
                _department.CreateAttendence(data);
                _department.SaveAllChange();
                return Json(department);

            }
            else
            {
                var currentUserId = User.Identity.GetUserId();
                var data = new Department
                {
                    Id = department.Id,
                    DepartmentName = department.DepartmentName,
                    Headid = department.Headid,
                    Companyid = department.Companyid,
                    Clientid = currentUserId,
                    CreatedDate = department.CreatedDate,
                    UpdateDate = DateTime.Now,
                };
                _context.department.Update(data);
                _context.SaveChanges();
                return Json(department);

            }
            
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _department.DeleteData(id);
            _department.SaveAllChange();
            return Json(id);
        }
    }
}
