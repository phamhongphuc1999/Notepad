<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Private Sub InitializeMenu()
        Me.NoteMenu = New MenuStrip()
        Me.FileToolStrip = New ToolStripMenuItem()
        Me.EditToolStrip = New ToolStripMenuItem()
        Me.FormatToolStrip = New ToolStripMenuItem()
        Me.ViewToolStrip = New ToolStripMenuItem()
        Me.HelpToolStrip = New ToolStripMenuItem()
        Me.NoteMenu.SuspendLayout()
        Me.SuspendLayout()

        'NoteMenu
        Me.NoteMenu.GripMargin = New Padding(2, 2, 0, 2)
        Me.NoteMenu.ImageScalingSize = New Size(24, 24)
        Me.NoteMenu.Items.AddRange(New ToolStripItem() {
            Me.FileToolStrip,
            Me.EditToolStrip,
            Me.FormatToolStrip,
            Me.ViewToolStrip,
            Me.HelpToolStrip
        })
        Me.NoteMenu.Location = New Point(0, 0)
        Me.NoteMenu.Name = "MenuStrip1"
        Me.NoteMenu.Size = New Size(800, 33)

        'FileToolStrip
        Me.NewToolStrip = New ToolStripMenuItem()
        Me.NewWindowToolStrip = New ToolStripMenuItem()
        Me.OpenToolStrip = New ToolStripMenuItem()
        Me.SaveToolStrip = New ToolStripMenuItem()
        Me.SaveAsToolStrip = New ToolStripMenuItem()
        Me.BottomSaveAsSeparator = New ToolStripSeparator()
        Me.PageSetupToolStrip = New ToolStripMenuItem()
        Me.PrintToolStrip = New ToolStripMenuItem()
        Me.BottomPrintSeparator = New ToolStripSeparator()
        Me.ExitToolStrip = New ToolStripMenuItem()

        Me.NewToolStrip.Text = "New"
        Me.NewWindowToolStrip.Text = "New Window"
        Me.OpenToolStrip.Text = "Open..."
        Me.SaveToolStrip.Text = "Save"
        Me.SaveAsToolStrip.Text = "Save As..."
        Me.PageSetupToolStrip.Text = "Page Setup..."
        Me.PrintToolStrip.Text = "Print..."
        Me.ExitToolStrip.Text = "Exit"

        Me.FileToolStrip.Text = "File"
        Me.FileToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            Me.NewToolStrip,
            Me.NewWindowToolStrip,
            Me.OpenToolStrip,
            Me.SaveToolStrip,
            Me.SaveAsToolStrip,
            Me.BottomSaveAsSeparator,
            Me.PageSetupToolStrip,
            Me.PrintToolStrip,
            Me.BottomPrintSeparator,
            Me.ExitToolStrip
        })

        'Edit
        Me.UndoToolStrip = New ToolStripMenuItem()
        Me.BottomUndoSeparator = New ToolStripSeparator()
        Me.CutToolStrip = New ToolStripMenuItem()
        Me.CopyToolStrip = New ToolStripMenuItem()
        Me.PasteToolStrip = New ToolStripMenuItem()
        Me.DeleteToolStrip = New ToolStripMenuItem()
        Me.BottomDeleteSeparator = New ToolStripSeparator()
        Me.SearchBingToolStrip = New ToolStripMenuItem()
        Me.FindToolStrip = New ToolStripMenuItem()
        Me.FindNextToolStrip = New ToolStripMenuItem()
        Me.FindPreviousToolStrip = New ToolStripMenuItem()
        Me.ReplaceToolStrip = New ToolStripMenuItem()
        Me.GotoToolStrip = New ToolStripMenuItem()
        Me.BottomGotoSeparator = New ToolStripSeparator()
        Me.SearchAllToolStrip = New ToolStripMenuItem()
        Me.TimeDateToolStrip = New ToolStripMenuItem()

        Me.UndoToolStrip.Text = "Undo"
        Me.UndoToolStrip.Enabled = False
        Me.CutToolStrip.Text = "Cut"
        Me.CutToolStrip.Enabled = False
        Me.CopyToolStrip.Text = "Copy"
        Me.CopyToolStrip.Enabled = False
        Me.PasteToolStrip.Text = "Paste"
        Me.DeleteToolStrip.Text = "Delete"
        Me.SearchBingToolStrip.Text = "Search With Bing..."
        Me.FindToolStrip.Text = "Find..."
        Me.FindToolStrip.Enabled = False
        Me.FindNextToolStrip.Text = "Find Next"
        Me.FindNextToolStrip.Enabled = False
        Me.FindPreviousToolStrip.Text = "Find Previous"
        Me.FindPreviousToolStrip.Enabled = False
        Me.ReplaceToolStrip.Text = "Replace..."
        Me.GotoToolStrip.Text = "Go To..."
        Me.SearchAllToolStrip.Text = "Search All..."
        Me.TimeDateToolStrip.Text = "Time/Date"

        Me.EditToolStrip.Text = "Edit"
        Me.EditToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            Me.UndoToolStrip,
            Me.BottomUndoSeparator,
            Me.CutToolStrip,
            Me.CopyToolStrip,
            Me.PasteToolStrip,
            Me.DeleteToolStrip,
            Me.BottomDeleteSeparator,
            Me.SearchBingToolStrip,
            Me.FindToolStrip,
            Me.FindNextToolStrip,
            Me.FindPreviousToolStrip,
            Me.ReplaceToolStrip,
            Me.GotoToolStrip,
            Me.BottomGotoSeparator,
            Me.SearchAllToolStrip,
            Me.TimeDateToolStrip
        })

        Me.FormatToolStrip.Text = "Format"
        Me.ViewToolStrip.Text = "View"
        Me.HelpToolStrip.Text = "Help"

        Me.Controls.Add(Me.NoteMenu)
        Me.MainMenuStrip = Me.NoteMenu

        Me.NoteMenu.ResumeLayout(False)
        Me.NoteMenu.PerformLayout()
    End Sub

    Private Sub InitializeController()
        Call InitializeMenu()
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form1"
        Me.Text = "Untitled - Notepad"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NoteMenu As MenuStrip
    Friend WithEvents FileToolStrip As ToolStripMenuItem
    Friend WithEvents EditToolStrip As ToolStripMenuItem
    Friend WithEvents FormatToolStrip As ToolStripMenuItem
    Friend WithEvents ViewToolStrip As ToolStripMenuItem
    Friend WithEvents HelpToolStrip As ToolStripMenuItem

    'FileToolStrip
    Friend WithEvents NewToolStrip As ToolStripMenuItem
    Friend WithEvents NewWindowToolStrip As ToolStripMenuItem
    Friend WithEvents OpenToolStrip As ToolStripMenuItem
    Friend WithEvents SaveToolStrip As ToolStripMenuItem
    Friend WithEvents SaveAsToolStrip As ToolStripMenuItem
    Friend WithEvents BottomSaveAsSeparator As ToolStripSeparator
    Friend WithEvents PageSetupToolStrip As ToolStripMenuItem
    Friend WithEvents PrintToolStrip As ToolStripMenuItem
    Friend WithEvents BottomPrintSeparator As ToolStripSeparator
    Friend WithEvents ExitToolStrip As ToolStripMenuItem

    'EditToolStrip
    Friend WithEvents UndoToolStrip As ToolStripMenuItem
    Friend WithEvents BottomUndoSeparator As ToolStripSeparator
    Friend WithEvents CutToolStrip As ToolStripMenuItem
    Friend WithEvents CopyToolStrip As ToolStripMenuItem
    Friend WithEvents PasteToolStrip As ToolStripMenuItem
    Friend WithEvents DeleteToolStrip As ToolStripMenuItem
    Friend WithEvents BottomDeleteSeparator As ToolStripSeparator
    Friend WithEvents SearchBingToolStrip As ToolStripMenuItem
    Friend WithEvents FindToolStrip As ToolStripMenuItem
    Friend WithEvents FindNextToolStrip As ToolStripMenuItem
    Friend WithEvents FindPreviousToolStrip As ToolStripMenuItem
    Friend WithEvents ReplaceToolStrip As ToolStripMenuItem
    Friend WithEvents GotoToolStrip As ToolStripMenuItem
    Friend WithEvents BottomGotoSeparator As ToolStripSeparator
    Friend WithEvents SearchAllToolStrip As ToolStripMenuItem
    Friend WithEvents TimeDateToolStrip As ToolStripMenuItem

    'FormatToolStrip
    Friend WithEvents WordWrapToolStrip As ToolStripMenuItem
    Friend WithEvents FontToolStrip As ToolStripMenuItem

    'ViewToolStrip

End Class
