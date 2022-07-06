Partial Class ProdSupport_Ribbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabProdSupport_db = Me.Factory.CreateRibbonTab
        Me.Email_Export = Me.Factory.CreateRibbonGroup
        Me.btnCreateRequest = Me.Factory.CreateRibbonButton
        Me.btnEditRequest = Me.Factory.CreateRibbonButton
        Me.tabProdSupport_db.SuspendLayout()
        Me.Email_Export.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabProdSupport_db
        '
        Me.tabProdSupport_db.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.tabProdSupport_db.Groups.Add(Me.Email_Export)
        Me.tabProdSupport_db.Label = "Prod Support"
        Me.tabProdSupport_db.Name = "tabProdSupport_db"
        '
        'Email_Export
        '
        Me.Email_Export.Items.Add(Me.btnCreateRequest)
        Me.Email_Export.Items.Add(Me.btnEditRequest)
        Me.Email_Export.Label = "Prod Support"
        Me.Email_Export.Name = "Email_Export"
        '
        'btnCreateRequest
        '
        Me.btnCreateRequest.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnCreateRequest.Image = Global.ProdSupportOutlookAddIn.My.Resources.Resources.AddDBIcon
        Me.btnCreateRequest.ImageName = "MailExportBtn.png"
        Me.btnCreateRequest.Label = "Create Issue"
        Me.btnCreateRequest.Name = "btnCreateRequest"
        Me.btnCreateRequest.ShowImage = True
        Me.btnCreateRequest.SuperTip = "Export email to Prod Support database and create a new issue"
        '
        'btnEditRequest
        '
        Me.btnEditRequest.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.btnEditRequest.Enabled = False
        Me.btnEditRequest.Image = Global.ProdSupportOutlookAddIn.My.Resources.Resources.EditIssueTransp
        Me.btnEditRequest.Label = "Edit Existing Request"
        Me.btnEditRequest.Name = "btnEditRequest"
        Me.btnEditRequest.ShowImage = True
        Me.btnEditRequest.Visible = False
        '
        'ProdSupport_Ribbon
        '
        Me.Name = "ProdSupport_Ribbon"
        Me.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read"
        Me.Tabs.Add(Me.tabProdSupport_db)
        Me.tabProdSupport_db.ResumeLayout(False)
        Me.tabProdSupport_db.PerformLayout()
        Me.Email_Export.ResumeLayout(False)
        Me.Email_Export.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabProdSupport_db As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Email_Export As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnCreateRequest As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnEditRequest As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property ProdSupport_Ribbon() As ProdSupport_Ribbon
        Get
            Return Me.GetRibbon(Of ProdSupport_Ribbon)()
        End Get
    End Property
End Class
