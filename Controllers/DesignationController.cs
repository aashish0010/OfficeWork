
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
    public class DesignationController : Controller
    {
        private readonly IDesignationInterface _designation;
        private readonly ApplicationDbContext _context;
        public DesignationController(IDesignationInterface designation, ApplicationDbContext context)
        {
            _designation = designation;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Getdata()
        {
            
            
                var obj = await _designation.GetallData();
                return Json(new { data = obj });

            
            
        }
        public async Task<IActionResult> Create(int id = 0)
        {
            if (id == 0)
            {
                return View(new Designation());
            }
            else
            {
                var bMS = await _context.designation.FindAsync(id);
                if (bMS == null)
                {
                    return NotFound();
                }
                return Json(bMS);
            }

        }
        [HttpPost]
        public async Task<IActionResult> Create(int id,Designation designation)
        {
            if(id == 0)
            {
                var currentUserId = User.Identity.GetUserId();
                var data = new Designation
                {
                    DesignationName = designation.DesignationName,
                    ComId = designation.ComId,
                    CustomerId = currentUserId,
                    AddedDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                };
                _designation.CreateDesignation(data);
                _designation.SaveAllChange();
                return Json(designation);

            }
            else
            {
                var currentUserId = User.Identity.GetUserId();
                var data = new Designation
                {
                    Id = designation.Id,
                    DesignationName = designation.DesignationName,
                    ComId = currentUserId,
                    CustomerId = designation.CustomerId,
                    AddedDate = designation.AddedDate,
                    UpdateDate = DateTime.Now,
                };
                _context.designation.Update(data);
                _context.SaveChanges();
                return Json(designation);

            }
            
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _designation.DeleteData(id);
            _designation.SaveAllChange();
            return Json(id);
        }
    }
}
