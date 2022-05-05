using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.SignalR
{
    public class NotificationModel
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Guid SubscriberID { get; set; }
    }
}
