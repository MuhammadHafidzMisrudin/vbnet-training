Class MainWindow

    Sub OutputHandler(sender As Object, e As RoutedEventArgs)
        Dim valueOne As String = inputTextOne.Text
        Dim valueTwo As String = inputTextTwo.Text
        Dim isChecked As Boolean = checkNumeric.IsChecked

        OutputText(valueOne)
        OutputText(valueTwo)
        OutputText(isChecked)

        If valueOne <> "" And valueTwo <> "" Then
            If valueOne = valueTwo Then
                OutputText("Strings match")
            ElseIf valueOne > valueTwo Then
                OutputText("String 1 > String 2")
            Else
                OutputText("String 2 > String 1")
            End If

            If isChecked Then
                If IsNumeric(valueOne) And IsNumeric(valueTwo) Then
                    Dim newValueOne = Double.Parse(valueOne)
                    Dim newValueTwo = Double.Parse(valueTwo)

                    If newValueOne = newValueTwo Then
                        OutputText("Numbers match")
                    ElseIf newValueOne > newValueTwo Then
                        OutputText("Number 1 > Number 2")
                    Else
                        OutputText("Number 2 > Number 1")
                    End If
                Else
                    OutputText("Strings can't be converted to Numbers")
                End If
            End If
        Else
            OutputText("input values are empty, please insert them.")
        End If
    End Sub

    Sub OutputText(Value As String)
        textOutput.Text += Value + vbCrLf
    End Sub

    Sub OutputClear(sender As Object, e As RoutedEventArgs)
        textOutput.Text = Nothing
    End Sub
End Class
