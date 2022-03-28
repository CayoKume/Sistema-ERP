Imports DTO
Imports BLL
Imports System.Globalization

Public Class FrmMedidas

#Region "ATRIBUTOS"
    Private IdMedida As Integer
    Private UnidadeMedidaCompra As String
    Private UnidadeMedidaEstoque As String
    Private QtdeCaixa As Decimal
    Private TaxaConversao As Decimal
    Private PesoUnitario As Decimal
    Private KiloCaixa As Decimal
    Private Altura As Decimal
    Private Largura As Decimal
    Private Comprimento As Decimal
    Private Volume As Decimal
    Private IdProduto As Integer
#End Region

#Region "BOTÕES"

#Region "FORMULÁRIO"
    Private Sub BtnlboMedidaCompra_Click(sender As Object, e As EventArgs) Handles BtnlboMedidaCompra.Click
        FrmConfiguraCbo.lboCategoria.Text = "Medida Compra"
        FrmConfiguraCbo.Show()
    End Sub

    Private Sub BtnMedidaEstoque_Click(sender As Object, e As EventArgs) Handles BtnMedidaEstoque.Click
        FrmConfiguraCbo.lboCategoria.Text = "Medida Estoque"
        FrmConfiguraCbo.Show()
    End Sub
#End Region

