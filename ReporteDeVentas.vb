Imports System.Data.SqlClient
Imports System.Configuration
Public Class ReporteDeVentas
    Private Sub ReporteDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter("select V.ID as CodigoDeVenta, P.Nombre As Producto, VI.Cantidad, V.Fecha, VI.PrecioUnitario,
            VI.PrecioTotal, V.IDCliente from ventas V, ventasitems VI, productos P where 
            V.Id = VI.IDVenta And P.Id = IDProducto", cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvReporteDeVentas.DataSource = dt
            CbxCampo.Items.Add("Codigo De Venta")
            CbxCampo.Items.Add("Producto")
            CbxCampo.Items.Add("Cantidad")
            CbxCampo.Items.Add("Precio Total")
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim Consulta As String = Metodos.filtroVentas(CbxCampo.Text, CbxCriterio.Text, TxtFiltro.Text)
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter(Consulta, cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvReporteDeVentas.DataSource = dt
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class