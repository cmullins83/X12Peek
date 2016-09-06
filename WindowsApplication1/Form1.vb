Imports System
Imports System.IO
Public Class Form1
    Private SDirectory As String
    Private line As String

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            ' Store the line in this String.
            Dim line As String

            ' Create new StreamReader instance with Using block.
            Using reader As StreamReader = New StreamReader(OpenFileDialog1.FileName)
                ' Read one line from file
                line = reader.ReadLine
            End Using

            ' Write the line we read from the Open File Dialog to Textbox1
            TextBox1.Text = line

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
