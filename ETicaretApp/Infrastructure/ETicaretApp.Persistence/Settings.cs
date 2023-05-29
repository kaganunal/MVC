using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence
{
    public static class Settings
    {
        public static string ConnString
        {
            get
            {
                ConfigurationManager configManager = new();

                configManager.SetBasePath(Directory.GetCurrentDirectory()+"/../../Presentation/ETicaretApp.WEBAPI");
                configManager.AddJsonFile("appsettings.json");

                //return configManager.GetSection("ConnectionStrings")["home"];
                return configManager.GetConnectionString("home");
            }
        }
    }
}
