<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TramitsUsuari
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
        Me.TextUsuari = New System.Windows.Forms.TextBox
        Me.TextContrasenya = New System.Windows.Forms.TextBox
        Me.BtnNouUsuari = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DgUsuaris = New System.Windows.Forms.DataGridView
        Me.BtnAutentificar = New System.Windows.Forms.Button
        CType(Me.DgUsuaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextUsuari
        '
        Me.TextUsuari.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextUsuari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextUsuari.Enabled = False
        Me.TextUsuari.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsuari.Location = New System.Drawing.Point(12, 39)
        Me.TextUsuari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextUsuari.Name = "TextUsuari"
        Me.TextUsuari.Size = New System.Drawing.Size(199, 20)
        Me.TextUsuari.TabIndex = 0
        '
        'TextContrasenya
        '
        Me.TextContrasenya.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextContrasenya.Location = New System.Drawing.Point(12, 67)
        Me.TextContrasenya.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextContrasenya.Name = "TextContrasenya"
        Me.TextContrasenya.Size = New System.Drawing.Size(199, 27)
        Me.TextContrasenya.TabIndex = 1
        Me.TextContrasenya.UseSystemPasswordChar = True
        '
        'BtnNouUsuari
        '
        Me.BtnNouUsuari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNouUsuari.Location = New System.Drawing.Point(312, 242)
        Me.BtnNouUsuari.Name = "BtnNouUsuari"
        Me.BtnNouUsuari.Size = New System.Drawing.Size(121, 42)
        Me.BtnNouUsuari.TabIndex = 2
        Me.BtnNouUsuari.Text = "NOU USUARI"
        Me.BtnNouUsuari.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(87, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SORTIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DgUsuaris
        '
        Me.DgUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgUsuaris.Location = New System.Drawing.Point(262, 39)
        Me.DgUsuaris.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgUsuaris.Name = "DgUsuaris"
        Me.DgUsuaris.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgUsuaris.Size = New System.Drawing.Size(171, 196)
        Me.DgUsuaris.TabIndex = 7
        '
        'BtnAutentificar
        '
        Me.BtnAutentificar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAutentificar.Location = New System.Drawing.Point(87, 101)
        Me.BtnAutentificar.Name = "BtnAutentificar"
        Me.BtnAutentificar.Size = New System.Drawing.Size(124, 42)
        Me.BtnAutentificar.TabIndex = 8
        Me.BtnAutentificar.Text = "AUTENTIFICAR"
        Me.BtnAutentificar.UseVisualStyleBackColor = True
        '
        'TramitsUsuari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 492)
        Me.Controls.Add(Me.BtnAutentificar)
        Me.Controls.Add(Me.DgUsuaris)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnNouUsuari)
        Me.Controls.Add(Me.TextContrasenya)
        Me.Controls.Add(Me.TextUsuari)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TramitsUsuari"
        Me.Text = "TRAMITS D'USUARIS"
        CType(Me.DgUsuaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextUsuari As System.Windows.Forms.TextBox
    Friend WithEvents TextContrasenya As System.Windows.Forms.TextBox
    Friend WithEvents BtnNouUsuari As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DgUsuaris As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAutentificar As System.Windows.Forms.Button
End Class
