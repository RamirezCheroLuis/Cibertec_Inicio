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
    [Authorize]
    public class ClientController : Controller
    {
        // GET: Client
        // private ClientData _client = new ClientData();
        //siempre debe tener construtor al inyectar
        private ClientData _client;
       public ClientController(ClientData client)
        {
            _client = client;
        }
        public ActionResult Index()
        {
            ViewBag.Title = Resources.Resource.Client_Title;      
            return View(_client.GetList());
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
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }
        
        //public ActionResult Edit(int ID)
        //{            
        //    Client cliente = _client.GetClient(ID);
        //    if (cliente == null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(cliente);
        //}
        //[HttpPost]
        //public ActionResult Edit(Client client)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _client.Update(client);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public ActionResult Delete(int id)
        //{
        //    var client = _client.GetClient(id);
        //    if(client==null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(client);
        //}

        //[HttpPost]
        //public ActionResult Delete(Client client)
        //{
        //    if (_client.Delete(client)>0)
        //    {                
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //public ActionResult Details(int id)
        //{
        //    var client = _client.GetClient(id);
        //    if (client == null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(client);
        //}
    }
}