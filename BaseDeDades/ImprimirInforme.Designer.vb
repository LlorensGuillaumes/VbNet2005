<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirInforme
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
        Me.CrvInforme = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrvInforme
        '
        Me.CrvInforme.ActiveViewIndex = -1
        Me.CrvInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrvInforme.DisplayGroupTree = False
        Me.CrvInforme.DisplayStatusBar = False
        Me.CrvInforme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrvInforme.EnableDrillDown = False
        Me.CrvInforme.Location = New System.Drawing.Point(0, 0)
        Me.CrvInforme.Name = "CrvInforme"
        Me.CrvInforme.SelectionFormula = ""
        Me.CrvInforme.ShowCloseButton = False
        Me.CrvInforme.ShowExportButton = False
        Me.CrvInforme.ShowGotoPageButton = False
        Me.CrvInforme.ShowGroupTreeButton = False
        Me.CrvInforme.ShowRefreshButton = False
        Me.CrvInforme.ShowTextSearchButton = False
        Me.CrvInforme.Size = New System.Drawing.Size(812, 610)
        Me.CrvInforme.TabIndex = 0
        Me.CrvInforme.ViewTimeSelectionFormula = ""
        '
        'ImprimirInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 610)
        Me.Controls.Add(Me.CrvInforme)
        Me.Name = "ImprimirInforme"
        Me.Text = "INFORME"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrvInforme As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
