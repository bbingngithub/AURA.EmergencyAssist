using AURA.EmergencyAssist.DAL.Abstractions;
using AURA.EmergencyAssist.DAL.Shared;
using AURA.EmergencyAssist.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace AURA.EmergencyAssist.DAL.Implementations
{
    public class MSSQLDAL : CrossProviderDAL
    {
        public override string ConnectionString { get; set; }
        public override string DBProviderName { get; set; }

        public MSSQLDAL(string connectionString)
        {
            ConnectionString = connectionString;
            DBProviderName = "System.Data.SqlClient";
        }

        public override ResponseModel GetData(string storedProcedureName, List<DbParameter> dbParameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlCommand command = SetCommand(storedProcedureName, dbParameters, connection);

                    DataSet ds = new DataSet();

                    connection.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(ds);

                    responseModel.Data = ds;
                    responseModel.Success = true;
                }
                catch (Exception ex)
                {
                    responseModel.Message = $"Critical SQL Error : {ex.Message}";
                }
                finally
                {
                    connection.Close();
                }
            }

            return responseModel;
        }

        public override ResponseModel SaveData(string storedProcedureName, List<DbParameter> dbParameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlCommand command = SetCommand(storedProcedureName, dbParameters, connection);

                    connection.Open();
                    int rowCount = command.ExecuteNonQuery();

                    responseModel.Success = true;
                    responseModel.Data = rowCount;
                }
                catch (Exception ex)
                {
                    responseModel.Message = $"Data Saving Failure : {ex.Message}";
                }
                finally
                {
                    connection.Close();
                }

            }

            return responseModel;
        }

        private SqlCommand SetCommand(string storedProcedureName, List<DbParameter> dbParameters, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(storedProcedureName, connection);

            if (dbParameters != null)
            {
                foreach (DbParameter dbParameter in dbParameters)
                {
                    command.Parameters.AddWithValue($"@{dbParameter.ParameterName}", dbParameter.Value);
                }
            }

            return command;
        }
    }
}
