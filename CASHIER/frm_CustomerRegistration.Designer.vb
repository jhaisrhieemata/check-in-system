<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_CustomerRegistration
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.txt_registerID = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dtp_date_register = New System.Windows.Forms.DateTimePicker()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_contacno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_firstname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lv_registration = New System.Windows.Forms.ListView()
        Me.registerId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.add = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cont = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dateregister = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_checkedin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txt_lastname)
        Me.GroupBox1.Controls.Add(Me.txt_registerID)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.dtp_date_register)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.txt_contacno)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_firstname)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 391)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information Details"
        '
        'txt_lastname
        '
        Me.txt_lastname.Location = New System.Drawing.Point(146, 118)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(236, 25)
        Me.txt_lastname.TabIndex = 17
        '
        'txt_registerID
        '
        Me.txt_registerID.Enabled = False
        Me.txt_registerID.Location = New System.Drawing.Point(146, 41)
        Me.txt_registerID.Name = "txt_registerID"
        Me.txt_registerID.Size = New System.Drawing.Size(236, 25)
        Me.txt_registerID.TabIndex = 16
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(268, 295)
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
        Me.btn_save.Location = New System.Drawing.Point(148, 295)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(114, 33)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'dtp_date_register
        '
        Me.dtp_date_register.Location = New System.Drawing.Point(146, 242)
        Me.dtp_date_register.Name = "dtp_date_register"
        Me.dtp_date_register.Size = New System.Drawing.Size(236, 25)
        Me.dtp_date_register.TabIndex = 6
        Me.dtp_date_register.Value = New Date(2022, 11, 30, 9, 18, 4, 0)
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(38, 44)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(76, 17)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "Register ID "
        '
        'txt_contacno
        '
        Me.txt_contacno.Location = New System.Drawing.Point(146, 198)
        Me.txt_contacno.Name = "txt_contacno"
        Me.txt_contacno.Size = New System.Drawing.Size(236, 25)
        Me.txt_contacno.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date Register"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(146, 152)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(236, 25)
        Me.txt_address.TabIndex = 1
        '
        'txt_firstname
        '
        Me.txt_firstname.Location = New System.Drawing.Point(146, 80)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.Size = New System.Drawing.Size(236, 25)
        Me.txt_firstname.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lv_registration)
        Me.Panel1.Location = New System.Drawing.Point(512, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 319)
        Me.Panel1.TabIndex = 1
        '
        'lv_registration
        '
        Me.lv_registration.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.registerId, Me.fname, Me.lname, Me.add, Me.cont, Me.Dateregister})
        Me.lv_registration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_registration.FullRowSelect = True
        Me.lv_registration.HideSelection = False
        Me.lv_registration.Location = New System.Drawing.Point(0, 0)
        Me.lv_registration.Name = "lv_registration"
        Me.lv_registration.Size = New System.Drawing.Size(699, 319)
        Me.lv_registration.TabIndex = 0
        Me.lv_registration.UseCompatibleStateImageBehavior = False
        Me.lv_registration.View = System.Windows.Forms.View.Details
        '
        'registerId
        '
        Me.registerId.Text = "Register_ID"
        Me.registerId.Width = 94
        '
        'fname
        '
        Me.fname.Text = "First Name"
        Me.fname.Width = 75
        '
        'lname
        '
        Me.lname.Text = "Last Name"
        Me.lname.Width = 88
        '
        'add
        '
        Me.add.Text = "Address"
        '
        'cont
        '
        Me.cont.Text = "Contact no."
        Me.cont.Width = 91
        '
        'Dateregister
        '
        Me.Dateregister.Text = "Date Register"
        Me.Dateregister.Width = 95
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.White
        Me.btn_new.Location = New System.Drawing.Point(628, 424)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(116, 33)
        Me.btn_new.TabIndex = 1
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(750, 424)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(116, 33)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(872, 424)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(116, 33)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_checkedin
        '
        Me.btn_checkedin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_checkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_checkedin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkedin.ForeColor = System.Drawing.Color.White
        Me.btn_checkedin.Location = New System.Drawing.Point(994, 424)
        Me.btn_checkedin.Name = "btn_checkedin"
        Me.btn_checkedin.Size = New System.Drawing.Size(116, 33)
        Me.btn_checkedin.TabIndex = 4
        Me.btn_checkedin.Text = "checked-in"
        Me.btn_checkedin.UseVisualStyleBackColor = False
        '
        'frm_CustomerRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 561)
        Me.Controls.Add(Me.btn_checkedin)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_CustomerRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Customer Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents dtp_date_register As DateTimePicker
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_contacno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lv_registration As ListView
    Friend WithEvents registerId As ColumnHeader
    Friend WithEvents fname As ColumnHeader
    Friend WithEvents add As ColumnHeader
    Friend WithEvents cont As ColumnHeader
    Friend WithEvents Dateregister As ColumnHeader
    Friend WithEvents txt_registerID As TextBox
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lname As ColumnHeader
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_checkedin As Button
End Class
