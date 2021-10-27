Imports JHSoftware.SimpleDNS.Plugin

Public Class SkipPlugIn
  Implements ISkip
  Implements IOptionsUI

  Dim SkipCount As Integer

  Public Property Host As IHost Implements IPlugInBase.Host

#Region "not implemented"
  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Function StartService() As System.Threading.Tasks.Task Implements IPlugInBase.StartService
    Return Threading.Tasks.Task.CompletedTask
  End Function

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

#End Region

  Public Function GetPlugInTypeInfo() As TypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetTypeInfo
    With GetPlugInTypeInfo
      .Name = "Skip"
      .Description = "Use to skip other plug-in instances"
      .InfoURL = "https://simpledns.plus/plugin-skip"
    End With
  End Function

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As Guid, ByVal dataPath As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
    SkipCount = Integer.Parse(config)
  End Sub

  Public Function LookupSkip(request As IRequestContext) As Threading.Tasks.Task(Of Integer) Implements ISkip.LookupSkip
    Return Threading.Tasks.Task.FromResult(SkipCount)
  End Function

  Public Function GetOptionsUI(ByVal instanceID As Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IOptionsUI.GetOptionsUI
    Return New OptionsUI
  End Function

End Class
