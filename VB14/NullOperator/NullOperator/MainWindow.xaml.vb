Class MainWindow

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim StringVar As String = "Hello Inma"

        'Checking if string variable is null'
        If StringVar IsNot Nothing Then
            Dim StrLength As Integer = StringVar.Length
            Output("String length = " + StrLength.ToString())
        Else
            Output("The string variable is empty")
        End If

        Output("")

        'Use and implement checking for null values with null-propagating operator (?.)'
        Dim StringVariableNew As String = Nothing
        Dim StrVarLength As Integer? = StringVariableNew?.Length
        Output("String length for new variable = " + StrVarLength.ToString())

        Output("")

        Output("Length (explicitly use if clause) = " + If(StrVarLength Is Nothing, "0", StrVarLength.ToString()))
        Output(If(StrVarLength Is Nothing, NameOf(StringVariableNew) + " is empty", StrVarLength.ToString()))

        Output("")
        Output("All done!")

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
