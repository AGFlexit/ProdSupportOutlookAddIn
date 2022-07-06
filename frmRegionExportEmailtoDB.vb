Imports System.Data
Public Class frmRegionExportEmailtoDB
    Private Access As New DBControl
    Dim objOL As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application
    Dim myOlExp As Outlook.Explorer = objOL.ActiveExplorer

    Dim mySelection As Outlook.Selection = objOL.ActiveExplorer.Selection
    Dim mailitem As Outlook.MailItem = Nothing
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
#Region "Form Region Factory"

    <Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)>
    <Microsoft.Office.Tools.Outlook.FormRegionName("ProdSupportOutlookAddIn.frmRegionExportEmailtoDB")>
    Partial Public Class frmRegionExportEmailtoDBFactory

        ' Occurs before the form region is initialized.
        ' To prevent the form region from appearing, set e.Cancel to true.
        ' Use e.OutlookItem to get a reference to the current Outlook item.
        Private Sub frmRegionExportEmailtoDBFactory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

        End Sub

    End Class

#End Region

    'Occurs before the form region is displayed. 
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
    Private Sub frmRegionExportEmailtoDB_FormRegionShowing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing
        Dim ExternalEmail As String = "ATTENTION: This email originated from outside of TELUS. Use caution when clicking links or opening attachments. | Ce courriel provient de l'extérieur de TELUS. Soyez prudent lorsque vous cliquez sur des liens ou ouvrez des pièces jointes." & vbCr & vbLf
        'Me.SuspendLayout()
        ' RUN QUERY TO POPULATE CLIENTS DROPDOWN
        'Access.ExecQuery("SELECT [Client Name] FROM Clients ORDER BY [Client Name] ASC")
        'If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        '' FILL CLIENTS DROPDOWN
        ''For Each R As DataRow In Access.DBDT.Rows
        ''    Me.cboClient.Items.Add(R("Client Name"))
        ''Next
        '' FILL CLIENTS DROPDOWN
        'Me.cboClient.DataSource = Access.DBDT
        'Me.cboClient.DisplayMember = "Client Name"
        'Me.cboClient.ValueMember = "ID"

        ' DISPLAY FIRST NAME FOUND
        'If Access.RecordCount > 0 Then Me.cboClient.SelectedIndex = 0

        'Dim objOL As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application
        'Dim myOlExp As Outlook.Explorer = objOL.ActiveExplorer
        If mySelection.Count > 0 Then
            mailitem = DirectCast(mySelection.Item(1), Outlook.MailItem)
        End If
        'Dim mySelection As Outlook.Selection = objOL.ActiveExplorer.Selection
        'Dim mailitem As Outlook.MailItem = Nothing

        For Each obj As [Object] In mySelection
            If TypeOf obj Is Outlook.MailItem Then

                mailitem = DirectCast(obj, Outlook.MailItem)
                Me.txtTitle.Text = mailitem.ConversationTopic
                Me.cboReportedBy.Text = mailitem.SenderName
                Me.txtReporterEmail.Text = GetSenderSMTPAddress(mailitem) 'mailitem.SenderEmailAddress
                Me.dtReceived.Value = mailitem.SentOn
                Me.cboPriority.Text = "(2) Normal"
                'Me.cboAssignedTo.Text = "Mary Anne Cheung"
                Me.cboStatus.Text = "Not Started"
                'Me.cboClient.Text = ""
                'Me.cboChannel.Text = "Direct"
                'Me.txtComments.Text = "."
                Me.txtDetails.Text = Replace(Replace(mailitem.Body, ExternalEmail, ""), vbCr & vbLf & vbCr & vbLf, vbCr & vbLf) 'Replace(mailitem.Body, vbNewLine & vbNewLine, "")
                'Exit For
                GoTo Success
            Else
                MsgBox("The selected item is not an email.")
                'Me.ResumeLayout()
                GoTo NotEmail
            End If
        Next

NotEmail:
        objOL = Nothing
        myOlExp = Nothing
        mySelection = Nothing
        mailitem = Nothing

Success:
        'Me.ResumeLayout()

    End Sub

    Private Function GetSenderSMTPAddress(mail As Outlook.MailItem) As String
        Dim PR_SMTP_ADDRESS As String = "http://schemas.microsoft.com/mapi/proptag/0x39FE001E"
        If mail Is Nothing Then
            Throw New ArgumentNullException()
        End If
        If mail.SenderEmailType = "EX" Then
            Dim sender As Outlook.AddressEntry = mail.Sender
            If sender IsNot Nothing Then
                'Now we have an AddressEntry representing the Sender
                If sender.AddressEntryUserType = Outlook.OlAddressEntryUserType.olExchangeUserAddressEntry OrElse sender.AddressEntryUserType = Outlook.OlAddressEntryUserType.olExchangeRemoteUserAddressEntry Then
                    'Use the ExchangeUser object PrimarySMTPAddress
                    Dim exchUser As Outlook.ExchangeUser = sender.GetExchangeUser()
                    If exchUser IsNot Nothing Then
                        Return exchUser.PrimarySmtpAddress
                    Else
                        Return Nothing
                    End If
                Else
                    Return TryCast(sender.PropertyAccessor.GetProperty(PR_SMTP_ADDRESS), String)
                End If
            Else
                Return Nothing
            End If
        Else
            Return mail.SenderEmailAddress
        End If
    End Function

    'Occurs when the form region is closed.   
    'Use Me.OutlookItem to get a reference to the current Outlook item.
    'Use Me.OutlookFormRegion to get a reference to the form region.
    Private Sub frmRegionExportEmailtoDB_FormRegionClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed

    End Sub

    Private Sub frmRegionExportEmailtoDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Access.ExecQuery("SELECT [Client Name] FROM Clients ORDER BY [Client Name] ASC")
        'If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        '' FILL CLIENTS DROPDOWN
        ''For Each R As DataRow In Access.DBDT.Rows
        ''    Me.cboClient.Items.Add(R("Client Name"))
        ''Next
        '' FILL CLIENTS DROPDOWN
        'Me.cboClient.DataSource = Access.DBDT
        'Me.cboClient.DisplayMember = "Client Name"
        'Me.cboClient.ValueMember = "ID"
    End Sub
End Class
