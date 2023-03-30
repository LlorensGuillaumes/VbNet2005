<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirFactura
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
        Me.CrvFactura = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvFactura
        '
        Me.CrvFactura.ActiveViewIndex = -1
        Me.CrvFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvFactura.DisplayGroupTree = False
        Me.CrvFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvFactura.EnableDrillDown = False
        Me.CrvFactura.Location = New System.Drawing.Point(0, 0)
        Me.CrvFactura.Name = "CrvFactura"
        Me.CrvFactura.SelectionFormula = ""
        Me.CrvFactura.ShowCloseButton = False
        Me.CrvFactura.ShowExportButton = False
        Me.CrvFactura.ShowGotoPageButton = False
        Me.CrvFactura.ShowGroupTreeButton = False
        Me.CrvFactura.ShowRefreshButton = False
        Me.CrvFactura.ShowTextSearchButton = False
        Me.CrvFactura.Size = New System.Drawing.Size(897, 603)
        Me.CrvFactura.TabIndex = 0
        Me.CrvFactura.TabStop = False
        Me.CrvFactura.ViewTimeSelectionFormula = ""
        '
        'ImprimirFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(897, 603)
        Me.Controls.Add(Me.CrvFactura)
        Me.Name = "ImprimirFactura"
        Me.Text = "FACTURA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvFactura As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
