<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainCashier))
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_report = New System.Windows.Forms.Button()
        Me.btn_manageUser = New System.Windows.Forms.Button()
        Me.btn_manageCheckin = New System.Windows.Forms.Button()
        Me.btn_manageRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(895, 353)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(116, 87)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(633, 259)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Management System"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1423, 94)
        Me.Panel1.TabIndex = 2
        '
        'Btn_report
        '
        Me.Btn_report.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_report.Enabled = False
        Me.Btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_report.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_report.ForeColor = System.Drawing.Color.White
        Me.Btn_report.Location = New System.Drawing.Point(782, 353)
        Me.Btn_report.Name = "Btn_report"
        Me.Btn_report.Size = New System.Drawing.Size(116, 87)
        Me.Btn_report.TabIndex = 4
        Me.Btn_report.Text = "Record"
        Me.Btn_report.UseVisualStyleBackColor = False
        '
        'btn_manageUser
        '
        Me.btn_manageUser.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageUser.Enabled = False
        Me.btn_manageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageUser.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageUser.ForeColor = System.Drawing.Color.White
        Me.btn_manageUser.Location = New System.Drawing.Point(669, 353)
        Me.btn_manageUser.Name = "btn_manageUser"
        Me.btn_manageUser.Size = New System.Drawing.Size(116, 87)
        Me.btn_manageUser.TabIndex = 3
        Me.btn_manageUser.Text = "User"
        Me.btn_manageUser.UseVisualStyleBackColor = False
        '
        'btn_manageCheckin
        '
        Me.btn_manageCheckin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageCheckin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageCheckin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageCheckin.ForeColor = System.Drawing.Color.White
        Me.btn_manageCheckin.Location = New System.Drawing.Point(556, 353)
        Me.btn_manageCheckin.Name = "btn_manageCheckin"
        Me.btn_manageCheckin.Size = New System.Drawing.Size(116, 87)
        Me.btn_manageCheckin.TabIndex = 3
        Me.btn_manageCheckin.Text = "Check-in"
        Me.btn_manageCheckin.UseVisualStyleBackColor = False
        '
        'btn_manageRegister
        '
        Me.btn_manageRegister.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_manageRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageRegister.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageRegister.ForeColor = System.Drawing.Color.White
        Me.btn_manageRegister.Location = New System.Drawing.Point(445, 353)
        Me.btn_manageRegister.Name = "btn_manageRegister"
        Me.btn_manageRegister.Size = New System.Drawing.Size(116, 87)
        Me.btn_manageRegister.TabIndex = 3
        Me.btn_manageRegister.Text = "Register"
        Me.btn_manageRegister.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(627, 194)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "H o t e l"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btn_logout)
        Me.Panel3.Controls.Add(Me.btn_manageRegister)
        Me.Panel3.Controls.Add(Me.Btn_report)
        Me.Panel3.Controls.Add(Me.btn_manageCheckin)
        Me.Panel3.Controls.Add(Me.btn_manageUser)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1366, 768)
        Me.Panel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(595, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 47)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pro-Luxe Hotel"
        '
        'frm_mainCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_mainCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel and Inventory Management System"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_report As Button
    Friend WithEvents btn_manageUser As Button
    Friend WithEvents btn_manageCheckin As Button
    Friend WithEvents btn_manageRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
End Class
