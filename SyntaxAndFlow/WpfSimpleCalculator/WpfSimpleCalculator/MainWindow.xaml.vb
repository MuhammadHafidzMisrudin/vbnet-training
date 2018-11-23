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

        'Invoke operation.'
        outputCalculation.Content = operation

    End Sub

    Private Sub DisplayError(errorMsg As String)
        outputCalculation.Content = errorMsg
        outputCalculation.Foreground = Brushes.Red
    End Sub

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
