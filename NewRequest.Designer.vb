<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewRequest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewRequest))
        Me.lblSenderEmail = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.lblReporter = New System.Windows.Forms.Label()
        Me.cboClient = New System.Windows.Forms.ComboBox()
        Me.dtReceived = New System.Windows.Forms.DateTimePicker()
        Me.cboAssignedTo = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboPriority = New System.Windows.Forms.ComboBox()
        Me.cboChannel = New System.Windows.Forms.ComboBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtDetails = New System.Windows.Forms.RichTextBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDateRcvd = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblChannel = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblAssignee = New System.Windows.Forms.Label()
        Me.txtReporterEmail = New System.Windows.Forms.TextBox()
        Me.btnCreateRequest = New System.Windows.Forms.Button()
        Me.lstReporter = New System.Windows.Forms.ListBox()
        Me.txtReportedBy = New System.Windows.Forms.TextBox()
        Me.lblCLID = New System.Windows.Forms.Label()
        Me.txtCLID = New System.Windows.Forms.TextBox()
        Me.picTelusHealth = New System.Windows.Forms.PictureBox()
        Me.picProdSupportLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picTelusHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProdSupportLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSenderEmail
        '
        Me.lblSenderEmail.AutoSize = True
        Me.lblSenderEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblSenderEmail.Location = New System.Drawing.Point(10, 131)
        Me.lblSenderEmail.Name = "lblSenderEmail"
        Me.lblSenderEmail.Size = New System.Drawing.Size(69, 13)
        Me.lblSenderEmail.TabIndex = 60
        Me.lblSenderEmail.Text = "Sender Email"
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblComments.Location = New System.Drawing.Point(315, 263)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 82
        Me.lblComments.Text = "Comments"
        '
        'txtComments
        '
        Me.txtComments.AcceptsReturn = True
        Me.txtComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComments.Location = New System.Drawing.Point(401, 263)
        Me.txtComments.MaxLength = 500
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(198, 56)
        Me.txtComments.TabIndex = 81
        '
        'lblReporter
        '
        Me.lblReporter.AutoSize = True
        Me.lblReporter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblReporter.Location = New System.Drawing.Point(315, 131)
        Me.lblReporter.Name = "lblReporter"
        Me.lblReporter.Size = New System.Drawing.Size(65, 13)
        Me.lblReporter.TabIndex = 80
        Me.lblReporter.Text = "Reported by"
        '
        'cboClient
        '
        Me.cboClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboClient.FormattingEnabled = True
        Me.cboClient.Location = New System.Drawing.Point(401, 162)
        Me.cboClient.Name = "cboClient"
        Me.cboClient.Size = New System.Drawing.Size(198, 21)
        Me.cboClient.Sorted = True
        Me.cboClient.TabIndex = 78
        '
        'dtReceived
        '
        Me.dtReceived.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dtReceived.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dtReceived.Checked = False
        Me.dtReceived.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtReceived.Font = New System.Drawing.Font("Microsoft JhengHei", 10.0!)
        Me.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReceived.Location = New System.Drawing.Point(401, 197)
        Me.dtReceived.Name = "dtReceived"
        Me.dtReceived.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtReceived.RightToLeftLayout = True
        Me.dtReceived.Size = New System.Drawing.Size(198, 25)
        Me.dtReceived.TabIndex = 77
        '
        'cboAssignedTo
        '
        Me.cboAssignedTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAssignedTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAssignedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboAssignedTo.FormattingEnabled = True
        Me.cboAssignedTo.Location = New System.Drawing.Point(84, 263)
        Me.cboAssignedTo.Name = "cboAssignedTo"
        Me.cboAssignedTo.Size = New System.Drawing.Size(197, 21)
        Me.cboAssignedTo.Sorted = True
        Me.cboAssignedTo.TabIndex = 76
        '
        'cboStatus
        '
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Cancelled", "Completed", "Escalated to Prod Support", "In Progress", "Not Started", "On Hold (Client)"})
        Me.cboStatus.Location = New System.Drawing.Point(401, 230)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(198, 21)
        Me.cboStatus.Sorted = True
        Me.cboStatus.TabIndex = 75
        '
        'cboPriority
        '
        Me.cboPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboPriority.FormattingEnabled = True
        Me.cboPriority.Items.AddRange(New Object() {"(0) Urgent", "(1) High", "(2) Medium", "(3) Low"})
        Me.cboPriority.Location = New System.Drawing.Point(84, 233)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(197, 21)
        Me.cboPriority.TabIndex = 74
        '
        'cboChannel
        '
        Me.cboChannel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboChannel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboChannel.FormattingEnabled = True
        Me.cboChannel.Location = New System.Drawing.Point(84, 162)
        Me.cboChannel.Name = "cboChannel"
        Me.cboChannel.Size = New System.Drawing.Size(197, 21)
        Me.cboChannel.Sorted = True
        Me.cboChannel.TabIndex = 73
        '
        'cboCategory
        '
        Me.cboCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Config/Setup", "Data/Script", "Documents", "Enhancements/New Features", "Not an issue", "Question", "Question/Consulting", "Refresh DB/Run HRIS", "Report", "Resource file", "Special Request", "Troubleshooting", "Troubleshooting - Config/Setup", "Troubleshooting - Data", "Troubleshooting - Defect", "Troubleshooting - Not an Issue", "Troubleshooting - Process"})
        Me.cboCategory.Location = New System.Drawing.Point(84, 198)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(197, 21)
        Me.cboCategory.Sorted = True
        Me.cboCategory.TabIndex = 72
        '
        'txtDetails
        '
        Me.txtDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDetails.Location = New System.Drawing.Point(13, 344)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(586, 137)
        Me.txtDetails.TabIndex = 71
        Me.txtDetails.Text = ""
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblDetails.Location = New System.Drawing.Point(10, 328)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(39, 13)
        Me.lblDetails.TabIndex = 70
        Me.lblDetails.Text = "Details"
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblPriority.Location = New System.Drawing.Point(10, 236)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(38, 13)
        Me.lblPriority.TabIndex = 69
        Me.lblPriority.Text = "Priority"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(315, 233)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 68
        Me.lblStatus.Text = "Status"
        '
        'lblDateRcvd
        '
        Me.lblDateRcvd.AutoSize = True
        Me.lblDateRcvd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblDateRcvd.Location = New System.Drawing.Point(315, 201)
        Me.lblDateRcvd.Name = "lblDateRcvd"
        Me.lblDateRcvd.Size = New System.Drawing.Size(79, 13)
        Me.lblDateRcvd.TabIndex = 67
        Me.lblDateRcvd.Text = "Date Received"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(10, 201)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 66
        Me.lblCategory.Text = "Category"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblClient.Location = New System.Drawing.Point(315, 166)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(33, 13)
        Me.lblClient.TabIndex = 65
        Me.lblClient.Text = "Client"
        '
        'lblChannel
        '
        Me.lblChannel.AutoSize = True
        Me.lblChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblChannel.Location = New System.Drawing.Point(10, 166)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(46, 13)
        Me.lblChannel.TabIndex = 64
        Me.lblChannel.Text = "Channel"
        '
        'lblTitle
        '
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(10, 101)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 63
        Me.lblTitle.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(84, 100)
        Me.txtTitle.MaxLength = 150
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(515, 20)
        Me.txtTitle.TabIndex = 62
        '
        'lblAssignee
        '
        Me.lblAssignee.AutoSize = True
        Me.lblAssignee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblAssignee.Location = New System.Drawing.Point(10, 266)
        Me.lblAssignee.Name = "lblAssignee"
        Me.lblAssignee.Size = New System.Drawing.Size(62, 13)
        Me.lblAssignee.TabIndex = 61
        Me.lblAssignee.Text = "Assigned to"
        '
        'txtReporterEmail
        '
        Me.txtReporterEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReporterEmail.Location = New System.Drawing.Point(84, 131)
        Me.txtReporterEmail.MaxLength = 80
        Me.txtReporterEmail.Name = "txtReporterEmail"
        Me.txtReporterEmail.Size = New System.Drawing.Size(197, 20)
        Me.txtReporterEmail.TabIndex = 59
        '
        'btnCreateRequest
        '
        Me.btnCreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCreateRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCreateRequest.Location = New System.Drawing.Point(209, 487)
        Me.btnCreateRequest.Name = "btnCreateRequest"
        Me.btnCreateRequest.Size = New System.Drawing.Size(187, 45)
        Me.btnCreateRequest.TabIndex = 86
        Me.btnCreateRequest.Text = "Create Request"
        Me.btnCreateRequest.UseVisualStyleBackColor = True
        '
        'lstReporter
        '
        Me.lstReporter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lstReporter.FormattingEnabled = True
        Me.lstReporter.Location = New System.Drawing.Point(13, 502)
        Me.lstReporter.Name = "lstReporter"
        Me.lstReporter.Size = New System.Drawing.Size(173, 17)
        Me.lstReporter.TabIndex = 88
        '
        'txtReportedBy
        '
        Me.txtReportedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReportedBy.Location = New System.Drawing.Point(401, 128)
        Me.txtReportedBy.Name = "txtReportedBy"
        Me.txtReportedBy.Size = New System.Drawing.Size(198, 20)
        Me.txtReportedBy.TabIndex = 89
        '
        'lblCLID
        '
        Me.lblCLID.AutoSize = True
        Me.lblCLID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblCLID.Location = New System.Drawing.Point(10, 299)
        Me.lblCLID.Name = "lblCLID"
        Me.lblCLID.Size = New System.Drawing.Size(47, 13)
        Me.lblCLID.TabIndex = 91
        Me.lblCLID.Text = "Client ID"
        '
        'txtCLID
        '
        Me.txtCLID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCLID.Location = New System.Drawing.Point(84, 299)
        Me.txtCLID.MaxLength = 80
        Me.txtCLID.Name = "txtCLID"
        Me.txtCLID.Size = New System.Drawing.Size(197, 20)
        Me.txtCLID.TabIndex = 90
        '
        'picTelusHealth
        '
        Me.picTelusHealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTelusHealth.Image = Global.ProdSupportOutlookAddIn.My.Resources.Resources.TELUS_Health_EN_Hor_2021_Digital_RGB
        Me.picTelusHealth.Location = New System.Drawing.Point(298, 12)
        Me.picTelusHealth.Name = "picTelusHealth"
        Me.picTelusHealth.Size = New System.Drawing.Size(316, 63)
        Me.picTelusHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTelusHealth.TabIndex = 58
        Me.picTelusHealth.TabStop = False
        '
        'picProdSupportLogo
        '
        Me.picProdSupportLogo.Image = Global.ProdSupportOutlookAddIn.My.Resources.Resources.ProdSupport
        Me.picProdSupportLogo.Location = New System.Drawing.Point(2, 2)
        Me.picProdSupportLogo.Name = "picProdSupportLogo"
        Me.picProdSupportLogo.Size = New System.Drawing.Size(268, 92)
        Me.picProdSupportLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProdSupportLogo.TabIndex = 57
        Me.picProdSupportLogo.TabStop = False
        '
        'NewRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(605, 576)
        Me.Controls.Add(Me.lblCLID)
        Me.Controls.Add(Me.txtCLID)
        Me.Controls.Add(Me.txtReportedBy)
        Me.Controls.Add(Me.lstReporter)
        Me.Controls.Add(Me.btnCreateRequest)
        Me.Controls.Add(Me.lblSenderEmail)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lblReporter)
        Me.Controls.Add(Me.cboClient)
        Me.Controls.Add(Me.dtReceived)
        Me.Controls.Add(Me.cboAssignedTo)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboPriority)
        Me.Controls.Add(Me.cboChannel)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDateRcvd)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.lblChannel)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblAssignee)
        Me.Controls.Add(Me.txtReporterEmail)
        Me.Controls.Add(Me.picTelusHealth)
        Me.Controls.Add(Me.picProdSupportLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NewRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create New Request from Email"
        CType(Me.picTelusHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProdSupportLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProdSupportLogo As Windows.Forms.PictureBox
    Friend WithEvents picTelusHealth As Windows.Forms.PictureBox
    Friend WithEvents lblSenderEmail As Windows.Forms.Label
    Friend WithEvents cboClient As Windows.Forms.ComboBox
    Friend WithEvents dtReceived As Windows.Forms.DateTimePicker
    Friend WithEvents cboAssignedTo As Windows.Forms.ComboBox
    Friend WithEvents cboStatus As Windows.Forms.ComboBox
    Friend WithEvents cboPriority As Windows.Forms.ComboBox
    Friend WithEvents cboChannel As Windows.Forms.ComboBox
    Friend WithEvents cboCategory As Windows.Forms.ComboBox
    Friend WithEvents txtDetails As Windows.Forms.RichTextBox
    Friend WithEvents lblComments As Windows.Forms.Label
    Friend WithEvents lblReporter As Windows.Forms.Label
    Friend WithEvents lblDetails As Windows.Forms.Label
    Friend WithEvents lblPriority As Windows.Forms.Label
    Friend WithEvents lblStatus As Windows.Forms.Label
    Friend WithEvents lblClient As Windows.Forms.Label
    Friend WithEvents lblChannel As Windows.Forms.Label
    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents txtTitle As Windows.Forms.TextBox
    Friend WithEvents lblDateRcvd As Windows.Forms.Label
    Friend WithEvents lblCategory As Windows.Forms.Label
    Friend WithEvents txtReporterEmail As Windows.Forms.TextBox
    Friend WithEvents btnCreateRequest As Windows.Forms.Button
    Friend WithEvents lblAssignee As Windows.Forms.Label
    Friend WithEvents txtComments As Windows.Forms.TextBox
    Friend WithEvents lstReporter As Windows.Forms.ListBox
    Friend WithEvents txtReportedBy As Windows.Forms.TextBox
    Friend WithEvents lblCLID As Windows.Forms.Label
    Friend WithEvents txtCLID As Windows.Forms.TextBox
End Class
