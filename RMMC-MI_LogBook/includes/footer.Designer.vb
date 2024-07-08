Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class footer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblAccountName = New MetroFramework.Controls.MetroLabel()
        Me.lblUserType = New MetroFramework.Controls.MetroLabel()
        Me.lblOffice = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblAccountName.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblAccountName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblAccountName.Location = New System.Drawing.Point(14, 28)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(148, 25)
        Me.lblAccountName.TabIndex = 0
        Me.lblAccountName.Text = "Account Name:"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblUserType.Location = New System.Drawing.Point(494, 36)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(76, 20)
        Me.lblUserType.TabIndex = 1
        Me.lblUserType.Text = "User Type:"
        '
        'lblOffice
        '
        Me.lblOffice.AutoSize = True
        Me.lblOffice.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblOffice.Location = New System.Drawing.Point(816, 39)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(52, 20)
        Me.lblOffice.TabIndex = 2
        Me.lblOffice.Text = "Office:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.MetroLabel1.Location = New System.Drawing.Point(192, 28)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(148, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Account Name:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(579, 36)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(76, 20)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "User Type:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(879, 39)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(52, 20)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Office:"
        '
        'footer
        '
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lblOffice)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.lblAccountName)
        Me.Name = "footer"
        Me.Size = New System.Drawing.Size(1163, 86)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAccountName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUserType As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOffice As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel

End Class
