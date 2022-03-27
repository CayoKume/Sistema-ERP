Public Class TipoProdutoDTO

#Region "ATRIBUTOS"
    Private _IdTipoProduto As Integer
    Private _CodigoTipoProduto As String
    Private _CodigoCategoriaProduto As String
#End Region

#Region "PROPIEDADES"
    Public Property IdTipoProduto As Integer
        Get
            Return _IdTipoProduto
        End Get
        Set
            _IdTipoProduto = Value
        End Set
    End Property

    Public Property CodigoTipoProduto As String
        Get
            Return _CodigoTipoProduto
        End Get
        Set
            _CodigoTipoProduto = Value
        End Set
    End Property

    Public Property CodigoCategoriaProduto As String
        Get
            Return _CodigoCategoriaProduto
        End Get
        Set
            _CodigoCategoriaProduto = Value
        End Set
    End Property
#End Region

End Class
