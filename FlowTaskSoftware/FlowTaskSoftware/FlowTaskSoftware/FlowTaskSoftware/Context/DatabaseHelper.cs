using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace TareasApp
{
    public static class DatabaseHelper
    {
        //Cadena de conexion base de datos
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["TareasDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}