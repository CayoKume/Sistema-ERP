Public Class MedidaDTO

#Region "ATRIBUTOS"
    Private _IdMedida As Integer
    Private _UnidadeMedidaCompraProduto As String
    Private _UnidadeMedidaEstoqueProduto As String
    Private _QtdeCaixaProduto As Decimal
    Private _TaxaConversaoProduto As Decimal
    Private _PesoUnitarioProduto As Decimal
    Private _KiloCaixaProduto As Decimal
    Private _AlturaProduto As Decimal
    Private _LarguraProduto As Decimal
    Private _ComprimentoProduto As Decimal
    Private _VolumeProduto As Decimal
    Private _IdProdutoProduto As Integer
#End Region

#Region "PROPIEDADES"
    Public Property IdMedida As Integer
        Get
            Return _IdMedida
        End Get
        Set
            _IdMedida = Value
        End Set
    End Property

    Public Property UnidadeMedidaCompraProduto As String
        Get
            Return _UnidadeMedidaCompraProduto
        End Get
        Set
            _UnidadeMedidaCompraProduto = Value
        End Set
    End Property

    Public Property UnidadeMedidaEstoqueProduto As String
        Get
            Return _UnidadeMedidaEstoqueProduto
        End Get
        Set
            _UnidadeMedidaEstoqueProduto = Value
        End Set
    End Property

    Public Property QtdeCaixaProduto As Decimal
        Get
            Return _QtdeCaixaProduto
        End Get
        Set
            _QtdeCaixaProduto = Value
        End Set
    End Property

    Public Property TaxaConversaoProduto As Decimal
        Get
            Return _TaxaConversaoProduto
        End Get
        Set
            _TaxaConversaoProduto = Value
        End Set
    End Property

    Public Property PesoUnitarioProduto As Decimal
        Get
            Return _PesoUnitarioProduto
        End Get
        Set
            _PesoUnitarioProduto = Value
        End Set
    End Property

    Public Property KiloCaixaProduto As Decimal
        Get
            Return _KiloCaixaProduto
        End Get
        Set
            _KiloCaixaProduto = Value
        End Set
    End Property

    Public Property AlturaProduto As Decimal
        Get
            Return _AlturaProduto
        End Get
        Set
            _AlturaProduto = Value
        End Set
    End Property

    Public Property LarguraProduto As Decimal
        Get
            Return _LarguraProduto
        End Get
        Set
            _LarguraProduto = Value
        End Set
    End Property

    Public Property ComprimentoProduto As Decimal
        Get
            Return _ComprimentoProduto
        End Get
        Set
            _ComprimentoProduto = Value
        End Set
    End Property

    Public Property VolumeProduto As Decimal
        Get
            Return _VolumeProduto
        End Get
        Set
            _VolumeProduto = Value
        End Set
    End Property

    Public Property IdProdutoProduto As Integer
        Get
            Return _IdProdutoProduto
        End Get
        Set
            _IdProdutoProduto = Value
        End Set
    End Property
#End Region

End Class
