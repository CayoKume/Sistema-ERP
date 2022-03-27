Imports DTO

Public Interface IReferencia
    Function InsertReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
    Function UpdateReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
    Function DeleteReferencia(referenciaDTO As ReferenciaDTO) As ArrayList
    Function SelectReferencia(referenciaDTO As ReferenciaDTO) As DataTable
    Function SelectReferencias(referenciaDTO As ReferenciaDTO) As ArrayList
End Interface
