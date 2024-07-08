

Public Class footer

    Public Sub New()
        InitializeComponent()

        MetroLabel1.Text = _name
        MetroLabel2.Text = _account
        MetroLabel3.Text = _departmentName
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

    End Sub

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub
End Class
