using POSRepository.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Tracer;

namespace POSRepository.Common
{
    public class TraceLogger : ITraceLogger
    {
        public class TraceType
        {
            public const string INFORMATION = "INFORMATION";
            public const string EXCEPTION = "EXCEPTION";
        }

        public void Notify(params object[] args)
        {
            AuditTrace.Notify(args);
        }

        public void Exception(params object[] args)
        {
            AuditTrace.Exception(args);
            LogInDB(TraceType.EXCEPTION, null, null, args);
        }

        public void Exception(Exception ex, params object[] args)
        {
            AuditTrace.Exception(ex, args);
            LogInDB(TraceType.EXCEPTION, null, ex, args);
        }

        public void MOBException(string pUniqueId, params object[] args)
        {
            AuditTrace.Exception(args);
            LogInDB(TraceType.EXCEPTION, pUniqueId, null, args);
        }

        public void ThrowException(string pMessage)
        {
            Exception ex = new Exception(pMessage);
            ex.Data.Add("ErrorCode", "0538");
            throw ex;
        }

        private void LogInDB(string pTraceType, string pUniqueId, Exception pException, params object[] args)
        {
            try
            {
                StringBuilder paramEntries = new StringBuilder();
                StringBuilder paramEntriesException = new StringBuilder();
                if (args != null)
                    foreach (object i in args)
                        if (i != null)
                            paramEntries.Append(i + "\t");

                if (pException != null)
                {
                    paramEntriesException.AppendFormat("Exception: | {0} ", pException.Message);
                    paramEntriesException.AppendFormat("StackTrace: | {0} ", pException.StackTrace);

                    Exception Inner = pException.InnerException;
                    while (Inner != null)
                    {
                        paramEntriesException.AppendFormat("InnerException: | {0} ", Inner.Message);
                        paramEntriesException.AppendFormat("InnerStackTrace: | {0} ", Inner.StackTrace);

                        Inner = Inner.InnerException;
                    }
                }

                //DBLogger.Log(pTraceType, pUniqueId, GetServerIP(), GetAssemblyVersion(), GetLastModifiedDate(), SafeConvert.ToString(paramEntries), SafeConvert.ToString(paramEntriesException), args);

            }
            catch (Exception ex)
            {
                AuditTrace.Exception(ex, "AuditTraceMOB", "LogInDB");
            }
        }

        private string GetServerIP()
        {
            try
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress localIP = host.AddressList.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                return localIP.ToString();
            }
            catch (Exception ex)
            {
                Exception(ex, "TraceLogger", "GetServerIP");
                return "-";
            }
        }

        //private string GetAssemblyVersion()
        //{
        //    try
        //    {
        //        string appVersion = (string)CacheManager.GetCache(Constants.Cache.SERVER_ASSEMBLY_VERSION);
        //        if (string.IsNullOrWhiteSpace(appVersion))
        //        {
        //            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        //            appVersion = SafeConvert.ToString(assembly.GetName().Version);
        //            CacheManager.SetCache(Constants.Cache.SERVER_ASSEMBLY_VERSION, appVersion);
        //        }
        //        return appVersion;
        //    }
        //    catch (Exception ex)
        //    {
        //        Notify(ex, "TraceLogger", "GetAssemblyVersion");
        //        return "-";
        //    }

        //}

        //private string GetLastModifiedDate()
        //{
        //    try
        //    {
        //        string lastMDate = (string)CacheManager.GetCache(Constants.Cache.LAST_MODIFIED_DATE);
        //        if (string.IsNullOrWhiteSpace(lastMDate))
        //        {
        //            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        //            System.IO.FileInfo fileInfo = new System.IO.FileInfo(assembly.Location);
        //            DateTime lastModified = fileInfo.LastWriteTime;
        //            lastMDate = SafeConvert.ToString(lastModified);
        //            CacheManager.SetCache(Constants.Cache.LAST_MODIFIED_DATE, lastMDate);
        //        }
        //        return lastMDate;
        //    }
        //    catch (Exception ex)
        //    {
        //        Notify(ex, "TraceLogger", "GetLastModifiedDate");
        //        return "-";
        //    }
        //}
    }
}
