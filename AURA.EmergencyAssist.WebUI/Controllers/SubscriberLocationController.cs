using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.WebUI.Controllers
{
    public class SubscriberLocationController : Controller
    {
        // GET: SubscriberLocationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubscriberLocationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubscriberLocationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubscriberLocationController/Create
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

        // GET: SubscriberLocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubscriberLocationController/Edit/5
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

        // GET: SubscriberLocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubscriberLocationController/Delete/5
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
