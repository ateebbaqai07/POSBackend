using POSRepository.Common;
using System.Collections.Generic;
using System.Data;

namespace POSRepository.Connections
{
    public interface IRepositoryProvider
    {
       
        DataSet GetDataSet(IDbCommand pCmd);
        DataSet GetDataSet(string commandText, CommandType commandType, List<Parameter> dbParameters);
        object ExecuteScalar(IDbCommand pCmd);
        object ExecuteScalar(string commandText, CommandType commandType, List<Parameter> dbParameters);
        int ExecuteNonQuery(IDbCommand pCmd);
        int ExecuteNonQuery(string commandText, CommandType commandType, List<Parameter> dbParameters);
    }
}
