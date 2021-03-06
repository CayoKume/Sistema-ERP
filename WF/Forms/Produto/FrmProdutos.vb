Imports DTO
Imports BLL
Imports System.IO

Public Class FrmProdutos

#Region "ATRIBUTOS"
    Public IdProduto As Integer
    Public DescricaoProduto As String
    Public ReferenciaProduto As String
    Public ClasseProduto As String
    Public FornecedorProduto As String
    Public CategoriaProduto As String
    Public TipoProduto As String
    Public StatusProduto As String
    Public PrecoCompraProduto As Decimal
    Public CompraImpostoProduto As Decimal
    Public MargemLucroProduto As Decimal
    Public PrecoVendaProduto As Decimal
    Public EstoqueDisponivelProduto As Decimal
    Public EstoqueMinProduto As Decimal
    Public EstoqueMaxProduto As Decimal
    Public EstoqueVinculadoProduto As Decimal
    Public EstoquePrevistoProduto As Decimal
    Public DescricaoDetalhadaProduto As String
    Public ObservacoesProduto As String
    Public IdMedidaProduto As Integer
    Public NomeArquivoImagem As String
    Public Imagem() As Byte
#End Region

#Region "BOTÕES"

#Region "MENU-STRIP"
    Private Sub ServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem.Click
        Me.Close()
        FrmServicos.Show()
    End Sub

    Private Sub RefernciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefernciasToolStripMenuItem.Click
        FrmReferencias.Show()
    End Sub

    Private Sub MedidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedidasToolStripMenuItem.Click
        FrmMedidas.Show()
    End Sub

    Private Sub ImpostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpostosToolStripMenuItem.Click
        FrmImpostos.Show()
    End Sub

    Private Sub RequisiçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequisiçõesToolStripMenuItem.Click
        FrmRequisicoes.Show()
    End Sub
#End Region

#Region "FORMULÁRIO"
    Private Sub BtnFornecedores_Click(sender As Object, e As EventArgs) Handles BtnFornecedores.Click
        FrmFornecedoresMultiplos.Show()
    End Sub

    Private Sub BtnTipoProduto_Click(sender As Object, e As EventArgs) Handles BtnTipoProduto.Click
        FrmConfiguraCbo.lboCategoria.Text = "Tipo do Produto"
        FrmConfiguraCbo.Show()
    End Sub

    Private Sub BtnCategoria_Click(sender As Object, e As EventArgs) Handles BtnCategoria.Click
        FrmConfiguraCbo.lboCategoria.Text = "Categoria"
        FrmConfiguraCbo.Show()
    End Sub

    Private Sub BtnStatus_Click(sender As Object, e As EventArgs) Handles BtnStatus.Click
        FrmConfiguraCbo.lboCategoria.Text = "Status"
        FrmConfiguraCbo.Show()
    End Sub

    Private Sub BtnMargemLucro_Click(sender As Object, e As EventArgs) Handles BtnMargemLucro.Click
        FrmConfiguraCbo.lboCategoria.Text = "% Margem Lucro"
        FrmConfiguraCbo.Show()
    End Sub

    Private Sub BtnVinculado_Click(sender As Object, e As EventArgs) Handles BtnVinculado.Click
        FrmEstoqueVinculado.Show()
    End Sub

    Private Sub BtnPrevisto_Click(sender As Object, e As EventArgs) Handles BtnPrevisto.Click
        FrmEstoquePrevisto.Show()
    End Sub
#End Region

#Region "INFERIORES"
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        SalvarProduto()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        ExcluirProduto()
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        If txtCodigo.Text <> Nothing Or txtDescricao.Text <> Nothing Or txtReferencia.Text <> Nothing Then
            PesquisarProduto()
        Else
            FrmBuscaProduto.Show()
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimpaCampos()
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
        FrmPrincipal.Show()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        If txtCodigo.Text <> Nothing And txtDescricao.Text <> Nothing And txtReferencia.Text <> Nothing Then
            TrataVariavel()
            Dim produtoDTO As New ProdutoDTO
            produtoDTO.IdProduto = IdProduto
            produtoDTO.DescricaoProduto = DescricaoProduto
            produtoDTO.ClasseProduto = ClasseProduto
            produtoDTO.StatusProduto = StatusProduto
            produtoDTO.PrecoCompraProduto = PrecoCompraProduto
            produtoDTO.CompraImpostoProduto = CompraImpostoProduto
            produtoDTO.MargemLucroProduto = MargemLucroProduto
            produtoDTO.PrecoVendaProduto = PrecoVendaProduto
            produtoDTO.EstoqueDisponivelProduto = EstoqueDisponivelProduto
            produtoDTO.EstoqueMinProduto = EstoqueMinProduto
            produtoDTO.EstoqueMaxProduto = EstoqueMaxProduto
            produtoDTO.EstoqueVinculadoProduto = EstoqueVinculadoProduto
            produtoDTO.EstoquePrevistoProduto = EstoquePrevistoProduto
            produtoDTO.DescricoesDetalhadasProduto = DescricaoDetalhadaProduto
            produtoDTO.ObservacoesProduto = ObservacoesProduto
            produtoDTO.CodigoTipoProduto = TipoProduto
            produtoDTO.CodigoCategoriaProduto = CategoriaProduto
            produtoDTO.ImagemProduto = Imagem
            FrmExibeProduto.Show(ProdutoDTO)
        End If
    End Sub
