<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manageChecked_in
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_customer_choice = New System.Windows.Forms.ComboBox()
        Me.dtp_date_out = New System.Windows.Forms.DateTimePicker()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.cbo_room_rate = New System.Windows.Forms.ComboBox()
        Me.cbo_room_status = New System.Windows.Forms.ComboBox()
        Me.cbo_room_type = New System.Windows.Forms.ComboBox()
        Me.cbo_room_no = New System.Windows.Forms.ComboBox()
        Me.cbo_payment_status = New System.Windows.Forms.ComboBox()
        Me.txt_checked_out_time = New System.Windows.Forms.TextBox()
        Me.txt_checked_in_time = New System.Windows.Forms.TextBox()
        Me.dtp_date_in = New System.Windows.Forms.DateTimePicker()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_contacno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_payment_method = New System.Windows.Forms.ComboBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cbo_customer_choice)
        Me.GroupBox1.Controls.Add(Me.dtp_date_out)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.cbo_room_rate)
        Me.GroupBox1.Controls.Add(Me.cbo_room_status)
        Me.GroupBox1.Controls.Add(Me.cbo_room_type)
        Me.GroupBox1.Controls.Add(Me.cbo_room_no)
        Me.GroupBox1.Controls.Add(Me.cbo_payment_status)
        Me.GroupBox1.Controls.Add(Me.txt_checked_out_time)
        Me.GroupBox1.Controls.Add(Me.txt_checked_in_time)
        Me.GroupBox1.Controls.Add(Me.dtp_date_in)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.txt_contacno)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_payment_method)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 519)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'cbo_customer_choice
        '
        Me.cbo_customer_choice.Enabled = False
        Me.cbo_customer_choice.FormattingEnabled = True
        Me.cbo_customer_choice.Items.AddRange(New Object() {"Checked In", "Reserve"})
        Me.cbo_customer_choice.Location = New System.Drawing.Point(147, 243)
        Me.cbo_customer_choice.Name = "cbo_customer_choice"
        Me.cbo_customer_choice.Size = New System.Drawing.Size(236, 25)
        Me.cbo_customer_choice.TabIndex = 15
        '
        'dtp_date_out
        '
        Me.dtp_date_out.Enabled = False
        Me.dtp_date_out.Location = New System.Drawing.Point(147, 208)
        Me.dtp_date_out.Name = "dtp_date_out"
        Me.dtp_date_out.Size = New System.Drawing.Size(236, 25)
        Me.dtp_date_out.TabIndex = 14
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(269, 475)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(114, 33)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(149, 475)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(114, 33)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'cbo_room_rate
        '
        Me.cbo_room_rate.Enabled = False
        Me.cbo_room_rate.FormattingEnabled = True
        Me.cbo_room_rate.Items.AddRange(New Object() {"250", "550", "750"})
        Me.cbo_room_rate.Location = New System.Drawing.Point(147, 367)
        Me.cbo_room_rate.Name = "cbo_room_rate"
        Me.cbo_room_rate.Size = New System.Drawing.Size(236, 25)
        Me.cbo_room_rate.TabIndex = 12
        '
        'cbo_room_status
        '
        Me.cbo_room_status.Enabled = False
        Me.cbo_room_status.FormattingEnabled = True
        Me.cbo_room_status.Items.AddRange(New Object() {"Occupied", "Available", "Reserve"})
        Me.cbo_room_status.Location = New System.Drawing.Point(147, 337)
        Me.cbo_room_status.Name = "cbo_room_status"
        Me.cbo_room_status.Size = New System.Drawing.Size(236, 25)
        Me.cbo_room_status.TabIndex = 12
        '
        'cbo_room_type
        '
        Me.cbo_room_type.Enabled = False
        Me.cbo_room_type.FormattingEnabled = True
        Me.cbo_room_type.Items.AddRange(New Object() {"Single", "Double", "Family"})
        Me.cbo_room_type.Location = New System.Drawing.Point(147, 306)
        Me.cbo_room_type.Name = "cbo_room_type"
        Me.cbo_room_type.Size = New System.Drawing.Size(236, 25)
        Me.cbo_room_type.TabIndex = 11
        '
        'cbo_room_no
        '
        Me.cbo_room_no.Enabled = False
        Me.cbo_room_no.FormattingEnabled = True
        Me.cbo_room_no.Items.AddRange(New Object() {"100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110"})
        Me.cbo_room_no.Location = New System.Drawing.Point(147, 275)
        Me.cbo_room_no.Name = "cbo_room_no"
        Me.cbo_room_no.Size = New System.Drawing.Size(236, 25)
        Me.cbo_room_no.TabIndex = 10
        '
        'cbo_payment_status
        '
        Me.cbo_payment_status.Enabled = False
        Me.cbo_payment_status.FormattingEnabled = True
        Me.cbo_payment_status.Items.AddRange(New Object() {"Fully Paid", "Under Paid"})
        Me.cbo_payment_status.Location = New System.Drawing.Point(147, 429)
        Me.cbo_payment_status.Name = "cbo_payment_status"
        Me.cbo_payment_status.Size = New System.Drawing.Size(236, 25)
        Me.cbo_payment_status.TabIndex = 9
        '
        'txt_checked_out_time
        '
        Me.txt_checked_out_time.Enabled = False
        Me.txt_checked_out_time.Location = New System.Drawing.Point(147, 177)
        Me.txt_checked_out_time.Name = "txt_checked_out_time"
        Me.txt_checked_out_time.Size = New System.Drawing.Size(236, 25)
        Me.txt_checked_out_time.TabIndex = 8
        '
        'txt_checked_in_time
        '
        Me.txt_checked_in_time.Enabled = False
        Me.txt_checked_in_time.Location = New System.Drawing.Point(147, 146)
        Me.txt_checked_in_time.Name = "txt_checked_in_time"
        Me.txt_checked_in_time.Size = New System.Drawing.Size(236, 25)
        Me.txt_checked_in_time.TabIndex = 7
        '
        'dtp_date_in
        '
        Me.dtp_date_in.Enabled = False
        Me.dtp_date_in.Location = New System.Drawing.Point(147, 115)
        Me.dtp_date_in.Name = "dtp_date_in"
        Me.dtp_date_in.Size = New System.Drawing.Size(236, 25)
        Me.dtp_date_in.TabIndex = 6
        Me.dtp_date_in.Value = New Date(2022, 11, 30, 9, 18, 4, 0)
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(6, 25)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(20, 17)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "ID"
        '
        'txt_contacno
        '
        Me.txt_contacno.Location = New System.Drawing.Point(147, 84)
        Me.txt_contacno.Name = "txt_contacno"
        Me.txt_contacno.Size = New System.Drawing.Size(236, 25)
        Me.txt_contacno.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 429)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Payment Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Payment Method"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(48, 370)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Room Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(47, 340)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Room Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Room Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(47, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Room no."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Checked Out Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Checked in Time"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Customer Choice"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Date Out"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date in"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'cbo_payment_method
        '
        Me.cbo_payment_method.Enabled = False
        Me.cbo_payment_method.FormattingEnabled = True
        Me.cbo_payment_method.Items.AddRange(New Object() {"Cash", "Online", "Debit/Credit"})
        Me.cbo_payment_method.Location = New System.Drawing.Point(147, 398)
        Me.cbo_payment_method.Name = "cbo_payment_method"
        Me.cbo_payment_method.Size = New System.Drawing.Size(236, 25)
        Me.cbo_payment_method.TabIndex = 2
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(147, 53)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(236, 25)
        Me.txt_address.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(147, 22)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(236, 25)
        Me.txt_name.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(428, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 401)
        Me.Panel1.TabIndex = 2
        '
        'frm_manageChecked_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 721)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_manageChecked_in"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_manageChecked_in"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_customer_choice As ComboBox
    Friend WithEvents dtp_date_out As DateTimePicker
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents cbo_room_rate As ComboBox
    Friend WithEvents cbo_room_status As ComboBox
    Friend WithEvents cbo_room_type As ComboBox
    Friend WithEvents cbo_room_no As ComboBox
    Friend WithEvents cbo_payment_status As ComboBox
    Friend WithEvents txt_checked_out_time As TextBox
    Friend WithEvents txt_checked_in_time As TextBox
    Friend WithEvents dtp_date_in As DateTimePicker
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_contacno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_payment_method As ComboBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Panel1 As Panel
End Class
