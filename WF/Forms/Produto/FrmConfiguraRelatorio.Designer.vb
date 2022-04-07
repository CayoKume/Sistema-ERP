<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfiguraRelatorio
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
        Me.chkExibeProdutoNegativo = New System.Windows.Forms.CheckBox()
        Me.chkExibeSomenteProdutoNegativo = New System.Windows.Forms.CheckBox()
        Me.chkNaoExibeProdutoNegativo = New System.Windows.Forms.CheckBox()
        Me.chkListProduto = New System.Windows.Forms.CheckedListBox()
        Me.chkListDatas = New System.Windows.Forms.CheckedListBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblDatas = New System.Windows.Forms.Label()
        Me.chkListEstoque = New System.Windows.Forms.CheckedListBox()
        Me.chkListMedidas = New System.Windows.Forms.CheckedListBox()
        Me.chkListValores = New System.Windows.Forms.CheckedListBox()
        Me.lblValores = New System.Windows.Forms.Label()
        Me.lblMedidas = New System.Windows.Forms.Label()
        Me.lblEstoque = New System.Windows.Forms.Label()
        Me.chkListImpostos = New System.Windows.Forms.CheckedListBox()
        Me.lblImpostos = New System.Windows.Forms.Label()
        Me.lblSaidas = New System.Windows.Forms.Label()
        Me.chkListSaidas = New System.Windows.Forms.CheckedListBox()
        Me.chkListEntradas = New System.Windows.Forms.CheckedListBox()
        Me.lblEntradas = New System.Windows.Forms.Label()
        Me.txtNomeRelatorio = New System.Windows.Forms.TextBox()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.lblNomeRelatorio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkExibeProdutoNegativo
        '
        Me.chkExibeProdutoNegativo.AutoSize = True
        Me.chkExibeProdutoNegativo.Location = New System.Drawing.Point(12, 442)
        Me.chkExibeProdutoNegativo.Name = "chkExibeProdutoNegativo"
        Me.chkExibeProdutoNegativo.Size = New System.Drawing.Size(330, 17)
        Me.chkExibeProdutoNegativo.TabIndex = 66
        Me.chkExibeProdutoNegativo.Text = "Exibir Produtos com Estoque Menor ou Igual ao Estoque Mínimo"
        Me.chkExibeProdutoNegativo.UseVisualStyleBackColor = True
        '
        'chkExibeSomenteProdutoNegativo
        '
        Me.chkExibeSomenteProdutoNegativo.AutoSize = True
        Me.chkExibeSomenteProdutoNegativo.Location = New System.Drawing.Point(12, 465)
        Me.chkExibeSomenteProdutoNegativo.Name = "chkExibeSomenteProdutoNegativo"
        Me.chkExibeSomenteProdutoNegativo.Size = New System.Drawing.Size(252, 17)
        Me.chkExibeSomenteProdutoNegativo.TabIndex = 65
        Me.chkExibeSomenteProdutoNegativo.Text = "Exibir Somente Produtos com Estoque Negativo"
        Me.chkExibeSomenteProdutoNegativo.UseVisualStyleBackColor = True
        '
        'chkNaoExibeProdutoNegativo
        '
        Me.chkNaoExibeProdutoNegativo.AutoSize = True
        Me.chkNaoExibeProdutoNegativo.Location = New System.Drawing.Point(12, 419)
        Me.chkNaoExibeProdutoNegativo.Name = "chkNaoExibeProdutoNegativo"
        Me.chkNaoExibeProdutoNegativo.Size = New System.Drawing.Size(304, 17)
        Me.chkNaoExibeProdutoNegativo.TabIndex = 64
        Me.chkNaoExibeProdutoNegativo.Text = "Não Exibir Produtos com Estoque Igual ou Menor que Zero"
        Me.chkNaoExibeProdutoNegativo.UseVisualStyleBackColor = True
        '
        'chkListProduto
        '
        Me.chkListProduto.FormattingEnabled = True
        Me.chkListProduto.Items.AddRange(New Object() {"Código Produto", "Descrição", "Referência", "Tipo Produto", "Categoria", "Fornecedor", "Classe", "Status", "Descrições Detalhadas", "Observações", "Imagem"})
        Me.chkListProduto.Location = New System.Drawing.Point(12, 28)
        Me.chkListProduto.Name = "chkListProduto"
        Me.chkListProduto.Size = New System.Drawing.Size(170, 169)
        Me.chkListProduto.TabIndex = 67
        '
        'chkListDatas
        '
        Me.chkListDatas.FormattingEnabled = True
        Me.chkListDatas.Items.AddRange(New Object() {"Data da Última Venda", "Data da Última Compra", "Data de Atualização"})
        Me.chkListDatas.Location = New System.Drawing.Point(12, 334)
        Me.chkListDatas.Name = "chkListDatas"
        Me.chkListDatas.Size = New System.Drawing.Size(170, 79)
        Me.chkListDatas.TabIndex = 68
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduto.Location = New System.Drawing.Point(9, 8)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(51, 16)
        Me.lblProduto.TabIndex = 69
        Me.lblProduto.Text = "Produto"
        '
        'lblDatas
        '
        Me.lblDatas.AutoSize = True
        Me.lblDatas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatas.Location = New System.Drawing.Point(9, 315)
        Me.lblDatas.Name = "lblDatas"
        Me.lblDatas.Size = New System.Drawing.Size(37, 16)
        Me.lblDatas.TabIndex = 70
        Me.lblDatas.Text = "Datas"
        '
        'chkListEstoque
        '
        Me.chkListEstoque.FormattingEnabled = True
        Me.chkListEstoque.Items.AddRange(New Object() {"Estoque Disponível", "Estoque Mínimo", "Estoque Máximo", "Estoque Vinculado", "Estoque Previsto", "Produtos à Comprar"})
        Me.chkListEstoque.Location = New System.Drawing.Point(12, 218)
        Me.chkListEstoque.Name = "chkListEstoque"
        Me.chkListEstoque.Size = New System.Drawing.Size(170, 94)
        Me.chkListEstoque.TabIndex = 71
        '
        'chkListMedidas
        '
        Me.chkListMedidas.FormattingEnabled = True
        Me.chkListMedidas.Items.AddRange(New Object() {"Unidade de Medida Compra", "Unidade de Medida Estoque", "Quantidade po Caixa", "Taxa de Conversão", "Peso Unitário", "Peso por Caixa", "Altura", "Largura", "Comprimento", "Volume"})
        Me.chkListMedidas.Location = New System.Drawing.Point(364, 28)
        Me.chkListMedidas.Name = "chkListMedidas"
        Me.chkListMedidas.Size = New System.Drawing.Size(170, 154)
        Me.chkListMedidas.TabIndex = 72
        '
        'chkListValores
        '
        Me.chkListValores.FormattingEnabled = True
        Me.chkListValores.Items.AddRange(New Object() {"Preço de Compra", "Preço de Compra + Impostos", "Margem de Lucro %", "Preço de Venda"})
        Me.chkListValores.Location = New System.Drawing.Point(188, 28)
        Me.chkListValores.Name = "chkListValores"
        Me.chkListValores.Size = New System.Drawing.Size(170, 64)
        Me.chkListValores.TabIndex = 73
        '
        'lblValores
        '
        Me.lblValores.AutoSize = True
        Me.lblValores.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValores.Location = New System.Drawing.Point(185, 9)
        Me.lblValores.Name = "lblValores"
        Me.lblValores.Size = New System.Drawing.Size(46, 16)
        Me.lblValores.TabIndex = 74
        Me.lblValores.Text = "Valores"
        '
        'lblMedidas
        '
        Me.lblMedidas.AutoSize = True
        Me.lblMedidas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedidas.Location = New System.Drawing.Point(361, 8)
        Me.lblMedidas.Name = "lblMedidas"
        Me.lblMedidas.Size = New System.Drawing.Size(53, 16)
        Me.lblMedidas.TabIndex = 75
        Me.lblMedidas.Text = "Medidas"
        '
        'lblEstoque
        '
        Me.lblEstoque.AutoSize = True
        Me.lblEstoque.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstoque.Location = New System.Drawing.Point(9, 199)
        Me.lblEstoque.Name = "lblEstoque"
        Me.lblEstoque.Size = New System.Drawing.Size(50, 16)
        Me.lblEstoque.TabIndex = 76
        Me.lblEstoque.Text = "Estoque"
        '
        'chkListImpostos
        '
        Me.chkListImpostos.FormattingEnabled = True
        Me.chkListImpostos.Items.AddRange(New Object() {"% ICMS", "Valor Total ICMS", "% IPI de Saída", "Valor Total IPI de Saída", "% IPI de Entrada", "Valor Total IPI de Entrada", "% ISS", "Valor Total ISS", "% II", "Valor Total II"})
        Me.chkListImpostos.Location = New System.Drawing.Point(188, 114)
        Me.chkListImpostos.Name = "chkListImpostos"
        Me.chkListImpostos.Size = New System.Drawing.Size(170, 154)
        Me.chkListImpostos.TabIndex = 77
        '
        'lblImpostos
        '
        Me.lblImpostos.AutoSize = True
        Me.lblImpostos.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpostos.Location = New System.Drawing.Point(185, 95)
        Me.lblImpostos.Name = "lblImpostos"
        Me.lblImpostos.Size = New System.Drawing.Size(56, 16)
        Me.lblImpostos.TabIndex = 78
        Me.lblImpostos.Text = "Impostos"
        '
        'lblSaidas
        '
        Me.lblSaidas.AutoSize = True
        Me.lblSaidas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaidas.Location = New System.Drawing.Point(185, 271)
        Me.lblSaidas.Name = "lblSaidas"
        Me.lblSaidas.Size = New System.Drawing.Size(41, 16)
        Me.lblSaidas.TabIndex = 79
        Me.lblSaidas.Text = "Saídas"
        '
        'chkListSaidas
        '
        Me.chkListSaidas.FormattingEnabled = True
        Me.chkListSaidas.Items.AddRange(New Object() {"Devoluções de Fornecedores", "Requisições", "Vendas"})
        Me.chkListSaidas.Location = New System.Drawing.Point(188, 290)
        Me.chkListSaidas.Name = "chkListSaidas"
        Me.chkListSaidas.Size = New System.Drawing.Size(170, 49)
        Me.chkListSaidas.TabIndex = 80
        '
        'chkListEntradas
        '
        Me.chkListEntradas.FormattingEnabled = True
        Me.chkListEntradas.Items.AddRange(New Object() {"Devoluções de Clientes", "Ordem de Serviços", "Compras"})
        Me.chkListEntradas.Location = New System.Drawing.Point(188, 361)
        Me.chkListEntradas.Name = "chkListEntradas"
        Me.chkListEntradas.Size = New System.Drawing.Size(170, 49)
        Me.chkListEntradas.TabIndex = 81
        '
        'lblEntradas
        '
        Me.lblEntradas.AutoSize = True
        Me.lblEntradas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradas.Location = New System.Drawing.Point(185, 342)
        Me.lblEntradas.Name = "lblEntradas"
        Me.lblEntradas.Size = New System.Drawing.Size(49, 16)
        Me.lblEntradas.TabIndex = 82
        Me.lblEntradas.Text = "Entadas"
        '
        'txtNomeRelatorio
        '
        Me.txtNomeRelatorio.Location = New System.Drawing.Point(405, 429)
        Me.txtNomeRelatorio.Name = "txtNomeRelatorio"
        Me.txtNomeRelatorio.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeRelatorio.TabIndex = 83
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(459, 455)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 85
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(378, 455)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 84
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'lblNomeRelatorio
        '
        Me.lblNomeRelatorio.AutoSize = True
        Me.lblNomeRelatorio.Location = New System.Drawing.Point(408, 412)
        Me.lblNomeRelatorio.Name = "lblNomeRelatorio"
        Me.lblNomeRelatorio.Size = New System.Drawing.Size(95, 13)
        Me.lblNomeRelatorio.TabIndex = 86
        Me.lblNomeRelatorio.Text = "Nome do Relatório"
        '
        'FrmConfiguraRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 490)
        Me.Controls.Add(Me.lblNomeRelatorio)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.txtNomeRelatorio)
        Me.Controls.Add(Me.lblEntradas)
        Me.Controls.Add(Me.chkListEntradas)
        Me.Controls.Add(Me.chkListSaidas)
        Me.Controls.Add(Me.lblSaidas)
        Me.Controls.Add(Me.lblImpostos)
        Me.Controls.Add(Me.chkListImpostos)
        Me.Controls.Add(Me.lblEstoque)
        Me.Controls.Add(Me.lblMedidas)
        Me.Controls.Add(Me.lblValores)
        Me.Controls.Add(Me.chkListValores)
        Me.Controls.Add(Me.chkListMedidas)
        Me.Controls.Add(Me.chkListEstoque)
        Me.Controls.Add(Me.lblDatas)
        Me.Controls.Add(Me.lblProduto)
        Me.Controls.Add(Me.chkListDatas)
        Me.Controls.Add(Me.chkListProduto)
        Me.Controls.Add(Me.chkExibeProdutoNegativo)
        Me.Controls.Add(Me.chkExibeSomenteProdutoNegativo)
        Me.Controls.Add(Me.chkNaoExibeProdutoNegativo)
        Me.KeyPreview = True
        Me.Name = "FrmConfiguraRelatorio"
        Me.Text = "FrmConfiguraRelatorio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkExibeProdutoNegativo As CheckBox
    Friend WithEvents chkExibeSomenteProdutoNegativo As CheckBox
    Friend WithEvents chkNaoExibeProdutoNegativo As CheckBox
    Friend WithEvents chkListProduto As CheckedListBox
    Friend WithEvents chkListDatas As CheckedListBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents lblDatas As Label
    Friend WithEvents chkListEstoque As CheckedListBox
    Friend WithEvents chkListMedidas As CheckedListBox
    Friend WithEvents chkListValores As CheckedListBox
    Friend WithEvents lblValores As Label
    Friend WithEvents lblMedidas As Label
    Friend WithEvents lblEstoque As Label
    Friend WithEvents chkListImpostos As CheckedListBox
    Friend WithEvents lblImpostos As Label
    Friend WithEvents lblSaidas As Label
    Friend WithEvents chkListSaidas As CheckedListBox
    Friend WithEvents chkListEntradas As CheckedListBox
    Friend WithEvents lblEntradas As Label
    Friend WithEvents txtNomeRelatorio As TextBox
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents lblNomeRelatorio As Label
End Class
