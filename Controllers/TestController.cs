using DemoSchoolConnection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSchoolConnection.Controllers
{
    public class TestController : Controller
    {
        private DemoSchoolContext db { get; set; }
        public TestController (DemoSchoolContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            Course newCourse = new Course();
            newCourse.Title = "How to add new courses";
            db.Courses.Add(newCourse);

            db.SaveChanges();

            return View(db.Courses.ToList());
        }
    }
}
