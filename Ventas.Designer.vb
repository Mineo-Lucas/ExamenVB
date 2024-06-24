<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtFiltrar = New System.Windows.Forms.TextBox()
        Me.CbxCriterio = New System.Windows.Forms.ComboBox()
        Me.CbxCampo = New System.Windows.Forms.ComboBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblCodigoDeVenta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblPrecioUnitario = New System.Windows.Forms.Label()
        Me.TxtCodigoDeVenta = New System.Windows.Forms.TextBox()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.LblPrecioTotal = New System.Windows.Forms.Label()
        Me.TxtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumeroDeCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvVentas
        '
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Location = New System.Drawing.Point(276, 67)
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.ReadOnly = True
        Me.DgvVentas.RowTemplate.Height = 25
        Me.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVentas.Size = New System.Drawing.Size(430, 231)
        Me.DgvVentas.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(11, 314)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(90, 20)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar Nuevo"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtFiltrar
        '
        Me.TxtFiltrar.Location = New System.Drawing.Point(377, 28)
        Me.TxtFiltrar.Name = "TxtFiltrar"
        Me.TxtFiltrar.Size = New System.Drawing.Size(139, 20)
        Me.TxtFiltrar.TabIndex = 2
        '
        'CbxCriterio
        '
        Me.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCriterio.FormattingEnabled = True
        Me.CbxCriterio.Location = New System.Drawing.Point(229, 28)
        Me.CbxCriterio.Name = "CbxCriterio"
        Me.CbxCriterio.Size = New System.Drawing.Size(104, 21)
        Me.CbxCriterio.TabIndex = 3
        '
        'CbxCampo
        '
        Me.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCampo.FormattingEnabled = True
        Me.CbxCampo.Location = New System.Drawing.Point(74, 28)
        Me.CbxCampo.Name = "CbxCampo"
        Me.CbxCampo.Size = New System.Drawing.Size(104, 21)
        Me.CbxCampo.TabIndex = 4
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(130, 314)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(93, 20)
        Me.BtnModificar.TabIndex = 5
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(250, 314)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 20)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(630, 314)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(64, 20)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(564, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 20)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LblCodigoDeVenta
        '
        Me.LblCodigoDeVenta.AutoSize = True
        Me.LblCodigoDeVenta.Location = New System.Drawing.Point(21, 74)
        Me.LblCodigoDeVenta.Name = "LblCodigoDeVenta"
        Me.LblCodigoDeVenta.Size = New System.Drawing.Size(88, 13)
        Me.LblCodigoDeVenta.TabIndex = 13
        Me.LblCodigoDeVenta.Text = "Codigo de venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Producto:"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(24, 167)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.LblCantidad.TabIndex = 15
        Me.LblCantidad.Text = "Cantidad:"
        '
        'LblPrecioUnitario
        '
        Me.LblPrecioUnitario.AutoSize = True
        Me.LblPrecioUnitario.Location = New System.Drawing.Point(24, 207)
        Me.LblPrecioUnitario.Name = "LblPrecioUnitario"
        Me.LblPrecioUnitario.Size = New System.Drawing.Size(77, 13)
        Me.LblPrecioUnitario.TabIndex = 16
        Me.LblPrecioUnitario.Text = "Precio unitario:"
        '
        'TxtCodigoDeVenta
        '
        Me.TxtCodigoDeVenta.Location = New System.Drawing.Point(120, 64)
        Me.TxtCodigoDeVenta.Name = "TxtCodigoDeVenta"
        Me.TxtCodigoDeVenta.ReadOnly = True
        Me.TxtCodigoDeVenta.Size = New System.Drawing.Size(103, 20)
        Me.TxtCodigoDeVenta.TabIndex = 17
        '
        'TxtProducto
        '
        Me.TxtProducto.Location = New System.Drawing.Point(120, 97)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(103, 20)
        Me.TxtProducto.TabIndex = 18
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(120, 161)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(103, 20)
        Me.TxtCantidad.TabIndex = 19
        '
        'TxtPrecioUnitario
        '
        Me.TxtPrecioUnitario.Location = New System.Drawing.Point(120, 201)
        Me.TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        Me.TxtPrecioUnitario.Size = New System.Drawing.Size(103, 20)
        Me.TxtPrecioUnitario.TabIndex = 20
        '
        'LblPrecioTotal
        '
        Me.LblPrecioTotal.AutoSize = True
        Me.LblPrecioTotal.Location = New System.Drawing.Point(24, 248)
        Me.LblPrecioTotal.Name = "LblPrecioTotal"
        Me.LblPrecioTotal.Size = New System.Drawing.Size(67, 13)
        Me.LblPrecioTotal.TabIndex = 21
        Me.LblPrecioTotal.Text = "Precio Total:"
        '
        'TxtPrecioTotal
        '
        Me.TxtPrecioTotal.Location = New System.Drawing.Point(120, 245)
        Me.TxtPrecioTotal.Name = "TxtPrecioTotal"
        Me.TxtPrecioTotal.Size = New System.Drawing.Size(103, 20)
        Me.TxtPrecioTotal.TabIndex = 22
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(24, 285)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(40, 13)
        Me.LblFecha.TabIndex = 23
        Me.LblFecha.Text = "Fecha:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(70, 279)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpFecha.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Numero de cliente:"
        '
        'TxtNumeroDeCliente
        '
        Me.TxtNumeroDeCliente.Location = New System.Drawing.Point(120, 124)
        Me.TxtNumeroDeCliente.Name = "TxtNumeroDeCliente"
        Me.TxtNumeroDeCliente.Size = New System.Drawing.Size(103, 20)
        Me.TxtNumeroDeCliente.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Campo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Criterio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Filtro:"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 357)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNumeroDeCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.TxtPrecioTotal)
        Me.Controls.Add(Me.LblPrecioTotal)
        Me.Controls.Add(Me.TxtPrecioUnitario)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.TxtCodigoDeVenta)
        Me.Controls.Add(Me.LblPrecioUnitario)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCodigoDeVenta)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.CbxCampo)
        Me.Controls.Add(Me.CbxCriterio)
        Me.Controls.Add(Me.TxtFiltrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DgvVentas)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtFiltrar As TextBox
    Friend WithEvents CbxCriterio As ComboBox
    Friend WithEvents CbxCampo As ComboBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblCodigoDeVenta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblPrecioUnitario As Label
    Friend WithEvents TxtCodigoDeVenta As TextBox
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtPrecioUnitario As TextBox
    Friend WithEvents LblPrecioTotal As Label
    Friend WithEvents TxtPrecioTotal As TextBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumeroDeCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
