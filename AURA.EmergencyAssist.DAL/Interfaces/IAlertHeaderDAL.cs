using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.DAL.Interfaces
{
    public interface IAlertHeaderDAL
    {
        ResponseModel SaveNewAlert(NotificationModel notificationModel);
    }
}
