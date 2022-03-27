Imports DAL
Imports DTO
Imports MySql.Data.MySqlClient

Public Class MedidaBLL
    Implements IMedida
    Public Function InsertMedida(medidaDTO As MedidaDTO) As ArrayList Implements IMedida.InsertMedida
        Dim retorno As ArrayList
        Dim medidaDAL As New MedidaDAL
        Try
            retorno = medidaDAL.IncluiMedida(medidaDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function UpdateMedida(SQL As String, parametros As List(Of MySqlParameter)) As ArrayList Implements IMedida.UpdateMedida
        Dim retorno As ArrayList
        Dim conexao As New Conexao
        Try
            retorno = conexao.ExecuteQuery(SQL, parametros)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conexao.CloseConn()
        End Try

        Return retorno
    End Function

    Public Function DeleteMedida(SQL As String, parametros As List(Of MySqlParameter)) As Boolean Implements IMedida.DeleteMedida
        'Dim retorno As Boolean = True
        'Dim conexao As New Conexao
        'Try
        '    retorno = conexao.ExecuteQuery(SQL, parametros)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'Finally
        '    conexao.CloseConn()
        'End Try

        'Return retorno
    End Function

    Public Function SelectMedida(medidaDTO As MedidaDTO) As MedidaDTO Implements IMedida.SelectMedida
        Dim dt As New DataTable
        Dim medidaDAL As New MedidaDAL
        Try
            medidaDAL.SelecionaMedida(medidaDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return medidaDTO
    End Function

    Public Function SelectMedidas(SQL As String, parametros As List(Of MySqlParameter)) As DataSet Implements IMedida.SelectMedidas
        'Dim ds As New DataSet
        'Dim conexao As New Conexao

        'Try
        '    ds = conexao.ExecuteDataSet(SQL, parametros)
        'Catch ex As Exception
        '    Throw ex
        'Finally
        '    conexao.CloseConn()
        'End Try

        'Return ds
    End Function
End Class
