Imports DTO
Imports BLL
Imports System.Globalization

Public Class FrmReferencias

#Region "ATRIBUTOS"
    Private Referencia As String
    Private Catalago As String
    Private IdProduto As Integer
#End Region

#Region "BOTÕES"

#Region "FORMULÁRIO"
    Private Sub btnCatalago_Click(sender As Object, e As EventArgs) Handles btnCatalago.Click
        FrmConfiguraCbo.lboCategoria.Text = "Catálago"
        FrmConfiguraCbo.Show()
    End Sub
#End Region

#Region "INFERIORES"
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        TrataVariavel()
        Dim referenciaDTO As New ReferenciaDTO
        referenciaDTO.CodigoReferenciaProduto = Referencia
        referenciaDTO.CatalagoReferencia = Catalago
        referenciaDTO.IdProduto = FrmProdutos.IdProduto 'não sei se está certo

        Dim referenciaBLL As New ReferenciaBLL
        Try
            If referenciaBLL.InsertReferencia(referenciaDTO)(1) = True Then
                MessageBox.Show("Referencia cadastrada com sucesso!")
            Else
                MessageBox.Show("Problema ao cadastrar referencia!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#End Region

#Region "MÉTODOS"
    Private Sub TrataVariavel()
        Dim Vetor() As String = {txtReferencia.Text, cboCatalago.Text}
        Dim NewVetor() As String
        Dim elemento As String
        Dim lista As New List(Of String)()

        For Each elemento In Vetor
            lista.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Trim(elemento.Replace("|", "").Replace("\", "").Replace("/", "").Replace("""", "").Replace("'", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("¨", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("<", "").Replace(">", "").Replace(":", "").Replace(";", "").Replace("}", "").Replace("{", "").Replace("_", "").Replace("-", "").Replace("+", "").Replace("=", ""))))
        Next
        NewVetor = lista.ToArray()

        If NewVetor(0) <> "" Then
            Referencia = NewVetor(0)
        Else
            Referencia = Nothing
        End If
        If NewVetor(1) <> "" Then
            Catalago = NewVetor(1)
        Else
            Catalago = Nothing
        End If
    End Sub

    Private Sub FrmReferencias_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtReferencia.Select()
        cboCatalago.Items.Clear()
        For Each item In My.Settings.ConfiguraCboCatalago
            cboCatalago.Items.Add(item)
        Next

        Dim referenciaDTO As New ReferenciaDTO
        referenciaDTO.IdProduto = FrmProdutos.IdProduto

        Dim referenciaBLL As New ReferenciaBLL
        Try
            Dim dtReferencia As DataTable = referenciaBLL.SelectReferencias(referenciaDTO)
            dgvResultados.DataSource = dtReferencia
            dgvResultados.Columns("id_referencia_produto").HeaderText = "ID Referência"
            dgvResultados.Columns(0).Visible = False
            dgvResultados.Columns("codigo_referencia_produto").HeaderText = "Referência"
            dgvResultados.Columns(1).Width = 130
            dgvResultados.Columns("catalago_referencia").HeaderText = "Catálago"
            dgvResultados.Columns(2).Width = 130
            dgvResultados.Columns("produto_id_produto").HeaderText = "ID Produto"
            dgvResultados.Columns(3).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

End Class