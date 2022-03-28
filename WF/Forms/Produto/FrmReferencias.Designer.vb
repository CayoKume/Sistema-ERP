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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCatalago = New System.Windows.Forms.Button()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lboReferencia
        '
        Me.lboReferencia.AutoSize = True
        Me.lboReferencia.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboReferencia.Location = New System.Drawing.Point(12, 9)
        Me.lboReferencia.Name = "lboReferencia"
        Me.lboReferencia.Size = New System.Drawing.Size(63, 16)
        Me.lboReferencia.TabIndex = 0
        Me.lboReferencia.Text = "Referência"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(100, 9)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(179, 20)
        Me.txtReferencia.TabIndex = 1
        '
        'cboCatalago
        '
        Me.cboCatalago.DisplayMember = "Código de Barras"
        Me.cboCatalago.FormattingEnabled = True
        Me.cboCatalago.Items.AddRange(New Object() {"Código de Barras", "Código Interno", "Código Fornecedor"})
        Me.cboCatalago.Location = New System.Drawing.Point(100, 38)
        Me.cboCatalago.Name = "cboCatalago"
        Me.cboCatalago.Size = New System.Drawing.Size(179, 21)
        Me.cboCatalago.TabIndex = 2
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(15, 65)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowTemplate.ReadOnly = True
        Me.dgvResultados.Size = New System.Drawing.Size(297, 225)
        Me.dgvResultados.TabIndex = 4
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(1, 1)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 5
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(85, 1)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 6
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnVoltar)
        Me.Panel1.Controls.Add(Me.BtnSalvar)
        Me.Panel1.Location = New System.Drawing.Point(152, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 24)
        Me.Panel1.TabIndex = 7
        '
        'btnCatalago
        '
        Me.btnCatalago.Location = New System.Drawing.Point(15, 36)
        Me.btnCatalago.Name = "btnCatalago"
        Me.btnCatalago.Size = New System.Drawing.Size(75, 23)
        Me.btnCatalago.TabIndex = 8
        Me.btnCatalago.Text = "Catálagos"
        Me.btnCatalago.UseVisualStyleBackColor = True
        '
        'FrmReferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 331)
        Me.Controls.Add(Me.btnCatalago)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.cboCatalago)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lboReferencia)
        Me.MaximizeBox = False
        Me.Name = "FrmReferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Referencias"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lboReferencia As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents cboCatalago As ComboBox
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCatalago As Button
End Class
