using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.Models.DataModels
{
    public class RespondentDataModel
    {
        public Guid RespondentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmployeeCode { get; set; }
        public Guid RespondentTypeID { get; set; }
        public Guid VehicleID { get; set; }
        public Guid OrganizationID { get; set; }

        public RespondentTypeDataModel respondentTypeData { get; set; }
        public VehicleDataModel VehicleData { get; set; }
        public OrganizationDataModel OrganizationData { get; set; }
    }
}
