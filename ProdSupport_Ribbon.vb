Imports Microsoft.Office.Tools.Ribbon

Public Class ProdSupport_Ribbon

    Private Sub ProdSupport_Ribbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEditRequest_Click(sender As Object, e As RibbonControlEventArgs) Handles btnEditRequest.Click

    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As RibbonControlEventArgs) Handles btnCreateRequest.Click
        Dim IssueForm As New NewRequest

        IssueForm.Show()
    End Sub
End Class
