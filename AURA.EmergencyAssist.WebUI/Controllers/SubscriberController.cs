using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.WebUI.Controllers
{
    public class SubscriberController : Controller
    {
        // GET: SubscriberController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubscriberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubscriberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubscriberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubscriberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubscriberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubscriberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubscriberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
