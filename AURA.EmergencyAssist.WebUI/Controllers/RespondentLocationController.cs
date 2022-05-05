using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.WebUI.Controllers
{
    public class RespondentLocationController : Controller
    {
        // GET: RespondentLocationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RespondentLocationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RespondentLocationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RespondentLocationController/Create
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

        // GET: RespondentLocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RespondentLocationController/Edit/5
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

        // GET: RespondentLocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RespondentLocationController/Delete/5
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
