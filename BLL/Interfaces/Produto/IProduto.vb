Imports DTO

Public Interface IProduto
    Function InsertProduto(produtoDTO As ProdutoDTO) As ArrayList
    Function UpdateProduto(produtoDTO As ProdutoDTO) As ArrayList
    Function DeleteProduto(produtoDTO As ProdutoDTO) As ArrayList
    Function SelectProduto(produtoDTO As ProdutoDTO) As ProdutoDTO
    Function SelectProdutoByDescricao(produtoDTO As ProdutoDTO) As Boolean
    Function SelectProdutos(produtoDTO As ProdutoDTO) As DataSet
End Interface
