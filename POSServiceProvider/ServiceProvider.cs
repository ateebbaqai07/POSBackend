using POSInterface;
using POSLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSServiceProvider
{
    public class ServiceProvider : IServiceProvider
    {
        public ICommonService GetCommonService()
        {
            return new CommonService();
        }
    }
}
