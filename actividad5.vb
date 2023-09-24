'Pedir al usuario que ingrese un número y mostrar la tabla de multiplicación de ese número del 1 al 10 usando un bucle For
'
Public Class actividad5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim indice As Integer
        Dim resultado As Integer
        Dim tabla As Integer

        ListBox1.Items.Clear()
        tabla = Val(TextBox1.Text)
        For indice = 1 To 10
            resultado = tabla * indice
            ListBox1.Items.Add(tabla & " * " & indice & " = " & resultado)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class