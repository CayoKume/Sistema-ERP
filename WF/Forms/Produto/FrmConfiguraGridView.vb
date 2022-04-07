Public Class FrmConfiguraGridView

#Region "ATRIBUTOS"

#End Region

#Region "BOTÕES"
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If FrmBuscaProduto.chkCodigo.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(0).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(0).Visible = True
        End If

        If FrmBuscaProduto.chkDescricao.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(1).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(1).Visible = True
        End If

        If FrmBuscaProduto.chkClasse.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(2).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(2).Visible = True
        End If

        If FrmBuscaProduto.chkStatus.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(3).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(3).Visible = True
        End If

        If FrmBuscaProduto.chkPrecoCompra.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(4).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(4).Visible = True
        End If

        If FrmBuscaProduto.chkCompraImposto.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(5).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(5).Visible = True
        End If

        If FrmBuscaProduto.chkMargemLucro.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(6).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(6).Visible = True
        End If

        If FrmBuscaProduto.chkPrecoVenda.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(7).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(7).Visible = True
        End If

        If FrmBuscaProduto.chkEstoqueDisponivel.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(8).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(8).Visible = True
        End If

        If FrmBuscaProduto.chkEstoqueMin.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(9).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(9).Visible = True
        End If

        If FrmBuscaProduto.chkEstoqueMax.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(10).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(10).Visible = True
        End If

        If FrmBuscaProduto.chkEstoqueVinculado.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(11).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(11).Visible = True
        End If

        If FrmBuscaProduto.chkEstoquePrevisto.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(12).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(12).Visible = True
        End If

        If FrmBuscaProduto.chkDescricaoDetalhada.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(13).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(13).Visible = True
        End If

        If FrmBuscaProduto.chkObservacoes.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(14).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(14).Visible = True
        End If

        If FrmBuscaProduto.chkImagem.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(15).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(15).Visible = True
        End If

        If FrmBuscaProduto.chkCategoria.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(16).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(16).Visible = True
        End If

        If FrmBuscaProduto.chkTipoProduto.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(17).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(17).Visible = True
        End If

        If FrmBuscaProduto.chkIdMedida.Checked = False Then
            FrmBuscaProduto.dgvBuscaProdutos.Columns(18).Visible = False
        Else
            FrmBuscaProduto.dgvBuscaProdutos.Columns(18).Visible = True
        End If
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
    End Sub
#End Region

#Region "MÉTODOS"
    Private Sub FrmConfiguraGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

End Class