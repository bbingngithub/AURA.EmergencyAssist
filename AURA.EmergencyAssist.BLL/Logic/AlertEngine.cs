using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.DataModels;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.BLL.Logic
{
    public class AlertEngine
    {
        private ConcurrentQueue<MessageModel> messageQueue = new ConcurrentQueue<MessageModel>();

        public ResponseModel ProcessAlert(List<AlertDetailDataModel> alertDetails)
        {
            ResponseModel responseModel = new ResponseModel();



            return responseModel;
        }

        //private ResponseModel GenerateUpdateMessages(List<AlertDetailDataModel> alertDetails)
        //{

        //}

        //private ResponseModel AddUpDateMessagesToQueue(List<MessageModel> messages)
        //{

        //}
        
        //private ResponseModel SendMessages()
        //{

        //}

    }
}
