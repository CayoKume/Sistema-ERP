Imports DAL
Imports DTO

Public Class ProdutoBLL
    Implements IProduto

    Public Function InsertProduto(Produto As ProdutoDTO) As ArrayList Implements IProduto.InsertProduto
        Dim retorno As ArrayList
        Dim ProdutoDAL As New ProdutoDAL
        Try
            retorno = ProdutoDAL.IncluiProduto(Produto)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function UpdateProduto(Produto As ProdutoDTO) As ArrayList Implements IProduto.UpdateProduto
        Dim retorno As ArrayList
        Dim ProdutoDAL As New ProdutoDAL
        Try
            retorno = ProdutoDAL.AlteraProduto(Produto)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function DeleteProduto(Produto As ProdutoDTO) As ArrayList Implements IProduto.DeleteProduto
        Dim retorno As ArrayList
        Dim ProdutoDAL As New ProdutoDAL
        Try
            retorno = ProdutoDAL.DeletaProduto(Produto)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function SelectProduto(Produto As ProdutoDTO) As ProdutoDTO Implements IProduto.SelectProduto
        Dim ProdutoDAL As New ProdutoDAL

        Try
            ProdutoDAL.SelecionaProduto(Produto)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Produto
    End Function

    Public Function SelectProdutoByDescricao(Produto As ProdutoDTO) As Boolean Implements IProduto.SelectProdutoByDescricao
        'Dim retorno As Boolean = False
        'Dim dr As IDataReader
        'Dim conexao As New Conexao
        'Try
        '    dr = conexao.ExecuteDataReader(SQL, parametros)
        '    Do While dr.Read
        '        If Not IsDBNull(dr("id_produto")) Then Id_Produto = dr("id_produto")
        '        If Not IsDBNull(dr("descricao_produto")) Then Descricao_Produto = dr("descricao_produto")
        '        If Not IsDBNull(dr("classe_produto")) Then Classe_Produto = dr("classe_produto")
        '        If Not IsDBNull(dr("status_produto")) Then Status_Produto = dr("status_produto")
        '        If Not IsDBNull(dr("preco_compra_produto")) Then Preco_Compra_Produto = dr("preco_compra_produto")
        '        If Not IsDBNull(dr("compra_imposto_produto")) Then Compra_Imposto_Produto = dr("compra_imposto_produto")
        '        If Not IsDBNull(dr("margem_lucro_produto")) Then Margem_Lucro_Produto = dr("margem_lucro_produto")
        '        If Not IsDBNull(dr("preco_venda_produto")) Then Preco_Venda_Produto = dr("preco_venda_produto")
        '        If Not IsDBNull(dr("estoque_disponivel_produto")) Then Estoque_Disponivel_Produto = dr("estoque_disponivel_produto")
        '        If Not IsDBNull(dr("estoque_min_produto")) Then Estoque_Min_Produto = dr("estoque_min_produto")
        '        If Not IsDBNull(dr("estoque_max_produto")) Then Estoque_Max_Produto = dr("estoque_max_produto")
        '        If Not IsDBNull(dr("estoque_vinculado_produto")) Then Estoque_Vinculado_Produto = dr("estoque_vinculado_produto")
        '        If Not IsDBNull(dr("estoque_previsto_produto")) Then Estoque_Previsto_Produto = dr("estoque_previsto_produto")
        '        If Not IsDBNull(dr("descricoes_detalhadas_produto")) Then Descricoes_Detalhadas_Produto = dr("descricoes_detalhadas_produto")
        '        If Not IsDBNull(dr("observacoes_produto")) Then Observacoes_Produto = dr("observacoes_produto")
        '        If Not IsDBNull(dr("tipo_produto")) Then Codigo_Tipo_Produto = dr("tipo_produto")
        '        If Not IsDBNull(dr("categoria_produto")) Then Codigo_Categoria_Produto = dr("categoria_produto")

        '        retorno = True
        '    Loop

        '    Return retorno
        'Catch ex As Exception
        '    Throw ex
        'Finally
        '    conexao.CloseConn()
        'End Try
    End Function

    Public Function SelectProdutos(Produto As ProdutoDTO) As DataSet Implements IProduto.SelectProdutos
        'Dim ds As New DataSet
        'Dim conexao As New Conexao

        'Try
        '    ds = conexao.ExecuteDataSet(Sql, parametros)
        'Catch ex As Exception
        '    Throw ex
        'Finally
        '    conexao.CloseConn()
        'End Try

        'Return ds
    End Function

End Class
