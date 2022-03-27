Imports DTO
Imports MySql.Data.MySqlClient

Public Interface IMedida
    Function InsertMedida(medidaDTO As MedidaDTO) As ArrayList
    Function UpdateMedida(SQL As String, parametros As List(Of MySqlParameter)) As ArrayList
    Function DeleteMedida(SQL As String, parametros As List(Of MySqlParameter)) As Boolean
    Function SelectMedida(medidaDTO As MedidaDTO) As MedidaDTO
    Function SelectMedidas( SQL As String,  parametros As List(Of MySqlParameter)) As DataSet
End Interface
