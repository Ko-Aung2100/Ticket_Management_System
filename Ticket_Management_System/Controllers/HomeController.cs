using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_Management_System.Models;
namespace Ticket_Management_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["HasStarted"] = true;
            return View();
        }

        public ActionResult Details(int? id, String value)
        {
            if (Session["HasStarted"] == null || value == null || id == null)
            {
                // Redirect to the Index page if the session is missing
                return RedirectToAction("Index", "Home");
            }
            var model = new TicketDetail
            {
                From = "Turtle Lake, District 3",
                To = value,
                ToID = id.Value,
                TicketCost = 20 // Explicitly casting decimal to int
            };
            return View(model);
        }

        public ActionResult SelectDestination()
        {
            if (Session["HasStarted"] == null)
            {
                // Redirect to the Index page if the session is missing
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult SetLanguage(string language)
        {
            // Handle language setting here  
            // For now, redirecting to Index again  
            return RedirectToAction("SelectDestination");
        }
    }
}