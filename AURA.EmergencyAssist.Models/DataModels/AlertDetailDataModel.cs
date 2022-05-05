using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class AlertDetailDataModel
    {
        public Guid AlertDetailID { get; set; }
        public Guid AlertHeaderID { get; set; }
        public Guid AlertStatusID { get; set; }
        public DateTime CreatedDate { get; set; }

        public AlertHeaderDataModel AlertHeaderData { get; set; }
        public AlertStatusDataModel AlertStatusData { get; set; }
    }
}
