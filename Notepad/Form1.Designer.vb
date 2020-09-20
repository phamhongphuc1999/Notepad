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

    Private Sub ChangeFormText(FileName As String)
        Me.Text = FileName & Config.NotepadText
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

#Region "Main Menu And Main Context Menu"
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

    Private Sub InitializeContextInsertUnicode()
        LRMContextStrip = New ToolStripMenuItem()
        LRMContextStrip.Text = "LRM"

        RLMContextStrip = New ToolStripMenuItem()
        RLMContextStrip.Text = "RLM"

        ZWJContextStrip = New ToolStripMenuItem()
        ZWJContextStrip.Text = "ZWJ"

        ZWNJContextStrip = New ToolStripMenuItem()
        ZWNJContextStrip.Text = "ZWNJ"

        LREContextStrip = New ToolStripMenuItem()
        LREContextStrip.Text = "LRE"

        RLEContextStrip = New ToolStripMenuItem()
        RLEContextStrip.Text = "RLE"

        LROContextStrip = New ToolStripMenuItem()
        LROContextStrip.Text = "LRO"

        RLOContextStrip = New ToolStripMenuItem()
        RLOContextStrip.Text = "RLO"

        PDFContextStrip = New ToolStripMenuItem()
        PDFContextStrip.Text = "PDF"

        NADSContextStrip = New ToolStripMenuItem()
        NADSContextStrip.Text = "NADS"

        NODSContextStrip = New ToolStripMenuItem()
        NODSContextStrip.Text = "NODS"

        ASSContextStrip = New ToolStripMenuItem()
        ASSContextStrip.Text = "ASS"

        ISSContextStrip = New ToolStripMenuItem()
        ISSContextStrip.Text = "ISS"

        AAFSContextStrip = New ToolStripMenuItem()
        AAFSContextStrip.Text = "AAFS"

        IAFSContextStrip = New ToolStripMenuItem()
        IAFSContextStrip.Text = "IAFS"

        RSContextStrip = New ToolStripMenuItem()
        RSContextStrip.Text = "RS"

        USSContextStrip = New ToolStripMenuItem()
        USSContextStrip.Text = "US"

        InsertUnicodeContextStrip = New ToolStripMenuItem()
        InsertUnicodeContextStrip.Text = "Insert Unicode Control Characters"
        InsertUnicodeContextStrip.DropDownItems.AddRange(New ToolStripItem() {
            LRMContextStrip,
            RLEContextStrip,
            ZWJContextStrip,
            ZWNJContextStrip,
            LREContextStrip,
            RLEContextStrip,
            LROContextStrip,
            RLOContextStrip,
            PDFContextStrip,
            NADSContextStrip,
            NODSContextStrip,
            ASSContextStrip,
            ISSContextStrip,
            AAFSContextStrip,
            IAFSContextStrip,
            RSContextStrip,
            USSContextStrip
        })
    End Sub

    Private Sub InitializeContextMenu()
        UndoContextStrip = New ToolStripMenuItem()
        UndoContextStrip.Text = "Undo"
        UndoContextStrip.Enabled = False

        BottomUndoContextSeparator = New ToolStripSeparator()

        CutContextStrip = New ToolStripMenuItem()
        CutContextStrip.Text = "Cut"
        CutContextStrip.Enabled = False

        CopyContextStrip = New ToolStripMenuItem()
        CopyContextStrip.Text = "Copy"
        CopyContextStrip.Text = False

        PasteContextStrip = New ToolStripMenuItem()
        PasteContextStrip.Text = "Paste"

        DeleteContextStrip = New ToolStripMenuItem()
        DeleteContextStrip.Text = "Delete"
        DeleteContextStrip.Enabled = False

        BottomDeleteContextSeparator = New ToolStripSeparator()

        SelectAllContextStrip = New ToolStripMenuItem()
        SelectAllContextStrip.Text = "Slect All"
        SelectAllContextStrip.Enabled = False

        BottomSelectAllContextSeparator = New ToolStripSeparator()

        RightToLeftContextStrip = New ToolStripMenuItem()
        RightToLeftContextStrip.Text = "Right to left Reading order"

        ShowUnicodeContextStrip = New ToolStripButton()
        ShowUnicodeContextStrip.Text = "Show Unicode Control characters"

        BottomInsertUnicodeContextSeparator = New ToolStripSeparator()

        OpenIMEContextStrip = New ToolStripMenuItem()
        OpenIMEContextStrip.Text = "Open IME"

        ReconversionContextStrip = New ToolStripMenuItem()
        ReconversionContextStrip.Text = "Recoversion"
        ReconversionContextStrip.Enabled = False

        BottomReconversionContextSeparator = New ToolStripSeparator()

        SearchWithBingContextStrip = New ToolStripMenuItem()
        SearchWithBingContextStrip.Text = "Search With bing..."

        InitializeContextInsertUnicode()

        MainContextMenu = New ContextMenuStrip()
        MainContextMenu.Width = 100
        MainContextMenu.Items.AddRange(New ToolStripItem() {
            UndoContextStrip,
            BottomUndoContextSeparator,
            CutContextStrip,
            CopyContextStrip,
            PasteContextStrip,
            DeleteContextStrip,
            BottomDeleteContextSeparator,
            SelectAllContextStrip,
            BottomSelectAllContextSeparator,
            RightToLeftContextStrip,
            ShowUnicodeContextStrip,
            InsertUnicodeContextStrip,
            OpenIMEContextStrip,
            ReconversionContextStrip,
            SearchWithBingContextStrip
        })

        Me.ContextMenuStrip = MainContextMenu
    End Sub
