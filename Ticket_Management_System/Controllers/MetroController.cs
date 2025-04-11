using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket_Management_System.Models;
using System.Data.Entity;


namespace Ticket_Management_System.Controllers
{
    public class MetroController : Controller
    {
        // GET: Metro  
        private ticket_management_systemEntities1 db = new ticket_management_systemEntities1();

        public ActionResult Momo()
        {
            if (Session["HasStarted"] == null)
            {
                // Redirect to the Index page if the session is missing
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult Card()
        {
            if (Session["HasStarted"] == null)
            {
                // Redirect to the Index page if the session is missing
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult ShowTickets()
        {
            if (Session["HasStarted"] == null)
            {
                // Redirect to the Index page if the session is missing
                return RedirectToAction("Index", "Home");
            }

            // Use Eager Loading to include the DESTINATION entity
            var tickets = db.vw_TicketDetails.ToList();

            return View(tickets);
        }

        [HttpGet]
        public ActionResult Register(string from, int to, decimal? ticketCost)
        {
            if (Session["HasStarted"] == null)
            {
                // Redirect to the Index page if the session is missing
                return RedirectToAction("Index", "Home");
            }
            if (string.IsNullOrEmpty(from) || ticketCost == null)
            {
                return RedirectToAction("Details", "Home");
            }

            // Use the values as needed
            // Create a new ticket
            TICKET newTicket = new TICKET
            {
                TID = 1,
                FROM = from,
                DID = to, // Assuming 'to' matches a destination ID
                COST = ticketCost,
                TIME = DateTime.Now,
                STATUS = true // Assuming 'false' means unpaid or unconfirmed
            };

            // Add the ticket to the database
            db.TICKETS.Add(newTicket);
            db.SaveChanges();
            return View();
        }


        [HttpGet]
        public JsonResult Search(string term)
        {
            if (string.IsNullOrEmpty(term))
            {
                return Json(new List<object>(), JsonRequestBehavior.AllowGet);
            }

            var results = db.DESTINATIONS
                           .Select(d => new { id = d.DID, name = d.NAME }) // Fetch data without filtering
                           .ToList() // Bring data into memory
                           .Where(d => d.name.ToLower().Contains(term.ToLower())) // Apply filtering in memory
                           .Take(10)
                           .ToList();

            return Json(results, JsonRequestBehavior.AllowGet);
        }

    }
}