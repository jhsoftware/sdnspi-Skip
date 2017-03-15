Public Class OptionsUI

  Public Overrides Sub LoadData(ByVal config As String)
    If config Is Nothing Then Exit Sub 'new instance
    Skip1.Value = Integer.Parse(config)
  End Sub

  Public Overrides Function SaveData() As String
    Return Skip1.Value.ToString()
  End Function

End Class
