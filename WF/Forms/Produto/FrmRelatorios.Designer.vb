<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnGerar = New System.Windows.Forms.Button()
        Me.cboPadrao = New System.Windows.Forms.ComboBox()
        Me.lblListarProdutos = New System.Windows.Forms.Label()
        Me.lblAgruparProdutos = New System.Windows.Forms.Label()
        Me.lblSelecaoProdutos = New System.Windows.Forms.Label()
        Me.pnlListarProdutos = New System.Windows.Forms.Panel()
        Me.rdoListaEstoqueVinculado = New System.Windows.Forms.RadioButton()
        Me.rdoListaPrecoVenda = New System.Windows.Forms.RadioButton()
        Me.rdoListaPrecoCompra = New System.Windows.Forms.RadioButton()
        Me.rdoListaEstoquePrevisto = New System.Windows.Forms.RadioButton()
        Me.rdoListaEstoqueDisponivel = New System.Windows.Forms.RadioButton()
        Me.rdoListaCodigo = New System.Windows.Forms.RadioButton()
        Me.rdoListaDescricao = New System.Windows.Forms.RadioButton()
        Me.pnlAgruparProdutos = New System.Windows.Forms.Panel()
        Me.rdoQuebraClasse = New System.Windows.Forms.RadioButton()
        Me.rdoQuebraStatus = New System.Windows.Forms.RadioButton()
        Me.rdoQuebraCategoria = New System.Windows.Forms.RadioButton()
        Me.rdoQuebraTipoProduto = New System.Windows.Forms.RadioButton()
        Me.rdoQuebraFornecedor = New System.Windows.Forms.RadioButton()
        Me.rdoNenhumaQuebra = New System.Windows.Forms.RadioButton()
        Me.pnlSelecaoProdutos = New System.Windows.Forms.Panel()
        Me.rdoProdutoAcabado = New System.Windows.Forms.RadioButton()
        Me.rdoMateriaPrima = New System.Windows.Forms.RadioButton()
        Me.rdoServicos = New System.Windows.Forms.RadioButton()
        Me.rdoProdutoRevenda = New System.Windows.Forms.RadioButton()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboFornecedores = New System.Windows.Forms.ComboBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.cboTipoProduto = New System.Windows.Forms.ComboBox()
        Me.lblCategoriaProduto = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblTipoProduto = New System.Windows.Forms.Label()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlListarProdutos.SuspendLayout()
        Me.pnlAgruparProdutos.SuspendLayout()
        Me.pnlSelecaoProdutos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.BtnVoltar)
        Me.pnlPrincipal.Controls.Add(Me.BtnGerar)
        Me.pnlPrincipal.Controls.Add(Me.cboPadrao)
        Me.pnlPrincipal.Controls.Add(Me.lblListarProdutos)
        Me.pnlPrincipal.Controls.Add(Me.lblAgruparProdutos)
        Me.pnlPrincipal.Controls.Add(Me.lblSelecaoProdutos)
        Me.pnlPrincipal.Controls.Add(Me.pnlListarProdutos)
        Me.pnlPrincipal.Controls.Add(Me.pnlAgruparProdutos)
        Me.pnlPrincipal.Controls.Add(Me.pnlSelecaoProdutos)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(525, 306)
        Me.pnlPrincipal.TabIndex = 0
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(437, 271)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 87
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnGerar
        '
        Me.BtnGerar.Location = New System.Drawing.Point(356, 271)
        Me.BtnGerar.Name = "BtnGerar"
        Me.BtnGerar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGerar.TabIndex = 86
        Me.BtnGerar.Text = "Gerar"
        Me.BtnGerar.UseVisualStyleBackColor = True
        '
        'cboPadrao
        '
        Me.cboPadrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPadrao.FormattingEnabled = True
        Me.cboPadrao.Location = New System.Drawing.Point(12, 273)
        Me.cboPadrao.Name = "cboPadrao"
        Me.cboPadrao.Size = New System.Drawing.Size(121, 21)
        Me.cboPadrao.TabIndex = 82
        '
        'lblListarProdutos
        '
        Me.lblListarProdutos.AutoSize = True
        Me.lblListarProdutos.Location = New System.Drawing.Point(18, 187)
        Me.lblListarProdutos.Name = "lblListarProdutos"
        Me.lblListarProdutos.Size = New System.Drawing.Size(144, 13)
        Me.lblListarProdutos.TabIndex = 81
        Me.lblListarProdutos.Text = "Listar produtos por ordem de:"
        '
        'lblAgruparProdutos
        '
        Me.lblAgruparProdutos.AutoSize = True
        Me.lblAgruparProdutos.Location = New System.Drawing.Point(18, 128)
        Me.lblAgruparProdutos.Name = "lblAgruparProdutos"
        Me.lblAgruparProdutos.Size = New System.Drawing.Size(109, 13)
        Me.lblAgruparProdutos.TabIndex = 80
        Me.lblAgruparProdutos.Text = "Agrupar produtos por:"
        '
        'lblSelecaoProdutos
        '
        Me.lblSelecaoProdutos.AutoSize = True
        Me.lblSelecaoProdutos.Location = New System.Drawing.Point(18, 20)
        Me.lblSelecaoProdutos.Name = "lblSelecaoProdutos"
        Me.lblSelecaoProdutos.Size = New System.Drawing.Size(122, 13)
        Me.lblSelecaoProdutos.TabIndex = 79
        Me.lblSelecaoProdutos.Text = "Selecionar produtos por:"
        '
        'pnlListarProdutos
        '
        Me.pnlListarProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlListarProdutos.Controls.Add(Me.rdoListaEstoqueVinculado)
        Me.pnlListarProdutos.Controls.Add(Me.rdoListaPrecoVenda)
        Me.pnlListarProdutos.Controls.Add(Me.rdoListaPrecoCompra)
        Me.pnlListarProdutos.Controls.Add(Me.rdoListaEstoquePrevisto)
        Me.pnlListarProdutos.Controls.Add(Me.rdoListaEstoqueDisponivel)
        Me.pnlListarProdutos.Controls.Add(Me.rdoListaCodigo)
        Me.pnlListarProdutos.Controls.Add(Me.rdoListaDescricao)
        Me.pnlListarProdutos.Location = New System.Drawing.Point(12, 196)
        Me.pnlListarProdutos.Name = "pnlListarProdutos"
        Me.pnlListarProdutos.Size = New System.Drawing.Size(500, 59)
        Me.pnlListarProdutos.TabIndex = 78
        '
        'rdoListaEstoqueVinculado
        '
        Me.rdoListaEstoqueVinculado.AutoSize = True
        Me.rdoListaEstoqueVinculado.Location = New System.Drawing.Point(232, 33)
        Me.rdoListaEstoqueVinculado.Name = "rdoListaEstoqueVinculado"
        Me.rdoListaEstoqueVinculado.Size = New System.Drawing.Size(114, 17)
        Me.rdoListaEstoqueVinculado.TabIndex = 75
        Me.rdoListaEstoqueVinculado.TabStop = True
        Me.rdoListaEstoqueVinculado.Text = "Estoque Vinculado"
        Me.rdoListaEstoqueVinculado.UseVisualStyleBackColor = True
        '
        'rdoListaPrecoVenda
        '
        Me.rdoListaPrecoVenda.AutoSize = True
        Me.rdoListaPrecoVenda.Location = New System.Drawing.Point(345, 10)
        Me.rdoListaPrecoVenda.Name = "rdoListaPrecoVenda"
        Me.rdoListaPrecoVenda.Size = New System.Drawing.Size(102, 17)
        Me.rdoListaPrecoVenda.TabIndex = 75
        Me.rdoListaPrecoVenda.TabStop = True
        Me.rdoListaPrecoVenda.Text = "Preço de Venda"
        Me.rdoListaPrecoVenda.UseVisualStyleBackColor = True
        '
        'rdoListaPrecoCompra
        '
        Me.rdoListaPrecoCompra.AutoSize = True
        Me.rdoListaPrecoCompra.Location = New System.Drawing.Point(232, 10)
        Me.rdoListaPrecoCompra.Name = "rdoListaPrecoCompra"
        Me.rdoListaPrecoCompra.Size = New System.Drawing.Size(107, 17)
        Me.rdoListaPrecoCompra.TabIndex = 75
        Me.rdoListaPrecoCompra.TabStop = True
        Me.rdoListaPrecoCompra.Text = "Preço de Compra"
        Me.rdoListaPrecoCompra.UseVisualStyleBackColor = True
        '
        'rdoListaEstoquePrevisto
        '
        Me.rdoListaEstoquePrevisto.AutoSize = True
        Me.rdoListaEstoquePrevisto.Location = New System.Drawing.Point(128, 33)
        Me.rdoListaEstoquePrevisto.Name = "rdoListaEstoquePrevisto"
        Me.rdoListaEstoquePrevisto.Size = New System.Drawing.Size(105, 17)
        Me.rdoListaEstoquePrevisto.TabIndex = 75
        Me.rdoListaEstoquePrevisto.TabStop = True
        Me.rdoListaEstoquePrevisto.Text = "Estoque Previsto"
        Me.rdoListaEstoquePrevisto.UseVisualStyleBackColor = True
        '
        'rdoListaEstoqueDisponivel
        '
        Me.rdoListaEstoqueDisponivel.AutoSize = True
        Me.rdoListaEstoqueDisponivel.Location = New System.Drawing.Point(9, 33)
        Me.rdoListaEstoqueDisponivel.Name = "rdoListaEstoqueDisponivel"
        Me.rdoListaEstoqueDisponivel.Size = New System.Drawing.Size(118, 17)
        Me.rdoListaEstoqueDisponivel.TabIndex = 75
        Me.rdoListaEstoqueDisponivel.TabStop = True
        Me.rdoListaEstoqueDisponivel.Text = "Estoque Disponível"
        Me.rdoListaEstoqueDisponivel.UseVisualStyleBackColor = True
        '
        'rdoListaCodigo
        '
        Me.rdoListaCodigo.AutoSize = True
        Me.rdoListaCodigo.Location = New System.Drawing.Point(128, 10)
        Me.rdoListaCodigo.Name = "rdoListaCodigo"
        Me.rdoListaCodigo.Size = New System.Drawing.Size(98, 17)
        Me.rdoListaCodigo.TabIndex = 74
        Me.rdoListaCodigo.TabStop = True
        Me.rdoListaCodigo.Text = "Código Produto"
        Me.rdoListaCodigo.UseVisualStyleBackColor = True
        '
        'rdoListaDescricao
        '
        Me.rdoListaDescricao.AutoSize = True
        Me.rdoListaDescricao.Location = New System.Drawing.Point(9, 10)
        Me.rdoListaDescricao.Name = "rdoListaDescricao"
        Me.rdoListaDescricao.Size = New System.Drawing.Size(113, 17)
        Me.rdoListaDescricao.TabIndex = 73
        Me.rdoListaDescricao.TabStop = True
        Me.rdoListaDescricao.Text = "Descrição Produto"
        Me.rdoListaDescricao.UseVisualStyleBackColor = True
        '
        'pnlAgruparProdutos
        '
        Me.pnlAgruparProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAgruparProdutos.Controls.Add(Me.rdoQuebraClasse)
        Me.pnlAgruparProdutos.Controls.Add(Me.rdoQuebraStatus)
        Me.pnlAgruparProdutos.Controls.Add(Me.rdoQuebraCategoria)
        Me.pnlAgruparProdutos.Controls.Add(Me.rdoQuebraTipoProduto)
        Me.pnlAgruparProdutos.Controls.Add(Me.rdoQuebraFornecedor)
        Me.pnlAgruparProdutos.Controls.Add(Me.rdoNenhumaQuebra)
        Me.pnlAgruparProdutos.Location = New System.Drawing.Point(12, 136)
        Me.pnlAgruparProdutos.Name = "pnlAgruparProdutos"
        Me.pnlAgruparProdutos.Size = New System.Drawing.Size(500, 44)
        Me.pnlAgruparProdutos.TabIndex = 77
        '
        'rdoQuebraClasse
        '
        Me.rdoQuebraClasse.AutoSize = True
        Me.rdoQuebraClasse.Location = New System.Drawing.Point(438, 13)
        Me.rdoQuebraClasse.Name = "rdoQuebraClasse"
        Me.rdoQuebraClasse.Size = New System.Drawing.Size(56, 17)
        Me.rdoQuebraClasse.TabIndex = 71
        Me.rdoQuebraClasse.TabStop = True
        Me.rdoQuebraClasse.Text = "Classe"
        Me.rdoQuebraClasse.UseVisualStyleBackColor = True
        '
        'rdoQuebraStatus
        '
        Me.rdoQuebraStatus.AutoSize = True
        Me.rdoQuebraStatus.Location = New System.Drawing.Point(377, 13)
        Me.rdoQuebraStatus.Name = "rdoQuebraStatus"
        Me.rdoQuebraStatus.Size = New System.Drawing.Size(55, 17)
        Me.rdoQuebraStatus.TabIndex = 70
        Me.rdoQuebraStatus.TabStop = True
        Me.rdoQuebraStatus.Text = "Status"
        Me.rdoQuebraStatus.UseVisualStyleBackColor = True
        '
        'rdoQuebraCategoria
        '
        Me.rdoQuebraCategoria.AutoSize = True
        Me.rdoQuebraCategoria.Location = New System.Drawing.Point(301, 13)
        Me.rdoQuebraCategoria.Name = "rdoQuebraCategoria"
        Me.rdoQuebraCategoria.Size = New System.Drawing.Size(70, 17)
        Me.rdoQuebraCategoria.TabIndex = 69
        Me.rdoQuebraCategoria.TabStop = True
        Me.rdoQuebraCategoria.Text = "Categoria"
        Me.rdoQuebraCategoria.UseVisualStyleBackColor = True
        '
        'rdoQuebraTipoProduto
        '
        Me.rdoQuebraTipoProduto.AutoSize = True
        Me.rdoQuebraTipoProduto.Location = New System.Drawing.Point(209, 13)
        Me.rdoQuebraTipoProduto.Name = "rdoQuebraTipoProduto"
        Me.rdoQuebraTipoProduto.Size = New System.Drawing.Size(86, 17)
        Me.rdoQuebraTipoProduto.TabIndex = 68
        Me.rdoQuebraTipoProduto.TabStop = True
        Me.rdoQuebraTipoProduto.Text = "Tipo Produto"
        Me.rdoQuebraTipoProduto.UseVisualStyleBackColor = True
        '
        'rdoQuebraFornecedor
        '
        Me.rdoQuebraFornecedor.AutoSize = True
        Me.rdoQuebraFornecedor.Location = New System.Drawing.Point(124, 13)
        Me.rdoQuebraFornecedor.Name = "rdoQuebraFornecedor"
        Me.rdoQuebraFornecedor.Size = New System.Drawing.Size(79, 17)
        Me.rdoQuebraFornecedor.TabIndex = 67
        Me.rdoQuebraFornecedor.TabStop = True
        Me.rdoQuebraFornecedor.Text = "Fornecedor"
        Me.rdoQuebraFornecedor.UseVisualStyleBackColor = True
        '
        'rdoNenhumaQuebra
        '
        Me.rdoNenhumaQuebra.AutoSize = True
        Me.rdoNenhumaQuebra.Location = New System.Drawing.Point(9, 13)
        Me.rdoNenhumaQuebra.Name = "rdoNenhumaQuebra"
        Me.rdoNenhumaQuebra.Size = New System.Drawing.Size(109, 17)
        Me.rdoNenhumaQuebra.TabIndex = 66
        Me.rdoNenhumaQuebra.TabStop = True
        Me.rdoNenhumaQuebra.Text = "Nenhuma Quebra"
        Me.rdoNenhumaQuebra.UseVisualStyleBackColor = True
        '
        'pnlSelecaoProdutos
        '
        Me.pnlSelecaoProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSelecaoProdutos.Controls.Add(Me.rdoProdutoAcabado)
        Me.pnlSelecaoProdutos.Controls.Add(Me.rdoMateriaPrima)
        Me.pnlSelecaoProdutos.Controls.Add(Me.rdoServicos)
        Me.pnlSelecaoProdutos.Controls.Add(Me.rdoProdutoRevenda)
        Me.pnlSelecaoProdutos.Controls.Add(Me.cboStatus)
        Me.pnlSelecaoProdutos.Controls.Add(Me.cboFornecedores)
        Me.pnlSelecaoProdutos.Controls.Add(Me.cboCategoria)
        Me.pnlSelecaoProdutos.Controls.Add(Me.cboTipoProduto)
        Me.pnlSelecaoProdutos.Controls.Add(Me.lblCategoriaProduto)
        Me.pnlSelecaoProdutos.Controls.Add(Me.lblStatus)
        Me.pnlSelecaoProdutos.Controls.Add(Me.lblFornecedor)
        Me.pnlSelecaoProdutos.Controls.Add(Me.lblTipoProduto)
        Me.pnlSelecaoProdutos.Location = New System.Drawing.Point(12, 28)
        Me.pnlSelecaoProdutos.Name = "pnlSelecaoProdutos"
        Me.pnlSelecaoProdutos.Size = New System.Drawing.Size(500, 92)
        Me.pnlSelecaoProdutos.TabIndex = 76
        '
        'rdoProdutoAcabado
        '
        Me.rdoProdutoAcabado.AutoSize = True
        Me.rdoProdutoAcabado.Location = New System.Drawing.Point(296, 12)
        Me.rdoProdutoAcabado.Name = "rdoProdutoAcabado"
        Me.rdoProdutoAcabado.Size = New System.Drawing.Size(108, 17)
        Me.rdoProdutoAcabado.TabIndex = 60
        Me.rdoProdutoAcabado.TabStop = True
        Me.rdoProdutoAcabado.Text = "Produto Acabado"
        Me.rdoProdutoAcabado.UseVisualStyleBackColor = True
        '
        'rdoMateriaPrima
        '
        Me.rdoMateriaPrima.AutoSize = True
        Me.rdoMateriaPrima.Location = New System.Drawing.Point(201, 12)
        Me.rdoMateriaPrima.Name = "rdoMateriaPrima"
        Me.rdoMateriaPrima.Size = New System.Drawing.Size(89, 17)
        Me.rdoMateriaPrima.TabIndex = 59
        Me.rdoMateriaPrima.TabStop = True
        Me.rdoMateriaPrima.Text = "Matéria Prima"
        Me.rdoMateriaPrima.UseVisualStyleBackColor = True
        '
        'rdoServicos
        '
        Me.rdoServicos.AutoSize = True
        Me.rdoServicos.Location = New System.Drawing.Point(129, 12)
        Me.rdoServicos.Name = "rdoServicos"
        Me.rdoServicos.Size = New System.Drawing.Size(66, 17)
        Me.rdoServicos.TabIndex = 58
        Me.rdoServicos.TabStop = True
        Me.rdoServicos.Text = "Serviços"
        Me.rdoServicos.UseVisualStyleBackColor = True
        '
        'rdoProdutoRevenda
        '
        Me.rdoProdutoRevenda.AutoSize = True
        Me.rdoProdutoRevenda.Location = New System.Drawing.Point(14, 12)
        Me.rdoProdutoRevenda.Name = "rdoProdutoRevenda"
        Me.rdoProdutoRevenda.Size = New System.Drawing.Size(109, 17)
        Me.rdoProdutoRevenda.TabIndex = 57
        Me.rdoProdutoRevenda.TabStop = True
        Me.rdoProdutoRevenda.Text = "Produto Revenda"
        Me.rdoProdutoRevenda.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(381, 58)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(99, 21)
        Me.cboStatus.TabIndex = 55
        '
        'cboFornecedores
        '
        Me.cboFornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFornecedores.FormattingEnabled = True
        Me.cboFornecedores.Location = New System.Drawing.Point(263, 58)
        Me.cboFornecedores.Name = "cboFornecedores"
        Me.cboFornecedores.Size = New System.Drawing.Size(112, 21)
        Me.cboFornecedores.TabIndex = 56
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(138, 58)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(119, 21)
        Me.cboCategoria.TabIndex = 54
        '
        'cboTipoProduto
        '
        Me.cboTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProduto.FormattingEnabled = True
        Me.cboTipoProduto.Location = New System.Drawing.Point(14, 58)
        Me.cboTipoProduto.Name = "cboTipoProduto"
        Me.cboTipoProduto.Size = New System.Drawing.Size(118, 21)
        Me.cboTipoProduto.TabIndex = 53
        '
        'lblCategoriaProduto
        '
        Me.lblCategoriaProduto.AutoSize = True
        Me.lblCategoriaProduto.Location = New System.Drawing.Point(135, 42)
        Me.lblCategoriaProduto.Name = "lblCategoriaProduto"
        Me.lblCategoriaProduto.Size = New System.Drawing.Size(92, 13)
        Me.lblCategoriaProduto.TabIndex = 50
        Me.lblCategoriaProduto.Text = "Categoria Produto"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(378, 42)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 51
        Me.lblStatus.Text = "Status"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(260, 42)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(61, 13)
        Me.lblFornecedor.TabIndex = 52
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'lblTipoProduto
        '
        Me.lblTipoProduto.AutoSize = True
        Me.lblTipoProduto.Location = New System.Drawing.Point(11, 42)
        Me.lblTipoProduto.Name = "lblTipoProduto"
        Me.lblTipoProduto.Size = New System.Drawing.Size(68, 13)
        Me.lblTipoProduto.TabIndex = 49
        Me.lblTipoProduto.Text = "Tipo Produto"
        '
        'FrmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 306)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.KeyPreview = True
        Me.Name = "FrmRelatorios"
        Me.Text = "FrmRelatorios"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.pnlListarProdutos.ResumeLayout(False)
        Me.pnlListarProdutos.PerformLayout()
        Me.pnlAgruparProdutos.ResumeLayout(False)
        Me.pnlAgruparProdutos.PerformLayout()
        Me.pnlSelecaoProdutos.ResumeLayout(False)
        Me.pnlSelecaoProdutos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents rdoProdutoAcabado As RadioButton
    Friend WithEvents rdoMateriaPrima As RadioButton
    Friend WithEvents rdoServicos As RadioButton
    Friend WithEvents rdoProdutoRevenda As RadioButton
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboFornecedores As ComboBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents cboTipoProduto As ComboBox
    Friend WithEvents lblCategoriaProduto As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblTipoProduto As Label
    Friend WithEvents rdoQuebraClasse As RadioButton
    Friend WithEvents rdoQuebraStatus As RadioButton
    Friend WithEvents rdoQuebraCategoria As RadioButton
    Friend WithEvents rdoQuebraTipoProduto As RadioButton
    Friend WithEvents rdoQuebraFornecedor As RadioButton
    Friend WithEvents rdoNenhumaQuebra As RadioButton
    Friend WithEvents rdoListaEstoqueDisponivel As RadioButton
    Friend WithEvents rdoListaCodigo As RadioButton
    Friend WithEvents rdoListaDescricao As RadioButton
    Friend WithEvents rdoListaEstoqueVinculado As RadioButton
    Friend WithEvents rdoListaEstoquePrevisto As RadioButton
    Friend WithEvents rdoListaPrecoVenda As RadioButton
    Friend WithEvents rdoListaPrecoCompra As RadioButton
    Friend WithEvents pnlListarProdutos As Panel
    Friend WithEvents pnlAgruparProdutos As Panel
    Friend WithEvents pnlSelecaoProdutos As Panel
    Friend WithEvents cboPadrao As ComboBox
    Friend WithEvents lblListarProdutos As Label
    Friend WithEvents lblAgruparProdutos As Label
    Friend WithEvents lblSelecaoProdutos As Label
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnGerar As Button
End Class
