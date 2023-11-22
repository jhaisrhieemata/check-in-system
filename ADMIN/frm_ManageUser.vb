Imports MySql.Data.MySqlClient
Public Class frm_ManageUser
    Public myConnection As New MySqlConnection
    Public MyCommand As New MySqlCommand
    Public MyAdaptor As New MySqlDataAdapter
    Public MyReader As MySqlDataReader
    Private MySQLUSER As String = "root"
    Private MySQLHOST As String = "localhost"
    Private MySQLPASS As String = ""
    Private MySQLDBSE As String = "db_pos"
    Private Sub frm_ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Sub clear()
        txt_password.Clear()
        txt_name.Clear()
        txt_username.Clear()
        cbo_role.SelectedIndex = -1
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        frm_login.Show()


    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR
        myConnection.Open()
        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "insert into db_pos.tbluser (name,username, password, role ) values ('" & txt_name.Text & "','" & txt_username.Text & "','" & txt_password.Text & "','" & cbo_role.Text & "')"
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfully Registered", vbInformation)
            frm_login.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try
        txt_name.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        cbo_role.Text = ""
        myConnection.Close()
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frm_ChangePassword.Show()
    End Sub

    Private Sub txt_password_TextChanged_1(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub
End Class