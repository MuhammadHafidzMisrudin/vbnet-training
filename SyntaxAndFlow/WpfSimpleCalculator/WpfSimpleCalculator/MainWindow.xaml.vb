﻿Class MainWindow

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
        If operation = ADD Then
            result = dbl1 + dbl2
        ElseIf operation = SUBTRACT Then
            result = dbl1 - dbl2
        ElseIf operation = MULTIPLY Then
            result = dbl1 * dbl2
        ElseIf operation = DIVIDE Then
            result = dbl1 / dbl2
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