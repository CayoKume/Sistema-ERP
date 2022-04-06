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

#Region "MÉTODOS"
    Public Sub New()

    End Sub

    Public Sub New(_IdReferenciaProduto As Integer, _CodigoReferenciaProduto As String, _CatalagoReferencia As String, _IdProduto As Integer)
        Me.IdReferenciaProduto = _IdReferenciaProduto
        Me.CodigoReferenciaProduto = _CodigoReferenciaProduto
        Me.CatalagoReferencia = _CatalagoReferencia
        Me.IdProduto = _IdProduto
    End Sub
#End Region

End Class
