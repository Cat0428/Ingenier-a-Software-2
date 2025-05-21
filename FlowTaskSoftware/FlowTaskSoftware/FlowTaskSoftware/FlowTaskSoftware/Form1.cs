using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections;


namespace FlowTaskSoftware
{
    public partial class frmLogin : Form
    {
        
        Usuario usuario = new Usuario();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (usuario.ValidateUser(txtUsuario.Text, txtContrasena.Text) == true)
            {
                frmGestorTareas formGestorTareas = new frmGestorTareas();
                this.Hide();
                formGestorTareas.Show();
            }
            else
            {
                try
                {
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    MessageBox.Show("Usuario y/o contraseña incorrectas","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex) 
                {
                   

                }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroForm _RegistroForm = new RegistroForm();
            _RegistroForm.Show();
        }
    } 
}
