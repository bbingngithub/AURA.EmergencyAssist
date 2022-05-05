using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class SubscriberDataModel
    {
        public Guid SubscriberID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string ContactNumber { get; set; }
        public Guid AddressID { get; set; }
        public Guid OrganizationID { get; set; }

        public AddressDataModel AddressData { get; set; }
        public OrganizationDataModel OrganizationData { get; set; }
    }
}
