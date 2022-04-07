<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmServicos
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
        Me.pnlProdutos = New System.Windows.Forms.Panel()
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lboObservacoes = New System.Windows.Forms.Label()
        Me.lboDescricaoDetalhada = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCompraImposto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMarginLucro = New System.Windows.Forms.TextBox()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.txtPrecoCompra = New System.Windows.Forms.TextBox()
        Me.lboMarginLucro = New System.Windows.Forms.Label()
        Me.lboPrecoVenda = New System.Windows.Forms.Label()
        Me.lboPrecoCompra = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lboFornecedores = New System.Windows.Forms.Label()
        Me.cboFornecedores = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lboStatus = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.cboTipoProduto = New System.Windows.Forms.ComboBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lboCategoria = New System.Windows.Forms.Label()
        Me.lboTipoProduto = New System.Windows.Forms.Label()
        Me.lboReferencia = New System.Windows.Forms.Label()
        Me.lboDescricao = New System.Windows.Forms.Label()
        Me.lboCodigo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefernciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelacionamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlProdutos.SuspendLayout()
        Me.pnlBotoes.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlProdutos
        '
        Me.pnlProdutos.Controls.Add(Me.pnlBotoes)
        Me.pnlProdutos.Controls.Add(Me.Panel6)
        Me.pnlProdutos.Controls.Add(Me.Panel3)
        Me.pnlProdutos.Controls.Add(Me.Panel2)
        Me.pnlProdutos.Location = New System.Drawing.Point(7, 30)
        Me.pnlProdutos.Name = "pnlProdutos"
        Me.pnlProdutos.Size = New System.Drawing.Size(783, 387)
        Me.pnlProdutos.TabIndex = 57
        '
        'pnlBotoes
        '
        Me.pnlBotoes.Controls.Add(Me.BtnPesquisar)
        Me.pnlBotoes.Controls.Add(Me.BtnImprimir)
        Me.pnlBotoes.Controls.Add(Me.BtnVoltar)
        Me.pnlBotoes.Controls.Add(Me.BtnLimpar)
        Me.pnlBotoes.Controls.Add(Me.BtnExcluir)
        Me.pnlBotoes.Controls.Add(Me.BtnSalvar)
        Me.pnlBotoes.Location = New System.Drawing.Point(136, 342)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(487, 28)
        Me.pnlBotoes.TabIndex = 56
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Location = New System.Drawing.Point(165, 3)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.BtnPesquisar.TabIndex = 54
        Me.BtnPesquisar.Text = "Pesquisar"
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(327, 3)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprimir.TabIndex = 53
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(408, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 52
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(246, 3)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 51
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Location = New System.Drawing.Point(84, 3)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluir.TabIndex = 49
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(3, 3)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 48
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lboObservacoes)
        Me.Panel6.Controls.Add(Me.lboDescricaoDetalhada)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Location = New System.Drawing.Point(20, 143)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(744, 181)
        Me.Panel6.TabIndex = 0
        '
        'lboObservacoes
        '
        Me.lboObservacoes.AutoSize = True
        Me.lboObservacoes.Location = New System.Drawing.Point(8, 89)
        Me.lboObservacoes.Name = "lboObservacoes"
        Me.lboObservacoes.Size = New System.Drawing.Size(70, 13)
        Me.lboObservacoes.TabIndex = 51
        Me.lboObservacoes.Text = "Observações"
        '
        'lboDescricaoDetalhada
        '
        Me.lboDescricaoDetalhada.AutoSize = True
        Me.lboDescricaoDetalhada.Location = New System.Drawing.Point(8, 5)
        Me.lboDescricaoDetalhada.Name = "lboDescricaoDetalhada"
        Me.lboDescricaoDetalhada.Size = New System.Drawing.Size(107, 13)
        Me.lboDescricaoDetalhada.TabIndex = 50
        Me.lboDescricaoDetalhada.Text = "Descrição Detalhada"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 105)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(730, 65)
        Me.TextBox2.TabIndex = 49
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 21)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(730, 65)
        Me.TextBox1.TabIndex = 48
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtCompraImposto)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtMarginLucro)
        Me.Panel3.Controls.Add(Me.txtPrecoVenda)
        Me.Panel3.Controls.Add(Me.txtPrecoCompra)
        Me.Panel3.Controls.Add(Me.lboMarginLucro)
        Me.Panel3.Controls.Add(Me.lboPrecoVenda)
        Me.Panel3.Controls.Add(Me.lboPrecoCompra)
        Me.Panel3.Location = New System.Drawing.Point(20, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 50)
        Me.Panel3.TabIndex = 43
        '
        'txtCompraImposto
        '
        Me.txtCompraImposto.Location = New System.Drawing.Point(288, 14)
        Me.txtCompraImposto.Name = "txtCompraImposto"
        Me.txtCompraImposto.Size = New System.Drawing.Size(50, 20)
        Me.txtCompraImposto.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Compra + Impostos"
        '
        'txtMarginLucro
        '
        Me.txtMarginLucro.Location = New System.Drawing.Point(458, 14)
        Me.txtMarginLucro.Name = "txtMarginLucro"
        Me.txtMarginLucro.Size = New System.Drawing.Size(50, 20)
        Me.txtMarginLucro.TabIndex = 20
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Location = New System.Drawing.Point(610, 14)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(50, 20)
        Me.txtPrecoVenda.TabIndex = 19
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.Location = New System.Drawing.Point(115, 14)
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.Size = New System.Drawing.Size(50, 20)
        Me.txtPrecoCompra.TabIndex = 17
        '
        'lboMarginLucro
        '
        Me.lboMarginLucro.AutoSize = True
        Me.lboMarginLucro.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboMarginLucro.Location = New System.Drawing.Point(344, 16)
        Me.lboMarginLucro.Name = "lboMarginLucro"
        Me.lboMarginLucro.Size = New System.Drawing.Size(108, 16)
        Me.lboMarginLucro.TabIndex = 10
        Me.lboMarginLucro.Text = "% Margin de Lucro"
        '
        'lboPrecoVenda
        '
        Me.lboPrecoVenda.AutoSize = True
        Me.lboPrecoVenda.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboPrecoVenda.Location = New System.Drawing.Point(514, 16)
        Me.lboPrecoVenda.Name = "lboPrecoVenda"
        Me.lboPrecoVenda.Size = New System.Drawing.Size(90, 16)
        Me.lboPrecoVenda.TabIndex = 9
        Me.lboPrecoVenda.Text = "Preço de Venda"
        '
        'lboPrecoCompra
        '
        Me.lboPrecoCompra.AutoSize = True
        Me.lboPrecoCompra.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboPrecoCompra.Location = New System.Drawing.Point(11, 16)
        Me.lboPrecoCompra.Name = "lboPrecoCompra"
        Me.lboPrecoCompra.Size = New System.Drawing.Size(98, 16)
        Me.lboPrecoCompra.TabIndex = 8
        Me.lboPrecoCompra.Text = "Preço de Compra"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lboFornecedores)
        Me.Panel2.Controls.Add(Me.cboFornecedores)
        Me.Panel2.Controls.Add(Me.cboStatus)
        Me.Panel2.Controls.Add(Me.lboStatus)
        Me.Panel2.Controls.Add(Me.cboCategoria)
        Me.Panel2.Controls.Add(Me.cboTipoProduto)
        Me.Panel2.Controls.Add(Me.txtReferencia)
        Me.Panel2.Controls.Add(Me.txtDescricao)
        Me.Panel2.Controls.Add(Me.txtCodigo)
        Me.Panel2.Controls.Add(Me.lboCategoria)
        Me.Panel2.Controls.Add(Me.lboTipoProduto)
        Me.Panel2.Controls.Add(Me.lboReferencia)
        Me.Panel2.Controls.Add(Me.lboDescricao)
        Me.Panel2.Controls.Add(Me.lboCodigo)
        Me.Panel2.Location = New System.Drawing.Point(20, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 75)
        Me.Panel2.TabIndex = 41
        '
        'lboFornecedores
        '
        Me.lboFornecedores.AutoSize = True
        Me.lboFornecedores.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboFornecedores.Location = New System.Drawing.Point(8, 43)
        Me.lboFornecedores.Name = "lboFornecedores"
        Me.lboFornecedores.Size = New System.Drawing.Size(79, 16)
        Me.lboFornecedores.TabIndex = 33
        Me.lboFornecedores.Text = "Fornecedores"
        '
        'cboFornecedores
        '
        Me.cboFornecedores.FormattingEnabled = True
        Me.cboFornecedores.Location = New System.Drawing.Point(93, 41)
        Me.cboFornecedores.Name = "cboFornecedores"
        Me.cboFornecedores.Size = New System.Drawing.Size(121, 21)
        Me.cboFornecedores.TabIndex = 32
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(678, 41)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(55, 21)
        Me.cboStatus.TabIndex = 31
        '
        'lboStatus
        '
        Me.lboStatus.AutoSize = True
        Me.lboStatus.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboStatus.Location = New System.Drawing.Point(632, 43)
        Me.lboStatus.Name = "lboStatus"
        Me.lboStatus.Size = New System.Drawing.Size(40, 16)
        Me.lboStatus.TabIndex = 30
        Me.lboStatus.Text = "Status"
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(284, 41)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 29
        '
        'cboTipoProduto
        '
        Me.cboTipoProduto.FormattingEnabled = True
        Me.cboTipoProduto.Location = New System.Drawing.Point(505, 41)
        Me.cboTipoProduto.Name = "cboTipoProduto"
        Me.cboTipoProduto.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoProduto.TabIndex = 28
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(648, 9)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(85, 20)
        Me.txtReferencia.TabIndex = 21
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(181, 9)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(392, 20)
        Me.txtDescricao.TabIndex = 15
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(60, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigo.TabIndex = 14
        '
        'lboCategoria
        '
        Me.lboCategoria.AutoSize = True
        Me.lboCategoria.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboCategoria.Location = New System.Drawing.Point(220, 43)
        Me.lboCategoria.Name = "lboCategoria"
        Me.lboCategoria.Size = New System.Drawing.Size(58, 16)
        Me.lboCategoria.TabIndex = 13
        Me.lboCategoria.Text = "Categoria"
        '
        'lboTipoProduto
        '
        Me.lboTipoProduto.AutoSize = True
        Me.lboTipoProduto.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboTipoProduto.Location = New System.Drawing.Point(411, 43)
        Me.lboTipoProduto.Name = "lboTipoProduto"
        Me.lboTipoProduto.Size = New System.Drawing.Size(88, 16)
        Me.lboTipoProduto.TabIndex = 12
        Me.lboTipoProduto.Text = "Tipo de Serviço"
        '
        'lboReferencia
        '
        Me.lboReferencia.AutoSize = True
        Me.lboReferencia.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboReferencia.Location = New System.Drawing.Point(579, 11)
        Me.lboReferencia.Name = "lboReferencia"
        Me.lboReferencia.Size = New System.Drawing.Size(63, 16)
        Me.lboReferencia.TabIndex = 11
        Me.lboReferencia.Text = "Referência"
        '
        'lboDescricao
        '
        Me.lboDescricao.AutoSize = True
        Me.lboDescricao.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboDescricao.Location = New System.Drawing.Point(116, 11)
        Me.lboDescricao.Name = "lboDescricao"
        Me.lboDescricao.Size = New System.Drawing.Size(59, 16)
        Me.lboDescricao.TabIndex = 1
        Me.lboDescricao.Text = "Descrição"
        '
        'lboCodigo
        '
        Me.lboCodigo.AutoSize = True
        Me.lboCodigo.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboCodigo.Location = New System.Drawing.Point(8, 11)
        Me.lboCodigo.Name = "lboCodigo"
        Me.lboCodigo.Size = New System.Drawing.Size(46, 16)
        Me.lboCodigo.TabIndex = 0
        Me.lboCodigo.Text = "Código"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutoToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.RefernciasToolStripMenuItem, Me.MedidasToolStripMenuItem, Me.ImpostosToolStripMenuItem, Me.RelacionamentosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(790, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'FrmServicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 418)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlProdutos)
        Me.KeyPreview = True
        Me.Name = "FrmServicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicos"
        Me.pnlProdutos.ResumeLayout(False)
        Me.pnlBotoes.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlProdutos As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lboObservacoes As Label
    Friend WithEvents lboDescricaoDetalhada As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtCompraImposto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMarginLucro As TextBox
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents txtPrecoCompra As TextBox
    Friend WithEvents lboMarginLucro As Label
    Friend WithEvents lboPrecoVenda As Label
    Friend WithEvents lboPrecoCompra As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lboFornecedores As Label
    Friend WithEvents cboFornecedores As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lboStatus As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents cboTipoProduto As ComboBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lboCategoria As Label
    Friend WithEvents lboTipoProduto As Label
    Friend WithEvents lboReferencia As Label
    Friend WithEvents lboDescricao As Label
    Friend WithEvents lboCodigo As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefernciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelacionamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnSalvar As Button
End Class
