Imports DTO
Imports BLL
Imports System.IO

Public Class FrmBuscaProduto

#Region "ATRIBUTOS"
    Public DescricaoProduto As String
    Public ReferenciaProduto As String
    Public ClasseProduto As String
    Public FornecedorProduto As String
    Public CategoriaProduto As String
    Public TipoProduto As String
    Public StatusProduto As String
    Public NomeArquivoImagem As String
    Public Imagem() As Byte
    'CHECKBOXES INSTACIADAS NO FrmConfiguraGridView
    Public chkCodigo As New CheckBox With {.Text = "Código Produto", .Location = New Point(10, 10), .Checked = True, .Size = New Size(99, 17)}
    Public chkDescricao As New CheckBox With {.Text = "Descrição Produto", .Location = New Point(10, 33), .Checked = True, .Size = New Size(114, 17)}
    Public chkClasse As New CheckBox With {.Text = "Classe Produto", .Location = New Point(10, 56), .Checked = True, .Size = New Size(97, 17)}
    Public chkStatus As New CheckBox With {.Text = "Status Produto", .Location = New Point(10, 79), .Checked = True, .Size = New Size(96, 17)}
    Public chkPrecoCompra As New CheckBox With {.Text = "Preço de Compra", .Location = New Point(10, 102), .Size = New Size(108, 17)}
    Public chkCompraImposto As New CheckBox With {.Text = "Compra + Impostos", .Location = New Point(10, 125), .Size = New Size(116, 17)}
    Public chkMargemLucro As New CheckBox With {.Text = "Margem de Lucro", .Location = New Point(10, 148), .Size = New Size(109, 17)}
    Public chkPrecoVenda As New CheckBox With {.Text = "Preço de Venda", .Location = New Point(158, 10), .Size = New Size(103, 17)}
    Public chkEstoqueDisponivel As New CheckBox With {.Text = "Estoque Disponível", .Location = New Point(158, 33), .Size = New Size(119, 17)}
    Public chkEstoqueMin As New CheckBox With {.Text = "Estoque Mínimo", .Location = New Point(158, 56), .Size = New Size(103, 17)}
    Public chkEstoqueMax As New CheckBox With {.Text = "Estoque Máximo", .Location = New Point(158, 79), .Size = New Size(104, 17)}
    Public chkEstoqueVinculado As New CheckBox With {.Text = "Estoque Vinculado", .Location = New Point(158, 102), .Size = New Size(115, 17)}
    Public chkEstoquePrevisto As New CheckBox With {.Text = "Estoque Previsto", .Location = New Point(158, 125), .Size = New Size(106, 17)}
    Public chkDescricaoDetalhada As New CheckBox With {.Text = "Descrições Detalhadas", .Location = New Point(158, 148), .Size = New Size(136, 17)}
    Public chkObservacoes As New CheckBox With {.Text = "Observações", .Location = New Point(318, 10), .Size = New Size(89, 17)}
    Public chkImagem As New CheckBox With {.Text = "Imagem", .Location = New Point(318, 33), .Checked = True, .Size = New Size(63, 17)}
    Public chkCategoria As New CheckBox With {.Text = "Categoria", .Location = New Point(318, 56), .Checked = True, .Size = New Size(71, 17)}
    Public chkTipoProduto As New CheckBox With {.Text = "Tipo Produto", .Location = New Point(318, 79), .Checked = True, .Size = New Size(87, 17)}
    Public chkIdMedida As New CheckBox With {.Text = "Código Medida", .Location = New Point(318, 102), .Size = New Size(97, 17)}
#End Region

#Region "BOTÕES"
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        PesquisarProduto()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

    Private Sub btnConfiguracao_Click(sender As Object, e As EventArgs) Handles btnConfiguracao.Click
        InstaciaFrmConfiguraGridView()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimpaCampos()
    End Sub
#End Region

