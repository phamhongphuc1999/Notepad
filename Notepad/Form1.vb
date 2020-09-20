Public Class Form1

    Public Sub New()
        InitializeController()
        InitializeComponent()
    End Sub

#Region "FileToolStrip"
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Config.IsSavedFile Then
            Dim dlg As DialogResult = MsgBox(String.Format("Do you want to save changes to {0}?", Config.FileName), MsgBoxStyle.YesNoCancel, Title:="Notepad")
            If dlg = DialogResult.Yes Then
                If Config.FilePath = "" Then
                    Dim result As DialogResult = SaveFileDlg.ShowDialog()
                    If result = DialogResult.OK Then
                        Dim FilePath As String = SaveFileDlg.FileName
                        WorkWithFile.WriteFile(SaveFileDlg.FileName, textArea.Text)
                    Else e.Cancel = True
                    End If
                Else SaveToolStrip_Click(SaveToolStrip, New EventArgs())
                End If
            ElseIf dlg = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub NewToolStrip_Click(sender As Object, e As EventArgs) Handles NewToolStrip.Click
        MsgBox("Click")
    End Sub

    Private Sub OpenToolStrip_Click(sender As Object, e As EventArgs) Handles OpenToolStrip.Click
        Dim result As DialogResult = FileDlg.ShowDialog()
        If result = DialogResult.OK Then
            Me.Text = FileDlg.SafeFileName
            Config.FilePath = FileDlg.FileName
            Config.FileName = WorkWithFile.GetNameByPath(Config.FilePath)
            Dim fileData As String = WorkWithFile.ReadFile(Config.FilePath)
            textArea.Text = fileData
            Config.IsSavedFile = True
        End If
    End Sub

    Private Sub SaveToolStrip_Click(sender As Object, e As EventArgs) Handles SaveToolStrip.Click
        If Config.FilePath = "" Then
            SaveAsToolStrip_Click(SaveAsToolStrip, New EventArgs())
            Return
        End If
        WorkWithFile.WriteFile(Config.FilePath, textArea.Text)
        If Not Config.IsSavedFile Then
            Me.Text = Config.FileName.Substring(0)
            Config.FileName = Me.Text
            Config.IsSavedFile = True
        End If
    End Sub

    Private Sub SaveAsToolStrip_Click(sender As Object, e As EventArgs) Handles SaveAsToolStrip.Click
        Dim result As DialogResult = SaveFileDlg.ShowDialog()
        If result = DialogResult.OK Then
            Dim FilePath As String = SaveFileDlg.FileName
            WorkWithFile.WriteFile(SaveFileDlg.FileName, textArea.Text)
            Config.FilePath = FilePath
            Config.FileName = WorkWithFile.GetNameByPath(Config.FilePath)
            Me.Text = Config.FileName
            Config.IsSavedFile = True
        End If
    End Sub

    Private Sub ExitToolStrip_Click(sender As Object, e As EventArgs) Handles ExitToolStrip.Click
        Application.Exit()
    End Sub

    Private Sub TextArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textArea.KeyPress
        If Config.IsSavedFile Then
            ChangeFormText("*" & Config.FileName)
            Config.IsSavedFile = False
        End If
    End Sub
#End Region
End Class
