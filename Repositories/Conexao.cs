using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SistemaFooFaMvc.Repositories
{
    public static class Conexao
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["FooFighters"].ConnectionString;
        }
    }
}