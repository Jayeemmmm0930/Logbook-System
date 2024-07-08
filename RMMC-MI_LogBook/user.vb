Imports MySql.Data.MySqlClient

Partial Class user
    Inherits UserControl

    Private currentPage As Integer = 1
    Private recordsPerPage As Integer = 10
    Private totalRecords As Integer = 0

    Public Sub New()
        InitializeComponent()
        DisplayVisitorsData()
    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        metroGrid1.RowHeadersVisible = False

        metroGrid1.ClearSelection()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addForm As New AddForm()
        addForm.StartPosition = FormStartPosition.CenterScreen

        If addForm.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("New user added successfully!")
            DisplayVisitorsData()
        End If

        addForm.Dispose()
    End Sub

    Private Sub DisplayVisitorsData(Optional ByVal searchTerm As String = "")
        Try

            cn.Open()

            Using cmd As New MySqlCommand()
                cmd.Connection = cn

                Dim offset As Integer = (currentPage - 1) * recordsPerPage

                ' Build SQL query with LIMIT and OFFSET
                Dim query As String = "SELECT u.id AS ID, u.firstname AS FirstName, u.middleinitial AS MiddleInitial, " &
                                          "u.lastname AS LastName, u.acounttype AS AccountType, " &
                                          "d.department AS DepartmentName " &
                                          "FROM tbl_user u " &
                                          "INNER JOIN tbl_department d ON u.fk_department = d.id"
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " WHERE u.firstname LIKE @searchTerm OR u.lastname LIKE @searchTerm " &
                             "OR u.acounttype LIKE @searchTerm OR d.department LIKE @searchTerm"
                    cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                End If
                query &= " LIMIT @limit OFFSET @offset"
                cmd.CommandText = query
                cmd.Parameters.AddWithValue("@limit", recordsPerPage)
                cmd.Parameters.AddWithValue("@offset", offset)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    metroGrid1.DataSource = dataTable

                    metroGrid1.Columns("ID").HeaderText = "ID"
                    metroGrid1.Columns("FirstName").HeaderText = "First Name"
                    metroGrid1.Columns("MiddleInitial").HeaderText = "Middle Initial"
                    metroGrid1.Columns("LastName").HeaderText = "Last Name"
                    metroGrid1.Columns("AccountType").HeaderText = "Account Type"
                    metroGrid1.Columns("DepartmentName").HeaderText = "Department"
                End Using
            End Using


            UpdateNavigationButtons()
            UpdatePageInfoLabel()

        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateNavigationButtons()
        btnPrevious.Enabled = (currentPage > 1)
        btnNext.Enabled = (currentPage * recordsPerPage < totalRecords)
    End Sub

    Private Sub UpdatePageInfoLabel()
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)
        lblPageInfo.Text = $"Page {currentPage} of {totalPages}"
    End Sub

    Private Sub metroGrid1_SelectionChanged(sender As Object, e As EventArgs) Handles metroGrid1.SelectionChanged
        If metroGrid1.SelectedRows.Count > 0 Then
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        Else
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If metroGrid1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = metroGrid1.SelectedRows(0)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

            Dim editForm As New EditForm(userId)
            editForm.StartPosition = FormStartPosition.CenterScreen

            If editForm.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("User updated successfully!")
                DisplayVisitorsData()
            End If
        Else
            MessageBox.Show("Please select a user to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If metroGrid1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = metroGrid1.SelectedRows(0)
            Dim userId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                Try

                    cn.Open()

                    Using cmdDeleteUser As New MySqlCommand()
                        cmdDeleteUser.Connection = cn
                        cmdDeleteUser.CommandText = "DELETE FROM tbl_user WHERE id = @id"
                        cmdDeleteUser.Parameters.AddWithValue("@id", userId)

                        Using cmdDeleteLogin As New MySqlCommand()
                            cmdDeleteLogin.Connection = cn
                            cmdDeleteLogin.CommandText = "DELETE FROM tbl_user_login WHERE id = (SELECT fk_user_login FROM tbl_user WHERE id = @id)"
                            cmdDeleteLogin.Parameters.AddWithValue("@id", userId)

                            cmdDeleteLogin.ExecuteNonQuery()
                            Dim rowsAffected As Integer = cmdDeleteUser.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                MessageBox.Show("User deleted successfully!")
                                DisplayVisitorsData()
                            Else
                                MessageBox.Show("Failed to delete user.")
                            End If
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        currentPage = 1 ' Reset to first page when search term changes
        DisplayVisitorsData(txtSearch.Text.Trim())
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage * recordsPerPage < totalRecords Then
            currentPage += 1
            DisplayVisitorsData(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            DisplayVisitorsData(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub lblPageInfo_Click(sender As Object, e As EventArgs) Handles lblPageInfo.Click
        ' Optional: Add any additional logic for when the page info label is clicked
    End Sub
End Class
