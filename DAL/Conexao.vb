Imports MySql.Data.MySqlClient

Public Class Conexao
#Region "atributos"
    Private conexao As MySqlConnection
    Private command As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
#End Region

#Region "Open and Close"
    Public Sub New()
        conexao = New MySqlConnection("Server=localhost;Database=erp;Uid=root;Pwd=root;")
    End Sub

    Public Sub CloseConn()
        If IsNothing(conexao) Then
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End If
    End Sub
#End Region

#Region "Executa Query"
    Public Function ExecuteQuery(SQL As String, parametros As List(Of MySqlParameter)) As ArrayList
        Dim Array As ArrayList = New ArrayList
        Dim retorno As Boolean = True
        Dim LastId As Integer
        Try
            command = New MySqlCommand(SQL, conexao)

            For Each P As MySqlParameter In parametros
                command.Parameters.Add(P)
            Next
            conexao.Open()
            retorno = command.ExecuteNonQuery()
            LastId = Convert.ToInt32(command.LastInsertedId.ToString)
            Array.Add(LastId)
            Array.Add(retorno)
        Catch ex As Exception
            retorno = False
            Throw New Exception("Problema ao executar a função ExecuteQuery" + ex.Message)
        Finally
            command = Nothing
        End Try

        Return Array
    End Function
#End Region

#Region "Retorna DataSet"
    Public Function ExecuteDataSet(ByVal SQL As String, ByVal parametros As List(Of MySqlParameter)) As DataSet
        Dim ds As New DataSet
        Try
            command = New MySqlCommand(SQL, conexao)

            For Each P As MySqlParameter In parametros
                command.Parameters.Add(P)
            Next
            conexao.Open()
            da = New MySqlDataAdapter(command)
            da.Fill(ds)
        Catch ex As Exception
            Throw New Exception("Problema ao executar a função ExecuteDataSet" + ex.Message)
        Finally
            command = Nothing
        End Try
        Return ds
    End Function
#End Region

#Region "Retorna DataTable"
    Public Function ExecuteDataTable(ByVal SQL As String) As DataTable
        Dim dt As New DataTable
        Try
            command = New MySqlCommand(SQL, conexao)

            conexao.Open()
            da = New MySqlDataAdapter(command)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Problema ao executar a função ExecuteDataTable" + ex.Message)
        Finally
            command = Nothing
        End Try
        Return dt
    End Function
#End Region

#Region "Retorna DataReader"
    Public Function ExecuteDataReader(ByVal SQL As String, ByVal parametros As List(Of MySqlParameter)) As IDataReader
        Try
            command = New MySqlCommand(SQL, conexao)

            For Each P As MySqlParameter In parametros
                command.Parameters.Add(P)
            Next
            conexao.Open()
            dr = command.ExecuteReader
        Catch ex As Exception
            Throw New Exception("Problema ao executar a função ExecuteDataReader" + ex.Message)
        Finally
            command = Nothing
        End Try
        Return dr
    End Function
#End Region
End Class