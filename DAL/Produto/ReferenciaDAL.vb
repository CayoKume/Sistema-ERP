Imports DTO
Imports MySql.Data.MySqlClient

Public Class ReferenciaDAL

    Public Function IncluiReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If referenciaDTO.CodigoReferenciaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Codigo_Referencia_Produto", referenciaDTO.CodigoReferenciaProduto))
            Else
                parram.Add(New MySqlParameter("@Codigo_Referencia_Produto", DBNull.Value))
            End If
            If referenciaDTO.CatalagoReferencia <> Nothing Then
                parram.Add(New MySqlParameter("@Catalago_Referencia", referenciaDTO.CatalagoReferencia))
            Else
                parram.Add(New MySqlParameter("@Catalago_Referencia", DBNull.Value))
            End If
            If referenciaDTO.IdProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Id_Produto", referenciaDTO.IdProduto))
            Else
                parram.Add(New MySqlParameter("@Id_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "INSERT INTO REFERENCIA_PRODUTO (codigo_referencia_produto, catalago_referencia, produto_id_produto)"
            SQL = SQL + "VALUES (@Codigo_Referencia_Produto, @Catalago_Referencia, @Id_Produto)"

            retorno = conexao.ExecuteQuery(SQL, parram)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function AlteraReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            SQL = Nothing
            SQL = SQL + " UPDATE REFERENCIA_PRODUTO SET codigo_referencia_produto = '" & referenciaDTO.CodigoReferenciaProduto & "', catalago_referencia = '" & referenciaDTO.CatalagoReferencia & "'"
            SQL = SQL + " WHERE produto_id_produto = '" & referenciaDTO.IdProduto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function DeletaReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String
        Try
            If referenciaDTO.IdReferenciaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Id_Referencia", referenciaDTO.IdReferenciaProduto))
            End If

            SQL = Nothing
            SQL = SQL + " DELETE From REFERENCIA_PRODUTO WHERE codigo_referencia_produto = '" & referenciaDTO.CodigoReferenciaProduto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try
        Return retorno
    End Function

    Public Function SelecionaReferencia(referenciaDTO As ReferenciaDTO) As List(Of ReferenciaDTO)
        Dim conexao As New Conexao
        Dim retorno As New List(Of ReferenciaDTO)
        Dim dr As IDataReader
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        SQL = Nothing
        SQL = SQL + " SELECT * From REFERENCIA_PRODUTO WHERE codigo_referencia_produto = '" & referenciaDTO.CodigoReferenciaProduto & "'"

        Try
            dr = conexao.ExecuteDataReader(SQL, parram)
            While dr.Read
                If Not IsDBNull(dr("id_referencia_produto")) Then referenciaDTO.IdReferenciaProduto = dr("id_referencia_produto")
                If Not IsDBNull(dr("codigo_referencia_produto")) Then referenciaDTO.CodigoReferenciaProduto = dr("codigo_referencia_produto")
                If Not IsDBNull(dr("catalago_referencia")) Then referenciaDTO.CatalagoReferencia = dr("catalago_referencia")
                If Not IsDBNull(dr("produto_id_produto")) Then referenciaDTO.IdProduto = dr("produto_id_produto")

                retorno.Add(New ReferenciaDTO(referenciaDTO.IdProduto, referenciaDTO.CodigoReferenciaProduto, referenciaDTO.CatalagoReferencia, referenciaDTO.IdProduto))
            End While

            Return retorno
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try
    End Function

    Public Function SelecionaReferencias(referenciaDTO As ReferenciaDTO) As DataTable
        Dim dt As New DataTable
        Dim conexao As New Conexao
        Dim SQL As String

        Try
            SQL = Nothing
            SQL = SQL + " SELECT * From REFERENCIA_PRODUTO WHERE produto_id_produto = '" & referenciaDTO.IdProduto & "'"

            dt = conexao.ExecuteDataTable(SQL)

            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try

        Return dt
    End Function

End Class
