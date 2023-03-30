<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NumFactura = New System.Windows.Forms.TextBox
        Me.DataEmisio = New System.Windows.Forms.TextBox
        Me.Client = New System.Windows.Forms.TextBox
        Me.Cif = New System.Windows.Forms.TextBox
        Me.Adreça = New System.Windows.Forms.TextBox
        Me.CP = New System.Windows.Forms.TextBox
        Me.Poblacio = New System.Windows.Forms.TextBox
        Me.Provincia = New System.Windows.Forms.TextBox
        Me.BtnSortir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'NumFactura
        '
        Me.NumFactura.Location = New System.Drawing.Point(14, 27)
        Me.NumFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumFactura.Name = "NumFactura"
        Me.NumFactura.Size = New System.Drawing.Size(98, 23)
        Me.NumFactura.TabIndex = 0
        Me.NumFactura.TabStop = False
        '
        'DataEmisio
        '
        Me.DataEmisio.Location = New System.Drawing.Point(14, 59)
        Me.DataEmisio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataEmisio.Name = "DataEmisio"
        Me.DataEmisio.Size = New System.Drawing.Size(98, 23)
        Me.DataEmisio.TabIndex = 1
        Me.DataEmisio.TabStop = False
        '
        'Client
        '
        Me.Client.Location = New System.Drawing.Point(118, 28)
        Me.Client.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(381, 23)
        Me.Client.TabIndex = 0
        '
        'Cif
        '
        Me.Cif.Location = New System.Drawing.Point(505, 28)
        Me.Cif.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cif.Name = "Cif"
        Me.Cif.Size = New System.Drawing.Size(170, 23)
        Me.Cif.TabIndex = 1
        '
        'Adreça
        '
        Me.Adreça.Location = New System.Drawing.Point(118, 59)
        Me.Adreça.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Adreça.Name = "Adreça"
        Me.Adreça.Size = New System.Drawing.Size(381, 23)
        Me.Adreça.TabIndex = 2
        '
        'CP
        '
        Me.CP.Location = New System.Drawing.Point(118, 90)
        Me.CP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(74, 23)
        Me.CP.TabIndex = 3
        '
        'Poblacio
        '
        Me.Poblacio.Location = New System.Drawing.Point(198, 90)
        Me.Poblacio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Poblacio.Name = "Poblacio"
        Me.Poblacio.Size = New System.Drawing.Size(301, 23)
        Me.Poblacio.TabIndex = 4
        '
        'Provincia
        '
        Me.Provincia.Location = New System.Drawing.Point(118, 121)
        Me.Provincia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(215, 23)
        Me.Provincia.TabIndex = 5
        '
        'BtnSortir
        '
        Me.BtnSortir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSortir.Location = New System.Drawing.Point(597, 189)
        Me.BtnSortir.Name = "BtnSortir"
        Me.BtnSortir.Size = New System.Drawing.Size(96, 40)
        Me.BtnSortir.TabIndex = 6
        Me.BtnSortir.Text = "OK"
        Me.BtnSortir.UseVisualStyleBackColor = True
        '
        'ModificarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(738, 325)
        Me.Controls.Add(Me.BtnSortir)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.Poblacio)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.Adreça)
        Me.Controls.Add(Me.Cif)
        Me.Controls.Add(Me.Client)
        Me.Controls.Add(Me.DataEmisio)
        Me.Controls.Add(Me.NumFactura)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ModificarFactura"
        Me.Text = "MODIFICAR FACTURA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumFactura As System.Windows.Forms.TextBox
    Friend WithEvents DataEmisio As System.Windows.Forms.TextBox
    Friend WithEvents Client As System.Windows.Forms.TextBox
    Friend WithEvents Cif As System.Windows.Forms.TextBox
    Friend WithEvents Adreça As System.Windows.Forms.TextBox
    Friend WithEvents CP As System.Windows.Forms.TextBox
    Friend WithEvents Poblacio As System.Windows.Forms.TextBox
    Friend WithEvents Provincia As System.Windows.Forms.TextBox
    Friend WithEvents BtnSortir As System.Windows.Forms.Button
End Class
