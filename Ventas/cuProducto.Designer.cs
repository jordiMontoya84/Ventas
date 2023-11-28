namespace Ventas
{
    partial class cuProducto
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnCrear = new System.Windows.Forms.Button();
			this.tbDescripcion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.cbSucursal = new System.Windows.Forms.ComboBox();
			this.cbProveedor = new System.Windows.Forms.ComboBox();
			this.nudCosto = new System.Windows.Forms.NumericUpDown();
			this.nudExistencia = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(547, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "Sucursal";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(537, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "Existencia";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(561, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 24;
			this.label2.Text = "Costo";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(597, 350);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 23;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(643, 293);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 22;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(551, 293);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 23);
			this.btnCrear.TabIndex = 21;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.Location = new System.Drawing.Point(618, 63);
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
			this.tbDescripcion.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(526, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 20);
			this.label1.TabIndex = 19;
			this.label1.Text = "Descripcion";
			// 
			// dgvDatos
			// 
			this.dgvDatos.AllowUserToAddRows = false;
			this.dgvDatos.AllowUserToDeleteRows = false;
			this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Location = new System.Drawing.Point(22, 18);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.ReadOnly = true;
			this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDatos.Size = new System.Drawing.Size(498, 395);
			this.dgvDatos.TabIndex = 18;
			this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(537, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 30;
			this.label5.Text = "Proveedor";
			// 
			// cbSucursal
			// 
			this.cbSucursal.FormattingEnabled = true;
			this.cbSucursal.Location = new System.Drawing.Point(618, 203);
			this.cbSucursal.Name = "cbSucursal";
			this.cbSucursal.Size = new System.Drawing.Size(100, 21);
			this.cbSucursal.TabIndex = 31;
			this.cbSucursal.DropDown += new System.EventHandler(this.cbSucursal_DropDown);
			// 
			// cbProveedor
			// 
			this.cbProveedor.FormattingEnabled = true;
			this.cbProveedor.Location = new System.Drawing.Point(618, 240);
			this.cbProveedor.Name = "cbProveedor";
			this.cbProveedor.Size = new System.Drawing.Size(100, 21);
			this.cbProveedor.TabIndex = 32;
			this.cbProveedor.DropDown += new System.EventHandler(this.cbProveedor_DropDown);
			// 
			// nudCosto
			// 
			this.nudCosto.Location = new System.Drawing.Point(618, 109);
			this.nudCosto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.nudCosto.Name = "nudCosto";
			this.nudCosto.Size = new System.Drawing.Size(100, 20);
			this.nudCosto.TabIndex = 33;
			// 
			// nudExistencia
			// 
			this.nudExistencia.Location = new System.Drawing.Point(618, 160);
			this.nudExistencia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.nudExistencia.Name = "nudExistencia";
			this.nudExistencia.Size = new System.Drawing.Size(100, 20);
			this.nudExistencia.TabIndex = 34;
			// 
			// cuProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nudExistencia);
			this.Controls.Add(this.nudCosto);
			this.Controls.Add(this.cbProveedor);
			this.Controls.Add(this.cbSucursal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.tbDescripcion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDatos);
			this.Name = "cuProducto";
			this.Size = new System.Drawing.Size(738, 430);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.ComboBox cbProveedor;
		private System.Windows.Forms.NumericUpDown nudCosto;
		private System.Windows.Forms.NumericUpDown nudExistencia;
	}
}
