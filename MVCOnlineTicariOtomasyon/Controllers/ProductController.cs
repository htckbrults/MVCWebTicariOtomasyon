using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOnlineTicariOtomasyon.Models.Classes;

namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context c = new Context();
        public ActionResult Index()
        {
            var products = c.Produucts.Where(x => x.Status == true).ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult NewProduct()
        {
            List<SelectListItem> value1 = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.Value1= value1;
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(Product p)
        {
            c.Produucts.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id)
        {
            var value = c.Produucts.Find(id);
            value.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringProduct(int id)
        {
            List<SelectListItem> value1 = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.Value1 = value1;
            var productvalue = c.Produucts.Find(id);
            return View("BringProduct",productvalue) ;
        }
        public ActionResult UpdateProduct(Product pr)
        {
            var prd = c.Produucts.Find(pr.ProductId);
            prd.PurchasePrice = pr.PurchasePrice;
            prd.Status= pr.Status;
            prd.CategoryId=pr.CategoryId; 
            prd.Brand=pr.Brand;
            prd.SalePrice=pr.SalePrice;
            prd.Stock = pr.Stock;
            prd.ProductName=pr.ProductName;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}