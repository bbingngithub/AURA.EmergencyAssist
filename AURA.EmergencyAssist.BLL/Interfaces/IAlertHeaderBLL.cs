using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.BLL.Interfaces
{
    public interface IAlertHeaderBLL
    {
        public ResponseModel SaveNewAlert(NotificationModel notificationModel);
    }
}
