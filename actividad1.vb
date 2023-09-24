'Programa que determina si un estudiante aprobó o reprobó un examen, sabiendo que la nota mínima aprobatoria es 80 y muestra el resultado en un Label
'
Public Class actividad1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CALIFICACION As Double
        Dim ESTATUS As String
        CALIFICACION = TextBox1.Text
        If CALIFICACION >= 80 Then
            ESTATUS = "Aprobado"
            Label3.Text = ""
        Else
            ESTATUS = "Reprobado"
            Label3.Text = "Mas suerte la proxima :c"
        End If
        Label2.Text = ESTATUS
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class