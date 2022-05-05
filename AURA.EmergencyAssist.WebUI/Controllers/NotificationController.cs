using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AURA.EmergencyAssist.SignalRHub;
using Microsoft.AspNetCore.SignalR;
using AURA.EmergencyAssist.Models.SignalR;
using AURA.EmergencyAssist.BLL.Interfaces;
using AURA.EmergencyAssist.Models;

namespace AURA.EmergencyAssist.WebUI.Controllers
{
    public class NotificationController : Controller
    {

        IAlertHeaderBLL alertHeaderBLL;
        INotificationHandler notificationHandler;


        public NotificationController(IAlertHeaderBLL alertHeaderBLL, INotificationHandler notificationHandler)
        {

            this.alertHeaderBLL = alertHeaderBLL;
            this.notificationHandler = notificationHandler;
        }

        // GET: NotificationController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(NotificationModel model)
        {
            ResponseModel response = alertHeaderBLL.SaveNewAlert(model);

            notificationHandler.NotifyUsers(model);

            return View();
        }

        public IActionResult SendToSpecificUser()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SendToSpecificUser(NotificationModel model)
        {

            notificationHandler.NotifySpecificUsers(model);

            return View();
        }
    }
}
