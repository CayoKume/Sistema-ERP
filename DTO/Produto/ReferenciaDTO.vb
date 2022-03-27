Public Class ReferenciaDTO

#Region "ATRIBUTOS"
    Private _IdReferenciaProduto As Integer
    Private _CodigoReferenciaProduto As String
    Private _CatalagoReferencia As String
    Private _IdProduto As Integer
#End Region

#Region "PROPIEDADES"
    Public Property IdReferenciaProduto As Integer
        Get
            Return _IdReferenciaProduto
        End Get
        Set
            _IdReferenciaProduto = Value
        End Set
    End Property

    Public Property CodigoReferenciaProduto As String
        Get
            Return _CodigoReferenciaProduto
        End Get
        Set
            _CodigoReferenciaProduto = Value
        End Set
    End Property

    Public Property CatalagoReferencia As String
        Get
            Return _CatalagoReferencia
        End Get
        Set
            _CatalagoReferencia = Value
        End Set
    End Property

    Public Property IdProduto As Integer
        Get
            Return _IdProduto
        End Get
        Set
            _IdProduto = Value
        End Set
    End Property
#End Region

End Class
