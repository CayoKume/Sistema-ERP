Public Class FrmModeloEtiquetas

#Region "ATRIBUTOS"

#End Region

#Region "BOTÕES"

#End Region

#Region "MÉTODOS"
    Private Sub FrmModeloEtiquetas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

End Class