<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.LblId = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.DgvClientes = New System.Windows.Forms.DataGridView()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.CbxCampo = New System.Windows.Forms.ComboBox()
        Me.CbxCriterio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(42, 94)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(19, 13)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "Id:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(42, 207)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 1
        Me.lblTelefono.Text = "Telefono:"
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(42, 143)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(42, 13)
        Me.LblCliente.TabIndex = 2
        Me.LblCliente.Text = "Cliente:"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(42, 273)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.LblCorreo.TabIndex = 3
        Me.LblCorreo.Text = "Correo:"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(115, 270)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(86, 20)
        Me.TxtCorreo.TabIndex = 4
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(115, 204)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(86, 20)
        Me.TxtTelefono.TabIndex = 5
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(115, 146)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(86, 20)
        Me.TxtCliente.TabIndex = 6
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(115, 90)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(86, 20)
        Me.TxtId.TabIndex = 7
        '
        'DgvClientes
        '
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvClientes.Location = New System.Drawing.Point(272, 76)
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.RowTemplate.Height = 25
        Me.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvClientes.Size = New System.Drawing.Size(373, 232)
        Me.DgvClientes.TabIndex = 8
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(137, 347)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(64, 20)
        Me.BtnModificar.TabIndex = 9
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(226, 347)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(64, 20)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(581, 347)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(64, 20)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(20, 347)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(87, 20)
        Me.BtnAgregar.TabIndex = 12
        Me.BtnAgregar.Text = "Agregar Nuevo"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(581, 33)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 20)
        Me.BtnBuscar.TabIndex = 13
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(384, 34)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(142, 20)
        Me.TxtFiltro.TabIndex = 14
        '
        'CbxCampo
        '
        Me.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCampo.FormattingEnabled = True
        Me.CbxCampo.Location = New System.Drawing.Point(66, 34)
        Me.CbxCampo.Name = "CbxCampo"
        Me.CbxCampo.Size = New System.Drawing.Size(109, 21)
        Me.CbxCampo.TabIndex = 15
        '
        'CbxCriterio
        '
        Me.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCriterio.FormattingEnabled = True
        Me.CbxCriterio.Location = New System.Drawing.Point(232, 34)
        Me.CbxCriterio.Name = "CbxCriterio"
        Me.CbxCriterio.Size = New System.Drawing.Size(108, 21)
        Me.CbxCriterio.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Filtro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Criterio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Campo:"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 390)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbxCriterio)
        Me.Controls.Add(Me.CbxCampo)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.DgvClientes)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.LblId)
        Me.Name = "Clientes"
        Me.Text = "clientes"
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents LblCliente As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents DgvClientes As DataGridView
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtFiltro As TextBox
    Friend WithEvents CbxCampo As ComboBox
    Friend WithEvents CbxCriterio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
