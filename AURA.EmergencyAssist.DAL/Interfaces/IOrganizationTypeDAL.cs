using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.DataModels;
using System;

namespace AURA.EmergencyAssist.DAL.Interfaces
{
    public interface IOrganizationTypeDAL
    {
        ResponseModel SaveOrganizationType(OrganizationTypeDataModel organizationTypeDataModel);
        ResponseModel GetAllOrganizationTypes();
        ResponseModel GetOrganizationTypeByID(Guid orginizationalTypeID);
    }
}