#Region "MÉTODOS"
    Private Sub FrmBuscaProduto_Load(sender As Object, e As EventArgs) Handles Me.Load
        LimpaCampos()
        txtDescricao.Select()
        cboTipoProduto.Items.Clear()
        cboCategoria.Items.Clear()
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
    End Sub

    Private Sub LimpaCampos()
        txtDescricao.Text = Nothing
        txtReferencia.Text = Nothing
        rdoMateriaPrima.Checked = False
        rdoProdutoAcabado.Checked = False
        cboFornecedores.Text = Nothing
        cboCategoria.SelectedIndex = -1
        cboTipoProduto.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        pctboxProduto.Image = Nothing
        dgvBuscaProdutos.DataSource = Nothing
    End Sub

    Private Sub PesquisarProduto()
        TrataVariavel()
        Dim produtoDTO As New ProdutoDTO
        produtoDTO.DescricaoProduto = DescricaoProduto
        produtoDTO.ClasseProduto = ClasseProduto
        produtoDTO.StatusProduto = StatusProduto
        produtoDTO.CodigoTipoProduto = TipoProduto
        produtoDTO.CodigoCategoriaProduto = CategoriaProduto
        produtoDTO.ImagemProduto = Imagem

        Dim produtoBLL As New ProdutoBLL
        Dim dtProdutos As DataTable
        Try
            dtProdutos = produtoBLL.SelectAllProdutos(produtoDTO)
            If dtProdutos IsNot Nothing Then
                dgvBuscaProdutos.DataSource = dtProdutos
                ConfiguraGrid()
            Else
                MessageBox.Show("Produto não cadastrado")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TrataVariavel()
        Dim Vetor() As String = {txtDescricao.Text, txtReferencia.Text, rdoProdutoRevenda.Text, rdoServicos.Text, rdoMateriaPrima.Text, rdoProdutoAcabado.Text, cboFornecedores.Text, cboCategoria.Text, cboTipoProduto.Text, cboStatus.Text}
        Dim NewVetor() As String
        Dim elemento As String
        Dim lista As New List(Of String)()
        Dim fs As FileStream
        Dim br As BinaryReader

        For Each elemento In Vetor
            lista.Add(Trim(elemento.Replace("|", "").Replace("\", "").Replace("/", "").Replace("""", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("<", "").Replace(">", "").Replace(":", "").Replace(";", "").Replace("}", "").Replace("{", "").Replace("_", "").Replace("-", "").Replace("+", "").Replace("=", "")))
        Next
        NewVetor = lista.ToArray()

        If NewVetor(0) <> "" Then
            DescricaoProduto = NewVetor(0)
        Else
            DescricaoProduto = Nothing
        End If
        If NewVetor(1) <> "" Then
            ReferenciaProduto = NewVetor(1)
        Else
            ReferenciaProduto = Nothing
        End If
        If rdoProdutoRevenda.Checked = True Then
            ClasseProduto = NewVetor(2)
        ElseIf rdoServicos.Checked = True Then
            ClasseProduto = NewVetor(3)
        ElseIf rdoMateriaPrima.Checked = True Then
            ClasseProduto = NewVetor(4)
        ElseIf rdoProdutoAcabado.Checked = True Then
            ClasseProduto = NewVetor(5)
        End If
        If NewVetor(6) <> "" Then
            FornecedorProduto = NewVetor(6)
        Else
            FornecedorProduto = Nothing
        End If
        If NewVetor(7) <> "" Then
            CategoriaProduto = NewVetor(7)
        Else
            CategoriaProduto = Nothing
        End If
        If NewVetor(8) <> "" Then
            TipoProduto = NewVetor(8)
        Else
            TipoProduto = Nothing
        End If
        If NewVetor(9) <> "" Then
            StatusProduto = NewVetor(9)
        Else
            StatusProduto = Nothing
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

    Private Sub ConfiguraGrid()
        'ALTERA NOME DAS COLUNAS
        dgvBuscaProdutos.Columns("id_produto").HeaderText = "Código Produto"
        dgvBuscaProdutos.Columns("descricao_produto").HeaderText = "Descrição"
        dgvBuscaProdutos.Columns("classe_produto").HeaderText = "Classe"
        dgvBuscaProdutos.Columns("status_produto").HeaderText = "Status"
        dgvBuscaProdutos.Columns("preco_compra_produto").HeaderText = "Preço Compra"
        dgvBuscaProdutos.Columns("compra_imposto_produto").HeaderText = "Preço Compra + Impostos"
        dgvBuscaProdutos.Columns("margem_lucro_produto").HeaderText = "Margem de Lucro"
        dgvBuscaProdutos.Columns("preco_venda_produto").HeaderText = "Preço Venda"
        dgvBuscaProdutos.Columns("estoque_disponivel_produto").HeaderText = "Estoque Disponível"
        dgvBuscaProdutos.Columns("estoque_min_produto").HeaderText = "Estoque Mínimo"
        dgvBuscaProdutos.Columns("estoque_max_produto").HeaderText = "Estoque Máximo"
        dgvBuscaProdutos.Columns("estoque_vinculado_produto").HeaderText = "Estoque Vinculado"
        dgvBuscaProdutos.Columns("estoque_previsto_produto").HeaderText = "Estoque Previsto"
        dgvBuscaProdutos.Columns("descricoes_detalhadas_produto").HeaderText = "Descrições Detalhadas"
        dgvBuscaProdutos.Columns("observacoes_produto").HeaderText = "Observações"
        dgvBuscaProdutos.Columns("imagem_produto").HeaderText = "Imagem"
        dgvBuscaProdutos.Columns("categoria_produto_codigo_categoria_produto").HeaderText = "Categoria"
        dgvBuscaProdutos.Columns("tipo_produto_codigo_tipo_produto").HeaderText = "Tipo Produto"
        dgvBuscaProdutos.Columns("medida_produto_id_medida_produto").HeaderText = "Id Medida"
        'SETA COLUNAS COMO INVISIVEIS
        dgvBuscaProdutos.Columns(4).Visible = False
        dgvBuscaProdutos.Columns(5).Visible = False
        dgvBuscaProdutos.Columns(6).Visible = False
        dgvBuscaProdutos.Columns(7).Visible = False
        dgvBuscaProdutos.Columns(8).Visible = False
        dgvBuscaProdutos.Columns(9).Visible = False
        dgvBuscaProdutos.Columns(10).Visible = False
        dgvBuscaProdutos.Columns(11).Visible = False
        dgvBuscaProdutos.Columns(12).Visible = False
        dgvBuscaProdutos.Columns(13).Visible = False
        dgvBuscaProdutos.Columns(14).Visible = False
        dgvBuscaProdutos.Columns(18).Visible = False
        'SETA TAMANHO DAS COLUNAS
        dgvBuscaProdutos.Columns(0).Width = 110
        dgvBuscaProdutos.Columns(5).Width = 160
        dgvBuscaProdutos.Columns(6).Width = 115
        dgvBuscaProdutos.Columns(8).Width = 130
        dgvBuscaProdutos.Columns(9).Width = 110
        dgvBuscaProdutos.Columns(10).Width = 110
        dgvBuscaProdutos.Columns(11).Width = 130
        dgvBuscaProdutos.Columns(12).Width = 110
        dgvBuscaProdutos.Columns(13).Width = 150
    End Sub

    Private Sub InstaciaFrmConfiguraGridView()
        FrmConfiguraGridView.Controls.Add(chkCodigo)
        FrmConfiguraGridView.Controls.Add(chkDescricao)
        FrmConfiguraGridView.Controls.Add(chkClasse)
        FrmConfiguraGridView.Controls.Add(chkCodigo)
        FrmConfiguraGridView.Controls.Add(chkStatus)
        FrmConfiguraGridView.Controls.Add(chkPrecoCompra)
        FrmConfiguraGridView.Controls.Add(chkCompraImposto)
        FrmConfiguraGridView.Controls.Add(chkMargemLucro)
        FrmConfiguraGridView.Controls.Add(chkPrecoVenda)
        FrmConfiguraGridView.Controls.Add(chkEstoqueDisponivel)
        FrmConfiguraGridView.Controls.Add(chkEstoqueMin)
        FrmConfiguraGridView.Controls.Add(chkEstoqueMax)
        FrmConfiguraGridView.Controls.Add(chkEstoqueVinculado)
        FrmConfiguraGridView.Controls.Add(chkEstoquePrevisto)
        FrmConfiguraGridView.Controls.Add(chkDescricaoDetalhada)
        FrmConfiguraGridView.Controls.Add(chkObservacoes)
        FrmConfiguraGridView.Controls.Add(chkImagem)
        FrmConfiguraGridView.Controls.Add(chkCategoria)
        FrmConfiguraGridView.Controls.Add(chkTipoProduto)
        FrmConfiguraGridView.Controls.Add(chkIdMedida)

        FrmConfiguraGridView.Show()
    End Sub

    Private Sub dgvBuscaProdutos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBuscaProdutos.RowHeaderMouseClick
        pctboxProduto.Image = Nothing
        If dgvBuscaProdutos.CurrentRow.Cells(15).Value IsNot DBNull.Value Then
            Dim ImgStream As MemoryStream = New MemoryStream(CType(dgvBuscaProdutos.CurrentRow.Cells(15).Value, Byte()))
            Dim bm As New Bitmap(ImgStream)

            Dim largura As Double = bm.Width
            Dim altura As Double = bm.Height

            Dim proporcao As Double = 156 / largura
            Dim novaAltura As Double = (proporcao * altura)

            pctboxProduto.Image = RedimensionarImagem(bm, New Size(156, novaAltura))
        End If
    End Sub

    Private Sub dgvBuscaProdutos_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBuscaProdutos.RowHeaderMouseDoubleClick
        Dim produtoDTO As New ProdutoDTO
        produtoDTO.IdProduto = dgvBuscaProdutos.CurrentRow.Cells(0).Value
        produtoDTO.DescricaoProduto = dgvBuscaProdutos.CurrentRow.Cells(1).Value
        produtoDTO.ClasseProduto = dgvBuscaProdutos.CurrentRow.Cells(2).Value
        If dgvBuscaProdutos.CurrentRow.Cells(3).Value IsNot DBNull.Value Then
            produtoDTO.StatusProduto = dgvBuscaProdutos.CurrentRow.Cells(3).Value
        Else
            produtoDTO.StatusProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(4).Value IsNot DBNull.Value Then
            produtoDTO.PrecoCompraProduto = dgvBuscaProdutos.CurrentRow.Cells(4).Value
        Else
            produtoDTO.PrecoCompraProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(5).Value IsNot DBNull.Value Then
            produtoDTO.CompraImpostoProduto = dgvBuscaProdutos.CurrentRow.Cells(5).Value
        Else
            produtoDTO.CompraImpostoProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(6).Value IsNot DBNull.Value Then
            produtoDTO.MargemLucroProduto = dgvBuscaProdutos.CurrentRow.Cells(6).Value
        Else
            produtoDTO.MargemLucroProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(7).Value IsNot DBNull.Value Then
            produtoDTO.PrecoVendaProduto = dgvBuscaProdutos.CurrentRow.Cells(7).Value
        Else
            produtoDTO.PrecoVendaProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(8).Value IsNot DBNull.Value Then
            produtoDTO.EstoqueDisponivelProduto = dgvBuscaProdutos.CurrentRow.Cells(8).Value
        Else
            produtoDTO.EstoqueDisponivelProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(9).Value IsNot DBNull.Value Then
            produtoDTO.EstoqueMinProduto = dgvBuscaProdutos.CurrentRow.Cells(9).Value
        Else
            produtoDTO.EstoqueMinProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(10).Value IsNot DBNull.Value Then
            produtoDTO.EstoqueMaxProduto = dgvBuscaProdutos.CurrentRow.Cells(10).Value
        Else
            produtoDTO.EstoqueMaxProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(11).Value IsNot DBNull.Value Then
            produtoDTO.EstoqueVinculadoProduto = dgvBuscaProdutos.CurrentRow.Cells(11).Value
        Else
            produtoDTO.EstoqueVinculadoProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(12).Value IsNot DBNull.Value Then
            produtoDTO.EstoquePrevistoProduto = dgvBuscaProdutos.CurrentRow.Cells(12).Value
        Else
            produtoDTO.EstoquePrevistoProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(13).Value IsNot DBNull.Value Then
            produtoDTO.DescricoesDetalhadasProduto = dgvBuscaProdutos.CurrentRow.Cells(13).Value
        Else
            produtoDTO.DescricoesDetalhadasProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(14).Value IsNot DBNull.Value Then
            produtoDTO.ObservacoesProduto = dgvBuscaProdutos.CurrentRow.Cells(14).Value
        Else
            produtoDTO.ObservacoesProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(15).Value IsNot DBNull.Value Then
            produtoDTO.ImagemProduto = dgvBuscaProdutos.CurrentRow.Cells(15).Value
        Else
            produtoDTO.ImagemProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(16).Value IsNot DBNull.Value Then
            produtoDTO.CodigoCategoriaProduto = dgvBuscaProdutos.CurrentRow.Cells(16).Value
        Else
            produtoDTO.CodigoCategoriaProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(17).Value IsNot DBNull.Value Then
            produtoDTO.CodigoTipoProduto = dgvBuscaProdutos.CurrentRow.Cells(17).Value
        Else
            produtoDTO.CodigoTipoProduto = Nothing
        End If
        If dgvBuscaProdutos.CurrentRow.Cells(18).Value IsNot DBNull.Value Then
            produtoDTO.IdMedidaProduto = dgvBuscaProdutos.CurrentRow.Cells(18).Value
        Else
            produtoDTO.IdMedidaProduto = Nothing
        End If

        FrmProdutos.txtCodigo.Text = produtoDTO.IdProduto
        FrmProdutos.txtDescricao.Text = produtoDTO.DescricaoProduto
        If produtoDTO.ClasseProduto = "Matéria Prima" Then
            FrmProdutos.rdoMateriaPrima.Checked = True
        ElseIf produtoDTO.ClasseProduto = "Produto Acabado" Then
            FrmProdutos.rdoProdutoAcabado.Checked = True
        End If
        FrmProdutos.cboStatus.SelectedIndex = cboStatus.FindStringExact(produtoDTO.StatusProduto)
        FrmProdutos.txtPrecoCompra.Text = produtoDTO.PrecoCompraProduto
        FrmProdutos.txtCompraImposto.Text = produtoDTO.CompraImpostoProduto
        FrmProdutos.cboMargemLucro.Text = produtoDTO.MargemLucroProduto
        FrmProdutos.txtPrecoVenda.Text = produtoDTO.PrecoVendaProduto
        FrmProdutos.txtEstoqueDisponivel.Text = produtoDTO.EstoqueDisponivelProduto
        FrmProdutos.txtEstoqueMin.Text = produtoDTO.EstoqueMinProduto
        FrmProdutos.txtEstoqueMax.Text = produtoDTO.EstoqueMaxProduto
        FrmProdutos.txtEstoqueVinculado.Text = produtoDTO.EstoqueVinculadoProduto
        FrmProdutos.txtEstoquePrevisto.Text = produtoDTO.EstoquePrevistoProduto
        FrmProdutos.txtDescricaoDetalhada.Text = produtoDTO.DescricoesDetalhadasProduto
        FrmProdutos.txtObservacoes.Text = produtoDTO.ObservacoesProduto
        If produtoDTO.ImagemProduto IsNot Nothing Then
            Dim ImgStream As MemoryStream = New MemoryStream(CType(produtoDTO.ImagemProduto, Byte()))
            Dim bm As New Bitmap(ImgStream)

            Dim largura As Double = bm.Width
            Dim altura As Double = bm.Height

            Dim proporcao As Double = 156 / largura
            Dim novaAltura As Double = (proporcao * altura)

            FrmProdutos.pctboxProduto.Image = RedimensionarImagem(bm, New Size(156, novaAltura))
        End If
        FrmProdutos.cboTipoProduto.SelectedIndex = cboTipoProduto.FindStringExact(produtoDTO.CodigoTipoProduto)
        FrmProdutos.cboCategoria.SelectedIndex = cboCategoria.FindStringExact(produtoDTO.CodigoCategoriaProduto)
        FrmProdutos.IdMedidaProduto = produtoDTO.IdMedidaProduto

        Dim medidaDTO As New MedidaDTO
        medidaDTO.IdProdutoProduto = FrmProdutos.IdMedidaProduto
        Dim medidaBLL As New MedidaBLL
        medidaBLL.SelectMedida(medidaDTO)
        FrmProdutos.txtUnidade.Text = medidaDTO.UnidadeMedidaEstoqueProduto
        FrmProdutos.txtAltura.Text = medidaDTO.AlturaProduto
        FrmProdutos.txtLargura.Text = medidaDTO.LarguraProduto
        FrmProdutos.txtComprimento.Text = medidaDTO.ComprimentoProduto
        FrmProdutos.txtPeso.Text = medidaDTO.PesoUnitarioProduto

        Me.Close()
    End Sub

    'REDIMENSIONA IMAGEM PARA A PICTUREBOX
    Private Function RedimensionarImagem(imagem As Image, tamanho As Size) As Image
        Return New Bitmap(imagem, tamanho)
    End Function

    Private Sub FrmBuscaProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

End Class