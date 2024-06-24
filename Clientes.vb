Imports System.Data.SqlClient
Imports System.Configuration

Public Class Clientes
    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'carga de la tabla
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter("select * from clientes", cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvClientes.DataSource = dt
            'carga de los combobox
            CbxCampo.Items.Add("Id")
            CbxCampo.Items.Add("Cliente")
            CbxCampo.Items.Add("Correo")
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
    Private Sub DgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellClick
        'seleccionar valores y mostrarlos en texbox
        Try
            TxtId.Text = DgvClientes.SelectedCells(0).Value
            TxtCliente.Text = DgvClientes.SelectedCells(1).Value
            TxtTelefono.Text = DgvClientes.SelectedCells(2).Value
            TxtCorreo.Text = DgvClientes.SelectedCells(3).Value
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        'modificacion de los registros
        Try
            If (TxtCliente.Text <> "" And TxtCorreo.Text <> "" And TxtTelefono.Text <> "" And TxtId.Text <> "") Then
                Metodos.Update("Clientes", TxtCliente.Text, TxtCorreo.Text, TxtTelefono.Text, TxtId.Text)
            Else
                MsgBox("Completa todos los campos antes de modificar")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'eliminacion de los registros
        Try
            If (TxtId.Text <> "") Then
                Metodos.Eliminar("Clientes", TxtId.Text)
                MsgBox("El registro fue borrado")
            Else
                MsgBox("Selecciona un cliente para eliminar")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        InsertarNuevoCliente.Show()
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'filtros 
        Try
            Dim Consulta As String = Metodos.filtroClientes(CbxCampo.Text, CbxCriterio.Text, TxtFiltro.Text)
            Dim cn As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
            Dim comando As New SqlDataAdapter(Consulta, cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvClientes.DataSource = dt
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub CbxCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCampo.SelectedIndexChanged
        'carga de los combobox
        Try
            If (CbxCampo.Text = "Id") Then
                CbxCriterio.Items.Clear()
                CbxCriterio.Items.Add("Mayor a")
                CbxCriterio.Items.Add("Menor a")
                CbxCriterio.Items.Add("Igual a")
            Else
                CbxCriterio.Items.Clear()
                CbxCriterio.Items.Add("Empieza con")
                CbxCriterio.Items.Add("Termina con")
                CbxCriterio.Items.Add("Contiene")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
End Class