Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WpfSimpleCalculator

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim test As New CalculatorUtility(1.0, 2.0)
        test.AddValues()
        Assert.AreEqual(3.0, test.result)
    End Sub

End Class