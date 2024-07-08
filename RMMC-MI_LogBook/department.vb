Imports MySql.Data.MySqlClient

Public Class department
    Private currentPage As Integer = 1
    Private Const pageSize As Integer = 10 ' Number of records per page

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayVisitorsData()
    End Sub

    Private Sub DisplayVisitorsData(Optional ByVal searchTerm As String = "")
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim query As String = $"SELECT id, department FROM tbl_department LIMIT {pageSize} OFFSET {(currentPage - 1) * pageSize}"

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query = $"SELECT id, department FROM tbl_department WHERE department LIKE @searchTerm LIMIT {pageSize} OFFSET {(currentPage - 1) * pageSize}"
            End If

            Using cmd As New MySqlCommand(query, cn)
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%")
                End If

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    metroGrid1.DataSource = dataTable

                    metroGrid1.Columns("id").HeaderText = "ID"
                    metroGrid1.Columns("department").HeaderText = "Department Name"
                End Using
            End Using

            UpdatePaginationButtons()

        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub UpdatePaginationButtons()
        ' Enable/disable previous button
        btnPrevious.Enabled = currentPage > 1

        ' Check if there are more records to show
        Dim moreRecordsExist As Boolean = CheckIfMoreRecordsExist()
        btnNext.Enabled = moreRecordsExist

        ' Update page info label
        Dim pageInfo As String = $"Page {currentPage} of {(If(moreRecordsExist, GetTotalPages(), currentPage))}"
        lblPageInfo.Text = pageInfo
    End Sub

    Private Function CheckIfMoreRecordsExist() As Boolean
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim countQuery As String = "SELECT COUNT(*) FROM tbl_department"
            Using cmd As New MySqlCommand(countQuery, cn)
                Dim totalRecords As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return totalRecords > currentPage * pageSize
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error checking if more records exist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Private Function GetTotalPages() As Integer
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            Dim countQuery As String = "SELECT CEIL(COUNT(*) / @pageSize) FROM tbl_department"
            Using cmd As New MySqlCommand(countQuery, cn)
                cmd.Parameters.AddWithValue("@pageSize", pageSize)
                Dim totalPages As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return totalPages
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error calculating total pages: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 1 ' Default to 1 page
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentPage += 1
        DisplayVisitorsData()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            DisplayVisitorsData()
        End If
    End Sub

    Private Sub lblPageInfo_Click(sender As Object, e As EventArgs) Handles lblPageInfo.Click
        ' This event handler can be used for additional functionality related to page info label if needed
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        currentPage = 1 ' Reset to first page when searching
        DisplayVisitorsData(txtSearch.Text.Trim())
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addDepartment As New AddDepartment()
        addDepartment.StartPosition = FormStartPosition.CenterScreen

        If addDepartment.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("New Department added successfully!")
            DisplayVisitorsData()
        End If

        addDepartment.Dispose()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If metroGrid1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = metroGrid1.SelectedRows(0)
            Dim departmentId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)

            Dim editDepartmentForm As New EditDepartment(departmentId)
            editDepartmentForm.StartPosition = FormStartPosition.CenterScreen

            If editDepartmentForm.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DisplayVisitorsData()
            End If
        Else
            MessageBox.Show("Please select a department to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If metroGrid1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = metroGrid1.SelectedRows(0)
            Dim departmentId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                Try
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    Dim deleteQuery As String = "DELETE FROM tbl_department WHERE id = @department_id"

                    Using cmd As New MySqlCommand(deleteQuery, cn)
                        cmd.Parameters.AddWithValue("@department_id", departmentId)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DisplayVisitorsData()

                Catch ex As Exception
                    MessageBox.Show($"An error occurred while deleting the department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select a department to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
