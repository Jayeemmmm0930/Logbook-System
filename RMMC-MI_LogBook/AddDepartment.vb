
Imports MySql.Data.MySqlClient

Public Class AddDepartment

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If String.IsNullOrWhiteSpace(txtDepartmentName.Text) Then
                MessageBox.Show("Department name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim departmentExistsQuery As String = "SELECT COUNT(*) FROM tbl_department WHERE department = @department_name"
            Dim departmentExists As Boolean = False

            Using cmdCheck As New MySqlCommand(departmentExistsQuery, cn)
                cmdCheck.Parameters.AddWithValue("@department_name", txtDepartmentName.Text.Trim())
                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                departmentExists = (count > 0)
            End Using

            If departmentExists Then
                MessageBox.Show("Department name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim insertDepartmentQuery As String = "INSERT INTO tbl_department (department) VALUES (@department_name)"

            Using cmd As New MySqlCommand(insertDepartmentQuery, cn)
                cmd.Parameters.AddWithValue("@department_name", txtDepartmentName.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Department added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As Exception
            MessageBox.Show($"An error occurred while adding department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ClearFields()
        txtDepartmentName.Text = String.Empty
    End Sub
End Class