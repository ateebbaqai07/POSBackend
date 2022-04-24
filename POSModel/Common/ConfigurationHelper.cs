
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSModel.Common
{
    public class CustomConfigurationServiceProvider
    {
        public static IServiceProvider ServiceProvider { get; set; }
    }

    public  class ConfigurationHelper
    {
        private static readonly IConfigurationRoot Configuration;
        private static readonly string _ConnectionString;

        static ConfigurationHelper()
        {
            IHostEnvironment env = CustomConfigurationServiceProvider.ServiceProvider.GetRequiredService<IHostEnvironment>();

            Configuration = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
              .Build();

            var _configString = Configuration["DataSettings:DataConnectionString"];
            _ConnectionString  =   _configString;
        }

        public static string DataConnectionString
        {
            get { return _ConnectionString; }
        }
    }
}
