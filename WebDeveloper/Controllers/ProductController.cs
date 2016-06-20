using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloperDataAccess;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        // GET: Client
        private ProductData _product = new ProductData();
        public ActionResult Index()
        {
            return View(_product.GetList());
        }

        public ActionResult Create()
        {
            return View(new Product());
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            Product product = _product.GetProduct(ID);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var client = _product.GetProduct(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            if (_product.Delete(product) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var product = _product.GetProduct(id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}