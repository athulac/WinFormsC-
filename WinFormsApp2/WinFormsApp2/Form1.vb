Public Class Form1
    Private Sub btnSubmit_24_Click(sender As Object, e As EventArgs) Handles btnSubmit_24.Click

        Dim arrayAll() As Char = txtUserName_24.Text.ToCharArray()
        'Dim arrayResult() As String
        Dim arrayResult As New List(Of Char)()
        lblResult.Text = ""
        'txtUserName_24.Clear()
        For index = 0 To arrayAll.Length - 1
            lblResult.Text += arrayAll(index)
            If arrayAll(index) = "." Then
                lblResult.Text += ControlChars.NewLine
            End If
        Next




    End Sub
End Class
