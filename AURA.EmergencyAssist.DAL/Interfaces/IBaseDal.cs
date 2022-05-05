using AURA.EmergencyAssist.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace AURA.EmergencyAssist.DAL.Interfaces
{
    public interface IBaseDal
    {
        public string ConnectionString { get; set; }
        public string DBProviderName { get; set; }
        public ResponseModel GetData(string storedProcedureName, List<DbParameter> dbParameters);
        public ResponseModel SaveData(string storedProcedureName, List<DbParameter> dbParameters);
    }
}
