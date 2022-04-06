<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaProduto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.rdoProdutoAcabado = New System.Windows.Forms.RadioButton()
        Me.rdoMateriaPrima = New System.Windows.Forms.RadioButton()
        Me.rdoServicos = New System.Windows.Forms.RadioButton()
        Me.rdoProdutoRevenda = New System.Windows.Forms.RadioButton()
        Me.btnConfiguracao = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.dgvBuscaProdutos = New System.Windows.Forms.DataGridView()
        Me.lboFoto = New System.Windows.Forms.Label()
        Me.pctboxProduto = New System.Windows.Forms.PictureBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboFornecedores = New System.Windows.Forms.ComboBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.cboTipoProduto = New System.Windows.Forms.ComboBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblCategoriaProduto = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblTipoProduto = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvBuscaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.BtnLimpar)
        Me.pnlPrincipal.Controls.Add(Me.rdoProdutoAcabado)
        Me.pnlPrincipal.Controls.Add(Me.rdoMateriaPrima)
        Me.pnlPrincipal.Controls.Add(Me.rdoServicos)
        Me.pnlPrincipal.Controls.Add(Me.rdoProdutoRevenda)
        Me.pnlPrincipal.Controls.Add(Me.btnConfiguracao)
        Me.pnlPrincipal.Controls.Add(Me.btnPesquisar)
        Me.pnlPrincipal.Controls.Add(Me.btnVoltar)
        Me.pnlPrincipal.Controls.Add(Me.dgvBuscaProdutos)
        Me.pnlPrincipal.Controls.Add(Me.lboFoto)
        Me.pnlPrincipal.Controls.Add(Me.pctboxProduto)
        Me.pnlPrincipal.Controls.Add(Me.cboStatus)
        Me.pnlPrincipal.Controls.Add(Me.cboFornecedores)
        Me.pnlPrincipal.Controls.Add(Me.cboCategoria)
        Me.pnlPrincipal.Controls.Add(Me.cboTipoProduto)
        Me.pnlPrincipal.Controls.Add(Me.txtDescricao)
        Me.pnlPrincipal.Controls.Add(Me.txtReferencia)
        Me.pnlPrincipal.Controls.Add(Me.lblCategoriaProduto)
        Me.pnlPrincipal.Controls.Add(Me.lblStatus)
        Me.pnlPrincipal.Controls.Add(Me.lblFornecedor)
        Me.pnlPrincipal.Controls.Add(Me.lblTipoProduto)
        Me.pnlPrincipal.Controls.Add(Me.lblDescricao)
        Me.pnlPrincipal.Controls.Add(Me.lblReferencia)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(626, 444)
        Me.pnlPrincipal.TabIndex = 0
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(458, 413)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 45
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'rdoProdutoAcabado
        '
        Me.rdoProdutoAcabado.AutoSize = True
        Me.rdoProdutoAcabado.Location = New System.Drawing.Point(295, 15)
        Me.rdoProdutoAcabado.Name = "rdoProdutoAcabado"
        Me.rdoProdutoAcabado.Size = New System.Drawing.Size(108, 17)
        Me.rdoProdutoAcabado.TabIndex = 44
        Me.rdoProdutoAcabado.TabStop = True
        Me.rdoProdutoAcabado.Text = "Produto Acabado"
        Me.rdoProdutoAcabado.UseVisualStyleBackColor = True
        '
        'rdoMateriaPrima
        '
        Me.rdoMateriaPrima.AutoSize = True
        Me.rdoMateriaPrima.Location = New System.Drawing.Point(200, 15)
        Me.rdoMateriaPrima.Name = "rdoMateriaPrima"
        Me.rdoMateriaPrima.Size = New System.Drawing.Size(89, 17)
        Me.rdoMateriaPrima.TabIndex = 43
        Me.rdoMateriaPrima.TabStop = True
        Me.rdoMateriaPrima.Text = "Matéria Prima"
        Me.rdoMateriaPrima.UseVisualStyleBackColor = True
        '
        'rdoServicos
        '
        Me.rdoServicos.AutoSize = True
        Me.rdoServicos.Location = New System.Drawing.Point(128, 15)
        Me.rdoServicos.Name = "rdoServicos"
        Me.rdoServicos.Size = New System.Drawing.Size(66, 17)
        Me.rdoServicos.TabIndex = 42
        Me.rdoServicos.TabStop = True
        Me.rdoServicos.Text = "Serviços"
        Me.rdoServicos.UseVisualStyleBackColor = True
        '
        'rdoProdutoRevenda
        '
        Me.rdoProdutoRevenda.AutoSize = True
        Me.rdoProdutoRevenda.Location = New System.Drawing.Point(13, 15)
        Me.rdoProdutoRevenda.Name = "rdoProdutoRevenda"
        Me.rdoProdutoRevenda.Size = New System.Drawing.Size(109, 17)
        Me.rdoProdutoRevenda.TabIndex = 41
        Me.rdoProdutoRevenda.TabStop = True
        Me.rdoProdutoRevenda.Text = "Produto Revenda"
        Me.rdoProdutoRevenda.UseVisualStyleBackColor = True
        '
        'btnConfiguracao
        '
        Me.btnConfiguracao.Location = New System.Drawing.Point(12, 413)
        Me.btnConfiguracao.Name = "btnConfiguracao"
        Me.btnConfiguracao.Size = New System.Drawing.Size(81, 23)
        Me.btnConfiguracao.TabIndex = 2
        Me.btnConfiguracao.Text = "Configuração"
        Me.btnConfiguracao.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(377, 413)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 3
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(539, 413)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'dgvBuscaProdutos
        '
        Me.dgvBuscaProdutos.AllowUserToAddRows = False
        Me.dgvBuscaProdutos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBuscaProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscaProdutos.Location = New System.Drawing.Point(12, 147)
        Me.dgvBuscaProdutos.Name = "dgvBuscaProdutos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvBuscaProdutos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBuscaProdutos.Size = New System.Drawing.Size(602, 260)
        Me.dgvBuscaProdutos.TabIndex = 37
        '
        'lboFoto
        '
        Me.lboFoto.AutoSize = True
        Me.lboFoto.Location = New System.Drawing.Point(436, 12)
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
        Me.pctboxProduto.Location = New System.Drawing.Point(431, 19)
        Me.pctboxProduto.Name = "pctboxProduto"
        Me.pctboxProduto.Size = New System.Drawing.Size(156, 116)
        Me.pctboxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctboxProduto.TabIndex = 36
        Me.pctboxProduto.TabStop = False
        Me.pctboxProduto.Tag = ""
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(277, 64)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(99, 21)
        Me.cboStatus.TabIndex = 12
        '
        'cboFornecedores
        '
        Me.cboFornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFornecedores.FormattingEnabled = True
        Me.cboFornecedores.Location = New System.Drawing.Point(264, 114)
        Me.cboFornecedores.Name = "cboFornecedores"
        Me.cboFornecedores.Size = New System.Drawing.Size(112, 21)
        Me.cboFornecedores.TabIndex = 12
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(139, 114)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(119, 21)
        Me.cboCategoria.TabIndex = 11
        '
        'cboTipoProduto
        '
        Me.cboTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProduto.FormattingEnabled = True
        Me.cboTipoProduto.Location = New System.Drawing.Point(15, 114)
        Me.cboTipoProduto.Name = "cboTipoProduto"
        Me.cboTipoProduto.Size = New System.Drawing.Size(118, 21)
        Me.cboTipoProduto.TabIndex = 10
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(15, 65)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(150, 20)
        Me.txtDescricao.TabIndex = 0
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(171, 65)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtReferencia.TabIndex = 1
        '
        'lblCategoriaProduto
        '
        Me.lblCategoriaProduto.AutoSize = True
        Me.lblCategoriaProduto.Location = New System.Drawing.Point(136, 98)
        Me.lblCategoriaProduto.Name = "lblCategoriaProduto"
        Me.lblCategoriaProduto.Size = New System.Drawing.Size(92, 13)
        Me.lblCategoriaProduto.TabIndex = 5
        Me.lblCategoriaProduto.Text = "Categoria Produto"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(274, 48)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(261, 98)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(61, 13)
        Me.lblFornecedor.TabIndex = 6
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'lblTipoProduto
        '
        Me.lblTipoProduto.AutoSize = True
        Me.lblTipoProduto.Location = New System.Drawing.Point(12, 98)
        Me.lblTipoProduto.Name = "lblTipoProduto"
        Me.lblTipoProduto.Size = New System.Drawing.Size(68, 13)
        Me.lblTipoProduto.TabIndex = 4
        Me.lblTipoProduto.Text = "Tipo Produto"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(12, 49)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(55, 13)
        Me.lblDescricao.TabIndex = 3
        Me.lblDescricao.Text = "Descrição"
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(168, 49)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 1
        Me.lblReferencia.Text = "Referência"
        '
        'FrmBuscaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 442)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "FrmBuscaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBuscaProduto"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.dgvBuscaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents lblCategoriaProduto As Label
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblTipoProduto As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents cboFornecedores As ComboBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents cboTipoProduto As ComboBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lboFoto As Label
    Friend WithEvents pctboxProduto As PictureBox
    Friend WithEvents dgvBuscaProdutos As DataGridView
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnConfiguracao As Button
    Friend WithEvents rdoProdutoAcabado As RadioButton
    Friend WithEvents rdoMateriaPrima As RadioButton
    Friend WithEvents rdoServicos As RadioButton
    Friend WithEvents rdoProdutoRevenda As RadioButton
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents BtnLimpar As Button
End Class
