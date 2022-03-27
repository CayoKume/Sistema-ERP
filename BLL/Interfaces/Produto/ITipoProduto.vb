Imports DTO

Public Interface ITipoProduto
    Function InsertTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList
    Function UpdateTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList
    Function DeleteTipoProduto(tipoprodutoDTO As TipoProdutoDTO) As ArrayList
    Function SelectTipoProduto() As DataTable
    Function SelectTipoProdutos(tipoprodutoDTO As TipoProdutoDTO) As ArrayList
End Interface
