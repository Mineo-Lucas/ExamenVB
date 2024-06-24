<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteDeProductosVendidos
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DtpHora1 = New System.Windows.Forms.DateTimePicker()
        Me.DtpHora2 = New System.Windows.Forms.DateTimePicker()
        Me.DgvReporteProductos = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvReporteProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(389, 38)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 20)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DtpHora1
        '
        Me.DtpHora1.Location = New System.Drawing.Point(123, 12)
        Me.DtpHora1.Name = "DtpHora1"
        Me.DtpHora1.Size = New System.Drawing.Size(211, 20)
        Me.DtpHora1.TabIndex = 4
        '
        'DtpHora2
        '
        Me.DtpHora2.Location = New System.Drawing.Point(123, 38)
        Me.DtpHora2.Name = "DtpHora2"
        Me.DtpHora2.Size = New System.Drawing.Size(211, 20)
        Me.DtpHora2.TabIndex = 5
        '
        'DgvReporteProductos
        '
        Me.DgvReporteProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporteProductos.Location = New System.Drawing.Point(34, 78)
        Me.DgvReporteProductos.Name = "DgvReporteProductos"
        Me.DgvReporteProductos.Size = New System.Drawing.Size(457, 288)
        Me.DgvReporteProductos.TabIndex = 6
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(416, 372)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ventas desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta:"
        '
        'ReporteDeProductosVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 409)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DgvReporteProductos)
        Me.Controls.Add(Me.DtpHora2)
        Me.Controls.Add(Me.DtpHora1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Name = "ReporteDeProductosVendidos"
        Me.Text = "ReporteDeProductosVendidos"
        CType(Me.DgvReporteProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DtpHora1 As DateTimePicker
    Friend WithEvents DtpHora2 As DateTimePicker
    Friend WithEvents DgvReporteProductos As DataGridView
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
