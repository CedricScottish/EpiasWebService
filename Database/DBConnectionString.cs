using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DBConnectionString
    {
        public static string dbConnectionString
        {
            get
            {
                return ConfigurationSettings.AppSettings["dbCon"].ToString();
            }
        }
    }


}
