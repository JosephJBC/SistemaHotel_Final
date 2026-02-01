namespace Visual_
{
    partial class FrmEliminarReserva
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
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
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
            this.dgvReserva.Location = new System.Drawing.Point(12, 81);
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(648, 258);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmEliminarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 328);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvReserva);
            this.MaximizeBox = false;
            this.Name = "FrmEliminarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEliminarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnEliminar;
    }
}