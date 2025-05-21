namespace FlowTaskSoftware
{
    partial class frmGestorTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorTareas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregarTarea = new MaterialSkin.Controls.MaterialButton();
            this.lblGestorTareas = new MaterialSkin.Controls.MaterialLabel();
            this.dtgGestorTareas = new System.Windows.Forms.DataGridView();
            this.idTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrarTarea = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCategorias = new MaterialSkin.Controls.MaterialButton();
            this.txtTituloTarea = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescripcionTarea = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTituloTarea = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescripcionTarea = new MaterialSkin.Controls.MaterialLabel();
            this.lblIdEstadoTarea = new MaterialSkin.Controls.MaterialLabel();
            this.cboIdEstadoTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.cboIdCategoriaTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.lblIdCategoriaTarea = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditarTarea = new MaterialSkin.Controls.MaterialButton();
            this.dtpFechaVencimientoTarea = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimientoTarea = new MaterialSkin.Controls.MaterialLabel();
            this.cboIdUsuarioTarea = new MaterialSkin.Controls.MaterialComboBox();
            this.lblIdUsuarioTarea = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGestorTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.AutoSize = false;
            this.btnAgregarTarea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTarea.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarTarea.Depth = 0;
            this.btnAgregarTarea.HighEmphasis = true;
            this.btnAgregarTarea.Icon = null;
            this.btnAgregarTarea.Location = new System.Drawing.Point(40, 495);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarTarea.Size = new System.Drawing.Size(132, 47);
            this.btnAgregarTarea.TabIndex = 10;
            this.btnAgregarTarea.Text = "Agregar tarea";
            this.btnAgregarTarea.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarTarea.UseAccentColor = false;
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // lblGestorTareas
            // 
            this.lblGestorTareas.AutoSize = true;
            this.lblGestorTareas.Depth = 0;
            this.lblGestorTareas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGestorTareas.Location = new System.Drawing.Point(579, 58);
            this.lblGestorTareas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGestorTareas.Name = "lblGestorTareas";
            this.lblGestorTareas.Size = new System.Drawing.Size(116, 19);
            this.lblGestorTareas.TabIndex = 9;
            this.lblGestorTareas.Text = "Gestor de tareas";
            // 
            // dtgGestorTareas
            // 
            this.dtgGestorTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGestorTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarea,
            this.tituloTarea,
            this.descripcionTarea,
            this.idCategoriaTarea,
            this.idUsuarioTarea,
            this.idEstadoTarea,
            this.fechaCreacionTarea,
            this.fechaVencimientoTarea,
            this.borrarTarea});
            this.dtgGestorTareas.Location = new System.Drawing.Point(364, 129);
            this.dtgGestorTareas.Name = "dtgGestorTareas";
            this.dtgGestorTareas.Size = new System.Drawing.Size(852, 350);
            this.dtgGestorTareas.TabIndex = 17;
            this.dtgGestorTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGestorTareas_CellContentClick);
            // 
            // idTarea
            // 
            this.idTarea.HeaderText = "Id";
            this.idTarea.Name = "idTarea";
            this.idTarea.ReadOnly = true;
            this.idTarea.Width = 30;
            // 
            // tituloTarea
            // 
            this.tituloTarea.HeaderText = "Titulo";
            this.tituloTarea.Name = "tituloTarea";
            this.tituloTarea.ReadOnly = true;
            // 
            // descripcionTarea
            // 
            this.descripcionTarea.HeaderText = "Descripcion";
            this.descripcionTarea.Name = "descripcionTarea";
            this.descripcionTarea.ReadOnly = true;
            // 
            // idCategoriaTarea
            // 
            this.idCategoriaTarea.HeaderText = "Id categoria";
            this.idCategoriaTarea.Name = "idCategoriaTarea";
            this.idCategoriaTarea.ReadOnly = true;
            this.idCategoriaTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCategoriaTarea.Width = 60;
            // 
            // idUsuarioTarea
            // 
            this.idUsuarioTarea.HeaderText = "Id usuario";
            this.idUsuarioTarea.Name = "idUsuarioTarea";
            this.idUsuarioTarea.ReadOnly = true;
            this.idUsuarioTarea.Width = 60;
            // 
            // idEstadoTarea
            // 
            this.idEstadoTarea.HeaderText = "Id estado";
            this.idEstadoTarea.Name = "idEstadoTarea";
            this.idEstadoTarea.ReadOnly = true;
            this.idEstadoTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idEstadoTarea.Width = 60;
            // 
            // fechaCreacionTarea
            // 
            this.fechaCreacionTarea.HeaderText = "Fecha de creacion";
            this.fechaCreacionTarea.Name = "fechaCreacionTarea";
            this.fechaCreacionTarea.ReadOnly = true;
            // 
            // fechaVencimientoTarea
            // 
            this.fechaVencimientoTarea.HeaderText = "Fecha de vencimiento";
            this.fechaVencimientoTarea.Name = "fechaVencimientoTarea";
            this.fechaVencimientoTarea.ReadOnly = true;
            // 
            // borrarTarea
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.borrarTarea.DefaultCellStyle = dataGridViewCellStyle2;
            this.borrarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrarTarea.HeaderText = "Borrar";
            this.borrarTarea.Name = "borrarTarea";
            this.borrarTarea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrarTarea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.borrarTarea.Text = "Borrar";
            this.borrarTarea.UseColumnTextForButtonValue = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.AutoSize = false;
            this.btnCategorias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCategorias.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCategorias.Depth = 0;
            this.btnCategorias.HighEmphasis = true;
            this.btnCategorias.Icon = null;
            this.btnCategorias.Location = new System.Drawing.Point(364, 495);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCategorias.Size = new System.Drawing.Size(159, 50);
            this.btnCategorias.TabIndex = 18;
            this.btnCategorias.Text = "categorias";
            this.btnCategorias.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCategorias.UseAccentColor = false;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.AnimateReadOnly = false;
            this.txtTituloTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloTarea.Depth = 0;
            this.txtTituloTarea.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTituloTarea.LeadingIcon = null;
            this.txtTituloTarea.Location = new System.Drawing.Point(40, 79);
            this.txtTituloTarea.MaxLength = 50;
            this.txtTituloTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTituloTarea.Multiline = false;
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(285, 50);
            this.txtTituloTarea.TabIndex = 7;
            this.txtTituloTarea.Text = "";
            this.txtTituloTarea.TrailingIcon = null;
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.AnimateReadOnly = false;
            this.txtDescripcionTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionTarea.Depth = 0;
            this.txtDescripcionTarea.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionTarea.LeadingIcon = null;
            this.txtDescripcionTarea.Location = new System.Drawing.Point(40, 154);
            this.txtDescripcionTarea.MaxLength = 50;
            this.txtDescripcionTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionTarea.Multiline = false;
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.Size = new System.Drawing.Size(285, 50);
            this.txtDescripcionTarea.TabIndex = 8;
            this.txtDescripcionTarea.Text = "";
            this.txtDescripcionTarea.TrailingIcon = null;
            // 
            // lblTituloTarea
            // 
            this.lblTituloTarea.AutoSize = true;
            this.lblTituloTarea.Depth = 0;
            this.lblTituloTarea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTituloTarea.Location = new System.Drawing.Point(37, 57);
            this.lblTituloTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloTarea.Name = "lblTituloTarea";
            this.lblTituloTarea.Size = new System.Drawing.Size(42, 19);
            this.lblTituloTarea.TabIndex = 12;
            this.lblTituloTarea.Text = "Titulo";
            // 
            // lblDescripcionTarea
            // 
            this.lblDescripcionTarea.AutoSize = true;
            this.lblDescripcionTarea.Depth = 0;
            this.lblDescripcionTarea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionTarea.Location = new System.Drawing.Point(37, 132);
            this.lblDescripcionTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionTarea.Name = "lblDescripcionTarea";
            this.lblDescripcionTarea.Size = new System.Drawing.Size(84, 19);
            this.lblDescripcionTarea.TabIndex = 13;
            this.lblDescripcionTarea.Text = "Descripcion";
            // 
            // lblIdEstadoTarea
            // 
            this.lblIdEstadoTarea.AutoSize = true;
            this.lblIdEstadoTarea.Depth = 0;
            this.lblIdEstadoTarea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdEstadoTarea.Location = new System.Drawing.Point(37, 357);
            this.lblIdEstadoTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdEstadoTarea.Name = "lblIdEstadoTarea";
            this.lblIdEstadoTarea.Size = new System.Drawing.Size(66, 19);
            this.lblIdEstadoTarea.TabIndex = 15;
            this.lblIdEstadoTarea.Text = "Id estado";
            // 
            // cboIdEstadoTarea
            // 
            this.cboIdEstadoTarea.AutoResize = false;
            this.cboIdEstadoTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboIdEstadoTarea.Depth = 0;
            this.cboIdEstadoTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboIdEstadoTarea.DropDownHeight = 174;
            this.cboIdEstadoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdEstadoTarea.DropDownWidth = 121;
            this.cboIdEstadoTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboIdEstadoTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboIdEstadoTarea.FormattingEnabled = true;
            this.cboIdEstadoTarea.IntegralHeight = false;
            this.cboIdEstadoTarea.ItemHeight = 43;
            this.cboIdEstadoTarea.Location = new System.Drawing.Point(40, 379);
            this.cboIdEstadoTarea.MaxDropDownItems = 4;
            this.cboIdEstadoTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.cboIdEstadoTarea.Name = "cboIdEstadoTarea";
            this.cboIdEstadoTarea.Size = new System.Drawing.Size(285, 49);
            this.cboIdEstadoTarea.StartIndex = 0;
            this.cboIdEstadoTarea.TabIndex = 16;
            // 
            // cboIdCategoriaTarea
            // 
            this.cboIdCategoriaTarea.AutoResize = false;
            this.cboIdCategoriaTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboIdCategoriaTarea.Depth = 0;
            this.cboIdCategoriaTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboIdCategoriaTarea.DropDownHeight = 174;
            this.cboIdCategoriaTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCategoriaTarea.DropDownWidth = 121;
            this.cboIdCategoriaTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboIdCategoriaTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboIdCategoriaTarea.FormattingEnabled = true;
            this.cboIdCategoriaTarea.IntegralHeight = false;
            this.cboIdCategoriaTarea.ItemHeight = 43;
            this.cboIdCategoriaTarea.Location = new System.Drawing.Point(40, 229);
            this.cboIdCategoriaTarea.MaxDropDownItems = 4;
            this.cboIdCategoriaTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.cboIdCategoriaTarea.Name = "cboIdCategoriaTarea";
            this.cboIdCategoriaTarea.Size = new System.Drawing.Size(285, 49);
            this.cboIdCategoriaTarea.StartIndex = 0;
            this.cboIdCategoriaTarea.TabIndex = 20;
            // 
            // lblIdCategoriaTarea
            // 
            this.lblIdCategoriaTarea.AutoSize = true;
            this.lblIdCategoriaTarea.Depth = 0;
            this.lblIdCategoriaTarea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdCategoriaTarea.Location = new System.Drawing.Point(37, 207);
            this.lblIdCategoriaTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdCategoriaTarea.Name = "lblIdCategoriaTarea";
            this.lblIdCategoriaTarea.Size = new System.Drawing.Size(84, 19);
            this.lblIdCategoriaTarea.TabIndex = 19;
            this.lblIdCategoriaTarea.Text = "Id categoria";
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.AutoSize = false;
            this.btnEditarTarea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarTarea.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarTarea.Depth = 0;
            this.btnEditarTarea.HighEmphasis = true;
            this.btnEditarTarea.Icon = null;
            this.btnEditarTarea.Location = new System.Drawing.Point(193, 495);
            this.btnEditarTarea.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarTarea.Size = new System.Drawing.Size(132, 47);
            this.btnEditarTarea.TabIndex = 23;
            this.btnEditarTarea.Text = "Editar tarea";
            this.btnEditarTarea.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarTarea.UseAccentColor = false;
            this.btnEditarTarea.UseVisualStyleBackColor = true;
            this.btnEditarTarea.Click += new System.EventHandler(this.btnEditarTarea_Click);
            // 
            // dtpFechaVencimientoTarea
            // 
            this.dtpFechaVencimientoTarea.Location = new System.Drawing.Point(40, 464);
            this.dtpFechaVencimientoTarea.Name = "dtpFechaVencimientoTarea";
            this.dtpFechaVencimientoTarea.Size = new System.Drawing.Size(285, 20);
            this.dtpFechaVencimientoTarea.TabIndex = 25;
            // 
            // lblFechaVencimientoTarea
            // 
            this.lblFechaVencimientoTarea.AutoSize = true;
            this.lblFechaVencimientoTarea.Depth = 0;
            this.lblFechaVencimientoTarea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaVencimientoTarea.Location = new System.Drawing.Point(37, 441);
            this.lblFechaVencimientoTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaVencimientoTarea.Name = "lblFechaVencimientoTarea";
            this.lblFechaVencimientoTarea.Size = new System.Drawing.Size(163, 19);
            this.lblFechaVencimientoTarea.TabIndex = 24;
            this.lblFechaVencimientoTarea.Text = "Fecha de venciemiento";
            // 
            // cboIdUsuarioTarea
            // 
            this.cboIdUsuarioTarea.AutoResize = false;
            this.cboIdUsuarioTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboIdUsuarioTarea.Depth = 0;
            this.cboIdUsuarioTarea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboIdUsuarioTarea.DropDownHeight = 174;
            this.cboIdUsuarioTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdUsuarioTarea.DropDownWidth = 121;
            this.cboIdUsuarioTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboIdUsuarioTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboIdUsuarioTarea.FormattingEnabled = true;
            this.cboIdUsuarioTarea.IntegralHeight = false;
            this.cboIdUsuarioTarea.ItemHeight = 43;
            this.cboIdUsuarioTarea.Location = new System.Drawing.Point(40, 305);
            this.cboIdUsuarioTarea.MaxDropDownItems = 4;
            this.cboIdUsuarioTarea.MouseState = MaterialSkin.MouseState.OUT;
            this.cboIdUsuarioTarea.Name = "cboIdUsuarioTarea";
            this.cboIdUsuarioTarea.Size = new System.Drawing.Size(285, 49);
            this.cboIdUsuarioTarea.StartIndex = 0;
            this.cboIdUsuarioTarea.TabIndex = 27;
            // 
            // lblIdUsuarioTarea
            // 
            this.lblIdUsuarioTarea.AutoSize = true;
            this.lblIdUsuarioTarea.Depth = 0;
            this.lblIdUsuarioTarea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdUsuarioTarea.Location = new System.Drawing.Point(37, 283);
            this.lblIdUsuarioTarea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdUsuarioTarea.Name = "lblIdUsuarioTarea";
            this.lblIdUsuarioTarea.Size = new System.Drawing.Size(71, 19);
            this.lblIdUsuarioTarea.TabIndex = 26;
            this.lblIdUsuarioTarea.Text = "Id usuario";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = false;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.HighEmphasis = true;
            this.btnCerrarSesion.Icon = null;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1057, 495);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesion.Size = new System.Drawing.Size(159, 50);
            this.btnCerrarSesion.TabIndex = 28;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesion.UseAccentColor = false;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmGestorTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 591);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.cboIdUsuarioTarea);
            this.Controls.Add(this.lblIdUsuarioTarea);
            this.Controls.Add(this.dtpFechaVencimientoTarea);
            this.Controls.Add(this.lblFechaVencimientoTarea);
            this.Controls.Add(this.btnEditarTarea);
            this.Controls.Add(this.cboIdCategoriaTarea);
            this.Controls.Add(this.lblIdCategoriaTarea);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.dtgGestorTareas);
            this.Controls.Add(this.cboIdEstadoTarea);
            this.Controls.Add(this.lblIdEstadoTarea);
            this.Controls.Add(this.lblDescripcionTarea);
            this.Controls.Add(this.lblTituloTarea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.lblGestorTareas);
            this.Controls.Add(this.txtDescripcionTarea);
            this.Controls.Add(this.txtTituloTarea);
            this.Name = "frmGestorTareas";
            this.Text = "Gestor de tareas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGestorTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnAgregarTarea;
        private MaterialSkin.Controls.MaterialLabel lblGestorTareas;
        private System.Windows.Forms.DataGridView dtgGestorTareas;
        private MaterialSkin.Controls.MaterialButton btnCategorias;
        private MaterialSkin.Controls.MaterialTextBox txtTituloTarea;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcionTarea;
        private MaterialSkin.Controls.MaterialLabel lblTituloTarea;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionTarea;
        private MaterialSkin.Controls.MaterialLabel lblIdEstadoTarea;
        private MaterialSkin.Controls.MaterialComboBox cboIdEstadoTarea;
        private MaterialSkin.Controls.MaterialComboBox cboIdCategoriaTarea;
        private MaterialSkin.Controls.MaterialLabel lblIdCategoriaTarea;
        private MaterialSkin.Controls.MaterialButton btnEditarTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimientoTarea;
        private MaterialSkin.Controls.MaterialLabel lblFechaVencimientoTarea;
        private MaterialSkin.Controls.MaterialComboBox cboIdUsuarioTarea;
        private MaterialSkin.Controls.MaterialLabel lblIdUsuarioTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoTarea;
        private System.Windows.Forms.DataGridViewButtonColumn borrarTarea;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
    }
}