#End Region

    Private Sub InitializeController()
        Call InitializeMenu()
        Call InitializeContextMenu()

        FileDlg = New OpenFileDialog()
        FileDlg.Title = "Open File Dialog"
        FileDlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        FileDlg.FilterIndex = 2
        FileDlg.RestoreDirectory = True

        SaveFileDlg = New SaveFileDialog()
        SaveFileDlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"

        textArea = New RichTextBox()
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        FileName = "Untitled"
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form1"
        Me.Icon = New Icon("../../Resources/Images/notepad.ico")
        Me.Text = FileName & Config.NotepadText
        Me.ResumeLayout(False)

        textArea.Location = New Point(0, NoteMenu.Height)
        textArea.Size = New Size(Me.Width, Me.Height - NoteMenu.Height)
        Me.Controls.Add(textArea)
    End Sub

    Friend WithEvents FileDlg As OpenFileDialog
    Friend WithEvents SaveFileDlg As SaveFileDialog

    Friend WithEvents textArea As RichTextBox

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
    Friend WithEvents UndoContextStrip As ToolStripMenuItem
    Friend WithEvents BottomUndoContextSeparator As ToolStripSeparator
    Friend WithEvents CutContextStrip As ToolStripMenuItem
    Friend WithEvents CopyContextStrip As ToolStripMenuItem
    Friend WithEvents PasteContextStrip As ToolStripMenuItem
    Friend WithEvents DeleteContextStrip As ToolStripMenuItem
    Friend WithEvents BottomDeleteContextSeparator As ToolStripSeparator
    Friend WithEvents SelectAllContextStrip As ToolStripMenuItem
    Friend WithEvents BottomSelectAllContextSeparator As ToolStripSeparator
    Friend WithEvents RightToLeftContextStrip As ToolStripMenuItem
    Friend WithEvents ShowUnicodeContextStrip As ToolStripButton
    Friend WithEvents InsertUnicodeContextStrip As ToolStripMenuItem
    Friend WithEvents BottomInsertUnicodeContextSeparator As ToolStripSeparator
    Friend WithEvents OpenIMEContextStrip As ToolStripMenuItem
    Friend WithEvents ReconversionContextStrip As ToolStripMenuItem
    Friend WithEvents BottomReconversionContextSeparator As ToolStripSeparator
    Friend WithEvents SearchWithBingContextStrip As ToolStripMenuItem

    'InsertUnicode
    Friend WithEvents LRMContextStrip As ToolStripMenuItem
    Friend WithEvents RLMContextStrip As ToolStripMenuItem
    Friend WithEvents ZWJContextStrip As ToolStripMenuItem
    Friend WithEvents ZWNJContextStrip As ToolStripMenuItem
    Friend WithEvents LREContextStrip As ToolStripMenuItem
    Friend WithEvents RLEContextStrip As ToolStripMenuItem
    Friend WithEvents LROContextStrip As ToolStripMenuItem
    Friend WithEvents RLOContextStrip As ToolStripMenuItem
    Friend WithEvents PDFContextStrip As ToolStripMenuItem
    Friend WithEvents NADSContextStrip As ToolStripMenuItem
    Friend WithEvents NODSContextStrip As ToolStripMenuItem
    Friend WithEvents ASSContextStrip As ToolStripMenuItem
    Friend WithEvents ISSContextStrip As ToolStripMenuItem
    Friend WithEvents AAFSContextStrip As ToolStripMenuItem
    Friend WithEvents IAFSContextStrip As ToolStripMenuItem
    Friend WithEvents RSContextStrip As ToolStripMenuItem
    Friend WithEvents USSContextStrip As ToolStripMenuItem
End Class
