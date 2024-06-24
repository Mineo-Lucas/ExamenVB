Imports System.Data.SqlClient
Imports System.Configuration
Public Class InsertarNuevoCliente
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        'paso los datos al metodo el cual ya hace la consulta
        Try
            If (TxtCliente.Text <> "" And TxtCorreo.Text <> "" And TxtTelefono.Text <> "") Then
                Metodos.insert("Clientes", TxtCliente.Text, TxtTelefono.Text, TxtCorreo.Text)
                MsgBox("Se registró correctamente")
            Else
                MsgBox("Completa todos los campos antes de insertar un nuevo cliente")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString())
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Clientes.Show()
        Me.Close()
    End Sub
End Class