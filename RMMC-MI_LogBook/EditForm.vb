Imports MySql.Data.MySqlClient

Public Class EditForm
    Private userId As Integer
    Private departments As New Dictionary(Of String, Integer)()

    Public Sub New(id As Integer)
        InitializeComponent()
        userId = id
        PopulateDepartments()
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        Try
            Dim query As String = "SELECT u.firstName, u.middleInitial, u.lastName, u.acounttype, u.fk_department, ul.username, ul.password, d.department " &
                                 "FROM tbl_user u " &
                                 "INNER JOIN tbl_user_login ul ON u.fk_user_login = ul.id " &
                                 "LEFT JOIN tbl_department d ON u.fk_department = d.id " &
                                 "WHERE u.id = @UserId"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@UserId", userId)
                EnsureConnectionOpen()

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        txtFirstName.Text = dr.GetString("firstName")
                        txtMiddleInitial.Text = If(Not dr.IsDBNull(dr.GetOrdinal("middleInitial")), dr.GetString("middleInitial"), "")
                        txtLastName.Text = dr.GetString("lastName")
                        cboAccountType.SelectedItem = dr.GetString("acounttype")

                        Dim departmentName As String = If(Not dr.IsDBNull(dr.GetOrdinal("department")), dr.GetString("department"), "")
                        If Not String.IsNullOrEmpty(departmentName) Then
                            cboDepartment.SelectedItem = departmentName
                        End If

                        txtUsername.Text = dr.GetString("username")
                        txtPassword.Text = dr.GetString("password")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            EnsureConnectionClosed()
        End Try
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        Try
            If ValidateInput() = False Then Return

            ' Check if the new username is already taken
            If IsUsernameDuplicate(txtUsername.Text.Trim(), userId) Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MessageBox.Show("Update record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EnsureConnectionOpen()

                Try
                    ' Update tbl_user table
                    Dim queryUser As String = "UPDATE tbl_user SET firstname = @FirstName, middleinitial = @MiddleInitial, lastname = @LastName, " &
                                          "acounttype = @AccountType, fk_department = @Department WHERE id = @UserId"

                    Using cmdUser As New MySqlCommand(queryUser, cn)
                        cmdUser.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                        cmdUser.Parameters.AddWithValue("@MiddleInitial", txtMiddleInitial.Text.Trim())
                        cmdUser.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                        cmdUser.Parameters.AddWithValue("@AccountType", cboAccountType.SelectedItem.ToString())
                        cmdUser.Parameters.AddWithValue("@Department", departments(DirectCast(cboDepartment.SelectedItem, String)))
                        cmdUser.Parameters.AddWithValue("@UserId", userId)

                        cmdUser.ExecuteNonQuery()
                    End Using

                    ' Update tbl_user_login table
                    Dim queryLogin As String = "UPDATE tbl_user_login SET username = @Username"

                    If Not String.IsNullOrEmpty(txtPassword.Text.Trim()) Then
                        queryLogin += ", password = @Password"
                    End If

                    queryLogin += " WHERE id = (SELECT fk_user_login FROM tbl_user WHERE id = @UserId)"

                    Using cmdLogin As New MySqlCommand(queryLogin, cn)
                        cmdLogin.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                        cmdLogin.Parameters.AddWithValue("@UserId", userId)

                        If Not String.IsNullOrEmpty(txtPassword.Text.Trim()) Then
                            cmdLogin.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                        End If

                        cmdLogin.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("User information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error updating user information: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            EnsureConnectionClosed()
        End Try
    End Sub

    Private Function IsUsernameDuplicate(username As String, userId As Integer) As Boolean
        Try

            Dim query As String = "SELECT COUNT(*) FROM tbl_user_login WHERE username = @Username AND id <> (SELECT fk_user_login FROM tbl_user WHERE id = @UserId)"

                Using cmd As New MySqlCommand(query, cn)
                    cn.Open()
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@UserId", userId)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using

        Catch ex As Exception
            MessageBox.Show("Error checking username duplication: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' or handle differently based on your application logic
        End Try
    End Function





    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("First Name cannot be empty.")
            Return False
        End If

        Return True
    End Function

    Private Sub PopulateDepartments()
        cboDepartment.Items.Clear()
        departments.Clear()

        Try
            Dim query As String = "SELECT id, department FROM tbl_department"

            Using cmd As New MySqlCommand(query, cn)
                EnsureConnectionOpen()

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim departmentId As Integer = Convert.ToInt32(dr("id"))
                        Dim departmentName As String = dr("department").ToString()
                        departments.Add(departmentName, departmentId)
                        cboDepartment.Items.Add(departmentName)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            EnsureConnectionClosed()
        End Try
    End Sub

    Private Sub EnsureConnectionOpen()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error opening database connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnsureConnectionClosed()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error closing database connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtFirstName.Text = ""
        txtMiddleInitial.Text = ""
        txtLastName.Text = ""
        cboAccountType.SelectedIndex = -1
        cboDepartment.SelectedIndex = -1
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub EditForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure connection is closed when the form is closing
        EnsureConnectionClosed()
    End Sub
End Class
