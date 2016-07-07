using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.Model;
using WebDeveloperDataAccess;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")] //ponemos el prefijo
    public class RazorController : Controller
    {
        // GET: Razor
      [Route]
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

        //[Route("EntryDate/{date:DateTime}")]
        [Route("Entry/{date:DateTime}")]
        public ActionResult EntryDate(DateTime date)
        {
            ViewBag.Date = date.ToShortDateString();
            return View();

        }
        [Route("Entry/{id:int}")]
        public String EntryId(int id)
        {
             
            return id.ToString();

        }
    }
}