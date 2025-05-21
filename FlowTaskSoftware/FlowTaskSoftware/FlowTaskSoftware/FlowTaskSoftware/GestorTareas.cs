using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowTaskSoftware.Context;
using TareasApp;

namespace FlowTaskSoftware
{
    public partial class frmGestorTareas : Form
    {
        Categorias categorias = new Categorias();
        Estados estados = new Estados();
        Usuario usuario = new Usuario();
        Tareas tareas = new Tareas();

        public frmGestorTareas()
        {
            InitializeComponent();

            CargarTareas();           
            CargarCategorias();
            CargarEstados();
            CargarUsuarios();
            LimpiarCampos();

        }

        private void CargarCategorias()
        {
            cboIdCategoriaTarea.DataSource = categorias.ObtenerCategorias();
            cboIdCategoriaTarea.DisplayMember = "NombreCategorias";
            cboIdCategoriaTarea.ValueMember = "Id";
        }

        private void CargarEstados()
        {
            cboIdEstadoTarea.DataSource = estados.ObtenerEstados();
            cboIdEstadoTarea.DisplayMember = "NombreEstados";
            cboIdEstadoTarea.ValueMember = "Id";
        }

        private void CargarUsuarios()
        {
            cboIdUsuarioTarea.DataSource = usuario.ObtenerUsuarios();
            cboIdUsuarioTarea.DisplayMember = "NombreUsuarios";
            cboIdUsuarioTarea.ValueMember = "Id";
        }

        private void CargarTareas()
        {
            dtgGestorTareas.DataSource = null;
            dtgGestorTareas.Rows.Clear();
            
            List <Tareas> listaTareas = tareas.ObtenerTareas();
            foreach (var tarea in listaTareas)
            {
                dtgGestorTareas.Rows.Add(tarea.Id, 
                    tarea.Titulo, 
                    tarea.Descripcion, 
                    tarea.CategoriaId, 
                    tarea.UsuarioId, 
                    tarea.EstadoId, 
                    tarea.FechaCreacion, 
                    tarea.FechaVencimiento);
            }
        }

        public void LimpiarCampos()
        {
            txtTituloTarea.Text = "";
            txtDescripcionTarea.Text = "";
            cboIdCategoriaTarea.SelectedIndex = -1;
            cboIdUsuarioTarea.SelectedIndex = -1;
            cboIdEstadoTarea.SelectedIndex = -1;
            dtpFechaVencimientoTarea.Value = DateTime.Now;
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            
            if (txtTituloTarea.Text == "" || 
                txtDescripcionTarea.Text == "" ||
                cboIdCategoriaTarea.SelectedValue == null ||
                cboIdUsuarioTarea.SelectedValue == null ||
                cboIdEstadoTarea.SelectedValue == null)
            {
                MessageBox.Show("Se deben completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var valorTitulo = txtTituloTarea.Text.ToString();
                var valorDescripcion = txtDescripcionTarea.Text.ToString();
                var valorCategoriaId = Convert.ToInt32(cboIdCategoriaTarea.SelectedValue);
                var valorUsuarioId = Convert.ToInt32(cboIdUsuarioTarea.SelectedValue);
                var valorEstadoId = Convert.ToInt32(cboIdEstadoTarea.SelectedValue);
                var valorFechaVencimiento = Convert.ToDateTime(dtpFechaVencimientoTarea.Text);

                tareas.AgregarTarea(valorTitulo, 
                    valorDescripcion, 
                    valorCategoriaId, 
                    valorUsuarioId, 
                    valorEstadoId, 
                    valorFechaVencimiento);

                CargarTareas();
                LimpiarCampos();

            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriasForm categoriasForm = new CategoriasForm();
            categoriasForm.Show();
        }

        //CRUD: Borrar(boton dentro de DataGridView)
        private void dtgGestorTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            var valorId = dtgGestorTareas.Rows[e.RowIndex].Cells["idTarea"].Value.ToString();

            if (dtgGestorTareas.Rows.Count > 1)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea borrar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    tareas.BorrarTarea(valorId);
                    CargarTareas();
                }

            }
            else
            {
                MessageBox.Show("No puede borrar una celda vacia");
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }


}
