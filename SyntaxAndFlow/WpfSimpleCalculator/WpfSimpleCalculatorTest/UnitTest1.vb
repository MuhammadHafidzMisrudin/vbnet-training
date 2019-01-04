Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WpfSimpleCalculator

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestCheckInputParam1()
        Dim param1 As Double = 1.0
        Dim param2 As Double = 2.0
        Dim test As New CalculatorUtility(1.0, 2.0)
        Assert.AreEqual(1.0, test.value1)
    End Sub

    <TestMethod()> Public Sub TestCheckInputParam1NotSameAsOutput()
        Dim param1 As Double = 1.0
        Dim param2 As Double = 2.0
        Dim test As New CalculatorUtility(1.0, 2.0)
        Assert.AreNotEqual(-3.0, test.value1, "pass, param1 should not be equal as expected value")
    End Sub

    <TestMethod()> Public Sub TestCheckInputParam2()
        Dim param1 As Double = 1.0
        Dim param2 As Double = 2.0
        Dim test As New CalculatorUtility(1.0, 2.0)
        Assert.AreEqual(2.0, test.value2)
    End Sub

    <TestMethod()> Public Sub TestCheckInputParam2NotSameAsOutput()
        Dim param1 As Double = 1.0
        Dim param2 As Double = 2.0
        Dim test As New CalculatorUtility(1.0, 2.0)
        Assert.AreNotEqual(-9.0, test.value2, "pass, param2 should not be equal as expected value")
    End Sub

    <TestMethod()> Public Sub TestAddValuesMethod()
        Dim test As New CalculatorUtility(1.0, 2.0)
        test.AddValues()
        Assert.AreEqual(3.0, test.result)
    End Sub

    <TestMethod()> Public Sub TestSubtractValuesMethod()
        Dim test As New CalculatorUtility(1.0, 2.0)
        test.SubtractValues()
        Assert.AreEqual(-1.0, test.result)
    End Sub

    <TestMethod()> Public Sub TestMultiplyValuesMethod()
        Dim test As New CalculatorUtility(1.0, 2.0)
        test.MultiplyValues()
        Assert.AreEqual(2.0, test.result)
    End Sub

    <TestMethod()> Public Sub TestDivideValuesMethod()
        Dim test As New CalculatorUtility(1.0, 2.0)
        test.DivideValues()
        Assert.AreEqual(0.5, test.result)
    End Sub

End Class