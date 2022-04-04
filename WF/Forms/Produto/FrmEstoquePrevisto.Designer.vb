<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstoquePrevisto
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
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.txtTotalDisponivel = New System.Windows.Forms.TextBox()
        Me.txtTotalPrevisto = New System.Windows.Forms.TextBox()
        Me.txtTotalEstoque = New System.Windows.Forms.TextBox()
        Me.lblTotalPrevisto = New System.Windows.Forms.Label()
        Me.lblTotalDisponivel = New System.Windows.Forms.Label()
        Me.lblTotalEstoque = New System.Windows.Forms.Label()
        Me.dgvEstoquePrevisto = New System.Windows.Forms.DataGridView()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvEstoquePrevisto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.BtnVoltar)
        Me.pnlPrincipal.Controls.Add(Me.txtTotalDisponivel)
        Me.pnlPrincipal.Controls.Add(Me.txtTotalPrevisto)
        Me.pnlPrincipal.Controls.Add(Me.txtTotalEstoque)
        Me.pnlPrincipal.Controls.Add(Me.lblTotalPrevisto)
        Me.pnlPrincipal.Controls.Add(Me.lblTotalDisponivel)
        Me.pnlPrincipal.Controls.Add(Me.lblTotalEstoque)
        Me.pnlPrincipal.Controls.Add(Me.dgvEstoquePrevisto)
        Me.pnlPrincipal.Location = New System.Drawing.Point(-4, -1)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(504, 405)
        Me.pnlPrincipal.TabIndex = 0
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(420, 373)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 7
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'txtTotalDisponivel
        '
        Me.txtTotalDisponivel.Location = New System.Drawing.Point(424, 342)
        Me.txtTotalDisponivel.Name = "txtTotalDisponivel"
        Me.txtTotalDisponivel.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalDisponivel.TabIndex = 6
        '
        'txtTotalPrevisto
        '
        Me.txtTotalPrevisto.Location = New System.Drawing.Point(252, 340)
        Me.txtTotalPrevisto.Name = "txtTotalPrevisto"
        Me.txtTotalPrevisto.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalPrevisto.TabIndex = 5
        '
        'txtTotalEstoque
        '
        Me.txtTotalEstoque.Location = New System.Drawing.Point(93, 340)
        Me.txtTotalEstoque.Name = "txtTotalEstoque"
        Me.txtTotalEstoque.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalEstoque.TabIndex = 4
        '
        'lblTotalPrevisto
        '
        Me.lblTotalPrevisto.AutoSize = True
        Me.lblTotalPrevisto.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrevisto.Location = New System.Drawing.Point(167, 342)
        Me.lblTotalPrevisto.Name = "lblTotalPrevisto"
        Me.lblTotalPrevisto.Size = New System.Drawing.Size(79, 16)
        Me.lblTotalPrevisto.TabIndex = 3
        Me.lblTotalPrevisto.Text = "Total Previsto"
        '
        'lblTotalDisponivel
        '
        Me.lblTotalDisponivel.AutoSize = True
        Me.lblTotalDisponivel.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDisponivel.Location = New System.Drawing.Point(326, 342)
        Me.lblTotalDisponivel.Name = "lblTotalDisponivel"
        Me.lblTotalDisponivel.Size = New System.Drawing.Size(92, 16)
        Me.lblTotalDisponivel.TabIndex = 2
        Me.lblTotalDisponivel.Text = "Total Disponível"
        '
        'lblTotalEstoque
        '
        Me.lblTotalEstoque.AutoSize = True
        Me.lblTotalEstoque.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEstoque.Location = New System.Drawing.Point(8, 342)
        Me.lblTotalEstoque.Name = "lblTotalEstoque"
        Me.lblTotalEstoque.Size = New System.Drawing.Size(79, 16)
        Me.lblTotalEstoque.TabIndex = 1
        Me.lblTotalEstoque.Text = "Total Estoque"
        '
        'dgvEstoquePrevisto
        '
        Me.dgvEstoquePrevisto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstoquePrevisto.Location = New System.Drawing.Point(5, 3)
        Me.dgvEstoquePrevisto.Name = "dgvEstoquePrevisto"
        Me.dgvEstoquePrevisto.Size = New System.Drawing.Size(498, 325)
        Me.dgvEstoquePrevisto.TabIndex = 0
        '
        'FrmEstoquePrevisto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 403)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "FrmEstoquePrevisto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEstoquePrevisto"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.dgvEstoquePrevisto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents lblTotalPrevisto As Label
    Friend WithEvents lblTotalDisponivel As Label
    Friend WithEvents lblTotalEstoque As Label
    Friend WithEvents dgvEstoquePrevisto As DataGridView
    Friend WithEvents txtTotalDisponivel As TextBox
    Friend WithEvents txtTotalPrevisto As TextBox
    Friend WithEvents txtTotalEstoque As TextBox
    Friend WithEvents BtnVoltar As Button
End Class
