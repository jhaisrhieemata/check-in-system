Imports MySql.Data.MySqlClient
Public Class frm_ChangePassword
    Public myConnection As New MySqlConnection
    Public MyCommand As New MySqlCommand
    Public MyAdaptor As New MySqlDataAdapter
    Public MyReader As MySqlDataReader
    Public dt As New DataTable
    Dim result As Boolean
    Public i As Integer
    Private Sub frm_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_ChangePass_Click(sender As Object, e As EventArgs) Handles btn_ChangePass.Click
        If txt_oldpassword.Text = String.Empty Then
            MsgBox("Pls Enter Your OLD Password !", vbExclamation)
            Return
        ElseIf txt_newpassword.Text = String.Empty Or txt_reenterPassword.Text = String.Empty Then
            MsgBox("Pls Enter Your New Password !", vbExclamation)
            Return
        ElseIf StrComp(txt_newpassword.Text, txt_reenterPassword.Text, CompareMethod.Binary) Then
            MsgBox(" Password Does not Match !", vbExclamation)
            Return
        Else
            Try
                myConnection.Open()
                MyCommand = New MySqlCommand("UPDATE `tbluser` SET `password`=@password WHERE `password`=@password1", myConnection)
                MyCommand.Parameters.Clear()
                MyCommand.Parameters.AddWithValue("@Password", txt_reenterPassword.Text)
                MyCommand.Parameters.AddWithValue("@Password1", txt_oldpassword.Text)
                i = MyCommand.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Change Success !", vbExclamation)
                Else
                    MsgBox("Password Change Faide !", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myConnection.Close()
        End If
        txt_newpassword.Clear()
        txt_oldpassword.Clear()
        txt_reenterPassword.Clear()
        Me.Hide()
        frm_login.Show()

    End Sub
    Public Function dbconn() As Boolean
        Try
            If myConnection.State = ConnectionState.Closed Then
                myConnection.ConnectionString = "server=localhost;user=root;password=;port=3306;database=db_pos"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server not Connected !", vbExclamation)

        End Try
        Return result
    End Function
End Class