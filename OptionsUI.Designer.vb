<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsUI
    Inherits JHSoftware.SimpleDNS.Plugin.OptionsUI

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.Skip1 = New Skip
    Me.SuspendLayout()
    '
    'Skip1
    '
    Me.Skip1.AutoSize = True
    Me.Skip1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.Skip1.Location = New System.Drawing.Point(0, 0)
    Me.Skip1.Name = "Skip1"
    Me.Skip1.Size = New System.Drawing.Size(210, 59)
    Me.Skip1.TabIndex = 0
    Me.Skip1.Value = -1
    '
    'OptionsUI
    '
    Me.Controls.Add(Me.Skip1)
    Me.Name = "OptionsUI"
    Me.Size = New System.Drawing.Size(239, 70)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Skip1 As Skip

End Class
