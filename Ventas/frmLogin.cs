using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
	public partial class frmLogin : Form
	{
		Conexion con = new Conexion();

		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (con.login(tbCorreo.Text, tbContraseña.Text))
			{
				frmVenta menu = new frmVenta();
				menu.Show();
				Hide();
			}
			else MessageBox.Show("Usuario o contraseña incorrectas");
		}
	}
}
