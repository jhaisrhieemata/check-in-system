Imports MySql.Data.MySqlClient
Public Class registration
    Public myConnection As New MySqlConnection
    Public MyCommand As New MySqlCommand
    Public MyAdaptor As New MySqlDataAdapter
    Public MyReader As MySqlDataReader
    Private MySQLUSER As String = "root"
    Private MySQLHOST As String = "localhost"
    Private MySQLPASS As String = ""
    Private MySQLDBSE As String = "db_pos"

    Public Sub Load(ByRef STR As String, ByRef List As ListView)
        Dim l As String
        Dim TABLE As New DataTable
        If STR <> "" Then
            l = STR
        Else
            l = "Select * from db_pos.tblregistration  order by register_id asc"
        End If

        Try
            Databaseconnect()
            MyCommand.Connection = myConnection
            MyCommand.CommandText = l
            MyAdaptor.SelectCommand = MyCommand
            MyAdaptor.Fill(TABLE) 'fill table with data from  database
            Dim COLS As Integer = 5
            Dim BUFFER As Integer
            For BUFFER = 0 To TABLE.Rows.Count - 1 ' table rows number of records in the database . ' this is for rows 
                With frm_CustomerRegistration.lv_registration
                    .Items.Add(TABLE.Rows(BUFFER)(0)) 'id determines the number rows and thus the number of loop 

                    If COLS > 0 Then
                        With .Items(.Items.Count - 1).SubItems
                            Dim RBUFF As Integer
                            For RBUFF = 1 To COLS
                                .Add(TABLE.Rows(BUFFER)(RBUFF))

                            Next
                        End With
                    End If
                End With
            Next
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConnection.Close()
        End Try
    End Sub

    Public Function Databaseconnect()
        Dim STR As String
        STR = "server=" & MySQLHOST & "; user=" & MySQLUSER & ";password=" & MySQLPASS & "; database=" & MySQLDBSE

        myConnection.ConnectionString = STR
        Try
            myConnection.Open()
            Return True
        Catch ex As Exception
            MsgBox("Data Connection Failed!", MsgBoxStyle.Critical, "System Error")
            Return False
        End Try
    End Function
End Class
