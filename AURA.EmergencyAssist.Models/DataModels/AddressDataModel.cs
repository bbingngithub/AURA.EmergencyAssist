using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class AddressDataModel
    {
        public Guid AddressID { get; set; }
        public string PostalCode { get; set; }
        public string SuburbName { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
    }
}
