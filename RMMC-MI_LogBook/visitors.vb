Imports MySql.Data.MySqlClient

Public Class visitors

    Private currentPage As Integer = 1
    Private recordsPerPage As Integer = 10
    Private totalRecords As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        DisplayVisitorsData()
    End Sub

    Private Sub SetupDataGridView()
        ' Setup your DataGridView properties as needed
        metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        metroGrid1.RowHeadersVisible = False
        metroGrid1.ClearSelection()
    End Sub

    Private Sub DisplayVisitorsData(Optional ByVal searchTerm As String = "")
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            ' Count total records
            Dim countQuery As String = "SELECT COUNT(*) FROM tbl_visitors"
            Using cmdCount As New MySqlCommand(countQuery, cn)
                totalRecords = Convert.ToInt32(cmdCount.ExecuteScalar())
            End Using

            ' Calculate OFFSET based on currentPage
            Dim offset As Integer = (currentPage - 1) * recordsPerPage

            Dim query As String = "SELECT * FROM tbl_visitors"
            If _account = "Staff" Then

                query &= " WHERE designation = @department"
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " AND fullname LIKE @searchTerm"
                End If
            ElseIf Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " WHERE fullname LIKE @searchTerm"
            End If

            query &= " LIMIT @limit OFFSET @offset"

            Using cmd As New MySqlCommand(query, cn)
                If _account = "Staff" Then
                    ' Provide the department value for Staff
                    cmd.Parameters.AddWithValue("@department", _departmentName)
                End If
                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                End If
                cmd.Parameters.AddWithValue("@limit", recordsPerPage)
                cmd.Parameters.AddWithValue("@offset", offset)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    metroGrid1.DataSource = dataTable
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
        btnNext.Enabled = (currentPage < Math.Ceiling(totalRecords / recordsPerPage))
    End Sub

    Private Sub UpdatePageInfoLabel()
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)
        lblPageInfo.Text = $"Page {currentPage} of {totalPages}"
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < Math.Ceiling(totalRecords / recordsPerPage) Then
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        currentPage = 1 ' Reset to first page when search term changes
        DisplayVisitorsData(txtSearch.Text.Trim())
    End Sub
End Class
