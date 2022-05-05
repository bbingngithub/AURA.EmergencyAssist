using AURA.EmergencyAssist.Models;
using AURA.EmergencyAssist.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA.EmergencyAssist.DAL.Mappers
{
    public class OrganizationalTypeMapper
    {
        public ResponseModel MapDataSetToDataModelList(ResponseModel responseModel)
        {
            try
            {
                if (responseModel.Data != null)
                {
                    DataSet dataSet = (DataSet)responseModel.Data;

                    if (dataSet.Tables != null)
                    {
                        List<OrganizationTypeDataModel> organizationTypes = new List<OrganizationTypeDataModel>();

                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            OrganizationTypeDataModel organizationTypeDataModel = new OrganizationTypeDataModel();

                            organizationTypeDataModel.OrganizationTypeID = Guid.Parse(row["OrganizationTypeID"].ToString());
                            organizationTypeDataModel.OrganizationTypeName = row["OrganizationTypeName"].ToString();

                            organizationTypes.Add(organizationTypeDataModel);

                            responseModel.Data = organizationTypes;
                            responseModel.Success = true;
                            responseModel.Message = $"Record count : {organizationTypes.Count}";
                        }
                    }
                }
                else
                {
                    responseModel.Data = null;
                    responseModel.Success = false;
                    responseModel.Message = "There is no Organization Type data to Map.";
                }
            }
            catch (Exception ex)
            {
                responseModel.Data = null;
                responseModel.Success = false;
                responseModel.Message = $"Critical error when mapping Organization Type : {ex.Message}";
            }
            return responseModel;
        }
    }
}
