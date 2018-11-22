Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)

        '''''''''''''''''''''
        Output("For Loop")

        For count As Integer = 0 To 3
            Output("For Count: " + count.ToString())
        Next

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("While Loop")
        Dim whileCount As Integer = 1
        While whileCount <= 3
            Output("While Count: " + whileCount.ToString())
            whileCount += 1
        End While

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("Do Loop")
        Dim doCount As Integer = 1
        Do
            Output("Do While Count: " + doCount.ToString())
            doCount += 1
        Loop Until doCount > 3

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("Infinite do")
        doCount = 1
        Do
            Output("Do While Count: " + doCount.ToString())
            doCount += 1
            If doCount > 3 Then
                Exit Do
            End If
        Loop

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("For Each Loop")
        Dim numbers As Integer() = {1, 3, 5}
        For Each i In numbers
            Output("For Each Count: " + i.ToString())
        Next

        Output(vbCrLf)
        
    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
