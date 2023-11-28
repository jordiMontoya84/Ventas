namespace Ventas
{
	partial class frmLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCorreo = new System.Windows.Forms.TextBox();
			this.tbContraseña = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Correo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña";
			// 
			// tbCorreo
			// 
			this.tbCorreo.Location = new System.Drawing.Point(116, 48);
			this.tbCorreo.Name = "tbCorreo";
			this.tbCorreo.Size = new System.Drawing.Size(160, 20);
			this.tbCorreo.TabIndex = 2;
			// 
			// tbContraseña
			// 
			this.tbContraseña.Location = new System.Drawing.Point(116, 93);
			this.tbContraseña.Name = "tbContraseña";
			this.tbContraseña.Size = new System.Drawing.Size(100, 20);
			this.tbContraseña.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(201, 128);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 163);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.tbContraseña);
			this.Controls.Add(this.tbCorreo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbCorreo;
		private System.Windows.Forms.TextBox tbContraseña;
		private System.Windows.Forms.Button btnLogin;
	}
}