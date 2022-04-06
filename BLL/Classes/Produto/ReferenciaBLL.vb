Imports DTO
Imports DAL

Public Class ReferenciaBLL
    Implements IReferencia

    Public Function InsertReferencia(referenciaDTO As ReferenciaDTO) As ArrayList Implements IReferencia.InsertReferencia
        Dim retorno As ArrayList
        Dim referenciaDAL As New ReferenciaDAL
        Try
            retorno = referenciaDAL.IncluiReferencia(referenciaDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function UpdateReferencia(referenciaDTO As ReferenciaDTO) As ArrayList Implements IReferencia.UpdateReferencia
        Throw New NotImplementedException()
    End Function

    Public Function DeleteReferencia(referenciaDTO As ReferenciaDTO) As ArrayList Implements IReferencia.DeleteReferencia
        Dim retorno As ArrayList
        Dim referenciaDAL As New ReferenciaDAL
        Try
            retorno = referenciaDAL.DeletaReferencia(referenciaDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

    Public Function SelectReferencias(referenciaDTO As ReferenciaDTO) As DataTable Implements IReferencia.SelectReferencias
        Dim dt As New DataTable
        Dim referenciaDAL As New ReferenciaDAL
        Try
            dt = referenciaDAL.SelecionaReferencias(referenciaDTO)
        Catch ex As Exception
            Throw ex
        End Try

        Return dt
    End Function

    Public Function SelectReferencia(referenciaDTO As ReferenciaDTO) As List(Of ReferenciaDTO) Implements IReferencia.SelectReferencia
        Dim retorno As List(Of ReferenciaDTO)
        Dim referenciaDAL As New ReferenciaDAL
        Try
            retorno = referenciaDAL.SelecionaReferencia(referenciaDTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return retorno
    End Function

End Class
