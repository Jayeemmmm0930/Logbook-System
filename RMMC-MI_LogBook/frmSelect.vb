
Imports MySql.Data.MySqlClient

Public Class frmSelect

    Private Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateDesignations()
    End Sub

    Private Function FetchDepartmentNameFromDatabase(department As String) As String
        Dim departmentName As String = ""
        Try
            cn.Open()
            Using cmd As New MySqlCommand("SELECT department FROM tbl_department WHERE department = @department", cn)
                cmd.Parameters.AddWithValue("@department", department)
                departmentName = Convert.ToString(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, $"Error fetching department name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        Return departmentName
    End Function

    Private Sub PopulateDesignations()

        cmbDesignation.Items.Clear()

        Try

            Dim query As String = "SELECT department FROM tbl_department"


            Using cmd As New MySqlCommand(query, cn)
                cn.Open()

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()

                        cmbDesignation.Items.Add(dr("department").ToString())
                    End While
                End Using
            End Using

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, $"Error loading designations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim purpose As String = txtPurpose.Text.Trim()
        Dim contactNo As String = txtContactNo.Text.Trim()
        Dim designation As String = cmbDesignation.Text.Trim()
        Dim currentDate As Date = Date.Today
        Dim formattedDate As String = currentDate.ToString("MM/dd/yyyy")
        Dim remarks As String = "Ongoing"
        Dim timeInFormatted As String = Date.Now.ToString("hh:mm tt") ' Format time as 12-hour with AM/PM

        ' Check for empty fields
        If String.IsNullOrWhiteSpace(fullName) OrElse
       String.IsNullOrWhiteSpace(address) OrElse
       String.IsNullOrWhiteSpace(purpose) OrElse
       String.IsNullOrWhiteSpace(contactNo) OrElse
       String.IsNullOrWhiteSpace(designation) Then

            MetroFramework.MetroMessageBox.Show(Me, "All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try


            _departmentName = FetchDepartmentNameFromDatabase(designation)


            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If


            Dim query As String = "INSERT INTO tbl_visitors (fullname, address, purpose, contactnumber, designation, date, time_in, remarks) " &
                              "VALUES (@FullName, @Address, @Purpose, @ContactNo, @Designation, @Date, @TimeIn, @Remarks)"

            Using cm As New MySqlCommand(query, cn)

                cm.Parameters.AddWithValue("@FullName", fullName)
                cm.Parameters.AddWithValue("@Address", address)
                cm.Parameters.AddWithValue("@Purpose", purpose)
                cm.Parameters.AddWithValue("@ContactNo", contactNo)
                cm.Parameters.AddWithValue("@Designation", designation)

                cm.Parameters.AddWithValue("@Date", formattedDate)
                cm.Parameters.AddWithValue("@TimeIn", timeInFormatted)
                cm.Parameters.AddWithValue("@Remarks", remarks)


                Dim rowsAffected As Integer = cm.ExecuteNonQuery()


                MetroFramework.MetroMessageBox.Show(Me, $"{rowsAffected} record(s) saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                frmStaff.HandleVisitorEntered(fullName, address, purpose, designation)


                ClearFields()
            End Using
        Catch ex As Exception

            MetroFramework.MetroMessageBox.Show(Me, $"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub










    Private Sub ClearFields()

        txtFullName.Text = ""
        txtAddress.Text = ""
        txtPurpose.Text = ""
        txtContactNo.Text = ""
        cmbDesignation.SelectedIndex = -1 ' Clear combo box selection
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        Try
            Dim timeInFormatted As String = Date.Now.ToString("hh:mm tt") ' Format time as 12-hour with AM/PM
            Dim fullName As String = txtFullName.Text.Trim()
            Dim queryCheck As String = "SELECT * FROM tbl_visitors WHERE fullname = @FullName AND time_out IS NULL"


            cn.Open()

                ' Start transaction for atomic operation
                Using transaction As MySqlTransaction = cn.BeginTransaction()
                    Try
                        Using cmdCheck As New MySqlCommand(queryCheck, cn, transaction)
                            cmdCheck.Parameters.AddWithValue("@FullName", fullName)

                            Dim visitorReader As MySqlDataReader = cmdCheck.ExecuteReader()
                            If visitorReader.Read() Then
                                visitorReader.Close()

                                Dim updateQuery As String = "UPDATE tbl_visitors SET time_out = @TimeOut WHERE fullname = @FullName AND time_out IS NULL"

                                Using cmdUpdate As New MySqlCommand(updateQuery, cn, transaction)
                                    cmdUpdate.Parameters.AddWithValue("@FullName", fullName)
                                cmdUpdate.Parameters.AddWithValue("@TimeOut", timeInFormatted)

                                Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                                    If rowsAffected > 0 Then
                                        transaction.Commit() ' Commit transaction if update is successful
                                        MetroFramework.MetroMessageBox.Show(Me, $"Time out recorded for {fullName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Else
                                        transaction.Rollback() ' Rollback transaction if no rows were affected (optional)
                                        MetroFramework.MetroMessageBox.Show(Me, $"No active record found for {fullName} to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                End Using
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, $"No record found for {fullName} or visitor has already checked out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    Catch ex As Exception
                        transaction.Rollback() ' Rollback transaction on error
                        Throw ' Re-throw exception to be caught by the outer exception handler
                    End Try
                End Using


        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, $"Error updating time out: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub





End Class
