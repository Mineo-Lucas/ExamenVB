Imports System.Data.SqlClient


Public Class Form1
    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        Producto.Show()
        Me.Hide()
    End Sub
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Clientes.Show()
        Me.Hide()
    End Sub
    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReporteVentas_Click(sender As Object, e As EventArgs) Handles BtnReporteVentas.Click
        ReporteDeVentas.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReporteDeProductosVendidos_Click(sender As Object, e As EventArgs) Handles BtnReporteDeProductosVendidos.Click
        ReporteDeProductosVendidos.Show()
        Me.Hide()
    End Sub
End Class
