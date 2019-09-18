<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_System
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(128, 115)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(183, 31)
        Me.txt_username.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(128, 159)
        Me.txt_password.Multiline = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(183, 31)
        Me.txt_password.TabIndex = 3
        '
        'LoginBTN
        '
        Me.LoginBTN.Location = New System.Drawing.Point(317, 159)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(97, 31)
        Me.LoginBTN.TabIndex = 4
        Me.LoginBTN.Text = "login"
        Me.LoginBTN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 89)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Khan's Grill Hut Login System"
        '
        'Login_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(425, 269)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LoginBTN)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_username)
        Me.Name = "Login_System"
        Me.Text = "Login System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents LoginBTN As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
