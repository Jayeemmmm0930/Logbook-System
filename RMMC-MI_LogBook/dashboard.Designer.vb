<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.UserControl

    ' Declare components and controls
    Private components As System.ComponentModel.IContainer
    Private lblWelcome As MetroFramework.Controls.MetroLabel
    Private panelHeader As MetroFramework.Controls.MetroPanel
    Private panelTotals As MetroFramework.Controls.MetroPanel
    Private panelVisitors As MetroFramework.Controls.MetroPanel
    Private panelDepartments As MetroFramework.Controls.MetroPanel
    Private panelUsers As MetroFramework.Controls.MetroPanel
    Private lblVisitors As MetroFramework.Controls.MetroLabel
    Private lblDepartments As MetroFramework.Controls.MetroLabel
    Private lblUsers As MetroFramework.Controls.MetroLabel
    Private iconVisitors As FontAwesome.Sharp.IconPictureBox
    Private iconDepartments As FontAwesome.Sharp.IconPictureBox
    Private iconUsers As FontAwesome.Sharp.IconPictureBox

    ' Constructor


    ' Initialize components
    Private Sub InitializeComponent()
        Me.panelHeader = New MetroFramework.Controls.MetroPanel()
        Me.lblWelcome = New MetroFramework.Controls.MetroLabel()
        Me.panelTotals = New MetroFramework.Controls.MetroPanel()
        Me.panelUsers = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblUsers = New MetroFramework.Controls.MetroLabel()
        Me.iconUsers = New FontAwesome.Sharp.IconPictureBox()
        Me.panelDepartments = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblDepartments = New MetroFramework.Controls.MetroLabel()
        Me.iconDepartments = New FontAwesome.Sharp.IconPictureBox()
        Me.panelVisitors = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblVisitors = New MetroFramework.Controls.MetroLabel()
        Me.iconVisitors = New FontAwesome.Sharp.IconPictureBox()
        Me.panelHeader.SuspendLayout()
        Me.panelTotals.SuspendLayout()
        Me.panelUsers.SuspendLayout()
        CType(Me.iconUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDepartments.SuspendLayout()
        CType(Me.iconDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelVisitors.SuspendLayout()
        CType(Me.iconVisitors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.lblWelcome)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.HorizontalScrollbarBarColor = True
        Me.panelHeader.HorizontalScrollbarHighlightOnWheel = False
        Me.panelHeader.HorizontalScrollbarSize = 11
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1067, 116)
        Me.panelHeader.TabIndex = 0
        Me.panelHeader.VerticalScrollbarBarColor = True
        Me.panelHeader.VerticalScrollbarHighlightOnWheel = False
        Me.panelHeader.VerticalScrollbarSize = 13
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWelcome.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblWelcome.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1067, 116)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Your Dashboard"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelTotals
        '
        Me.panelTotals.Controls.Add(Me.panelUsers)
        Me.panelTotals.Controls.Add(Me.panelDepartments)
        Me.panelTotals.Controls.Add(Me.panelVisitors)
        Me.panelTotals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTotals.HorizontalScrollbarBarColor = True
        Me.panelTotals.HorizontalScrollbarHighlightOnWheel = False
        Me.panelTotals.HorizontalScrollbarSize = 11
        Me.panelTotals.Location = New System.Drawing.Point(0, 116)
        Me.panelTotals.Margin = New System.Windows.Forms.Padding(4)
        Me.panelTotals.Name = "panelTotals"
        Me.panelTotals.Size = New System.Drawing.Size(1067, 579)
        Me.panelTotals.TabIndex = 1
        Me.panelTotals.VerticalScrollbarBarColor = True
        Me.panelTotals.VerticalScrollbarHighlightOnWheel = False
        Me.panelTotals.VerticalScrollbarSize = 13
        '
        'panelUsers
        '
        Me.panelUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.panelUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelUsers.Controls.Add(Me.MetroLabel1)
        Me.panelUsers.Controls.Add(Me.lblUsers)
        Me.panelUsers.Controls.Add(Me.iconUsers)
        Me.panelUsers.HorizontalScrollbarBarColor = True
        Me.panelUsers.HorizontalScrollbarHighlightOnWheel = False
        Me.panelUsers.HorizontalScrollbarSize = 11
        Me.panelUsers.Location = New System.Drawing.Point(915, 58)
        Me.panelUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.panelUsers.Name = "panelUsers"
        Me.panelUsers.Size = New System.Drawing.Size(302, 463)
        Me.panelUsers.TabIndex = 2
        Me.panelUsers.VerticalScrollbarBarColor = True
        Me.panelUsers.VerticalScrollbarHighlightOnWheel = False
        Me.panelUsers.VerticalScrollbarSize = 13
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(128, 306)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(23, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "2"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblUsers.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblUsers.ForeColor = System.Drawing.Color.White
        Me.lblUsers.Location = New System.Drawing.Point(36, 46)
        Me.lblUsers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(113, 25)
        Me.lblUsers.TabIndex = 2
        Me.lblUsers.Text = "Total Users:"
        Me.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iconUsers
        '
        Me.iconUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.iconUsers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.iconUsers.IconColor = System.Drawing.Color.White
        Me.iconUsers.IconSize = 185
        Me.iconUsers.Location = New System.Drawing.Point(36, 94)
        Me.iconUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.iconUsers.Name = "iconUsers"
        Me.iconUsers.Size = New System.Drawing.Size(212, 185)
        Me.iconUsers.TabIndex = 1
        Me.iconUsers.TabStop = False
        '
        'panelDepartments
        '
        Me.panelDepartments.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.panelDepartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDepartments.Controls.Add(Me.MetroLabel2)
        Me.panelDepartments.Controls.Add(Me.lblDepartments)
        Me.panelDepartments.Controls.Add(Me.iconDepartments)
        Me.panelDepartments.HorizontalScrollbarBarColor = True
        Me.panelDepartments.HorizontalScrollbarHighlightOnWheel = False
        Me.panelDepartments.HorizontalScrollbarSize = 11
        Me.panelDepartments.Location = New System.Drawing.Point(477, 58)
        Me.panelDepartments.Margin = New System.Windows.Forms.Padding(4)
        Me.panelDepartments.Name = "panelDepartments"
        Me.panelDepartments.Size = New System.Drawing.Size(302, 463)
        Me.panelDepartments.TabIndex = 1
        Me.panelDepartments.VerticalScrollbarBarColor = True
        Me.panelDepartments.VerticalScrollbarHighlightOnWheel = False
        Me.panelDepartments.VerticalScrollbarSize = 13
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.White
        Me.MetroLabel2.Location = New System.Drawing.Point(143, 306)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(23, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "3"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartments
        '
        Me.lblDepartments.AutoSize = True
        Me.lblDepartments.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDepartments.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblDepartments.ForeColor = System.Drawing.Color.White
        Me.lblDepartments.Location = New System.Drawing.Point(20, 46)
        Me.lblDepartments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartments.Name = "lblDepartments"
        Me.lblDepartments.Size = New System.Drawing.Size(181, 25)
        Me.lblDepartments.TabIndex = 2
        Me.lblDepartments.Text = "Total Departments:"
        Me.lblDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iconDepartments
        '
        Me.iconDepartments.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.iconDepartments.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.iconDepartments.IconColor = System.Drawing.Color.White
        Me.iconDepartments.IconSize = 185
        Me.iconDepartments.Location = New System.Drawing.Point(39, 94)
        Me.iconDepartments.Margin = New System.Windows.Forms.Padding(4)
        Me.iconDepartments.Name = "iconDepartments"
        Me.iconDepartments.Size = New System.Drawing.Size(212, 185)
        Me.iconDepartments.TabIndex = 1
        Me.iconDepartments.TabStop = False
        '
        'panelVisitors
        '
        Me.panelVisitors.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.panelVisitors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelVisitors.Controls.Add(Me.MetroLabel3)
        Me.panelVisitors.Controls.Add(Me.lblVisitors)
        Me.panelVisitors.Controls.Add(Me.iconVisitors)
        Me.panelVisitors.HorizontalScrollbarBarColor = True
        Me.panelVisitors.HorizontalScrollbarHighlightOnWheel = False
        Me.panelVisitors.HorizontalScrollbarSize = 11
        Me.panelVisitors.Location = New System.Drawing.Point(69, 58)
        Me.panelVisitors.Margin = New System.Windows.Forms.Padding(4)
        Me.panelVisitors.Name = "panelVisitors"
        Me.panelVisitors.Size = New System.Drawing.Size(266, 463)
        Me.panelVisitors.TabIndex = 0
        Me.panelVisitors.VerticalScrollbarBarColor = True
        Me.panelVisitors.VerticalScrollbarHighlightOnWheel = False
        Me.panelVisitors.VerticalScrollbarSize = 13
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.Color.White
        Me.MetroLabel3.Location = New System.Drawing.Point(112, 306)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(23, 25)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "1"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVisitors
        '
        Me.lblVisitors.AutoSize = True
        Me.lblVisitors.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblVisitors.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblVisitors.ForeColor = System.Drawing.Color.White
        Me.lblVisitors.Location = New System.Drawing.Point(18, 46)
        Me.lblVisitors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVisitors.Name = "lblVisitors"
        Me.lblVisitors.Size = New System.Drawing.Size(131, 25)
        Me.lblVisitors.TabIndex = 1
        Me.lblVisitors.Text = "Total Visitors:"
        Me.lblVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iconVisitors
        '
        Me.iconVisitors.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.iconVisitors.IconChar = FontAwesome.Sharp.IconChar.User
        Me.iconVisitors.IconColor = System.Drawing.Color.White
        Me.iconVisitors.IconSize = 185
        Me.iconVisitors.Location = New System.Drawing.Point(18, 94)
        Me.iconVisitors.Margin = New System.Windows.Forms.Padding(4)
        Me.iconVisitors.Name = "iconVisitors"
        Me.iconVisitors.Size = New System.Drawing.Size(212, 185)
        Me.iconVisitors.TabIndex = 0
        Me.iconVisitors.TabStop = False
        '
        'dashboard
        '
        Me.Controls.Add(Me.panelTotals)
        Me.Controls.Add(Me.panelHeader)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dashboard"
        Me.Size = New System.Drawing.Size(1067, 695)
        Me.panelHeader.ResumeLayout(False)
        Me.panelTotals.ResumeLayout(False)
        Me.panelUsers.ResumeLayout(False)
        Me.panelUsers.PerformLayout()
        CType(Me.iconUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDepartments.ResumeLayout(False)
        Me.panelDepartments.PerformLayout()
        CType(Me.iconDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelVisitors.ResumeLayout(False)
        Me.panelVisitors.PerformLayout()
        CType(Me.iconVisitors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    ' Initialize controls for each panel
    Private Sub InitializeControls()
        ' panelHeader
        Me.lblWelcome.Text = "Welcome to Your Dashboard"

        ' panelVisitors
        Me.lblVisitors.Text = "Total Visitors:"
        Me.iconVisitors.IconChar = FontAwesome.Sharp.IconChar.User

        ' Add content to panelVisitors
        Dim lblVisitorsCount As New MetroFramework.Controls.MetroLabel()
        lblVisitorsCount.AutoSize = True
        lblVisitorsCount.FontSize = MetroFramework.MetroLabelSize.Tall
        lblVisitorsCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        lblVisitorsCount.ForeColor = Color.White
        lblVisitorsCount.Location = New Point(30, 200)
        lblVisitorsCount.Text = "100" ' Example data, replace with dynamic data
        Me.panelVisitors.Controls.Add(lblVisitorsCount)

        ' panelDepartments
        Me.lblDepartments.Text = "Total Departments:"
        Me.iconDepartments.IconChar = FontAwesome.Sharp.IconChar.Building

        ' Add content to panelDepartments
        Dim lblDepartmentsCount As New MetroFramework.Controls.MetroLabel()
        lblDepartmentsCount.AutoSize = True
        lblDepartmentsCount.FontSize = MetroFramework.MetroLabelSize.Tall
        lblDepartmentsCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        lblDepartmentsCount.ForeColor = Color.White
        lblDepartmentsCount.Location = New Point(30, 200)
        lblDepartmentsCount.Text = "10" ' Example data, replace with dynamic data
        Me.panelDepartments.Controls.Add(lblDepartmentsCount)

        ' panelUsers
        Me.lblUsers.Text = "Total Users:"
        Me.iconUsers.IconChar = FontAwesome.Sharp.IconChar.Users

        Dim lblUsersCount As New MetroFramework.Controls.MetroLabel()
        lblUsersCount.AutoSize = True
        lblUsersCount.FontSize = MetroFramework.MetroLabelSize.Tall
        lblUsersCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        lblUsersCount.ForeColor = Color.White
        lblUsersCount.Location = New Point(30, 200)
        lblUsersCount.Text = "50"
        Me.panelUsers.Controls.Add(lblUsersCount)
    End Sub

    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
