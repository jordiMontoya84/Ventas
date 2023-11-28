using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Ventas
{

    class Conexion
    {
        SqlConnection conexion;

        public Conexion()
        {
            conexion = new SqlConnection("Server=localhost\\SQLEXPRESS; Database=Ventas; Trusted_Connection=True;");
        }

        private DataTable query(string cueri)
        {
            DataTable datos = new DataTable();
            conexion.Open();
            SqlDataAdapter reader = new SqlDataAdapter(cueri, conexion);
            reader.Fill(datos);
            conexion.Close();
            return datos;
        }

        public DataTable sucursales()
        {
            return query("select id,nombre from sucursal where estatus = 1");
        }

        public DataTable proveedores()
        {
            return query("select id,nombre from proveedor where estatus = 1");
        }

        public DataTable categorias()
        {
            return query("select Id,Descripcion from categoria where estatus = 1");
        }

        public DataTable cargos()
        {
            return query("select id,descripcion from cargo where estatus = 1");
        }

        public DataTable turno()
        {
            return query("select id,hraentrada from turno where estatus = 1");
        }

        public DataTable clientes()
        {
            return query("select id,nombre from cliente where estatus = 1");
        }

        public DataTable articulo(string id)
        {
            return query("select id,descripcion,costo from producto where estatus = 1 and id = "+id);
        }
        public DataTable datosProveedores()
        {
            return query("select P.Id,P.Nombre,P.Correo,P.Telefono,P.Cuenta,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from Proveedor as P inner join Empleado as C on P.EmpCreo=C.Id inner join Empleado as A on P.EmpAct= A.Id where p.estatus = 1");
        }

        public DataTable datosSucursales()
        {
            return query("select S.Id,S.Nombre,S.Telefono,S.Estado,S.Ciudad,S.Colonia,S.Calle,S.Numero,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from Sucursal as S inner join Empleado as C on S.EmpCreo=C.Id inner join Empleado as A on S.EmpAct= A.Id where S.estatus = 1");
        }

        public DataTable datosCargos()
        {
            return query("select Car.Id,Car.Descripcion,Car.Sueldo,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from Cargo as Car inner join Empleado as C on Car.EmpCreo=C.Id inner join Empleado as A on Car.EmpAct= A.Id where Car.estatus = 1");
        }

        public DataTable datosTurnos()
        {
            return query("select T.Id,T.HraEntrada,T.HraSalida,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from Turno as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id where T.estatus = 1");
        }

        public DataTable datosEmpleado()
        {
            return query("select * from empleado where estatus =1");
        }

        public DataTable datosCliente()
        {
            return query("select T.Id,T.Nombre,T.Cp,T.Rfc,T.Cfdi,T.Regimen,S.Nombre as Sucursal,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from Cliente as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id inner join Sucursal as S on T.idsucursal = S.id where T.estatus = 1");
        }

        public DataTable datosProducto()
        {
            return query("select T.Id,T.Descripcion,T.Costo,T.Existencia,S.Nombre as Sucursal,P.Nombre as Proveedor,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from Producto as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id inner join Sucursal as S on T.idsucursal = S.id inner join Proveedor as P on T.IdProveedor = P.Id where T.estatus = 1");
        }

        public DataTable datosSucursalProveedor()
        {
            return query("select T.Id,S.Nombre as Sucursal,P.Nombre as Proveedor,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from SucursalProveedor as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id inner join Sucursal as S on T.idsucursal = S.id inner join Proveedor as P on T.IdProveedor = P.Id where T.estatus = 1");
        }

        public DataTable datosVenta()
        {
            return query("select T.Id,T.Total,C.Nombres+' '+ C.ApPaterno as EmpCreo,A.Nombres+' '+ A.ApPaterno as EmpAct from Venta as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id where T.estatus = 1");
        }

        public int venta()
        {
            DataTable datos = new DataTable();
            SqlDataAdapter reader = new SqlDataAdapter("select max(id) from venta", conexion);
            reader.Fill(datos);

            try
            {
                return Convert.ToInt32(datos.Rows[0][0]) + 1;
            }catch(Exception ex)
            {
                return 1;
            }
        }

        public void crearProveedor(string nombre,string correo,string telefono,string cuenta,int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into Proveedor(Nombre,Correo,Telefono,Cuenta,EmpCreo,EmpAct) values(@n,@c,@t,@cu,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@c", correo);
            cmd.Parameters.AddWithValue("@t", telefono);
            cmd.Parameters.AddWithValue("@cu", cuenta);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarProveedor(int id,string nombre, string correo, string telefono, string cuenta, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update Proveedor set Nombre=@n, Correo=@c, Telefono=@t, Cuenta=@cu,EmpAct=@e where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@c", correo);
            cmd.Parameters.AddWithValue("@t", telefono);
            cmd.Parameters.AddWithValue("@cu", cuenta);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@e", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void eliminarTabla(string tabla,int id,int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update "+tabla+" set Estatus = 0,EmpAct=@e where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@e", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se Elimino correctamente");
        }

        public void crearSucursal(string nombre, string telefono, string estado, string ciudad,string colonia,string calle,string numero, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into sucursal(Nombre,telefono,estado,ciudad,colonia,calle,numero,empcreo,empact) values(@n,@t,@e,@c,@co,@ca,@num,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@t", telefono);
            cmd.Parameters.AddWithValue("@e", estado);
            cmd.Parameters.AddWithValue("@c", ciudad);
            cmd.Parameters.AddWithValue("@co", colonia);
            cmd.Parameters.AddWithValue("@ca", calle);
            cmd.Parameters.AddWithValue("@num", numero);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarSucursal(int id, string nombre, string telefono, string estado, string ciudad, string colonia, string calle, string numero, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update sucursal set Nombre=@n, Telefono=@t, estado = @e, ciudad=@c,colonia=@co,calle=@ca,numero=@num,EmpAct=@em where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@e", estado);
            cmd.Parameters.AddWithValue("@c", ciudad);
            cmd.Parameters.AddWithValue("@t", telefono);
            cmd.Parameters.AddWithValue("@co", colonia);
            cmd.Parameters.AddWithValue("@ca", calle);
            cmd.Parameters.AddWithValue("@num", numero);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@em", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void crearCargo(string descripcion,int sueldo, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into Cargo(Descripcion,Sueldo,EmpCreo,EmpAct) values(@d,@s,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@d", descripcion);
            cmd.Parameters.AddWithValue("@s", sueldo);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarCargo(int id, string descripcion,int sueldo, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update Cargo set Descripcion=@d, Sueldo=@s, EmpAct=@e where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@d", descripcion);
            cmd.Parameters.AddWithValue("@s", sueldo);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@e", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void crearTurno(string entrada, string salida, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into Turno(HraEntrada,HraSalida,EmpCreo,EmpAct) values(@e,@s,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@e", entrada);
            cmd.Parameters.AddWithValue("@s", salida);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarTurno(int id, string entrada, string salida, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update Turno set HraEntrada=@en, HraSalida=@s, EmpAct=@e where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@en", entrada);
            cmd.Parameters.AddWithValue("@s", salida);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@e", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void crearEmpleado(string nombres, string ap, string am, string telefono, string rfc, string correo, string contra,int sucursal,int cargo,int turno, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into Empleado(Nombres,ApPaterno,ApMaterno,telefono,rfc,correo,contrasenia,idsucursal,idcargo,idturno,empcreo,empact) values(@n,@ap,@am,@t,@rfc,@c,@con,@s,@car,@tu,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@n", nombres);
            cmd.Parameters.AddWithValue("@ap", ap);
            cmd.Parameters.AddWithValue("@am", am );
            cmd.Parameters.AddWithValue("@t", telefono);
            cmd.Parameters.AddWithValue("@rfc", rfc);
            cmd.Parameters.AddWithValue("@c", correo);
            cmd.Parameters.AddWithValue("@con", Encrypt(contra));
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@car", cargo);
            cmd.Parameters.AddWithValue("@tu", turno);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarEmpleado(int id, string nombres, string ap, string am, string telefono, string rfc, string correo, string contra, int sucursal, int cargo, int turno, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update Empleado set Nombres=@n, ApPaterno=@ap, ApMaterno= @am, telefono=@t,rfc=@rfc,correo=@c,contrasenia=@con,idSucursal=@s,idCargo=@car,idTurno=@tu,EmpAct=@em where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@n", nombres);
            cmd.Parameters.AddWithValue("@ap", ap);
            cmd.Parameters.AddWithValue("@am", am);
            cmd.Parameters.AddWithValue("@t", telefono);
            cmd.Parameters.AddWithValue("@rfc", rfc);
            cmd.Parameters.AddWithValue("@c", correo);
            cmd.Parameters.AddWithValue("@con", Encrypt(contra));
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@car", cargo);
            cmd.Parameters.AddWithValue("@tu", turno);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@em", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void crearCategoria(string descripcion, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into Categoria(Descripcion,EmpCreo,EmpAct) values(@d,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@d", descripcion);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarCategoria(int id, string descripcion, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update Categoria set Descripcion=@d, EmpAct=@e where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@d", descripcion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@e", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void crearCliente(string nombre, string cp, string rfc, string cfdi, string regimen, int sucursal, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into cliente(Nombre,Cp,Rfc,cfdi,regimen,idSucursal,empcreo,empact) values(@n,@cp,@rfc,@cfdi,@r,@s,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@cp", cp);
            cmd.Parameters.AddWithValue("@rfc", rfc);
            cmd.Parameters.AddWithValue("@cfdi", cfdi);
            cmd.Parameters.AddWithValue("@r", regimen);
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarCliente(int id, string nombre, string cp, string rfc, string cfdi, string regimen, int sucursal, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update cliente set Nombre=@n, cp=@cp, rfc= @rfc, cfdi=@cfdi,regimen=@r,idsucursal=@s,EmpAct=@em where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@cp", cp);
            cmd.Parameters.AddWithValue("@rfc", rfc);
            cmd.Parameters.AddWithValue("@cfdi", cfdi);
            cmd.Parameters.AddWithValue("@r", regimen);
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@em", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void crearProducto(string descripcion,int costo, int existencia, int sucursal, int proveedor, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into producto(descripcion,costo,existencia,idsucursal,idproveedor,empcreo,empact) values(@d,@c,@e,@s,@p,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@d", descripcion);
            cmd.Parameters.AddWithValue("@c", costo);
            cmd.Parameters.AddWithValue("@e", existencia);
            cmd.Parameters.AddWithValue("@p", proveedor);
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarProducto(int id, string descripcion, int costo, int existencia, int sucursal, int proveedor, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update producto set descripcion=@d, costo=@c, existencia= @e, idsucursal=@s,idproveedor=@p,EmpAct=@em where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@d", descripcion);
            cmd.Parameters.AddWithValue("@c", costo);
            cmd.Parameters.AddWithValue("@e", existencia);
            cmd.Parameters.AddWithValue("@p", proveedor);
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@em", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void crearSucursalProveedor(int sucursal, int proveedor, int id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into sucursalproveedor(idsucursal,idproveedor,empcreo,empact) values(@s,@p,@ec,@ea) ", conexion);
            cmd.Parameters.AddWithValue("@p", proveedor);
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se creo correctamente");
        }

        public void actualizarSucursalProveedor(int id,int sucursal, int proveedor, int idEmp)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update sucursalproveedor set idsucursal=@s,idproveedor=@p,EmpAct=@em where Id = @id ", conexion);
            cmd.Parameters.AddWithValue("@p", proveedor);
            cmd.Parameters.AddWithValue("@s", sucursal);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@em", idEmp);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo correctamente");
        }

        public void registrarVenta(int cliente, decimal total, int id,DataGridView articulos)
        {
            conexion.Open();

            int nota = venta();
            SqlCommand cmd = new SqlCommand("insert into Venta (id,Fechahra,total,idempleado,idcliente,empcreo,empact) values (@id,@fh,@t,@idemp,@c,@ec,@ea)", conexion);

            cmd.Parameters.AddWithValue("@id", nota);
            cmd.Parameters.AddWithValue("@fh", DateTime.Now);
            cmd.Parameters.AddWithValue("@t", total);
            cmd.Parameters.AddWithValue("@idemp", id);
            cmd.Parameters.AddWithValue("@c", cliente);
            cmd.Parameters.AddWithValue("@ec", id);
            cmd.Parameters.AddWithValue("@ea", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            foreach (DataGridViewRow r in articulos.Rows)
            {
                cmd = new SqlCommand("insert into ventadetalle (cantidad,costo,idventa,idproducto,empcreo,empact) values (@can,@cos,@venta,@prod,@ec,@ea)", conexion);

                cmd.Parameters.AddWithValue("@can", r.Cells["Cantidad"].Value);
                cmd.Parameters.AddWithValue("@cos", r.Cells["Costo"].Value);
                cmd.Parameters.AddWithValue("@venta", nota);
                cmd.Parameters.AddWithValue("@prod", r.Cells["Codigo"].Value);
                cmd.Parameters.AddWithValue("@ec", id);
                cmd.Parameters.AddWithValue("@ea", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            conexion.Close();
            MessageBox.Show("Nota Registrada");
        }

        public bool login(string correo, string contra)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select id from empleado where correo = @correo and contrasenia=@contra and estatus=1", conexion);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contra", Encrypt(contra));
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conexion.Close();

            if (dt.Rows.Count != 0)
            {
                global.id = Convert.ToInt32(dt.Rows[0][0]);
                return true;
            }
            else
                return false;
        }


        static string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte),
                                          CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
