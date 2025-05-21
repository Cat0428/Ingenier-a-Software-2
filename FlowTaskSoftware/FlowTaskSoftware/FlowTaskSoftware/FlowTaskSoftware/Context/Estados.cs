using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasApp;

namespace FlowTaskSoftware.Context
{
    public class Estados
    {
        public int Id { get; set; }
        public string NombreEstado { get; set; }

        //Metodo para obtener id de Estados
        public List<Estados> ObtenerEstados()
        {
            List<Estados> estados = new List<Estados>();

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT id, nombreEstado FROM Estados";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            estados.Add(new Estados
                            {
                                Id = reader.GetInt32(0),
                                NombreEstado = reader.GetString(1)
                            });
                        }
                    }
                }
            }

            return estados;

        }

    }
}
