Imports DAL
Imports DTO

Public Class ProdutoBLL
    Implements IProduto

    Public Function InsertProduto(produtoDTO As ProdutoDTO) As ArrayList Implements IProduto.InsertProduto
        Dim retorno As ArrayList
        Dim ProdutoDAL As New ProdutoDAL
        Try
            retorno = ProdutoDAL.IncluiProduto(produtoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function UpdateProduto(produtoDTO As ProdutoDTO) As ArrayList Implements IProduto.UpdateProduto
        Dim retorno As ArrayList
        Dim ProdutoDAL As New ProdutoDAL
        Try
            retorno = ProdutoDAL.AlteraProduto(produtoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function DeleteProduto(produtoDTO As ProdutoDTO) As ArrayList Implements IProduto.DeleteProduto
        Dim retorno As ArrayList
        Dim ProdutoDAL As New ProdutoDAL
        Try
            retorno = ProdutoDAL.DeletaProduto(produtoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function SelectProdutoById(produtoDTO As ProdutoDTO) As ProdutoDTO Implements IProduto.SelectProdutoById
        Dim ProdutoDAL As New ProdutoDAL
        Try
            ProdutoDAL.SelecionaProdutoPorId(produtoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return produtoDTO
    End Function

    Public Function SelectProdutoByDescricao(produtoDTO As ProdutoDTO) As ProdutoDTO Implements IProduto.SelectProdutoByDescricao
        Dim ProdutoDAL As New ProdutoDAL
        Try
            ProdutoDAL.SelecionaProdutoPorDescricao(produtoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return produtoDTO
    End Function

    Public Function SelectProdutoByReferencia(referenciaDTO As ReferenciaDTO) As ProdutoDTO Implements IProduto.SelectProdutoByReferencia
        Dim ProdutoDAL As New ProdutoDAL
        Dim produtoDTO As New ProdutoDTO
        Try
            produtoDTO = ProdutoDAL.SelecionaProdutoPorReferencia(referenciaDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return produtoDTO
    End Function

    Public Function SelectAllProdutos(produtoDTO As ProdutoDTO) As DataTable Implements IProduto.SelectAllProdutos
        Dim produtoDAL As New ProdutoDAL
        Dim dt As New DataTable
        Try
            dt = produtoDAL.SelecionaTodosProdutos(produtoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return dt
    End Function

End Class
