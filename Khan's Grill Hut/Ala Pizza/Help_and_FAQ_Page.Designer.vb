<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help_and_FAQ_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help_and_FAQ_Page))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Return To Till"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(37, 66)
        Me.txt_username.Multiline = True
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(616, 349)
        Me.txt_username.TabIndex = 1
        Me.txt_username.Text = resources.GetString("txt_username.Text")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit Program"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Help and FAQ Page"
        '
        'Help_and_FAQ_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 476)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Help_and_FAQ_Page"
        Me.Text = "Help_and_FAQ_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
