Imports System.Data
Public Class NewRequest
    Private Access As New DBControl
    Dim objOL As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application
    Dim myOlExp As Outlook.Explorer = objOL.ActiveExplorer

    Dim mySelection As Outlook.Selection = objOL.ActiveExplorer.Selection
    Dim mailitem As Outlook.MailItem = Nothing

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Private Sub NewRequest_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim ExternalEmail As String = "ATTENTION: This email originated from outside of TELUS. Use caution when clicking links or opening attachments. | Ce courriel provient de l'extérieur de TELUS. Soyez prudent lorsque vous cliquez sur des liens ou ouvrez des pièces jointes." & vbCr & vbLf
        Me.SuspendLayout()
        '' RUN QUERY TO POPULATE CLIENTS DROPDOWN
        'Access.ExecQuery("SELECT ID, [Client Name] FROM [Clients] ORDER BY [Client Name] ASC")
        'If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        '' FILL CLIENTS DROPDOWN
        ''For Each R As DataRow In Access.DBDT.Rows
        ''    Me.cboClient.Items.Add(R("Client Name"))
        ''Next
        '' FILL CLIENTS DROPDOWN
        'Me.cboClient.DataSource = Access.DBDT
        'Me.cboClient.DisplayMember = "Client Name"
        'Me.cboClient.ValueMember = "ID"

        '' RUN QUERY TO POPULATE ANALYSTS DROPDOWN
        'Access.ExecQuery("SELECT ID, [Contact Name] FROM [Contacts Extended] WHERE [Contact Name] IN 
        '                    ('Alain Gasse', 'Francis Lemaire', 'Alex Case', 'Mengdi Liu', 'Valérie Lemaire', 'Geneviève Roy', 'Asma Ben Youssef', 'Hena Mahmood') ORDER BY [Contact Name] ASC")

        'If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        '' FILL ANALYSTS DROPDOWN
        'Me.cboAssignedTo.DataSource = Access.DBDT
        'Me.cboAssignedTo.DisplayMember = "Contact Name"
        'Me.cboAssignedTo.ValueMember = "ID"

        ' RUN QUERY TO POPULATE ANALYSTS DROPDOWN
        Access.ExecQuery("SELECT ID, [Channel Name] FROM [Channels] ORDER BY [Channel Name] ASC")

        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL ANALYSTS DROPDOWN
        Me.cboChannel.DataSource = Access.DBDT
        Me.cboChannel.DisplayMember = "Channel Name"
        Me.cboChannel.ValueMember = "ID"

        PopulateClients()
        PopulateAnalysts()

        ' DISPLAY FIRST NAME FOUND
        'If Access.RecordCount > 0 Then Me.cboClient.SelectedIndex = 0

        'Dim objOL As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application
        'Dim myOlExp As Outlook.Explorer = objOL.ActiveExplorer

        'Dim mySelection As Outlook.Selection = objOL.ActiveExplorer.Selection
        'Dim mailitem As Outlook.MailItem = Nothing

        For Each obj As [Object] In mySelection
            If TypeOf obj Is Outlook.MailItem Then
                mailitem = DirectCast(obj, Outlook.MailItem)
                Me.txtTitle.Text = mailitem.ConversationTopic
                Me.txtReportedBy.Text = mailitem.SenderName
                Me.txtReporterEmail.Text = GetSenderSMTPAddress(mailitem) 'mailitem.SenderEmailAddress
                FindRequesterID(mailitem.SenderName)
                Me.dtReceived.Value = mailitem.SentOn
                Me.cboPriority.Text = "(2) Medium"
                Me.cboCategory.Text = "Troubleshooting"
                Me.cboStatus.Text = "Not Started"
                Me.cboClient.Text = ""
                Me.cboChannel.Text = ""
                'Me.txtComments.Text = "."
                Me.txtDetails.Text = Replace(Replace(mailitem.Body, ExternalEmail, ""), vbCr & vbLf & vbCr & vbLf, vbCr & vbLf) 'Replace(mailitem.Body, vbNewLine & vbNewLine, "")
                'Exit For
                GoTo Success
            Else
                MsgBox("The selected item is not an email.")
                Me.ResumeLayout()
                GoTo NotEmail
            End If
        Next

