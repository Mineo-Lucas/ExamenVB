<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteDeVentas
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
        Me.DgvReporteDeVentas = New System.Windows.Forms.DataGridView()
        Me.CbxCampo = New System.Windows.Forms.ComboBox()
        Me.CbxCriterio = New System.Windows.Forms.ComboBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.DgvReporteDeVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvReporteDeVentas
        '
        Me.DgvReporteDeVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporteDeVentas.Location = New System.Drawing.Point(21, 38)
        Me.DgvReporteDeVentas.Name = "DgvReporteDeVentas"
        Me.DgvReporteDeVentas.Size = New System.Drawing.Size(754, 365)
        Me.DgvReporteDeVentas.TabIndex = 0
        '
        'CbxCampo
        '
        Me.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCampo.FormattingEnabled = True
        Me.CbxCampo.Location = New System.Drawing.Point(21, 12)
        Me.CbxCampo.Name = "CbxCampo"
        Me.CbxCampo.Size = New System.Drawing.Size(121, 21)
        Me.CbxCampo.TabIndex = 1
        '
        'CbxCriterio
        '
        Me.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCriterio.FormattingEnabled = True
        Me.CbxCriterio.Location = New System.Drawing.Point(177, 11)
        Me.CbxCriterio.Name = "CbxCriterio"
        Me.CbxCriterio.Size = New System.Drawing.Size(121, 21)
        Me.CbxCriterio.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(551, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(328, 12)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(186, 20)
        Me.TxtFiltro.TabIndex = 4
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(700, 415)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'ReporteDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.CbxCriterio)
        Me.Controls.Add(Me.CbxCampo)
        Me.Controls.Add(Me.DgvReporteDeVentas)
        Me.Name = "ReporteDeVentas"
        Me.Text = "ReporteDeVentas"
        CType(Me.DgvReporteDeVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvReporteDeVentas As DataGridView
    Friend WithEvents CbxCampo As ComboBox
    Friend WithEvents CbxCriterio As ComboBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtFiltro As TextBox
    Friend WithEvents BtnSalir As Button
End Class
