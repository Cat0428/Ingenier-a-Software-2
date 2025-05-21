using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareasApp;

namespace FlowTaskSoftware
{
    public partial class CategoriasForm : Form
    {

        Categorias categorias = new Categorias();

        public CategoriasForm()
        {
            InitializeComponent();
            CargarCategorias();            

        }

        public void CargarCategorias()
        {
            List<Categorias> listaCategorias = categorias.ObtenerCategorias();
            foreach (var categoria in listaCategorias)
            {
                dtgCategorias.Rows.Add(categoria.Id, categoria.NombreCategoria, categoria.DescripcionCategoria, categoria.FechaCreacion);
            }
        }

        private void btnVolverATareas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestorTareas formGestorTareas = new frmGestorTareas();
            formGestorTareas.Show();

        }

        
        public void dtgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string columnName = dtgCategorias.Columns[e.ColumnIndex].Name;

            var valorId = dtgCategorias.Rows[e.RowIndex].Cells["idCategoria"].Value.ToString();
            var valorNombre = dtgCategorias.Rows[e.RowIndex].Cells["nombreCategoria"].Value.ToString();
            var valorDescripcion = dtgCategorias.Rows[e.RowIndex].Cells["descripcionCategoria"].Value.ToString();


            //Validacion por boton(Guardar, Editar, Borrar) dentro de DataGridView
            if (columnName == "guardarCategoria")
            {
                categorias.GuardarCategoria(valorNombre, valorDescripcion);

                MessageBox.Show("Se guardó categoria con éxito", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (columnName == "editarCategoria")
            {
                categorias.EditarCategoria(valorId, valorNombre, valorDescripcion);

                MessageBox.Show("Se modificó registro con éxito", "Registro modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (columnName == "borrarCategoria")
            {
                if (dtgCategorias.Rows.Count > 1)
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea borrar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        categorias.BorrarCategoria(valorId);
                    }

                }
                else
                {
                    MessageBox.Show("No puede borrar una celda vacia");
                }
            }

        }
    }


}
