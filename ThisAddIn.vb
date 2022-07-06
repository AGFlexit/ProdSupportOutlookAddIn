Imports System.IO
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class ThisAddIn
    Private menuBar As Office.CommandBar
    Private newMenuBar As Office.CommandBarPopup
    Private buttonOne As Office.CommandBarButton
    Private Sub ThisAddIn_Startup() Handles Me.Startup
        Dim customCat As String = "Added to DB"

        If IsNothing(Application.Session.Categories(customCat)) Then
            Application.Session.Categories.Add(customCat, Outlook.OlCategoryColor.olCategoryColorDarkPurple)
        End If
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
