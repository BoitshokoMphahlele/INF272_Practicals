using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace u24634400_INF272_Prac2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult StudyGroupView()
        {
            List<Models.MyModel> students = new List<Models.MyModel>();//Create list for the students
            students.Add(new Models.MyModel { StudentNumber = "u24634400", FirstName = "Boitshoko", LastName = "Mphahlele", EmailAddress = "u24634400@tuks.co.za", mylink = "~/HTML/Boitshoko.html" });
            students.Add(new Models.MyModel { StudentNumber = "u24784606", FirstName = "Msizi", LastName = "Gumede", EmailAddress = "u24784606@tuks.co.za", mylink = "~/HTML/Msizi.html" });
            students.Add(new Models.MyModel { StudentNumber = "u24924718", FirstName = "Gundo", LastName = "Ndou", EmailAddress = "u24924718@tuks.co.za", mylink = "~/HTML/Gundo.html" });
            students.Add(new Models.MyModel { StudentNumber = "u24717739", FirstName = "Ritshidze", LastName = "Nedzimauli", EmailAddress = "u24717739@tuks.co.za", mylink = "~/HTML/Ritshidze.html" });
            students.Add(new Models.MyModel { StudentNumber = "u24758354", FirstName = "Nhlanhla", LastName = "Mnisi", EmailAddress = "u24758354@tuks.co.za", mylink = "~/HTML/Nhlanhla.html" });
            return View(students);
            
        }

       
    }
}