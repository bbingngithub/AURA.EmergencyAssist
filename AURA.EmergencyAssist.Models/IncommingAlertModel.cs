using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models
{
    public class IncommingAlertModel
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Guid SubscriberID { get; set; }
    }
}
