using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data_Annotaion_DemoWebApplication.Models;
namespace Data_Annotaion_DemoWebApplication.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Create()
        {

            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }          
        }

	}
}