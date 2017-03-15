Public Class Skip

  <System.ComponentModel.Browsable(True)> _
  <System.ComponentModel.DefaultValue("Skip:")> _
  Public Overrides Property Text() As String
    Get
      Return lblCaption.Text
    End Get
    Set(ByVal value As String)
      lblCaption.Text = value
    End Set
  End Property

  Property Value() As Integer
    Get
      If radAll.Checked Then Return -1
      Return CInt(numCt.Value)
    End Get
    Set(ByVal value As Integer)
      If value < 1 Then
        radAll.Checked = True
        radSome.Checked = False
      Else
        radAll.Checked = False
        radSome.Checked = True
        numCt.Value = value
      End If
    End Set
  End Property

  Private Sub radAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAll.CheckedChanged, radSome.CheckedChanged
    numCt.Enabled = radSome.Checked
  End Sub
End Class
