Public Class Form1
    Public Sub New()
        InitializeController()
        InitializeComponent()
    End Sub

#Region "FileToolStrip"
    Private Sub NewToolStrip_Click(sender As Object, e As EventArgs) Handles NewToolStrip.Click
        MsgBox("Click")
    End Sub

    Private Sub OpenToolStrip_Click(sender As Object, e As EventArgs) Handles OpenToolStrip.Click
        Dim result As DialogResult = FileDlg.ShowDialog()
        If result = DialogResult.OK Then
            ChangeFormText(FileDlg.SafeFileName)
            Dim fileData As String = WorkWithFile.ReadFile(FileDlg.FileName)
            textArea.Text = fileData
        End If
    End Sub

    Private Sub SaveAsToolStrip_Click(sender As Object, e As EventArgs) Handles SaveAsToolStrip.Click
        Dim result As DialogResult = SaveFileDlg.ShowDialog()
        If result = DialogResult.OK Then
            Dim check As Boolean = WorkWithFile.WriteNewFile(SaveFileDlg.FileName, textArea.Text)
            If Not check Then
                MsgBox("Do not save file")
            End If
        End If
    End Sub
#End Region
End Class
