using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowTaskSoftware
{
    public partial class RegistroForm : Form
    {
        Registro registro = new Registro();
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin _FrmLogin = new frmLogin();
            _FrmLogin.Show();
        }

        public void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtRepetirContrasena.Text = "";
            txtCorreo.Text = "";
            chkTerminos.Checked = false;
        }


        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" ||
                txtContrasena.Text == "" ||
                txtRepetirContrasena.Text == "" ||
                txtCorreo.Text == "" ||
                chkTerminos.Checked == false)
            {
                MessageBox.Show("Se deben completar todos los campos y aceptar los términos y condiciones",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);


            }
            else
            {

                if (txtContrasena.Text != txtRepetirContrasena.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    var ValorUsuario = txtUsuario.Text.ToString();
                    var ValorContrasena = txtContrasena.Text.ToString();
                    var ValorCorreo = txtCorreo.Text.ToString();

                    registro.RegistrarUsuario(ValorUsuario,
                        ValorContrasena,
                        ValorCorreo);


                    MessageBox.Show("Usuario registrado con éxito",
                    "Usuario registrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    LimpiarCampos();

                }

            }
        }
    }
}
