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
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCategoriaProduto = New System.Windows.Forms.Label()
        Me.lblCatalago = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.chkProdutoAcabado = New System.Windows.Forms.CheckBox()
        Me.lblTipoProduto = New System.Windows.Forms.Label()
        Me.chkMateriaPrima = New System.Windows.Forms.CheckBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.chkServicos = New System.Windows.Forms.CheckBox()
        Me.chkProdutoRevenda = New System.Windows.Forms.CheckBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lboFoto = New System.Windows.Forms.Label()
        Me.pctboxProduto = New System.Windows.Forms.PictureBox()
        Me.dgvBuscaProdutos = New System.Windows.Forms.DataGridView()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.BtnConfiguracao = New System.Windows.Forms.Button()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuscaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.BtnConfiguracao)
        Me.pnlPrincipal.Controls.Add(Me.BtnPesquisar)
        Me.pnlPrincipal.Controls.Add(Me.BtnVoltar)
        Me.pnlPrincipal.Controls.Add(Me.dgvBuscaProdutos)
        Me.pnlPrincipal.Controls.Add(Me.lboFoto)
        Me.pnlPrincipal.Controls.Add(Me.pctboxProduto)
        Me.pnlPrincipal.Controls.Add(Me.ComboBox4)
        Me.pnlPrincipal.Controls.Add(Me.ComboBox3)
        Me.pnlPrincipal.Controls.Add(Me.ComboBox2)
        Me.pnlPrincipal.Controls.Add(Me.ComboBox1)
        Me.pnlPrincipal.Controls.Add(Me.TextBox2)
        Me.pnlPrincipal.Controls.Add(Me.TextBox1)
        Me.pnlPrincipal.Controls.Add(Me.lblCategoriaProduto)
        Me.pnlPrincipal.Controls.Add(Me.lblCatalago)
        Me.pnlPrincipal.Controls.Add(Me.lblFornecedor)
        Me.pnlPrincipal.Controls.Add(Me.chkProdutoAcabado)
        Me.pnlPrincipal.Controls.Add(Me.lblTipoProduto)
        Me.pnlPrincipal.Controls.Add(Me.chkMateriaPrima)
        Me.pnlPrincipal.Controls.Add(Me.lblDescricao)
        Me.pnlPrincipal.Controls.Add(Me.chkServicos)
        Me.pnlPrincipal.Controls.Add(Me.chkProdutoRevenda)
        Me.pnlPrincipal.Controls.Add(Me.lblReferencia)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(626, 444)
        Me.pnlPrincipal.TabIndex = 0
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(245, 114)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 12
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(118, 114)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(15, 114)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(245, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(15, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'lblCategoriaProduto
        '
        Me.lblCategoriaProduto.AutoSize = True
        Me.lblCategoriaProduto.Location = New System.Drawing.Point(115, 98)
        Me.lblCategoriaProduto.Name = "lblCategoriaProduto"
        Me.lblCategoriaProduto.Size = New System.Drawing.Size(92, 13)
        Me.lblCategoriaProduto.TabIndex = 5
        Me.lblCategoriaProduto.Text = "Categoria Produto"
        '
        'lblCatalago
        '
        Me.lblCatalago.AutoSize = True
        Me.lblCatalago.Location = New System.Drawing.Point(242, 49)
        Me.lblCatalago.Name = "lblCatalago"
        Me.lblCatalago.Size = New System.Drawing.Size(49, 13)
        Me.lblCatalago.TabIndex = 2
        Me.lblCatalago.Text = "Catálago"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(242, 98)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(61, 13)
        Me.lblFornecedor.TabIndex = 6
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'chkProdutoAcabado
        '
        Me.chkProdutoAcabado.AutoSize = True
        Me.chkProdutoAcabado.Location = New System.Drawing.Point(297, 16)
        Me.chkProdutoAcabado.Name = "chkProdutoAcabado"
        Me.chkProdutoAcabado.Size = New System.Drawing.Size(109, 17)
        Me.chkProdutoAcabado.TabIndex = 3
        Me.chkProdutoAcabado.Text = "Produto Acabado"
        Me.chkProdutoAcabado.UseVisualStyleBackColor = True
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
        'chkMateriaPrima
        '
        Me.chkMateriaPrima.AutoSize = True
        Me.chkMateriaPrima.Location = New System.Drawing.Point(201, 16)
        Me.chkMateriaPrima.Name = "chkMateriaPrima"
        Me.chkMateriaPrima.Size = New System.Drawing.Size(90, 17)
        Me.chkMateriaPrima.TabIndex = 2
        Me.chkMateriaPrima.Text = "Matéria Prima"
        Me.chkMateriaPrima.UseVisualStyleBackColor = True
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
        'chkServicos
        '
        Me.chkServicos.AutoSize = True
        Me.chkServicos.Location = New System.Drawing.Point(128, 16)
        Me.chkServicos.Name = "chkServicos"
        Me.chkServicos.Size = New System.Drawing.Size(67, 17)
        Me.chkServicos.TabIndex = 1
        Me.chkServicos.Text = "Serviços"
        Me.chkServicos.UseVisualStyleBackColor = True
        '
        'chkProdutoRevenda
        '
        Me.chkProdutoRevenda.AutoSize = True
        Me.chkProdutoRevenda.Location = New System.Drawing.Point(12, 16)
        Me.chkProdutoRevenda.Name = "chkProdutoRevenda"
        Me.chkProdutoRevenda.Size = New System.Drawing.Size(110, 17)
        Me.chkProdutoRevenda.TabIndex = 0
        Me.chkProdutoRevenda.Text = "Produto Revenda"
        Me.chkProdutoRevenda.UseVisualStyleBackColor = True
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(136, 49)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 1
        Me.lblReferencia.Text = "Referência"
        '
        'lboFoto
        '
        Me.lboFoto.AutoSize = True
        Me.lboFoto.Location = New System.Drawing.Point(443, 12)
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
        Me.pctboxProduto.Location = New System.Drawing.Point(438, 19)
        Me.pctboxProduto.Name = "pctboxProduto"
        Me.pctboxProduto.Size = New System.Drawing.Size(156, 116)
        Me.pctboxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctboxProduto.TabIndex = 36
        Me.pctboxProduto.TabStop = False
        Me.pctboxProduto.Tag = ""
        '
        'dgvBuscaProdutos
        '
        Me.dgvBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscaProdutos.Location = New System.Drawing.Point(12, 147)
        Me.dgvBuscaProdutos.Name = "dgvBuscaProdutos"
        Me.dgvBuscaProdutos.Size = New System.Drawing.Size(602, 260)
        Me.dgvBuscaProdutos.TabIndex = 37
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(539, 413)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 38
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Location = New System.Drawing.Point(458, 413)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.BtnPesquisar.TabIndex = 39
        Me.BtnPesquisar.Text = "Pesquisar"
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'BtnConfiguracao
        '
        Me.BtnConfiguracao.Location = New System.Drawing.Point(12, 413)
        Me.BtnConfiguracao.Name = "BtnConfiguracao"
        Me.BtnConfiguracao.Size = New System.Drawing.Size(81, 23)
        Me.BtnConfiguracao.TabIndex = 40
        Me.BtnConfiguracao.Text = "Configuração"
        Me.BtnConfiguracao.UseVisualStyleBackColor = True
        '
        'FrmBuscaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 442)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "FrmBuscaProduto"
        Me.Text = "FrmBuscaProduto"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.pctboxProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuscaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents chkProdutoAcabado As CheckBox
    Friend WithEvents chkMateriaPrima As CheckBox
    Friend WithEvents chkServicos As CheckBox
    Friend WithEvents chkProdutoRevenda As CheckBox
    Friend WithEvents lblCategoriaProduto As Label
    Friend WithEvents lblCatalago As Label
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblTipoProduto As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lboFoto As Label
    Friend WithEvents pctboxProduto As PictureBox
    Friend WithEvents dgvBuscaProdutos As DataGridView
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents BtnConfiguracao As Button
End Class
