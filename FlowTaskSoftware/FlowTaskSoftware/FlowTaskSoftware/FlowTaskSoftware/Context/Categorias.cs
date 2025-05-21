using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasApp;

namespace FlowTaskSoftware
{
    public class Categorias
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public DateTime FechaCreacion { get; set; }


        public void GuardarCategoria(string nombre, string descripcion)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {

                string consulta = "INSERT INTO Categorias (nombre, descripcion, fechaCreacion) VALUES (@nombre, @descripcion, GETDATE())";

                using (var command = new SqlCommand(consulta, conn))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Categorias> ObtenerCategorias()
        {
            //Lista provisional para llenar DataGridView
            List<Categorias> categorias = new List<Categorias>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string consulta = "SELECT id, nombre, descripcion, fechaCreacion FROM Categorias";

                using (var command = new SqlCommand(consulta, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(new Categorias
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NombreCategoria = reader["nombre"].ToString(),
                                DescripcionCategoria = reader["descripcion"].ToString(),
                                FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"])
                            });
                        }
                    }
                }
            }
            return categorias;
        }


        public void EditarCategoria(string id, string nombre, string descripcion)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {

                string consulta = "UPDATE Categorias SET nombre=@nombre, descripcion=@descripcion WHERE id=@id";

                using (var command = new SqlCommand(consulta, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void BorrarCategoria(string id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {

                string consulta = "DELETE FROM Categorias WHERE id = @id";

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
