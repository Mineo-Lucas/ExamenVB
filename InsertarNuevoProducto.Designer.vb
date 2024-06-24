<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarNuevoProducto
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
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Precio = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 267)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(64, 20)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(170, 267)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(64, 20)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(79, 28)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre:"
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Location = New System.Drawing.Point(79, 97)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(40, 13)
        Me.Precio.TabIndex = 3
        Me.Precio.Text = "Precio:"
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(79, 176)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.LblCategoria.TabIndex = 4
        Me.LblCategoria.Text = "Categoria:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(82, 60)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(86, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(82, 133)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(86, 20)
        Me.TxtPrecio.TabIndex = 6
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Location = New System.Drawing.Point(82, 211)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(86, 20)
        Me.TxtCategoria.TabIndex = 7
        '
        'InsertarNuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 302)
        Me.Controls.Add(Me.TxtCategoria)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblCategoria)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "InsertarNuevoProducto"
        Me.Text = "InsertarNuevoProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblNombre As Label
    Friend WithEvents Precio As Label
    Friend WithEvents LblCategoria As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtCategoria As TextBox
End Class
