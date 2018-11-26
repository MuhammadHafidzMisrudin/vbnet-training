Imports System.Web.Configuration
Imports System.Data
Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Private strCon As String = WebConfigurationManager.ConnectionStrings("UserConnectionString1").ConnectionString

    Protected Function UserLogin(un As String, pw As String) As Boolean
        Using connection As New SqlConnection(strCon)
            Dim command As New SqlCommand("SELECT UserName FROM Users WHERE UserName=@un and Password=@pw", connection)
            command.Parameters.AddWithValue("@un", un)
            command.Parameters.AddWithValue("@pw", pw)
            connection.Open()
            Dim result As String = Convert.ToString(command.ExecuteScalarAsync())

            If (String.IsNullOrEmpty(result)) Then
                Return False
            Else
                Return True
            End If
        End Using
    End Function

    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        Dim usrname As String = Login1.UserName
        Dim paswd As String = Login1.Password

        Dim result As Boolean = UserLogin(usrname, paswd)

        If (result) Then
            e.Authenticated = True
            Session("username") = usrname
        Else
            e.Authenticated = False
        End If

    End Sub
End Class
