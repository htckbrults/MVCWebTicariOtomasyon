using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOnlineTicariOtomasyon.Models.Classes;

namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        Context c = new Context();  
        public ActionResult Index()
        {
            var values = c.Departmans.Where(x=>x.Status==true).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();  
        }


        [HttpPost]
        public ActionResult AddDepartment(Department d)
        {
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");   
        }
        public ActionResult DeleteDepartment(int id)
        {
            var dep = c.Departmans.Find(id);
            dep.Status = true;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringDepartment(int id)
        {
            var dpt = c.Departmans.Find(id);
            return View("BringDepartment",dpt);
        }
        public ActionResult UpdateDepartment(Department de)
        {
            var dept= c.Departmans.Find(de.DepartmentId);
            dept.DepartmentName = de.DepartmentName;
                c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DepartmentDetail(int id)
        {
            var values=c.Employees.Where(x=>x.Departmentid==id).ToList();
            var dpt=c.Departmans.Where(x=>x.DepartmentId==id).Select(y=>y.DepartmentName).FirstOrDefault();
            ViewBag.d = dpt;
            return View(values);
        }
    }
}