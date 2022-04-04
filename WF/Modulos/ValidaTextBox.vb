Module ValidaTextBox

    Function SoLetras(ByVal KeyAscii As Integer) As Integer
        'TRANSFORMA LETRAS MINUSCULAS EM MAIÚSCULAS
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' INTERCEPTA UM CÓDIGO ASCII RECEBIDO E ADMITE SOMENTE LETRAS
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLetras = 0
        Else
            SoLetras = KeyAscii
        End If
        ' TECLAS ADICIONAIS PERMITIDAS
        If KeyAscii = 8 Then SoLetras = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLetras = KeyAscii ' Enter
        If KeyAscii = 32 Then SoLetras = KeyAscii ' Espace
    End Function

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
        End Select
    End Function

End Module