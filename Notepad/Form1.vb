Public Class Form1
    Friend IsNewFile As Boolean
    Friend FilePath As String

    Public Sub New()
        InitializeController()
        InitializeComponent()
        IsNewFile = True
    End Sub

#Region "FileToolStrip"
    Private Sub NewToolStrip_Click(sender As Object, e As EventArgs) Handles NewToolStrip.Click
        MsgBox("Click")
    End Sub

    Private Sub OpenToolStrip_Click(sender As Object, e As EventArgs) Handles OpenToolStrip.Click
        Dim result As DialogResult = FileDlg.ShowDialog()
        If result = DialogResult.OK Then
            ChangeFormText(FileDlg.SafeFileName)
            FilePath = FileDlg.FileName
            Dim fileData As String = WorkWithFile.ReadFile(FilePath)
            textArea.Text = fileData
            IsNewFile = False
        End If
    End Sub

    Private Sub SaveToolStrip_Click(sender As Object, e As EventArgs) Handles SaveToolStrip.Click
        If IsNewFile Then
            Dim result As DialogResult = SaveFileDlg.ShowDialog()
            If result = DialogResult.OK Then
                Dim check As Boolean = WorkWithFile.WriteNewFile(SaveFileDlg.FileName, textArea.Text)
                If Not check Then
                    MsgBox("Do Not Save File")
                    Return
                End If
                ChangeFormText(SaveFileDlg.FileName)
                IsNewFile = False
            End If
        Else

        End If


    End Sub

    Private Sub SaveAsToolStrip_Click(sender As Object, e As EventArgs) Handles SaveAsToolStrip.Click
        Dim result As DialogResult = SaveFileDlg.ShowDialog()
        If result = DialogResult.OK Then
            Dim check As Boolean = WorkWithFile.WriteNewFile(SaveFileDlg.FileName, textArea.Text)
            MsgBox(SaveFileDlg.FileNames)
            If Not check Then
                MsgBox("Do Not Save File")
            End If
        End If
    End Sub

    Private Sub TextArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textArea.KeyPress
        ChangeFormText("*" & Me.FileName)
    End Sub
#End Region
End Class