NotEmail:
        objOL = Nothing
        myOlExp = Nothing
        mySelection = Nothing
        mailitem = Nothing
        Me.Close()

Success:
        Me.ResumeLayout()

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

    Private Sub Add_Request()

        'MsgBox([GetType].Name(Me.lstReporter.SelectedValue))

        Access.AddParam("@Title", Me.txtTitle.Text)
        Access.AddParam("@Client", CInt(Me.cboClient.SelectedValue))
        If IsNothing(Me.lstReporter.SelectedValue) Then
            Access.AddParam("@ReporterID", 210)
        Else
            Access.AddParam("@ReporterID", Me.lstReporter.SelectedValue)
        End If
        'Access.AddParam("@ReporterID", Me.lstReporter.SelectedValue)
        Access.AddParam("@AssignedTo", CInt(Me.cboAssignedTo.SelectedValue))
        ''
        Access.AddParam("@Status", Me.cboStatus.Text)
        Access.AddParam("@Category", Me.cboCategory.Text)
        Access.AddParam("@Priority", Me.cboPriority.Text)
        Access.AddParam("@Description", Me.txtDetails.Text)
        Access.AddParam("@Channel", Me.cboChannel.SelectedValue)
        Access.AddParam("@DateReceived", Me.dtReceived.Value)
        If Me.txtCLID.Text = "" Then
            Access.AddParam("@CLID", DBNull.Value)
        Else
            Access.AddParam("@CLID", Me.txtCLID.Text)
        End If


        'Access.ExecQuery("INSERT INTO Issues ([Client], [Title], [Reported By], [Assigned To], [Status], [Category], [Priority], [Description], [Channel]) " &
        '                 "VALUES (@Client, @Title, @ReporterID, @AssignedTo, @Status, @Category, @Priority, @Description, @Channel); ")

        Access.ExecQuery("INSERT INTO Issues ([Title], [Client], [Reported By], [Assigned To], [Status], [Category], [Priority], [Description], [Channel], [Date Received], [CL ID]) " &
                 "VALUES (@Title, @Client, @ReporterID, @AssignedTo, @Status, @Category, @Priority, @Description, @Channel, @DateReceived, @CLID); ")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        If IsNothing(Me.lstReporter.SelectedValue) Then
            MsgBox("Successfully added to the Access Database without requester!" & vbNewLine & vbNewLine & "Please add the requester information in the Access DB and assign it to the request.")
        Else
            MsgBox("Successfully added to the Access Database!")
        End If


    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click

        Add_Request()

        If NotEmpty(Access.Exception) Then MsgBox("Please try again!") : Exit Sub

        'MarkSelectedAsAddedtoDB()

        objOL = Nothing
        myOlExp = Nothing
        mySelection = Nothing
        mailitem = Nothing

        Me.Close()

    End Sub

    Public Sub MarkSelectedAsAddedtoDB()

        Dim newCategory As String = "Added to DB"

        'AddCategory(mailitem, newCategory)

    End Sub

    Private Sub AddCategory(mailItem As Outlook.MailItem, newCategory As String)
        'Dim categories() As String
        'Dim listSep As String

        '' Get the current list separator from Windows regional settings
        'listSep = CreateObject("WScript.Shell").RegRead("HKEY_CURRENT_USER\Control Panel\International\sList")

        '' Break the list up into an array
        'categories = Split(mailItem.Categories, listSep)

        '' Search the array for the new category, and if it is missing, then add it
        'If UBound(Filter(categories, newCategory)) = -1 Then
        '    ReDim Preserve categories(UBound(categories) + 1)
        '    categories(UBound(categories)) = newCategory
        '    mailItem.Categories = Join(categories, listSep)
        '    mailItem.Save()
        'End If
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        'If Strings.Right(Me.cboCategory.Text, 6) = "French" Then
        '    cboAssignedTo.Text = "Geneviève Marquis"
        'Else
        '    cboAssignedTo.Text = "Mary Anne Cheung"
        'End If
    End Sub

    Private Sub cboReportedBy_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboReportedBy_DropDown(sender As Object, e As EventArgs)

        'If Me.cboReportedBy.Items.Count <= 1 Then
        '    Me.SuspendLayout()
        '    ' RUN QUERY TO POPULATE REQUESTER DROPDOWN
        '    Access.ExecQuery("SELECT ID, [Contact Name] FROM [Contacts Extended] ORDER BY [Contact Name] ASC")

        '    If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        '    ' FILL REQUESTER DROPDOWN
        '    Me.cboReportedBy.DataSource = Access.DBDT
        '    Me.cboReportedBy.DisplayMember = "Contact Name"
        '    Me.cboReportedBy.ValueMember = "ID"
        '    Me.ResumeLayout()
        'End If

        'Me.cboReportedBy.DroppedDown = True
        'For Each R As DataRow In Access.DBDT.Rows
        '    Me.cboReportedBy.Items.Add(R("Contact Name"))
        'Next
    End Sub

    Private Sub cboChannel_DropDown(sender As Object, e As EventArgs) Handles cboChannel.DropDown

        If Me.cboChannel.Items.Count <= 1 Then
            Me.SuspendLayout()
            ' RUN QUERY TO POPULATE CHANNELS DROPDOWN
            Access.ExecQuery("SELECT ID, [Channel Name] FROM [Channels] ORDER BY [Channel Name] ASC")

            If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            ' FILL REQUESTER DROPDOWN
            Me.cboChannel.DataSource = Access.DBDT
            Me.cboChannel.DisplayMember = "Channel Name"
            Me.cboChannel.ValueMember = "ID"
            Me.ResumeLayout()
        End If

        'Me.cboChannel.DroppedDown = True

    End Sub

    Private Sub FindRequesterID(sender As String)
        Access.ExecQuery("SELECT ID, [Contact Name] FROM [Contacts Extended] WHERE 
                          [Contact Name] LIKE '" & sender & "' OR [File As] LIKE '" & sender & "' OR [E-mail Address] = '" & Me.txtReporterEmail.Text & "'")

        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Me.lstReporter.DataSource = Access.DBDT
        Me.lstReporter.DisplayMember = "Contact Name"
        Me.lstReporter.ValueMember = "ID"

        'If (Not String.IsNullOrEmpty(Me.lstReporter.Items.Count)) Then
        'If Me.lstReporter.Items.Count > 0 Then
        '    Me.txtReportedBy.Text = Me.lstReporter.SelectedItem
        'Else
        '    Me.txtReportedBy.Text = "Couldn't find match in DB!"
        'End If

    End Sub

    Private Sub PopulateClients()
        ' RUN QUERY TO POPULATE CLIENTS DROPDOWN
        Access.ExecQuery("SELECT ID, [Client Name] FROM [Clients] ORDER BY [Client Name] ASC")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL CLIENTS DROPDOWN
        'For Each R As DataRow In Access.DBDT.Rows
        '    Me.cboClient.Items.Add(R("Client Name"))
        'Next
        ' FILL CLIENTS DROPDOWN
        Me.cboClient.DataSource = Access.DBDT
        Me.cboClient.DisplayMember = "Client Name"
        Me.cboClient.ValueMember = "ID"

    End Sub

    Private Sub PopulateAnalysts()
        ' RUN QUERY TO POPULATE ANALYSTS DROPDOWN
        Access.ExecQuery("SELECT ID, [Contact Name] FROM [Contacts Extended] WHERE [Contact Name] IN 
                            ('Alain Gasse', 'Francis Lemaire', 'Alex Case', 'Mengdi Liu', 'Valérie Lemaire', 'Geneviève Roy', 'Asma Ben Youssef', 'Hena Mahmood') ORDER BY [Contact Name] ASC")

        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL ANALYSTS DROPDOWN
        Me.cboAssignedTo.DataSource = Access.DBDT
        Me.cboAssignedTo.DisplayMember = "Contact Name"
        Me.cboAssignedTo.ValueMember = "ID"

    End Sub
End Class