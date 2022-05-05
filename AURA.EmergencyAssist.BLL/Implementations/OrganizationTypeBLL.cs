using AURA.EmergencyAssist.BLL.Interfaces;
using AURA.EmergencyAssist.DAL.Interfaces;
using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.BLL.Implementations
{
    public class OrganizationTypeBLL : IOrganizationTypeBLL
    {
        IOrganizationTypeDAL organizationTypeDAL;
        public OrganizationTypeBLL(IOrganizationTypeDAL organizationTypeDAL)
        {
            this.organizationTypeDAL = organizationTypeDAL;
        }
        public ResponseModel GetAllOrganizationTypes()
        {
            return organizationTypeDAL.GetAllOrganizationTypes();
        }

        public ResponseModel GetOrganizationTypeByID(Guid orginizationalTypeID)
        {
            return organizationTypeDAL.GetOrganizationTypeByID(orginizationalTypeID);
        }

        public ResponseModel SaveOrganizationType(OrganizationTypeDataModel organizationTypeDataModel)
        {
            return organizationTypeDAL.SaveOrganizationType(organizationTypeDataModel);
        }
    }
}
