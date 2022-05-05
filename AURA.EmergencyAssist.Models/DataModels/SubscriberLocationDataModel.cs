using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class SubscriberLocationDataModel
    {
        public Guid SubscriberLocationID { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid SubscriberID { get; set; }

        public SubscriberDataModel SubscriberData { get; set; }
    }
}
