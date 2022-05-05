using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class AlertDetailLocationDataModel
    {
        public Guid AlertDetailLocationID { get; set; }
        public Guid SubscriberLocationID { get; set; }
        public Guid? RespondentLocationID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid AlertDetailID { get; set; }

        public AlertDetailDataModel AlertDetailData { get; set; }
        public SubscriberLocationDataModel SubscriberLocationData { get; set; }
        public RespondentLocationDataModel RespondentLocationData { get; set; }
    }
}
