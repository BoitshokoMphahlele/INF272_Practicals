using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using u24634400_INF272_Prac2.Models;

namespace u24634400_INF272_Prac2.Controllers
{
    public class PeopleController : Controller
    {
        // Simulated database (will be lost on app restart)
        private static List<MyModel> students = new List<MyModel>();

        public ActionResult StudyGroupView(string searchTerm = "")
        {
            List<MyModel> filteredStudents = students;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string lower = searchTerm.ToLower();
                filteredStudents = students
                    .Where(s => !string.IsNullOrEmpty(s.FirstName) && s.FirstName.ToLower().Contains(lower))
                    .ToList();

                ViewBag.SearchTerm = lower;
            }
            else
            {
                ViewBag.SearchTerm = "";
            }

            return View(filteredStudents);
        }

        [HttpGet]
        public ActionResult CreatePeopleView()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePeopleView(MyModel pm)
        {
            if (ModelState.IsValid)
            {
                students.Add(pm);
                TempData["SuccessMessage"] = "Student added successfully!";
                return RedirectToAction("StudyGroupView");
            }

            return View(pm);
        }
    }
}
