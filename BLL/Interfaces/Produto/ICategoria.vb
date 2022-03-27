Imports DTO
Imports MySql.Data.MySqlClient

Public Interface ICategoria
    Function InsertCategoria(categoriaDTO As CategoriaDTO) As ArrayList
    Function UpdateCategoria(categoriaDTO As CategoriaDTO) As ArrayList
    Function DeleteCategoria(categoriaDTO As CategoriaDTO) As ArrayList
    Function SelectCategoria() As DataTable
    Function SelectCategorias(categoriaDTO As CategoriaDTO) As ArrayList
End Interface
