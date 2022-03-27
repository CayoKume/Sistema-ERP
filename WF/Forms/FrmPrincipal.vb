Public Class FrmPrincipal
    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        Me.Hide()
        FrmProdutos.Show()
    End Sub
End Class