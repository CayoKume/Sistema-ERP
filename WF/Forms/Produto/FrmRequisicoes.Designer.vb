<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequisicoes
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
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.pnlProduto = New System.Windows.Forms.Panel()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.pnlRequisicao = New System.Windows.Forms.Panel()
        Me.lboFoto = New System.Windows.Forms.Label()
        Me.pctboxProduto = New System.Windows.Forms.PictureBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboAtendidoPor = New System.Windows.Forms.ComboBox()
        Me.cboAprovadoPor = New System.Windows.Forms.ComboBox()
        Me.cboSolicitadoPor = New System.Windows.Forms.ComboBox()
        Me.cboTipoRequisicao = New System.Windows.Forms.ComboBox()
        Me.lblDataConclusao = New System.Windows.Forms.Label()
        Me.txtHoraConclusao = New System.Windows.Forms.TextBox()
        Me.txtDataConclusao = New System.Windows.Forms.TextBox()
        Me.txtHoraAprovacao = New System.Windows.Forms.TextBox()
        Me.txtDataProvacao = New System.Windows.Forms.TextBox()
        Me.txtHoraEmissao = New System.Windows.Forms.TextBox()
        Me.txtDataEmissao = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblAprovadoPor = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblSolicitadoPor = New System.Windows.Forms.Label()
        Me.lblAtendidoPor = New System.Windows.Forms.Label()
        Me.lblDataAprovacao = New System.Windows.Forms.Label()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.lblTipoRequisicao = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.dgvRequisicoes = New System.Windows.Forms.DataGridView()
        Me.pnlBotoes.SuspendLayout()
        Me.pnlProduto.SuspendLayout()
        Me.pnlRequisicao.SuspendLayout()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequisicoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBotoes
        '
        Me.pnlBotoes.Controls.Add(Me.BtnPesquisar)
        Me.pnlBotoes.Controls.Add(Me.BtnImprimir)
        Me.pnlBotoes.Controls.Add(Me.BtnVoltar)
        Me.pnlBotoes.Controls.Add(Me.BtnLimpar)
        Me.pnlBotoes.Controls.Add(Me.BtnExcluir)
        Me.pnlBotoes.Controls.Add(Me.BtnSalvar)
        Me.pnlBotoes.Location = New System.Drawing.Point(50, 395)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(487, 28)
        Me.pnlBotoes.TabIndex = 50
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
        'pnlProduto
        '
        Me.pnlProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProduto.Controls.Add(Me.btnAlterar)
        Me.pnlProduto.Controls.Add(Me.btnRemover)
        Me.pnlProduto.Controls.Add(Me.btnAdicionar)
        Me.pnlProduto.Controls.Add(Me.cboProduto)
        Me.pnlProduto.Controls.Add(Me.txtQuantidade)
        Me.pnlProduto.Controls.Add(Me.txtReferencia)
        Me.pnlProduto.Controls.Add(Me.lblQuantidade)
        Me.pnlProduto.Controls.Add(Me.lblProduto)
        Me.pnlProduto.Controls.Add(Me.lblReferencia)
        Me.pnlProduto.Location = New System.Drawing.Point(0, 155)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(602, 37)
        Me.pnlProduto.TabIndex = 49
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(545, 7)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(46, 20)
        Me.btnAlterar.TabIndex = 47
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(515, 7)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(20, 20)
        Me.btnRemover.TabIndex = 46
        Me.btnRemover.Text = "-"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(485, 7)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(20, 20)
        Me.btnAdicionar.TabIndex = 45
        Me.btnAdicionar.Text = "+"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(200, 8)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(149, 21)
        Me.cboProduto.TabIndex = 44
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(423, 8)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(50, 20)
        Me.txtQuantidade.TabIndex = 43
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(69, 8)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(75, 20)
        Me.txtReferencia.TabIndex = 42
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(355, 11)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 40
        Me.lblQuantidade.Text = "Quantidade"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(150, 11)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(44, 13)
        Me.lblProduto.TabIndex = 39
        Me.lblProduto.Text = "Produto"
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(4, 11)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 38
        Me.lblReferencia.Text = "Referência"
        '
        'pnlRequisicao
        '
        Me.pnlRequisicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRequisicao.Controls.Add(Me.lboFoto)
        Me.pnlRequisicao.Controls.Add(Me.pctboxProduto)
        Me.pnlRequisicao.Controls.Add(Me.cboStatus)
        Me.pnlRequisicao.Controls.Add(Me.cboAtendidoPor)
        Me.pnlRequisicao.Controls.Add(Me.cboAprovadoPor)
        Me.pnlRequisicao.Controls.Add(Me.cboSolicitadoPor)
        Me.pnlRequisicao.Controls.Add(Me.cboTipoRequisicao)
        Me.pnlRequisicao.Controls.Add(Me.lblDataConclusao)
        Me.pnlRequisicao.Controls.Add(Me.txtHoraConclusao)
        Me.pnlRequisicao.Controls.Add(Me.txtDataConclusao)
        Me.pnlRequisicao.Controls.Add(Me.txtHoraAprovacao)
        Me.pnlRequisicao.Controls.Add(Me.txtDataProvacao)
        Me.pnlRequisicao.Controls.Add(Me.txtHoraEmissao)
        Me.pnlRequisicao.Controls.Add(Me.txtDataEmissao)
        Me.pnlRequisicao.Controls.Add(Me.txtCodigo)
        Me.pnlRequisicao.Controls.Add(Me.lblAprovadoPor)
        Me.pnlRequisicao.Controls.Add(Me.lblStatus)
        Me.pnlRequisicao.Controls.Add(Me.lblSolicitadoPor)
        Me.pnlRequisicao.Controls.Add(Me.lblAtendidoPor)
        Me.pnlRequisicao.Controls.Add(Me.lblDataAprovacao)
        Me.pnlRequisicao.Controls.Add(Me.lblDataEmissao)
        Me.pnlRequisicao.Controls.Add(Me.lblTipoRequisicao)
        Me.pnlRequisicao.Controls.Add(Me.lblCodigo)
        Me.pnlRequisicao.Location = New System.Drawing.Point(0, 0)
        Me.pnlRequisicao.Name = "pnlRequisicao"
        Me.pnlRequisicao.Size = New System.Drawing.Size(602, 149)
        Me.pnlRequisicao.TabIndex = 48
        '
        'lboFoto
        '
        Me.lboFoto.AutoSize = True
        Me.lboFoto.Location = New System.Drawing.Point(446, 6)
        Me.lboFoto.Name = "lboFoto"
        Me.lboFoto.Size = New System.Drawing.Size(28, 13)
        Me.lboFoto.TabIndex = 35
        Me.lboFoto.Text = "Foto"
        '
        'pctboxProduto
        '
        Me.pctboxProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctboxProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctboxProduto.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctboxProduto.Location = New System.Drawing.Point(439, 16)
        Me.pctboxProduto.Name = "pctboxProduto"
        Me.pctboxProduto.Size = New System.Drawing.Size(156, 116)
        Me.pctboxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctboxProduto.TabIndex = 36
        Me.pctboxProduto.TabStop = False
        Me.pctboxProduto.Tag = ""
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(354, 10)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(74, 21)
        Me.cboStatus.TabIndex = 19
        '
        'cboAtendidoPor
        '
        Me.cboAtendidoPor.FormattingEnabled = True
        Me.cboAtendidoPor.Location = New System.Drawing.Point(81, 116)
        Me.cboAtendidoPor.Name = "cboAtendidoPor"
        Me.cboAtendidoPor.Size = New System.Drawing.Size(110, 21)
        Me.cboAtendidoPor.TabIndex = 18
        '
        'cboAprovadoPor
        '
        Me.cboAprovadoPor.FormattingEnabled = True
        Me.cboAprovadoPor.Location = New System.Drawing.Point(81, 79)
        Me.cboAprovadoPor.Name = "cboAprovadoPor"
        Me.cboAprovadoPor.Size = New System.Drawing.Size(110, 21)
        Me.cboAprovadoPor.TabIndex = 18
        '
        'cboSolicitadoPor
        '
        Me.cboSolicitadoPor.FormattingEnabled = True
        Me.cboSolicitadoPor.Location = New System.Drawing.Point(81, 42)
        Me.cboSolicitadoPor.Name = "cboSolicitadoPor"
        Me.cboSolicitadoPor.Size = New System.Drawing.Size(110, 21)
        Me.cboSolicitadoPor.TabIndex = 18
        '
        'cboTipoRequisicao
        '
        Me.cboTipoRequisicao.FormattingEnabled = True
        Me.cboTipoRequisicao.Location = New System.Drawing.Point(195, 10)
        Me.cboTipoRequisicao.Name = "cboTipoRequisicao"
        Me.cboTipoRequisicao.Size = New System.Drawing.Size(110, 21)
        Me.cboTipoRequisicao.TabIndex = 18
        '
        'lblDataConclusao
        '
        Me.lblDataConclusao.AutoSize = True
        Me.lblDataConclusao.Location = New System.Drawing.Point(197, 119)
        Me.lblDataConclusao.Name = "lblDataConclusao"
        Me.lblDataConclusao.Size = New System.Drawing.Size(83, 13)
        Me.lblDataConclusao.TabIndex = 17
        Me.lblDataConclusao.Text = "Data Conclusão"
        '
        'txtHoraConclusao
        '
        Me.txtHoraConclusao.Location = New System.Drawing.Point(361, 116)
        Me.txtHoraConclusao.Name = "txtHoraConclusao"
        Me.txtHoraConclusao.Size = New System.Drawing.Size(67, 20)
        Me.txtHoraConclusao.TabIndex = 16
        '
        'txtDataConclusao
        '
        Me.txtDataConclusao.Location = New System.Drawing.Point(288, 116)
        Me.txtDataConclusao.Name = "txtDataConclusao"
        Me.txtDataConclusao.Size = New System.Drawing.Size(67, 20)
        Me.txtDataConclusao.TabIndex = 16
        '
        'txtHoraAprovacao
        '
        Me.txtHoraAprovacao.Location = New System.Drawing.Point(361, 79)
        Me.txtHoraAprovacao.Name = "txtHoraAprovacao"
        Me.txtHoraAprovacao.Size = New System.Drawing.Size(67, 20)
        Me.txtHoraAprovacao.TabIndex = 14
        '
        'txtDataProvacao
        '
        Me.txtDataProvacao.Location = New System.Drawing.Point(288, 79)
        Me.txtDataProvacao.Name = "txtDataProvacao"
        Me.txtDataProvacao.Size = New System.Drawing.Size(67, 20)
        Me.txtDataProvacao.TabIndex = 13
        '
        'txtHoraEmissao
        '
        Me.txtHoraEmissao.Location = New System.Drawing.Point(361, 42)
        Me.txtHoraEmissao.Name = "txtHoraEmissao"
        Me.txtHoraEmissao.Size = New System.Drawing.Size(67, 20)
        Me.txtHoraEmissao.TabIndex = 12
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.Location = New System.Drawing.Point(288, 42)
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.Size = New System.Drawing.Size(67, 20)
        Me.txtDataEmissao.TabIndex = 11
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(49, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'lblAprovadoPor
        '
        Me.lblAprovadoPor.AutoSize = True
        Me.lblAprovadoPor.Location = New System.Drawing.Point(3, 82)
        Me.lblAprovadoPor.Name = "lblAprovadoPor"
        Me.lblAprovadoPor.Size = New System.Drawing.Size(72, 13)
        Me.lblAprovadoPor.TabIndex = 7
        Me.lblAprovadoPor.Text = "Aprovado Por"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(311, 13)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Status"
        '
        'lblSolicitadoPor
        '
        Me.lblSolicitadoPor.AutoSize = True
        Me.lblSolicitadoPor.Location = New System.Drawing.Point(3, 45)
        Me.lblSolicitadoPor.Name = "lblSolicitadoPor"
        Me.lblSolicitadoPor.Size = New System.Drawing.Size(72, 13)
        Me.lblSolicitadoPor.TabIndex = 6
        Me.lblSolicitadoPor.Text = "Solicitado Por"
        '
        'lblAtendidoPor
        '
        Me.lblAtendidoPor.AutoSize = True
        Me.lblAtendidoPor.Location = New System.Drawing.Point(3, 119)
        Me.lblAtendidoPor.Name = "lblAtendidoPor"
        Me.lblAtendidoPor.Size = New System.Drawing.Size(68, 13)
        Me.lblAtendidoPor.TabIndex = 8
        Me.lblAtendidoPor.Text = "Atendido Por"
        '
        'lblDataAprovacao
        '
        Me.lblDataAprovacao.AutoSize = True
        Me.lblDataAprovacao.Location = New System.Drawing.Point(197, 82)
        Me.lblDataAprovacao.Name = "lblDataAprovacao"
        Me.lblDataAprovacao.Size = New System.Drawing.Size(85, 13)
        Me.lblDataAprovacao.TabIndex = 4
        Me.lblDataAprovacao.Text = "Data Aprovação"
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(197, 45)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(72, 13)
        Me.lblDataEmissao.TabIndex = 3
        Me.lblDataEmissao.Text = "Data Emissão"
        '
        'lblTipoRequisicao
        '
        Me.lblTipoRequisicao.AutoSize = True
        Me.lblTipoRequisicao.Location = New System.Drawing.Point(105, 13)
        Me.lblTipoRequisicao.Name = "lblTipoRequisicao"
        Me.lblTipoRequisicao.Size = New System.Drawing.Size(84, 13)
        Me.lblTipoRequisicao.TabIndex = 2
        Me.lblTipoRequisicao.Text = "Tipo Requisição"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(3, 13)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código"
        '
        'dgvRequisicoes
        '
        Me.dgvRequisicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequisicoes.Location = New System.Drawing.Point(0, 198)
        Me.dgvRequisicoes.Name = "dgvRequisicoes"
        Me.dgvRequisicoes.Size = New System.Drawing.Size(602, 191)
        Me.dgvRequisicoes.TabIndex = 47
        '
        'FrmRequisicoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 427)
        Me.Controls.Add(Me.pnlBotoes)
        Me.Controls.Add(Me.pnlProduto)
        Me.Controls.Add(Me.pnlRequisicao)
        Me.Controls.Add(Me.dgvRequisicoes)
        Me.Name = "FrmRequisicoes"
        Me.Text = "FrmRequisicoes"
        Me.pnlBotoes.ResumeLayout(False)
        Me.pnlProduto.ResumeLayout(False)
        Me.pnlProduto.PerformLayout()
        Me.pnlRequisicao.ResumeLayout(False)
        Me.pnlRequisicao.PerformLayout()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequisicoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents pnlProduto As Panel
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents cboProduto As ComboBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents lblProduto As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents pnlRequisicao As Panel
    Friend WithEvents lboFoto As Label
    Friend WithEvents pctboxProduto As PictureBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboAtendidoPor As ComboBox
    Friend WithEvents cboAprovadoPor As ComboBox
    Friend WithEvents cboSolicitadoPor As ComboBox
    Friend WithEvents cboTipoRequisicao As ComboBox
    Friend WithEvents lblDataConclusao As Label
    Friend WithEvents txtHoraConclusao As TextBox
    Friend WithEvents txtDataConclusao As TextBox
    Friend WithEvents txtHoraAprovacao As TextBox
    Friend WithEvents txtDataProvacao As TextBox
    Friend WithEvents txtHoraEmissao As TextBox
    Friend WithEvents txtDataEmissao As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblAprovadoPor As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblSolicitadoPor As Label
    Friend WithEvents lblAtendidoPor As Label
    Friend WithEvents lblDataAprovacao As Label
    Friend WithEvents lblDataEmissao As Label
    Friend WithEvents lblTipoRequisicao As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents dgvRequisicoes As DataGridView
End Class
