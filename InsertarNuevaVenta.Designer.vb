<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarNuevaVenta
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblPrecioUnitario = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.TxtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.CbxProductos = New System.Windows.Forms.ComboBox()
        Me.LblNumeroDeCliente = New System.Windows.Forms.Label()
        Me.TxtNumeroDeCliente = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(169, 330)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(64, 20)
        Me.BtnCancelar.TabIndex = 0
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(30, 330)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(64, 20)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(27, 15)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(53, 13)
        Me.LblProducto.TabIndex = 3
        Me.LblProducto.Text = "Producto:"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(27, 58)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.LblCantidad.TabIndex = 4
        Me.LblCantidad.Text = "Cantidad:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(27, 106)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(40, 13)
        Me.LblFecha.TabIndex = 5
        Me.LblFecha.Text = "Fecha:"
        '
        'LblPrecioUnitario
        '
        Me.LblPrecioUnitario.AutoSize = True
        Me.LblPrecioUnitario.Location = New System.Drawing.Point(27, 157)
        Me.LblPrecioUnitario.Name = "LblPrecioUnitario"
        Me.LblPrecioUnitario.Size = New System.Drawing.Size(79, 13)
        Me.LblPrecioUnitario.TabIndex = 6
        Me.LblPrecioUnitario.Text = "Precio Unitario:"
        Me.LblPrecioUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Precio Total:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(30, 74)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(122, 20)
        Me.TxtCantidad.TabIndex = 10
        '
        'TxtPrecioUnitario
        '
        Me.TxtPrecioUnitario.Location = New System.Drawing.Point(30, 179)
        Me.TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        Me.TxtPrecioUnitario.Size = New System.Drawing.Size(122, 20)
        Me.TxtPrecioUnitario.TabIndex = 12
        '
        'TxtPrecioTotal
        '
        Me.TxtPrecioTotal.Location = New System.Drawing.Point(30, 226)
        Me.TxtPrecioTotal.Name = "TxtPrecioTotal"
        Me.TxtPrecioTotal.Size = New System.Drawing.Size(122, 20)
        Me.TxtPrecioTotal.TabIndex = 13
        '
        'CbxProductos
        '
        Me.CbxProductos.FormattingEnabled = True
        Me.CbxProductos.Location = New System.Drawing.Point(30, 31)
        Me.CbxProductos.Name = "CbxProductos"
        Me.CbxProductos.Size = New System.Drawing.Size(122, 21)
        Me.CbxProductos.TabIndex = 14
        '
        'LblNumeroDeCliente
        '
        Me.LblNumeroDeCliente.AutoSize = True
        Me.LblNumeroDeCliente.Location = New System.Drawing.Point(27, 263)
        Me.LblNumeroDeCliente.Name = "LblNumeroDeCliente"
        Me.LblNumeroDeCliente.Size = New System.Drawing.Size(96, 13)
        Me.LblNumeroDeCliente.TabIndex = 15
        Me.LblNumeroDeCliente.Text = "Numero de cliente:"
        '
        'TxtNumeroDeCliente
        '
        Me.TxtNumeroDeCliente.Location = New System.Drawing.Point(30, 279)
        Me.TxtNumeroDeCliente.Name = "TxtNumeroDeCliente"
        Me.TxtNumeroDeCliente.Size = New System.Drawing.Size(122, 20)
        Me.TxtNumeroDeCliente.TabIndex = 16
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(30, 122)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(203, 20)
        Me.DtpFecha.TabIndex = 17
        '
        'InsertarNuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 366)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.TxtNumeroDeCliente)
        Me.Controls.Add(Me.LblNumeroDeCliente)
        Me.Controls.Add(Me.CbxProductos)
        Me.Controls.Add(Me.TxtPrecioTotal)
        Me.Controls.Add(Me.TxtPrecioUnitario)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblPrecioUnitario)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblProducto)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "InsertarNuevaVenta"
        Me.Text = "InsertarNuevaVenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LblProducto As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblPrecioUnitario As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtPrecioUnitario As TextBox
    Friend WithEvents TxtPrecioTotal As TextBox
    Friend WithEvents CbxProductos As ComboBox
    Friend WithEvents LblNumeroDeCliente As Label
    Friend WithEvents TxtNumeroDeCliente As TextBox
    Friend WithEvents DtpFecha As DateTimePicker
End Class
