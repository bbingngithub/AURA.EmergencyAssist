using AURA.EmergencyAssist.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models
{
    public class MessageModel
    {
        public RespondentLocationDataModel RespondentLocationData { get; set; }
        public SubscriberLocationDataModel SubscriberLocationData { get; set; }
        public AlertStatusDataModel AlertStatusData { get; set; }
        public TimeSpan ApproximateArrivalTime { get; set; }
    }
}
