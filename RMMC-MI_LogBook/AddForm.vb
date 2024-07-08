Imports MySql.Data.MySqlClient

Public Class AddForm

    Private departments As New Dictionary(Of String, Integer)()

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDepartments()
    End Sub

    Private Sub PopulateDepartments()
        cboDepartment.Items.Clear()
        departments.Clear()

        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim query As String = "SELECT id, department FROM tbl_department"

            Using cmd As New MySqlCommand(query, cn)
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
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Try
            ' Check if all required fields are filled
            If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
               String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
               cboAccountType.SelectedItem Is Nothing OrElse
               cboDepartment.SelectedItem Is Nothing OrElse
               String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
               String.IsNullOrWhiteSpace(txtPassword.Text) Then

                MessageBox.Show("All fields except for Middle Initial are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim usernameExistsQuery As String = "SELECT COUNT(*) FROM tbl_user_login WHERE username = @username"
            Dim usernameExists As Boolean = False

            Using cmdCheck As New MySqlCommand(usernameExistsQuery, cn)
                cmdCheck.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                usernameExists = (count > 0)
            End Using

            If usernameExists Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If username is unique and all fields are filled, proceed with inserting the user
            Dim insertLoginQuery As String = "INSERT INTO tbl_user_login (username, password) VALUES (@username, @password); SELECT LAST_INSERT_ID();"
            Dim loginId As Integer = 0

            Using cmd As New MySqlCommand(insertLoginQuery, cn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
                loginId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            Dim insertUserQuery As String = "INSERT INTO tbl_user (firstname, middleinitial, lastname, acounttype, fk_department, fk_user_login) " &
                                            "VALUES (@first_name, @middle_initial, @last_name, @account_type, @department_id, @fk_user_login);"

            Using cmdInsertUser As New MySqlCommand(insertUserQuery, cn)
                cmdInsertUser.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim())
                cmdInsertUser.Parameters.AddWithValue("@middle_initial", If(String.IsNullOrWhiteSpace(txtMiddleInitial.Text), DBNull.Value, txtMiddleInitial.Text.Trim()))
                cmdInsertUser.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim())
                cmdInsertUser.Parameters.AddWithValue("@account_type", cboAccountType.SelectedItem.ToString())
                cmdInsertUser.Parameters.AddWithValue("@department_id", departments(DirectCast(cboDepartment.SelectedItem, String)))
                cmdInsertUser.Parameters.AddWithValue("@fk_user_login", loginId)
                cmdInsertUser.ExecuteNonQuery()
            End Using

            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As Exception
            MessageBox.Show($"An error occurred while adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
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

End Class
