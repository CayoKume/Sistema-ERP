<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedidas
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
        Me.lboQtdCaixa = New System.Windows.Forms.Label()
        Me.lboPesoUnitario = New System.Windows.Forms.Label()
        Me.lboKiloCaixa = New System.Windows.Forms.Label()
        Me.lboAltura = New System.Windows.Forms.Label()
        Me.lboLargura = New System.Windows.Forms.Label()
        Me.lboComprimento = New System.Windows.Forms.Label()
        Me.pnlDimensoes = New System.Windows.Forms.Panel()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.txtComprimento = New System.Windows.Forms.TextBox()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lboVolume = New System.Windows.Forms.Label()
        Me.pnlPesos = New System.Windows.Forms.Panel()
        Me.txtKiloCaixa = New System.Windows.Forms.TextBox()
        Me.txtPesoUnitario = New System.Windows.Forms.TextBox()
        Me.pnlUnidades = New System.Windows.Forms.Panel()
        Me.BtnMedidaEstoque = New System.Windows.Forms.Button()
        Me.BtnlboMedidaCompra = New System.Windows.Forms.Button()
        Me.cboMedidaEstoque = New System.Windows.Forms.ComboBox()
        Me.cboMedidaCompra = New System.Windows.Forms.ComboBox()
        Me.txtTaxaDeConversao = New System.Windows.Forms.TextBox()
        Me.lboTaxaDeConversao = New System.Windows.Forms.Label()
        Me.txtQtdCaixa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lboPesos = New System.Windows.Forms.Label()
        Me.lboUnidade = New System.Windows.Forms.Label()
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.pnlDimensoes.SuspendLayout()
        Me.pnlPesos.SuspendLayout()
        Me.pnlUnidades.SuspendLayout()
        Me.pnlBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboQtdCaixa
        '
        Me.lboQtdCaixa.AutoSize = True
        Me.lboQtdCaixa.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboQtdCaixa.Location = New System.Drawing.Point(8, 70)
        Me.lboQtdCaixa.Name = "lboQtdCaixa"
        Me.lboQtdCaixa.Size = New System.Drawing.Size(86, 16)
        Me.lboQtdCaixa.TabIndex = 0
        Me.lboQtdCaixa.Text = "Qtde por Caixa"
        '
        'lboPesoUnitario
        '
        Me.lboPesoUnitario.AutoSize = True
        Me.lboPesoUnitario.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboPesoUnitario.Location = New System.Drawing.Point(8, 16)
        Me.lboPesoUnitario.Name = "lboPesoUnitario"
        Me.lboPesoUnitario.Size = New System.Drawing.Size(125, 16)
        Me.lboPesoUnitario.TabIndex = 0
        Me.lboPesoUnitario.Text = "Peso Unitário(Gramas)"
        '
        'lboKiloCaixa
        '
        Me.lboKiloCaixa.AutoSize = True
        Me.lboKiloCaixa.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboKiloCaixa.Location = New System.Drawing.Point(8, 45)
        Me.lboKiloCaixa.Name = "lboKiloCaixa"
        Me.lboKiloCaixa.Size = New System.Drawing.Size(85, 16)
        Me.lboKiloCaixa.TabIndex = 0
        Me.lboKiloCaixa.Text = "Kilos por Caixa"
        '
        'lboAltura
        '
        Me.lboAltura.AutoSize = True
        Me.lboAltura.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboAltura.Location = New System.Drawing.Point(8, 16)
        Me.lboAltura.Name = "lboAltura"
        Me.lboAltura.Size = New System.Drawing.Size(40, 16)
        Me.lboAltura.TabIndex = 0
        Me.lboAltura.Text = "Altura"
        '
        'lboLargura
        '
        Me.lboLargura.AutoSize = True
        Me.lboLargura.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboLargura.Location = New System.Drawing.Point(8, 41)
        Me.lboLargura.Name = "lboLargura"
        Me.lboLargura.Size = New System.Drawing.Size(48, 16)
        Me.lboLargura.TabIndex = 0
        Me.lboLargura.Text = "Largura"
        '
        'lboComprimento
        '
        Me.lboComprimento.AutoSize = True
        Me.lboComprimento.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboComprimento.Location = New System.Drawing.Point(8, 66)
        Me.lboComprimento.Name = "lboComprimento"
        Me.lboComprimento.Size = New System.Drawing.Size(80, 16)
        Me.lboComprimento.TabIndex = 0
        Me.lboComprimento.Text = "Comprimento"
        '
        'pnlDimensoes
        '
        Me.pnlDimensoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDimensoes.Controls.Add(Me.txtVolume)
        Me.pnlDimensoes.Controls.Add(Me.txtComprimento)
        Me.pnlDimensoes.Controls.Add(Me.txtLargura)
        Me.pnlDimensoes.Controls.Add(Me.txtAltura)
        Me.pnlDimensoes.Controls.Add(Me.lboVolume)
        Me.pnlDimensoes.Controls.Add(Me.lboComprimento)
        Me.pnlDimensoes.Controls.Add(Me.lboLargura)
        Me.pnlDimensoes.Controls.Add(Me.lboAltura)
        Me.pnlDimensoes.Location = New System.Drawing.Point(5, 240)
        Me.pnlDimensoes.Name = "pnlDimensoes"
        Me.pnlDimensoes.Size = New System.Drawing.Size(323, 122)
        Me.pnlDimensoes.TabIndex = 2
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(203, 90)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(113, 20)
        Me.txtVolume.TabIndex = 3
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComprimento
        '
        Me.txtComprimento.Location = New System.Drawing.Point(203, 64)
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.Size = New System.Drawing.Size(113, 20)
        Me.txtComprimento.TabIndex = 2
        Me.txtComprimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLargura
        '
        Me.txtLargura.Location = New System.Drawing.Point(203, 39)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(113, 20)
        Me.txtLargura.TabIndex = 1
        Me.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(203, 14)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(113, 20)
        Me.txtAltura.TabIndex = 0
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboVolume
        '
        Me.lboVolume.AutoSize = True
        Me.lboVolume.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboVolume.Location = New System.Drawing.Point(8, 92)
        Me.lboVolume.Name = "lboVolume"
        Me.lboVolume.Size = New System.Drawing.Size(70, 16)
        Me.lboVolume.TabIndex = 0
        Me.lboVolume.Text = "Volume(m³)"
        '
        'pnlPesos
        '
        Me.pnlPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPesos.Controls.Add(Me.txtKiloCaixa)
        Me.pnlPesos.Controls.Add(Me.txtPesoUnitario)
        Me.pnlPesos.Controls.Add(Me.lboKiloCaixa)
        Me.pnlPesos.Controls.Add(Me.lboPesoUnitario)
        Me.pnlPesos.Location = New System.Drawing.Point(5, 158)
        Me.pnlPesos.Name = "pnlPesos"
        Me.pnlPesos.Size = New System.Drawing.Size(323, 72)
        Me.pnlPesos.TabIndex = 1
        '
        'txtKiloCaixa
        '
        Me.txtKiloCaixa.Location = New System.Drawing.Point(203, 43)
        Me.txtKiloCaixa.Name = "txtKiloCaixa"
        Me.txtKiloCaixa.Size = New System.Drawing.Size(113, 20)
        Me.txtKiloCaixa.TabIndex = 1
        Me.txtKiloCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPesoUnitario
        '
        Me.txtPesoUnitario.Location = New System.Drawing.Point(203, 14)
        Me.txtPesoUnitario.Name = "txtPesoUnitario"
        Me.txtPesoUnitario.Size = New System.Drawing.Size(113, 20)
        Me.txtPesoUnitario.TabIndex = 0
        Me.txtPesoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlUnidades
        '
        Me.pnlUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUnidades.Controls.Add(Me.BtnMedidaEstoque)
        Me.pnlUnidades.Controls.Add(Me.BtnlboMedidaCompra)
        Me.pnlUnidades.Controls.Add(Me.cboMedidaEstoque)
        Me.pnlUnidades.Controls.Add(Me.cboMedidaCompra)
        Me.pnlUnidades.Controls.Add(Me.txtTaxaDeConversao)
        Me.pnlUnidades.Controls.Add(Me.lboTaxaDeConversao)
        Me.pnlUnidades.Controls.Add(Me.txtQtdCaixa)
        Me.pnlUnidades.Controls.Add(Me.lboQtdCaixa)
        Me.pnlUnidades.Location = New System.Drawing.Point(5, 25)
        Me.pnlUnidades.Name = "pnlUnidades"
        Me.pnlUnidades.Size = New System.Drawing.Size(323, 124)
        Me.pnlUnidades.TabIndex = 0
        '
        'BtnMedidaEstoque
        '
        Me.BtnMedidaEstoque.BackColor = System.Drawing.Color.Transparent
        Me.BtnMedidaEstoque.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnMedidaEstoque.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnMedidaEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnMedidaEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnMedidaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMedidaEstoque.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedidaEstoque.Location = New System.Drawing.Point(6, 41)
        Me.BtnMedidaEstoque.Name = "BtnMedidaEstoque"
        Me.BtnMedidaEstoque.Size = New System.Drawing.Size(191, 23)
        Me.BtnMedidaEstoque.TabIndex = 5
        Me.BtnMedidaEstoque.Text = "Unidade de Medida do Estoque"
        Me.BtnMedidaEstoque.UseVisualStyleBackColor = False
        '
        'BtnlboMedidaCompra
        '
        Me.BtnlboMedidaCompra.BackColor = System.Drawing.Color.Transparent
        Me.BtnlboMedidaCompra.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnlboMedidaCompra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnlboMedidaCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnlboMedidaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnlboMedidaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnlboMedidaCompra.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnlboMedidaCompra.Location = New System.Drawing.Point(6, 14)
        Me.BtnlboMedidaCompra.Name = "BtnlboMedidaCompra"
        Me.BtnlboMedidaCompra.Size = New System.Drawing.Size(191, 23)
        Me.BtnlboMedidaCompra.TabIndex = 4
        Me.BtnlboMedidaCompra.Text = "Unidade de Medida da Compra"
        Me.BtnlboMedidaCompra.UseVisualStyleBackColor = False
        '
        'cboMedidaEstoque
        '
        Me.cboMedidaEstoque.FormattingEnabled = True
        Me.cboMedidaEstoque.Location = New System.Drawing.Point(203, 41)
        Me.cboMedidaEstoque.Name = "cboMedidaEstoque"
        Me.cboMedidaEstoque.Size = New System.Drawing.Size(113, 21)
        Me.cboMedidaEstoque.TabIndex = 1
        '
        'cboMedidaCompra
        '
        Me.cboMedidaCompra.FormattingEnabled = True
        Me.cboMedidaCompra.Location = New System.Drawing.Point(203, 14)
        Me.cboMedidaCompra.Name = "cboMedidaCompra"
        Me.cboMedidaCompra.Size = New System.Drawing.Size(113, 21)
        Me.cboMedidaCompra.TabIndex = 0
        '
        'txtTaxaDeConversao
        '
        Me.txtTaxaDeConversao.Location = New System.Drawing.Point(203, 94)
        Me.txtTaxaDeConversao.Name = "txtTaxaDeConversao"
        Me.txtTaxaDeConversao.Size = New System.Drawing.Size(113, 20)
        Me.txtTaxaDeConversao.TabIndex = 3
        Me.txtTaxaDeConversao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboTaxaDeConversao
        '
        Me.lboTaxaDeConversao.AutoSize = True
        Me.lboTaxaDeConversao.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboTaxaDeConversao.Location = New System.Drawing.Point(8, 96)
        Me.lboTaxaDeConversao.Name = "lboTaxaDeConversao"
        Me.lboTaxaDeConversao.Size = New System.Drawing.Size(106, 16)
        Me.lboTaxaDeConversao.TabIndex = 0
        Me.lboTaxaDeConversao.Text = "Taxa de Conversão"
        '
        'txtQtdCaixa
        '
        Me.txtQtdCaixa.Location = New System.Drawing.Point(203, 68)
        Me.txtQtdCaixa.Name = "txtQtdCaixa"
        Me.txtQtdCaixa.Size = New System.Drawing.Size(113, 20)
        Me.txtQtdCaixa.TabIndex = 2
        Me.txtQtdCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Dimensões"
        '
        'lboPesos
        '
        Me.lboPesos.AutoSize = True
        Me.lboPesos.Location = New System.Drawing.Point(14, 152)
        Me.lboPesos.Name = "lboPesos"
        Me.lboPesos.Size = New System.Drawing.Size(36, 13)
        Me.lboPesos.TabIndex = 0
        Me.lboPesos.Text = "Pesos"
        '
        'lboUnidade
        '
        Me.lboUnidade.AutoSize = True
        Me.lboUnidade.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboUnidade.Location = New System.Drawing.Point(13, 15)
        Me.lboUnidade.Name = "lboUnidade"
        Me.lboUnidade.Size = New System.Drawing.Size(57, 16)
        Me.lboUnidade.TabIndex = 0
        Me.lboUnidade.Text = "Unidades"
        '
        'pnlBotoes
        '
        Me.pnlBotoes.Controls.Add(Me.BtnVoltar)
        Me.pnlBotoes.Controls.Add(Me.BtnSalvar)
        Me.pnlBotoes.Location = New System.Drawing.Point(167, 368)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(161, 24)
        Me.pnlBotoes.TabIndex = 3
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(83, 1)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 1
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(2, 1)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 0
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'FrmMedidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 404)
        Me.Controls.Add(Me.pnlBotoes)
        Me.Controls.Add(Me.lboUnidade)
        Me.Controls.Add(Me.lboPesos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pnlUnidades)
        Me.Controls.Add(Me.pnlPesos)
        Me.Controls.Add(Me.pnlDimensoes)
        Me.MaximizeBox = False
        Me.Name = "FrmMedidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medidas"
        Me.pnlDimensoes.ResumeLayout(False)
        Me.pnlDimensoes.PerformLayout()
        Me.pnlPesos.ResumeLayout(False)
        Me.pnlPesos.PerformLayout()
        Me.pnlUnidades.ResumeLayout(False)
        Me.pnlUnidades.PerformLayout()
        Me.pnlBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lboQtdCaixa As Label
    Friend WithEvents lboPesoUnitario As Label
    Friend WithEvents lboKiloCaixa As Label
    Friend WithEvents lboAltura As Label
    Friend WithEvents lboLargura As Label
    Friend WithEvents lboComprimento As Label
    Friend WithEvents pnlDimensoes As Panel
    Friend WithEvents lboVolume As Label
    Friend WithEvents pnlPesos As Panel
    Friend WithEvents pnlUnidades As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lboPesos As Label
    Friend WithEvents txtKiloCaixa As TextBox
    Friend WithEvents txtPesoUnitario As TextBox
    Friend WithEvents txtQtdCaixa As TextBox
    Friend WithEvents lboUnidade As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents txtComprimento As TextBox
    Friend WithEvents txtLargura As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents txtTaxaDeConversao As TextBox
    Friend WithEvents lboTaxaDeConversao As Label
    Friend WithEvents BtnlboMedidaCompra As Button
    Friend WithEvents cboMedidaEstoque As ComboBox
    Friend WithEvents cboMedidaCompra As ComboBox
    Friend WithEvents BtnMedidaEstoque As Button
End Class
