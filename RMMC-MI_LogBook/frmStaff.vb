
Imports Tulpep.NotificationWindow



Public Class frmStaff
    Private WithEvents sidebarControl As sidebar
    Private WithEvents topbarControl As topbar
    Private WithEvents footerControl As footer

    Public dept As String

    Public Sub New()
        InitializeComponent()
        dept = _departmentName
        ShowDashboard()
        sidebarControl = New sidebar()
        sidebarControl.Dock = DockStyle.Fill
        pnlSidebar.Controls.Add(sidebarControl)

        topbarControl = New topbar()
        topbarControl.Dock = DockStyle.Fill
        pnlTopbar.Controls.Add(topbarControl)

        footerControl = New footer()
        footerControl.Dock = DockStyle.Fill
        pnlTop.Controls.Add(footerControl)

        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        Me.Size = New Size(CInt(screenWidth * 0.8), CInt(screenHeight * 0.8))
    End Sub

    Public Sub NotifyUser()
        Dim popup As New PopupNotifier()


        popup.TitleText = "WELCOME USER"
        popup.ContentText = $"{_name} {_departmentName}{vbNewLine}{Now.ToLongDateString}{vbNewLine}{Now.ToLongTimeString}"




        popup.Popup()
    End Sub

    Public Sub ShowDashboard()

        Dim dashboardControl As New dashboard()

        pnlMain.Controls.Clear()


        dashboardControl.Dock = DockStyle.Fill
        pnlMain.Controls.Add(dashboardControl)

    End Sub

    Public Sub HandleVisitorEntered(fullName As String, address As String, purpose As String, designation As String)
        Try
            _fullname = fullName
            _address = address
            _purpose = purpose
            If dept = designation Then


                Dim popupsecond As New PopupNotifier()
                popupsecond.TitleText = "Incoming Person"
                popupsecond.ContentText = $"{_fullname}{vbNewLine}Purpose: {_purpose}{vbNewLine}Designation: {designation}{vbNewLine}Date: {Now.ToLongDateString}{vbNewLine}Time: {Now.ToLongTimeString}"

                popupsecond.Size = New System.Drawing.Size(400, 200)
                popupsecond.ContentPadding = New Padding(10)
                popupsecond.ShowGrip = True
                popupsecond.Delay = Integer.MaxValue
                popupsecond.Popup()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, $"Error displaying notification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub pnltopbar_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopbar.Paint

    End Sub

    Public Sub ShowVisitors()
        Dim visitorsControl As New visitors()
        pnlMain.Controls.Clear()
        visitorsControl.Dock = DockStyle.Fill
        pnlMain.Controls.Add(visitorsControl)
    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
