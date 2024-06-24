Imports System.Data.SqlClient
Imports System.Configuration
Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter("select V.ID as CodigoDeVenta, P.Nombre As Producto, VI.Cantidad, V.Fecha, VI.PrecioUnitario,
            VI.PrecioTotal, V.IDCliente from ventas V, ventasitems VI, productos P where 
            V.Id = VI.IDVenta And P.Id = IDProducto", cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvVentas.DataSource = dt
            CbxCampo.Items.Add("Codigo De Venta")
            CbxCampo.Items.Add("Producto")
            CbxCampo.Items.Add("Cantidad")
            CbxCampo.Items.Add("Precio Total")
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            InsertarNuevaVenta.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            If (TxtProducto.Text <> "" And TxtCantidad.Text <> "" And TxtCodigoDeVenta.Text <> "" And TxtPrecioTotal.Text <> "" And TxtPrecioUnitario.Text <> "") Then
                Metodos.UpdateVentas(TxtPrecioUnitario.Text, TxtCantidad.Text, TxtPrecioTotal.Text, TxtCodigoDeVenta.Text, TxtNumeroDeCliente.Text, DtpFecha.Value)
                MsgBox("El registro fue actualizado")
            Else
                MsgBox("Completa todos los datos antes de Modificar")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
    Private Sub DgvVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVentas.CellClick
        Try
            TxtCodigoDeVenta.Text = DgvVentas.SelectedCells(0).Value
            TxtProducto.Text = DgvVentas.SelectedCells(1).Value
            TxtCantidad.Text = DgvVentas.SelectedCells(2).Value
            DtpFecha.Value = DgvVentas.SelectedCells(3).Value
            TxtPrecioUnitario.Text = DgvVentas.SelectedCells(4).Value
            TxtPrecioTotal.Text = DgvVentas.SelectedCells(5).Value
            TxtProducto.Text = DgvVentas.SelectedCells(6).Value
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If (TxtCodigoDeVenta.Text <> "") Then
                Metodos.Eliminar("Ventas", TxtCodigoDeVenta.Text)
                MsgBox("El registro fue borrado")
            Else
                MsgBox("Selecciona un registro para eliminarlo")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim Consulta As String = Metodos.filtroVentas(CbxCampo.Text, CbxCriterio.Text, TxtFiltrar.Text)
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter(Consulta, cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvVentas.DataSource = dt
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub CbxCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCampo.SelectedIndexChanged
        Try
            If (CbxCampo.Text = "Producto") Then
                CbxCriterio.Items.Clear()
                CbxCriterio.Items.Add("Empieza con")
                CbxCriterio.Items.Add("Termina con")
                CbxCriterio.Items.Add("Contiene")
            Else
                CbxCriterio.Items.Clear()
                CbxCriterio.Items.Add("Mayor a")
                CbxCriterio.Items.Add("Menor a")
                CbxCriterio.Items.Add("Igual a")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
End Class