Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265 
'Spring 2021
'Math Contest
'https://github.com/dylannelson58/Stan_Grocery


Public Class Form1

    Dim fileName As String = "data.txt"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        WriteToFile()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Sub WriteToFile()
        'TODO
        'file name/path
        'file number
        'Global file name gets updatedif file not found

        Dim fileNumber As Integer = FreeFile()
        Dim filePath As String = "data.txt"

        FileOpen(fileNumber, filePath, OpenMode.Append)

        Write(fileNumber, TextBox1.Text)
        Write(fileNumber, TextBox2.Text)
        Write(fileNumber, TextBox3.Text)

        FileClose(fileNumber)
    End Sub

    Sub ReadFile()
        Dim fileNumber As Integer = FreeFile()
        Dim fileName As String = "data.txt"
        Dim currentRecord As String

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord)
                Console.WriteLine(currentRecord)
                Console.ReadLine()
            Loop
        Catch ex As Exception
            'TODO user pick file
            OpenFileDialog.ShowDialog()
            fileName = OpenFileDialog.FileName
        End Try

        FileClose(fileNumber)


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog.Filter() = "acme files (*.acme)|*.acme|txt files (*.txt)|*.txt|All Files (*.*)|*.*"

        OpenFileDialog.FileName = "acme" & DateTime.Now.Year.ToString & DateTime.Now.Month.ToString & DateTime.Now.Day.ToString

        OpenFileDialog.ShowDialog()
        Me.fileName = OpenFileDialog.FileName
    End Sub
    Sub SplitIntoArray()
        Dim names() As String
        Dim dataString As String = "Bob,Joe,Mary,Billy,Jane"

        names = Split(dataString, ",")
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub
End Class
