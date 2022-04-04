<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtiquetas
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
        Me.BtnConfiguracao = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.dgvBuscaProdutos = New System.Windows.Forms.DataGridView()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvBuscaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.BtnImprimir)
        Me.pnlPrincipal.Controls.Add(Me.BtnExcluir)
        Me.pnlPrincipal.Controls.Add(Me.BtnAdicionar)
        Me.pnlPrincipal.Controls.Add(Me.BtnConfiguracao)
        Me.pnlPrincipal.Controls.Add(Me.BtnVoltar)
        Me.pnlPrincipal.Controls.Add(Me.dgvBuscaProdutos)
        Me.pnlPrincipal.Controls.Add(Me.cboProduto)
        Me.pnlPrincipal.Controls.Add(Me.txtQuantidade)
        Me.pnlPrincipal.Controls.Add(Me.txtReferencia)
        Me.pnlPrincipal.Controls.Add(Me.lblQuantidade)
        Me.pnlPrincipal.Controls.Add(Me.lblProduto)
        Me.pnlPrincipal.Controls.Add(Me.lblReferencia)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, -1)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(611, 338)
        Me.pnlPrincipal.TabIndex = 1
        '
        'BtnConfiguracao
        '
        Me.BtnConfiguracao.Location = New System.Drawing.Point(12, 304)
        Me.BtnConfiguracao.Name = "BtnConfiguracao"
        Me.BtnConfiguracao.Size = New System.Drawing.Size(81, 23)
        Me.BtnConfiguracao.TabIndex = 40
        Me.BtnConfiguracao.Text = "Configuração"
        Me.BtnConfiguracao.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(521, 304)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 38
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'dgvBuscaProdutos
        '
        Me.dgvBuscaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscaProdutos.Location = New System.Drawing.Point(12, 53)
        Me.dgvBuscaProdutos.Name = "dgvBuscaProdutos"
        Me.dgvBuscaProdutos.Size = New System.Drawing.Size(583, 245)
        Me.dgvBuscaProdutos.TabIndex = 37
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(12, 26)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(198, 21)
        Me.cboProduto.TabIndex = 10
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(216, 26)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtReferencia.TabIndex = 7
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(319, 10)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 2
        Me.lblQuantidade.Text = "Quantidade"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(9, 10)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(44, 13)
        Me.lblProduto.TabIndex = 4
        Me.lblProduto.Text = "Produto"
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(213, 10)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 1
        Me.lblReferencia.Text = "Referência"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(322, 26)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 7
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Location = New System.Drawing.Point(359, 304)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluir.TabIndex = 42
        Me.BtnExcluir.Text = "Remover"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Location = New System.Drawing.Point(278, 304)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdicionar.TabIndex = 41
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(440, 304)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprimir.TabIndex = 43
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'FrmEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 338)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "FrmEtiquetas"
        Me.Text = "FrmEtiquetas"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.dgvBuscaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents BtnConfiguracao As Button
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents dgvBuscaProdutos As DataGridView
    Friend WithEvents cboProduto As ComboBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents lblProduto As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents BtnImprimir As Button
End Class
