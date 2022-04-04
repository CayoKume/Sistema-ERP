Imports DTO
Imports BLL
Imports System.Globalization

Public Class FrmConfiguraCbo

#Region "ATRIBUTOS"
    Private CodigoLabel As String
#End Region

#Region "BOTÕES"
    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        TrataVariavel()
        If Trim(cboCategorias.Text) <> "" Then
            If lboCategoria.Text = "Categoria" Then
                Dim categoriaDTO As New CategoriaDTO
                categoriaDTO.Codigo_Categoria_Produto = CodigoLabel

                Dim categoriaBLL As New CategoriaBLL
                Try
                    If categoriaBLL.InsertCategoria(categoriaDTO)(1) = True Then
                        MessageBox.Show("Categoria cadastrada com sucesso!.")
                    Else
                        MessageBox.Show("Problema ao cadastrar categoria!.")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Me.Close()

            ElseIf lboCategoria.Text = "Tipo do Produto" Then
                Dim tipoprodutoDTO As New TipoProdutoDTO
                tipoprodutoDTO.CodigoTipoProduto = CodigoLabel

                Dim tipoprodutoBLL As New TipoProdutoBLL
                Try
                    If tipoprodutoBLL.InsertTipoProduto(tipoprodutoDTO)(1) = True Then
                        MessageBox.Show("Tipo produto cadastrada com sucesso!.")
                    Else
                        MessageBox.Show("Problema ao cadastrar tipo produto!.")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Me.Close()

            ElseIf lboCategoria.Text = "Status" Then
                My.Settings.ConfiguraCboStatus.Add(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Status cadastrado com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "% Margem Lucro" Then
                My.Settings.ConfiguraCboMargemLucro.Add(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Margem de lucro cadastrada com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "Medida Compra" Then
                My.Settings.ConfiguraCboMedidaCompra.Add(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Medida compra cadastrada com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "Medida Estoque" Then
                My.Settings.ConfiguraCboMedidaEstoque.Add(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Medida estoque cadastrada com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "Catálago" Then
                My.Settings.ConfiguraCboCatalago.Add(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Catálago referência cadastrado com sucesso!.")
                Me.Close()
            End If
        Else
            MessageBox.Show("Digite um Parâmetro")
        End If
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        TrataVariavel()
        If Trim(cboCategorias.Text) <> "" Then
            If lboCategoria.Text = "Categoria" Then
                Dim categoriaDTO As New CategoriaDTO
                categoriaDTO.Codigo_Categoria_Produto = CodigoLabel

                Dim categoriaBLL As New CategoriaBLL
                Try
                    If categoriaBLL.DeleteCategoria(categoriaDTO)(1) = True Then
                        MessageBox.Show("Categoria removida com sucesso!.")
                    Else
                        MessageBox.Show("Problema ao remover categoria!.")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Me.Close()

            ElseIf lboCategoria.Text = "Tipo do Produto" Then
                Dim tipoprodutoDTO As New TipoProdutoDTO
                tipoprodutoDTO.CodigoTipoProduto = CodigoLabel

                Dim tipoprodutoBLL As New TipoProdutoBLL
                Try
                    If tipoprodutoBLL.DeleteTipoProduto(tipoprodutoDTO)(1) = True Then
                        MessageBox.Show("Tipo produto removido com sucesso!.")
                    Else
                        MessageBox.Show("Problema ao remover tipo produto!.")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Me.Close()

            ElseIf lboCategoria.Text = "Status" Then
                My.Settings.ConfiguraCboStatus.Remove(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Status removido com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "% Margem Lucro" Then
                My.Settings.ConfiguraCboMargemLucro.Remove(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Margem de lucro removido com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "Medida Compra" Then
                My.Settings.ConfiguraCboMedidaCompra.Remove(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Medida compra removida com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "Medida Estoque" Then
                My.Settings.ConfiguraCboMedidaEstoque.Remove(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Medida estoque removida com sucesso!.")
                Me.Close()

            ElseIf lboCategoria.Text = "Catálago" Then
                My.Settings.ConfiguraCboCatalago.Remove(CodigoLabel.ToString)
                My.Settings.Save()
                MessageBox.Show("Catálago referência removido com sucesso!.")
                Me.Close()

            End If
        Else
            MessageBox.Show("Digite um Parâmetro")
        End If
    End Sub
#End Region

#Region "MÉTODOS"
    Private Sub FrmConfiguraCbo_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboCategorias.Select()
    End Sub

    Private Sub TrataVariavel()
        CodigoLabel = Trim(cboCategorias.Text.Replace("|", "").Replace("\", "").Replace("/", "").Replace("""", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("<", "").Replace(">", "").Replace(":", "").Replace(";", "").Replace("}", "").Replace("{", "").Replace("_", "").Replace("-", "").Replace("+", "").Replace("=", ""))
    End Sub

    Private Sub cboCategorias_DropDown(sender As Object, e As EventArgs) Handles cboCategorias.DropDown
        If lboCategoria.Text = "Categoria" Then
            cboCategorias.Items.Clear()
            Dim categoriaBLL As New CategoriaBLL
            Try
                Dim dtCategoria As DataTable = categoriaBLL.SelectCategoria()

                For i = 0 To dtCategoria.Rows.Count - 1
                    cboCategorias.Items.Add(dtCategoria.Rows(i).Item(0).ToString)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf lboCategoria.Text = "Tipo do Produto" Then
            cboCategorias.Items.Clear()
            Dim tipoprodutoBLL As New TipoProdutoBLL
            Try
                Dim dtTipo As DataTable = tipoprodutoBLL.SelectTipoProduto()

                For i = 0 To dtTipo.Rows.Count - 1
                    cboCategorias.Items.Add(dtTipo.Rows(i).Item(0).ToString)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf lboCategoria.Text = "Status" Then
            cboCategorias.Items.Clear()
            For Each item In My.Settings.ConfiguraCboStatus
                cboCategorias.Items.Add(item)
            Next

        ElseIf lboCategoria.Text = "% Margem Lucro" Then
            cboCategorias.Items.Clear()
            For Each item In My.Settings.ConfiguraCboMargemLucro
                cboCategorias.Items.Add(item)
            Next

        ElseIf lboCategoria.Text = "Medida Compra" Then
            cboCategorias.Items.Clear()
            For Each item In My.Settings.ConfiguraCboMedidaCompra
                cboCategorias.Items.Add(item)
            Next

        ElseIf lboCategoria.Text = "Medida Estoque" Then
            cboCategorias.Items.Clear()
            For Each item In My.Settings.ConfiguraCboMedidaEstoque
                cboCategorias.Items.Add(item)
            Next

        ElseIf lboCategoria.Text = "Catálago" Then
            cboCategorias.Items.Clear()
            For Each item In My.Settings.ConfiguraCboCatalago
                cboCategorias.Items.Add(item)
            Next

        Else
            MessageBox.Show("Digite um Parâmetro")
        End If
    End Sub

    'VALIDA COMBOBOX PARA SOMENTE ACEITAR NÚMEROS OU LETRAS MAIUSCULAS
    Private Sub cboCategorias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategorias.KeyPress
        If lboCategoria.Text = "% Margem Lucro" Then
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SoNumeros(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        ElseIf lboCategoria.Text = "Catálago" Or lboCategoria.Text = "Status" Or lboCategoria.Text = "Tipo do Produto" Or lboCategoria.Text = "Categoria" Then
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SoLetras(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
        End If
    End Sub
#End Region

End Class