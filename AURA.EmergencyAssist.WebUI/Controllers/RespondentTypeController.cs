using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.WebUI.Controllers
{
    public class RespondentTypeController : Controller
    {
        // GET: RespondentTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RespondentTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RespondentTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RespondentTypeController/Create
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

        // GET: RespondentTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RespondentTypeController/Edit/5
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

        // GET: RespondentTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RespondentTypeController/Delete/5
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
