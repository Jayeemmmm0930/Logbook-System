<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatabasesetup
    Inherits MetroFramework.Forms.MetroForm

    ' Required designer variable.
    Private components As System.ComponentModel.IContainer

    ' Clean up any resources being used.
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

    ' Required method for Designer support - do not modify
    ' the contents of this method with the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnTestConnection = New MetroFramework.Controls.MetroButton()
        Me.btnConnect = New MetroFramework.Controls.MetroButton()
        Me.txtServer = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtDatabase = New MetroFramework.Controls.MetroTextBox()
        Me.lblServer = New MetroFramework.Controls.MetroLabel()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.lblPassword = New MetroFramework.Controls.MetroLabel()
        Me.lblDatabase = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Location = New System.Drawing.Point(31, 291)
        Me.btnTestConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(160, 49)
        Me.btnTestConnection.TabIndex = 0
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseSelectable = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(218, 291)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(160, 49)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseSelectable = True
        '
        'txtServer
        '
        '
        '
        '
        Me.txtServer.CustomButton.Image = Nothing
        Me.txtServer.CustomButton.Location = New System.Drawing.Point(321, 2)
        Me.txtServer.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.CustomButton.Name = ""
        Me.txtServer.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtServer.CustomButton.TabIndex = 1
        Me.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtServer.CustomButton.UseSelectable = True
        Me.txtServer.CustomButton.Visible = False
        Me.txtServer.Lines = New String(-1) {}
        Me.txtServer.Location = New System.Drawing.Point(31, 92)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.MaxLength = 32767
        Me.txtServer.Name = "txtServer"
        Me.txtServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtServer.SelectedText = ""
        Me.txtServer.SelectionLength = 0
        Me.txtServer.SelectionStart = 0
        Me.txtServer.ShortcutsEnabled = True
        Me.txtServer.Size = New System.Drawing.Size(347, 28)
        Me.txtServer.TabIndex = 2
        Me.txtServer.UseSelectable = True
        Me.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtServer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(321, 2)
        Me.txtUsername.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(31, 146)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(347, 28)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(321, 2)
        Me.txtPassword.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(31, 200)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(347, 28)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDatabase
        '
        '
        '
        '
        Me.txtDatabase.CustomButton.Image = Nothing
        Me.txtDatabase.CustomButton.Location = New System.Drawing.Point(321, 2)
        Me.txtDatabase.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDatabase.CustomButton.Name = ""
        Me.txtDatabase.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDatabase.CustomButton.TabIndex = 1
        Me.txtDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDatabase.CustomButton.UseSelectable = True
        Me.txtDatabase.CustomButton.Visible = False
        Me.txtDatabase.Lines = New String(-1) {}
        Me.txtDatabase.Location = New System.Drawing.Point(31, 255)
        Me.txtDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDatabase.MaxLength = 32767
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDatabase.SelectedText = ""
        Me.txtDatabase.SelectionLength = 0
        Me.txtDatabase.SelectionStart = 0
        Me.txtDatabase.ShortcutsEnabled = True
        Me.txtDatabase.Size = New System.Drawing.Size(347, 28)
        Me.txtDatabase.TabIndex = 5
        Me.txtDatabase.UseSelectable = True
        Me.txtDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDatabase.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(31, 70)
        Me.lblServer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(50, 20)
        Me.lblServer.TabIndex = 6
        Me.lblServer.Text = "Server"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(31, 123)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 20)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(31, 177)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(66, 20)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password"
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(31, 232)
        Me.lblDatabase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(66, 20)
        Me.lblDatabase.TabIndex = 9
        Me.lblDatabase.Text = "Database"
        '
        'frmDatabasesetup
        '
        Me.ClientSize = New System.Drawing.Size(408, 373)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDatabasesetup"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Database Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTestConnection As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConnect As MetroFramework.Controls.MetroButton
    Friend WithEvents txtServer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDatabase As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblServer As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPassword As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDatabase As MetroFramework.Controls.MetroLabel
End Class
