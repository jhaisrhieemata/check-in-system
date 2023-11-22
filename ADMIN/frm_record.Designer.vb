<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_record
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lv_registration = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.add = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cont = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Datein = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Checkin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Checkout = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Dateout = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.roomno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.roomtype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.roomstat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.roomrate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.paymentmethod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.paymentstatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lv_registration)
        Me.Panel1.Location = New System.Drawing.Point(12, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1326, 281)
        Me.Panel1.TabIndex = 0
        '
        'lv_registration
        '
        Me.lv_registration.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.fname, Me.add, Me.cont, Me.Datein, Me.Checkin, Me.Checkout, Me.Dateout, Me.roomno, Me.roomtype, Me.roomstat, Me.roomrate, Me.paymentmethod, Me.paymentstatus})
        Me.lv_registration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_registration.HideSelection = False
        Me.lv_registration.Location = New System.Drawing.Point(0, 0)
        Me.lv_registration.Name = "lv_registration"
        Me.lv_registration.Size = New System.Drawing.Size(1326, 281)
        Me.lv_registration.TabIndex = 1
        Me.lv_registration.UseCompatibleStateImageBehavior = False
        Me.lv_registration.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "ID"
        Me.Id.Width = 28
        '
        'fname
        '
        Me.fname.Text = "Name"
        '
        'add
        '
        Me.add.Text = "Address"
        '
        'cont
        '
        Me.cont.Text = "Contact no."
        Me.cont.Width = 74
        '
        'Datein
        '
        Me.Datein.Text = "Date In"
        Me.Datein.Width = 75
        '
        'Checkin
        '
        Me.Checkin.Text = "Checked in Time"
        Me.Checkin.Width = 92
        '
        'Checkout
        '
        Me.Checkout.Text = "Checked Out Time"
        Me.Checkout.Width = 100
        '
        'Dateout
        '
        Me.Dateout.Text = "Date Out"
        Me.Dateout.Width = 48
        '
        'roomno
        '
        Me.roomno.Text = "Room no."
        '
        'roomtype
        '
        Me.roomtype.Text = "Room Type"
        Me.roomtype.Width = 70
        '
        'roomstat
        '
        Me.roomstat.Text = "Room Status"
        Me.roomstat.Width = 92
        '
        'roomrate
        '
        Me.roomrate.Text = "Room Rate"
        '
        'paymentmethod
        '
        Me.paymentmethod.Text = "Payment Metod"
        Me.paymentmethod.Width = 63
        '
        'paymentstatus
        '
        Me.paymentstatus.Text = "Payment Status"
        Me.paymentstatus.Width = 46
        '
        'frm_record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lv_registration As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents fname As ColumnHeader
    Friend WithEvents add As ColumnHeader
    Friend WithEvents cont As ColumnHeader
    Friend WithEvents Datein As ColumnHeader
    Friend WithEvents Checkin As ColumnHeader
    Friend WithEvents Checkout As ColumnHeader
    Friend WithEvents Dateout As ColumnHeader
    Friend WithEvents roomno As ColumnHeader
    Friend WithEvents roomtype As ColumnHeader
    Friend WithEvents roomstat As ColumnHeader
    Friend WithEvents roomrate As ColumnHeader
    Friend WithEvents paymentmethod As ColumnHeader
    Friend WithEvents paymentstatus As ColumnHeader
End Class
