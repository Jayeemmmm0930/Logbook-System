Imports MySql.Data.MySqlClient
Imports System.IO
Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public _user As String
    Public _name As String
    Public _pass As String
    Public _account As String
    Public _departmentName As String
    Public _fullname As String
    Public _address As String
    Public _purpose As String
    Public office As String
    Public _designation As String

    Sub Connection()
        Dim connStringPath As String = Path.Combine(Application.StartupPath, "connstring.txt")

        Try
            Dim connString As String = File.ReadAllText(connStringPath)
            cn.ConnectionString = connString
            cn.Open()


            If cn.State <> ConnectionState.Open Then
                MessageBox.Show("Failed to establish database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Database connection established successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while reading or setting the connection string: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim databaseSetupForm As New frmDatabasesetup()
            databaseSetupForm.ShowDialog()
        Finally
            ' Always close the connection if it was opened
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Public Function IS_EMPTY(ByRef sText As Object) As Boolean
        On Error Resume Next
        If sText.Text = "" Then
            IS_EMPTY = True
            MsgBox("WARNING: REQUIRED MISSING FIELD.", vbExclamation)
            sText.BackColor = Color.LemonChiffon
            sText.SetFocus()
        Else
            IS_EMPTY = False
            sText.BackColor = Color.FromArgb(240, 240, 240)
        End If
        Return IS_EMPTY
    End Function
End Module
