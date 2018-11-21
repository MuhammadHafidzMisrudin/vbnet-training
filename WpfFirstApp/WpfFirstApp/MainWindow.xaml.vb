Class MainWindow
    Private Sub ButtonObject1_Click(sender As Object, e As RoutedEventArgs) Handles ButtonObject1.Click
        Dim enteredValue As String
        enteredValue = TextBoxObject1.Text

        enteredValue = "Added: " + enteredValue
        LabelObject1.Content = enteredValue
    End Sub
End Class
