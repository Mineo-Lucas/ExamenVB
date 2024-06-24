Imports System.Data.SqlClient
Imports System.Configuration
Public Class Producto
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga del combobox campo y la tabla
        Try
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter("select * from productos", cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvProductos.DataSource = dt
            CbxCampo.Items.Add("Id")
            CbxCampo.Items.Add("Nombre")
            CbxCampo.Items.Add("Precio")
            CbxCampo.Items.Add("Categoria")
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub
    Private Sub DgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellClick
        Try
            TxtId.Text = DgvProductos.SelectedCells(0).Value
            TxtNombre.Text = DgvProductos.SelectedCells(1).Value
            TxtPrecio.Text = DgvProductos.SelectedCells(2).Value
            TxtCategoria.Text = DgvProductos.SelectedCells(3).Value
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'eliminar datos
        Try
            If (TxtId.Text <> "") Then
                Metodos.Eliminar("Productos", TxtId.Text)
                MsgBox("El registro fue borrado")
            Else
                MsgBox("Seleccion un producto para eliminarlo")
            End If
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        'mandar datos para hacer el update en la funcion
        Try
            If (TxtNombre.Text <> "" And TxtCategoria.Text <> "" And TxtPrecio.Text <> "" And TxtId.Text <> "") Then
                Metodos.Update("Productos", TxtNombre.Text, TxtCategoria.Text, TxtPrecio.Text, TxtId.Text)
                MsgBox("El registro fue actualizado")
            Else
                MsgBox("Completa todos los campos antes de modificar")
            End If

        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        InsertarNuevoProducto.Show()
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'filtros
        Try
            Dim Consulta As String = Metodos.filtroProductos(CbxCampo.Text, CbxCriterio.Text, TxtBuscar.Text)
            Dim cn As New SqlConnection(ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString)
            Dim comando As New SqlDataAdapter(Consulta, cn)
            Dim dt As New DataTable
            comando.Fill(dt)
            DgvProductos.DataSource = dt
        Catch ex As Exception
            MsgBox("ha ocurrido un error", ex.ToString)
        End Try
    End Sub

    Private Sub CbxCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCampo.SelectedIndexChanged
        'carga del combobox criterio para los filtros
        Try
            If (CbxCampo.Text = "Nombre" Or CbxCampo.Text = "Categoria") Then
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
