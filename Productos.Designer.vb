<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbxCampo = New System.Windows.Forms.ComboBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.CbxCriterio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvProductos
        '
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvProductos.Location = New System.Drawing.Point(202, 55)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.RowTemplate.Height = 25
        Me.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductos.Size = New System.Drawing.Size(446, 260)
        Me.DgvProductos.TabIndex = 0
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(88, 81)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(86, 20)
        Me.TxtId.TabIndex = 2
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(88, 147)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(86, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(88, 208)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(86, 20)
        Me.TxtPrecio.TabIndex = 4
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Location = New System.Drawing.Point(88, 265)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(86, 20)
        Me.TxtCategoria.TabIndex = 5
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(23, 84)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(19, 13)
        Me.LblId.TabIndex = 6
        Me.LblId.Text = "Id:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(23, 150)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 7
        Me.LblNombre.Text = "Nombre"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(23, 211)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.LblPrecio.TabIndex = 8
        Me.LblPrecio.Text = "Precio:"
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(23, 268)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.LblCategoria.TabIndex = 9
        Me.LblCategoria.Text = "Categoria:"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(23, 347)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(104, 20)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.Text = "Agregar Nuevo"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(225, 347)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(64, 20)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(144, 347)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(64, 20)
        Me.BtnModificar.TabIndex = 12
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(611, 347)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(64, 20)
        Me.BtnAtras.TabIndex = 13
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(584, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 20)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CbxCampo
        '
        Me.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCampo.FormattingEnabled = True
        Me.CbxCampo.Location = New System.Drawing.Point(70, 22)
        Me.CbxCampo.Name = "CbxCampo"
        Me.CbxCampo.Size = New System.Drawing.Size(104, 21)
        Me.CbxCampo.TabIndex = 15
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(373, 24)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(132, 20)
        Me.TxtBuscar.TabIndex = 16
        '
        'CbxCriterio
        '
        Me.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCriterio.FormattingEnabled = True
        Me.CbxCriterio.Location = New System.Drawing.Point(225, 24)
        Me.CbxCriterio.Name = "CbxCriterio"
        Me.CbxCriterio.Size = New System.Drawing.Size(104, 21)
        Me.CbxCriterio.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Campo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Criterio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Filtro:"
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbxCriterio)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.CbxCampo)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LblCategoria)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtCategoria)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.DgvProductos)
        Me.Name = "Producto"
        Me.Text = "Productos"
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvProductos As DataGridView
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblCategoria As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CbxCampo As ComboBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents CbxCriterio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
