Public NotInheritable Class WorkWithFile
    Public Shared Function ReadFile(FilePath As String) As String
        ReadFile = My.Computer.FileSystem.ReadAllText(FilePath)
    End Function
End Class
