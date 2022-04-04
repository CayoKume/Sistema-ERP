<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.pnlFormularios = New System.Windows.Forms.Panel()
        Me.lboFoto = New System.Windows.Forms.Label()
        Me.lboValores = New System.Windows.Forms.Label()
        Me.lboEstoque = New System.Windows.Forms.Label()
        Me.lboMedidas = New System.Windows.Forms.Label()
        Me.lboDescricoes = New System.Windows.Forms.Label()
        Me.pnlDescricoes = New System.Windows.Forms.Panel()
        Me.lboObservacoes = New System.Windows.Forms.Label()
        Me.lboDescricaoDetalhada = New System.Windows.Forms.Label()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.txtDescricaoDetalhada = New System.Windows.Forms.TextBox()
        Me.pnlMedidas = New System.Windows.Forms.Panel()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lboPeso = New System.Windows.Forms.Label()
        Me.txtComprimento = New System.Windows.Forms.TextBox()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.lboDimensoes = New System.Windows.Forms.Label()
        Me.lboUnidade = New System.Windows.Forms.Label()
        Me.pnlEstoque = New System.Windows.Forms.Panel()
        Me.BtnVinculado = New System.Windows.Forms.Button()
        Me.BtnPrevisto = New System.Windows.Forms.Button()
        Me.txtEstoquePrevisto = New System.Windows.Forms.TextBox()
        Me.txtEstoqueDisponivel = New System.Windows.Forms.TextBox()
        Me.txtEstoqueMin = New System.Windows.Forms.TextBox()
        Me.txtEstoqueMax = New System.Windows.Forms.TextBox()
        Me.txtEstoqueVinculado = New System.Windows.Forms.TextBox()
        Me.lboEstoqueMax = New System.Windows.Forms.Label()
        Me.lboEstoqueMin = New System.Windows.Forms.Label()
        Me.lboDisponivel = New System.Windows.Forms.Label()
        Me.pnlValores = New System.Windows.Forms.Panel()
        Me.BtnMargemLucro = New System.Windows.Forms.Button()
        Me.cboMargemLucro = New System.Windows.Forms.ComboBox()
        Me.txtCompraImposto = New System.Windows.Forms.TextBox()
        Me.lboCompraImposto = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.txtPrecoCompra = New System.Windows.Forms.TextBox()
        Me.lboPrecoVenda = New System.Windows.Forms.Label()
        Me.lboPrecoCompra = New System.Windows.Forms.Label()
        Me.pnlProduto = New System.Windows.Forms.Panel()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.BtnFornecedores = New System.Windows.Forms.Button()
        Me.BtnStatus = New System.Windows.Forms.Button()
        Me.BtnCategoria = New System.Windows.Forms.Button()
        Me.BtnTipoProduto = New System.Windows.Forms.Button()
        Me.rdoProdutoAcabado = New System.Windows.Forms.RadioButton()
        Me.rdoMateriaPrima = New System.Windows.Forms.RadioButton()
        Me.cboFornecedores = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.cboTipoProduto = New System.Windows.Forms.ComboBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lboReferencia = New System.Windows.Forms.Label()
        Me.lboDescricao = New System.Windows.Forms.Label()
        Me.lboCodigo = New System.Windows.Forms.Label()
        Me.pctboxProduto = New System.Windows.Forms.PictureBox()
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefernciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelacionamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivosFixosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlFormularios.SuspendLayout()
        Me.pnlDescricoes.SuspendLayout()
        Me.pnlMedidas.SuspendLayout()
        Me.pnlEstoque.SuspendLayout()
        Me.pnlValores.SuspendLayout()
        Me.pnlProduto.SuspendLayout()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotoes.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.pnlFormularios)
        Me.pnlPrincipal.Controls.Add(Me.pnlBotoes)
        Me.pnlPrincipal.Controls.Add(Me.Menu)
        Me.pnlPrincipal.Location = New System.Drawing.Point(-2, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(881, 561)
        Me.pnlPrincipal.TabIndex = 0
        '
        'pnlFormularios
        '
        Me.pnlFormularios.Controls.Add(Me.lboFoto)
        Me.pnlFormularios.Controls.Add(Me.lboValores)
        Me.pnlFormularios.Controls.Add(Me.lboEstoque)
        Me.pnlFormularios.Controls.Add(Me.lboMedidas)
        Me.pnlFormularios.Controls.Add(Me.lboDescricoes)
        Me.pnlFormularios.Controls.Add(Me.pnlDescricoes)
        Me.pnlFormularios.Controls.Add(Me.pnlMedidas)
        Me.pnlFormularios.Controls.Add(Me.pnlEstoque)
        Me.pnlFormularios.Controls.Add(Me.pnlValores)
        Me.pnlFormularios.Controls.Add(Me.pnlProduto)
        Me.pnlFormularios.Controls.Add(Me.pctboxProduto)
        Me.pnlFormularios.Location = New System.Drawing.Point(7, 30)
        Me.pnlFormularios.Name = "pnlFormularios"
        Me.pnlFormularios.Size = New System.Drawing.Size(868, 488)
        Me.pnlFormularios.TabIndex = 0
        '
        'lboFoto
        '
        Me.lboFoto.AutoSize = True
        Me.lboFoto.Location = New System.Drawing.Point(709, 95)
        Me.lboFoto.Name = "lboFoto"
        Me.lboFoto.Size = New System.Drawing.Size(28, 13)
        Me.lboFoto.TabIndex = 0
        Me.lboFoto.Text = "Foto"
        '
        'lboValores
        '
        Me.lboValores.AutoSize = True
        Me.lboValores.Location = New System.Drawing.Point(10, 92)
        Me.lboValores.Name = "lboValores"
        Me.lboValores.Size = New System.Drawing.Size(42, 13)
        Me.lboValores.TabIndex = 0
        Me.lboValores.Text = "Valores"
        '
        'lboEstoque
        '
        Me.lboEstoque.AutoSize = True
        Me.lboEstoque.Location = New System.Drawing.Point(9, 159)
        Me.lboEstoque.Name = "lboEstoque"
        Me.lboEstoque.Size = New System.Drawing.Size(46, 13)
        Me.lboEstoque.TabIndex = 0
        Me.lboEstoque.Text = "Estoque"
        '
        'lboMedidas
        '
        Me.lboMedidas.AutoSize = True
        Me.lboMedidas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboMedidas.Location = New System.Drawing.Point(10, 224)
        Me.lboMedidas.Name = "lboMedidas"
        Me.lboMedidas.Size = New System.Drawing.Size(53, 16)
        Me.lboMedidas.TabIndex = 0
        Me.lboMedidas.Text = "Medidas"
        '
        'lboDescricoes
        '
        Me.lboDescricoes.AutoSize = True
        Me.lboDescricoes.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboDescricoes.Location = New System.Drawing.Point(10, 286)
        Me.lboDescricoes.Name = "lboDescricoes"
        Me.lboDescricoes.Size = New System.Drawing.Size(64, 16)
        Me.lboDescricoes.TabIndex = 0
        Me.lboDescricoes.Text = "Descrições"
        '
        'pnlDescricoes
        '
        Me.pnlDescricoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDescricoes.Controls.Add(Me.lboObservacoes)
        Me.pnlDescricoes.Controls.Add(Me.lboDescricaoDetalhada)
        Me.pnlDescricoes.Controls.Add(Me.txtObservacoes)
        Me.pnlDescricoes.Controls.Add(Me.txtDescricaoDetalhada)
        Me.pnlDescricoes.Location = New System.Drawing.Point(1, 295)
        Me.pnlDescricoes.Name = "pnlDescricoes"
        Me.pnlDescricoes.Size = New System.Drawing.Size(863, 191)
        Me.pnlDescricoes.TabIndex = 4
        Me.pnlDescricoes.TabStop = True
        '
        'lboObservacoes
        '
        Me.lboObservacoes.AutoSize = True
        Me.lboObservacoes.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboObservacoes.Location = New System.Drawing.Point(8, 98)
        Me.lboObservacoes.Name = "lboObservacoes"
        Me.lboObservacoes.Size = New System.Drawing.Size(75, 16)
        Me.lboObservacoes.TabIndex = 0
        Me.lboObservacoes.Text = "Observações"
        '
        'lboDescricaoDetalhada
        '
        Me.lboDescricaoDetalhada.AutoSize = True
        Me.lboDescricaoDetalhada.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboDescricaoDetalhada.Location = New System.Drawing.Point(8, 13)
        Me.lboDescricaoDetalhada.Name = "lboDescricaoDetalhada"
        Me.lboDescricaoDetalhada.Size = New System.Drawing.Size(115, 16)
        Me.lboDescricaoDetalhada.TabIndex = 0
        Me.lboDescricaoDetalhada.Text = "Descrição Detalhada"
        '
        'txtObservacoes
        '
        Me.txtObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacoes.Location = New System.Drawing.Point(11, 117)
        Me.txtObservacoes.Multiline = True
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(845, 65)
        Me.txtObservacoes.TabIndex = 1
        '
        'txtDescricaoDetalhada
        '
        Me.txtDescricaoDetalhada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoDetalhada.Location = New System.Drawing.Point(11, 29)
        Me.txtDescricaoDetalhada.Multiline = True
        Me.txtDescricaoDetalhada.Name = "txtDescricaoDetalhada"
        Me.txtDescricaoDetalhada.Size = New System.Drawing.Size(845, 65)
        Me.txtDescricaoDetalhada.TabIndex = 0
        '
        'pnlMedidas
        '
        Me.pnlMedidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMedidas.Controls.Add(Me.txtPeso)
        Me.pnlMedidas.Controls.Add(Me.lboPeso)
        Me.pnlMedidas.Controls.Add(Me.txtComprimento)
        Me.pnlMedidas.Controls.Add(Me.txtLargura)
        Me.pnlMedidas.Controls.Add(Me.txtAltura)
        Me.pnlMedidas.Controls.Add(Me.txtUnidade)
        Me.pnlMedidas.Controls.Add(Me.lboDimensoes)
        Me.pnlMedidas.Controls.Add(Me.lboUnidade)
        Me.pnlMedidas.Location = New System.Drawing.Point(1, 232)
        Me.pnlMedidas.Name = "pnlMedidas"
        Me.pnlMedidas.Size = New System.Drawing.Size(694, 50)
        Me.pnlMedidas.TabIndex = 3
        Me.pnlMedidas.TabStop = True
        '
        'txtPeso
        '
        Me.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeso.Enabled = False
        Me.txtPeso.Location = New System.Drawing.Point(635, 16)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(50, 20)
        Me.txtPeso.TabIndex = 0
        Me.txtPeso.TabStop = False
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboPeso
        '
        Me.lboPeso.AutoSize = True
        Me.lboPeso.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboPeso.Location = New System.Drawing.Point(550, 18)
        Me.lboPeso.Name = "lboPeso"
        Me.lboPeso.Size = New System.Drawing.Size(79, 16)
        Me.lboPeso.TabIndex = 0
        Me.lboPeso.Text = "Peso(gramas)"
        '
        'txtComprimento
        '
        Me.txtComprimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComprimento.Enabled = False
        Me.txtComprimento.Location = New System.Drawing.Point(494, 16)
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.Size = New System.Drawing.Size(50, 20)
        Me.txtComprimento.TabIndex = 0
        Me.txtComprimento.TabStop = False
        Me.txtComprimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLargura
        '
        Me.txtLargura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLargura.Enabled = False
        Me.txtLargura.Location = New System.Drawing.Point(438, 16)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(50, 20)
        Me.txtLargura.TabIndex = 0
        Me.txtLargura.TabStop = False
        Me.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAltura
        '
        Me.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAltura.Enabled = False
        Me.txtAltura.Location = New System.Drawing.Point(382, 16)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(50, 20)
        Me.txtAltura.TabIndex = 0
        Me.txtAltura.TabStop = False
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnidade
        '
        Me.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidade.Enabled = False
        Me.txtUnidade.Location = New System.Drawing.Point(59, 16)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(50, 20)
        Me.txtUnidade.TabIndex = 0
        Me.txtUnidade.TabStop = False
        Me.txtUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboDimensoes
        '
        Me.lboDimensoes.AutoSize = True
        Me.lboDimensoes.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboDimensoes.Location = New System.Drawing.Point(115, 18)
        Me.lboDimensoes.Name = "lboDimensoes"
        Me.lboDimensoes.Size = New System.Drawing.Size(261, 16)
        Me.lboDimensoes.TabIndex = 0
        Me.lboDimensoes.Text = "Dimensões(cm): Altura - Largura - Comprimento"
        '
        'lboUnidade
        '
        Me.lboUnidade.AutoSize = True
        Me.lboUnidade.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboUnidade.Location = New System.Drawing.Point(3, 18)
        Me.lboUnidade.Name = "lboUnidade"
        Me.lboUnidade.Size = New System.Drawing.Size(52, 16)
        Me.lboUnidade.TabIndex = 0
        Me.lboUnidade.Text = "Unidade"
        '
        'pnlEstoque
        '
        Me.pnlEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEstoque.Controls.Add(Me.BtnVinculado)
        Me.pnlEstoque.Controls.Add(Me.BtnPrevisto)
        Me.pnlEstoque.Controls.Add(Me.txtEstoquePrevisto)
        Me.pnlEstoque.Controls.Add(Me.txtEstoqueDisponivel)
        Me.pnlEstoque.Controls.Add(Me.txtEstoqueMin)
        Me.pnlEstoque.Controls.Add(Me.txtEstoqueMax)
        Me.pnlEstoque.Controls.Add(Me.txtEstoqueVinculado)
        Me.pnlEstoque.Controls.Add(Me.lboEstoqueMax)
        Me.pnlEstoque.Controls.Add(Me.lboEstoqueMin)
        Me.pnlEstoque.Controls.Add(Me.lboDisponivel)
        Me.pnlEstoque.Location = New System.Drawing.Point(1, 166)
        Me.pnlEstoque.Name = "pnlEstoque"
        Me.pnlEstoque.Size = New System.Drawing.Size(694, 50)
        Me.pnlEstoque.TabIndex = 2
        Me.pnlEstoque.TabStop = True
        '
        'BtnVinculado
        '
        Me.BtnVinculado.BackColor = System.Drawing.Color.Transparent
        Me.BtnVinculado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVinculado.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnVinculado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnVinculado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnVinculado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVinculado.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVinculado.Location = New System.Drawing.Point(409, 12)
        Me.BtnVinculado.Name = "BtnVinculado"
        Me.BtnVinculado.Size = New System.Drawing.Size(75, 25)
        Me.BtnVinculado.TabIndex = 3
        Me.BtnVinculado.Text = "Vinculado"
        Me.BtnVinculado.UseVisualStyleBackColor = False
        '
        'BtnPrevisto
        '
        Me.BtnPrevisto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrevisto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnPrevisto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnPrevisto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnPrevisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrevisto.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevisto.Location = New System.Drawing.Point(546, 12)
        Me.BtnPrevisto.Name = "BtnPrevisto"
        Me.BtnPrevisto.Size = New System.Drawing.Size(68, 25)
        Me.BtnPrevisto.TabIndex = 5
        Me.BtnPrevisto.Text = "Previsto"
        Me.BtnPrevisto.UseVisualStyleBackColor = True
        '
        'txtEstoquePrevisto
        '
        Me.txtEstoquePrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoquePrevisto.Location = New System.Drawing.Point(619, 14)
        Me.txtEstoquePrevisto.Name = "txtEstoquePrevisto"
        Me.txtEstoquePrevisto.Size = New System.Drawing.Size(50, 20)
        Me.txtEstoquePrevisto.TabIndex = 6
        Me.txtEstoquePrevisto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEstoqueDisponivel
        '
        Me.txtEstoqueDisponivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoqueDisponivel.Location = New System.Drawing.Point(73, 14)
        Me.txtEstoqueDisponivel.Name = "txtEstoqueDisponivel"
        Me.txtEstoqueDisponivel.Size = New System.Drawing.Size(50, 20)
        Me.txtEstoqueDisponivel.TabIndex = 0
        Me.txtEstoqueDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEstoqueMin
        '
        Me.txtEstoqueMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoqueMin.Location = New System.Drawing.Point(212, 14)
        Me.txtEstoqueMin.Name = "txtEstoqueMin"
        Me.txtEstoqueMin.Size = New System.Drawing.Size(50, 20)
        Me.txtEstoqueMin.TabIndex = 1
        Me.txtEstoqueMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEstoqueMax
        '
        Me.txtEstoqueMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoqueMax.Location = New System.Drawing.Point(353, 14)
        Me.txtEstoqueMax.Name = "txtEstoqueMax"
        Me.txtEstoqueMax.Size = New System.Drawing.Size(50, 20)
        Me.txtEstoqueMax.TabIndex = 2
        Me.txtEstoqueMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEstoqueVinculado
        '
        Me.txtEstoqueVinculado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstoqueVinculado.Location = New System.Drawing.Point(490, 14)
        Me.txtEstoqueVinculado.Name = "txtEstoqueVinculado"
        Me.txtEstoqueVinculado.Size = New System.Drawing.Size(50, 20)
        Me.txtEstoqueVinculado.TabIndex = 4
        Me.txtEstoqueVinculado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboEstoqueMax
        '
        Me.lboEstoqueMax.AutoSize = True
        Me.lboEstoqueMax.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboEstoqueMax.Location = New System.Drawing.Point(268, 16)
        Me.lboEstoqueMax.Name = "lboEstoqueMax"
        Me.lboEstoqueMax.Size = New System.Drawing.Size(79, 16)
        Me.lboEstoqueMax.TabIndex = 0
        Me.lboEstoqueMax.Text = "Estoque Max."
        '
        'lboEstoqueMin
        '
        Me.lboEstoqueMin.AutoSize = True
        Me.lboEstoqueMin.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboEstoqueMin.Location = New System.Drawing.Point(129, 16)
        Me.lboEstoqueMin.Name = "lboEstoqueMin"
        Me.lboEstoqueMin.Size = New System.Drawing.Size(77, 16)
        Me.lboEstoqueMin.TabIndex = 0
        Me.lboEstoqueMin.Text = "Estoque Min."
        '
        'lboDisponivel
        '
        Me.lboDisponivel.AutoSize = True
        Me.lboDisponivel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboDisponivel.Location = New System.Drawing.Point(4, 16)
        Me.lboDisponivel.Name = "lboDisponivel"
        Me.lboDisponivel.Size = New System.Drawing.Size(63, 16)
        Me.lboDisponivel.TabIndex = 0
        Me.lboDisponivel.Text = "Disponível"
        '
        'pnlValores
        '
        Me.pnlValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlValores.Controls.Add(Me.BtnMargemLucro)
        Me.pnlValores.Controls.Add(Me.cboMargemLucro)
        Me.pnlValores.Controls.Add(Me.txtCompraImposto)
        Me.pnlValores.Controls.Add(Me.lboCompraImposto)
        Me.pnlValores.Controls.Add(Me.txtPrecoVenda)
        Me.pnlValores.Controls.Add(Me.txtPrecoCompra)
        Me.pnlValores.Controls.Add(Me.lboPrecoVenda)
        Me.pnlValores.Controls.Add(Me.lboPrecoCompra)
        Me.pnlValores.Location = New System.Drawing.Point(1, 99)
        Me.pnlValores.Name = "pnlValores"
        Me.pnlValores.Size = New System.Drawing.Size(694, 50)
        Me.pnlValores.TabIndex = 1
        Me.pnlValores.TabStop = True
        '
        'BtnMargemLucro
        '
        Me.BtnMargemLucro.BackColor = System.Drawing.Color.Transparent
        Me.BtnMargemLucro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnMargemLucro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnMargemLucro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnMargemLucro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMargemLucro.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMargemLucro.Location = New System.Drawing.Point(336, 12)
        Me.BtnMargemLucro.Name = "BtnMargemLucro"
        Me.BtnMargemLucro.Size = New System.Drawing.Size(130, 25)
        Me.BtnMargemLucro.TabIndex = 2
        Me.BtnMargemLucro.Text = "% Margem de Lucro"
        Me.BtnMargemLucro.UseVisualStyleBackColor = False
        '
        'cboMargemLucro
        '
        Me.cboMargemLucro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMargemLucro.FormattingEnabled = True
        Me.cboMargemLucro.Location = New System.Drawing.Point(472, 14)
        Me.cboMargemLucro.Name = "cboMargemLucro"
        Me.cboMargemLucro.Size = New System.Drawing.Size(50, 21)
        Me.cboMargemLucro.TabIndex = 3
        '
        'txtCompraImposto
        '
        Me.txtCompraImposto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompraImposto.Location = New System.Drawing.Point(280, 14)
        Me.txtCompraImposto.Name = "txtCompraImposto"
        Me.txtCompraImposto.Size = New System.Drawing.Size(50, 20)
        Me.txtCompraImposto.TabIndex = 1
        Me.txtCompraImposto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboCompraImposto
        '
        Me.lboCompraImposto.AutoSize = True
        Me.lboCompraImposto.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboCompraImposto.Location = New System.Drawing.Point(163, 16)
        Me.lboCompraImposto.Name = "lboCompraImposto"
        Me.lboCompraImposto.Size = New System.Drawing.Size(111, 16)
        Me.lboCompraImposto.TabIndex = 0
        Me.lboCompraImposto.Text = "Compra + Impostos"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecoVenda.Location = New System.Drawing.Point(624, 14)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(50, 20)
        Me.txtPrecoVenda.TabIndex = 4
        Me.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecoCompra.Location = New System.Drawing.Point(107, 14)
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.Size = New System.Drawing.Size(50, 20)
        Me.txtPrecoCompra.TabIndex = 0
        Me.txtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboPrecoVenda
        '
        Me.lboPrecoVenda.AutoSize = True
        Me.lboPrecoVenda.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboPrecoVenda.Location = New System.Drawing.Point(528, 16)
        Me.lboPrecoVenda.Name = "lboPrecoVenda"
        Me.lboPrecoVenda.Size = New System.Drawing.Size(90, 16)
        Me.lboPrecoVenda.TabIndex = 0
        Me.lboPrecoVenda.Text = "Preço de Venda"
        '
        'lboPrecoCompra
        '
        Me.lboPrecoCompra.AutoSize = True
        Me.lboPrecoCompra.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboPrecoCompra.Location = New System.Drawing.Point(3, 16)
        Me.lboPrecoCompra.Name = "lboPrecoCompra"
        Me.lboPrecoCompra.Size = New System.Drawing.Size(98, 16)
        Me.lboPrecoCompra.TabIndex = 0
        Me.lboPrecoCompra.Text = "Preço de Compra"
        '
        'pnlProduto
        '
        Me.pnlProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProduto.Controls.Add(Me.txtCodigo)
        Me.pnlProduto.Controls.Add(Me.BtnFornecedores)
        Me.pnlProduto.Controls.Add(Me.BtnStatus)
        Me.pnlProduto.Controls.Add(Me.BtnCategoria)
        Me.pnlProduto.Controls.Add(Me.BtnTipoProduto)
        Me.pnlProduto.Controls.Add(Me.rdoProdutoAcabado)
        Me.pnlProduto.Controls.Add(Me.rdoMateriaPrima)
        Me.pnlProduto.Controls.Add(Me.cboFornecedores)
        Me.pnlProduto.Controls.Add(Me.cboStatus)
        Me.pnlProduto.Controls.Add(Me.cboCategoria)
        Me.pnlProduto.Controls.Add(Me.cboTipoProduto)
        Me.pnlProduto.Controls.Add(Me.txtReferencia)
        Me.pnlProduto.Controls.Add(Me.txtDescricao)
        Me.pnlProduto.Controls.Add(Me.lboReferencia)
        Me.pnlProduto.Controls.Add(Me.lboDescricao)
        Me.pnlProduto.Controls.Add(Me.lboCodigo)
        Me.pnlProduto.Location = New System.Drawing.Point(1, 1)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(863, 86)
        Me.pnlProduto.TabIndex = 0
        Me.pnlProduto.TabStop = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(61, 16)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnFornecedores
        '
        Me.BtnFornecedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFornecedores.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnFornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFornecedores.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFornecedores.Location = New System.Drawing.Point(9, 52)
        Me.BtnFornecedores.Name = "BtnFornecedores"
        Me.BtnFornecedores.Size = New System.Drawing.Size(98, 25)
        Me.BtnFornecedores.TabIndex = 5
        Me.BtnFornecedores.Text = "Fornecedores"
        Me.BtnFornecedores.UseVisualStyleBackColor = True
        '
        'BtnStatus
        '
        Me.BtnStatus.BackColor = System.Drawing.Color.Transparent
        Me.BtnStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatus.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnStatus.Location = New System.Drawing.Point(626, 52)
        Me.BtnStatus.Name = "BtnStatus"
        Me.BtnStatus.Size = New System.Drawing.Size(75, 25)
        Me.BtnStatus.TabIndex = 11
        Me.BtnStatus.Text = "Status"
        Me.BtnStatus.UseVisualStyleBackColor = False
        '
        'BtnCategoria
        '
        Me.BtnCategoria.BackColor = System.Drawing.Color.Transparent
        Me.BtnCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCategoria.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategoria.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategoria.Location = New System.Drawing.Point(240, 52)
        Me.BtnCategoria.Name = "BtnCategoria"
        Me.BtnCategoria.Size = New System.Drawing.Size(75, 25)
        Me.BtnCategoria.TabIndex = 7
        Me.BtnCategoria.Text = "Categoria"
        Me.BtnCategoria.UseVisualStyleBackColor = False
        '
        'BtnTipoProduto
        '
        Me.BtnTipoProduto.BackColor = System.Drawing.Color.Transparent
        Me.BtnTipoProduto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTipoProduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnTipoProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnTipoProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnTipoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipoProduto.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTipoProduto.Location = New System.Drawing.Point(427, 52)
        Me.BtnTipoProduto.Name = "BtnTipoProduto"
        Me.BtnTipoProduto.Size = New System.Drawing.Size(87, 25)
        Me.BtnTipoProduto.TabIndex = 9
        Me.BtnTipoProduto.Text = "Tipo Produto"
        Me.BtnTipoProduto.UseVisualStyleBackColor = False
        '
        'rdoProdutoAcabado
        '
        Me.rdoProdutoAcabado.AutoSize = True
        Me.rdoProdutoAcabado.Location = New System.Drawing.Point(748, 28)
        Me.rdoProdutoAcabado.Name = "rdoProdutoAcabado"
        Me.rdoProdutoAcabado.Size = New System.Drawing.Size(108, 17)
        Me.rdoProdutoAcabado.TabIndex = 4
        Me.rdoProdutoAcabado.Text = "Produto Acabado"
        Me.rdoProdutoAcabado.UseVisualStyleBackColor = True
        '
        'rdoMateriaPrima
        '
        Me.rdoMateriaPrima.AutoSize = True
        Me.rdoMateriaPrima.Location = New System.Drawing.Point(748, 5)
        Me.rdoMateriaPrima.Name = "rdoMateriaPrima"
        Me.rdoMateriaPrima.Size = New System.Drawing.Size(89, 17)
        Me.rdoMateriaPrima.TabIndex = 3
        Me.rdoMateriaPrima.Text = "Matéria Prima"
        Me.rdoMateriaPrima.UseVisualStyleBackColor = True
        '
        'cboFornecedores
        '
        Me.cboFornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFornecedores.FormattingEnabled = True
        Me.cboFornecedores.Location = New System.Drawing.Point(113, 54)
        Me.cboFornecedores.Name = "cboFornecedores"
        Me.cboFornecedores.Size = New System.Drawing.Size(121, 21)
        Me.cboFornecedores.TabIndex = 6
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.IntegralHeight = False
        Me.cboStatus.ItemHeight = 13
        Me.cboStatus.Location = New System.Drawing.Point(707, 54)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(100, 21)
        Me.cboStatus.TabIndex = 12
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(321, 54)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(100, 21)
        Me.cboCategoria.TabIndex = 8
        '
        'cboTipoProduto
        '
        Me.cboTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProduto.FormattingEnabled = True
        Me.cboTipoProduto.Location = New System.Drawing.Point(520, 54)
        Me.cboTipoProduto.Name = "cboTipoProduto"
        Me.cboTipoProduto.Size = New System.Drawing.Size(100, 21)
        Me.cboTipoProduto.TabIndex = 10
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(649, 16)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(85, 20)
        Me.txtReferencia.TabIndex = 2
        Me.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(182, 16)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(392, 20)
        Me.txtDescricao.TabIndex = 1
        Me.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboReferencia
        '
        Me.lboReferencia.AutoSize = True
        Me.lboReferencia.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboReferencia.Location = New System.Drawing.Point(580, 18)
        Me.lboReferencia.Name = "lboReferencia"
        Me.lboReferencia.Size = New System.Drawing.Size(63, 16)
        Me.lboReferencia.TabIndex = 0
        Me.lboReferencia.Text = "Referência"
        '
        'lboDescricao
        '
        Me.lboDescricao.AutoSize = True
        Me.lboDescricao.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboDescricao.Location = New System.Drawing.Point(117, 18)
        Me.lboDescricao.Name = "lboDescricao"
        Me.lboDescricao.Size = New System.Drawing.Size(59, 16)
        Me.lboDescricao.TabIndex = 0
        Me.lboDescricao.Text = "Descrição"
        '
        'lboCodigo
        '
        Me.lboCodigo.AutoSize = True
        Me.lboCodigo.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboCodigo.Location = New System.Drawing.Point(9, 18)
        Me.lboCodigo.Name = "lboCodigo"
        Me.lboCodigo.Size = New System.Drawing.Size(46, 16)
        Me.lboCodigo.TabIndex = 0
        Me.lboCodigo.Text = "Código"
        '
        'pctboxProduto
        '
        Me.pctboxProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctboxProduto.Location = New System.Drawing.Point(707, 99)
        Me.pctboxProduto.Name = "pctboxProduto"
        Me.pctboxProduto.Size = New System.Drawing.Size(156, 183)
        Me.pctboxProduto.TabIndex = 34
        Me.pctboxProduto.TabStop = False
        Me.pctboxProduto.Tag = ""
        Me.pctboxProduto.UseWaitCursor = True
        '
        'pnlBotoes
        '
        Me.pnlBotoes.Controls.Add(Me.BtnPesquisar)
        Me.pnlBotoes.Controls.Add(Me.BtnImprimir)
        Me.pnlBotoes.Controls.Add(Me.BtnVoltar)
        Me.pnlBotoes.Controls.Add(Me.BtnLimpar)
        Me.pnlBotoes.Controls.Add(Me.BtnExcluir)
        Me.pnlBotoes.Controls.Add(Me.BtnSalvar)
        Me.pnlBotoes.Location = New System.Drawing.Point(190, 524)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(487, 28)
        Me.pnlBotoes.TabIndex = 5
        Me.pnlBotoes.TabStop = True
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Location = New System.Drawing.Point(165, 3)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.BtnPesquisar.TabIndex = 2
        Me.BtnPesquisar.Text = "Pesquisar"
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(327, 3)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprimir.TabIndex = 4
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(408, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 5
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(246, 3)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 3
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Location = New System.Drawing.Point(84, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluir.TabIndex = 1
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(3, 3)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 0
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutoToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.RefernciasToolStripMenuItem, Me.MedidasToolStripMenuItem, Me.ImpostosToolStripMenuItem, Me.RelacionamentosToolStripMenuItem, Me.EtiquetasToolStripMenuItem, Me.AtivosFixosToolStripMenuItem, Me.RelatóriosToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(881, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'ProdutoToolStripMenuItem
        '
        Me.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem"
        Me.ProdutoToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ProdutoToolStripMenuItem.Text = "Produtos"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'RefernciasToolStripMenuItem
        '
        Me.RefernciasToolStripMenuItem.Name = "RefernciasToolStripMenuItem"
        Me.RefernciasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.RefernciasToolStripMenuItem.Text = "Referências"
        '
        'MedidasToolStripMenuItem
        '
        Me.MedidasToolStripMenuItem.Name = "MedidasToolStripMenuItem"
        Me.MedidasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MedidasToolStripMenuItem.Text = "Medidas"
        '
        'ImpostosToolStripMenuItem
        '
        Me.ImpostosToolStripMenuItem.Name = "ImpostosToolStripMenuItem"
        Me.ImpostosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ImpostosToolStripMenuItem.Text = "Impostos"
        '
        'RelacionamentosToolStripMenuItem
        '
        Me.RelacionamentosToolStripMenuItem.Name = "RelacionamentosToolStripMenuItem"
        Me.RelacionamentosToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.RelacionamentosToolStripMenuItem.Text = "Relacionamentos"
        '
        'EtiquetasToolStripMenuItem
        '
        Me.EtiquetasToolStripMenuItem.Name = "EtiquetasToolStripMenuItem"
        Me.EtiquetasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EtiquetasToolStripMenuItem.Text = "Etiquetas"
        '
        'AtivosFixosToolStripMenuItem
        '
        Me.AtivosFixosToolStripMenuItem.Name = "AtivosFixosToolStripMenuItem"
        Me.AtivosFixosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.AtivosFixosToolStripMenuItem.Text = "Ativos Fixos"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'FrmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 560)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "FrmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.pnlFormularios.ResumeLayout(False)
        Me.pnlFormularios.PerformLayout()
        Me.pnlDescricoes.ResumeLayout(False)
        Me.pnlDescricoes.PerformLayout()
        Me.pnlMedidas.ResumeLayout(False)
        Me.pnlMedidas.PerformLayout()
        Me.pnlEstoque.ResumeLayout(False)
        Me.pnlEstoque.PerformLayout()
        Me.pnlValores.ResumeLayout(False)
        Me.pnlValores.PerformLayout()
        Me.pnlProduto.ResumeLayout(False)
        Me.pnlProduto.PerformLayout()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotoes.ResumeLayout(False)
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents ProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelacionamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefernciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtiquetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtivosFixosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlFormularios As Panel
    Friend WithEvents lboFoto As Label
    Friend WithEvents lboValores As Label
    Friend WithEvents lboEstoque As Label
    Friend WithEvents lboMedidas As Label
    Friend WithEvents lboDescricoes As Label
    Friend WithEvents pnlDescricoes As Panel
    Friend WithEvents lboObservacoes As Label
    Friend WithEvents lboDescricaoDetalhada As Label
    Public WithEvents txtObservacoes As TextBox
    Public WithEvents txtDescricaoDetalhada As TextBox
    Friend WithEvents pnlMedidas As Panel
    Public WithEvents txtPeso As TextBox
    Friend WithEvents lboPeso As Label
    Public WithEvents txtComprimento As TextBox
    Public WithEvents txtLargura As TextBox
    Public WithEvents txtAltura As TextBox
    Public WithEvents txtUnidade As TextBox
    Friend WithEvents lboDimensoes As Label
    Friend WithEvents lboUnidade As Label
    Friend WithEvents pnlEstoque As Panel
    Friend WithEvents BtnVinculado As Button
    Friend WithEvents BtnPrevisto As Button
    Public WithEvents txtEstoquePrevisto As TextBox
    Public WithEvents txtEstoqueDisponivel As TextBox
    Public WithEvents txtEstoqueMin As TextBox
    Public WithEvents txtEstoqueMax As TextBox
    Public WithEvents txtEstoqueVinculado As TextBox
    Friend WithEvents lboEstoqueMax As Label
    Friend WithEvents lboEstoqueMin As Label
    Friend WithEvents lboDisponivel As Label
    Friend WithEvents pnlValores As Panel
    Friend WithEvents BtnMargemLucro As Button
    Public WithEvents cboMargemLucro As ComboBox
    Public WithEvents txtCompraImposto As TextBox
    Friend WithEvents lboCompraImposto As Label
    Public WithEvents txtPrecoVenda As TextBox
    Public WithEvents txtPrecoCompra As TextBox
    Friend WithEvents lboPrecoVenda As Label
    Friend WithEvents lboPrecoCompra As Label
    Friend WithEvents pnlProduto As Panel
    Friend WithEvents BtnFornecedores As Button
    Friend WithEvents BtnStatus As Button
    Friend WithEvents BtnCategoria As Button
    Friend WithEvents BtnTipoProduto As Button
    Public WithEvents rdoProdutoAcabado As RadioButton
    Public WithEvents rdoMateriaPrima As RadioButton
    Public WithEvents cboFornecedores As ComboBox
    Public WithEvents cboStatus As ComboBox
    Public WithEvents cboCategoria As ComboBox
    Public WithEvents cboTipoProduto As ComboBox
    Public WithEvents txtReferencia As TextBox
    Public WithEvents txtDescricao As TextBox
    Public WithEvents txtCodigo As TextBox
    Friend WithEvents lboReferencia As Label
    Friend WithEvents lboDescricao As Label
    Friend WithEvents lboCodigo As Label
    Friend WithEvents pctboxProduto As PictureBox
    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnSalvar As Button
End Class
