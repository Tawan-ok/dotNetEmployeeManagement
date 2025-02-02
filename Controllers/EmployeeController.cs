using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MongoDbContext _context;

        public EmployeeController(MongoDbContext context)
        {
            _context = context;
        }

        // 📌 แสดงรายการพนักงาน (หน้า Index)
        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.Find(_ => true).ToListAsync();
            return View(employees);
        }

        // 📌 หน้าเพิ่มพนักงาน
        public IActionResult Create()
        {
            return View(); // ✅ ต้องมีไฟล์ `Views/Employee/Create.cshtml`
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _context.Employees.InsertOneAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // 📌 หน้าแก้ไขพนักงาน
        public async Task<IActionResult> Edit(string id)
        {
            var employee = await _context.Employees.Find(e => e.Id == id).FirstOrDefaultAsync();
            if (employee == null) return NotFound();
            return View(employee); // ✅ ต้องมีไฟล์ `Views/Employee/Edit.cshtml`
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _context.Employees.ReplaceOneAsync(e => e.Id == employee.Id, employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // 📌 หน้ายืนยันการลบพนักงาน
        public async Task<IActionResult> Delete(string id)
        {
            var employee = await _context.Employees.Find(e => e.Id == id).FirstOrDefaultAsync();
            if (employee == null) return NotFound();
            return View(employee); // ✅ ต้องมีไฟล์ `Views/Employee/Delete.cshtml`
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _context.Employees.DeleteOneAsync(e => e.Id == id);
            return RedirectToAction(nameof(Index));
        }
    }
}
