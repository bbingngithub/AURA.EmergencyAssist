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
    public class AlertHeaderMapper
    {
        public ResponseModel MapDataSetToDataModel(ResponseModel responseModel)
        {
            try
            {
                if (responseModel.Data != null)
                {
                    DataSet dataSet = (DataSet)responseModel.Data;

                    if (dataSet.Tables != null)
                    {
                        DataRow row = dataSet.Tables[0].Rows[0];

                        AlertHeaderDataModel alertHeaderData = new AlertHeaderDataModel();
                        alertHeaderData.RespondentData = new RespondentDataModel();
                        alertHeaderData.RespondentData.OrganizationData = new OrganizationDataModel();
                        alertHeaderData.RespondentData.OrganizationData.AddressData = new AddressDataModel();
                        alertHeaderData.RespondentData.respondentTypeData = new RespondentTypeDataModel();
                        alertHeaderData.RespondentData.VehicleData = new VehicleDataModel();
                        alertHeaderData.SubscriberData = new SubscriberDataModel();
                        alertHeaderData.SubscriberData.AddressData = new AddressDataModel();

                        responseModel.Data = alertHeaderData;
                        responseModel.Success = true;
                        responseModel.Message = $"";
                    }
                }
                else
                {
                    responseModel.Data = null;
                    responseModel.Success = false;
                    responseModel.Message = "There is no Alert Info data to Map.";
                }
            }
            catch (Exception ex)
            {
                responseModel.Data = null;
                responseModel.Success = false;
                responseModel.Message = $"Critical error when mapping Alert Data : {ex.Message}";
            }
            return responseModel;
        }
    }
}
