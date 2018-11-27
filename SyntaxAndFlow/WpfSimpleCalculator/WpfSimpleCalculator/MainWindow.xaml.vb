Imports WpfSimpleCalculator.UtilitiesSharedClass

Class MainWindow

    Const ADD As String = "Add"
    Const SUBTRACT As String = "Subtract"
    Const MULTIPLY As String = "Multiply"
    Const DIVIDE As String = "Divide"

    Sub Calculation(operation As String)
        Dim str1 As String = textInputOne.Text
        Dim str2 As String = textInputTwo.Text
        Dim dbl1 As Double
        Dim dbl2 As Double

        ClearContent()

        If IsNumeric(str1) And IsNumeric(str2) Then
            dbl1 = Double.Parse(str1)
            dbl2 = Double.Parse(str2)
        Else
            DisplayError("Input must be numbers!")
            Return 'Exit the subroutine'
        End If

        'Perform operation.'
        Dim result As Double
        Dim calUtilObj As New CalculatorUtility(dbl1, dbl2) 'Create an instance of Calculator Utility Class'
        'calUtilObj.value1 = dbl1 'Add instance fields to set variables'
        'calUtilObj.value2 = dbl2
        Console.WriteLine(calUtilObj)
        If operation = ADD Then
            'result = dbl1 + dbl2
            'result = AddValues(dbl1, dbl2) 'Invoke method using Module'
            'result = CalculatorUtilitySharedClass.AddValues(dbl1, dbl2) 'Invoke shared member of method'
            result = calUtilObj.AddValues() 'Invoke method from Custom Class'
        ElseIf operation = SUBTRACT Then
            'result = dbl1 - dbl2
            'result = SubtractValues(dbl1, dbl2)
            'result = CalculatorUtilitySharedClass.SubtractValues(dbl1, dbl2)
            result = calUtilObj.SubtractValues()
        ElseIf operation = MULTIPLY Then
            'result = dbl1 * dbl2
            'result = MultiplyValues(dbl1, dbl2)
            'result = CalculatorUtilitySharedClass.MultiplyValues(dbl1, dbl2)
            result = calUtilObj.MultiplyValues()
        ElseIf operation = DIVIDE Then
            'result = dbl1 / dbl2
            'result = DivideValues(dbl1, dbl2)
            'result = CalculatorUtilitySharedClass.DivideValues(dbl1, dbl2)
            result = calUtilObj.DivideValues()
            If Double.IsPositiveInfinity(result) Or Double.IsNegativeInfinity(result) Then
                DisplayError("Error, divide by zero")
                Return
            End If
        End If

        DisplayResult(result)

    End Sub

    ''' <summary>
    ''' Method to check the result output whether is positive
    ''' Then outputs value with different text color in output label
    ''' </summary>
    ''' <param name="result"></param>
    Private Sub DisplayResult(result As Double)

        If result >= 0 Then
            outputCalculation.Content = result.ToString()
            outputCalculation.Foreground = Brushes.Blue
        Else
            outputCalculation.Content = result.ToString()
            outputCalculation.Foreground = Brushes.Red
        End If

    End Sub

    ''' <summary>
    ''' Method to display error message with red color text
    ''' </summary>
    ''' <param name="errorMsg"></param>
    Private Sub DisplayError(errorMsg As String)
        outputCalculation.Content = errorMsg
        outputCalculation.Foreground = Brushes.Red
    End Sub

    ''' <summary>
    ''' Clear or reset output label text
    ''' </summary>
    Private Sub ClearContent()
        outputCalculation.Content = ""
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As RoutedEventArgs)
        Calculation(ADD)
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As RoutedEventArgs)
        Calculation(SUBTRACT)
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As RoutedEventArgs) Handles btnMultiply.Click
        Calculation(MULTIPLY)
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As RoutedEventArgs) Handles btnDivide.Click
        Calculation(DIVIDE)
    End Sub
End Class
