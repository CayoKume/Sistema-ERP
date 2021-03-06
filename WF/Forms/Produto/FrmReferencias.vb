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
        SalvarReferencia()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        ExcluirReferencia()
    End Sub
#End Region

#End Region

#Region "MÉTODOS"
    Private Sub FrmReferencias_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtReferencia.Select()
        cboCatalago.Items.Clear()
        For Each item In My.Settings.ConfiguraCboCatalago
            cboCatalago.Items.Add(item)
        Next
        PesquisaReferencia()
    End Sub

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

    Private Sub SalvarReferencia()
        TrataVariavel()
        Dim referenciaDTO As New ReferenciaDTO
        Dim flag As Boolean = False
        referenciaDTO.CodigoReferenciaProduto = Referencia

        Dim referenciaBLL As New ReferenciaBLL
        If referenciaBLL.SelectReferencia(referenciaDTO).Count <> 0 Then
            For Each objeto In referenciaBLL.SelectReferencia(referenciaDTO)
                If (objeto.CodigoReferenciaProduto.Equals(Referencia) = True And objeto.CatalagoReferencia.Equals(Catalago) <> True) Or (objeto.CodigoReferenciaProduto.Equals(Referencia) <> True And objeto.CatalagoReferencia.Equals(Catalago) <> True) Then
                    flag = True
                ElseIf objeto.CodigoReferenciaProduto.Equals(Referencia) = True And objeto.CatalagoReferencia.Equals(Catalago) = True Then
                    flag = False
                    Exit For
                End If
            Next
            If flag = True Then
                referenciaDTO.CodigoReferenciaProduto = Referencia
                referenciaDTO.CatalagoReferencia = Catalago
                Try
                    If referenciaBLL.InsertReferencia(referenciaDTO)(1) = True Then
                        MessageBox.Show("Referencia cadastrada com sucesso!")
                    Else
                        MessageBox.Show("Problema ao cadastrar referencia!")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                dgvResultados.DataSource = Nothing
                PesquisaReferencia()
            Else
                MessageBox.Show("Referência já cadastradas para o catálago ou produto selecionados!.")
            End If
        Else
            referenciaDTO.CodigoReferenciaProduto = Referencia
            referenciaDTO.CatalagoReferencia = Catalago
            Try
                If referenciaBLL.InsertReferencia(referenciaDTO)(1) = True Then
                    MessageBox.Show("Referencia cadastrada com sucesso!")
                Else
                    MessageBox.Show("Problema ao cadastrar referencia!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            dgvResultados.DataSource = Nothing
            PesquisaReferencia()
        End If
    End Sub

    Private Sub ExcluirReferencia()
        Dim referenciaDTO As New ReferenciaDTO
        referenciaDTO.CodigoReferenciaProduto = dgvResultados.CurrentRow.Cells(1).Value
        Dim referenciaBLL As New ReferenciaBLL
        Try
            If referenciaBLL.DeleteReferencia(referenciaDTO)(1) = True Then
                MessageBox.Show("Referência excluida com sucesso!")
            Else
                MessageBox.Show("Problema ao excluir referência!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LimpaCampos()
    End Sub

    Private Sub PesquisaReferencia()
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

    Private Sub LimpaCampos()
        txtReferencia.Text = Nothing
        cboCatalago.SelectedIndex = -1
        dgvResultados.DataSource = Nothing
    End Sub

    Private Sub FrmReferencias_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

End Class