#End Region

#End Region

#Region "MÉTODOS"
    Private Sub FrmProdutos_Load(sender As Object, e As EventArgs) Handles Me.Load
        LimpaCampos()
        txtDescricao.Select()
        cboTipoProduto.Items.Clear()
        cboCategoria.Items.Clear()
        cboMargemLucro.Items.Clear()
        cboStatus.Items.Clear()
        NomeArquivoImagem = Nothing

        'CARREGA VALORES DOS COMBOBOXES cboCategoria E cboTipoProduto, CADASTRADOS NO BANCO DE DADOS
        Dim categoriaBLL As New CategoriaBLL
        Try
            Dim dtCategoria As DataTable = categoriaBLL.SelectCategoria()

            For i = 0 To dtCategoria.Rows.Count - 1
                cboCategoria.Items.Add(dtCategoria.Rows(i).Item(0).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim tipoprodutoBLL As New TipoProdutoBLL
        Try
            Dim dtTipo As DataTable = tipoprodutoBLL.SelectTipoProduto()

            For i = 0 To dtTipo.Rows.Count - 1
                cboTipoProduto.Items.Add(dtTipo.Rows(i).Item(0).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'CARREGA VALORES DOS COMBOBOXES cboStatus E cboMargemLucro, CADASTRADOS NA CONFIGURAÇÃO DE STATUS My.Settings
        For Each item In My.Settings.ConfiguraCboStatus
            cboStatus.Items.Add(item)
        Next

        For Each item In My.Settings.ConfiguraCboMargemLucro
            cboMargemLucro.Items.Add(item)
        Next
    End Sub

    Private Sub PesquisarProduto()
        TrataVariavel()
        Dim produtoDTO As New ProdutoDTO
        Dim referenciaDTO As New ReferenciaDTO

        If IdProduto <> Nothing And DescricaoProduto = Nothing And ReferenciaProduto = Nothing Then
            'PESQUISA PRODUTO POR ID
            produtoDTO.IdProduto = IdProduto
            Dim produtoBLL As New ProdutoBLL
            Try
                If produtoBLL.SelectProdutoById(produtoDTO) IsNot Nothing Then
                    If produtoDTO.DescricaoProduto <> Nothing Then
                        SelecionaProduto(produtoDTO)
                    End If
                Else
                    MessageBox.Show("Produto não cadastrado")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf IdProduto = Nothing And DescricaoProduto <> Nothing And ReferenciaProduto = Nothing Then
            'PESQUISA PRODUTO POR DESCRIÇÃO
            produtoDTO.DescricaoProduto = DescricaoProduto
            Dim produtoBLL As New ProdutoBLL
            Try
                If produtoBLL.SelectProdutoByDescricao(produtoDTO) IsNot Nothing Then
                    If produtoDTO.DescricaoProduto <> Nothing Then
                        SelecionaProduto(produtoDTO)
                    End If
                Else
                    MessageBox.Show("Produto não cadastrado")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf IdProduto = Nothing And DescricaoProduto = Nothing And ReferenciaProduto <> Nothing Then
            'PESQUISA PRODUTO POR REFERENCIA
            referenciaDTO.CodigoReferenciaProduto = ReferenciaProduto
            Dim produtoBLL As New ProdutoBLL
            Try
                produtoDTO = produtoBLL.SelectProdutoByReferencia(referenciaDTO)
                If produtoDTO.DescricaoProduto <> Nothing Then
                    SelecionaProduto(produtoDTO)
                Else
                    MessageBox.Show("Produto não cadastrado")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SalvarProduto()
        TrataVariavel()
        Dim produtoDTO As New ProdutoDTO
        produtoDTO.IdProduto = IdProduto
        produtoDTO.DescricaoProduto = DescricaoProduto
        produtoDTO.ClasseProduto = ClasseProduto
        produtoDTO.StatusProduto = StatusProduto
        produtoDTO.PrecoCompraProduto = PrecoCompraProduto
        produtoDTO.CompraImpostoProduto = CompraImpostoProduto
        produtoDTO.MargemLucroProduto = MargemLucroProduto
        produtoDTO.PrecoVendaProduto = PrecoVendaProduto
        produtoDTO.EstoqueDisponivelProduto = EstoqueDisponivelProduto
        produtoDTO.EstoqueMinProduto = EstoqueMinProduto
        produtoDTO.EstoqueMaxProduto = EstoqueMaxProduto
        produtoDTO.EstoqueVinculadoProduto = EstoqueVinculadoProduto
        produtoDTO.EstoquePrevistoProduto = EstoquePrevistoProduto
        produtoDTO.DescricoesDetalhadasProduto = DescricaoDetalhadaProduto
        produtoDTO.ObservacoesProduto = ObservacoesProduto
        produtoDTO.CodigoTipoProduto = TipoProduto
        produtoDTO.CodigoCategoriaProduto = CategoriaProduto
        produtoDTO.ImagemProduto = Imagem
        If Trim(txtDescricao.Text) <> Nothing And Trim(txtCodigo.Text) = Nothing Then
            Dim medidaBLL As New MedidaBLL
            Dim medidaDTO As New MedidaDTO
            Try
                Dim NewVetor() As String
                Dim elemento As String
                Dim lista As New List(Of String)()

                For Each elemento In medidaBLL.InsertMedida(medidaDTO)
                    lista.Add(elemento)
                Next
                NewVetor = lista.ToArray()

                If NewVetor(1) = True Then
                    IdMedidaProduto = NewVetor(0)
                    MessageBox.Show("Medida cadastrada com sucesso!")
                Else
                    MessageBox.Show("Problema ao cadastrar medida!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            ProdutoDTO.IdMedidaProduto = IdMedidaProduto

            Dim produtoBLL As New ProdutoBLL
            Try
                If produtoBLL.InsertProduto(ProdutoDTO)(1) = True Then
                    MessageBox.Show("Produto cadastrado com sucesso!")
                Else
                    MessageBox.Show("Problema ao cadastrar produto !")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf Trim(txtDescricao.Text) <> Nothing And Trim(txtCodigo.Text) <> Nothing Then
            Dim produtoBLL As New ProdutoBLL
            Try
                If produtoBLL.UpdateProduto(ProdutoDTO)(1) = True Then
                    MessageBox.Show("Produto atualizado com sucesso!")
                Else
                    MessageBox.Show("Problema ao atualizar produto!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            FrmBuscaProduto.Show() 'porque você colocou isso aqui
        End If
        LimpaCampos()
    End Sub

    Private Sub ExcluirProduto()
        TrataVariavel()
        Dim produtoDTO As New ProdutoDTO
        If IdProduto <> Nothing Then
            produtoDTO.IdProduto = IdProduto
        End If
        Dim produtoBLL As New ProdutoBLL
        Try
            If produtoBLL.DeleteProduto(produtoDTO)(1) = True Then
                MessageBox.Show("Produto excluido com sucesso!")
            Else
                MessageBox.Show("Problema ao excluir produto!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LimpaCampos()
    End Sub

    Private Sub SelecionaProduto(produtoDTO)
        txtCodigo.Text = produtoDTO.IdProduto
        txtDescricao.Text = produtoDTO.DescricaoProduto
        If produtoDTO.ClasseProduto = "Matéria Prima" Then
            rdoMateriaPrima.Checked = True
        ElseIf produtoDTO.ClasseProduto = "Produto Acabado" Then
            rdoProdutoAcabado.Checked = True
        End If
        cboStatus.SelectedIndex = cboStatus.FindStringExact(produtoDTO.StatusProduto)
        txtPrecoCompra.Text = CDec(produtoDTO.PrecoCompraProduto).ToString("R$ #,###.00")
        txtCompraImposto.Text = CDec(produtoDTO.CompraImpostoProduto).ToString("R$ #,###.00")
        cboMargemLucro.Text = produtoDTO.MargemLucroProduto
        txtPrecoVenda.Text = CDec(produtoDTO.PrecoVendaProduto).ToString("R$ #,###.00")
        txtEstoqueDisponivel.Text = produtoDTO.EstoqueDisponivelProduto
        txtEstoqueMin.Text = produtoDTO.EstoqueMinProduto
        txtEstoqueMax.Text = produtoDTO.EstoqueMaxProduto
        txtEstoqueVinculado.Text = produtoDTO.EstoqueVinculadoProduto
        txtEstoquePrevisto.Text = produtoDTO.EstoquePrevistoProduto
        txtDescricaoDetalhada.Text = produtoDTO.DescricoesDetalhadasProduto
        txtObservacoes.Text = produtoDTO.ObservacoesProduto
        If produtoDTO.ImagemProduto IsNot Nothing Then
            Dim ImgStream As MemoryStream = New MemoryStream(CType(produtoDTO.ImagemProduto, Byte()))
            Dim bm As New Bitmap(ImgStream)

            Dim largura As Double = bm.Width
            Dim altura As Double = bm.Height

            Dim proporcao As Double = 156 / largura
            Dim novaAltura As Double = (proporcao * altura)

            pctboxProduto.Image = RedimensionarImagem(bm, New Size(156, novaAltura))
        End If
        cboTipoProduto.SelectedIndex = cboTipoProduto.FindStringExact(produtoDTO.CodigoTipoProduto)
        cboCategoria.SelectedIndex = cboCategoria.FindStringExact(produtoDTO.CodigoCategoriaProduto)
        IdMedidaProduto = produtoDTO.IdMedidaProduto

        Dim medidaDTO As New MedidaDTO
        medidaDTO.IdProdutoProduto = IdMedidaProduto
        Dim medidaBLL As New MedidaBLL
        medidaBLL.SelectMedida(medidaDTO)
        txtUnidade.Text = medidaDTO.UnidadeMedidaEstoqueProduto
        txtAltura.Text = medidaDTO.AlturaProduto
        txtLargura.Text = medidaDTO.LarguraProduto
        txtComprimento.Text = medidaDTO.ComprimentoProduto
        txtPeso.Text = medidaDTO.PesoUnitarioProduto
    End Sub

    Private Sub LimpaCampos()
        txtCodigo.Text = Nothing
        txtDescricao.Text = Nothing
        txtReferencia.Text = Nothing
        rdoMateriaPrima.Checked = False
        rdoProdutoAcabado.Checked = False
        cboFornecedores.Text = Nothing
        txtPrecoCompra.Text = Nothing
        txtCompraImposto.Text = Nothing
        cboMargemLucro.SelectedIndex = -1 'SELECIONA INDEX EM BRANCO NO COMBOBOX cboMargemLucro
        txtPrecoVenda.Text = Nothing
        txtEstoqueDisponivel.Text = Nothing
        txtEstoqueMin.Text = Nothing
        txtEstoqueMax.Text = Nothing
        txtEstoqueVinculado.Text = Nothing
        txtEstoquePrevisto.Text = Nothing
        txtUnidade.Text = Nothing
        txtLargura.Text = Nothing
        txtAltura.Text = Nothing
        txtComprimento.Text = Nothing
        txtPeso.Text = Nothing
        txtDescricaoDetalhada.Text = Nothing
        txtObservacoes.Text = Nothing
        cboCategoria.SelectedIndex = -1
        cboTipoProduto.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        pctboxProduto.Image = Nothing
    End Sub

    Private Sub TrataVariavel()
        Dim Vetor() As String = {txtCodigo.Text, txtDescricao.Text, txtReferencia.Text, rdoMateriaPrima.Text, rdoProdutoAcabado.Text, cboFornecedores.Text, cboCategoria.Text, cboTipoProduto.Text, cboStatus.Text, txtPrecoCompra.Text, txtCompraImposto.Text, cboMargemLucro.Text, txtPrecoVenda.Text, txtEstoqueDisponivel.Text, txtEstoqueMin.Text, txtEstoqueMax.Text, txtEstoqueVinculado.Text, txtEstoquePrevisto.Text, txtDescricaoDetalhada.Text, txtObservacoes.Text}
        Dim NewVetor() As String
        Dim elemento As String
        Dim lista As New List(Of String)()
        Dim fs As FileStream
        Dim br As BinaryReader

        For Each elemento In Vetor
            lista.Add(Trim(elemento.Replace("|", "").Replace("\", "").Replace("/", "").Replace("""", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("R$", "").Replace("%", "").Replace("¨", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("<", "").Replace(">", "").Replace(":", "").Replace(";", "").Replace("}", "").Replace("{", "").Replace("_", "").Replace("-", "").Replace("+", "").Replace("=", "").Replace("$", "").Replace(",00", "")))
        Next
        NewVetor = lista.ToArray()

        If NewVetor(0) <> "" Then
            IdProduto = Integer.Parse(NewVetor(0))
        End If
        If NewVetor(1) <> "" Then
            DescricaoProduto = NewVetor(1)
        Else
            DescricaoProduto = Nothing
        End If
        If NewVetor(2) <> "" Then
            ReferenciaProduto = NewVetor(2)
        Else
            ReferenciaProduto = Nothing
        End If
        If rdoMateriaPrima.Checked = False And rdoProdutoAcabado.Checked = False Then
            ClasseProduto = "Produto Revenda"
        ElseIf rdoMateriaPrima.Checked = True Then
            ClasseProduto = NewVetor(3)
        ElseIf rdoProdutoAcabado.Checked = True Then
            ClasseProduto = NewVetor(4)
        End If
        If NewVetor(5) <> "" Then
            FornecedorProduto = NewVetor(5)
        Else
            FornecedorProduto = Nothing
        End If
        If NewVetor(6) <> "" Then
            CategoriaProduto = NewVetor(6)
        Else
            CategoriaProduto = Nothing
        End If
        If NewVetor(7) <> "" Then
            TipoProduto = NewVetor(7)
        Else
            TipoProduto = Nothing
        End If
        If NewVetor(8) <> "" Then
            StatusProduto = NewVetor(8)
        Else
            StatusProduto = Nothing
        End If
        If NewVetor(9) <> "" Then
            PrecoCompraProduto = Decimal.Parse(NewVetor(9))
        Else
            PrecoCompraProduto = Nothing
        End If
        If NewVetor(10) <> "" Then
            CompraImpostoProduto = Decimal.Parse(NewVetor(10))
        Else
            CompraImpostoProduto = Nothing
        End If
        If NewVetor(11) <> "" Then
            MargemLucroProduto = Decimal.Parse(NewVetor(11))
        Else
            MargemLucroProduto = Nothing
        End If
        If NewVetor(12) <> "" Then
            PrecoVendaProduto = Decimal.Parse(NewVetor(12))
        Else
            PrecoVendaProduto = Nothing
        End If
        If NewVetor(13) <> "" Then
            EstoqueDisponivelProduto = Decimal.Parse(NewVetor(13))
        Else
            EstoqueDisponivelProduto = Nothing
        End If
        If NewVetor(14) <> "" Then
            EstoqueMinProduto = Decimal.Parse(NewVetor(14))
        Else
            EstoqueMinProduto = Nothing
        End If
        If NewVetor(15) <> "" Then
            EstoqueMaxProduto = Decimal.Parse(NewVetor(15))
        Else
            EstoqueMaxProduto = Nothing
        End If
        If NewVetor(16) <> "" Then
            EstoqueVinculadoProduto = Decimal.Parse(NewVetor(16))
        Else
            EstoqueVinculadoProduto = Nothing
        End If
        If NewVetor(17) <> "" Then
            EstoquePrevistoProduto = Decimal.Parse(NewVetor(17))
        Else
            EstoquePrevistoProduto = Nothing
        End If
        If NewVetor(18) <> "" Then
            DescricaoDetalhadaProduto = NewVetor(18)
        Else
            DescricaoDetalhadaProduto = Nothing
        End If
        If NewVetor(19) <> "" Then
            ObservacoesProduto = NewVetor(19)
        Else
            ObservacoesProduto = Nothing
        End If
        If NomeArquivoImagem <> "" Then
            fs = New FileStream(NomeArquivoImagem, FileMode.Open, FileAccess.Read)
            br = New BinaryReader(fs)
            Imagem = br.ReadBytes(CType(fs.Length, Integer))
            br.Close()
            fs.Close()
        Else
            Imagem = Nothing
        End If
    End Sub

    'CARREGA NOVAMENTE VALORES DOS COMBOBOXES cboTipoProduto E cboCategoria, CADASTRADOS NO BANCO DE DADOS, PARA QUE CADA VEZ QUE HAJA ALTERAÇÃO DOS VALORES
    'OS ITENS SEJAM ATUALIZADOS
    Private Sub cboCategoria_DropDown(sender As Object, e As EventArgs) Handles cboCategoria.DropDown
        cboCategoria.Items.Clear()
        Dim categoriaBLL As New CategoriaBLL
        Try
            Dim dtCategoria As DataTable = categoriaBLL.SelectCategoria()

            For i = 0 To dtCategoria.Rows.Count - 1
                cboCategoria.Items.Add(dtCategoria.Rows(i).Item(0).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboTipoProduto_DropDown(sender As Object, e As EventArgs) Handles cboTipoProduto.DropDown
        cboTipoProduto.Items.Clear()
        Dim tipoprodutoBLL As New TipoProdutoBLL
        Try
            Dim dtTipo As DataTable = tipoprodutoBLL.SelectTipoProduto()

            For i = 0 To dtTipo.Rows.Count - 1
                cboTipoProduto.Items.Add(dtTipo.Rows(i).Item(0).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CARREGA VALORES DOS COMBOBOXES cboMargemLucro E cboStatus, CADASTRADOS NA CONFIGURAÇÃO DE STATUS My.Settings, PARA QUE CADA VEZ QUE HAJA ALTERAÇÃO DOS
    'VALORES OS ITENS SEJAM ATUALIZADOS
    Private Sub cboStatus_DropDown(sender As Object, e As EventArgs) Handles cboStatus.DropDown
        cboStatus.Items.Clear()
        For Each item In My.Settings.ConfiguraCboStatus
            cboStatus.Items.Add(item)
        Next
    End Sub

    Private Sub cboMargemLucro_DropDown(sender As Object, e As EventArgs) Handles cboMargemLucro.DropDown
        cboMargemLucro.Items.Clear()
        For Each item In My.Settings.ConfiguraCboMargemLucro
            cboMargemLucro.Items.Add(item)
        Next
    End Sub

    'VALIDA TEXTBOXES PARA SOMENTE ACEITAR NÚMEROS OU LETRAS, E USA O MESMO MÉTODO PARA ACIONAR PESQUISA PRODUTO PELA TECLA ENTER NOS CAMPOS txtCodigo, txtDescricao E txtReferencia
    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        ElseIf e.KeyChar = Chr(13) Then
            If txtCodigo.Text <> Nothing Or txtDescricao.Text <> Nothing Or txtReferencia.Text <> Nothing Then
                PesquisarProduto()
            Else
                FrmBuscaProduto.Show()
            End If
        End If
    End Sub

    Private Sub txtPrecoCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoCompra.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCompraImposto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompraImposto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecoVenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoVenda.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstoqueDisponivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstoqueDisponivel.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstoqueMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstoqueMin.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstoqueMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstoqueMax.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstoqueVinculado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstoqueVinculado.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstoquePrevisto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstoquePrevisto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescricao.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtCodigo.Text <> Nothing Or txtDescricao.Text <> Nothing Or txtReferencia.Text <> Nothing Then
                PesquisarProduto()
            Else
                FrmBuscaProduto.Show()
            End If
        End If
    End Sub

    Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtCodigo.Text <> Nothing Or txtDescricao.Text <> Nothing Or txtReferencia.Text <> Nothing Then
                PesquisarProduto()
            Else
                FrmBuscaProduto.Show()
            End If
        End If
    End Sub

    'SETA TECLA ESC PARA SAIR DO FORMULÁRIO
    Private Sub FrmProdutos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            FrmPrincipal.Show()
        End If
    End Sub

    'CARREGA IMAGEM PARA A PICTUREBOX
    Private Sub pctboxProduto_Click(sender As Object, e As EventArgs) Handles pctboxProduto.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "jpeg|*.jpg"

        If openFile.ShowDialog() = DialogResult.OK Then
            NomeArquivoImagem = openFile.FileName
            Dim imagem = Image.FromFile(openFile.FileName)

            Dim largura As Double = imagem.Width
            Dim altura As Double = imagem.Height

            Dim proporcao As Double = 156 / largura
            Dim novaAltura As Double = (proporcao * altura)

            pctboxProduto.Image = RedimensionarImagem(imagem, New Size(156, novaAltura))
        End If
    End Sub

    'REDIMENSIONA IMAGEM PARA A PICTUREBOX
    Private Function RedimensionarImagem(imagem As Image, tamanho As Size) As Image
        Return New Bitmap(imagem, tamanho)
    End Function
#End Region

End Class