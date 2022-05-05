using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class OrganizationDataModel
    {
        public Guid OrganizationID { get; set; }
        public string Name { get; set; }
        public Guid OrganizationTypeID { get; set; }
        public Guid AddressID { get; set; }

        public AddressDataModel AddressData { get; set; }
        public OrganizationTypeDataModel  OrganizationType { get; set; }
    }
}
