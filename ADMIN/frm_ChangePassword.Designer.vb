<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePassword
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
        Me.txt_oldpassword = New System.Windows.Forms.TextBox()
        Me.txt_newpassword = New System.Windows.Forms.TextBox()
        Me.txt_reenterPassword = New System.Windows.Forms.TextBox()
        Me.btn_ChangePass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_oldpassword
        '
        Me.txt_oldpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oldpassword.Location = New System.Drawing.Point(41, 54)
        Me.txt_oldpassword.Name = "txt_oldpassword"
        Me.txt_oldpassword.Size = New System.Drawing.Size(242, 25)
        Me.txt_oldpassword.TabIndex = 0
        Me.txt_oldpassword.UseSystemPasswordChar = True
        '
        'txt_newpassword
        '
        Me.txt_newpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newpassword.Location = New System.Drawing.Point(41, 103)
        Me.txt_newpassword.Name = "txt_newpassword"
        Me.txt_newpassword.Size = New System.Drawing.Size(242, 25)
        Me.txt_newpassword.TabIndex = 1
        Me.txt_newpassword.UseSystemPasswordChar = True
        '
        'txt_reenterPassword
        '
        Me.txt_reenterPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reenterPassword.Location = New System.Drawing.Point(41, 157)
        Me.txt_reenterPassword.Name = "txt_reenterPassword"
        Me.txt_reenterPassword.Size = New System.Drawing.Size(242, 25)
        Me.txt_reenterPassword.TabIndex = 2
        Me.txt_reenterPassword.UseSystemPasswordChar = True
        '
        'btn_ChangePass
        '
        Me.btn_ChangePass.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_ChangePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ChangePass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ChangePass.ForeColor = System.Drawing.Color.White
        Me.btn_ChangePass.Location = New System.Drawing.Point(41, 200)
        Me.btn_ChangePass.Name = "btn_ChangePass"
        Me.btn_ChangePass.Size = New System.Drawing.Size(242, 32)
        Me.btn_ChangePass.TabIndex = 3
        Me.btn_ChangePass.Text = "Change Password"
        Me.btn_ChangePass.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Your Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Your New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Re-Enter Your New Password"
        '
        'frm_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(324, 269)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ChangePass)
        Me.Controls.Add(Me.txt_reenterPassword)
        Me.Controls.Add(Me.txt_newpassword)
        Me.Controls.Add(Me.txt_oldpassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_oldpassword As TextBox
    Friend WithEvents txt_newpassword As TextBox
    Friend WithEvents txt_reenterPassword As TextBox
    Friend WithEvents btn_ChangePass As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
