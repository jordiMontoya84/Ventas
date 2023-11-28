namespace Ventas
{
    partial class frmVenta
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cRUDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sucursalProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuPuntoVenta1 = new Ventas.cuPuntoVenta();
			this.cuProveedorSucursal1 = new Ventas.cuProveedorSucursal();
			this.cuProducto1 = new Ventas.cuProducto();
			this.cuCliente1 = new Ventas.cuCliente();
			this.cuCategoria1 = new Ventas.cuCategoria();
			this.cuEmpleado1 = new Ventas.cuEmpleado();
			this.cuTurno1 = new Ventas.cuTurno();
			this.cuCrudCargos1 = new Ventas.cuCrudCargos();
			this.cuCrudSucursal1 = new Ventas.cuCrudSucursal();
			this.cuProveedor1 = new Ventas.cuProveedor();
			this.cuVentas1 = new Ventas.cuVentas();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDsToolStripMenuItem,
            this.ventasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cRUDsToolStripMenuItem
			// 
			this.cRUDsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem,
            this.sucursalToolStripMenuItem,
            this.cargoToolStripMenuItem,
            this.turnoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.sucursalProveedorToolStripMenuItem});
			this.cRUDsToolStripMenuItem.Name = "cRUDsToolStripMenuItem";
			this.cRUDsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.cRUDsToolStripMenuItem.Text = "CRUDs";
			// 
			// proveedorToolStripMenuItem
			// 
			this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
			this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.proveedorToolStripMenuItem.Text = "Proveedor";
			this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
			// 
			// sucursalToolStripMenuItem
			// 
			this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
			this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.sucursalToolStripMenuItem.Text = "Sucursal";
			this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
			// 
			// cargoToolStripMenuItem
			// 
			this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
			this.cargoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.cargoToolStripMenuItem.Text = "Cargo";
			this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
			// 
			// turnoToolStripMenuItem
			// 
			this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
			this.turnoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.turnoToolStripMenuItem.Text = "Turno";
			this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
			// 
			// empleadoToolStripMenuItem
			// 
			this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
			this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.empleadoToolStripMenuItem.Text = "Empleado";
			this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
			// 
			// categoriaToolStripMenuItem
			// 
			this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
			this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.categoriaToolStripMenuItem.Text = "Categoria";
			this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
			// 
			// clienteToolStripMenuItem
			// 
			this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
			this.clienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.clienteToolStripMenuItem.Text = "Cliente";
			this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
			// 
			// productoToolStripMenuItem
			// 
			this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
			this.productoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.productoToolStripMenuItem.Text = "Producto";
			this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
			// 
			// sucursalProveedorToolStripMenuItem
			// 
			this.sucursalProveedorToolStripMenuItem.Name = "sucursalProveedorToolStripMenuItem";
			this.sucursalProveedorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.sucursalProveedorToolStripMenuItem.Text = "Sucursal-Proveedor";
			this.sucursalProveedorToolStripMenuItem.Click += new System.EventHandler(this.sucursalProveedorToolStripMenuItem_Click);
			// 
			// ventasToolStripMenuItem
			// 
			this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.listaVentasToolStripMenuItem});
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ventasToolStripMenuItem.Text = "Ventas";
			// 
			// nuevaVentaToolStripMenuItem
			// 
			this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
			this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
			this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
			// 
			// listaVentasToolStripMenuItem
			// 
			this.listaVentasToolStripMenuItem.Name = "listaVentasToolStripMenuItem";
			this.listaVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.listaVentasToolStripMenuItem.Text = "Lista Ventas";
			this.listaVentasToolStripMenuItem.Click += new System.EventHandler(this.listaVentasToolStripMenuItem_Click);
			// 
			// cuPuntoVenta1
			// 
			this.cuPuntoVenta1.Location = new System.Drawing.Point(28, 27);
			this.cuPuntoVenta1.Name = "cuPuntoVenta1";
			this.cuPuntoVenta1.Size = new System.Drawing.Size(738, 430);
			this.cuPuntoVenta1.TabIndex = 10;
			// 
			// cuProveedorSucursal1
			// 
			this.cuProveedorSucursal1.Location = new System.Drawing.Point(28, 27);
			this.cuProveedorSucursal1.Name = "cuProveedorSucursal1";
			this.cuProveedorSucursal1.Size = new System.Drawing.Size(738, 430);
			this.cuProveedorSucursal1.TabIndex = 9;
			// 
			// cuProducto1
			// 
			this.cuProducto1.Location = new System.Drawing.Point(28, 27);
			this.cuProducto1.Name = "cuProducto1";
			this.cuProducto1.Size = new System.Drawing.Size(738, 430);
			this.cuProducto1.TabIndex = 8;
			// 
			// cuCliente1
			// 
			this.cuCliente1.Location = new System.Drawing.Point(28, 27);
			this.cuCliente1.Name = "cuCliente1";
			this.cuCliente1.Size = new System.Drawing.Size(738, 430);
			this.cuCliente1.TabIndex = 7;
			// 
			// cuCategoria1
			// 
			this.cuCategoria1.Location = new System.Drawing.Point(28, 27);
			this.cuCategoria1.Name = "cuCategoria1";
			this.cuCategoria1.Size = new System.Drawing.Size(738, 430);
			this.cuCategoria1.TabIndex = 6;
			// 
			// cuEmpleado1
			// 
			this.cuEmpleado1.Location = new System.Drawing.Point(28, 27);
			this.cuEmpleado1.Name = "cuEmpleado1";
			this.cuEmpleado1.Size = new System.Drawing.Size(738, 430);
			this.cuEmpleado1.TabIndex = 5;
			// 
			// cuTurno1
			// 
			this.cuTurno1.Location = new System.Drawing.Point(28, 27);
			this.cuTurno1.Name = "cuTurno1";
			this.cuTurno1.Size = new System.Drawing.Size(738, 430);
			this.cuTurno1.TabIndex = 4;
			// 
			// cuCrudCargos1
			// 
			this.cuCrudCargos1.Location = new System.Drawing.Point(28, 27);
			this.cuCrudCargos1.Name = "cuCrudCargos1";
			this.cuCrudCargos1.Size = new System.Drawing.Size(738, 430);
			this.cuCrudCargos1.TabIndex = 3;
			// 
			// cuCrudSucursal1
			// 
			this.cuCrudSucursal1.Location = new System.Drawing.Point(28, 27);
			this.cuCrudSucursal1.Name = "cuCrudSucursal1";
			this.cuCrudSucursal1.Size = new System.Drawing.Size(738, 430);
			this.cuCrudSucursal1.TabIndex = 2;
			// 
			// cuProveedor1
			// 
			this.cuProveedor1.Location = new System.Drawing.Point(28, 27);
			this.cuProveedor1.Name = "cuProveedor1";
			this.cuProveedor1.Size = new System.Drawing.Size(738, 430);
			this.cuProveedor1.TabIndex = 0;
			// 
			// cuVentas1
			// 
			this.cuVentas1.Location = new System.Drawing.Point(28, 27);
			this.cuVentas1.Name = "cuVentas1";
			this.cuVentas1.Size = new System.Drawing.Size(738, 430);
			this.cuVentas1.TabIndex = 11;
			// 
			// frmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 463);
			this.Controls.Add(this.cuVentas1);
			this.Controls.Add(this.cuPuntoVenta1);
			this.Controls.Add(this.cuProveedorSucursal1);
			this.Controls.Add(this.cuProducto1);
			this.Controls.Add(this.cuCliente1);
			this.Controls.Add(this.cuCategoria1);
			this.Controls.Add(this.cuEmpleado1);
			this.Controls.Add(this.cuTurno1);
			this.Controls.Add(this.cuCrudCargos1);
			this.Controls.Add(this.cuCrudSucursal1);
			this.Controls.Add(this.cuProveedor1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmVenta";
			this.Text = "Ventas";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVenta_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private cuProveedor cuProveedor1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private cuCrudSucursal cuCrudSucursal1;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private cuCrudCargos cuCrudCargos1;
		private cuTurno cuTurno1;
		private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
		private cuEmpleado cuEmpleado1;
		private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
		private cuCategoria cuCategoria1;
		private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
		private cuCliente cuCliente1;
		private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
		private cuProducto cuProducto1;
		private System.Windows.Forms.ToolStripMenuItem sucursalProveedorToolStripMenuItem;
		private cuProveedorSucursal cuProveedorSucursal1;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
		private cuPuntoVenta cuPuntoVenta1;
		private System.Windows.Forms.ToolStripMenuItem listaVentasToolStripMenuItem;
		private cuVentas cuVentas1;
	}
}

