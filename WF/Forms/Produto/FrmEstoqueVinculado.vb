Public Class FrmEstoqueVinculado

#Region "ATRIBUTOS"

#End Region

#Region "BOTÕES"

#End Region

#Region "MÉTODOS"
    Private Sub FrmEstoqueVinculado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

End Class