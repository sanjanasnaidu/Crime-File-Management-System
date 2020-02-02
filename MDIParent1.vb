Imports System.Windows.Forms

Public Class MDIParent1

    Dim ToolBarToolStripMenuItem As Object
    Dim StatusBarToolStripMenuItem As Object

    Private Property m_ChildFormNumber As Integer

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub CREATEFIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CREATEFIRToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub VIEWFIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWFIRToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub FILLCOMPLAINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILLCOMPLAINTToolStripMenuItem.Click
        Form8.Show()

    End Sub

    Private Sub VIEWCOMPLAINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWCOMPLAINTToolStripMenuItem.Click
        Form7.Show()

    End Sub

    Private Sub SAVEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem1.Click
        Form9.Show()

    End Sub


    Private Sub UPLOADREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPLOADREPORTToolStripMenuItem.Click
        Form11.Show()

    End Sub

    Private Sub VIEWREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWREPORTToolStripMenuItem.Click
        Form12.Show()

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Form15.Show()

    End Sub

    Private Function ToolStrip() As Object
        Throw New NotImplementedException
    End Function

    Private Sub FINGERPRINTMATCHERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FINGERPRINTMATCHERToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim dialog As DialogResult = MessageBox.Show("Do you really want to close the program", "EXIT", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class






