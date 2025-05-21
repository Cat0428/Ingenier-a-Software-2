namespace FlowTaskSoftware
{
    partial class CategoriasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriasForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategorias = new MaterialSkin.Controls.MaterialLabel();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVolverATareas = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Depth = 0;
            this.lblCategorias.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategorias.Location = new System.Drawing.Point(403, 72);
            this.lblCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(77, 19);
            this.lblCategorias.TabIndex = 12;
            this.lblCategorias.Text = "Categorias";
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.nombreCategoria,
            this.descripcionCategoria,
            this.fechaCategoria,
            this.guardarCategoria,
            this.editarCategoria,
            this.borrarCategoria});
            this.dtgCategorias.Location = new System.Drawing.Point(29, 143);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.Size = new System.Drawing.Size(744, 283);
            this.dtgCategorias.TabIndex = 24;
            this.dtgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategorias_CellContentClick);
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "Id";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.HeaderText = "Nombre";
            this.nombreCategoria.Name = "nombreCategoria";
            // 
            // descripcionCategoria
            // 
            this.descripcionCategoria.HeaderText = "Descripcion";
            this.descripcionCategoria.Name = "descripcionCategoria";
            // 
            // fechaCategoria
            // 
            this.fechaCategoria.HeaderText = "Fecha (AAAA-MM-DD)";
            this.fechaCategoria.Name = "fechaCategoria";
            this.fechaCategoria.ReadOnly = true;
            // 
            // guardarCategoria
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.guardarCategoria.DefaultCellStyle = dataGridViewCellStyle4;
            this.guardarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarCategoria.HeaderText = "Guardar";
            this.guardarCategoria.Name = "guardarCategoria";
            this.guardarCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.guardarCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.guardarCategoria.Text = "Guardar";
            this.guardarCategoria.UseColumnTextForButtonValue = true;
            // 
            // editarCategoria
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.editarCategoria.DefaultCellStyle = dataGridViewCellStyle5;
            this.editarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editarCategoria.HeaderText = "Editar";
            this.editarCategoria.Name = "editarCategoria";
            this.editarCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editarCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editarCategoria.Text = "Editar";
            this.editarCategoria.UseColumnTextForButtonValue = true;
            // 
            // borrarCategoria
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.borrarCategoria.DefaultCellStyle = dataGridViewCellStyle6;
            this.borrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrarCategoria.HeaderText = "Borrar";
            this.borrarCategoria.Name = "borrarCategoria";
            this.borrarCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrarCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.borrarCategoria.Text = "Borrar";
            this.borrarCategoria.UseColumnTextForButtonValue = true;
            // 
            // btnVolverATareas
            // 
            this.btnVolverATareas.AutoSize = false;
            this.btnVolverATareas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolverATareas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolverATareas.Depth = 0;
            this.btnVolverATareas.HighEmphasis = true;
            this.btnVolverATareas.Icon = null;
            this.btnVolverATareas.Location = new System.Drawing.Point(544, 455);
            this.btnVolverATareas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolverATareas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolverATareas.Name = "btnVolverATareas";
            this.btnVolverATareas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolverATareas.Size = new System.Drawing.Size(159, 50);
            this.btnVolverATareas.TabIndex = 25;
            this.btnVolverATareas.Text = "Volver";
            this.btnVolverATareas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolverATareas.UseAccentColor = false;
            this.btnVolverATareas.UseVisualStyleBackColor = true;
            this.btnVolverATareas.Click += new System.EventHandler(this.btnVolverATareas_Click);
            // 
            // CategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btnVolverATareas);
            this.Controls.Add(this.dtgCategorias);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCategorias);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "CategoriasForm";
            this.Text = "CategoriasForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblCategorias;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private MaterialSkin.Controls.MaterialButton btnVolverATareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn guardarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn editarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn borrarCategoria;
    }
}