Public Class sidebar

    Private Sub sidebar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _account = "Staff" Then
            btnUsers.Visible = False
            btnDepartments.Visible = False
        ElseIf _account = "Admin" Then
            btnUsers.Visible = True
            btnDepartments.Visible = True
        End If
    End Sub

    Private Sub btnVisitors_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        If _account = "Staff" Then

            Dim staffForm As frmStaff = CType(Me.ParentForm, frmStaff)
            staffForm.ShowVisitors()
        ElseIf _account = "Admin" Then

            Dim mainForm As frmMain = CType(Me.ParentForm, frmMain)
            mainForm.ShowVisitors()
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim mainForm As frmMain = CType(Me.ParentForm, frmMain)
        mainForm.ShowUsers()
    End Sub

    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        Dim mainForm As frmMain = CType(Me.ParentForm, frmMain)
        mainForm.ShowDepartment()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim loginForm As New frmLogin()
            loginForm.Show()

            Dim mainForm As Form = Me.FindForm()
            mainForm.Close()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If _account = "Staff" Then

            Dim staffForm As frmStaff = CType(Me.ParentForm, frmStaff)
            staffForm.ShowDashboard()
        ElseIf _account = "Admin" Then

            Dim mainForm As frmMain = CType(Me.ParentForm, frmMain)
            mainForm.ShowDashboard()
        End If
    End Sub
End Class
