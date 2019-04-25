Imports System.Data.OleDb
Module modConnect
    Public dbcon As New OleDbConnection
    Public Sub pConnectDb()
        dbcon.ConnectionString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Examination system\Online Examination\WindowsApplication1\WindowsApplication1\dbStu.accdb"
        dbcon.Open()
        ' MsgBox("Connection Succesful")
    End Sub
    Public Sub pDisconnectDB()
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
    End Sub
End Module
