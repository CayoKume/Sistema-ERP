<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFornecedoresMultiplos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCadastrarFornecedor = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lboFornecedor4 = New System.Windows.Forms.Label()
        Me.lboFornecedor3 = New System.Windows.Forms.Label()
        Me.lboFornecedor2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCadastrarFornecedor)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.lboFornecedor4)
        Me.Panel1.Controls.Add(Me.lboFornecedor3)
        Me.Panel1.Controls.Add(Me.lboFornecedor2)
        Me.Panel1.Location = New System.Drawing.Point(-3, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 172)
        Me.Panel1.TabIndex = 0
        '
        'BtnCadastrarFornecedor
        '
        Me.BtnCadastrarFornecedor.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrarFornecedor.Location = New System.Drawing.Point(28, 116)
        Me.BtnCadastrarFornecedor.Name = "BtnCadastrarFornecedor"
        Me.BtnCadastrarFornecedor.Size = New System.Drawing.Size(86, 43)
        Me.BtnCadastrarFornecedor.TabIndex = 9
        Me.BtnCadastrarFornecedor.Text = "Cadastrar Fornecedor"
        Me.BtnCadastrarFornecedor.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnVoltar)
        Me.Panel2.Controls.Add(Me.BtnSalvar)
        Me.Panel2.Location = New System.Drawing.Point(126, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 24)
        Me.Panel2.TabIndex = 8
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(85, 1)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 6
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(1, 1)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 5
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(157, 75)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 5
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(157, 46)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'lboFornecedor4
        '
        Me.lboFornecedor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lboFornecedor4.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboFornecedor4.Location = New System.Drawing.Point(42, 76)
        Me.lboFornecedor4.Name = "lboFornecedor4"
        Me.lboFornecedor4.Size = New System.Drawing.Size(82, 22)
        Me.lboFornecedor4.TabIndex = 2
        Me.lboFornecedor4.Text = "Fornecedor 4"
        '
        'lboFornecedor3
        '
        Me.lboFornecedor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lboFornecedor3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboFornecedor3.Location = New System.Drawing.Point(42, 47)
        Me.lboFornecedor3.Name = "lboFornecedor3"
        Me.lboFornecedor3.Size = New System.Drawing.Size(82, 22)
        Me.lboFornecedor3.TabIndex = 1
        Me.lboFornecedor3.Text = "Fornecedor 3"
        '
        'lboFornecedor2
        '
        Me.lboFornecedor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lboFornecedor2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboFornecedor2.Location = New System.Drawing.Point(42, 15)
        Me.lboFornecedor2.Name = "lboFornecedor2"
        Me.lboFornecedor2.Size = New System.Drawing.Size(82, 22)
        Me.lboFornecedor2.TabIndex = 0
        Me.lboFornecedor2.Text = "Fornecedor 2"
        '
        'FrmFornecedoresMultiplos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 168)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FrmFornecedoresMultiplos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedores Multiplos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lboFornecedor4 As Label
    Friend WithEvents lboFornecedor3 As Label
    Friend WithEvents lboFornecedor2 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnCadastrarFornecedor As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnVoltar As Button
    Friend WithEvents BtnSalvar As Button
End Class
