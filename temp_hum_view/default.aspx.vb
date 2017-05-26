Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class _default

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Page.IsPostBack) Then
            BindData()
        End If
    End Sub
    Private Sub BindData()

        Dim db = New MyShopDataContext()

        dlProducts.DataSource = From d In db.Products
                                Select d
        dlProducts.DataBind()
    End Sub

End Class