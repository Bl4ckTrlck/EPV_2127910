'Programa que determina si un número ingresado por el usuario es primo o no y muestra el resultado en un MessageBox'
Public Class actividad2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim divisor As Integer
        divisor = 0
        For i = 1 To Val(TextBox1.Text)
            If Val(TextBox1.Text) Mod i = 0 Then
                divisor = divisor + 1
            End If
        Next i
        If divisor > 2 Then
            MsgBox("El numero no es primo")
        Else
            MsgBox("El numero es primo")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class