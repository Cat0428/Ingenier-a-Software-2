namespace FlowTaskSoftware
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.lblInicioSesion = new MaterialSkin.Controls.MaterialLabel();
            this.btnInicioSesion = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblConstrasena = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegistrarse = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(120, 253);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(285, 50);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AnimateReadOnly = false;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasena.LeadingIcon = null;
            this.txtContrasena.Location = new System.Drawing.Point(120, 359);
            this.txtContrasena.MaxLength = 50;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasena.Multiline = false;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Password = true;
            this.txtContrasena.Size = new System.Drawing.Size(285, 50);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.Text = "";
            this.txtContrasena.TrailingIcon = null;
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Depth = 0;
            this.lblInicioSesion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInicioSesion.Location = new System.Drawing.Point(222, 150);
            this.lblInicioSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(110, 19);
            this.lblInicioSesion.TabIndex = 2;
            this.lblInicioSesion.Text = "Inicio de sesion";
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.AutoSize = false;
            this.btnInicioSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInicioSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInicioSesion.Depth = 0;
            this.btnInicioSesion.HighEmphasis = true;
            this.btnInicioSesion.Icon = null;
            this.btnInicioSesion.Location = new System.Drawing.Point(120, 435);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInicioSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInicioSesion.Size = new System.Drawing.Size(285, 50);
            this.btnInicioSesion.TabIndex = 3;
            this.btnInicioSesion.Text = "Iniciar sesion";
            this.btnInicioSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInicioSesion.UseAccentColor = false;
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuario.Location = new System.Drawing.Point(117, 219);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 19);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConstrasena
            // 
            this.lblConstrasena.AutoSize = true;
            this.lblConstrasena.Depth = 0;
            this.lblConstrasena.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConstrasena.Location = new System.Drawing.Point(117, 324);
            this.lblConstrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConstrasena.Name = "lblConstrasena";
            this.lblConstrasena.Size = new System.Drawing.Size(82, 19);
            this.lblConstrasena.TabIndex = 6;
            this.lblConstrasena.Text = "Contraseña";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSize = false;
            this.btnRegistrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarse.Depth = 0;
            this.btnRegistrarse.HighEmphasis = true;
            this.btnRegistrarse.Icon = null;
            this.btnRegistrarse.Location = new System.Drawing.Point(120, 497);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarse.Size = new System.Drawing.Size(285, 50);
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarse.UseAccentColor = false;
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 563);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblConstrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frmLogin";
            this.Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtContrasena;
        private MaterialSkin.Controls.MaterialLabel lblInicioSesion;
        private MaterialSkin.Controls.MaterialButton btnInicioSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblConstrasena;
        private MaterialSkin.Controls.MaterialButton btnRegistrarse;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

