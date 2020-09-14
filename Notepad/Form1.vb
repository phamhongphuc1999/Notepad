Public Class Form1
    Public Sub New()
        InitializeController()
        InitializeComponent()
    End Sub

    Private Sub NewToolStrip_Click(sender As Object, e As EventArgs) Handles NewToolStrip.Click
        MsgBox("Click")
    End Sub

End Class
