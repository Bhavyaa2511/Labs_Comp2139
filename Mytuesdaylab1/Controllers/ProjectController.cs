using Microsoft.AspNetCore.Mvc;
using Mytuesdaylab1.Models;

namespace Mytuesdaylab1.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {

            var projects = new List<Project>()
            {
                new Project {Projectid = 1,  Name = "Project 1 " , Description = " First Project "}
            };

          return View(projects);
        }


        public IActionResult Details(int id)
        {
            var project = new Project { Projectid = 1, Name = "Project 1 ", Description = " First Project " };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
