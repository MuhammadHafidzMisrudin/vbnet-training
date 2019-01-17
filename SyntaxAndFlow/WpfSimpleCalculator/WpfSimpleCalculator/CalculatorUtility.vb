Public Class CalculatorUtility

    'Define public shared values as class fields'
    Public Shared ADD As String = "Add",
                  SUBTRACT As String = "Subtract",
                  MULTIPLY As String = "Multiply",
                  DIVIDE As String = "Divide"

    'Public value1 As Double
    'Public value2 As Double

    'Define private fields'
    Private _value1 As Double
    Private _value2 As Double
    Private _result As Double

    'Property for input 1'
    Property value1 As Double
        Get
            Return _value1
        End Get
        Set(value As Double)
            _value1 = value
        End Set
    End Property

    'Property for input 2'
    Property value2 As Double
        Get
            Return _value2
        End Get
        Set(value As Double)
            _value2 = value
        End Set
    End Property

    'Read-Only Property'
    ReadOnly Property result As Double
        Get
            Return _result
        End Get
    End Property

    'Create a Constructor'
    Sub New(dbl1 As Double, dbl2 As Double)
        'Set properties to parameters'
        value1 = dbl1
        value2 = dbl2
    End Sub

    'Addition method'
    Public Sub AddValues()
        'Return value1 + value2
        _result = value1 + value2
    End Sub

    'Substraction method'
    Public Sub SubtractValues()
        'Return value1 - value2
        _result = value1 - value2
    End Sub

    'Multiplication method'
    Public Sub MultiplyValues()
        'Return value1 * value2
        _result = value1 * value2
    End Sub

    'Division method'
    Public Sub DivideValues()
        'Return value1 / value2
        _result = value1 / value2
    End Sub
End Class
