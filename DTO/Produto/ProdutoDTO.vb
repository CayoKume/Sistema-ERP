Public Class ProdutoDTO

#Region "ATRIBUTOS"
    Private _IdProduto As Integer
    Private _DescricaoProduto As String
    Private _ClasseProduto As String
    Private _StatusProduto As String
    Private _PrecoCompraProduto As Decimal
    Private _CompraImpostoProduto As Decimal
    Private _MargemLucroProduto As Decimal
    Private _PrecoVendaProduto As Decimal
    Private _EstoqueDisponivelProduto As Decimal
    Private _EstoqueMinProduto As Decimal
    Private _EstoqueMaxProduto As Decimal
    Private _EstoqueVinculadoProduto As Decimal
    Private _EstoquePrevistoProduto As Decimal
    Private _ObservacoesProduto As String
    Private _DescricoesDetalhadasProduto As String
    Private _CodigoTipoProduto As String
    Private _CodigoCategoriaProduto As String
    Private _IdMedidaProduto As String
    Private _ImagemProduto As Byte()
#End Region

#Region "PROPIEDADES"
    Public Property IdProduto As Integer
        Get
            Return _IdProduto
        End Get
        Set
            _IdProduto = Value
        End Set
    End Property

    Public Property DescricaoProduto As String
        Get
            Return _DescricaoProduto
        End Get
        Set
            _DescricaoProduto = Value
        End Set
    End Property

    Public Property ClasseProduto As String
        Get
            Return _ClasseProduto
        End Get
        Set
            _ClasseProduto = Value
        End Set
    End Property

    Public Property StatusProduto As String
        Get
            Return _StatusProduto
        End Get
        Set
            _StatusProduto = Value
        End Set
    End Property

    Public Property PrecoCompraProduto As Decimal
        Get
            Return _PrecoCompraProduto
        End Get
        Set
            _PrecoCompraProduto = Value
        End Set
    End Property

    Public Property CompraImpostoProduto As Decimal
        Get
            Return _CompraImpostoProduto
        End Get
        Set
            _CompraImpostoProduto = Value
        End Set
    End Property

    Public Property MargemLucroProduto As Decimal
        Get
            Return _MargemLucroProduto
        End Get
        Set
            _MargemLucroProduto = Value
        End Set
    End Property

    Public Property PrecoVendaProduto As Decimal
        Get
            Return _PrecoVendaProduto
        End Get
        Set
            _PrecoVendaProduto = Value
        End Set
    End Property

    Public Property EstoqueDisponivelProduto As Decimal
        Get
            Return _EstoqueDisponivelProduto
        End Get
        Set
            _EstoqueDisponivelProduto = Value
        End Set
    End Property

    Public Property EstoqueMinProduto As Decimal
        Get
            Return _EstoqueMinProduto
        End Get
        Set
            _EstoqueMinProduto = Value
        End Set
    End Property

    Public Property EstoqueMaxProduto As Decimal
        Get
            Return _EstoqueMaxProduto
        End Get
        Set
            _EstoqueMaxProduto = Value
        End Set
    End Property

    Public Property EstoqueVinculadoProduto As Decimal
        Get
            Return _EstoqueVinculadoProduto
        End Get
        Set
            _EstoqueVinculadoProduto = Value
        End Set
    End Property

    Public Property EstoquePrevistoProduto As Decimal
        Get
            Return _EstoquePrevistoProduto
        End Get
        Set
            _EstoquePrevistoProduto = Value
        End Set
    End Property

    Public Property DescricoesDetalhadasProduto As String
        Get
            Return _DescricoesDetalhadasProduto
        End Get
        Set
            _DescricoesDetalhadasProduto = Value
        End Set
    End Property

    Public Property ObservacoesProduto As String
        Get
            Return _ObservacoesProduto
        End Get
        Set
            _ObservacoesProduto = Value
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

    Public Property IdMedidaProduto As String
        Get
            Return _IdMedidaProduto
        End Get
        Set
            _IdMedidaProduto = Value
        End Set
    End Property

    Public Property ImagemProduto As Byte()
        Get
            Return _ImagemProduto
        End Get
        Set
            _ImagemProduto = Value
        End Set
    End Property
#End Region

End Class
