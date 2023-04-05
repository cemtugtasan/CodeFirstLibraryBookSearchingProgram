using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Configuraiton
{
    public static class AppConfig
    {
        public static string GetConnectionString()
        {
            return @"Server=DESKTOP-55D3033\MSSQLSERVER01;Database=library;Trusted_Connection=True;TrustServerCertificate=True";
        }
    }
}
