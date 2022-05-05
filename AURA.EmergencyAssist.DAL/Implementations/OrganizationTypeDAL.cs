using AURA.EmergencyAssist.DAL.Abstractions;
using AURA.EmergencyAssist.DAL.Interfaces;
using AURA.EmergencyAssist.DAL.Mappers;
using AURA.EmergencyAssist.DAL.Shared;
using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.DAL.Implementations
{
    public class OrganizationTypeDAL : MSSQLDAL, IOrganizationTypeDAL
    {
        OrganizationalTypeMapper mapper;
        public OrganizationTypeDAL() : base(DBSettings.SQLServerConnectionStringWebUI)
        {
            mapper = new OrganizationalTypeMapper();
        }

        public ResponseModel GetAllOrganizationTypes()
        {
            responseModel = GetData("GetAllOrganizationTypes", null);

            if (responseModel.Success)
            {
                responseModel = mapper.MapDataSetToDataModelList(responseModel);
            }

            return responseModel;
        }

        public ResponseModel GetOrganizationTypeByID(Guid orginizationalTypeID)
        {

            List<DbParameter> parameters = new List<DbParameter>();
            parameters.Add(new SqlParameter("@OrganationTypeID", orginizationalTypeID));

            responseModel = GetData("GetOrganizationTypeByID", parameters);


            if (responseModel.Success)
            {
                responseModel = mapper.MapDataSetToDataModelList(responseModel);
            }

            return responseModel;
        }

        public ResponseModel SaveOrganizationType(OrganizationTypeDataModel organizationTypeDataModel)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            parameters.Add(new SqlParameter("@OrganationTypeID", organizationTypeDataModel.OrganizationTypeID));
            parameters.Add(new SqlParameter("@OrganizationTypeName", organizationTypeDataModel.OrganizationTypeName));

            responseModel = GetData("SaveOrganizationType", parameters);


            if (responseModel.Success)
            {
                responseModel = mapper.MapDataSetToDataModelList(responseModel);
            }

            return responseModel;
        }
    }
}
