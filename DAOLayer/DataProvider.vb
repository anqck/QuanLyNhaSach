Imports System.Data.OleDb
Imports ADODB

Public Class DataProvider

    Private Shared m_connectionString As String
    Private Shared connection As OleDbConnection = Nothing

    Public Shared Property ConnectionString() As String
        Get
            Return m_connectionString
        End Get

        Set
            m_connectionString = Value
            If connection IsNot Nothing Then
                connection.Close()
            End If
            connection = New OleDbConnection(m_connectionString)
            connection.Open()
        End Set
    End Property

    Friend Shared Function ExecuteQuery(strSQL As String) As DataTable

        Dim ds As New DataSet()
        Dim adapter As New OleDbDataAdapter(strSQL, connection)
        adapter.Fill(ds)
        Return ds.Tables(0)
    End Function

    Friend Shared Sub ExecuteNonQuery(strSQL As String)

        Dim command As New OleDbCommand(strSQL, connection)
        command.ExecuteNonQuery()
    End Sub
End Class
