Imports MySql.Data.MySqlClient

Public Class frmDatabasesetup

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        Dim connectionString As String = GetConnectionString()
        If TestConnection(connectionString) Then
            MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim connectionString As String = GetConnectionString()

        If TestConnection(connectionString) Then
            MessageBox.Show("Connection successful! You can now proceed with database operations.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SaveConnectionDetails(connectionString)
            PromptLoginForm()
            Me.Hide()
        Else
            MessageBox.Show("Connection failed! Please check your connection settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function TestConnection(connectionString As String) As Boolean
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub SaveConnectionDetails(connectionString As String)
        My.Settings.ConnectionString = connectionString
        My.Settings.Save()
    End Sub

    Private Function GetConnectionString() As String
        Dim server As String = txtServer.Text.Trim()
        Dim database As String = txtDatabase.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Example connection string for MySQL
        Dim connectionString As String = $"Server={server};Database={database};Uid={username};Pwd={password};"

        ' Replace above example connection string with your actual MySQL connection string format

        Return connectionString
    End Function

    Private Sub PromptLoginForm()
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Close()
    End Sub

End Class
