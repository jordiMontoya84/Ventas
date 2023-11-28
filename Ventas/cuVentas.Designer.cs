namespace Ventas
{
	partial class cuVentas
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
			this.btnEliminar = new System.Windows.Forms.Button();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(593, 190);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 27;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// dgvDatos
			// 
			this.dgvDatos.AllowUserToAddRows = false;
			this.dgvDatos.AllowUserToDeleteRows = false;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Location = new System.Drawing.Point(17, 18);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.ReadOnly = true;
			this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDatos.Size = new System.Drawing.Size(498, 395);
			this.dgvDatos.TabIndex = 24;
			// 
			// cuVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvDatos);
			this.Name = "cuVentas";
			this.Size = new System.Drawing.Size(738, 430);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridView dgvDatos;
	}
}
