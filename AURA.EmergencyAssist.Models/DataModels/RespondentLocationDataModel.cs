using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class RespondentLocationDataModel
    {
        public Guid RespondentLocationID { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid RespondentID { get; set; }

        public RespondentDataModel RespondentData { get; set; }
    }
}
