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

         public IActionResult Delete(int teacherid) {
            var teacherObj = _db.Teacher.Find(teacherid);
            return View(teacherObj);
        }


        [HttpPost]
        public IActionResult DeletePost(int id) {
            var teacherObj = _db.Teacher.Find(id);

            if (ModelState.IsValid)
            {
                _db.Teacher.Remove(teacherObj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teacherObj);
        }

         public IActionResult Create() {
            return View();
        }


        [HttpPost]
        public IActionResult Create([Bind("Name,joinDate,birthDate")] Student studobj) {
            if (ModelState.IsValid)
            {
                _db.Student.Add(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studobj);
        }

    }
}
