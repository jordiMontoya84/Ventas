namespace Ventas
{
	partial class cuTurno
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnCrear = new System.Windows.Forms.Button();
			this.tbEntrada = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.tbSalida = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(531, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 32;
			this.label2.Text = "Hra.Salida";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(599, 291);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 31;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(645, 234);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 30;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(553, 234);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 23);
			this.btnCrear.TabIndex = 29;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// tbEntrada
			// 
			this.tbEntrada.Location = new System.Drawing.Point(620, 98);
			this.tbEntrada.Name = "tbEntrada";
			this.tbEntrada.Size = new System.Drawing.Size(100, 20);
			this.tbEntrada.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(522, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 27;
			this.label1.Text = "Hra.Entrada";
			// 
			// dgvDatos
			// 
			this.dgvDatos.AllowUserToAddRows = false;
			this.dgvDatos.AllowUserToDeleteRows = false;
			this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvDatos.Location = new System.Drawing.Point(18, 18);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.ReadOnly = true;
			this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDatos.Size = new System.Drawing.Size(498, 395);
			this.dgvDatos.TabIndex = 26;
			this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
			// 
			// tbSalida
			// 
			this.tbSalida.Location = new System.Drawing.Point(620, 142);
			this.tbSalida.Name = "tbSalida";
			this.tbSalida.Size = new System.Drawing.Size(100, 20);
			this.tbSalida.TabIndex = 33;
			// 
			// cuTurno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tbSalida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.tbEntrada);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDatos);
			this.Name = "cuTurno";
			this.Size = new System.Drawing.Size(738, 430);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.TextBox tbEntrada;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.TextBox tbSalida;
	}
}
