Imports MySql.Data.MySqlClient
Public Class frm_checked_in
    Public myConnection As New MySqlConnection
    Public MyCommand As New MySqlCommand
    Public MyAdaptor As New MySqlDataAdapter
    Public MyReader As MySqlDataReader
    Private MySQLUSER As String = "root"
    Private MySQLHOST As String = "localhost"
    Private MySQLPASS As String = ""
    Private MySQLDBSE As String = "db_pos"
    Private Sub lv_registration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_checked_in.SelectedIndexChanged
        If lv_checked_in.SelectedItems.Count <> 0 Then
            With lv_checked_in.SelectedItems(0)
                txt_checked_in_no.Text = .SubItems(0).Text
                txt_customername.Text = .SubItems(1).Text
                dtp_date_arrived.Text = .SubItems(2).Text
                dtp_date_departure.Text = .SubItems(3).Text
                cbo_room_number.Text = .SubItems(4).Text
                cbo_status.Text = .SubItems(5).Text
                cbo_payment_method.Text = .SubItems(6).Text
                cbo_roomrate.Text = .SubItems(7).Text
            End With
        End If
        myConnection.Close()
    End Sub

    Private Sub frm_check_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_checked_in.Load("", lv_checked_in)
        For Each Column As ColumnHeader In Me.lv_checked_in.Columns
            Column.Width = -2
         
        Next

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR

        myConnection.Open()

        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "insert into db_pos.tblchecked_in (checked_in_num, customer_name, date_arrived , date_departure, room_num, paymethod, status, room_rate) values ('" & txt_checked_in_no.Text & "','" & txt_customername.Text & "','" & dtp_date_arrived.Text & "','" & dtp_date_departure.Text & "','" & cbo_room_number.Text & "','" & cbo_payment_method.Text & "','" & cbo_status.Text & "','" & cbo_roomrate.Text & "' )"
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Item Inserted", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")

        End Try

        'txt_checked_in_no.Clear()
        'txt_customername.Clear()
        'dtp_date_arrived.Text = ""
        'dtp_date_departure.Text = ""
        'cbo_room_number.Text = ""
        'cbo_payment_method.Text = ""
        'cbo_status.Text = ""
        'cbo_roomrate.Text = ""
        lv_checked_in.Items.Clear()
        Load_checked_in.Load("", lv_checked_in)
        myConnection.Close()
    End Sub
    Dim Load_checked_in As New checked_in

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txt_checked_in_no.Clear()
        txt_customername.Clear()
        dtp_date_arrived.Text = ""
        dtp_date_departure.Text = ""
        cbo_room_number.Text = ""
        cbo_payment_method.Text = ""
        cbo_status.Text = ""
        cbo_roomrate.Text = ""
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR

        myConnection.Open()
        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "update db_pos.tblchecked_in set checked_in_num= '" & txt_checked_in_no.Text & "', customer_name= '" & txt_customername.Text & "', date_arrived= '" & dtp_date_arrived.Text & "', date_departure= '" & dtp_date_departure.Text & "', room_num= '" & cbo_room_number.Text & "', paymethod= '" & cbo_payment_method.Text & "', status='" & cbo_status.Text & "', room_rate= '" & cbo_roomrate.Text & "'  where checked_in_num= '" & txt_checked_in_no.Text & "' "
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Update", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try

        'txt_checked_in_no.Clear()
        'txt_customername.Clear()
        'dtp_date_arrived.Text = ""
        'dtp_date_departure.Text = ""
        'cbo_room_number.Text = ""
        'cbo_payment_method.Text = ""
        'cbo_status.Text = ""
        'cbo_roomrate.Text = ""
        lv_checked_in.Items.Clear()
        Load_checked_in.Load("", lv_checked_in)
        myConnection.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR

        myConnection.Open()
        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "delete from db_pos.tblchecked_in where checked_in_num  = '" & txt_checked_in_no.Text & "'"
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Deleted", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try

        'txt_checked_in_no.Clear()
        'txt_customername.Clear()
        'dtp_date_arrived.Text = ""
        'dtp_date_departure.Text = ""
        'cbo_room_number.Text = ""
        'cbo_payment_method.Text = ""
        'cbo_status.Text = ""
        'cbo_roomrate.Text = ""
        lv_checked_in.Items.Clear()
        Load_checked_in.Load("", lv_checked_in)
        myConnection.Close()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_checked_in_no.Text = ""
        txt_customername.Clear()
        dtp_date_arrived.Text = ""
        dtp_date_departure.Text = ""
        cbo_room_number.Text = ""
        cbo_payment_method.Text = ""
        cbo_status.Text = ""
        cbo_roomrate.Text = ""
    End Sub

    Private Sub btn_checkedin_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        Me.Hide()
        frm_billing.Show()
    End Sub
End Class