using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class KnownMedicalDataModel
    {
        public Guid KnownMedicalID { get; set; }
        public string Name { get; set; }
        public Guid SubscriberID { get; set; }

        public SubscriberDataModel SubscriberData { get; set; }
    }
}
