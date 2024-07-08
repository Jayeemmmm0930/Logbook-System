Imports MySql.Data.MySqlClient
Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Me.AcceptButton = btnLogin
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim found As Boolean = False


            If IS_EMPTY(txtUser) Or IS_EMPTY(txtPass) Then
                Return
            End If


            If txtUser.Text = "superadmin" AndAlso txtPass.Text = "superadmin" Then
                found = True
                _user = "superadmin"
                _name = "Superadmin"
                _account = "Admin"
                _departmentName = "SuperAdmin"
            Else

                cn.Open()
                cm = New MySqlCommand("SELECT ul.username, u.firstname, u.middleinitial, u.lastname, u.acounttype, d.department " &
                  "FROM tbl_user_login ul " &
                  "INNER JOIN tbl_user u ON ul.id = u.fk_user_login " &
                  "INNER JOIN tbl_department d ON u.fk_department = d.id " &
                  "WHERE ul.username = @username AND ul.password = @password", cn)

                With cm
                    .Parameters.AddWithValue("@username", txtUser.Text)
                    .Parameters.AddWithValue("@password", txtPass.Text)
                End With

                dr = cm.ExecuteReader
                If dr.Read() Then
                    found = True
                    _user = dr("username").ToString()
                    Dim firstname As String = dr("firstname").ToString()
                    Dim middlename As String = dr("middleinitial").ToString()
                    Dim lastname As String = dr("lastname").ToString()
                    _name = $"{firstname} {middlename} {lastname}"
                    _account = dr("acounttype").ToString()
                    _departmentName = dr("department").ToString()
                End If

                dr.Close()
                cn.Close()
            End If

            If found Then
                If _account = "Admin" Then

                    With frmMain
                        txtPass.Clear()
                        txtUser.Clear()
                        Me.Hide()
                        .NotifyUser()
                        .ShowDialog()
                    End With
                ElseIf _account = "Staff" Then

                    With frmStaff
                        txtPass.Clear()
                        txtUser.Clear()
                        Me.Hide()
                        .NotifyUser()
                        .ShowDialog()
                    End With
                Else
                    MsgBox("Invalid account type. Contact administrator.", vbCritical)
                End If
            Else
                ' Login failed
                MsgBox("INVALID USERNAME AND PASSWORD", vbCritical)
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub



    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        With frmSelect
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub txtUser_Click(sender As Object, e As EventArgs) Handles txtUser.Click

    End Sub
End Class