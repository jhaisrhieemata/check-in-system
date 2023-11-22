Public Class frm_mainAdmin
    Private Sub frm_mainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub btn_manageUser_Click(sender As Object, e As EventArgs) Handles btn_manageUser.Click
        frm_ManageUser.ShowDialog()
    End Sub

    Private Sub btn_manageCheckin_Click(sender As Object, e As EventArgs) Handles btn_manageCheckin.Click
        frm_checked_in.ShowDialog()
    End Sub

    Private Sub btn_manageRegister_Click(sender As Object, e As EventArgs) Handles btn_manageRegister.Click
        frm_CustomerRegistration.Show()
    End Sub

    Private Sub Btn_report_Click(sender As Object, e As EventArgs) Handles Btn_report.Click
        frm_record.ShowDialog()
    End Sub
End Class