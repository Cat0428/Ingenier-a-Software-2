namespace FlowTaskSoftware
{
    partial class RegistroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.lblConstrasena = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarse = new MaterialSkin.Controls.MaterialButton();
            this.lblRegistroUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.lblRepetirContrasena = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRepetirContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.chkTerminos = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConstrasena
            // 
            this.lblConstrasena.AutoSize = true;
            this.lblConstrasena.Depth = 0;
            this.lblConstrasena.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConstrasena.Location = new System.Drawing.Point(117, 208);
            this.lblConstrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConstrasena.Name = "lblConstrasena";
            this.lblConstrasena.Size = new System.Drawing.Size(82, 19);
            this.lblConstrasena.TabIndex = 13;
            this.lblConstrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuario.Location = new System.Drawing.Point(117, 133);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 19);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSize = false;
            this.btnRegistrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarse.Depth = 0;
            this.btnRegistrarse.HighEmphasis = true;
            this.btnRegistrarse.Icon = null;
            this.btnRegistrarse.Location = new System.Drawing.Point(120, 485);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarse.Size = new System.Drawing.Size(285, 50);
            this.btnRegistrarse.TabIndex = 10;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarse.UseAccentColor = false;
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblRegistroUsuario
            // 
            this.lblRegistroUsuario.AutoSize = true;
            this.lblRegistroUsuario.Depth = 0;
            this.lblRegistroUsuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRegistroUsuario.Location = new System.Drawing.Point(222, 64);
            this.lblRegistroUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRegistroUsuario.Name = "lblRegistroUsuario";
            this.lblRegistroUsuario.Size = new System.Drawing.Size(137, 19);
            this.lblRegistroUsuario.TabIndex = 9;
            this.lblRegistroUsuario.Text = "Registro de usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.AnimateReadOnly = false;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasena.LeadingIcon = null;
            this.txtContrasena.Location = new System.Drawing.Point(120, 230);
            this.txtContrasena.MaxLength = 50;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasena.Multiline = false;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Password = true;
            this.txtContrasena.Size = new System.Drawing.Size(285, 50);
            this.txtContrasena.TabIndex = 8;
            this.txtContrasena.Text = "";
            this.txtContrasena.TrailingIcon = null;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(120, 155);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(285, 50);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Depth = 0;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCorreo.Location = new System.Drawing.Point(117, 361);
            this.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 19);
            this.lblCorreo.TabIndex = 17;
            this.lblCorreo.Text = "Correo";
            // 
            // lblRepetirContrasena
            // 
            this.lblRepetirContrasena.AutoSize = true;
            this.lblRepetirContrasena.Depth = 0;
            this.lblRepetirContrasena.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRepetirContrasena.Location = new System.Drawing.Point(117, 286);
            this.lblRepetirContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRepetirContrasena.Name = "lblRepetirContrasena";
            this.lblRepetirContrasena.Size = new System.Drawing.Size(133, 19);
            this.lblRepetirContrasena.TabIndex = 16;
            this.lblRepetirContrasena.Text = "Repetir contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(120, 383);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(285, 50);
            this.txtCorreo.TabIndex = 15;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.AnimateReadOnly = false;
            this.txtRepetirContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepetirContrasena.Depth = 0;
            this.txtRepetirContrasena.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepetirContrasena.LeadingIcon = null;
            this.txtRepetirContrasena.Location = new System.Drawing.Point(120, 308);
            this.txtRepetirContrasena.MaxLength = 50;
            this.txtRepetirContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRepetirContrasena.Multiline = false;
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.Password = true;
            this.txtRepetirContrasena.Size = new System.Drawing.Size(285, 50);
            this.txtRepetirContrasena.TabIndex = 14;
            this.txtRepetirContrasena.Text = "";
            this.txtRepetirContrasena.TrailingIcon = null;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = false;
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(120, 547);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(285, 50);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // chkTerminos
            // 
            this.chkTerminos.Depth = 0;
            this.chkTerminos.Location = new System.Drawing.Point(120, 436);
            this.chkTerminos.Margin = new System.Windows.Forms.Padding(0);
            this.chkTerminos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTerminos.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTerminos.Name = "chkTerminos";
            this.chkTerminos.ReadOnly = false;
            this.chkTerminos.Ripple = true;
            this.chkTerminos.Size = new System.Drawing.Size(285, 37);
            this.chkTerminos.TabIndex = 20;
            this.chkTerminos.Text = "Acepto términos y condiciones";
            this.chkTerminos.UseVisualStyleBackColor = true;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 629);
            this.Controls.Add(this.chkTerminos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblRepetirContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtRepetirContrasena);
            this.Controls.Add(this.lblConstrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblRegistroUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Name = "RegistroForm";
            this.Text = "FrmRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblConstrasena;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnRegistrarse;
        private MaterialSkin.Controls.MaterialLabel lblRegistroUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtContrasena;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialLabel lblRepetirContrasena;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox txtRepetirContrasena;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialCheckbox chkTerminos;
    }
}