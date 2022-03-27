Imports DAL
Imports DTO

Public Class CategoriaBLL
    Implements ICategoria

    Public Function InsertCategoria(Categoria As CategoriaDTO) As ArrayList Implements ICategoria.InsertCategoria
        Dim retorno As ArrayList
        Dim CategoriaDAL As New CategoriaDAL
        Try
            retorno = CategoriaDAL.IncluiCategoria(Categoria)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function UpdateCategoria(Categoria As CategoriaDTO) As ArrayList Implements ICategoria.UpdateCategoria
        Throw New NotImplementedException()
    End Function

    Public Function DeleteCategoria(Categoria As CategoriaDTO) As ArrayList Implements ICategoria.DeleteCategoria
        Dim retorno As ArrayList
        Dim CategoriaDAL As New CategoriaDAL
        Try
            retorno = CategoriaDAL.DeletaCategoria(Categoria)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function SelectCategoria() As DataTable Implements ICategoria.SelectCategoria
        Dim dt As New DataTable
        Dim CategoriaDAL As New CategoriaDAL
        Try
            dt = CategoriaDAL.SelecionaCategoria()
        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    Public Function SelectCategorias(Categoria As CategoriaDTO) As ArrayList Implements ICategoria.SelectCategorias
        Dim retorno As ArrayList
        Dim CategoriaDAL As New CategoriaDAL
        Try
            retorno = CategoriaDAL.SelecionaCategorias(Categoria)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function
End Class
