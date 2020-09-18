Public Class Form1

    Public Sub New()
        InitializeController()
        InitializeComponent()
        IsNewFile = True
    End Sub

#Region "FileToolStrip"
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlg As DialogResult = MsgBox(String.Format("Do you want to save changes to {0}?", Config.FileName), MsgBoxStyle.YesNoCancel, Title:="Notepad")
        If dlg = DialogResult.Yes Then

        End If
    End Sub

    Private Sub NewToolStrip_Click(sender As Object, e As EventArgs) Handles NewToolStrip.Click
        MsgBox("Click")
    End Sub

    Private Sub OpenToolStrip_Click(sender As Object, e As EventArgs) Handles OpenToolStrip.Click
        Dim result As DialogResult = FileDlg.ShowDialog()
        If result = DialogResult.OK Then
            ChangeFormText(FileDlg.SafeFileName)
            Config.FilePath = FileDlg.FileName
            Config.FileName = WorkWithFile.GetNameByPath(Config.FilePath)
            Dim fileData As String = WorkWithFile.ReadFile(Config.FilePath)
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
                Config.FilePath = SaveFileDlg.FileName
                Config.FileName = WorkWithFile.GetNameByPath(FilePath)
                ChangeFormText(FileName)
                IsNewFile = False
            End If
        Else
            Dim check As Boolean = WorkWithFile.WriteNewFile(FilePath, textArea.Text)
            If Not check Then
                MsgBox("Do Not Save File")
            End If
        End If
    End Sub

    Private Sub SaveAsToolStrip_Click(sender As Object, e As EventArgs) Handles SaveAsToolStrip.Click
        Dim result As DialogResult = SaveFileDlg.ShowDialog()
        If result = DialogResult.OK Then
            Dim check As Boolean = WorkWithFile.WriteNewFile(SaveFileDlg.FileName, textArea.Text)
            If Not check Then
                MsgBox("Do Not Save File")
                Return
            End If
            Config.FilePath = SaveFileDlg.FileName
            Config.FileName = WorkWithFile.GetNameByPath(Config.FilePath)
            ChangeFormText(Config.FileName)
        End If
    End Sub

    Private Sub ExitToolStrip_Click(sender As Object, e As EventArgs) Handles ExitToolStrip.Click
        Application.Exit()
    End Sub

    Private Sub TextArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textArea.KeyPress
        Dim NewFormText = String.Copy(Config.FileName)
        ChangeFormText("*" & NewFormText)
    End Sub
#End Region
End Class
