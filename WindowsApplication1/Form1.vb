Imports System
Imports System.IO
Public Class Form1
    Private SDirectory As String
    Private line As String
    Private Splited As String()
    Public Property Textbox2 As Object

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
            Dim delimeter As String = line.Substring(3, 1)
            TextBox3.text = delimeter


            Dim delim As String() = New String(0) {"ST*"}

            Splited = line.Split(delim, StringSplitOptions.None)
            TextBoxDocType.Text = Splited(1).Substring(0, 3)
            ' Split the string on the backslash character.
            Dim parts As String() = line.Split(New Char() {"~"c})
            Dim part As String
            Dim CT As Int16 = "0"
            Dim SCT As Int16 = "0"
            ' Loop through result strings with For Each.

            For Each part In parts
                If part <> "" Then
                    ListBox1.Items.Add(part + "~")

                End If
            Next
            If line.Substring(150, 5) = "00401" Then
                TextBox1.Text = "4010"

            ElseIf line.Substring(150, 5) = "X*005" Then
                TextBox1.Text = "5010"
            Else
                TextBox1.Text = line.Substring(150, 5)
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RawToolStripMenuItem.Click
        Clipboard.Clear()
        Clipboard.SetText(line)
    End Sub

    Private Sub FormattedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormattedToolStripMenuItem.Click
        'Clipboard.SetText()
    End Sub
End Class
