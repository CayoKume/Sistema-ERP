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
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnConfiguracao = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.dgvBuscaProdutos = New System.Windows.Forms.DataGridView()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvBuscaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.ComboBox2)
        Me.pnlPrincipal.Controls.Add(Me.ComboBox1)
        Me.pnlPrincipal.Controls.Add(Me.Label2)
        Me.pnlPrincipal.Controls.Add(Me.Label1)
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
        Me.pnlPrincipal.Size = New System.Drawing.Size(629, 338)
        Me.pnlPrincipal.TabIndex = 1
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(459, 304)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprimir.TabIndex = 43
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Location = New System.Drawing.Point(378, 304)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluir.TabIndex = 42
        Me.BtnExcluir.Text = "Remover"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Location = New System.Drawing.Point(297, 304)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdicionar.TabIndex = 41
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
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
        Me.BtnVoltar.Location = New System.Drawing.Point(540, 304)
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
        Me.dgvBuscaProdutos.Size = New System.Drawing.Size(603, 245)
        Me.dgvBuscaProdutos.TabIndex = 37
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(12, 26)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(194, 21)
        Me.cboProduto.TabIndex = 10
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(318, 26)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantidade.TabIndex = 7
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(212, 26)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtReferencia.TabIndex = 7
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(315, 10)
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
        Me.lblReferencia.Location = New System.Drawing.Point(209, 10)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 1
        Me.lblReferencia.Text = "Referência"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(511, 26)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox2.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(401, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(508, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Formato da Página"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Modelo Etiqueta"
        '
        'FrmEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 338)
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
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
