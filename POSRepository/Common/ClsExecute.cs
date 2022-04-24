using POSRepository.Connections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tracer;

namespace POSRepository.Common
{
    public class ClsExecute
    {
        private IRepositoryProvider _provider;// = new RepositoryFactory().GetRepositoryProvider();

        public ClsExecute()
        {
            _provider = new RepositoryFactory().GetRepositoryProvider();
        }

   

        public DataSet GetDataSet(IDbCommand pCmd)
        {
            try
            {
                AuditTrace.Database(pCmd.CommandText, pCmd.CommandType, pCmd.Parameters);
                return _provider.GetDataSet(pCmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetDataSet(string commandText, CommandType commandType, List<Parameter> dbParameters)
        {
            try
            {
                List<string> paramList = new List<string>();
                foreach (var param in dbParameters)
                {
                    paramList.Add($"{param.ParameterName} = {param.Value}");
                }
                AuditTrace.Database(commandText, commandType, string.Join(", ", paramList));
                return _provider.GetDataSet(commandText, commandType, dbParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ExecuteScalar(IDbCommand pCmd)
        {
            try
            {
                AuditTrace.Database(pCmd.CommandText, pCmd.CommandType, pCmd.Parameters);
                return _provider.ExecuteScalar(pCmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ExecuteScalar(string commandText, CommandType commandType, List<Parameter> dbParameters)
        {
            try
            {
                List<string> paramList = new List<string>();
                foreach (var param in dbParameters)
                {
                    paramList.Add($"{param.ParameterName} = {param.Value}");
                }
                AuditTrace.Database(commandText, commandType, string.Join(", ", paramList));
                return _provider.ExecuteScalar(commandText, commandType, dbParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteNonQuery(IDbCommand pCmd)
        {
            try
            {
                AuditTrace.Database(pCmd.CommandText, pCmd.CommandType, pCmd.Parameters);
                return _provider.ExecuteNonQuery(pCmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, List<Parameter> dbParameters)
        {
            try
            {
                List<string> paramList = new List<string>();
                foreach (var param in dbParameters)
                {
                    paramList.Add($"{param.ParameterName} = {param.Value}");
                }
                AuditTrace.Database(commandText, commandType, string.Join(", ", paramList));
                return _provider.ExecuteNonQuery(commandText, commandType, dbParameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
