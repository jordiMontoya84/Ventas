namespace Ventas
{
    partial class cuCliente
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
			this.tbCfdi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbRfc = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnCrear = new System.Windows.Forms.Button();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.tbRegimen = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbSucursal = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// tbCfdi
			// 
			this.tbCfdi.Location = new System.Drawing.Point(616, 176);
			this.tbCfdi.Name = "tbCfdi";
			this.tbCfdi.Size = new System.Drawing.Size(100, 20);
			this.tbCfdi.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(559, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 20);
			this.label4.TabIndex = 28;
			this.label4.Text = "CFDI";
			// 
			// tbRfc
			// 
			this.tbRfc.Location = new System.Drawing.Point(616, 132);
			this.tbRfc.Name = "tbRfc";
			this.tbRfc.Size = new System.Drawing.Size(100, 20);
			this.tbRfc.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(568, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "RFC";
			// 
			// tbCp
			// 
			this.tbCp.Location = new System.Drawing.Point(616, 85);
			this.tbCp.Name = "tbCp";
			this.tbCp.Size = new System.Drawing.Size(100, 20);
			this.tbCp.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(576, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 20);
			this.label2.TabIndex = 24;
			this.label2.Text = "CP";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(604, 384);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 23;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(650, 327);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 22;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(558, 327);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 23);
			this.btnCrear.TabIndex = 21;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(616, 38);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(100, 20);
			this.tbNombre.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(545, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 19;
			this.label1.Text = "Nombre";
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
			this.label5.Location = new System.Drawing.Point(545, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 20);
			this.label5.TabIndex = 32;
			this.label5.Text = "Sucursal";
			// 
			// tbRegimen
			// 
			this.tbRegimen.Location = new System.Drawing.Point(616, 219);
			this.tbRegimen.Name = "tbRegimen";
			this.tbRegimen.Size = new System.Drawing.Size(100, 20);
			this.tbRegimen.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(545, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 20);
			this.label6.TabIndex = 30;
			this.label6.Text = "Regimen";
			// 
			// cbSucursal
			// 
			this.cbSucursal.FormattingEnabled = true;
			this.cbSucursal.Location = new System.Drawing.Point(623, 261);
			this.cbSucursal.Name = "cbSucursal";
			this.cbSucursal.Size = new System.Drawing.Size(102, 21);
			this.cbSucursal.TabIndex = 33;
			this.cbSucursal.DropDown += new System.EventHandler(this.cbSucursal_DropDown);
			// 
			// cuCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbSucursal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbRegimen);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbCfdi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbRfc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbCp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.tbNombre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDatos);
			this.Name = "cuCliente";
			this.Size = new System.Drawing.Size(738, 430);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCfdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRfc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRegimen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSucursal;
    }
}
