using System;
using System.Collections.Generic;
using System.Text;

namespace POSRepository.Common.Interfaces
{
    public interface ITraceLogger
    {
        void Notify(params object[] args);
        void Exception(params object[] args);
        void Exception(Exception ex, params object[] args);
        void MOBException(string pUniqueId, params object[] args);
    }
}
