using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlimmingCenter2.Models;
using SlimmingCenter2.Models.Context;
using SlimmingCenter2.Models.ClientModel;

namespace SlimmingCenter2.Controllers
{
    public class HomeController : Controller
    {
        CenterContext db = new CenterContext();
        public ActionResult Index()
        {
            try
            {                
                ViewBag.SuccessText = "DataBase created!";                
                return View(db.Clients.ToList());
            }
            catch(Exception e)
            {
                ViewBag.Excpection = e.Message;
                return View();
            }
        }

      
    }
}