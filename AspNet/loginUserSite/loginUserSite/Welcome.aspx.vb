
Partial Class Welcome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Label1.Text = "Welcome " & Session("username")
        End If
    End Sub
End Class
