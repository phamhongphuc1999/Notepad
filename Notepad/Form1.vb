Public Class Form1
    Public Sub New()
        InitializeController()
        InitializeComponent()
    End Sub

    Private Sub NewToolStrip_Click(sender As Object, e As EventArgs) Handles NewToolStrip.Click
        MsgBox("Click")
    End Sub

    Private Sub OpenToolStrip_Click(sender As Object, e As EventArgs) Handles OpenToolStrip.Click
        Dim result As DialogResult = FileDlg.ShowDialog()
        If result = DialogResult.OK Then
            ChangeFormText(FileDlg.SafeFileName)
            Dim fileData = WorkWithFile.ReadFile(FileDlg.FileName)
            textArea.Text = fileData
        End If
    End Sub

End Class
