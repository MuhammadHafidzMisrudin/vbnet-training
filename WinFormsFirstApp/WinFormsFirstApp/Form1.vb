Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredValue As String
        enteredValue = TextBox1.Text

        ''enteredValue = "Added: " + enteredValue
        Label2.Text = enteredValue
    End Sub
End Class
