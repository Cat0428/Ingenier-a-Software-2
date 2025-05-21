using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasApp;

namespace FlowTaskSoftware
{
    public class Tareas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public int UsuarioId { get; set; }
        public int EstadoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        public void AgregarTarea(string titulo, string descripcion, int categoriaId, int usuarioId, int estadoId, DateTime? fechaVencimiento = null)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Tareas (titulo, descripcion, categoriaId, usuarioId, estadoId, fechaCreacion, fechaVencimiento) " +
                               "VALUES (@titulo, @descripcion, @categoriaId, @usuarioId, @estadoId, GETDATE(), @fechaVencimiento)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@categoriaId", categoriaId);
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@estadoId", estadoId);
                    command.Parameters.AddWithValue("@fechaVencimiento", (object)fechaVencimiento ?? DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Tareas> ObtenerTareas()
        {
            List<Tareas> tareas = new List<Tareas>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT id, titulo, descripcion, categoriaId, usuarioId, estadoId, fechaCreacion, fechaVencimiento FROM Tareas";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tareas.Add(new Tareas
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Titulo = reader["titulo"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                CategoriaId = Convert.ToInt32(reader["categoriaId"]),
                                UsuarioId = Convert.ToInt32(reader["usuarioId"]),
                                EstadoId = Convert.ToInt32(reader["estadoId"]),
                                FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]),
                                FechaVencimiento = reader["fechaVencimiento"] != DBNull.Value ? Convert.ToDateTime(reader["fechaVencimiento"]) : (DateTime?)null
                            });
                        }
                    }
                }
            }
            return tareas;
        }


        public void BorrarTarea(string id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {

                string consulta = "DELETE FROM Tareas WHERE id = @id";

                using (var command = new SqlCommand(consulta, conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
