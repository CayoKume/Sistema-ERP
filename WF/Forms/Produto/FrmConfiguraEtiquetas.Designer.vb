<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModeloEtiquetas
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
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbcConfigurarPagina = New System.Windows.Forms.TabPage()
        Me.txtQtdeEtiquetaPágina = New System.Windows.Forms.TextBox()
        Me.txtQtdeEtiquetaColuna = New System.Windows.Forms.TextBox()
        Me.txtQtdeEtiquetaLinha = New System.Windows.Forms.TextBox()
        Me.txtLarguraEtiqueta = New System.Windows.Forms.TextBox()
        Me.txtAlturaEtiqueta = New System.Windows.Forms.TextBox()
        Me.lblNomeFormato = New System.Windows.Forms.Label()
        Me.txtNomeFormato = New System.Windows.Forms.TextBox()
        Me.lblQtdeEtiquetaPágina = New System.Windows.Forms.Label()
        Me.lblQtdeEtiquetaColuna = New System.Windows.Forms.Label()
        Me.lblQtdeEtiquetaLinha = New System.Windows.Forms.Label()
        Me.lblLarguraEtiqueta = New System.Windows.Forms.Label()
        Me.lblAlturaEtiqueta = New System.Windows.Forms.Label()
        Me.tbcConfiguarCampos = New System.Windows.Forms.TabPage()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.lblAlturaPagina = New System.Windows.Forms.Label()
        Me.lblLarguraPagina = New System.Windows.Forms.Label()
        Me.txtAlturaPagina = New System.Windows.Forms.TextBox()
        Me.txtLarguraPagina = New System.Windows.Forms.TextBox()
        Me.txtEspacamentoDireita = New System.Windows.Forms.TextBox()
        Me.txtEspacamentoEsquerda = New System.Windows.Forms.TextBox()
        Me.txtEspacamentoLinhas = New System.Windows.Forms.TextBox()
        Me.txtEspacamentoColunas = New System.Windows.Forms.TextBox()
        Me.txtQtdeLinhas = New System.Windows.Forms.TextBox()
        Me.txtQtdeColunas = New System.Windows.Forms.TextBox()
        Me.lblEspacamentoDireita = New System.Windows.Forms.Label()
        Me.lblEspacamentoEsquerda = New System.Windows.Forms.Label()
        Me.lblEspacamentoLinhas = New System.Windows.Forms.Label()
        Me.lblEspacamentoColunas = New System.Windows.Forms.Label()
        Me.lblQtdeLinhas = New System.Windows.Forms.Label()
        Me.lblQtdeColunas = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNomeModelo = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbcConfigurarPagina.SuspendLayout()
        Me.tbcConfiguarCampos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tbcConfigurarPagina)
        Me.tbcPrincipal.Controls.Add(Me.tbcConfiguarCampos)
        Me.tbcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(611, 337)
        Me.tbcPrincipal.TabIndex = 2
        '
        'tbcConfigurarPagina
        '
        Me.tbcConfigurarPagina.Controls.Add(Me.txtEspacamentoDireita)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtEspacamentoEsquerda)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtEspacamentoLinhas)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtEspacamentoColunas)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtQtdeLinhas)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtQtdeColunas)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblEspacamentoDireita)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblEspacamentoEsquerda)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblEspacamentoLinhas)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblEspacamentoColunas)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblQtdeLinhas)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblQtdeColunas)
        Me.tbcConfigurarPagina.Controls.Add(Me.BtnSalvar)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtQtdeEtiquetaPágina)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtQtdeEtiquetaColuna)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtQtdeEtiquetaLinha)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtLarguraPagina)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtLarguraEtiqueta)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtAlturaPagina)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtAlturaEtiqueta)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblNomeFormato)
        Me.tbcConfigurarPagina.Controls.Add(Me.txtNomeFormato)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblQtdeEtiquetaPágina)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblQtdeEtiquetaColuna)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblLarguraPagina)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblQtdeEtiquetaLinha)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblLarguraEtiqueta)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblAlturaPagina)
        Me.tbcConfigurarPagina.Controls.Add(Me.lblAlturaEtiqueta)
        Me.tbcConfigurarPagina.Location = New System.Drawing.Point(4, 22)
        Me.tbcConfigurarPagina.Name = "tbcConfigurarPagina"
        Me.tbcConfigurarPagina.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcConfigurarPagina.Size = New System.Drawing.Size(603, 311)
        Me.tbcConfigurarPagina.TabIndex = 1
        Me.tbcConfigurarPagina.Text = "Configuração da Página"
        Me.tbcConfigurarPagina.UseVisualStyleBackColor = True
        '
        'txtQtdeEtiquetaPágina
        '
        Me.txtQtdeEtiquetaPágina.Location = New System.Drawing.Point(212, 70)
        Me.txtQtdeEtiquetaPágina.Name = "txtQtdeEtiquetaPágina"
        Me.txtQtdeEtiquetaPágina.Size = New System.Drawing.Size(100, 20)
        Me.txtQtdeEtiquetaPágina.TabIndex = 12
        '
        'txtQtdeEtiquetaColuna
        '
        Me.txtQtdeEtiquetaColuna.Location = New System.Drawing.Point(212, 41)
        Me.txtQtdeEtiquetaColuna.Name = "txtQtdeEtiquetaColuna"
        Me.txtQtdeEtiquetaColuna.Size = New System.Drawing.Size(100, 20)
        Me.txtQtdeEtiquetaColuna.TabIndex = 12
        '
        'txtQtdeEtiquetaLinha
        '
        Me.txtQtdeEtiquetaLinha.Location = New System.Drawing.Point(212, 15)
        Me.txtQtdeEtiquetaLinha.Name = "txtQtdeEtiquetaLinha"
        Me.txtQtdeEtiquetaLinha.Size = New System.Drawing.Size(100, 20)
        Me.txtQtdeEtiquetaLinha.TabIndex = 12
        '
        'txtLarguraEtiqueta
        '
        Me.txtLarguraEtiqueta.Location = New System.Drawing.Point(212, 122)
        Me.txtLarguraEtiqueta.Name = "txtLarguraEtiqueta"
        Me.txtLarguraEtiqueta.Size = New System.Drawing.Size(100, 20)
        Me.txtLarguraEtiqueta.TabIndex = 12
        '
        'txtAlturaEtiqueta
        '
        Me.txtAlturaEtiqueta.Location = New System.Drawing.Point(212, 96)
        Me.txtAlturaEtiqueta.Name = "txtAlturaEtiqueta"
        Me.txtAlturaEtiqueta.Size = New System.Drawing.Size(100, 20)
        Me.txtAlturaEtiqueta.TabIndex = 12
        '
        'lblNomeFormato
        '
        Me.lblNomeFormato.AutoSize = True
        Me.lblNomeFormato.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeFormato.Location = New System.Drawing.Point(304, 283)
        Me.lblNomeFormato.Name = "lblNomeFormato"
        Me.lblNomeFormato.Size = New System.Drawing.Size(104, 16)
        Me.lblNomeFormato.TabIndex = 11
        Me.lblNomeFormato.Text = "Nome do Formato"
        '
        'txtNomeFormato
        '
        Me.txtNomeFormato.Location = New System.Drawing.Point(414, 281)
        Me.txtNomeFormato.Name = "txtNomeFormato"
        Me.txtNomeFormato.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeFormato.TabIndex = 9
        '
        'lblQtdeEtiquetaPágina
        '
        Me.lblQtdeEtiquetaPágina.AutoSize = True
        Me.lblQtdeEtiquetaPágina.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeEtiquetaPágina.Location = New System.Drawing.Point(8, 69)
        Me.lblQtdeEtiquetaPágina.Name = "lblQtdeEtiquetaPágina"
        Me.lblQtdeEtiquetaPágina.Size = New System.Drawing.Size(197, 16)
        Me.lblQtdeEtiquetaPágina.TabIndex = 8
        Me.lblQtdeEtiquetaPágina.Text = "Quantidade de Etiquetas por Página"
        '
        'lblQtdeEtiquetaColuna
        '
        Me.lblQtdeEtiquetaColuna.AutoSize = True
        Me.lblQtdeEtiquetaColuna.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeEtiquetaColuna.Location = New System.Drawing.Point(8, 43)
        Me.lblQtdeEtiquetaColuna.Name = "lblQtdeEtiquetaColuna"
        Me.lblQtdeEtiquetaColuna.Size = New System.Drawing.Size(198, 16)
        Me.lblQtdeEtiquetaColuna.TabIndex = 8
        Me.lblQtdeEtiquetaColuna.Text = "Quantidade de Etiquetas por Coluna"
        '
        'lblQtdeEtiquetaLinha
        '
        Me.lblQtdeEtiquetaLinha.AutoSize = True
        Me.lblQtdeEtiquetaLinha.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeEtiquetaLinha.Location = New System.Drawing.Point(8, 17)
        Me.lblQtdeEtiquetaLinha.Name = "lblQtdeEtiquetaLinha"
        Me.lblQtdeEtiquetaLinha.Size = New System.Drawing.Size(190, 16)
        Me.lblQtdeEtiquetaLinha.TabIndex = 8
        Me.lblQtdeEtiquetaLinha.Text = "Quantidade de Etiquetas por Linha"
        '
        'lblLarguraEtiqueta
        '
        Me.lblLarguraEtiqueta.AutoSize = True
        Me.lblLarguraEtiqueta.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLarguraEtiqueta.Location = New System.Drawing.Point(8, 124)
        Me.lblLarguraEtiqueta.Name = "lblLarguraEtiqueta"
        Me.lblLarguraEtiqueta.Size = New System.Drawing.Size(110, 16)
        Me.lblLarguraEtiqueta.TabIndex = 7
        Me.lblLarguraEtiqueta.Text = "Largura da Etiqueta"
        '
        'lblAlturaEtiqueta
        '
        Me.lblAlturaEtiqueta.AutoSize = True
        Me.lblAlturaEtiqueta.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlturaEtiqueta.Location = New System.Drawing.Point(8, 98)
        Me.lblAlturaEtiqueta.Name = "lblAlturaEtiqueta"
        Me.lblAlturaEtiqueta.Size = New System.Drawing.Size(102, 16)
        Me.lblAlturaEtiqueta.TabIndex = 5
        Me.lblAlturaEtiqueta.Text = "Altura da Etiqueta"
        '
        'tbcConfiguarCampos
        '
        Me.tbcConfiguarCampos.Controls.Add(Me.DataGridView1)
        Me.tbcConfiguarCampos.Controls.Add(Me.Button1)
        Me.tbcConfiguarCampos.Controls.Add(Me.Label7)
        Me.tbcConfiguarCampos.Controls.Add(Me.txtNomeModelo)
        Me.tbcConfiguarCampos.Location = New System.Drawing.Point(4, 22)
        Me.tbcConfiguarCampos.Name = "tbcConfiguarCampos"
        Me.tbcConfiguarCampos.Size = New System.Drawing.Size(603, 311)
        Me.tbcConfiguarCampos.TabIndex = 2
        Me.tbcConfiguarCampos.Text = "Configuação dos Campos"
        Me.tbcConfiguarCampos.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(520, 279)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 13
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'lblAlturaPagina
        '
        Me.lblAlturaPagina.AutoSize = True
        Me.lblAlturaPagina.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlturaPagina.Location = New System.Drawing.Point(8, 150)
        Me.lblAlturaPagina.Name = "lblAlturaPagina"
        Me.lblAlturaPagina.Size = New System.Drawing.Size(95, 16)
        Me.lblAlturaPagina.TabIndex = 5
        Me.lblAlturaPagina.Text = "Altura da Página"
        '
        'lblLarguraPagina
        '
        Me.lblLarguraPagina.AutoSize = True
        Me.lblLarguraPagina.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLarguraPagina.Location = New System.Drawing.Point(8, 176)
        Me.lblLarguraPagina.Name = "lblLarguraPagina"
        Me.lblLarguraPagina.Size = New System.Drawing.Size(103, 16)
        Me.lblLarguraPagina.TabIndex = 7
        Me.lblLarguraPagina.Text = "Largura da Página"
        '
        'txtAlturaPagina
        '
        Me.txtAlturaPagina.Location = New System.Drawing.Point(212, 148)
        Me.txtAlturaPagina.Name = "txtAlturaPagina"
        Me.txtAlturaPagina.Size = New System.Drawing.Size(100, 20)
        Me.txtAlturaPagina.TabIndex = 12
        '
        'txtLarguraPagina
        '
        Me.txtLarguraPagina.Location = New System.Drawing.Point(212, 174)
        Me.txtLarguraPagina.Name = "txtLarguraPagina"
        Me.txtLarguraPagina.Size = New System.Drawing.Size(100, 20)
        Me.txtLarguraPagina.TabIndex = 12
        '
        'txtEspacamentoDireita
        '
        Me.txtEspacamentoDireita.Location = New System.Drawing.Point(491, 145)
        Me.txtEspacamentoDireita.Name = "txtEspacamentoDireita"
        Me.txtEspacamentoDireita.Size = New System.Drawing.Size(100, 20)
        Me.txtEspacamentoDireita.TabIndex = 20
        '
        'txtEspacamentoEsquerda
        '
        Me.txtEspacamentoEsquerda.Location = New System.Drawing.Point(491, 119)
        Me.txtEspacamentoEsquerda.Name = "txtEspacamentoEsquerda"
        Me.txtEspacamentoEsquerda.Size = New System.Drawing.Size(100, 20)
        Me.txtEspacamentoEsquerda.TabIndex = 21
        '
        'txtEspacamentoLinhas
        '
        Me.txtEspacamentoLinhas.Location = New System.Drawing.Point(491, 93)
        Me.txtEspacamentoLinhas.Name = "txtEspacamentoLinhas"
        Me.txtEspacamentoLinhas.Size = New System.Drawing.Size(100, 20)
        Me.txtEspacamentoLinhas.TabIndex = 22
        '
        'txtEspacamentoColunas
        '
        Me.txtEspacamentoColunas.Location = New System.Drawing.Point(491, 67)
        Me.txtEspacamentoColunas.Name = "txtEspacamentoColunas"
        Me.txtEspacamentoColunas.Size = New System.Drawing.Size(100, 20)
        Me.txtEspacamentoColunas.TabIndex = 23
        '
        'txtQtdeLinhas
        '
        Me.txtQtdeLinhas.Location = New System.Drawing.Point(491, 41)
        Me.txtQtdeLinhas.Name = "txtQtdeLinhas"
        Me.txtQtdeLinhas.Size = New System.Drawing.Size(100, 20)
        Me.txtQtdeLinhas.TabIndex = 24
        '
        'txtQtdeColunas
        '
        Me.txtQtdeColunas.Location = New System.Drawing.Point(491, 15)
        Me.txtQtdeColunas.Name = "txtQtdeColunas"
        Me.txtQtdeColunas.Size = New System.Drawing.Size(100, 20)
        Me.txtQtdeColunas.TabIndex = 25
        '
        'lblEspacamentoDireita
        '
        Me.lblEspacamentoDireita.AutoSize = True
        Me.lblEspacamentoDireita.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspacamentoDireita.Location = New System.Drawing.Point(334, 148)
        Me.lblEspacamentoDireita.Name = "lblEspacamentoDireita"
        Me.lblEspacamentoDireita.Size = New System.Drawing.Size(124, 16)
        Me.lblEspacamentoDireita.TabIndex = 19
        Me.lblEspacamentoDireita.Text = "Espaçamento a Direita"
        '
        'lblEspacamentoEsquerda
        '
        Me.lblEspacamentoEsquerda.AutoSize = True
        Me.lblEspacamentoEsquerda.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspacamentoEsquerda.Location = New System.Drawing.Point(334, 122)
        Me.lblEspacamentoEsquerda.Name = "lblEspacamentoEsquerda"
        Me.lblEspacamentoEsquerda.Size = New System.Drawing.Size(138, 16)
        Me.lblEspacamentoEsquerda.TabIndex = 18
        Me.lblEspacamentoEsquerda.Text = "Espaçamento a Esquerda"
        '
        'lblEspacamentoLinhas
        '
        Me.lblEspacamentoLinhas.AutoSize = True
        Me.lblEspacamentoLinhas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspacamentoLinhas.Location = New System.Drawing.Point(334, 96)
        Me.lblEspacamentoLinhas.Name = "lblEspacamentoLinhas"
        Me.lblEspacamentoLinhas.Size = New System.Drawing.Size(136, 16)
        Me.lblEspacamentoLinhas.TabIndex = 17
        Me.lblEspacamentoLinhas.Text = "Espaçamento das Linhas"
        '
        'lblEspacamentoColunas
        '
        Me.lblEspacamentoColunas.AutoSize = True
        Me.lblEspacamentoColunas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspacamentoColunas.Location = New System.Drawing.Point(334, 70)
        Me.lblEspacamentoColunas.Name = "lblEspacamentoColunas"
        Me.lblEspacamentoColunas.Size = New System.Drawing.Size(144, 16)
        Me.lblEspacamentoColunas.TabIndex = 16
        Me.lblEspacamentoColunas.Text = "Espaçamento das Colunas"
        '
        'lblQtdeLinhas
        '
        Me.lblQtdeLinhas.AutoSize = True
        Me.lblQtdeLinhas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeLinhas.Location = New System.Drawing.Point(334, 44)
        Me.lblQtdeLinhas.Name = "lblQtdeLinhas"
        Me.lblQtdeLinhas.Size = New System.Drawing.Size(123, 16)
        Me.lblQtdeLinhas.TabIndex = 15
        Me.lblQtdeLinhas.Text = "Quantidade de Linhas"
        '
        'lblQtdeColunas
        '
        Me.lblQtdeColunas.AutoSize = True
        Me.lblQtdeColunas.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeColunas.Location = New System.Drawing.Point(334, 18)
        Me.lblQtdeColunas.Name = "lblQtdeColunas"
        Me.lblQtdeColunas.Size = New System.Drawing.Size(131, 16)
        Me.lblQtdeColunas.TabIndex = 14
        Me.lblQtdeColunas.Text = "Quantidade de Colunas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nome do Modelo"
        '
        'txtNomeModelo
        '
        Me.txtNomeModelo.Location = New System.Drawing.Point(414, 284)
        Me.txtNomeModelo.Name = "txtNomeModelo"
        Me.txtNomeModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeModelo.TabIndex = 33
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(603, 276)
        Me.DataGridView1.TabIndex = 43
        '
        'FrmModeloEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 338)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "FrmModeloEtiquetas"
        Me.Text = "FrmModeloEtiquetas"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbcConfigurarPagina.ResumeLayout(False)
        Me.tbcConfigurarPagina.PerformLayout()
        Me.tbcConfiguarCampos.ResumeLayout(False)
        Me.tbcConfiguarCampos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tbcConfigurarPagina As TabPage
    Friend WithEvents tbcConfiguarCampos As TabPage
    Friend WithEvents lblNomeFormato As Label
    Friend WithEvents txtNomeFormato As TextBox
    Friend WithEvents lblQtdeEtiquetaPágina As Label
    Friend WithEvents lblQtdeEtiquetaColuna As Label
    Friend WithEvents lblQtdeEtiquetaLinha As Label
    Friend WithEvents lblLarguraEtiqueta As Label
    Friend WithEvents lblAlturaEtiqueta As Label
    Friend WithEvents txtQtdeEtiquetaPágina As TextBox
    Friend WithEvents txtQtdeEtiquetaColuna As TextBox
    Friend WithEvents txtQtdeEtiquetaLinha As TextBox
    Friend WithEvents txtLarguraEtiqueta As TextBox
    Friend WithEvents txtAlturaEtiqueta As TextBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents txtEspacamentoDireita As TextBox
    Friend WithEvents txtEspacamentoEsquerda As TextBox
    Friend WithEvents txtEspacamentoLinhas As TextBox
    Friend WithEvents txtEspacamentoColunas As TextBox
    Friend WithEvents txtQtdeLinhas As TextBox
    Friend WithEvents txtQtdeColunas As TextBox
    Friend WithEvents lblEspacamentoDireita As Label
    Friend WithEvents lblEspacamentoEsquerda As Label
    Friend WithEvents lblEspacamentoLinhas As Label
    Friend WithEvents lblEspacamentoColunas As Label
    Friend WithEvents lblQtdeLinhas As Label
    Friend WithEvents lblQtdeColunas As Label
    Friend WithEvents txtLarguraPagina As TextBox
    Friend WithEvents txtAlturaPagina As TextBox
    Friend WithEvents lblLarguraPagina As Label
    Friend WithEvents lblAlturaPagina As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNomeModelo As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
