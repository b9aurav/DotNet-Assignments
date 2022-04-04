using MVC_Practical;
using MVC_Practical.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practical.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDBContext _db;

        public TeacherController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> listofteachers = _db.Teacher;
            return View(listofteachers);
        }

        [HttpGet]
        public IActionResult Edit(int teacherid)
        {
            var teacherobj = _db.Teacher.Find(teacherid);
            return View(teacherobj);

        }

        [HttpPost]
        public IActionResult Edit(Teacher updatedvaluesobj)
        {
            _db.Teacher.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
