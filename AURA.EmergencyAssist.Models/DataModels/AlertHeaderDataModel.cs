using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class AlertHeaderDataModel
    {
        public Guid AlertHeaderID { get; set; }
        public Guid SubscriberID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? RespondentID { get; set; }
        public string AlertOutcome { get; set; }

        public SubscriberDataModel SubscriberData { get; set; }
        public RespondentDataModel RespondentData { get; set; }
    }
}
