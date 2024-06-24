Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports System.Configuration

Public Class InsertarNuevaVenta
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        'paso los datos al metodo el cual ya hace el insert de ventas
        Try
            If (CbxProductos.Text <> "" And TxtCantidad.Text <> "" And CbxProductos.Text <> "" And TxtPrecioTotal.Text <> "" And TxtPrecioUnitario.Text <> "") Then
                Metodos.InsertVentas(CbxProductos.SelectedValue, DtpFecha.Value, TxtPrecioTotal.Text)
                Metodos.InsertVentasItems(CbxProductos.SelectedValue, TxtPrecioUnitario.Text, TxtCantidad.Text, TxtPrecioTotal.Text)
            Else
                MsgBox("Completa todos los campos antes de insetar la venta")
            End If
            MsgBox("se registro correctamente")
        Catch ex As Exception
            MsgBox("ha ocurrido un error: " & ex.ToString())
        End Try

    End Sub

    Private Sub InsertarNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'llenando el combobox de productos
        Try
            Dim connectionString As String = "Data Source=DESKTOP-E7IU7EN\SQLEXPRESS;Initial Catalog=pruebademo ;Integrated Security=True"
            Dim query As String = "select Nombre,Id from productos"

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                With CbxProductos
                    .DataSource = table
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                End With
            End Using
        Catch ex As Exception
            MsgBox("ha ocurrido un error: " & ex.Message)
        End Try
    End Sub
End Class