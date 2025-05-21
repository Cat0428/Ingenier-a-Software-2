using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowTaskSoftware.Context;
using TareasApp;

namespace FlowTaskSoftware
{
    public class Usuario
    {

        public int Id { get; set; }

        //Validar usuario de login
        public bool ValidateUser(string username, string password)
        {
            bool result = false;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string consulta = "SELECT nombreUsuario, contrasena FROM Usuarios WHERE nombreUsuario=@NombreUsuario and contrasena=@Contrasena";

                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("@NombreUsuario", username);
                comando.Parameters.AddWithValue("@Contrasena", password);


                using (var reader = comando.ExecuteReader())
                {

                    if (reader.HasRows)
                    {
                        return result = true;
                    }
                }
            }

            return result;
        }

        //CRUD: Leer
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuario = new List<Usuario>();

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT id FROM Usuarios";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario.Add(new Usuario
                            {
                                Id = reader.GetInt32(0),
                                
                            });
                        }
                    }
                }
            }

            return usuario;

        }

    }
}
