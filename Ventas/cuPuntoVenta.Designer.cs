namespace Ventas
{
	partial class cuPuntoVenta
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

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.pArticulo = new System.Windows.Forms.Panel();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pNota = new System.Windows.Forms.Panel();
			this.cbCliente = new System.Windows.Forms.ComboBox();
			this.btnPagar = new System.Windows.Forms.Button();
			this.tbImporte = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvArticulos = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.pArticulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.pNota.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
			this.SuspendLayout();
			// 
			// pArticulo
			// 
			this.pArticulo.Controls.Add(this.nudCantidad);
			this.pArticulo.Controls.Add(this.label2);
			this.pArticulo.Controls.Add(this.tbCodigo);
			this.pArticulo.Controls.Add(this.label1);
			this.pArticulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pArticulo.Location = new System.Drawing.Point(0, 0);
			this.pArticulo.Name = "pArticulo";
			this.pArticulo.Size = new System.Drawing.Size(522, 61);
			this.pArticulo.TabIndex = 19;
			// 
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(389, 19);
			this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(44, 20);
			this.nudCantidad.TabIndex = 18;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(309, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Cantidad";
			// 
			// tbCodigo
			// 
			this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCodigo.Location = new System.Drawing.Point(126, 18);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(158, 22);
			this.tbCodigo.TabIndex = 16;
			this.tbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigo_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Codigo";
			// 
			// pNota
			// 
			this.pNota.Controls.Add(this.cbCliente);
			this.pNota.Controls.Add(this.btnPagar);
			this.pNota.Controls.Add(this.tbImporte);
			this.pNota.Controls.Add(this.label8);
			this.pNota.Controls.Add(this.label4);
			this.pNota.Dock = System.Windows.Forms.DockStyle.Right;
			this.pNota.Location = new System.Drawing.Point(522, 0);
			this.pNota.Name = "pNota";
			this.pNota.Size = new System.Drawing.Size(216, 430);
			this.pNota.TabIndex = 18;
			// 
			// cbCliente
			// 
			this.cbCliente.FormattingEnabled = true;
			this.cbCliente.Location = new System.Drawing.Point(56, 135);
			this.cbCliente.Name = "cbCliente";
			this.cbCliente.Size = new System.Drawing.Size(121, 21);
			this.cbCliente.TabIndex = 23;
			this.cbCliente.DropDown += new System.EventHandler(this.cbCliente_DropDown);
			// 
			// btnPagar
			// 
			this.btnPagar.Location = new System.Drawing.Point(76, 232);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.Size = new System.Drawing.Size(81, 42);
			this.btnPagar.TabIndex = 22;
			this.btnPagar.Text = "Pagar";
			this.btnPagar.UseVisualStyleBackColor = true;
			this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
			// 
			// tbImporte
			// 
			this.tbImporte.Enabled = false;
			this.tbImporte.Location = new System.Drawing.Point(56, 172);
			this.tbImporte.Name = "tbImporte";
			this.tbImporte.Size = new System.Drawing.Size(82, 20);
			this.tbImporte.TabIndex = 11;
			this.tbImporte.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(19, 172);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Total";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Cliente";
			// 
			// dgvArticulos
			// 
			this.dgvArticulos.AllowUserToAddRows = false;
			this.dgvArticulos.AllowUserToDeleteRows = false;
			this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.Cantidad,
            this.Eliminar});
			this.dgvArticulos.Location = new System.Drawing.Point(3, 67);
			this.dgvArticulos.MultiSelect = false;
			this.dgvArticulos.Name = "dgvArticulos";
			this.dgvArticulos.ReadOnly = true;
			this.dgvArticulos.RowHeadersWidth = 51;
			this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvArticulos.Size = new System.Drawing.Size(513, 337);
			this.dgvArticulos.TabIndex = 17;
			this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
			this.dgvArticulos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvArticulos_RowsAdded);
			this.dgvArticulos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvArticulos_RowsRemoved);
			// 
			// Codigo
			// 
			this.Codigo.FillWeight = 30F;
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.MinimumWidth = 6;
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.FillWeight = 111.9289F;
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.MinimumWidth = 6;
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Costo
			// 
			this.Costo.FillWeight = 25F;
			this.Costo.HeaderText = "Costo";
			this.Costo.MinimumWidth = 6;
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.FillWeight = 30F;
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// Eliminar
			// 
			this.Eliminar.FillWeight = 25F;
			this.Eliminar.HeaderText = "Eliminar";
			this.Eliminar.MinimumWidth = 6;
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.ReadOnly = true;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseColumnTextForButtonValue = true;
			// 
			// cuPuntoVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pArticulo);
			this.Controls.Add(this.pNota);
			this.Controls.Add(this.dgvArticulos);
			this.Name = "cuPuntoVenta";
			this.Size = new System.Drawing.Size(738, 430);
			this.pArticulo.ResumeLayout(false);
			this.pArticulo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.pNota.ResumeLayout(false);
			this.pNota.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pArticulo;
		private System.Windows.Forms.TextBox tbCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pNota;
		private System.Windows.Forms.Button btnPagar;
		private System.Windows.Forms.TextBox tbImporte;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvArticulos;
		private System.Windows.Forms.ComboBox cbCliente;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
	}
}
