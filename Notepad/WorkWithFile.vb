Imports System.IO

Public NotInheritable Class WorkWithFile
    Public Shared Function ReadFile(FilePath As String) As String
        ReadFile = File.ReadAllText(FilePath)
    End Function

    Public Shared Sub WriteFile(FilePath As String, data As String)
        File.WriteAllText(FilePath, data)
    End Sub

    Public Shared Function GetNameByPath(FilePath As String) As String
        Dim position As Integer = FilePath.LastIndexOf("\") + 1
        GetNameByPath = FilePath.Substring(position)
    End Function

    Public Shared Function CheckExists(FilePath As String) As Boolean
        CheckExists = File.Exists(FilePath)
    End Function
End Class
