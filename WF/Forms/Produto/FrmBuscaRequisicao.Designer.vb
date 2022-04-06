<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaRequisicao
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
        Me.btnAprovar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.dgvBuscaRequisicao = New System.Windows.Forms.DataGridView()
        Me.pnlRequisicao = New System.Windows.Forms.Panel()
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
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvBuscaRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRequisicao.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.pnlRequisicao)
        Me.pnlPrincipal.Controls.Add(Me.BtnLimpar)
        Me.pnlPrincipal.Controls.Add(Me.btnAprovar)
        Me.pnlPrincipal.Controls.Add(Me.btnPesquisar)
        Me.pnlPrincipal.Controls.Add(Me.btnVoltar)
        Me.pnlPrincipal.Controls.Add(Me.dgvBuscaRequisicao)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(464, 374)
        Me.pnlPrincipal.TabIndex = 1
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(296, 345)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 45
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'btnAprovar
        '
        Me.btnAprovar.Location = New System.Drawing.Point(12, 345)
        Me.btnAprovar.Name = "btnAprovar"
        Me.btnAprovar.Size = New System.Drawing.Size(55, 23)
        Me.btnAprovar.TabIndex = 2
        Me.btnAprovar.Text = "Aprovar"
        Me.btnAprovar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(215, 345)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 3
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(377, 345)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'dgvBuscaRequisicao
        '
        Me.dgvBuscaRequisicao.AllowUserToAddRows = False
        Me.dgvBuscaRequisicao.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBuscaRequisicao.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBuscaRequisicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscaRequisicao.Location = New System.Drawing.Point(12, 167)
        Me.dgvBuscaRequisicao.Name = "dgvBuscaRequisicao"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvBuscaRequisicao.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBuscaRequisicao.Size = New System.Drawing.Size(440, 172)
        Me.dgvBuscaRequisicao.TabIndex = 37
        '
        'pnlRequisicao
        '
        Me.pnlRequisicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.pnlRequisicao.Location = New System.Drawing.Point(12, 12)
        Me.pnlRequisicao.Name = "pnlRequisicao"
        Me.pnlRequisicao.Size = New System.Drawing.Size(440, 149)
        Me.pnlRequisicao.TabIndex = 49
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
        'FrmBuscaRequisicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 374)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "FrmBuscaRequisicao"
        Me.Text = "FrmBuscaRequisicao"
        Me.pnlPrincipal.ResumeLayout(False)
        CType(Me.dgvBuscaRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRequisicao.ResumeLayout(False)
        Me.pnlRequisicao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents btnAprovar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents dgvBuscaRequisicao As DataGridView
    Friend WithEvents pnlRequisicao As Panel
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
End Class
