Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        ' Read the input from the use
        fullname = txtFullName.Text

        'Trim the input so as to remove leading spaces
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'Find the index of first space
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'Extract the first name
        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxSpace)

        'Display the result to the user
        txtFirstName.Text = firstName

    End Sub
End Class
