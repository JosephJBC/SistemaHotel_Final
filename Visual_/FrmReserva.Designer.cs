namespace Visual_
{
    partial class FrmReserva
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
            this.lblInfoHuesped = new System.Windows.Forms.GroupBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInfoHabitacion = new System.Windows.Forms.GroupBox();
            this.cmbSeleccion = new System.Windows.Forms.ComboBox();
            this.lblLlegada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblOcupantes = new System.Windows.Forms.GroupBox();
            this.numNinos = new System.Windows.Forms.NumericUpDown();
            this.lblNinos = new System.Windows.Forms.Label();
            this.numAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblInfoServicio = new System.Windows.Forms.GroupBox();
            this.cmbAdicionales = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblInfoHuesped.SuspendLayout();
            this.lblInfoHabitacion.SuspendLayout();
            this.lblOcupantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).BeginInit();
            this.lblInfoServicio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoHuesped
            // 
            this.lblInfoHuesped.Controls.Add(this.lblNacionalidad);
            this.lblInfoHuesped.Controls.Add(this.lblTelefono);
            this.lblInfoHuesped.Controls.Add(this.lblCi);
            this.lblInfoHuesped.Controls.Add(this.lblNombre);
            this.lblInfoHuesped.Location = new System.Drawing.Point(12, 24);
            this.lblInfoHuesped.Name = "lblInfoHuesped";
            this.lblInfoHuesped.Size = new System.Drawing.Size(758, 85);
            this.lblInfoHuesped.TabIndex = 0;
            this.lblInfoHuesped.TabStop = false;
            this.lblInfoHuesped.Text = "Información del Huesped";
            this.lblInfoHuesped.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(500, 62);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(105, 20);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(231, 62);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 20);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono: ";
            this.lblTelefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(25, 62);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(32, 20);
            this.lblCi.TabIndex = 1;
            this.lblCi.Text = "C.l: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInfoHabitacion
            // 
            this.lblInfoHabitacion.Controls.Add(this.cmbSeleccion);
            this.lblInfoHabitacion.Location = new System.Drawing.Point(12, 130);
            this.lblInfoHabitacion.Name = "lblInfoHabitacion";
            this.lblInfoHabitacion.Size = new System.Drawing.Size(758, 74);
            this.lblInfoHabitacion.TabIndex = 1;
            this.lblInfoHabitacion.TabStop = false;
            this.lblInfoHabitacion.Text = "Habitación Seleccionada";
            // 
            // cmbSeleccion
            // 
            this.cmbSeleccion.FormattingEnabled = true;
            this.cmbSeleccion.Location = new System.Drawing.Point(6, 26);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(715, 28);
            this.cmbSeleccion.TabIndex = 0;
            this.cmbSeleccion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLlegada
            // 
            this.lblLlegada.AutoSize = true;
            this.lblLlegada.Location = new System.Drawing.Point(14, 226);
            this.lblLlegada.Name = "lblLlegada";
            this.lblLlegada.Size = new System.Drawing.Size(128, 20);
            this.lblLlegada.TabIndex = 2;
            this.lblLlegada.Text = "Fecha de Llegada:";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(14, 341);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(116, 20);
            this.lblSalida.TabIndex = 3;
            this.lblSalida.Text = "Fecha de Salida:";
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLlegada.Location = new System.Drawing.Point(148, 226);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(200, 27);
            this.dtpLlegada.TabIndex = 4;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(148, 341);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 27);
            this.dtpSalida.TabIndex = 5;
            // 
            // lblOcupantes
            // 
            this.lblOcupantes.Controls.Add(this.numNinos);
            this.lblOcupantes.Controls.Add(this.lblNinos);
            this.lblOcupantes.Controls.Add(this.numAdultos);
            this.lblOcupantes.Controls.Add(this.lblAdultos);
            this.lblOcupantes.Location = new System.Drawing.Point(430, 210);
            this.lblOcupantes.Name = "lblOcupantes";
            this.lblOcupantes.Size = new System.Drawing.Size(303, 158);
            this.lblOcupantes.TabIndex = 6;
            this.lblOcupantes.TabStop = false;
            this.lblOcupantes.Text = "Ocupantes";
            // 
            // numNinos
            // 
            this.numNinos.Location = new System.Drawing.Point(14, 120);
            this.numNinos.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNinos.Name = "numNinos";
            this.numNinos.Size = new System.Drawing.Size(120, 27);
            this.numNinos.TabIndex = 3;
            // 
            // lblNinos
            // 
            this.lblNinos.AutoSize = true;
            this.lblNinos.Location = new System.Drawing.Point(10, 97);
            this.lblNinos.Name = "lblNinos";
            this.lblNinos.Size = new System.Drawing.Size(50, 20);
            this.lblNinos.TabIndex = 2;
            this.lblNinos.Text = "Niños:";
            // 
            // numAdultos
            // 
            this.numAdultos.Location = new System.Drawing.Point(10, 47);
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
            this.numAdultos.Size = new System.Drawing.Size(120, 27);
            this.numAdultos.TabIndex = 1;
            this.numAdultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(6, 23);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(63, 20);
            this.lblAdultos.TabIndex = 0;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblInfoServicio
            // 
            this.lblInfoServicio.Controls.Add(this.cmbAdicionales);
            this.lblInfoServicio.Location = new System.Drawing.Point(18, 390);
            this.lblInfoServicio.Name = "lblInfoServicio";
            this.lblInfoServicio.Size = new System.Drawing.Size(752, 73);
            this.lblInfoServicio.TabIndex = 7;
            this.lblInfoServicio.TabStop = false;
            this.lblInfoServicio.Text = "Servicios Adicionales";
            // 
            // cmbAdicionales
            // 
            this.cmbAdicionales.FormattingEnabled = true;
            this.cmbAdicionales.Location = new System.Drawing.Point(6, 26);
            this.cmbAdicionales.Name = "cmbAdicionales";
            this.cmbAdicionales.Size = new System.Drawing.Size(715, 28);
            this.cmbAdicionales.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblIva);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Location = new System.Drawing.Point(18, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 119);
            this.panel1.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(31, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(31, 49);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(85, 20);
            this.lblIva.TabIndex = 1;
            this.lblIva.Text = "IVA (12%):";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(31, 12);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(72, 20);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Location = new System.Drawing.Point(294, 619);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(196, 34);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "CONFIRMAR RESERVA";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 665);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInfoServicio);
            this.Controls.Add(this.lblOcupantes);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblLlegada);
            this.Controls.Add(this.lblInfoHabitacion);
            this.Controls.Add(this.lblInfoHuesped);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario de reserva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblInfoHuesped.ResumeLayout(false);
            this.lblInfoHuesped.PerformLayout();
            this.lblInfoHabitacion.ResumeLayout(false);
            this.lblOcupantes.ResumeLayout(false);
            this.lblOcupantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).EndInit();
            this.lblInfoServicio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lblInfoHuesped;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.GroupBox lblInfoHabitacion;
        private System.Windows.Forms.ComboBox cmbSeleccion;
        private System.Windows.Forms.Label lblLlegada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.GroupBox lblOcupantes;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.NumericUpDown numNinos;
        private System.Windows.Forms.Label lblNinos;
        private System.Windows.Forms.NumericUpDown numAdultos;
        private System.Windows.Forms.GroupBox lblInfoServicio;
        private System.Windows.Forms.ComboBox cmbAdicionales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

