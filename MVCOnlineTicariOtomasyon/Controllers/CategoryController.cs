using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOnlineTicariOtomasyon.Models.Classes;


namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category k)
        {
            c.Categories.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var cate = c.Categories.Find(id);
            c.Categories.Remove(cate);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringCategory(int id)
        {
            var category =c.Categories.Find(id);
            return View("BringCategory", category);
        }
        public ActionResult UpdateCategory(Category k)
        {
            var categ=c.Categories.Find(k.Id);
            categ.CategoryName = k.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}