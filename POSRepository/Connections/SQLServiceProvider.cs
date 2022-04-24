using POSModel.Common;
using POSRepository.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace POSRepository.Connections
{
    internal class SQLServiceProvider : IRepositoryProvider
    {
        private static IDbConnection _Connection;
        public object _obj = new object();

        public SQLServiceProvider()
        {
            string connection = ConfigurationHelper.DataConnectionString;
            //@"Data Source=PKKHICS06L1081\SQLEXPRESS;initial catalog=new_db;user id=sa;Password=abc1234"
            _Connection = new SqlConnection(connection);
        }

        
        public DataSet GetDataSet(IDbCommand pCmd)
        {
            DataSet ds = new DataSet();
            try
            {
                if (_Connection.State != ConnectionState.Open)
                {
                    _Connection.Open();
                }

                SqlDataAdapter objAdapter = new SqlDataAdapter((SqlCommand)pCmd);
                objAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                //Log Exception
                throw ex;
            }
            finally
            {
                if (pCmd.Connection.State == ConnectionState.Open && pCmd.Transaction == null)
                {
                    _Connection.Close();
                }
            }
            return ds;
        }

        public DataSet GetDataSet(string commandText, CommandType commandType, List<Parameter> dbParameters)
        {
            DataSet ds = new DataSet();
            try
            {


                using (SqlCommand dbCommand = CreateDBCommand(commandText, commandType, dbParameters))
                {

                    if (dbCommand.Connection.State != ConnectionState.Open)
                    {
                        dbCommand.Connection.Open();
                    }

                    SqlDataAdapter objAdapter = new SqlDataAdapter(dbCommand);
                    objAdapter.Fill(ds);




                }
            }
            catch (Exception ex)
            {
                //Log Exception
                throw ex;
            }
            finally
            {
                _Connection.Close();
            }
            return ds;
        }

        public object ExecuteScalar(IDbCommand pCmd)
        {
            object result = null;
            try
            {
                if (pCmd.Connection.State != ConnectionState.Open)
                {
                    pCmd.Connection.Open();
                }

                result = pCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //Log Exception
                throw ex;
            }
            finally
            {
                if (pCmd.Connection.State == ConnectionState.Open && pCmd.Transaction == null)
                {
                    pCmd.Connection.Close();
                }
            }
            return result;
        }

        public object ExecuteScalar(string commandText, CommandType commandType, List<Parameter> dbParameters)
        {
            object result = null;
            try
            {
                using (SqlCommand dbCommand = CreateDBCommand(commandText, commandType, dbParameters))
                {
                    if (dbCommand.Connection.State != ConnectionState.Open)
                    {
                        dbCommand.Connection.Open();
                    }

                    result = dbCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                //Log Exception
                throw ex;
            }
            finally
            {
                _Connection.Close();
            }
            return result;
        }

        public int ExecuteNonQuery(IDbCommand pCmd)
        {
            int _rowsAffected = 0;
            try
            {
                if (pCmd.Connection.State != ConnectionState.Open)
                {
                    pCmd.Connection.Open();
                }

                _rowsAffected = pCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Log Exception
                throw ex;
            }
            finally
            {
                if (pCmd.Connection.State == ConnectionState.Open && pCmd.Transaction == null)
                {
                    pCmd.Connection.Close();
                }
            }
            return _rowsAffected;
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, List<Parameter> dbParameters)
        {
            int _rowsAffected = 0;
            try
            {
                using (SqlCommand dbCommand = CreateDBCommand(commandText, commandType, dbParameters))
                {
                    if (dbCommand.Connection.State != ConnectionState.Open)
                    {
                        dbCommand.Connection.Open();
                    }

                    _rowsAffected = dbCommand.ExecuteNonQuery();

                    //Map Values Back To Parameters
                    MapOutParameterValue(dbParameters, dbCommand);
                }
            }
            catch (Exception ex)
            {
                //Log Exception
                throw ex;
            }
            finally
            {
                _Connection.Close();
            }
            return _rowsAffected;
        }

        private void MapOutParameterValue(List<Parameter> dbParameters, SqlCommand command)
        {
            foreach (Parameter item in dbParameters.Where(x => x.ParameterDirection == ParameterDirection.Output))
            {
                SqlParameter _param = command.Parameters[item.ParameterName];
                item.Value = _param.Value;
            }
        }

        private SqlCommand CreateDBCommand(string commandText, CommandType commandType, List<Parameter> dbParameters)
        {
            SqlCommand cmd = (SqlCommand)_Connection.CreateCommand(); 
            cmd.CommandText = commandText;
            cmd.CommandType = commandType;

            foreach (Parameter _param in dbParameters)
            {
                SqlParameter _p = cmd.CreateParameter();

                //Get Param Type
                //if (typeMapOracle.TryGetValue(_param.DbType, out var OracleDbTypeParam))
                //{
                //    _p.OracleDbType = OracleDbTypeParam;
                //}

                _p.ParameterName = _param.ParameterName;
                _p.Value = _param.Value;
                _p.Direction = _param.ParameterDirection;

                cmd.Parameters.Add(_p);
            }
            return cmd;
        }

        //public static Dictionary<Type, SqlDbType> typeMapSQLServer =
        //    new Dictionary<Type, SqlDbType>()
        //{
        //    { typeof(byte), SqlDbType.TinyInt}, { typeof(sbyte), SqlDbType.TinyInt },
        //    { typeof(short), SqlDbType.SmallInt}, { typeof(ushort), SqlDbType.SmallInt },
        //    { typeof(int), SqlDbType.Int }, {typeof(uint), SqlDbType.Int },
        //    { typeof(long), SqlDbType.BigInt },   {typeof(ulong), SqlDbType.BigInt },
        //    { typeof(float), SqlDbType.Float }, { typeof(double), SqlDbType.Float },
        //    { typeof(decimal), SqlDbType.Decimal }, {typeof(bool),  SqlDbType.Bit },
        //    { typeof(string), SqlDbType.VarChar },  {typeof(char), SqlDbType.Char },
        //    { typeof(Guid),  SqlDbType.UniqueIdentifier }, { typeof(DateTime), SqlDbType.DateTime},
        //    { typeof(DateTimeOffset), SqlDbType.DateTimeOffset }, { typeof(byte[]), SqlDbType.VarBinary },
        //    //Nullable fields
        //    { typeof(byte?), SqlDbType.TinyInt }, { typeof(sbyte?), SqlDbType.TinyInt },
        //    { typeof(short?), SqlDbType.SmallInt}, { typeof(ushort?), SqlDbType.SmallInt },
        //    { typeof(int?), SqlDbType.Int }, { typeof(uint?), SqlDbType.Int },
        //    { typeof(long?), SqlDbType.BigInt }, { typeof(ulong?), SqlDbType.BigInt },
        //    { typeof(float?), SqlDbType.Float }, { typeof(double?), SqlDbType.Float },
        //    { typeof(decimal?), SqlDbType.Decimal}, { typeof(bool?), SqlDbType.Bit },
        //    { typeof(Guid?), SqlDbType.UniqueIdentifier}, { typeof(DateTime?), SqlDbType.DateTime },
        //    { typeof(DateTimeOffset?), SqlDbType.DateTimeOffset }
        //};

        //public static Dictionary<ParameterDbType, OracleDbType> typeMapOracle =
        //    new Dictionary<ParameterDbType, OracleDbType>()
        //{

        //        { ParameterDbType.AnsiString            , OracleDbType.Varchar2 },
        //        { ParameterDbType.Binary                , OracleDbType.Raw },
        //        //{ ParameterDbType.Byte                  = 2,
        //        //{ ParameterDbType.Boolean               = 3,
        //        //{ ParameterDbType.Currency              , (OracleDbType)DbType.Currency }, //Not Found in Oracle
        //        //{ ParameterDbType.Date                  = 5,
        //        { ParameterDbType.DateTime              , OracleDbType.TimeStamp },
        //        //{ ParameterDbType.Decimal               = 7,
        //        //{ ParameterDbType.Double                = 8,
        //        //{ ParameterDbType.Guid                  , OracleDbType.BinaryFloat }, //Not Found in Oracle
        //        //{ ParameterDbType.Int16                 = 10,
        //        //{ ParameterDbType.Int32                 = 11,
        //        //{ ParameterDbType.Int64                 = 12,
        //        //{ ParameterDbType.Object                , (OracleDbType)DbType.Object }, //Not Found in Oracle
        //        //{ ParameterDbType.SByte                 , (OracleDbType)DbType.SByte }, //Not Found in Oracle
        //        //{ ParameterDbType.Single                = 15,
        //        { ParameterDbType.String                , OracleDbType.Varchar2 },
        //        { ParameterDbType.Time                  , OracleDbType.TimeStamp },
        //        //{ ParameterDbType.UInt16                , (OracleDbType)DbType.UInt16 }, //Not Found in Oracle
        //        //{ ParameterDbType.UInt32                , (OracleDbType)DbType.UInt32 }, //Not Found in Oracle
        //        //{ ParameterDbType.UInt64                , (OracleDbType)DbType.UInt64 }, //Not Found in Oracle
        //        //{ ParameterDbType.VarNumeric            , (OracleDbType)DbType.VarNumeric }, //Not Found in Oracle
        //        { ParameterDbType.AnsiStringFixedLength , OracleDbType.Char },
        //        { ParameterDbType.StringFixedLength     , OracleDbType.Char },
        //        //{ ParameterDbType.Xml                   , (OracleDbType)DbType.Xml }, //Not Found in Oracle
        //        //{ ParameterDbType.DateTime2             , (OracleDbType)DbType.DateTime2 }, //Not Found in Oracle
        //        //{ ParameterDbType.DateTimeOffset        , (OracleDbType)DbType.DateTimeOffset }, //Not Found in Oracle



        //        { ParameterDbType.BFile              , OracleDbType.BFile }       ,
        //        { ParameterDbType.Blob               , OracleDbType.Blob         },
        //        { ParameterDbType.Byte               , OracleDbType.Byte         },
        //        { ParameterDbType.Char               , OracleDbType.Char         },
        //        { ParameterDbType.Clob               , OracleDbType.Clob         },
        //        { ParameterDbType.Date               , OracleDbType.Date         },
        //        { ParameterDbType.Decimal            , OracleDbType.Decimal      },
        //        { ParameterDbType.Double             , OracleDbType.Double       },
        //        { ParameterDbType.Long               , OracleDbType.Long         },
        //        { ParameterDbType.LongRaw            , OracleDbType.LongRaw      },
        //        { ParameterDbType.Int16              , OracleDbType.Int16        },
        //        { ParameterDbType.Int32              , OracleDbType.Int32        },
        //        { ParameterDbType.Int64              , OracleDbType.Int64        },
        //        { ParameterDbType.IntervalDS         , OracleDbType.IntervalDS   },
        //        { ParameterDbType.IntervalYM         , OracleDbType.IntervalYM   },
        //        { ParameterDbType.NClob              , OracleDbType.NClob        },
        //        { ParameterDbType.NChar              , OracleDbType.NChar        },
        //        { ParameterDbType.NVarchar2          , OracleDbType.NVarchar2    },
        //        { ParameterDbType.Raw                , OracleDbType.Raw          },
        //        { ParameterDbType.RefCursor          , OracleDbType.RefCursor    },
        //        { ParameterDbType.Single             , OracleDbType.Single       },
        //        { ParameterDbType.TimeStamp          , OracleDbType.TimeStamp    },
        //        { ParameterDbType.TimeStampLTZ       , OracleDbType.TimeStampLTZ },
        //        { ParameterDbType.TimeStampTZ        , OracleDbType.TimeStampTZ  },
        //        { ParameterDbType.Varchar2           , OracleDbType.Varchar2     },
        //        { ParameterDbType.XmlType            , OracleDbType.XmlType      },
        //        { ParameterDbType.BinaryDouble       , OracleDbType.BinaryDouble },
        //        { ParameterDbType.BinaryFloat        , OracleDbType.BinaryFloat  },
        //        { ParameterDbType.Boolean            , OracleDbType.Boolean      }
        //};
    }
}
