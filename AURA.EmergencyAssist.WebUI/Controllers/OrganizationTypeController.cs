using AURA.EmergencyAssist.BLL.Interfaces;
using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.WebUI.Controllers
{
    public class OrganizationTypeController : Controller
    {
        IOrganizationTypeBLL organizationTypeBLL;
        ResponseModel responseModel;

        public OrganizationTypeController(IOrganizationTypeBLL organizationTypeBLL)
        {
            this.organizationTypeBLL = organizationTypeBLL;
        }


        public ActionResult Index()
        {
            responseModel = organizationTypeBLL.GetAllOrganizationTypes();
            
            return View(responseModel);
        }


        public ActionResult Details(Guid id)
        {
            return View(organizationTypeBLL.GetOrganizationTypeByID(id));
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            OrganizationTypeDataModel organizationTypeDataModel = (OrganizationTypeDataModel)collection;
            organizationTypeDataModel.OrganizationTypeID = Guid.NewGuid();
            responseModel = organizationTypeBLL.SaveOrganizationType(organizationTypeDataModel);

            if (responseModel.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(responseModel);
        }


        public ActionResult Edit(Guid id)
        {
            return View(organizationTypeBLL.GetOrganizationTypeByID(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IFormCollection collection)
        {
            OrganizationTypeDataModel organizationTypeDataModel = (OrganizationTypeDataModel)collection;
            responseModel = organizationTypeBLL.SaveOrganizationType(organizationTypeDataModel);

            if (responseModel.Success)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: OrganizationTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrganizationTypeController/Delete/5
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
