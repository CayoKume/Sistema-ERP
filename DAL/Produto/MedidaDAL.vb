Imports DTO
Imports MySql.Data.MySqlClient

Public Class MedidaDAL
    Public Function IncluiMedida(medidaDTO As MedidaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            If medidaDTO.UnidadeMedidaCompraProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Unidade_Medida_Compra_Produto", medidaDTO.UnidadeMedidaCompraProduto))
            Else
                parram.Add(New MySqlParameter("@Unidade_Medida_Compra_Produto", DBNull.Value))
            End If
            If medidaDTO.UnidadeMedidaEstoqueProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Unidade_Medida_Estoque_Produto", medidaDTO.UnidadeMedidaEstoqueProduto))
            Else
                parram.Add(New MySqlParameter("@Unidade_Medida_Estoque_Produto", DBNull.Value))
            End If
            If medidaDTO.QtdeCaixaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Qtde_Caixa_Produto", medidaDTO.QtdeCaixaProduto))
            Else
                parram.Add(New MySqlParameter("@Qtde_Caixa_Produto", DBNull.Value))
            End If
            If medidaDTO.TaxaConversaoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Taxa_Conversao_Produto", medidaDTO.TaxaConversaoProduto))
            Else
                parram.Add(New MySqlParameter("@Taxa_Conversao_Produto", DBNull.Value))
            End If
            If medidaDTO.PesoUnitarioProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Peso_Unitario_Produto", medidaDTO.PesoUnitarioProduto))
            Else
                parram.Add(New MySqlParameter("@Peso_Unitario_Produto", DBNull.Value))
            End If
            If medidaDTO.KiloCaixaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Kilo_Caixa_Produto", medidaDTO.KiloCaixaProduto))
            Else
                parram.Add(New MySqlParameter("@Kilo_Caixa_Produto", DBNull.Value))
            End If
            If medidaDTO.AlturaProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Altura_Produto", medidaDTO.AlturaProduto))
            Else
                parram.Add(New MySqlParameter("@Altura_Produto", DBNull.Value))
            End If
            If medidaDTO.LarguraProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Largura_Produto", medidaDTO.LarguraProduto))
            Else
                parram.Add(New MySqlParameter("@Largura_Produto", DBNull.Value))
            End If
            If medidaDTO.ComprimentoProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Comprimento_Produto", medidaDTO.ComprimentoProduto))
            Else
                parram.Add(New MySqlParameter("@Comprimento_Produto", DBNull.Value))
            End If
            If medidaDTO.VolumeProduto <> Nothing Then
                parram.Add(New MySqlParameter("@Volume_Produto", medidaDTO.VolumeProduto))
            Else
                parram.Add(New MySqlParameter("@Volume_Produto", DBNull.Value))
            End If

            SQL = SQL + "INSERT INTO MEDIDA_PRODUTO (unidade_medida_compra, unidade_medida_estoque, qtde_caixa, taxa_conversao, peso_unitario, kilo_caixa, altura_produto,"
            SQL = SQL + " largura_produto, comprimento_produto, volume_produto)"
            SQL = SQL + "VALUES (@Unidade_Medida_Compra_Produto, @Unidade_Medida_Estoque_Produto, @Qtde_Caixa_Produto, @Taxa_Conversao_Produto, @Peso_Unitario_Produto,"
            SQL = SQL + " @Kilo_Caixa_Produto, @Altura_Produto, @Largura_Produto, @Comprimento_Produto, @Volume_Produto)"

            retorno = conexao.ExecuteQuery(SQL, parram)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function AlteraMedida(medidaDTO As MedidaDTO) As ArrayList
        Dim conexao As New Conexao
        Dim retorno As ArrayList
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        Try
            SQL = Nothing
            SQL = SQL + " UPDATE MEDIDA_PRODUTO SET unidade_medida_compra = '" & medidaDTO.UnidadeMedidaCompraProduto & "', unidade_medida_estoque = '" & medidaDTO.UnidadeMedidaEstoqueProduto & "', qtde_caixa = '" & medidaDTO.QtdeCaixaProduto & "',"
            SQL = SQL + " taxa_conversao = '" & medidaDTO.TaxaConversaoProduto & "', peso_unitario = '" & medidaDTO.PesoUnitarioProduto & "', kilo_caixa = '" & medidaDTO.KiloCaixaProduto & "', altura_produto = '" & medidaDTO.AlturaProduto & "',"
            SQL = SQL + " largura_produto = '" & medidaDTO.LarguraProduto & "', comprimento_produto = '" & medidaDTO.ComprimentoProduto & "', volume_produto = '" & medidaDTO.VolumeProduto & "'"
            SQL = SQL + " WHERE id_medida_produto = '" & medidaDTO.IdProdutoProduto & "'"

            retorno = conexao.ExecuteQuery(SQL, parram)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function SelecionaMedida(medidaDTO As MedidaDTO) As MedidaDTO
        Dim conexao As New Conexao
        Dim retorno As New MedidaDTO
        Dim dr As IDataReader
        Dim parram As New List(Of MySqlParameter)
        Dim SQL As String

        If medidaDTO.IdProdutoProduto <> Nothing Then
            parram.Add(New MySqlParameter("@Id_Produto", medidaDTO.IdProdutoProduto))
        End If

        SQL = Nothing
        SQL = SQL + " SELECT * From MEDIDA_PRODUTO WHERE id_medida_produto = '" & medidaDTO.IdProdutoProduto & "'"

        Try
            dr = conexao.ExecuteDataReader(SQL, parram)
            Do While dr.Read
                If Not IsDBNull(dr("id_medida_produto")) Then medidaDTO.IdMedida = dr("id_medida_produto")
                If Not IsDBNull(dr("unidade_medida_compra")) Then medidaDTO.UnidadeMedidaCompraProduto = dr("unidade_medida_compra")
                If Not IsDBNull(dr("unidade_medida_estoque")) Then medidaDTO.UnidadeMedidaEstoqueProduto = dr("unidade_medida_estoque")
                If Not IsDBNull(dr("qtde_caixa")) Then medidaDTO.QtdeCaixaProduto = dr("qtde_caixa")
                If Not IsDBNull(dr("taxa_conversao")) Then medidaDTO.TaxaConversaoProduto = dr("taxa_conversao")
                If Not IsDBNull(dr("peso_unitario")) Then medidaDTO.PesoUnitarioProduto = dr("peso_unitario")
                If Not IsDBNull(dr("kilo_caixa")) Then medidaDTO.KiloCaixaProduto = dr("kilo_caixa")
                If Not IsDBNull(dr("altura_produto")) Then medidaDTO.AlturaProduto = dr("altura_produto")
                If Not IsDBNull(dr("largura_produto")) Then medidaDTO.LarguraProduto = dr("largura_produto")
                If Not IsDBNull(dr("comprimento_produto")) Then medidaDTO.ComprimentoProduto = dr("comprimento_produto")
                If Not IsDBNull(dr("volume_produto")) Then medidaDTO.VolumeProduto = dr("volume_Produto")

                retorno = medidaDTO
            Loop

            Return retorno
        Catch ex As Exception
            Throw ex
        Finally
            conexao.CloseConn()
        End Try
    End Function
End Class
