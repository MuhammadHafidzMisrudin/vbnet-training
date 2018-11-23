Class MainWindow

    Const ADD As String = "Add",
          SUBTRACT As String = "Subtract",
          MULTIPLY As String = "Multiply",
          DIVIDE As String = "Divide"

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim str1 As String = txtInput1.Text
        Dim str2 As String = txtInput2.Text
        Dim dbl1 As Double
        Dim dbl2 As Double

        txtOutput.Text = ""

        If IsNumeric(str1) And IsNumeric(str2) Then
            dbl1 = Double.Parse(str1)
            dbl2 = Double.Parse(str2)
        Else
            Output("Please enter valid numbers!")
            Return 'Exit the subroutine'
        End If

        'Check if user selects any optional operation'
        Dim operation As String = "None"
        If optAdd.IsChecked Then
            operation = ADD
        ElseIf optSubtract.IsChecked Then
            operation = SUBTRACT
        ElseIf optMultiply.IsChecked Then
            operation = MULTIPLY
        ElseIf optDivide.IsChecked Then
            operation = DIVIDE
        End If

        'Check if optional operation is None, do nothing'
        If operation = "None" Then
            Output("Select operation: " + operation)
            Return 'Exit the subroutine' 
        End If

        'Invoke Calculation()'
        Dim result As Double
        result = CalculateMethod(dbl1, dbl2, operation)
        Output("Result from selected operation: " + result.ToString())

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
        optAdd.IsChecked = False
        optSubtract.IsChecked = False
        optMultiply.IsChecked = False
        optDivide.IsChecked = False
    End Sub

    Function CalculateMethod(dbl1 As Double, dbl2 As Double, op As String) As String

        Dim result As Double
        Select Case op
            Case ADD
                result = dbl1 + dbl2
            Case SUBTRACT
                result = dbl1 - dbl2
            Case MULTIPLY
                result = dbl1 * dbl2
            Case DIVIDE
                result = dbl1 / dbl2
        End Select

        Return result
    End Function

End Class
