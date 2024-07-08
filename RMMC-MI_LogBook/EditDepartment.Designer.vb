<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDepartment
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.lblDepartmentName = New MetroFramework.Controls.MetroLabel()
        Me.txtDepartmentName = New MetroFramework.Controls.MetroTextBox()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'lblDepartmentName
        '
        Me.lblDepartmentName.AutoSize = True
        Me.lblDepartmentName.Location = New System.Drawing.Point(31, 74)
        Me.lblDepartmentName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartmentName.Name = "lblDepartmentName"
        Me.lblDepartmentName.Size = New System.Drawing.Size(129, 20)
        Me.lblDepartmentName.TabIndex = 0
        Me.lblDepartmentName.Text = "Department Name:"
        '
        'txtDepartmentName
        '
        '
        '
        '
        Me.txtDepartmentName.CustomButton.Image = Nothing
        Me.txtDepartmentName.CustomButton.Location = New System.Drawing.Point(255, 2)
        Me.txtDepartmentName.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepartmentName.CustomButton.Name = ""
        Me.txtDepartmentName.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtDepartmentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDepartmentName.CustomButton.TabIndex = 1
        Me.txtDepartmentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDepartmentName.CustomButton.UseSelectable = True
        Me.txtDepartmentName.CustomButton.Visible = False
        Me.txtDepartmentName.Lines = New String(-1) {}
        Me.txtDepartmentName.Location = New System.Drawing.Point(195, 74)
        Me.txtDepartmentName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepartmentName.MaxLength = 32767
        Me.txtDepartmentName.Name = "txtDepartmentName"
        Me.txtDepartmentName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepartmentName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDepartmentName.SelectedText = ""
        Me.txtDepartmentName.SelectionLength = 0
        Me.txtDepartmentName.SelectionStart = 0
        Me.txtDepartmentName.ShortcutsEnabled = True
        Me.txtDepartmentName.Size = New System.Drawing.Size(281, 28)
        Me.txtDepartmentName.TabIndex = 1
        Me.txtDepartmentName.UseSelectable = True
        Me.txtDepartmentName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDepartmentName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(376, 123)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseSelectable = True
        '
        'EditDepartment
        '
        Me.ClientSize = New System.Drawing.Size(507, 185)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtDepartmentName)
        Me.Controls.Add(Me.lblDepartmentName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EditDepartment"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Edit Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDepartmentName As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDepartmentName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
End Class
