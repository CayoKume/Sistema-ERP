Imports DTO

Public Interface IProduto
    Function InsertProduto(produtoDTO As ProdutoDTO) As ArrayList
    Function UpdateProduto(produtoDTO As ProdutoDTO) As ArrayList
    Function DeleteProduto(produtoDTO As ProdutoDTO) As ArrayList
    Function SelectProdutoById(produtoDTO As ProdutoDTO) As ProdutoDTO
    Function SelectProdutoByDescricao(produtoDTO As ProdutoDTO) As ProdutoDTO
    Function SelectProdutoByReferencia(referenciaDTO As ReferenciaDTO) As ProdutoDTO
    Function SelectAllProdutos(produtoDTO As ProdutoDTO) As DataTable
End Interface
