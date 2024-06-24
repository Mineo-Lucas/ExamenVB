Imports System.Data.SqlClient
Imports System.Configuration
Public Class ReporteDeProductosVendidos
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DtpHora1.ValueChanged

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim query As String = "SELECT p.Nombre, vi.Cantidad, vi.PrecioTotal, v.Fecha FROM productos p, ventasitems vi, 
            Ventas v WHERE vi.IDVenta = v.ID AND vi.IDProducto = p.ID AND v.Fecha BETWEEN @fecha1 AND @fecha2"
            Dim comando As New SqlCommand(query, cn)
            comando.Parameters.AddWithValue("@fecha1", DtpHora1.Value)
            comando.Parameters.AddWithValue("@fecha2", DtpHora2.Value)
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DgvReporteProductos.DataSource = dt

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub


    Private Sub ReporteDeProductosVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter("Select p.Nombre, vi.Cantidad, vi.PrecioTotal, v.Fecha from productos p, ventasitems vi, Ventas v
             where vi.IDVenta = v.ID And vi.IDProducto = p.ID", cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvReporteProductos.DataSource = dt
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class