Imports MySql.Data.MySqlClient
Public Class frm_login
    Public myConnection As New MySqlConnection
    Public MyCommand As New MySqlCommand
    Public MyAdaptor As New MySqlDataAdapter
    Public MyReader As MySqlDataReader
    Public dt As New DataTable
    Dim result As Boolean
    Public i As Integer
    Dim fname As String
    Dim username As String
    Dim password As String
    Dim role As String

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you Sure Want Exit ?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            myConnection.Open()
            Dim found As Boolean = False
            MyCommand = New MySqlCommand("SELECT * FROM `tbluser` WHERE `username`='" & txt_username.Text & "' AND `password`='" & txt_password.Text & "'", myConnection)
            MyReader = MyCommand.ExecuteReader
            MyReader.Read()
            If MyReader.HasRows Then
                found = True
                fname = MyReader.Item("name").ToString
                username = MyReader.Item("username").ToString
                password = MyReader.Item("password").ToString
                role = MyReader.Item("role").ToString
            Else
                found = False
                fname = ""
                username = ""
                password = ""
                role = ""


            End If
            If found = True Then
                If StrComp(txt_username.Text, username, CompareMethod.Binary) Or StrComp(txt_password.Text, password, CompareMethod.Binary) Then
                    MsgBox("Warning : Wrong Username or Password !", vbExclamation)
                    Return
                Else
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        frm_mainAdmin.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_mainCashier.Show()
                    End If
                End If
            Else
                MsgBox("Warning : Wrong Username or Password !", vbExclamation)
            End If
            txt_username.Clear()
            txt_password.Clear()
        Catch ex As Exception
            myConnection.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frm_ManageUser.Show()

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
