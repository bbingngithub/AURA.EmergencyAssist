using AURA.EmergencyAssist.BLL.Interfaces;
using AURA.EmergencyAssist.DAL.Interfaces;
using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.BLL.Implementations
{
    public class AlertHeaderBLL: IAlertHeaderBLL
    {
        IAlertHeaderDAL alertHeaderDAL;
        public AlertHeaderBLL(IAlertHeaderDAL alertHeaderDAL)
        {
            this.alertHeaderDAL = alertHeaderDAL;
        }

        public ResponseModel SaveNewAlert(NotificationModel notificationModel)
        {
            //save new alert header
            //pass alert to respondent finder
            //update alert details
            //pass alert to async alert tracker

            return new ResponseModel();
        }
    }
}
