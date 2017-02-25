using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JSON_Payment_Portal.Models;


namespace FinancingAPI.Controllers
{
    public class DashboardController : Controller
    {
        private DB db = new DB();

        // GET: /Dashboard
        public ActionResult Index()
        {
            return RedirectToAction("ProjectOverview");
        }

        public ActionResult ProjectOverview()
        {
            return View();
        }

        public ActionResult ProjectInformation()
        {
            return View();
        }

        public ActionResult EditInformation()
        {
            return View();
        }

        public ActionResult ProjectSystem()
        {
            return View();
        }

        public ActionResult ProjectInstallation()
        {

            return View();
        }

        public ActionResult ProjectFinancing()
        {
            return View();
        }

        public ActionResult PaymentForm()
        {
            return View();
        }

        public ActionResult Approval()
        {
            return View();
        }

        public ActionResult ProjectPaymentPortal()
        {
            return View();
        }





        // GET: Dashboard/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            return View();
        }

        // GET: Dashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        // POST: Dashboard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        // GET: Dashboard/Delete/5
    }
}