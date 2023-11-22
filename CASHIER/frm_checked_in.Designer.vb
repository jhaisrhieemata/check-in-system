<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_checked_in
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
        Me.cbo_roomrate = New System.Windows.Forms.ComboBox()
        Me.txt_checked_in_no = New System.Windows.Forms.TextBox()
        Me.cbo_room_number = New System.Windows.Forms.ComboBox()
        Me.dtp_date_departure = New System.Windows.Forms.DateTimePicker()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.cbo_status = New System.Windows.Forms.ComboBox()
        Me.dtp_date_arrived = New System.Windows.Forms.DateTimePicker()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_payment_method = New System.Windows.Forms.ComboBox()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lv_checked_in = New System.Windows.Forms.ListView()
        Me.checkedeinNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.customername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.datearrived = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.datedeparture = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.roomno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.paymethod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.roomrate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_payment = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cbo_roomrate)
        Me.GroupBox1.Controls.Add(Me.txt_checked_in_no)
        Me.GroupBox1.Controls.Add(Me.cbo_room_number)
        Me.GroupBox1.Controls.Add(Me.dtp_date_departure)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.cbo_status)
        Me.GroupBox1.Controls.Add(Me.dtp_date_arrived)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_payment_method)
        Me.GroupBox1.Controls.Add(Me.txt_customername)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 520)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'cbo_roomrate
        '
        Me.cbo_roomrate.FormattingEnabled = True
        Me.cbo_roomrate.Items.AddRange(New Object() {"550", "750", "950"})
        Me.cbo_roomrate.Location = New System.Drawing.Point(149, 342)
        Me.cbo_roomrate.Name = "cbo_roomrate"
        Me.cbo_roomrate.Size = New System.Drawing.Size(234, 25)
        Me.cbo_roomrate.TabIndex = 19
        '
        'txt_checked_in_no
        '
        Me.txt_checked_in_no.Location = New System.Drawing.Point(147, 44)
        Me.txt_checked_in_no.Name = "txt_checked_in_no"
        Me.txt_checked_in_no.Size = New System.Drawing.Size(236, 25)
        Me.txt_checked_in_no.TabIndex = 18
        '
        'cbo_room_number
        '
        Me.cbo_room_number.FormattingEnabled = True
        Me.cbo_room_number.Items.AddRange(New Object() {"101", "102", "103", "104", "105", "106"})
        Me.cbo_room_number.Location = New System.Drawing.Point(147, 209)
        Me.cbo_room_number.Name = "cbo_room_number"
        Me.cbo_room_number.Size = New System.Drawing.Size(236, 25)
        Me.cbo_room_number.TabIndex = 15
        '
        'dtp_date_departure
        '
        Me.dtp_date_departure.Location = New System.Drawing.Point(147, 166)
        Me.dtp_date_departure.Name = "dtp_date_departure"
        Me.dtp_date_departure.Size = New System.Drawing.Size(236, 25)
        Me.dtp_date_departure.TabIndex = 14
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(269, 393)
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
        Me.btn_save.Location = New System.Drawing.Point(149, 393)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(114, 33)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'cbo_status
        '
        Me.cbo_status.FormattingEnabled = True
        Me.cbo_status.Items.AddRange(New Object() {"Checked-in", "Reserved", "Canceled"})
        Me.cbo_status.Location = New System.Drawing.Point(147, 294)
        Me.cbo_status.Name = "cbo_status"
        Me.cbo_status.Size = New System.Drawing.Size(236, 25)
        Me.cbo_status.TabIndex = 9
        '
        'dtp_date_arrived
        '
        Me.dtp_date_arrived.Location = New System.Drawing.Point(147, 125)
        Me.dtp_date_arrived.Name = "dtp_date_arrived"
        Me.dtp_date_arrived.Size = New System.Drawing.Size(236, 25)
        Me.dtp_date_arrived.TabIndex = 6
        Me.dtp_date_arrived.Value = New Date(2022, 12, 1, 0, 0, 0, 0)
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(32, 52)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(97, 17)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "Checked-In No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Room Rate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Payment Method"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Room Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Date Departure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date Arrived"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Name"
        '
        'cbo_payment_method
        '
        Me.cbo_payment_method.FormattingEnabled = True
        Me.cbo_payment_method.Items.AddRange(New Object() {"Cash", "Online", "Debit/Credit"})
        Me.cbo_payment_method.Location = New System.Drawing.Point(147, 251)
        Me.cbo_payment_method.Name = "cbo_payment_method"
        Me.cbo_payment_method.Size = New System.Drawing.Size(236, 25)
        Me.cbo_payment_method.TabIndex = 2
        '
        'txt_customername
        '
        Me.txt_customername.Location = New System.Drawing.Point(147, 84)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(236, 25)
        Me.txt_customername.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lv_checked_in)
        Me.Panel1.Location = New System.Drawing.Point(501, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 402)
        Me.Panel1.TabIndex = 2
        '
        'lv_checked_in
        '
        Me.lv_checked_in.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.checkedeinNo, Me.customername, Me.datearrived, Me.datedeparture, Me.roomno, Me.paymethod, Me.status, Me.roomrate})
        Me.lv_checked_in.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_checked_in.FullRowSelect = True
        Me.lv_checked_in.HideSelection = False
        Me.lv_checked_in.Location = New System.Drawing.Point(0, 0)
        Me.lv_checked_in.Name = "lv_checked_in"
        Me.lv_checked_in.Size = New System.Drawing.Size(751, 402)
        Me.lv_checked_in.TabIndex = 0
        Me.lv_checked_in.UseCompatibleStateImageBehavior = False
        Me.lv_checked_in.View = System.Windows.Forms.View.Details
        '
        'checkedeinNo
        '
        Me.checkedeinNo.Text = "Checked_In_No."
        Me.checkedeinNo.Width = 107
        '
        'customername
        '
        Me.customername.Text = "Customer Name"
        Me.customername.Width = 99
        '
        'datearrived
        '
        Me.datearrived.Text = "Date Arrived"
        Me.datearrived.Width = 91
        '
        'datedeparture
        '
        Me.datedeparture.Text = "Date Departure"
        Me.datedeparture.Width = 92
        '
        'roomno
        '
        Me.roomno.Text = "Room Number"
        Me.roomno.Width = 84
        '
        'paymethod
        '
        Me.paymethod.Text = "Payment Method"
        Me.paymethod.Width = 100
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 68
        '
        'roomrate
        '
        Me.roomrate.Text = "Room Rate"
        Me.roomrate.Width = 109
        '
        'btn_payment
        '
        Me.btn_payment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_payment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payment.ForeColor = System.Drawing.Color.White
        Me.btn_payment.Location = New System.Drawing.Point(1007, 486)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.Size = New System.Drawing.Size(116, 33)
        Me.btn_payment.TabIndex = 8
        Me.btn_payment.Text = "Payment"
        Me.btn_payment.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(885, 486)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(116, 33)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.White
        Me.btn_new.Location = New System.Drawing.Point(641, 486)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(116, 33)
        Me.btn_new.TabIndex = 5
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(763, 486)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(116, 33)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'frm_check_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 561)
        Me.Controls.Add(Me.btn_payment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_update)
        Me.Name = "frm_check_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checked In Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_room_number As ComboBox
    Friend WithEvents dtp_date_departure As DateTimePicker
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents cbo_status As ComboBox
    Friend WithEvents dtp_date_arrived As DateTimePicker
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_payment_method As ComboBox
    Friend WithEvents txt_customername As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lv_checked_in As ListView
    Friend WithEvents checkedeinNo As ColumnHeader
    Friend WithEvents txt_checked_in_no As TextBox
    Friend WithEvents customername As ColumnHeader
    Friend WithEvents datearrived As ColumnHeader
    Friend WithEvents datedeparture As ColumnHeader
    Friend WithEvents roomno As ColumnHeader
    Friend WithEvents paymethod As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents roomrate As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_roomrate As ComboBox
    Friend WithEvents btn_payment As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_update As Button
End Class
