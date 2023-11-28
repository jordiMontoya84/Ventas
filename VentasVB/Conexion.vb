
Imports Npgsql
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text



Class Conexion
	Dim conexion As NpgsqlConnection

	Public Sub New()
		conexion = New NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Ventas;User Id=postgres;Password=jordi123;")
	End Sub

	Private Function query(ByVal cueri As String) As DataTable
			Dim datos As DataTable = New DataTable()
			conexion.Open()
		Dim reader As NpgsqlDataAdapter = New NpgsqlDataAdapter(cueri, conexion)
		reader.Fill(datos)
			conexion.Close()
			Return datos
		End Function

		Public Function sucursales() As DataTable
		Return query("select id,nombre from sucursal where estatus = true")
	End Function

		Public Function proveedores() As DataTable
		Return query("select id,nombre from proveedor where estatus = true")
	End Function

		Public Function categorias() As DataTable
		Return query("select Id,Descripcion from categoria where estatus = true")
	End Function

		Public Function cargos() As DataTable
		Return query("select id,descripcion from cargo where estatus = true")
	End Function

		Public Function turno() As DataTable
		Return query("select id,hraentrada from turno where estatus = true")
	End Function

		Public Function clientes() As DataTable
		Return query("select id,nombre from cliente where estatus = true")
	End Function

		Public Function articulo(ByVal id As String) As DataTable
		Return query("select id,descripcion,costo from producto where estatus = true and id = " + id)
	End Function
		Public Function datosProveedores() As DataTable
		Return query("select P.Id,P.Nombre,P.Correo,P.Telefono,P.Cuenta,C.Nombres as EmpCreo,A.Nombres as EmpAct from Proveedor as P inner join Empleado as C on P.EmpCreo=C.Id inner join Empleado as A on P.EmpAct= A.Id where p.estatus = true")
	End Function

		Public Function datosSucursales() As DataTable
		Return query("select S.Id,S.Nombre,S.Telefono,S.Estado,S.Ciudad,S.Colonia,S.Calle,S.Numero,C.Nombres as EmpCreo,A.Nombres as EmpAct from Sucursal as S inner join Empleado as C on S.EmpCreo=C.Id inner join Empleado as A on S.EmpAct= A.Id where S.estatus = true")
	End Function

		Public Function datosCargos() As DataTable
		Return query("select Car.Id,Car.Descripcion,Car.Sueldo,C.Nombres as EmpCreo,A.Nombres as EmpAct from Cargo as Car inner join Empleado as C on Car.EmpCreo=C.Id inner join Empleado as A on Car.EmpAct= A.Id where Car.estatus = true")
	End Function

		Public Function datosTurnos() As DataTable
		Return query("select T.Id,T.HraEntrada,T.HraSalida,C.Nombres as EmpCreo,A.Nombres as EmpAct from Turno as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id where T.estatus = true")
	End Function

		Public Function datosEmpleado() As DataTable
		Return query("select id,nombres,appaterno,apmaterno,telefono,rfc,correo,contrasenia from empleado where estatus =true")
	End Function

		Public Function datosCliente() As DataTable
		Return query("select T.Id,T.Nombre,T.Cp,T.Rfc,T.Cfdi,T.Regimen,S.Nombre as Sucursal,C.Nombres as EmpCreo,A.Nombres as EmpAct from Cliente as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id inner join Sucursal as S on T.idsucursal = S.id where T.estatus = true")
	End Function

		Public Function datosProducto() As DataTable
		Return query("select T.Id,T.Descripcion,T.Costo,T.Existencia,S.Nombre as Sucursal,P.Nombre as Proveedor,C.Nombres as EmpCreo,A.Nombres as EmpAct from Producto as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id inner join Sucursal as S on T.idsucursal = S.id inner join Proveedor as P on T.IdProveedor = P.Id where T.estatus = true")
	End Function

		Public Function datosSucursalProveedor() As DataTable
		Return query("select T.Id,S.Nombre as Sucursal,P.Nombre as Proveedor,C.Nombres as EmpCreo,A.Nombres as EmpAct from SucursalProveedor as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id inner join Sucursal as S on T.idsucursal = S.id inner join Proveedor as P on T.IdProveedor = P.Id where T.estatus = true")
	End Function

		Public Function datosVenta() As DataTable
		Return query("select T.Id,T.Total,C.Nombres as EmpCreo,A.Nombres as EmpAct from Venta as T inner join Empleado as C on T.EmpCreo=C.Id inner join Empleado as A on T.EmpAct= A.Id where T.estatus = true")
	End Function

		Public Function venta() As Integer
			Dim datos As DataTable = New DataTable()
		Dim reader As NpgsqlDataAdapter = New NpgsqlDataAdapter("select max(id) from venta", conexion)
		reader.Fill(datos)

			Try
				Return Convert.ToInt32(datos.Rows(0)(0)) + 1
			Catch ex As Exception
				Return 1
			End Try
		End Function

		Public Sub crearProveedor(ByVal nombre As String, ByVal correo As String, ByVal telefono As String, ByVal cuenta As String, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into Proveedor(Nombre,Correo,Telefono,Cuenta,EmpCreo,EmpAct) values(@n,@c,@t,@cu,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@n", nombre)
			cmd.Parameters.AddWithValue("@c", correo)
			cmd.Parameters.AddWithValue("@t", telefono)
			cmd.Parameters.AddWithValue("@cu", cuenta)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarProveedor(ByVal id As Integer, ByVal nombre As String, ByVal correo As String, ByVal telefono As String, ByVal cuenta As String, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update Proveedor set Nombre=@n, Correo=@c, Telefono=@t, Cuenta=@cu,EmpAct=@e where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@n", nombre)
			cmd.Parameters.AddWithValue("@c", correo)
			cmd.Parameters.AddWithValue("@t", telefono)
			cmd.Parameters.AddWithValue("@cu", cuenta)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@e", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub eliminarTabla(ByVal tabla As String, ByVal id As Integer, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update " + tabla + " set Estatus = false,EmpAct=@e where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@e", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se Elimino correctamente")
		End Sub

		Public Sub crearSucursal(ByVal nombre As String, ByVal telefono As String, ByVal estado As String, ByVal ciudad As String, ByVal colonia As String, ByVal calle As String, ByVal numero As String, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into sucursal(Nombre,telefono,estado,ciudad,colonia,calle,numero,empcreo,empact) values(@n,@t,@e,@c,@co,@ca,@num,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@n", nombre)
			cmd.Parameters.AddWithValue("@t", telefono)
			cmd.Parameters.AddWithValue("@e", estado)
			cmd.Parameters.AddWithValue("@c", ciudad)
			cmd.Parameters.AddWithValue("@co", colonia)
			cmd.Parameters.AddWithValue("@ca", calle)
			cmd.Parameters.AddWithValue("@num", numero)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarSucursal(ByVal id As Integer, ByVal nombre As String, ByVal telefono As String, ByVal estado As String, ByVal ciudad As String, ByVal colonia As String, ByVal calle As String, ByVal numero As String, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update sucursal set Nombre=@n, Telefono=@t, estado = @e, ciudad=@c,colonia=@co,calle=@ca,numero=@num,EmpAct=@em where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@n", nombre)
			cmd.Parameters.AddWithValue("@e", estado)
			cmd.Parameters.AddWithValue("@c", ciudad)
			cmd.Parameters.AddWithValue("@t", telefono)
			cmd.Parameters.AddWithValue("@co", colonia)
			cmd.Parameters.AddWithValue("@ca", calle)
			cmd.Parameters.AddWithValue("@num", numero)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@em", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub crearCargo(ByVal descripcion As String, ByVal sueldo As Integer, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into Cargo(Descripcion,Sueldo,EmpCreo,EmpAct) values(@d,@s,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@d", descripcion)
			cmd.Parameters.AddWithValue("@s", sueldo)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarCargo(ByVal id As Integer, ByVal descripcion As String, ByVal sueldo As Integer, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update Cargo set Descripcion=@d, Sueldo=@s, EmpAct=@e where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@d", descripcion)
			cmd.Parameters.AddWithValue("@s", sueldo)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@e", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

	Public Sub crearTurno(ByVal entrada As String, ByVal salida As String, ByVal id As Integer)

		conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into Turno(HraEntrada,HraSalida,EmpCreo,EmpAct) values(cast(@e as time),cast(@s as time),@ec,@ea)", conexion)
		cmd.Parameters.AddWithValue("@e", entrada)
		cmd.Parameters.AddWithValue("@s", salida)
		cmd.Parameters.AddWithValue("@ec", id)
		cmd.Parameters.AddWithValue("@ea", id)
		cmd.ExecuteNonQuery()
		conexion.Close()
		MessageBox.Show("Se creo correctamente")
	End Sub

	Public Sub actualizarTurno(ByVal id As Integer, ByVal entrada As String, ByVal salida As String, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update Turno set HraEntrada=@en, HraSalida=@s, EmpAct=@e where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@en", entrada)
			cmd.Parameters.AddWithValue("@s", salida)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@e", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub crearEmpleado(ByVal nombres As String, ByVal ap As String, ByVal am As String, ByVal telefono As String, ByVal rfc As String, ByVal correo As String, ByVal contra As String, ByVal sucursal As Integer, ByVal cargo As Integer, ByVal turno As Integer, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into Empleado(Nombres,ApPaterno,ApMaterno,telefono,rfc,correo,contrasenia,idsucursal,idcargo,idturno,empcreo,empact) values(@n,@ap,@am,@t,@rfc,@c,@con,@s,@car,@tu,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@n", nombres)
			cmd.Parameters.AddWithValue("@ap", ap)
			cmd.Parameters.AddWithValue("@am", am)
			cmd.Parameters.AddWithValue("@t", telefono)
			cmd.Parameters.AddWithValue("@rfc", rfc)
			cmd.Parameters.AddWithValue("@c", correo)
			cmd.Parameters.AddWithValue("@con", Encrypt(contra))
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@car", cargo)
			cmd.Parameters.AddWithValue("@tu", turno)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarEmpleado(ByVal id As Integer, ByVal nombres As String, ByVal ap As String, ByVal am As String, ByVal telefono As String, ByVal rfc As String, ByVal correo As String, ByVal contra As String, ByVal sucursal As Integer, ByVal cargo As Integer, ByVal turno As Integer, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update Empleado set Nombres=@n, ApPaterno=@ap, ApMaterno= @am, telefono=@t,rfc=@rfc,correo=@c,contrasenia=@con,idSucursal=@s,idCargo=@car,idTurno=@tu,EmpAct=@em where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@n", nombres)
			cmd.Parameters.AddWithValue("@ap", ap)
			cmd.Parameters.AddWithValue("@am", am)
			cmd.Parameters.AddWithValue("@t", telefono)
			cmd.Parameters.AddWithValue("@rfc", rfc)
			cmd.Parameters.AddWithValue("@c", correo)
			cmd.Parameters.AddWithValue("@con", Encrypt(contra))
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@car", cargo)
			cmd.Parameters.AddWithValue("@tu", turno)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@em", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub crearCategoria(ByVal descripcion As String, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into Categoria(Descripcion,EmpCreo,EmpAct) values(@d,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@d", descripcion)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarCategoria(ByVal id As Integer, ByVal descripcion As String, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update Categoria set Descripcion=@d, EmpAct=@e where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@d", descripcion)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@e", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub crearCliente(ByVal nombre As String, ByVal cp As String, ByVal rfc As String, ByVal cfdi As String, ByVal regimen As String, ByVal sucursal As Integer, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into cliente(Nombre,Cp,Rfc,cfdi,regimen,idSucursal,empcreo,empact) values(@n,@cp,@rfc,@cfdi,@r,@s,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@n", nombre)
			cmd.Parameters.AddWithValue("@cp", cp)
			cmd.Parameters.AddWithValue("@rfc", rfc)
			cmd.Parameters.AddWithValue("@cfdi", cfdi)
			cmd.Parameters.AddWithValue("@r", regimen)
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarCliente(ByVal id As Integer, ByVal nombre As String, ByVal cp As String, ByVal rfc As String, ByVal cfdi As String, ByVal regimen As String, ByVal sucursal As Integer, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update cliente set Nombre=@n, cp=@cp, rfc= @rfc, cfdi=@cfdi,regimen=@r,idsucursal=@s,EmpAct=@em where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@n", nombre)
			cmd.Parameters.AddWithValue("@cp", cp)
			cmd.Parameters.AddWithValue("@rfc", rfc)
			cmd.Parameters.AddWithValue("@cfdi", cfdi)
			cmd.Parameters.AddWithValue("@r", regimen)
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@em", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub crearProducto(ByVal descripcion As String, ByVal costo As Integer, ByVal existencia As Integer, ByVal sucursal As Integer, ByVal proveedor As Integer, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into producto(descripcion,costo,existencia,idsucursal,idproveedor,empcreo,empact) values(@d,@c,@e,@s,@p,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@d", descripcion)
			cmd.Parameters.AddWithValue("@c", costo)
			cmd.Parameters.AddWithValue("@e", existencia)
			cmd.Parameters.AddWithValue("@p", proveedor)
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarProducto(ByVal id As Integer, ByVal descripcion As String, ByVal costo As Integer, ByVal existencia As Integer, ByVal sucursal As Integer, ByVal proveedor As Integer, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update producto set descripcion=@d, costo=@c, existencia= @e, idsucursal=@s,idproveedor=@p,EmpAct=@em where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@d", descripcion)
			cmd.Parameters.AddWithValue("@c", costo)
			cmd.Parameters.AddWithValue("@e", existencia)
			cmd.Parameters.AddWithValue("@p", proveedor)
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@em", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub crearSucursalProveedor(ByVal sucursal As Integer, ByVal proveedor As Integer, ByVal id As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into sucursalproveedor(idsucursal,idproveedor,empcreo,empact) values(@s,@p,@ec,@ea) ", conexion)
		cmd.Parameters.AddWithValue("@p", proveedor)
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se creo correctamente")
		End Sub

		Public Sub actualizarSucursalProveedor(ByVal id As Integer, ByVal sucursal As Integer, ByVal proveedor As Integer, ByVal idEmp As Integer)
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("update sucursalproveedor set idsucursal=@s,idproveedor=@p,EmpAct=@em where Id = @id ", conexion)
		cmd.Parameters.AddWithValue("@p", proveedor)
			cmd.Parameters.AddWithValue("@s", sucursal)
			cmd.Parameters.AddWithValue("@id", id)
			cmd.Parameters.AddWithValue("@em", idEmp)
			cmd.ExecuteNonQuery()
			conexion.Close()
			MessageBox.Show("Se actualizo correctamente")
		End Sub

		Public Sub registrarVenta(ByVal cliente As Integer, ByVal total As Decimal, ByVal id As Integer, ByVal articulos As DataGridView)
			conexion.Open()

			Dim nota As Integer = venta()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("insert into Venta (id,Fechahra,total,idempleado,idcliente,empcreo,empact) values (@id,@fh,@t,@idemp,@c,@ec,@ea)", conexion)

		cmd.Parameters.AddWithValue("@id", nota)
			cmd.Parameters.AddWithValue("@fh", DateTime.Now)
			cmd.Parameters.AddWithValue("@t", total)
			cmd.Parameters.AddWithValue("@idemp", id)
			cmd.Parameters.AddWithValue("@c", cliente)
			cmd.Parameters.AddWithValue("@ec", id)
			cmd.Parameters.AddWithValue("@ea", id)
			cmd.ExecuteNonQuery()
			cmd.Dispose()

			Dim r As DataGridViewRow
			For Each r In articulos.Rows
			cmd = New NpgsqlCommand("insert into ventadetalle (cantidad,costo,idventa,idproducto,empcreo,empact) values (@can,@cos,@venta,@prod,@ec,@ea)", conexion)

			cmd.Parameters.AddWithValue("@can", r.Cells("Cantidad").Value)
				cmd.Parameters.AddWithValue("@cos", r.Cells("Costo").Value)
				cmd.Parameters.AddWithValue("@venta", nota)
				cmd.Parameters.AddWithValue("@prod", r.Cells("Codigo").Value)
				cmd.Parameters.AddWithValue("@ec", id)
				cmd.Parameters.AddWithValue("@ea", id)
				cmd.ExecuteNonQuery()
				cmd.Dispose()
			Next
			conexion.Close()
			MessageBox.Show("Nota Registrada")
		End Sub

		Public Function login(ByVal correo As String, ByVal contra As String) As Boolean
			conexion.Open()
		Dim cmd As NpgsqlCommand = New NpgsqlCommand("select id from empleado where correo = @correo and contrasenia=@contra and estatus=true", conexion)
		cmd.Parameters.AddWithValue("@correo", correo)
			cmd.Parameters.AddWithValue("@contra", Encrypt(contra))
		Dim adapter As NpgsqlDataAdapter = New NpgsqlDataAdapter(cmd)
		Dim dt As DataTable = New DataTable()
			adapter.Fill(dt)
			conexion.Close()

			If dt.Rows.Count <> 0 Then
				idUsuario = Convert.ToInt32(dt.Rows(0)(0))
				Return True
			Else
				Return False
			End If
		End Function


		Public Function Encrypt(ByVal Input As String) As String

			Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
			Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
			Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
			Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
			des.Key = EncryptionKey
			des.IV = IV

			Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

		End Function
	End Class
