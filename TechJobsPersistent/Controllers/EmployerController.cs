using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;
        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel employerViewModel = new AddEmployerViewModel();
            return View(employerViewModel);
        }

        //ProcessAddEmployerForm
        //AddPartTwo
        [HttpPost]
        public IActionResult Add(AddEmployerViewModel employerViewModel)
        {
            if (ModelState.IsValid)
            {
                /*string employerName = employerViewModel.Name;
                string employerLocation = employerViewModel.Location;*/

                /*List<Employer> existingEmployer = context.Employers
                    //.Where(e => e.Name == employerName)
                    //.Where(e => e.Location == employerLocation)
                    .ToList();*/
 
                Employer employer = new Employer
                {
                    Name = employerViewModel.Name,
                    Location = employerViewModel.Location
                };
                context.Employers.Add(employer);
                context.SaveChanges();
                return Redirect("Index");
            }
            return View(employerViewModel);
        }

        public IActionResult About(int id)
        {
            List<Employer> employers = context.Employers.ToList();
            Employer theEmployer;
                foreach (Employer employer in employers)
            {
                if (employer.Id == id)
                {
                    theEmployer = employer;
                    return View(theEmployer);
                }
            };
            return View(employers);
        }
    }
}
