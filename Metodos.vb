Imports System.Data.SqlClient
Imports System.Configuration
Public Module Metodos
    Public Sub insert(tabla As String, cliente As String, Telefono As Long, Correo As String)
        Try
            If (tabla = "Clientes") Then
                Dim consulta As String = "INSERT INTO Clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
                Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
                    cn.Open()
                    Using command As New SqlCommand(consulta, cn)
                        command.Parameters.AddWithValue("@Cliente", cliente)
                        command.Parameters.AddWithValue("@Telefono", Telefono)
                        command.Parameters.AddWithValue("@Correo", Correo)
                        command.ExecuteNonQuery()
                    End Using
                    cn.Close()
                End Using
            ElseIf (tabla = "Productos") Then
                Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
                Dim query As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
                cn.Open()
                Dim command As New SqlCommand(query, cn)
                ' Agregar parámetros al comando
                command.Parameters.AddWithValue("@Nombre", cliente)
                command.Parameters.AddWithValue("@Precio", Telefono)
                command.Parameters.AddWithValue("@Categoria", Correo)
                ' Ejecutar la consulta
                command.ExecuteNonQuery()
                cn.Close()
                MsgBox("Se registró correctamente")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Public Sub InsertVentas(IdCliente As Integer, fecha As DateTime, Total As String)
        Try
            Dim consulta As String = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@IdCliente, @Fecha, @Total)"
            Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
                cn.Open()
                Using command As New SqlCommand(consulta, cn)
                    command.Parameters.AddWithValue("@IdCliente", IdCliente)
                    command.Parameters.AddWithValue("@Fecha", fecha)
                    command.Parameters.AddWithValue("@Total", Total)
                    command.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
    Public Sub InsertVentasItems(Producto As Integer, PrecioUnitario As Integer, Cantidad As Integer, PrecioTotal As Integer)
        Try
            Dim connString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
            Dim query As String = "SELECT MAX(ID) FROM ventas"
            Dim result As Integer = 0
            Using conn As New SqlConnection(connString)
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim executeResult = cmd.ExecuteScalar()
                If Not IsDBNull(executeResult) Then
                    result = Convert.ToInt32(executeResult)
                End If
            End Using
            Dim queryss As String = "INSERT INTO ventasitems VALUES(@IDVenta, @IdProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"
            Using cnn As New SqlConnection(connString)
                cnn.Open()
                Dim command As New SqlCommand(queryss, cnn)
                command.Parameters.AddWithValue("@IDVenta", result + 1)
                command.Parameters.AddWithValue("@IdProducto", Producto)
                command.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario)
                command.Parameters.AddWithValue("@Cantidad", Cantidad)
                command.Parameters.AddWithValue("@PrecioTotal", PrecioTotal)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub


    Public Sub Update(Tabla As String, Cliente As String, Correo As String, Telefono As Long, Id As Integer)
        Try
            If (Tabla = "Clientes") Then
                Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
                Dim query As String = "update clientes set Cliente=@Cliente , Correo=@Correo,Telefono=@Telefono where id =@Id"
                cn.Open()
                Dim command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@Cliente", Cliente)
                command.Parameters.AddWithValue("@Correo", Correo)
                command.Parameters.AddWithValue("@Telefono", Telefono)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                cn.Close()
            ElseIf (Tabla = "Productos") Then
                Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
                Dim query As String = "update Productos set Nombre=@Nombre , Precio=@Precio,Categoria=@Categoria where Id =@Id"
                cn.Open()
                Dim command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@Nombre", Cliente)
                command.Parameters.AddWithValue("@Categoria", Correo)
                command.Parameters.AddWithValue("@Precio", Telefono)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
    Public Sub UpdateVentas(PrecioUnitario As Integer, Cantidad As Integer, Preciototal As Integer, IdVentas As Integer, IdCliente As Integer, Fecha As DateTime)
        Try
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim query As String = "update ventasitems set  PrecioUnitario=@PrecioUnitario ,Cantidad=@Cantidad,PrecioTotal=@PrecioTotal 
            where IdVenta=@IdVentas update ventas set IdCliente=@IdCliente,Fecha=@Fecha,Total=@PrecioTotal where id=@IDVentas"
            cn.Open()
            Dim command As New SqlCommand(query, cn)
            command.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario)
            command.Parameters.AddWithValue("@Cantidad", Cantidad)
            command.Parameters.AddWithValue("@PrecioTotal", Preciototal)
            command.Parameters.AddWithValue("@IdVentas", IdVentas)
            command.Parameters.AddWithValue("@IdCliente", IdCliente)
            command.Parameters.AddWithValue("@Fecha", Fecha)
            command.ExecuteNonQuery()
            cn.Close()

        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
    Public Function filtroProductos(Campo As String, Criterio As String, Filtro As String)
        Try
            Dim Consulta As String = ("select * from productos where   ")
            Select Case Campo
                Case "Id"

                    Select Case (Criterio)
                        Case "Mayor a"
                            Consulta += "Id >" + Filtro

                        Case "Menor a"
                            Consulta += "Id <" + Filtro

                        Case Else
                            Consulta += "Id =" + Filtro
                    End Select

                Case "Precio"
                    Select Case (Criterio)
                        Case "Mayor a"
                            Consulta += "Precio >" + Filtro

                        Case "Menor a"
                            Consulta += "Precio <" + Filtro

                        Case Else
                            Consulta += "Precio =" + Filtro
                    End Select

                Case "Nombre"
                    Select Case (Criterio)

                        Case "Empieza con"
                            Consulta += "Nombre like '" + Filtro + "%'"

                        Case "Termina con"
                            Consulta += "Nombre like '%" + Filtro + "'"

                        Case "Contiene"
                            Consulta += "Nombre like '%" + Filtro + "%'"
                    End Select

                Case Else
                    Select Case (Criterio)

                        Case "Empieza con"
                            Consulta += "Categoria like '" + Filtro + "%'"

                        Case "Termina con"
                            Consulta += "Categoria like '%" + Filtro + "'"

                        Case "Contiene"
                            Consulta += "Categoria like '%" + Filtro + "%'"
                    End Select
            End Select
            Return Consulta
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Function
    Public Function filtroClientes(Campo As String, Criterio As String, Filtro As String)
        Try
            Dim Consulta As String = ("select * from clientes where   ")
            Select Case Campo
                Case "Id"

                    Select Case (Criterio)
                        Case "Mayor a"
                            Consulta += "Id >" + Filtro

                        Case "Menor a"
                            Consulta += "Id <" + Filtro

                        Case Else
                            Consulta += "Id =" + Filtro
                    End Select

                Case "Cliente"
                    Select Case (Criterio)

                        Case "Empieza con"
                            Consulta += "Cliente like '" + Filtro + "%'"

                        Case "Termina con"
                            Consulta += "Cliente like '%" + Filtro + "'"

                        Case "Contiene"
                            Consulta += "Cliente like '%" + Filtro + "%'"
                    End Select

                Case Else
                    Select Case (Criterio)

                        Case "Empieza con"
                            Consulta += "Correo like '" + Filtro + "%'"

                        Case "Termina con"
                            Consulta += "Correo like '%" + Filtro + "'"

                        Case "Contiene"
                            Consulta += "Correo like '%" + Filtro + "%'"
                    End Select
            End Select
            Return Consulta
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Function
    Public Function filtroVentas(Campo As String, Criterio As String, Filtro As String)
        Try
            Dim Consulta As String = ("select V.ID as CodigoDeVenta, P.Nombre As Producto, VI.Cantidad, V.Fecha, VI.PrecioUnitario,VI.PrecioTotal from ventas V,ventasitems VI, productos P where 
           V.Id = VI.IDVenta And P.Id = IDProducto and ")
            Select Case Campo

                Case "Codigo De Venta"

                    Select Case (Criterio)
                        Case "Mayor a"
                            Consulta += " V.ID >" + Filtro

                        Case "Menor a"
                            Consulta += " V.ID <" + Filtro

                        Case Else
                            Consulta += " V.ID =" + Filtro
                    End Select

                Case "Cantidad"
                    Select Case (Criterio)
                        Case "Mayor a"
                            Consulta += " VI.Cantidad >" + Filtro

                        Case "Menor a"
                            Consulta += " VI.Cantidad <" + Filtro

                        Case Else
                            Consulta += " VI.Cantidad =" + Filtro
                    End Select

                Case "Precio Total"
                    Select Case (Criterio)
                        Case "Mayor a"
                            Consulta += " VI.PrecioTotal >" + Filtro

                        Case "Menor a"
                            Consulta += " VI.PrecioTotal <" + Filtro

                        Case Else
                            Consulta += " VI.PrecioTotal =" + Filtro
                    End Select
                Case Else
                    Select Case (Criterio)

                        Case "Empieza con"
                            Consulta += " P.Nombre like '" + Filtro + "%'"

                        Case "Termina con"
                            Consulta += " P.Nombre like '%" + Filtro + "'"

                        Case "Contiene"
                            Consulta += " P.Nombre like '%" + Filtro + "%'"
                    End Select
            End Select
            Return Consulta
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Function
    Public Sub Eliminar(Tabla As String, Id As Integer)
        Try
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim query As String = ""
            If (Tabla = "Productos") Then
                query = "DELETE FROM productos WHERE ID = @Id"
            ElseIf (Tabla = "Ventas") Then
                cn.Open()
                Dim command1 As New SqlCommand("DELETE FROM ventasitems WHERE IDVenta = @Id", cn)
                command1.Parameters.AddWithValue("@Id", Id)
                command1.ExecuteNonQuery()
                Dim command2 As New SqlCommand("DELETE FROM ventas WHERE ID = @Id", cn)
                command2.Parameters.AddWithValue("@Id", Id)
                command2.ExecuteNonQuery()
                cn.Close()
                Return
            ElseIf (Tabla = "Clientes") Then
                query = "DELETE FROM clientes WHERE ID = @Id"
            End If
            If query <> "" Then
                cn.Open()
                Dim command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@Id", Id)
                command.ExecuteNonQuery()
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
End Module
