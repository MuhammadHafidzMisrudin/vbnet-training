Public Class CalculatorUtility

    'Public value1 As Double
    'Public value2 As Double
    Private _value1 As Double
    Private _value2 As Double

    Property value1 As Double
        Get
            Return _value1
        End Get
        Set(value As Double)
            _value1 = value
        End Set
    End Property

    Property value2 As Double
        Get
            Return _value2
        End Get
        Set(value As Double)
            _value2 = value
        End Set
    End Property

    'Create a Constructor'
    Sub New(dbl1 As Double, dbl2 As Double)
        value1 = dbl1
        value2 = dbl2
    End Sub

    'Addition method'
    Public Function AddValues() As Double
        Return value1 + value2
    End Function

    'Substraction method'
    Public Function SubtractValues() As Double
        Return value1 - value2
    End Function

    'Multiplication method'
    Public Function MultiplyValues() As Double
        Return value1 * value2
    End Function

    'Division method'
    Public Function DivideValues() As Double
        Return value1 / value2
    End Function
End Class
