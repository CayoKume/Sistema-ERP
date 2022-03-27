Imports DAL
Imports DTO

Public Class TipoProdutoBLL
    Implements ITipoProduto

    Public Function InsertTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList Implements ITipoProduto.InsertTipoProduto
        Dim retorno As ArrayList
        Dim TipoProdutoDAL As New TipoProdutoDAL

        Try
            retorno = TipoProdutoDAL.IncluiTipoProduto(tipoprodutoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function UpdateTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList Implements ITipoProduto.UpdateTipoProduto
        Throw New NotImplementedException()
    End Function

    Public Function DeleteTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList Implements ITipoProduto.DeleteTipoProduto
        Dim retorno As ArrayList
        Dim TipoProdutoDAL As New TipoProdutoDAL

        Try
            retorno = TipoProdutoDAL.DeletaTipoProduto(tipoprodutoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function SelectTipoProduto() As DataTable Implements ITipoProduto.SelectTipoProduto
        Dim dt As New DataTable
        Dim tipoprodutoDAL As New TipoProdutoDAL
        Try
            dt = tipoprodutoDAL.SelecionaTipoProduto()
        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    Public Function SelectTipoProdutos(tipoprodutoDTO As TipoProdutoDTO) As ArrayList Implements ITipoProduto.SelectTipoProdutos
        Dim retorno As ArrayList
        Dim TipoProdutoDAL As New TipoProdutoDAL

        Try
            retorno = TipoProdutoDAL.SelecionaTipoProdutos(tipoprodutoDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function
End Class
