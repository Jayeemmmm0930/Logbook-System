Imports MySql.Data.MySqlClient

Public Class EditDepartment
    Private departmentId As Integer

    Public Sub New(departmentId As Integer)
        InitializeComponent()
        Me.departmentId = departmentId
        LoadDepartmentData()
    End Sub

    Private Sub LoadDepartmentData()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim query As String = "SELECT department FROM tbl_department WHERE id = @department_id"

            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@department_id", departmentId)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtDepartmentName.Text = reader("department").ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading department data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrWhiteSpace(txtDepartmentName.Text) Then
                MessageBox.Show("Department name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If


            Dim departmentExistsQuery As String = "SELECT COUNT(*) FROM tbl_department WHERE department = @department_name AND id <> @department_id"
            Dim departmentExists As Boolean = False

            Using cmdCheck As New MySqlCommand(departmentExistsQuery, cn)
                cmdCheck.Parameters.AddWithValue("@department_name", txtDepartmentName.Text.Trim())
                cmdCheck.Parameters.AddWithValue("@department_id", departmentId)
                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                departmentExists = (count > 0)
            End Using

            If departmentExists Then
                MessageBox.Show("Department name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' If the new department name is unique, proceed with updating the department
            Dim updateDepartmentQuery As String = "UPDATE tbl_department SET department = @department_name WHERE id = @department_id"

            Using cmd As New MySqlCommand(updateDepartmentQuery, cn)
                cmd.Parameters.AddWithValue("@department_name", txtDepartmentName.Text.Trim())
                cmd.Parameters.AddWithValue("@department_id", departmentId)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating the department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

End Class
