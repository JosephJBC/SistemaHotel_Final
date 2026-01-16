namespace Visual_
{
    partial class frmReserv
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
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpHabitacion = new System.Windows.Forms.GroupBox();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.lblFechaLLegada = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.dtpLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numNinos = new System.Windows.Forms.NumericUpDown();
            this.numAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblNinos = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.grpServicios = new System.Windows.Forms.GroupBox();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.grpReserva.SuspendLayout();
            this.grpHabitacion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).BeginInit();
            this.grpServicios.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReserva
            // 
            this.grpReserva.Controls.Add(this.txtCorreo);
            this.grpReserva.Controls.Add(this.lblCorreo);
            this.grpReserva.Controls.Add(this.txtNacionalidad);
            this.grpReserva.Controls.Add(this.txtTelefono);
            this.grpReserva.Controls.Add(this.txtCi);
            this.grpReserva.Controls.Add(this.txtNombre);
            this.grpReserva.Controls.Add(this.lblNacionalidad);
            this.grpReserva.Controls.Add(this.lblTelefono);
            this.grpReserva.Controls.Add(this.lblCi);
            this.grpReserva.Controls.Add(this.lblNombre);
            this.grpReserva.Location = new System.Drawing.Point(12, 23);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Size = new System.Drawing.Size(758, 117);
            this.grpReserva.TabIndex = 0;
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "Informacion de Reserva";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(381, 27);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(367, 27);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(308, 27);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 20);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(648, 81);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 27);
            this.txtNacionalidad.TabIndex = 7;
            this.txtNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(381, 84);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 27);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCi_KeyPress);
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(50, 84);
            this.txtCi.MaxLength = 9;
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(100, 27);
            this.txtCi.TabIndex = 5;
            this.txtCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCi_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 27);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(540, 84);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(101, 20);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(304, 84);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 20);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(15, 84);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(28, 20);
            this.lblCi.TabIndex = 1;
            this.lblCi.Text = "C.I:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // grpHabitacion
            // 
            this.grpHabitacion.Controls.Add(this.cmbHabitacion);
            this.grpHabitacion.Location = new System.Drawing.Point(12, 159);
            this.grpHabitacion.Name = "grpHabitacion";
            this.grpHabitacion.Size = new System.Drawing.Size(758, 112);
            this.grpHabitacion.TabIndex = 1;
            this.grpHabitacion.TabStop = false;
            this.grpHabitacion.Text = "Habitacion Seleccionada";
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(40, 50);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(685, 28);
            this.cmbHabitacion.TabIndex = 0;
            this.cmbHabitacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFechaLLegada
            // 
            this.lblFechaLLegada.AutoSize = true;
            this.lblFechaLLegada.Location = new System.Drawing.Point(13, 312);
            this.lblFechaLLegada.Name = "lblFechaLLegada";
            this.lblFechaLLegada.Size = new System.Drawing.Size(125, 20);
            this.lblFechaLLegada.TabIndex = 2;
            this.lblFechaLLegada.Text = "Fecha de llegada:";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(12, 413);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(114, 20);
            this.lblFechaSalida.TabIndex = 3;
            this.lblFechaSalida.Text = "Fecha de salida:";
            // 
            // dtpLlegada
            // 
            this.dtpLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLlegada.Location = new System.Drawing.Point(164, 307);
            this.dtpLlegada.Name = "dtpLlegada";
            this.dtpLlegada.Size = new System.Drawing.Size(200, 27);
            this.dtpLlegada.TabIndex = 4;
            this.dtpLlegada.ValueChanged += new System.EventHandler(this.dtpLlegada_ValueChanged);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(164, 406);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 27);
            this.dtpSalida.TabIndex = 5;
            this.dtpSalida.ValueChanged += new System.EventHandler(this.dtpSalida_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numNinos);
            this.groupBox3.Controls.Add(this.numAdultos);
            this.groupBox3.Controls.Add(this.lblNinos);
            this.groupBox3.Controls.Add(this.lblAdulto);
            this.groupBox3.Location = new System.Drawing.Point(486, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 155);
            this.groupBox3.TabIndex = 6;
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
            this.numNinos.Size = new System.Drawing.Size(120, 27);
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
            this.numAdultos.Size = new System.Drawing.Size(120, 27);
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
            this.lblNinos.Size = new System.Drawing.Size(50, 20);
            this.lblNinos.TabIndex = 1;
            this.lblNinos.Text = "Niños:";
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Location = new System.Drawing.Point(7, 27);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(63, 20);
            this.lblAdulto.TabIndex = 0;
            this.lblAdulto.Text = "Adultos:";
            // 
            // grpServicios
            // 
            this.grpServicios.Controls.Add(this.cmbServicios);
            this.grpServicios.Location = new System.Drawing.Point(16, 461);
            this.grpServicios.Name = "grpServicios";
            this.grpServicios.Size = new System.Drawing.Size(754, 124);
            this.grpServicios.TabIndex = 7;
            this.grpServicios.TabStop = false;
            this.grpServicios.Text = "Servicios Adicionales";
            // 
            // cmbServicios
            // 
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(36, 59);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(685, 28);
            this.cmbServicios.TabIndex = 0;
            this.cmbServicios.SelectedIndexChanged += new System.EventHandler(this.cmbServicios_SelectedIndexChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(304, 754);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(185, 43);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "CONFIRMAR RESERVA";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.txtContenido);
            this.grpRegistro.Location = new System.Drawing.Point(17, 591);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(753, 157);
            this.grpRegistro.TabIndex = 12;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registro Reserva";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(14, 27);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ReadOnly = true;
            this.txtContenido.Size = new System.Drawing.Size(729, 124);
            this.txtContenido.TabIndex = 0;
            // 
            // frmReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 809);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpServicios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpLlegada);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblFechaLLegada);
            this.Controls.Add(this.grpHabitacion);
            this.Controls.Add(this.grpReserva);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmReserv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Reserva";
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            this.grpHabitacion.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).EndInit();
            this.grpServicios.ResumeLayout(false);
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpHabitacion;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Label lblFechaLLegada;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpLlegada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numAdultos;
        private System.Windows.Forms.Label lblNinos;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.NumericUpDown numNinos;
        private System.Windows.Forms.GroupBox grpServicios;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.TextBox txtContenido;
    }
}