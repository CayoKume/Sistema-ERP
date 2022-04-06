Imports DTO

Public Interface IReferencia
    Function InsertReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
    Function UpdateReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
    Function DeleteReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
    Function SelectReferencia(referenciaDTO As ReferenciaDTO) As List(Of ReferenciaDTO)
    Function SelectReferencias(referenciaDTO As ReferenciaDTO) As DataTable
End Interface
