using System;
using System.Collections.Generic;
using System.Text;

namespace POSServiceProvider
{
    internal class ServiceFactory
    {
        public IServiceProvider GetServiceProvider()
        {
            return new ServiceProvider();
        }
    }
}
