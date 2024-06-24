Imports System.Data.SqlClient
Imports System.Configuration
Public Class InsertarNuevoProducto

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            ' Llamar al método insert y pasar los valores directamente
            If (TxtNombre.Text <> "" And TxtCategoria.Text <> "" And TxtPrecio.Text <> "") Then
                Metodos.insert("Productos", TxtNombre.Text, TxtPrecio.Text, TxtCategoria.Text)
                MsgBox("Se registró correctamente")
            Else
                MsgBox("Completa todos los campos antes de insertar un nuevo producto")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString())
        End Try
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class