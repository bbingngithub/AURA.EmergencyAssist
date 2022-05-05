using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.DataModels;
using System;

namespace AURA.EmergencyAssist.BLL.Interfaces
{
    public interface IOrganizationTypeBLL
    {
        ResponseModel SaveOrganizationType(OrganizationTypeDataModel organizationTypeDataModel);
        ResponseModel GetAllOrganizationTypes();
        ResponseModel GetOrganizationTypeByID(Guid orginizationalTypeID);
    }
}
