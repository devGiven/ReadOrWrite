Imports System.IO

Public Class Form1
    Private filePath As String = "data.txt" ' Change this to your desired file path

    Private Sub WriteToFileButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using writer As New StreamWriter(filePath, append:=True)
                writer.WriteLine(TextBox1.Text)
            End Using
            MessageBox.Show("Data written to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while writing to file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReadFromFileButton_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If File.Exists(filePath) Then
                Using reader As New StreamReader(filePath)
                    TextBox1.Text = reader.ReadToEnd()
                End Using
            Else
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while reading from file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub


End Class
