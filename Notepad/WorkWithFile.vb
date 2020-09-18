Public NotInheritable Class WorkWithFile
    Public Shared Function ReadFile(FilePath As String) As String
        ReadFile = My.Computer.FileSystem.ReadAllText(FilePath)
    End Function

    Public Shared Function WriteNewFile(FilePath As String, data As String) As Boolean
        Try
            My.Computer.FileSystem.WriteAllText(FilePath, data, True)
            WriteNewFile = True
        Catch ex As Exception
            WriteNewFile = False
        End Try
    End Function

    Public Shared Function GetNameByPath(FilePath As String) As String
        Dim position As Integer = FilePath.LastIndexOf("\") + 1
        GetNameByPath = FilePath.Substring(position)
    End Function
End Class
