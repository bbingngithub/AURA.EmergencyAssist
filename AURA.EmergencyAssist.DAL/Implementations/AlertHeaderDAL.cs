using AURA.EmergencyAssist.DAL.Interfaces;
using AURA.EmergencyAssist.DAL.Mappers;
using AURA.EmergencyAssist.DAL.Shared;
using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.DAL.Implementations
{
    public class AlertHeaderDAL : MSSQLDAL, IAlertHeaderDAL
    {
        AlertHeaderMapper mapper;
        public AlertHeaderDAL() : base(DBSettings.SQLServerConnectionStringAPI)
        {
            mapper = new AlertHeaderMapper();
        }

        public ResponseModel SaveNewAlert(NotificationModel notificationModel)
        {
            return responseModel;
        }
    }
}
