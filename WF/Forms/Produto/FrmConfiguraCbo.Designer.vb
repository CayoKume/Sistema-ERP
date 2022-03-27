<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguraCbo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRemover = New System.Windows.Forms.Button()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.lboCategoria = New System.Windows.Forms.Label()
        Me.cboCategorias = New System.Windows.Forms.ComboBox()
        Me.pnlPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.cboCategorias)
        Me.pnlPrincipal.Controls.Add(Me.Panel1)
        Me.pnlPrincipal.Controls.Add(Me.lboCategoria)
        Me.pnlPrincipal.Location = New System.Drawing.Point(-1, -1)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(316, 80)
        Me.pnlPrincipal.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnRemover)
        Me.Panel1.Controls.Add(Me.BtnVoltar)
        Me.Panel1.Controls.Add(Me.BtnAdicionar)
        Me.Panel1.Location = New System.Drawing.Point(63, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 24)
        Me.Panel1.TabIndex = 8
        '
        'BtnRemover
        '
        Me.BtnRemover.Location = New System.Drawing.Point(81, 1)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemover.TabIndex = 7
        Me.BtnRemover.Text = "Remover"
        Me.BtnRemover.UseVisualStyleBackColor = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Location = New System.Drawing.Point(162, 1)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 6
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Location = New System.Drawing.Point(0, 1)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdicionar.TabIndex = 5
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'lboCategoria
        '
        Me.lboCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lboCategoria.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboCategoria.Location = New System.Drawing.Point(12, 6)
        Me.lboCategoria.Name = "lboCategoria"
        Me.lboCategoria.Size = New System.Drawing.Size(103, 25)
        Me.lboCategoria.TabIndex = 0
        Me.lboCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCategorias
        '
        Me.cboCategorias.FormattingEnabled = True
        Me.cboCategorias.Location = New System.Drawing.Point(120, 8)
        Me.cboCategorias.Name = "cboCategorias"
        Me.cboCategorias.Size = New System.Drawing.Size(180, 21)
        Me.cboCategorias.TabIndex = 9
        '
        'FrmConfiguraCbo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 75)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.MaximizeBox = False
        Me.Name = "FrmConfiguraCbo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents lboCategoria As Label
    Friend WithEvents BtnRemover As Button
    Friend WithEvents cboCategorias As ComboBox
End Class
