Imports DTO
Imports MySql.Data.MySqlClient

Public Class TipoProdutoDAL

    Public Function IncluiTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try

            If tipoprodutoDTO.CodigoTipoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Codigo_Tipo_Produto", tipoprodutoDTO.CodigoTipoProduto))
            Else
                parram.Add(New MySqlParameter("@Codigo_Tipo_Produto", DBNull.Value))
            End If

            If tipoprodutoDTO.CodigoCategoriaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Categoria_Produto_Codigo_Categoria_Produto", tipoprodutoDTO.CodigoCategoriaProduto))
            Else
                parram.Add(New MySqlParameter("@Categoria_Produto_Codigo_Categoria_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "INSERT INTO TIPO_PRODUTO (codigo_tipo_produto, categoria_produto_codigo_categoria_produto)"
            SQL = SQL + "VALUES (@Codigo_Tipo_Produto, @Categoria_Produto_Codigo_Categoria_Produto)"

            retorno = conexao.ExecuteQuery(SQL, parram)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function DeletaTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If tipoprodutoDTO.CodigoTipoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Codigo_Tipo_Produto", tipoprodutoDTO.CodigoTipoProduto))
            Else
                parram.Add(New MySqlParameter("@Codigo_Tipo_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "DELETE FROM TIPO_PRODUTO"
            SQL = SQL + " WHERE codigo_tipo_produto = '" & tipoprodutoDTO.CodigoTipoProduto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function SelecionaTipoProduto() As DataTable
        Dim dt As New DataTable
        Dim conexao As New Conexao
        Dim SQL As String

        Try
            SQL = Nothing
            SQL = SQL + "SELECT CODIGO_TIPO_PRODUTO From TIPO_PRODUTO"

            dt = conexao.ExecuteDataTable(SQL)

            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try

        Return dt
    End Function

    Public Function SelecionaTipoProdutos(tipoprodutoDTO As TipoProdutoDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If tipoprodutoDTO.CodigoTipoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Codigo_Tipo_Produto", tipoprodutoDTO.CodigoTipoProduto))
            Else
                parram.Add(New MySqlParameter("@Codigo_Tipo_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "SELECT * FROM TIPO_PRODUTO"
            SQL = SQL + " WHERE codigo_tipo_produto = '" & tipoprodutoDTO.CodigoTipoProduto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function
End Class
