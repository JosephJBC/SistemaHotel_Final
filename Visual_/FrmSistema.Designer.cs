namespace Visual_
{
    partial class FrmSistema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistema));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasXNacionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinamicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceraDe = new System.Windows.Forms.Button();
            this.imageList6 = new System.Windows.Forms.ImageList(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.imageList5 = new System.Windows.Forms.ImageList(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnListar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnDinamico = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRegistrar,
            this.listarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // mniRegistrar
            // 
            this.mniRegistrar.Name = "mniRegistrar";
            this.mniRegistrar.Size = new System.Drawing.Size(224, 26);
            this.mniRegistrar.Text = "Registar";
            this.mniRegistrar.Click += new System.EventHandler(this.mniRegistrar_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasXNacionalidadToolStripMenuItem,
            this.listarXToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // listasXNacionalidadToolStripMenuItem
            // 
            this.listasXNacionalidadToolStripMenuItem.Name = "listasXNacionalidadToolStripMenuItem";
            this.listasXNacionalidadToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listasXNacionalidadToolStripMenuItem.Text = "Listar X Nacionalidad";
            // 
            // listarXToolStripMenuItem
            // 
            this.listarXToolStripMenuItem.Name = "listarXToolStripMenuItem";
            this.listarXToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listarXToolStripMenuItem.Text = "Listar X Habitacion";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auotToolStripMenuItem,
            this.conexionToolStripMenuItem,
            this.dinamicoToolStripMenuItem});
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de";
            // 
            // auotToolStripMenuItem
            // 
            this.auotToolStripMenuItem.Name = "auotToolStripMenuItem";
            this.auotToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.auotToolStripMenuItem.Text = "Autor";
            this.auotToolStripMenuItem.Click += new System.EventHandler(this.auotToolStripMenuItem_Click);
            // 
            // conexionToolStripMenuItem
            // 
            this.conexionToolStripMenuItem.Name = "conexionToolStripMenuItem";
            this.conexionToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.conexionToolStripMenuItem.Text = "Conexion";
            this.conexionToolStripMenuItem.Click += new System.EventHandler(this.conexionToolStripMenuItem_Click);
            // 
            // dinamicoToolStripMenuItem
            // 
            this.dinamicoToolStripMenuItem.Name = "dinamicoToolStripMenuItem";
            this.dinamicoToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.dinamicoToolStripMenuItem.Text = "Dinamico";
            this.dinamicoToolStripMenuItem.Click += new System.EventHandler(this.dinamicoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnAceraDe);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 609);
            this.panel1.TabIndex = 2;
            // 
            // btnAceraDe
            // 
            this.btnAceraDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceraDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceraDe.FlatAppearance.BorderSize = 0;
            this.btnAceraDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceraDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceraDe.ForeColor = System.Drawing.Color.White;
            this.btnAceraDe.ImageKey = "informacion.png";
            this.btnAceraDe.ImageList = this.imageList6;
            this.btnAceraDe.Location = new System.Drawing.Point(22, 497);
            this.btnAceraDe.Name = "btnAceraDe";
            this.btnAceraDe.Size = new System.Drawing.Size(165, 50);
            this.btnAceraDe.TabIndex = 7;
            this.btnAceraDe.Text = "Acerda de";
            this.btnAceraDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceraDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceraDe.UseVisualStyleBackColor = false;
            this.btnAceraDe.Click += new System.EventHandler(this.btnAceraDe_Click);
            // 
            // imageList6
            // 
            this.imageList6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList6.ImageStream")));
            this.imageList6.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList6.Images.SetKeyName(0, "informacion.png");
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.ImageKey = "cerrar-sesion.png";
            this.btnSalir.ImageList = this.imageList5;
            this.btnSalir.Location = new System.Drawing.Point(22, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imageList5
            // 
            this.imageList5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList5.ImageStream")));
            this.imageList5.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList5.Images.SetKeyName(0, "cerrar-sesion.png");
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageKey = "editar.png";
            this.btnEditar.ImageList = this.imageList4;
            this.btnEditar.Location = new System.Drawing.Point(22, 319);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(165, 50);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "editar.png");
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageKey = "borrar.png";
            this.btnEliminar.ImageList = this.imageList3;
            this.btnEliminar.Location = new System.Drawing.Point(22, 225);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "borrar.png");
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.ImageKey = "lista.png";
            this.btnListar.ImageList = this.imageList2;
            this.btnListar.Location = new System.Drawing.Point(22, 128);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(165, 50);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "lista.png");
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.ImageIndex = 0;
            this.btnRegistrar.ImageList = this.imageList1;
            this.btnRegistrar.Location = new System.Drawing.Point(22, 41);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRegistrar.Size = new System.Drawing.Size(165, 50);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agregar-usuario.png");
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlSubMenu.Controls.Add(this.btnDinamico);
            this.pnlSubMenu.Controls.Add(this.btnConexion);
            this.pnlSubMenu.Controls.Add(this.btnAutor);
            this.pnlSubMenu.Location = new System.Drawing.Point(226, 484);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(434, 100);
            this.pnlSubMenu.TabIndex = 3;
            this.pnlSubMenu.Visible = false;
            // 
            // btnDinamico
            // 
            this.btnDinamico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDinamico.FlatAppearance.BorderSize = 0;
            this.btnDinamico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinamico.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinamico.ForeColor = System.Drawing.Color.White;
            this.btnDinamico.Location = new System.Drawing.Point(269, 25);
            this.btnDinamico.Name = "btnDinamico";
            this.btnDinamico.Size = new System.Drawing.Size(149, 50);
            this.btnDinamico.TabIndex = 4;
            this.btnDinamico.Text = "Info Dinamico";
            this.btnDinamico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinamico.UseVisualStyleBackColor = false;
            this.btnDinamico.Click += new System.EventHandler(this.btnDinamico_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.ForeColor = System.Drawing.Color.White;
            this.btnConexion.Location = new System.Drawing.Point(141, 25);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(105, 50);
            this.btnConexion.TabIndex = 4;
            this.btnConexion.Text = "Conexion";
            this.btnConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAutor.FlatAppearance.BorderSize = 0;
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.Color.White;
            this.btnAutor.Location = new System.Drawing.Point(41, 25);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(83, 50);
            this.btnAutor.TabIndex = 4;
            this.btnAutor.Text = "Autor";
            this.btnAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // FrmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema_de_Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSistema_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniRegistrar;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasXNacionalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinamicoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceraDe;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Button btnDinamico;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.ImageList imageList5;
        private System.Windows.Forms.ImageList imageList6;
    }
}