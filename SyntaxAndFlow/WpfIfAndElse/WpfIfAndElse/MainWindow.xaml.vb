Class MainWindow

    Sub OutputHandler(sender As Object, e As RoutedEventArgs)
        Dim valueOne As String = inputTextOne.Text
        Dim valueTwo As String = inputTextTwo.Text

        OutputText(valueOne)
        OutputText(valueTwo)

    End Sub

    Sub OutputText(Value As String)
        textOutput.Text += Value + vbCrLf
    End Sub

    Sub OutputClear(sender As Object, e As RoutedEventArgs)
        textOutput.Text = ""
    End Sub
End Class
