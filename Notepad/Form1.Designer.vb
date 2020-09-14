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

#Region "Main Menu"
    Private Sub InitializeFileMenu()
        NewToolStrip = New ToolStripMenuItem()
        With NewToolStrip
            .Text = "New"
            .ShortcutKeys = Shortcut.CtrlN
        End With

        NewWindowToolStrip = New ToolStripMenuItem()
        With NewWindowToolStrip
            .Text = "New Window"
            .ShortcutKeys = Shortcut.CtrlShiftN
        End With

        OpenToolStrip = New ToolStripMenuItem()
        With OpenToolStrip
            .Text = "Open..."
            .ShortcutKeys = Shortcut.CtrlO
        End With

        SaveToolStrip = New ToolStripMenuItem()
        With SaveToolStrip
            .Text = "Save"
            .ShortcutKeys = Shortcut.CtrlS
        End With

        SaveAsToolStrip = New ToolStripMenuItem()
        With SaveAsToolStrip
            .Text = "Save As..."
            .ShortcutKeys = Shortcut.CtrlShiftS
        End With

        BottomSaveAsSeparator = New ToolStripSeparator()

        PageSetupToolStrip = New ToolStripMenuItem()
        PageSetupToolStrip.Text = "Page Setup..."

        PrintToolStrip = New ToolStripMenuItem()
        With PrintToolStrip
            .Text = "Print..."
            .ShortcutKeys = Shortcut.CtrlP
        End With

        BottomPrintSeparator = New ToolStripSeparator()

        ExitToolStrip = New ToolStripMenuItem()
        ExitToolStrip.Text = "Exit"

        FileToolStrip = New ToolStripMenuItem()
        FileToolStrip.Text = "File"
        FileToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            NewToolStrip,
            NewWindowToolStrip,
            OpenToolStrip,
            SaveToolStrip,
            SaveAsToolStrip,
            BottomSaveAsSeparator,
            PageSetupToolStrip,
            PrintToolStrip,
            BottomPrintSeparator,
            ExitToolStrip
        })
    End Sub

    Private Sub InitializeEditMenu()
        UndoToolStrip = New ToolStripMenuItem()
        With UndoToolStrip
            .Text = "Undo"
            .Enabled = False
            .ShortcutKeys = Shortcut.CtrlZ
        End With

        BottomUndoSeparator = New ToolStripSeparator()

        CutToolStrip = New ToolStripMenuItem()
        With CutToolStrip
            .Text = "Cut"
            .Enabled = False
            .ShortcutKeys = Shortcut.CtrlX
        End With

        CopyToolStrip = New ToolStripMenuItem()
        With CopyToolStrip
            .Text = "Copy"
            .Enabled = False
            .ShortcutKeys = Shortcut.CtrlC
        End With

        PasteToolStrip = New ToolStripMenuItem()
        With PasteToolStrip
            .Text = "Paste"
            .ShortcutKeys = Shortcut.CtrlV
        End With

        DeleteToolStrip = New ToolStripMenuItem()
        With DeleteToolStrip
            .Text = "Delete"
            .ShortcutKeys = Shortcut.Del
        End With

        BottomDeleteSeparator = New ToolStripSeparator()

        SearchBingToolStrip = New ToolStripMenuItem()
        With SearchBingToolStrip
            .Text = "Search With Bing..."
            .ShortcutKeys = Shortcut.CtrlE
        End With

        FindToolStrip = New ToolStripMenuItem()
        With FindToolStrip
            .Text = "Find..."
            .Enabled = False
            .ShortcutKeys = Shortcut.CtrlF
        End With

        FindNextToolStrip = New ToolStripMenuItem()
        With FindNextToolStrip
            .Text = "Find Next"
            .Enabled = False
            .ShortcutKeys = Shortcut.F3
        End With

        FindPreviousToolStrip = New ToolStripMenuItem()
        With FindPreviousToolStrip
            .Text = "Find Previous"
            .Enabled = False
            .ShortcutKeys = Shortcut.ShiftF3
        End With

        ReplaceToolStrip = New ToolStripMenuItem()
        With ReplaceToolStrip
            .Text = "Replace..."
            .ShortcutKeys = Shortcut.CtrlH
        End With

        GotoToolStrip = New ToolStripMenuItem()
        With GotoToolStrip
            .Text = "Go To..."
            .ShortcutKeys = Shortcut.CtrlG
        End With

        BottomGotoSeparator = New ToolStripSeparator()

        SearchAllToolStrip = New ToolStripMenuItem()
        With SearchAllToolStrip
            .Text = "Search All..."
            .ShortcutKeys = Shortcut.CtrlA
        End With

        TimeDateToolStrip = New ToolStripMenuItem()
        With TimeDateToolStrip
            .Text = "Time/Date"
            .ShortcutKeys = Shortcut.F5
        End With

        EditToolStrip = New ToolStripMenuItem()
        EditToolStrip.Text = "Edit"
        EditToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            UndoToolStrip,
            BottomUndoSeparator,
            CutToolStrip,
            CopyToolStrip,
            PasteToolStrip,
            DeleteToolStrip,
            BottomDeleteSeparator,
            SearchBingToolStrip,
            FindToolStrip,
            FindNextToolStrip,
            FindPreviousToolStrip,
            ReplaceToolStrip,
            GotoToolStrip,
            BottomGotoSeparator,
            SearchAllToolStrip,
            TimeDateToolStrip
        })
    End Sub

    Private Sub InitializeMenu()
        NoteMenu = New MenuStrip()
        InitializeFileMenu()
        InitializeEditMenu()
        FormatToolStrip = New ToolStripMenuItem()
        ViewToolStrip = New ToolStripMenuItem()
        HelpToolStrip = New ToolStripMenuItem()
        NoteMenu.SuspendLayout()
        Me.SuspendLayout()

        'NoteMenu
        NoteMenu.GripMargin = New Padding(2, 2, 0, 2)
        NoteMenu.ImageScalingSize = New Size(24, 24)
        NoteMenu.Items.AddRange(New ToolStripItem() {
            FileToolStrip,
            EditToolStrip,
            FormatToolStrip,
            ViewToolStrip,
            HelpToolStrip
        })
        NoteMenu.Location = New Point(0, 0)
        NoteMenu.Name = "MenuStrip1"
        NoteMenu.Size = New Size(800, 33)

