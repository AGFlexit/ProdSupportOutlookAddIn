<System.ComponentModel.ToolboxItemAttribute(False)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegionExportEmailtoDB
    Inherits Microsoft.Office.Tools.Outlook.FormRegionBase

    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(Globals.Factory, formRegion)
        Me.InitializeComponent()
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Form Regions Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Shared Sub InitializeManifest(ByVal manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest, ByVal factory As Microsoft.Office.Tools.Outlook.Factory)
        manifest.FormRegionName = "Export Email to DB"
        manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.Adjoining
        manifest.ShowInspectorCompose = False
        manifest.ShowInspectorRead = False
        manifest.ShowReadingPane = False

    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboReportedBy = New System.Windows.Forms.ComboBox()
        Me.btnCreateRequest = New System.Windows.Forms.Button()
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
        Me.picTelusHealth = New System.Windows.Forms.PictureBox()
        Me.picProdSupportLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picTelusHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProdSupportLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboReportedBy
        '
        Me.cboReportedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboReportedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReportedBy.DisplayMember = "ID"
        Me.cboReportedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboReportedBy.FormattingEnabled = True
        Me.cboReportedBy.Location = New System.Drawing.Point(424, 126)
        Me.cboReportedBy.Name = "cboReportedBy"
        Me.cboReportedBy.Size = New System.Drawing.Size(144, 21)
        Me.cboReportedBy.TabIndex = 114
        Me.cboReportedBy.ValueMember = "ID"
        '
        'btnCreateRequest
        '
        Me.btnCreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCreateRequest.Location = New System.Drawing.Point(207, 485)
        Me.btnCreateRequest.Name = "btnCreateRequest"
        Me.btnCreateRequest.Size = New System.Drawing.Size(187, 45)
        Me.btnCreateRequest.TabIndex = 113
        Me.btnCreateRequest.Text = "Create Request"
        Me.btnCreateRequest.UseVisualStyleBackColor = True
        '
        'lblSenderEmail
        '
        Me.lblSenderEmail.AutoSize = True
        Me.lblSenderEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblSenderEmail.Location = New System.Drawing.Point(8, 129)
        Me.lblSenderEmail.Name = "lblSenderEmail"
        Me.lblSenderEmail.Size = New System.Drawing.Size(69, 13)
        Me.lblSenderEmail.TabIndex = 91
        Me.lblSenderEmail.Text = "Sender Email"
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblComments.Location = New System.Drawing.Point(313, 261)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 112
        Me.lblComments.Text = "Comments"
        '
        'txtComments
        '
        Me.txtComments.AcceptsReturn = True
        Me.txtComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComments.Location = New System.Drawing.Point(424, 261)
        Me.txtComments.MaxLength = 500
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(144, 42)
        Me.txtComments.TabIndex = 111
        '
        'lblReporter
        '
        Me.lblReporter.AutoSize = True
        Me.lblReporter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblReporter.Location = New System.Drawing.Point(313, 129)
        Me.lblReporter.Name = "lblReporter"
        Me.lblReporter.Size = New System.Drawing.Size(65, 13)
        Me.lblReporter.TabIndex = 110
        Me.lblReporter.Text = "Reported by"
        '
        'cboClient
        '
        Me.cboClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClient.DisplayMember = "ID"
        Me.cboClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboClient.FormattingEnabled = True
        Me.cboClient.Location = New System.Drawing.Point(424, 160)
        Me.cboClient.Name = "cboClient"
        Me.cboClient.Size = New System.Drawing.Size(144, 21)
        Me.cboClient.TabIndex = 109
        Me.cboClient.ValueMember = "ID"
        '
        'dtReceived
        '
        Me.dtReceived.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dtReceived.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dtReceived.Checked = False
        Me.dtReceived.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtReceived.Font = New System.Drawing.Font("Microsoft JhengHei", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReceived.Location = New System.Drawing.Point(424, 195)
        Me.dtReceived.Name = "dtReceived"
        Me.dtReceived.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtReceived.RightToLeftLayout = True
        Me.dtReceived.Size = New System.Drawing.Size(144, 25)
        Me.dtReceived.TabIndex = 108
        '
        'cboAssignedTo
        '
        Me.cboAssignedTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboAssignedTo.FormattingEnabled = True
        Me.cboAssignedTo.Items.AddRange(New Object() {"Mary Anne Cheung", "Alain Gasse", "Alex Case", "Francis Lemaire", "Geneviève Marquis", "Mengdi Liu", "Prod Support"})
        Me.cboAssignedTo.Location = New System.Drawing.Point(106, 261)
        Me.cboAssignedTo.Name = "cboAssignedTo"
        Me.cboAssignedTo.Size = New System.Drawing.Size(173, 21)
        Me.cboAssignedTo.TabIndex = 107
        '
        'cboStatus
        '
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Cancelled", "Completed", "Escalated to Prod Support", "In Progress", "Not Started", "On Hold (Client)"})
        Me.cboStatus.Location = New System.Drawing.Point(424, 228)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(144, 21)
        Me.cboStatus.Sorted = True
        Me.cboStatus.TabIndex = 106
        '
        'cboPriority
        '
        Me.cboPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboPriority.FormattingEnabled = True
        Me.cboPriority.Items.AddRange(New Object() {"(0) Urgent", "(1) High", "(2) Normal", "(3) Low"})
        Me.cboPriority.Location = New System.Drawing.Point(106, 231)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(173, 21)
        Me.cboPriority.TabIndex = 105
        '
        'cboChannel
        '
        Me.cboChannel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboChannel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboChannel.FormattingEnabled = True
        Me.cboChannel.Location = New System.Drawing.Point(106, 160)
        Me.cboChannel.Name = "cboChannel"
        Me.cboChannel.Size = New System.Drawing.Size(173, 21)
        Me.cboChannel.Sorted = True
        Me.cboChannel.TabIndex = 104
        '
        'cboCategory
        '
        Me.cboCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Administrator", "Administrator - French", "Call", "Call - French", "Carrier", "Carrier - French", "Employee", "Employee - French"})
        Me.cboCategory.Location = New System.Drawing.Point(106, 196)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(173, 21)
        Me.cboCategory.Sorted = True
        Me.cboCategory.TabIndex = 103
        '
        'txtDetails
        '
        Me.txtDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDetails.Location = New System.Drawing.Point(11, 314)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(557, 165)
        Me.txtDetails.TabIndex = 102
        Me.txtDetails.Text = ""
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblDetails.Location = New System.Drawing.Point(8, 298)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(39, 13)
        Me.lblDetails.TabIndex = 101
        Me.lblDetails.Text = "Details"
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblPriority.Location = New System.Drawing.Point(8, 234)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(38, 13)
        Me.lblPriority.TabIndex = 100
        Me.lblPriority.Text = "Priority"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(313, 231)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 99
        Me.lblStatus.Text = "Status"
        '
        'lblDateRcvd
        '
        Me.lblDateRcvd.AutoSize = True
        Me.lblDateRcvd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblDateRcvd.Location = New System.Drawing.Point(313, 199)
        Me.lblDateRcvd.Name = "lblDateRcvd"
        Me.lblDateRcvd.Size = New System.Drawing.Size(79, 13)
        Me.lblDateRcvd.TabIndex = 98
        Me.lblDateRcvd.Text = "Date Received"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(8, 199)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 97
        Me.lblCategory.Text = "Category"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblClient.Location = New System.Drawing.Point(313, 164)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(33, 13)
        Me.lblClient.TabIndex = 96
        Me.lblClient.Text = "Client"
        '
        'lblChannel
        '
        Me.lblChannel.AutoSize = True
        Me.lblChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblChannel.Location = New System.Drawing.Point(8, 164)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(46, 13)
        Me.lblChannel.TabIndex = 95
        Me.lblChannel.Text = "Channel"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(8, 99)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 94
        Me.lblTitle.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(106, 98)
        Me.txtTitle.MaxLength = 80
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(462, 20)
        Me.txtTitle.TabIndex = 93
        '
        'lblAssignee
        '
        Me.lblAssignee.AutoSize = True
        Me.lblAssignee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblAssignee.Location = New System.Drawing.Point(8, 264)
        Me.lblAssignee.Name = "lblAssignee"
        Me.lblAssignee.Size = New System.Drawing.Size(62, 13)
        Me.lblAssignee.TabIndex = 92
        Me.lblAssignee.Text = "Assigned to"
        '
        'txtReporterEmail
        '
        Me.txtReporterEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReporterEmail.Location = New System.Drawing.Point(106, 129)
        Me.txtReporterEmail.MaxLength = 80
        Me.txtReporterEmail.Name = "txtReporterEmail"
        Me.txtReporterEmail.Size = New System.Drawing.Size(173, 20)
        Me.txtReporterEmail.TabIndex = 90
        '
        'picTelusHealth
        '
        Me.picTelusHealth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTelusHealth.Image = Global.ProdSupportOutlookAddIn.My.Resources.Resources.TELUS_Health_EN_Hor_2021_Digital_RGB
        Me.picTelusHealth.Location = New System.Drawing.Point(296, 10)
        Me.picTelusHealth.Name = "picTelusHealth"
        Me.picTelusHealth.Size = New System.Drawing.Size(289, 63)
        Me.picTelusHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTelusHealth.TabIndex = 89
        Me.picTelusHealth.TabStop = False
        '
        'picProdSupportLogo
        '
        Me.picProdSupportLogo.Image = Global.ProdSupportOutlookAddIn.My.Resources.Resources.ProdSupport
        Me.picProdSupportLogo.Location = New System.Drawing.Point(0, 0)
        Me.picProdSupportLogo.Name = "picProdSupportLogo"
        Me.picProdSupportLogo.Size = New System.Drawing.Size(268, 92)
        Me.picProdSupportLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProdSupportLogo.TabIndex = 88
        Me.picProdSupportLogo.TabStop = False
        '
        'frmRegionExportEmailtoDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cboReportedBy)
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
        Me.Enabled = False
        Me.Name = "frmRegionExportEmailtoDB"
        Me.Size = New System.Drawing.Size(585, 10)
        CType(Me.picTelusHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProdSupportLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboReportedBy As Windows.Forms.ComboBox
    Friend WithEvents btnCreateRequest As Windows.Forms.Button
    Friend WithEvents lblSenderEmail As Windows.Forms.Label
    Friend WithEvents lblComments As Windows.Forms.Label
    Friend WithEvents txtComments As Windows.Forms.TextBox
    Friend WithEvents lblReporter As Windows.Forms.Label
    Friend WithEvents cboClient As Windows.Forms.ComboBox
    Friend WithEvents dtReceived As Windows.Forms.DateTimePicker
    Friend WithEvents cboAssignedTo As Windows.Forms.ComboBox
    Friend WithEvents cboStatus As Windows.Forms.ComboBox
    Friend WithEvents cboPriority As Windows.Forms.ComboBox
    Friend WithEvents cboChannel As Windows.Forms.ComboBox
    Friend WithEvents cboCategory As Windows.Forms.ComboBox
    Friend WithEvents txtDetails As Windows.Forms.RichTextBox
    Friend WithEvents lblDetails As Windows.Forms.Label
    Friend WithEvents lblPriority As Windows.Forms.Label
    Friend WithEvents lblStatus As Windows.Forms.Label
    Friend WithEvents lblDateRcvd As Windows.Forms.Label
    Friend WithEvents lblCategory As Windows.Forms.Label
    Friend WithEvents lblClient As Windows.Forms.Label
    Friend WithEvents lblChannel As Windows.Forms.Label
    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents txtTitle As Windows.Forms.TextBox
    Friend WithEvents lblAssignee As Windows.Forms.Label
    Friend WithEvents txtReporterEmail As Windows.Forms.TextBox
    Friend WithEvents picTelusHealth As Windows.Forms.PictureBox
    Friend WithEvents picProdSupportLogo As Windows.Forms.PictureBox

    Partial Public Class frmRegionExportEmailtoDBFactory
        Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory

        Public Event FormRegionInitializing As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler

        Private _Manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest


        <System.Diagnostics.DebuggerNonUserCodeAttribute()>
        Public Sub New()
            Me._Manifest = Globals.Factory.CreateFormRegionManifest()
            frmRegionExportEmailtoDB.InitializeManifest(Me._Manifest, Globals.Factory)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()>
        ReadOnly Property Manifest() As Microsoft.Office.Tools.Outlook.FormRegionManifest Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Manifest
            Get
                Return Me._Manifest
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()>
        Function CreateFormRegion(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion) As Microsoft.Office.Tools.Outlook.IFormRegion Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion
            Dim form As frmRegionExportEmailtoDB = New frmRegionExportEmailtoDB(formRegion)
            form.Factory = Me
            Return form
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()>
        Function GetFormRegionStorage(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Byte() Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage
            Throw New System.NotSupportedException()
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()>
        Function IsDisplayedForItem(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Boolean Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem
            Dim cancelArgs As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs = Globals.Factory.CreateFormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, False)
            cancelArgs.Cancel = False
            RaiseEvent FormRegionInitializing(Me, cancelArgs)
            Return Not cancelArgs.Cancel
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()>
        ReadOnly Property Kind() As Microsoft.Office.Tools.Outlook.FormRegionKindConstants Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            Get
                Return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.WindowsForms
            End Get
        End Property
    End Class
End Class

Partial Class WindowFormRegionCollection

    Friend ReadOnly Property frmRegionExportEmailtoDB() As frmRegionExportEmailtoDB
        Get
            For Each Item As Object In Me
                If (TypeOf (Item) Is frmRegionExportEmailtoDB) Then
                    Return Item
                End If
            Next
            Return Nothing
        End Get
    End Property
End Class