Imports DTO
Imports MySql.Data.MySqlClient

Public Class ProdutoDAL

    Public Function IncluiProduto(produtoDTO As ProdutoDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If produtoDTO.IdProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Id_Produto", produtoDTO.IdProduto))
            End If
            If produtoDTO.DescricaoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Descricao_Produto", produtoDTO.DescricaoProduto))
            Else
                parram.Add(New MySqlParameter("@Descricao_Produto", DBNull.Value))
            End If
            If produtoDTO.ClasseProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Classe_Produto", produtoDTO.ClasseProduto))
            Else
                parram.Add(New MySqlParameter("@Classe_Produto", DBNull.Value))
            End If
            If produtoDTO.StatusProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Status_Produto", produtoDTO.StatusProduto))
            Else
                parram.Add(New MySqlParameter("@Status_Produto", DBNull.Value))
            End If
            If produtoDTO.PrecoCompraProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Preco_Compra_Produto", produtoDTO.PrecoCompraProduto))
            Else
                parram.Add(New MySqlParameter("@Preco_Compra_Produto", DBNull.Value))
            End If
            If produtoDTO.CompraImpostoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Compra_Imposto_Produto", produtoDTO.CompraImpostoProduto))
            Else
                parram.Add(New MySqlParameter("@Compra_Imposto_Produto", DBNull.Value))
            End If
            If produtoDTO.MargemLucroProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Margem_Lucro_Produto", produtoDTO.MargemLucroProduto))
            Else
                parram.Add(New MySqlParameter("@Margem_Lucro_Produto", DBNull.Value))
            End If
            If produtoDTO.PrecoVendaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Preco_Venda_Produto", produtoDTO.PrecoVendaProduto))
            Else
                parram.Add(New MySqlParameter("@Preco_Venda_Produto", DBNull.Value))
            End If
            If produtoDTO.EstoqueDisponivelProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Estoque_Disponivel_Produto", produtoDTO.EstoqueDisponivelProduto))
            Else
                parram.Add(New MySqlParameter("@Estoque_Disponivel_Produto", DBNull.Value))
            End If
            If produtoDTO.EstoqueMinProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Estoque_Min_Produto", produtoDTO.EstoqueMinProduto))
            Else
                parram.Add(New MySqlParameter("@Estoque_Min_Produto", DBNull.Value))
            End If
            If produtoDTO.EstoqueMaxProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Estoque_Max_Produto", produtoDTO.EstoqueMaxProduto))
            Else
                parram.Add(New MySqlParameter("@Estoque_Max_Produto", DBNull.Value))
            End If
            If produtoDTO.EstoqueVinculadoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Estoque_Vinculado_Produto", produtoDTO.EstoqueVinculadoProduto))
            Else
                parram.Add(New MySqlParameter("@Estoque_Vinculado_Produto", DBNull.Value))
            End If
            If produtoDTO.EstoquePrevistoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Estoque_Previsto_Produto", produtoDTO.EstoquePrevistoProduto))
            Else
                parram.Add(New MySqlParameter("@Estoque_Previsto_Produto", DBNull.Value))
            End If
            If produtoDTO.DescricoesDetalhadasProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Descricoes_Detalhadas_Produto", produtoDTO.DescricoesDetalhadasProduto))
            Else
                parram.Add(New MySqlParameter("@Descricoes_Detalhadas_Produto", DBNull.Value))
            End If
            If produtoDTO.ObservacoesProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Observacoes_Produto", produtoDTO.ObservacoesProduto))
            Else
                parram.Add(New MySqlParameter("@Observacoes_Produto", DBNull.Value))
            End If
            If produtoDTO.ImagemProduto IsNot Nothing Then
                parram.Add(New MySqlParameter("@Imagem_Produto", produtoDTO.ImagemProduto))
            Else
                parram.Add(New MySqlParameter("@Imagem_Produto", DBNull.Value))
            End If
            If produtoDTO.CodigoCategoriaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Categoria_Produto_Codigo_Categoria_Produto", produtoDTO.CodigoCategoriaProduto))
            Else
                parram.Add(New MySqlParameter("@Categoria_Produto_Codigo_Categoria_Produto", " "))
            End If
            If produtoDTO.CodigoTipoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Tipo_Produto_Codigo_Tipo_Produto", produtoDTO.CodigoTipoProduto))
            Else
                parram.Add(New MySqlParameter("@Tipo_Produto_Codigo_Tipo_Produto", " "))
            End If
            If produtoDTO.IdMedidaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Medida_Produto_Id_Medida_Produto", produtoDTO.IdMedidaProduto))
            Else
                parram.Add(New MySqlParameter("@Medida_Produto_Id_Medida_Produto", DBNull.Value))
            End If

            SQL = Nothing
            SQL = SQL + "INSERT INTO PRODUTO (descricao_produto, classe_produto, status_produto, preco_compra_produto, compra_imposto_produto, margem_lucro_produto, preco_venda_produto,"
            SQL = SQL + " estoque_disponivel_produto, estoque_min_produto, estoque_max_produto, estoque_vinculado_produto, estoque_previsto_produto, descricoes_detalhadas_produto,"
            SQL = SQL + " observacoes_produto, imagem_produto, categoria_produto_codigo_categoria_produto, tipo_produto_codigo_tipo_produto, medida_produto_id_medida_produto)"
            SQL = SQL + "VALUES (@Descricao_Produto, @Classe_Produto, @Status_Produto, @Preco_Compra_Produto, @Compra_Imposto_Produto, @Margem_Lucro_Produto, @Preco_Venda_Produto, @Estoque_Disponivel_Produto,"
            SQL = SQL + " @Estoque_Min_Produto, @Estoque_Max_Produto, @Estoque_Vinculado_Produto, @Estoque_Previsto_Produto, @Descricoes_Detalhadas_Produto, @Observacoes_Produto, @Imagem_Produto, @Categoria_Produto_Codigo_Categoria_Produto,"
            SQL = SQL + " @Tipo_Produto_Codigo_Tipo_Produto, @Medida_Produto_Id_Medida_Produto)"

            retorno = conexao.ExecuteQuery(SQL, parram)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function AlteraProduto(produtoDTO As ProdutoDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            SQL = Nothing
            SQL = SQL + " UPDATE PRODUTO SET descricao_produto = '" & produtoDTO.DescricaoProduto & "', classe_produto = '" & produtoDTO.ClasseProduto & "', status_produto = '" & produtoDTO.StatusProduto & "', preco_compra_produto = '" & produtoDTO.PrecoCompraProduto & "',"
            SQL = SQL + " compra_imposto_produto = '" & produtoDTO.CompraImpostoProduto & "', margem_lucro_produto = '" & produtoDTO.MargemLucroProduto & "', preco_venda_produto = '" & produtoDTO.PrecoVendaProduto & "', estoque_disponivel_produto = '" & produtoDTO.EstoqueDisponivelProduto & "',"
            SQL = SQL + " estoque_min_produto = '" & produtoDTO.EstoqueMinProduto & "', estoque_max_produto = '" & produtoDTO.EstoqueMaxProduto & "', estoque_vinculado_produto = '" & produtoDTO.EstoqueVinculadoProduto & "', estoque_previsto_produto = '" & produtoDTO.EstoquePrevistoProduto & "',"
            SQL = SQL + " descricoes_detalhadas_produto = '" & produtoDTO.DescricoesDetalhadasProduto & "', observacoes_produto = '" & produtoDTO.ObservacoesProduto & "', categoria_produto_codigo_categoria_produto = '" & produtoDTO.CodigoCategoriaProduto & "', tipo_produto_codigo_tipo_produto = '" & produtoDTO.CodigoTipoProduto & "'"
            SQL = SQL + " WHERE id_produto = '" & produtoDTO.IdProduto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function DeletaProduto(produtoDTO As ProdutoDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String
        Try
            If produtoDTO.IdProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Id_Produto", produtoDTO.IdProduto))
            End If

            SQL = Nothing
            SQL = SQL + " DELETE From PRODUTO WHERE id_produto = '" & produtoDTO.IdProduto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try
        Return retorno
    End Function

    Public Function SelecionaProdutoPorId(produtoDTO As ProdutoDTO) As ProdutoDTO
        Dim conexao As New Conexao
        Dim retorno As New ProdutoDTO
        Dim dr As IDataReader
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        If produtoDTO.IdProduto <> Nothing Then
            parram.Add(New MySqlParameter("@Id_Produto", produtoDTO.IdProduto))
        End If

        SQL = Nothing
        SQL = SQL + " SELECT * From PRODUTO WHERE id_produto = '" & produtoDTO.IdProduto & "'"

        Try
            dr = conexao.ExecuteDataReader(SQL, parram)
            Do While dr.Read
                If Not IsDBNull(dr("id_produto")) Then produtoDTO.IdProduto = dr("id_produto")
                If Not IsDBNull(dr("descricao_produto")) Then produtoDTO.DescricaoProduto = dr("descricao_produto")
                If Not IsDBNull(dr("classe_produto")) Then produtoDTO.ClasseProduto = dr("classe_produto")
                If Not IsDBNull(dr("status_produto")) Then produtoDTO.StatusProduto = dr("status_produto")
                If Not IsDBNull(dr("preco_compra_produto")) Then produtoDTO.PrecoCompraProduto = dr("preco_compra_produto")
                If Not IsDBNull(dr("compra_imposto_produto")) Then produtoDTO.CompraImpostoProduto = dr("compra_imposto_produto")
                If Not IsDBNull(dr("margem_lucro_produto")) Then produtoDTO.MargemLucroProduto = dr("margem_lucro_produto")
                If Not IsDBNull(dr("preco_venda_produto")) Then produtoDTO.PrecoVendaProduto = dr("preco_venda_produto")
                If Not IsDBNull(dr("estoque_disponivel_produto")) Then produtoDTO.EstoqueDisponivelProduto = dr("estoque_disponivel_produto")
                If Not IsDBNull(dr("estoque_min_produto")) Then produtoDTO.EstoqueMinProduto = dr("estoque_min_produto")
                If Not IsDBNull(dr("estoque_max_produto")) Then produtoDTO.EstoqueMaxProduto = dr("estoque_max_produto")
                If Not IsDBNull(dr("estoque_vinculado_produto")) Then produtoDTO.EstoqueVinculadoProduto = dr("estoque_vinculado_produto")
                If Not IsDBNull(dr("estoque_previsto_produto")) Then produtoDTO.EstoquePrevistoProduto = dr("estoque_previsto_produto")
                If Not IsDBNull(dr("descricoes_detalhadas_produto")) Then produtoDTO.DescricoesDetalhadasProduto = dr("descricoes_detalhadas_produto")
                If Not IsDBNull(dr("observacoes_produto")) Then produtoDTO.ObservacoesProduto = dr("observacoes_produto")
                If Not IsDBNull(dr("imagem_produto")) Then produtoDTO.ImagemProduto = dr("imagem_produto")
                If Not IsDBNull(dr("tipo_produto_codigo_tipo_produto")) Then produtoDTO.CodigoTipoProduto = dr("tipo_produto_codigo_tipo_produto")
                If Not IsDBNull(dr("categoria_produto_codigo_categoria_produto")) Then produtoDTO.CodigoCategoriaProduto = dr("categoria_produto_codigo_categoria_produto")
                If Not IsDBNull(dr("medida_produto_id_medida_produto")) Then produtoDTO.IdMedidaProduto = dr("medida_produto_id_medida_produto")

                retorno = produtoDTO
            Loop

            Return retorno
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try
    End Function

    Public Function SelecionaProdutoPorDescricao(produtoDTO As ProdutoDTO) As ProdutoDTO
        Dim conexao As New Conexao
        Dim retorno As New ProdutoDTO
        Dim dr As IDataReader
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        If produtoDTO.DescricaoProduto <> Nothing Then
            parram.Add(New MySqlParameter("@Descricao_Produto", produtoDTO.DescricaoProduto))
        End If

        SQL = Nothing
        SQL = SQL + " SELECT * From PRODUTO WHERE descricao_produto = '" & produtoDTO.DescricaoProduto & "'"

        Try
            dr = conexao.ExecuteDataReader(SQL, parram)
            Do While dr.Read
                If Not IsDBNull(dr("id_produto")) Then produtoDTO.IdProduto = dr("id_produto")
                If Not IsDBNull(dr("descricao_produto")) Then produtoDTO.DescricaoProduto = dr("descricao_produto")
                If Not IsDBNull(dr("classe_produto")) Then produtoDTO.ClasseProduto = dr("classe_produto")
                If Not IsDBNull(dr("status_produto")) Then produtoDTO.StatusProduto = dr("status_produto")
                If Not IsDBNull(dr("preco_compra_produto")) Then produtoDTO.PrecoCompraProduto = dr("preco_compra_produto")
                If Not IsDBNull(dr("compra_imposto_produto")) Then produtoDTO.CompraImpostoProduto = dr("compra_imposto_produto")
                If Not IsDBNull(dr("margem_lucro_produto")) Then produtoDTO.MargemLucroProduto = dr("margem_lucro_produto")
                If Not IsDBNull(dr("preco_venda_produto")) Then produtoDTO.PrecoVendaProduto = dr("preco_venda_produto")
                If Not IsDBNull(dr("estoque_disponivel_produto")) Then produtoDTO.EstoqueDisponivelProduto = dr("estoque_disponivel_produto")
                If Not IsDBNull(dr("estoque_min_produto")) Then produtoDTO.EstoqueMinProduto = dr("estoque_min_produto")
                If Not IsDBNull(dr("estoque_max_produto")) Then produtoDTO.EstoqueMaxProduto = dr("estoque_max_produto")
                If Not IsDBNull(dr("estoque_vinculado_produto")) Then produtoDTO.EstoqueVinculadoProduto = dr("estoque_vinculado_produto")
                If Not IsDBNull(dr("estoque_previsto_produto")) Then produtoDTO.EstoquePrevistoProduto = dr("estoque_previsto_produto")
                If Not IsDBNull(dr("descricoes_detalhadas_produto")) Then produtoDTO.DescricoesDetalhadasProduto = dr("descricoes_detalhadas_produto")
                If Not IsDBNull(dr("observacoes_produto")) Then produtoDTO.ObservacoesProduto = dr("observacoes_produto")
                If Not IsDBNull(dr("imagem_produto")) Then produtoDTO.ImagemProduto = dr("imagem_produto")
                If Not IsDBNull(dr("tipo_produto_codigo_tipo_produto")) Then produtoDTO.CodigoTipoProduto = dr("tipo_produto_codigo_tipo_produto")
                If Not IsDBNull(dr("categoria_produto_codigo_categoria_produto")) Then produtoDTO.CodigoCategoriaProduto = dr("categoria_produto_codigo_categoria_produto")
                If Not IsDBNull(dr("medida_produto_id_medida_produto")) Then produtoDTO.IdMedidaProduto = dr("medida_produto_id_medida_produto")

                retorno = produtoDTO
            Loop

            Return retorno
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try
    End Function

    Public Function SelecionaProdutoPorReferencia(referenciaDTO As ReferenciaDTO) As ProdutoDTO
        Dim conexao As New Conexao
        Dim produtoDTO As New ProdutoDTO
        Dim dr As IDataReader
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        If referenciaDTO.CodigoReferenciaProduto <> Nothing Then
            parram.Add(New MySqlParameter("@Codigo_Referencia_Produto", referenciaDTO.CodigoReferenciaProduto))
        End If

        SQL = Nothing
        SQL = SQL + " SELECT * From PRODUTO INNER JOIN REFERENCIA_PRODUTO"
        SQL = SQL + " ON PRODUTO.ID_PRODUTO = PRODUTO_ID_PRODUTO"
        SQL = SQL + " WHERE CODIGO_REFERENCIA_PRODUTO = '" & referenciaDTO.CodigoReferenciaProduto & "'"

        Try
            dr = conexao.ExecuteDataReader(SQL, parram)
            Do While dr.Read
                If Not IsDBNull(dr("id_produto")) Then produtoDTO.IdProduto = dr("id_produto")
                If Not IsDBNull(dr("descricao_produto")) Then produtoDTO.DescricaoProduto = dr("descricao_produto")
                If Not IsDBNull(dr("classe_produto")) Then produtoDTO.ClasseProduto = dr("classe_produto")
                If Not IsDBNull(dr("status_produto")) Then produtoDTO.StatusProduto = dr("status_produto")
                If Not IsDBNull(dr("preco_compra_produto")) Then produtoDTO.PrecoCompraProduto = dr("preco_compra_produto")
                If Not IsDBNull(dr("compra_imposto_produto")) Then produtoDTO.CompraImpostoProduto = dr("compra_imposto_produto")
                If Not IsDBNull(dr("margem_lucro_produto")) Then produtoDTO.MargemLucroProduto = dr("margem_lucro_produto")
                If Not IsDBNull(dr("preco_venda_produto")) Then produtoDTO.PrecoVendaProduto = dr("preco_venda_produto")
                If Not IsDBNull(dr("estoque_disponivel_produto")) Then produtoDTO.EstoqueDisponivelProduto = dr("estoque_disponivel_produto")
                If Not IsDBNull(dr("estoque_min_produto")) Then produtoDTO.EstoqueMinProduto = dr("estoque_min_produto")
                If Not IsDBNull(dr("estoque_max_produto")) Then produtoDTO.EstoqueMaxProduto = dr("estoque_max_produto")
                If Not IsDBNull(dr("estoque_vinculado_produto")) Then produtoDTO.EstoqueVinculadoProduto = dr("estoque_vinculado_produto")
                If Not IsDBNull(dr("estoque_previsto_produto")) Then produtoDTO.EstoquePrevistoProduto = dr("estoque_previsto_produto")
                If Not IsDBNull(dr("descricoes_detalhadas_produto")) Then produtoDTO.DescricoesDetalhadasProduto = dr("descricoes_detalhadas_produto")
                If Not IsDBNull(dr("observacoes_produto")) Then produtoDTO.ObservacoesProduto = dr("observacoes_produto")
                If Not IsDBNull(dr("imagem_produto")) Then produtoDTO.ImagemProduto = dr("imagem_produto")
                If Not IsDBNull(dr("tipo_produto_codigo_tipo_produto")) Then produtoDTO.CodigoTipoProduto = dr("tipo_produto_codigo_tipo_produto")
                If Not IsDBNull(dr("categoria_produto_codigo_categoria_produto")) Then produtoDTO.CodigoCategoriaProduto = dr("categoria_produto_codigo_categoria_produto")
                If Not IsDBNull(dr("medida_produto_id_medida_produto")) Then ProdutoDTO.IdMedidaProduto = dr("medida_produto_id_medida_produto")
            Loop

            Return produtoDTO
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try
    End Function

    Public Function SelecionaTodosProdutos(produtoDTO As ProdutoDTO) As DataTable
        Dim conexao As New Conexao
        Dim dt As New DataTable
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        SQL = Nothing

        If produtoDTO.DescricaoProduto = Nothing And produtoDTO.StatusProduto = Nothing And produtoDTO.CodigoTipoProduto = Nothing And produtoDTO.CodigoCategoriaProduto = Nothing Then
            SQL = SQL + " SELECT * From PRODUTO"
        Else
            SQL = SQL + " SELECT * From PRODUTO WHERE"
        End If

        If produtoDTO.DescricaoProduto <> Nothing Then
            SQL = SQL + " descricao_produto = '" & produtoDTO.DescricaoProduto & "'"
        ElseIf produtoDTO.DescricaoProduto <> Nothing And (produtoDTO.StatusProduto <> Nothing Or produtoDTO.CodigoTipoProduto <> Nothing Or produtoDTO.CodigoCategoriaProduto <> Nothing) Then
            SQL = SQL + " descricao_produto = '" & produtoDTO.DescricaoProduto & "' AND"
        End If

        If produtoDTO.StatusProduto <> Nothing Then
            SQL = SQL + " status_produto = '" & produtoDTO.StatusProduto & "'"
        ElseIf produtoDTO.StatusProduto <> Nothing And (produtoDTO.CodigoTipoProduto <> Nothing Or produtoDTO.CodigoCategoriaProduto <> Nothing) Then
            SQL = SQL + " status_produto = '" & produtoDTO.StatusProduto & "' AND"
        End If

        If produtoDTO.CodigoTipoProduto <> Nothing Then
            SQL = SQL + " tipo_produto_codigo_tipo_produto = '" & produtoDTO.CodigoTipoProduto & "'"
        ElseIf produtoDTO.CodigoTipoProduto <> Nothing And (produtoDTO.CodigoCategoriaProduto <> Nothing) Then
            SQL = SQL + " tipo_produto_codigo_tipo_produto = '" & produtoDTO.CodigoTipoProduto & "' AND"
        End If

        If produtoDTO.CodigoCategoriaProduto <> Nothing Then
            SQL = SQL + " categoria_produto_codigo_categoria_produto = '" & produtoDTO.CodigoCategoriaProduto & "'"
        End If

        Try
            dt = conexao.ExecuteDataTable(SQL)
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try

        Return dt
    End Function

End Class
