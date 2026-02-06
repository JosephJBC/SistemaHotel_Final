namespace Visual_
{
    partial class FrmEditarReserva
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
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbCedula = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numNinos = new System.Windows.Forms.NumericUpDown();
            this.numAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblNinos = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblFechaLLegada = new System.Windows.Forms.Label();
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedu = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).BeginInit();
            this.grpReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colNombres,
            this.colCi,
            this.colTelefono,
            this.colCorreo,
            this.colNacionalidad,
            this.colHabitacion,
            this.colReserva,
            this.colLlegada,
            this.colSalida,
            this.colAdultos,
            this.colNinos,
            this.collServicios,
            this.colSubTotal,
            this.ColIva,
            this.colTotal});
            this.dgvReserva.Location = new System.Drawing.Point(22, 131);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.RowHeadersWidth = 51;
            this.dgvReserva.RowTemplate.Height = 24;
            this.dgvReserva.Size = new System.Drawing.Size(1299, 150);
            this.dgvReserva.TabIndex = 1;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro.";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Width = 125;
            // 
            // colNombres
            // 
            this.colNombres.HeaderText = "Nombre";
            this.colNombres.MinimumWidth = 6;
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            this.colNombres.Width = 125;
            // 
            // colCi
            // 
            this.colCi.HeaderText = "CI";
            this.colCi.MinimumWidth = 6;
            this.colCi.Name = "colCi";
            this.colCi.ReadOnly = true;
            this.colCi.Width = 125;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 125;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 125;
            // 
            // colNacionalidad
            // 
            this.colNacionalidad.HeaderText = "Nacionalidad";
            this.colNacionalidad.MinimumWidth = 6;
            this.colNacionalidad.Name = "colNacionalidad";
            this.colNacionalidad.ReadOnly = true;
            this.colNacionalidad.Width = 125;
            // 
            // colHabitacion
            // 
            this.colHabitacion.HeaderText = "Habitacion";
            this.colHabitacion.MinimumWidth = 6;
            this.colHabitacion.Name = "colHabitacion";
            this.colHabitacion.ReadOnly = true;
            this.colHabitacion.Width = 125;
            // 
            // colReserva
            // 
            this.colReserva.HeaderText = "Reserva";
            this.colReserva.MinimumWidth = 6;
            this.colReserva.Name = "colReserva";
            this.colReserva.ReadOnly = true;
            this.colReserva.Width = 125;
            // 
            // colLlegada
            // 
            this.colLlegada.HeaderText = "Llegada";
            this.colLlegada.MinimumWidth = 6;
            this.colLlegada.Name = "colLlegada";
            this.colLlegada.ReadOnly = true;
            this.colLlegada.Width = 125;
            // 
            // colSalida
            // 
            this.colSalida.HeaderText = "Salida";
            this.colSalida.MinimumWidth = 6;
            this.colSalida.Name = "colSalida";
            this.colSalida.ReadOnly = true;
            this.colSalida.Width = 125;
            // 
            // colAdultos
            // 
            this.colAdultos.HeaderText = "Adultos";
            this.colAdultos.MinimumWidth = 6;
            this.colAdultos.Name = "colAdultos";
            this.colAdultos.ReadOnly = true;
            this.colAdultos.Width = 125;
            // 
            // colNinos
            // 
            this.colNinos.HeaderText = "Niños";
            this.colNinos.MinimumWidth = 6;
            this.colNinos.Name = "colNinos";
            this.colNinos.ReadOnly = true;
            this.colNinos.Width = 125;
            // 
            // collServicios
            // 
            this.collServicios.HeaderText = "Servicios";
            this.collServicios.MinimumWidth = 6;
            this.collServicios.Name = "collServicios";
            this.collServicios.ReadOnly = true;
            this.collServicios.Width = 125;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "subTotal";
            this.colSubTotal.MinimumWidth = 6;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 125;
            // 
            // ColIva
            // 
            this.ColIva.HeaderText = "Iva";
            this.ColIva.MinimumWidth = 6;
            this.ColIva.Name = "ColIva";
            this.ColIva.ReadOnly = true;
            this.ColIva.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "C.I:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(315, 48);
            this.txtCi.MaxLength = 9;
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(176, 22);
            this.txtCi.TabIndex = 6;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(598, 51);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(77, 20);
            this.rdbNombre.TabIndex = 7;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rdbCedula
            // 
            this.rdbCedula.AutoSize = true;
            this.rdbCedula.Location = new System.Drawing.Point(598, 88);
            this.rdbCedula.Name = "rdbCedula";
            this.rdbCedula.Size = new System.Drawing.Size(43, 20);
            this.rdbCedula.TabIndex = 8;
            this.rdbCedula.TabStop = true;
            this.rdbCedula.Text = "C.I";
            this.rdbCedula.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(735, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(645, 305);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(611, 711);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(185, 43);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "CONFIRMAR ";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numNinos);
            this.groupBox3.Controls.Add(this.numAdultos);
            this.groupBox3.Controls.Add(this.lblNinos);
            this.groupBox3.Controls.Add(this.lblAdulto);
            this.groupBox3.Location = new System.Drawing.Point(795, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 155);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ocupante";
            // 
            // numNinos
            // 
            this.numNinos.Location = new System.Drawing.Point(11, 121);
            this.numNinos.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNinos.Name = "numNinos";
            this.numNinos.ReadOnly = true;
            this.numNinos.Size = new System.Drawing.Size(120, 22);
            this.numNinos.TabIndex = 3;
            // 
            // numAdultos
            // 
            this.numAdultos.Location = new System.Drawing.Point(11, 50);
            this.numAdultos.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdultos.Name = "numAdultos";
            this.numAdultos.ReadOnly = true;
            this.numAdultos.Size = new System.Drawing.Size(120, 22);
            this.numAdultos.TabIndex = 2;
            this.numAdultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNinos
            // 
            this.lblNinos.AutoSize = true;
            this.lblNinos.Location = new System.Drawing.Point(7, 98);
            this.lblNinos.Name = "lblNinos";
            this.lblNinos.Size = new System.Drawing.Size(45, 16);
            this.lblNinos.TabIndex = 1;
            this.lblNinos.Text = "Niños:";
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Location = new System.Drawing.Point(7, 27);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(55, 16);
            this.lblAdulto.TabIndex = 0;
            this.lblAdulto.Text = "Adultos:";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(441, 586);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 22);
            this.dtpSalida.TabIndex = 18;
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLlegada.Location = new System.Drawing.Point(441, 530);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(200, 22);
            this.dtpLlegada.TabIndex = 17;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(312, 586);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(107, 16);
            this.lblFechaSalida.TabIndex = 16;
            this.lblFechaSalida.Text = "Fecha de salida:";
            // 
            // lblFechaLLegada
            // 
            this.lblFechaLLegada.AutoSize = true;
            this.lblFechaLLegada.Location = new System.Drawing.Point(312, 536);
            this.lblFechaLLegada.Name = "lblFechaLLegada";
            this.lblFechaLLegada.Size = new System.Drawing.Size(116, 16);
            this.lblFechaLLegada.TabIndex = 15;
            this.lblFechaLLegada.Text = "Fecha de llegada:";
            // 
            // grpReserva
            // 
            this.grpReserva.Controls.Add(this.txtCorreo);
            this.grpReserva.Controls.Add(this.lblCorreo);
            this.grpReserva.Controls.Add(this.txtNacionalidad);
            this.grpReserva.Controls.Add(this.txtTelefono);
            this.grpReserva.Controls.Add(this.txtCedu);
            this.grpReserva.Controls.Add(this.txtNom);
            this.grpReserva.Controls.Add(this.lblNacionalidad);
            this.grpReserva.Controls.Add(this.lblTelefono);
            this.grpReserva.Controls.Add(this.lblCi);
            this.grpReserva.Controls.Add(this.lblNombre);
            this.grpReserva.Location = new System.Drawing.Point(315, 363);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Size = new System.Drawing.Size(758, 117);
            this.grpReserva.TabIndex = 13;
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "Informacion de Reserva";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(381, 27);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(367, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(278, 35);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 16);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(648, 81);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 22);
            this.txtNacionalidad.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(381, 84);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtCedu
            // 
            this.txtCedu.Location = new System.Drawing.Point(50, 84);
            this.txtCedu.MaxLength = 9;
            this.txtCedu.Name = "txtCedu";
            this.txtCedu.Size = new System.Drawing.Size(100, 22);
            this.txtCedu.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(89, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 4;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(540, 84);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(91, 16);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(304, 84);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(15, 84);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(25, 16);
            this.lblCi.TabIndex = 1;
            this.lblCi.Text = "C.I:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // FrmEditarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 768);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblFechaLLegada);
            this.Controls.Add(this.grpReserva);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rdbCedula);
            this.Controls.Add(this.rdbNombre);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReserva);
            this.MaximizeBox = false;
            this.Name = "FrmEditarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRegistrarReserva";
            this.Load += new System.EventHandler(this.FrmRegistrarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).EndInit();
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn collServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numNinos;
        private System.Windows.Forms.NumericUpDown numAdultos;
        private System.Windows.Forms.Label lblNinos;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblFechaLLegada;
        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedu;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.Label lblNombre;
    }
}