#Region "FormatToolStrip"
        WordWrapToolStrip = New ToolStripMenuItem()
        FontToolStrip = New ToolStripMenuItem()

        WordWrapToolStrip.Text = "Word Wrap"
        FontToolStrip.Text = "Font..."

        FormatToolStrip.Text = "Format"
        FormatToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            WordWrapToolStrip,
            FontToolStrip
        })
#End Region

#Region "ViewToolStrip"
        ZoomInToolStrip = New ToolStripMenuItem()
        ZoomOutToolStrip = New ToolStripMenuItem()
        ResotreDefaultZoomToolStrip = New ToolStripMenuItem()
        StatusToolBut = New ToolStripButton()
        ZoomInToolStrip.Text = "Zoom In"
        ZoomOutToolStrip.Text = "Zoom Out"
        ResotreDefaultZoomToolStrip.Text = "Restore Default Zoom"
        StatusToolBut.Text = "True"

        ZoomToolStrip = New ToolStripMenuItem()
        ZoomToolStrip.Text = "Zoom"
        ZoomToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            ZoomInToolStrip,
            ZoomOutToolStrip,
            ResotreDefaultZoomToolStrip
        })

        ViewToolStrip.Text = "View"
        ViewToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            ZoomToolStrip,
            StatusToolBut
        })
#End Region

#Region "HelpToolStrip"
        ViewHelpToolStrip = New ToolStripMenuItem()
        SendFeedbackToolStrip = New ToolStripMenuItem()
        BottomSendFeedbackSeparator = New ToolStripSeparator()
        AboutNoteToolStrip = New ToolStripMenuItem()

        ViewHelpToolStrip.Text = "View Help"
        SendFeedbackToolStrip.Text = "Send Feedback"
        AboutNoteToolStrip.Text = "About Notepad"

        HelpToolStrip.Text = "Help"
        HelpToolStrip.DropDownItems.AddRange(New ToolStripItem() {
            ViewHelpToolStrip,
            SendFeedbackToolStrip,
            BottomSendFeedbackSeparator,
            AboutNoteToolStrip
        })
#End Region

        Me.Controls.Add(NoteMenu)
        Me.MainMenuStrip = NoteMenu

        NoteMenu.ResumeLayout(False)
        NoteMenu.PerformLayout()
    End Sub

    Private Sub InitializeContextMenu()
        MainContextMenu = New ContextMenuStrip()
        'UndoContextStrip = New ToolStripItem()
        UndoContextStrip.Text = "Undo"
        BottomUndoContextSeparator = New ToolStripSeparator()
        'CutContextStrip = New ToolStripItem()
        'CopyContextStrip = New ToolStripItem()
        'PasteContextStrip = New ToolStripItem()
        'DeleteContextStrip = New ToolStripItem()

        MainContextMenu.Items.AddRange(New ToolStripItem() {
            UndoContextStrip,
            CutContextStrip,
            CopyContextStrip,
            PasteContextStrip,
            DeleteContextStrip
        })

        Me.Controls.Add(MainContextMenu)
    End Sub
#End Region

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
    Friend WithEvents ZoomToolStrip As ToolStripMenuItem
    Friend WithEvents ZoomInToolStrip As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStrip As ToolStripMenuItem
    Friend WithEvents ResotreDefaultZoomToolStrip As ToolStripMenuItem
    Friend WithEvents StatusToolBut As ToolStripButton

    'HelpToolStrip
    Friend WithEvents ViewHelpToolStrip As ToolStripMenuItem
    Friend WithEvents SendFeedbackToolStrip As ToolStripMenuItem
    Friend WithEvents BottomSendFeedbackSeparator As ToolStripSeparator
    Friend WithEvents AboutNoteToolStrip As ToolStripMenuItem

    'ContextMenu
    Friend WithEvents MainContextMenu As ContextMenuStrip
    Friend WithEvents UndoContextStrip As ToolStripItem
    Friend WithEvents BottomUndoContextSeparator As ToolStripSeparator
    Friend WithEvents CutContextStrip As ToolStripItem
    Friend WithEvents CopyContextStrip As ToolStripItem
    Friend WithEvents PasteContextStrip As ToolStripItem
    Friend WithEvents DeleteContextStrip As ToolStripItem
End Class
