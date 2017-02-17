using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace FinancingAPI.Controllers
{
    public class DashboardController : Controller
    {


        // GET: Dashboard
        public ActionResult Index()
        {
            return RedirectToAction("");
        }

        public ActionResult ProjectOverview()
        {
            return View();
        }

        public ActionResult ProjectFinancing()
        {
            return View();
        }

        public ActionResult ProjectSite()
        {
            return View();
        }

        public ActionResult ProjectInstallation()
        {

            return View();
        }

        public ActionResult ProjectDocuments()
        {
            return View();
        }

        public ActionResult ProjectExperience()
        {
            return View();
        }

        public ActionResult ProjectMonitoring()
        {
            return View();
        }

        public ActionResult ProjectPayment()
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