Imports DTO
Imports MySql.Data.MySqlClient

Public Class CategoriaDAL

    Public Function IncluiCategoria(categoriaDTO As CategoriaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If categoriaDTO.Codigo_Categoria_Produto <> Nothing Then
                parram.Add(New MySqlParameter("@Codigo_Categoria_Produto", categoriaDTO.Codigo_Categoria_Produto))
            Else
                parram.Add(New MySqlParameter("@Codigo_Categoria_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "INSERT INTO CATEGORIA_PRODUTO (codigo_categoria_produto)"
            SQL = SQL + "VALUES (@Codigo_Categoria_Produto)"

            retorno = conexao.ExecuteQuery(SQL, parram)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function DeletaCategoria(categoriaDTO As CategoriaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If categoriaDTO.Codigo_Categoria_Produto <> Nothing Then
                parram.Add(New MySqlParameter("@Codigo_Categoria_Produto", categoriaDTO.Codigo_Categoria_Produto))
            Else
                parram.Add(New MySqlParameter("@Codigo_Categoria_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "DELETE FROM CATEGORIA_PRODUTO"
            SQL = SQL + " WHERE codigo_categoria_produto = '" & categoriaDTO.Codigo_Categoria_Produto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function SelecionaCategoria() As DataTable
        Dim dt As New DataTable
        Dim conexao As New Conexao
        Dim SQL As String

        Try
            SQL = Nothing
            SQL = SQL + " SELECT CODIGO_CATEGORIA_PRODUTO From CATEGORIA_PRODUTO"

            dt = conexao.ExecuteDataTable(SQL)

            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try

        Return dt
    End Function

    Public Function SelecionaCategorias(categoriaDTO As CategoriaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If categoriaDTO.Codigo_Categoria_Produto <> Nothing Then
                parram.Add(New MySqlParameter("@Codigo_Categoria_Produto", categoriaDTO.Codigo_Categoria_Produto))
            Else
                parram.Add(New MySqlParameter("@Codigo_Categoria_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "SELECT * FROM TIPO_PRODUTO"
            SQL = SQL + " WHERE codigo_tipo_produto = '" & categoriaDTO.Codigo_Categoria_Produto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

End Class
