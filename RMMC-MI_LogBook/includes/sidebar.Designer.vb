Imports FontAwesome.Sharp

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sidebar
    Inherits System.Windows.Forms.UserControl

    ' User Control overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sidebar))
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.btnVisitors = New FontAwesome.Sharp.IconButton()
        Me.btnUsers = New FontAwesome.Sharp.IconButton()
        Me.btnDepartments = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconSize = 48
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 147)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Rotation = 0R
        Me.btnDashboard.Size = New System.Drawing.Size(226, 80)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnVisitors
        '
        Me.btnVisitors.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnVisitors.FlatAppearance.BorderSize = 0
        Me.btnVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisitors.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnVisitors.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitors.ForeColor = System.Drawing.Color.White
        Me.btnVisitors.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnVisitors.IconColor = System.Drawing.Color.White
        Me.btnVisitors.IconSize = 48
        Me.btnVisitors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVisitors.Location = New System.Drawing.Point(0, 227)
        Me.btnVisitors.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVisitors.Name = "btnVisitors"
        Me.btnVisitors.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnVisitors.Rotation = 0R
        Me.btnVisitors.Size = New System.Drawing.Size(226, 80)
        Me.btnVisitors.TabIndex = 1
        Me.btnVisitors.Text = "Visitors"
        Me.btnVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVisitors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVisitors.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnUsers.IconColor = System.Drawing.Color.White
        Me.btnUsers.IconSize = 48
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 307)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUsers.Rotation = 0R
        Me.btnUsers.Size = New System.Drawing.Size(226, 80)
        Me.btnUsers.TabIndex = 2
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnDepartments
        '
        Me.btnDepartments.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDepartments.FlatAppearance.BorderSize = 0
        Me.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartments.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnDepartments.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDepartments.ForeColor = System.Drawing.Color.White
        Me.btnDepartments.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.btnDepartments.IconColor = System.Drawing.Color.White
        Me.btnDepartments.IconSize = 48
        Me.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartments.Location = New System.Drawing.Point(0, 387)
        Me.btnDepartments.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDepartments.Name = "btnDepartments"
        Me.btnDepartments.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDepartments.Rotation = 0R
        Me.btnDepartments.Size = New System.Drawing.Size(226, 80)
        Me.btnDepartments.TabIndex = 4
        Me.btnDepartments.Text = "Departments"
        Me.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDepartments.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconSize = 48
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 520)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogout.Rotation = 0R
        Me.btnLogout.Size = New System.Drawing.Size(226, 80)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
        Me.logoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(205, 144)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPictureBox.TabIndex = 5
        Me.logoPictureBox.TabStop = False
        '
        'sidebar
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.btnVisitors)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnDepartments)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Name = "sidebar"
        Me.Size = New System.Drawing.Size(205, 600)
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVisitors As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDepartments As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents logoPictureBox As PictureBox

End Class