#Region "INFERIORES"
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        TrataVariavel()
        Dim medidaDTO As New MedidaDTO
        medidaDTO.UnidadeMedidaEstoqueProduto = UnidadeMedidaEstoque
        medidaDTO.UnidadeMedidaCompraProduto = UnidadeMedidaCompra
        medidaDTO.QtdeCaixaProduto = QtdeCaixa
        medidaDTO.TaxaConversaoProduto = TaxaConversao
        medidaDTO.PesoUnitarioProduto = PesoUnitario
        medidaDTO.KiloCaixaProduto = KiloCaixa
        medidaDTO.AlturaProduto = Altura
        medidaDTO.LarguraProduto = Largura
        medidaDTO.ComprimentoProduto = Comprimento
        medidaDTO.VolumeProduto = Volume

        If FrmProdutos.IdMedidaProduto <> Nothing Then
            medidaDTO.IdProdutoProduto = FrmProdutos.IdMedidaProduto

            Dim medidaBLL As New MedidaBLL
            Try
                If medidaBLL.UpdateMedida(medidaDTO)(1) = True Then
                    MessageBox.Show("Medida atualizada com sucesso!")
                Else
                    MessageBox.Show("Problema ao atualizar medida!.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Dim medidaBLL As New MedidaBLL
            Try
                If medidaBLL.InsertMedida(MedidaDTO)(1) = True Then
                    MessageBox.Show("Medida cadastrada com sucesso!")
                Else
                    MessageBox.Show("Problema ao cadastrar medida!.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
    End Sub
#End Region

#End Region

#Region "MÉTODOS"
    Private Sub FrmMedidas_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboMedidaCompra.Items.Clear()
        For Each item In My.Settings.ConfiguraCboMedidaCompra
            cboMedidaCompra.Items.Add(item)
        Next

        cboMedidaEstoque.Items.Clear()
        For Each item In My.Settings.ConfiguraCboMedidaEstoque
            cboMedidaEstoque.Items.Add(item)
        Next

        TrataVariavel()
        If FrmProdutos.txtCodigo.Text <> "" Then
            Dim medidaDTO As New MedidaDTO
            medidaDTO.IdProdutoProduto = FrmProdutos.IdMedidaProduto

            Dim medidaBLL As New MedidaBLL
            Try
                If medidaBLL.SelectMedida(medidaDTO) IsNot Nothing Then
                    For i = 0 To cboMedidaCompra.Items.Count - 1
                        If medidaDTO.UnidadeMedidaCompraProduto = Trim(cboMedidaCompra.Items(i).substring(0, 2)) Then
                            cboMedidaCompra.SelectedIndex = cboMedidaCompra.FindStringExact(cboMedidaCompra.Items(i))
                        End If
                    Next
                    For i = 0 To cboMedidaEstoque.Items.Count - 1
                        If medidaDTO.UnidadeMedidaEstoqueProduto = Trim(cboMedidaEstoque.Items(i).substring(0, 2)) Then
                            cboMedidaEstoque.SelectedIndex = cboMedidaEstoque.FindStringExact(cboMedidaEstoque.Items(i))
                        End If
                    Next
                    txtQtdCaixa.Text = medidaDTO.QtdeCaixaProduto
                    txtTaxaDeConversao.Text = medidaDTO.TaxaConversaoProduto
                    txtPesoUnitario.Text = medidaDTO.PesoUnitarioProduto
                    txtKiloCaixa.Text = medidaDTO.KiloCaixaProduto
                    txtAltura.Text = medidaDTO.AlturaProduto
                    txtLargura.Text = medidaDTO.LarguraProduto
                    txtComprimento.Text = medidaDTO.ComprimentoProduto
                    txtVolume.Text = medidaDTO.VolumeProduto
                Else
                    MessageBox.Show("Produto não cadastrado")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cboMedidaCompra_DropDown(sender As Object, e As EventArgs) Handles cboMedidaCompra.DropDown
        cboMedidaCompra.Items.Clear()
        For Each item In My.Settings.ConfiguraCboMedidaCompra
            cboMedidaCompra.Items.Add(item)
        Next
    End Sub

    Private Sub cboMedidaEstoque_DropDown(sender As Object, e As EventArgs) Handles cboMedidaEstoque.DropDown
        cboMedidaEstoque.Items.Clear()
        For Each item In My.Settings.ConfiguraCboMedidaEstoque
            cboMedidaEstoque.Items.Add(item)
        Next
    End Sub

    Private Sub TrataVariavel()
        Dim Vetor() As String = {cboMedidaCompra.Text, cboMedidaEstoque.Text, txtQtdCaixa.Text, txtTaxaDeConversao.Text, txtPesoUnitario.Text, txtKiloCaixa.Text, txtAltura.Text, txtLargura.Text, txtComprimento.Text, txtVolume.Text, FrmProdutos.txtCodigo.Text}
        Dim NewVetor() As String
        Dim elemento As String
        Dim lista As New List(Of String)()

        For Each elemento In Vetor
            lista.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Trim(elemento.Replace("|", "").Replace("\", "").Replace("/", "").Replace("""", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("<", "").Replace(">", "").Replace(":", "").Replace(";", "").Replace("}", "").Replace("{", "").Replace("_", "").Replace("-", "").Replace("+", "").Replace("=", ""))))
        Next
        NewVetor = lista.ToArray()

        If NewVetor(0) <> "" Then
            UnidadeMedidaCompra = NewVetor(0).Substring(0, 2)
        Else
            UnidadeMedidaCompra = Nothing
        End If
        If NewVetor(1) <> "" Then
            UnidadeMedidaEstoque = NewVetor(1).Substring(0, 2)
        Else
            UnidadeMedidaEstoque = Nothing
        End If
        If NewVetor(2) <> "" Then
            QtdeCaixa = Decimal.Parse(NewVetor(2))
        Else
            QtdeCaixa = Nothing
        End If
        If NewVetor(3) <> "" Then
            TaxaConversao = Decimal.Parse(NewVetor(3))
        Else
            TaxaConversao = Nothing
        End If
        If NewVetor(4) <> "" Then
            PesoUnitario = Decimal.Parse(NewVetor(4))
        Else
            PesoUnitario = Nothing
        End If
        If NewVetor(5) <> "" Then
            KiloCaixa = Decimal.Parse(NewVetor(5))
        Else
            KiloCaixa = Nothing
        End If
        If NewVetor(6) <> "" Then
            Altura = Decimal.Parse(NewVetor(6))
        Else
            Altura = Nothing
        End If
        If NewVetor(7) <> "" Then
            Largura = Decimal.Parse(NewVetor(7))
        Else
            Largura = Nothing
        End If
        If NewVetor(8) <> "" Then
            Comprimento = Decimal.Parse(NewVetor(8))
        Else
            Comprimento = Nothing
        End If
        If NewVetor(9) <> "" Then
            Volume = Decimal.Parse(NewVetor(9))
        Else
            Volume = Nothing
        End If
        If NewVetor(10) <> "" Then
            IdProduto = Integer.Parse(NewVetor(10))
        Else
            IdProduto = Nothing
        End If
    End Sub
#End Region

End Class