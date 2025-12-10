Imports System.Data.SqlClient
Public Class SQL
    Private ConnectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=dbPesbokQ;Integrated Security=True"
    Public Function Execute(text As String) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Dim conn As SqlConnection = New SqlConnection(ConnectionString)
            Dim da As SqlDataAdapter = New SqlDataAdapter(text, conn)
            dt = New DataTable()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show($"Query.Error => {ex.Message}")
        End Try

        Execute = dt
    End Function
End Class
