using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasApp;

namespace FlowTaskSoftware
{
    public class Registro
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }


        public void RegistrarUsuario(string _Nombre, string _Contrasena, string _Correo)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {

                string consulta = 
                    "INSERT INTO Usuarios " +
                    "(nombreUsuario, contrasena, correo, fechaCreacion) " +
                    "VALUES (@_Nombre, @_Contrasena, @_Correo, GETDATE())";

                using (var command = new SqlCommand(consulta, conn))
                {
                    command.Parameters.AddWithValue("@_Nombre", _Nombre);
                    command.Parameters.AddWithValue("@_Contrasena", _Contrasena);
                    command.Parameters.AddWithValue("@_Correo", _Correo);

                    conn.Open();
                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
