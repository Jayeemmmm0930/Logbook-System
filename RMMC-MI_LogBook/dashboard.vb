Imports MySql.Data.MySqlClient

Public Class dashboard


    Public Sub New()
        InitializeComponent()
        CountVisitors()
            CountDepartments()
            CountUsers()

    End Sub

    Private Sub CountVisitors()
        Try


            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_visitors", cn)
                Dim totalVisitors As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                MetroLabel3.Text = totalVisitors.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error counting visitors: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub



    Private Sub CountDepartments()
        Try


            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_department", cn)
                Dim totalDepartments As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                MetroLabel2.Text = totalDepartments.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error counting departments: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub CountUsers()
        Try


            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_user", cn)
                Dim totalUsers As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                MetroLabel1.Text = totalUsers.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error counting users: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

End Class
