using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloperDataAccess;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {

            //var client = new Client()
            //{
            //    ID = 1,
            //    LastName = "cueva",
            //    Name = "aladino"
            //};
            var lista=new List<Client>{
                new Client {ID=1,Name="Luis",LastName="Ramirez"},
                new Client {ID=2,Name="Fiorela",LastName="Galarza"}
            };
            return View(lista);
        }
        public ActionResult Product()
        {
            var producData = new ProductData();
            return View(producData.getFakeProducts());
            
        }
    }
}