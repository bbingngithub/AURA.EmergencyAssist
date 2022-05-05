using AURA.EmergencyAssist.DAL.Interfaces;
using AURA.EmergencyAssist.DAL.Shared;
using AURA.EmergencyAssist.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace AURA.EmergencyAssist.DAL.Abstractions
{
    public abstract class CrossProviderDAL : IBaseDal
    {
        public ResponseModel responseModel;

        public CrossProviderDAL()
        {
            this.responseModel = new ResponseModel();
            this.responseModel.Data = null;
            this.responseModel.Message = "";
            this.responseModel.Success = false;
        }

        public abstract string ConnectionString { get; set; }
        public abstract string DBProviderName { get; set; }

        public abstract ResponseModel GetData(string storedProcedureName, List<DbParameter> dbParameters);

        public abstract ResponseModel SaveData(string storedProcedureName, List<DbParameter> dbParameters);
    }
}
