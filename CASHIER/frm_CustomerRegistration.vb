Imports MySql.Data.MySqlClient
Public Class frm_CustomerRegistration
    Public myConnection As New MySqlConnection
    Public MyCommand As New MySqlCommand
    Public MyAdaptor As New MySqlDataAdapter
    Public MyReader As MySqlDataReader
    Private MySQLUSER As String = "root"
    Private MySQLHOST As String = "localhost"
    Private MySQLPASS As String = ""
    Private MySQLDBSE As String = "db_pos"
    Private Sub frm_CustomerRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_register.Load("", lv_registration)
        For Each Column As ColumnHeader In Me.lv_registration.Columns
            Column.Width = -2
        Next

    End Sub

    Private Sub lv_registration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_registration.SelectedIndexChanged
        If lv_registration.SelectedItems.Count <> 0 Then
            With lv_registration.SelectedItems(0)
                txt_registerID.Text = .SubItems(0).Text
                txt_firstname.Text = .SubItems(1).Text
                txt_lastname.Text = .SubItems(2).Text
                txt_address.Text = .SubItems(3).Text
                txt_contacno.Text = .SubItems(4).Text
                dtp_date_register.Text = .SubItems(5).Text
            End With

        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR

        myConnection.Open()
        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "insert into db_pos.tblregistration (register_id, firstname, lastname, address , contact_no, date_register) values ('" & txt_registerID.Text & "','" & txt_firstname.Text & "','" & txt_lastname.Text & "','" & txt_address.Text & "','" & txt_contacno.Text & "','" & dtp_date_register.Text & "' )"
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Item Inserted", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")

        End Try

        txt_registerID.Clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_address.Clear()
        txt_contacno.Clear()
        dtp_date_register.Text = ""
        lv_registration.Items.Clear()
        Load_register.Load("", lv_registration)
        myConnection.Close()

    End Sub
    Dim Load_register As New registration
    'Dim Load_checked_in As New checked_In
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txt_registerID.Clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_address.Clear()
        txt_contacno.Clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txt_firstname_TextChanged(sender As Object, e As EventArgs) Handles txt_firstname.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR
        myConnection.Open()
        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "update db_pos.tblregistration set register_id= '" & txt_registerID.Text & "', firstname= '" & txt_firstname.Text & "', lastname= '" & txt_lastname.Text & "', address= '" & txt_address.Text & "', contact_no= '" & txt_contacno.Text & "', date_register= '" & dtp_date_register.Text & "' where register_id= '" & txt_registerID.Text & "' "
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Update", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try
        txt_registerID.Clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_address.Clear()
        txt_contacno.Clear()
        lv_registration.Items.Clear()
        Load_register.Load("", lv_registration)
        myConnection.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btn_checkedin_Click(sender As Object, e As EventArgs) Handles btn_checkedin.Click
        Me.Hide()
        frm_checked_in.Show()

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_registerID.Clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_address.Clear()
        txt_contacno.Clear()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR
        myConnection.Open()
        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "delete from db_pos.tblregistration where register_id  = '" & txt_registerID.Text & "'"
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Deleted", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try
        txt_registerID.Clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_address.Clear()
        txt_contacno.Clear()
        lv_registration.Items.Clear()
        Load_register.Load("", lv_registration)
        myConnection.Close()
    End Sub

    Private Sub lbl_id_Click(sender As Object, e As EventArgs) Handles lbl_id.Click

    End Sub
End Class