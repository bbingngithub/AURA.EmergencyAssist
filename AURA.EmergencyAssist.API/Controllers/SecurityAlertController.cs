using AURA.EmergencyAssist.BLL.Implementations;
using AURA.EmergencyAssist.BLL.Interfaces;
using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.SignalRHub;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AURA.EmergencyAssist.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityAlertController : ControllerBase
    {

        private IHubContext<NotificationHub, IHubClient> notificationHub;
        public SecurityAlertController(IHubContext<NotificationHub, IHubClient> hubContext)
        {
            notificationHub = hubContext;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            notificationHub.Clients.All.InformClient(value);
        }
    }
}
