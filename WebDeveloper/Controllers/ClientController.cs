using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloperDataAccess;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        private ClientData _client = new ClientData();
        public ActionResult Index()
        {         
            return View(_client.getList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.add(client);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}