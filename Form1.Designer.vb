<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Productos = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnReporteDeProductosVendidos = New System.Windows.Forms.Button()
        Me.BtnReporteVentas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Productos
        '
        Me.Productos.Location = New System.Drawing.Point(158, 101)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(339, 27)
        Me.Productos.TabIndex = 0
        Me.Productos.Text = "Productos"
        Me.Productos.UseVisualStyleBackColor = True
        '
        'BtnVentas
        '
        Me.BtnVentas.Location = New System.Drawing.Point(158, 209)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(339, 32)
        Me.BtnVentas.TabIndex = 1
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(158, 150)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(339, 29)
        Me.BtnClientes.TabIndex = 2
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnReporteDeProductosVendidos
        '
        Me.BtnReporteDeProductosVendidos.Location = New System.Drawing.Point(158, 330)
        Me.BtnReporteDeProductosVendidos.Name = "BtnReporteDeProductosVendidos"
        Me.BtnReporteDeProductosVendidos.Size = New System.Drawing.Size(339, 30)
        Me.BtnReporteDeProductosVendidos.TabIndex = 3
        Me.BtnReporteDeProductosVendidos.Text = "Reporte de productos vendidos"
        Me.BtnReporteDeProductosVendidos.UseVisualStyleBackColor = True
        '
        'BtnReporteVentas
        '
        Me.BtnReporteVentas.Location = New System.Drawing.Point(158, 268)
        Me.BtnReporteVentas.Name = "BtnReporteVentas"
        Me.BtnReporteVentas.Size = New System.Drawing.Size(339, 30)
        Me.BtnReporteVentas.TabIndex = 4
        Me.BtnReporteVentas.Text = "Reporte de ventas"
        Me.BtnReporteVentas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Examen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 390)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnReporteVentas)
        Me.Controls.Add(Me.BtnReporteDeProductosVendidos)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.Productos)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Productos As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnReporteDeProductosVendidos As Button
    Friend WithEvents BtnReporteVentas As Button
    Friend WithEvents Label1 As Label
End Class
