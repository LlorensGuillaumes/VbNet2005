<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirReco
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
        Me.CrvReco = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvReco
        '
        Me.CrvReco.ActiveViewIndex = -1
        Me.CrvReco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvReco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvReco.EnableDrillDown = False
        Me.CrvReco.Location = New System.Drawing.Point(0, 0)
        Me.CrvReco.Name = "CrvReco"
        Me.CrvReco.SelectionFormula = ""
        Me.CrvReco.ShowCloseButton = False
        Me.CrvReco.ShowExportButton = False
        Me.CrvReco.ShowGotoPageButton = False
        Me.CrvReco.ShowGroupTreeButton = False
        Me.CrvReco.ShowRefreshButton = False
        Me.CrvReco.ShowTextSearchButton = False
        Me.CrvReco.Size = New System.Drawing.Size(925, 628)
        Me.CrvReco.TabIndex = 0
        Me.CrvReco.ViewTimeSelectionFormula = ""
        '
        'ImprimirReco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 628)
        Me.Controls.Add(Me.CrvReco)
        Me.Name = "ImprimirReco"
        Me.Text = "IMPRIMIR"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvReco As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
