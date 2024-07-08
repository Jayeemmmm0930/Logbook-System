
Imports Tulpep.NotificationWindow

Public Class frmMain

    Private WithEvents sidebarControl As sidebar
    Private WithEvents topbarControl As topbar
    Private WithEvents footerControl As footer

    Public Sub New()
        InitializeComponent()
        ShowDashboard()
        sidebarControl = New sidebar()
        sidebarControl.Dock = DockStyle.Fill
        pnlSidebar.Controls.Add(sidebarControl)

        topbarControl = New topbar()
        topbarControl.Dock = DockStyle.Fill
        pnltopbar.Controls.Add(topbarControl)

        footerControl = New footer()
        footerControl.Dock = DockStyle.Fill
        pnlTop.Controls.Add(footerControl)


        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Me.Size = New Size(CInt(screenWidth * 0.8), CInt(screenHeight * 0.8))
    End Sub

    Sub NotifyUser()
        Dim popup = New PopupNotifier
        popup.TitleText = "WELCOME USER"
        popup.ContentText = _name & vbNewLine & Now.ToLongDateString & vbNewLine & Now.ToLongTimeString
        popup.Popup()
    End Sub

    Private Sub pnltopbar_Paint(sender As Object, e As PaintEventArgs) Handles pnltopbar.Paint

    End Sub
    Public Sub ShowVisitors()

        Dim visitorsControl As New visitors()

        pnlMain.Controls.Clear()


        visitorsControl.Dock = DockStyle.Fill
        pnlMain.Controls.Add(visitorsControl)

    End Sub


    Public Sub ShowUsers()

        Dim usersControl As New user()

        pnlMain.Controls.Clear()


        usersControl.Dock = DockStyle.Fill
        pnlMain.Controls.Add(usersControl)

    End Sub

    Public Sub ShowDepartment()

        Dim departmentControl As New department()

        pnlMain.Controls.Clear()


        departmentControl.Dock = DockStyle.Fill
        pnlMain.Controls.Add(departmentControl)

    End Sub

    Public Sub ShowDashboard()

        Dim dashboardControl As New dashboard()

        pnlMain.Controls.Clear()


        dashboardControl.Dock = DockStyle.Fill
        pnlMain.Controls.Add(dashboardControl)

    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class