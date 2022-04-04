<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReferencias
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
        Me.lboReferencia = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.cboCatalago = New System.Windows.Forms.ComboBox()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.btnCatalago = New System.Windows.Forms.Button()
        Me.pnlFormulario = New System.Windows.Forms.Panel()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotoes.SuspendLayout()
        Me.pnlFormulario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboReferencia
        '
        Me.lboReferencia.AutoSize = True
        Me.lboReferencia.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboReferencia.Location = New System.Drawing.Point(10, 9)
        Me.lboReferencia.Name = "lboReferencia"
        Me.lboReferencia.Size = New System.Drawing.Size(63, 16)
        Me.lboReferencia.TabIndex = 0
        Me.lboReferencia.Text = "Referência"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(98, 9)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(179, 20)
        Me.txtReferencia.TabIndex = 0
        '
        'cboCatalago
        '
        Me.cboCatalago.DisplayMember = "Código de Barras"
        Me.cboCatalago.FormattingEnabled = True
        Me.cboCatalago.Items.AddRange(New Object() {"Código de Barras", "Código Interno", "Código Fornecedor"})
        Me.cboCatalago.Location = New System.Drawing.Point(98, 38)
        Me.cboCatalago.Name = "cboCatalago"
        Me.cboCatalago.Size = New System.Drawing.Size(179, 21)
        Me.cboCatalago.TabIndex = 1
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(13, 65)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowTemplate.ReadOnly = True
        Me.dgvResultados.Size = New System.Drawing.Size(297, 225)
        Me.dgvResultados.TabIndex = 3
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(1, 1)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 0
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(85, 1)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 1
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'pnlBotoes
        '
        Me.pnlBotoes.Controls.Add(Me.BtnVoltar)
        Me.pnlBotoes.Controls.Add(Me.BtnSalvar)
        Me.pnlBotoes.Location = New System.Drawing.Point(151, 298)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(161, 24)
        Me.pnlBotoes.TabIndex = 1
        Me.pnlBotoes.TabStop = True
        '
        'btnCatalago
        '
        Me.btnCatalago.Location = New System.Drawing.Point(13, 36)
        Me.btnCatalago.Name = "btnCatalago"
        Me.btnCatalago.Size = New System.Drawing.Size(75, 23)
        Me.btnCatalago.TabIndex = 2
        Me.btnCatalago.Text = "Catálagos"
        Me.btnCatalago.UseVisualStyleBackColor = True
        '
        'pnlFormulario
        '
        Me.pnlFormulario.Controls.Add(Me.btnCatalago)
        Me.pnlFormulario.Controls.Add(Me.dgvResultados)
        Me.pnlFormulario.Controls.Add(Me.cboCatalago)
        Me.pnlFormulario.Controls.Add(Me.txtReferencia)
        Me.pnlFormulario.Controls.Add(Me.lboReferencia)
        Me.pnlFormulario.Location = New System.Drawing.Point(2, 0)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(328, 292)
        Me.pnlFormulario.TabIndex = 0
        Me.pnlFormulario.TabStop = True
        '
        'FrmReferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 331)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.pnlBotoes)
        Me.MaximizeBox = False
        Me.Name = "FrmReferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Referencias"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotoes.ResumeLayout(False)
        Me.pnlFormulario.ResumeLayout(False)
        Me.pnlFormulario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lboReferencia As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents cboCatalago As ComboBox
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents btnCatalago As Button
    Friend WithEvents pnlFormulario As Panel
End Class
