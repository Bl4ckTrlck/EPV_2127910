'Programa que determina el día de la semana correspondiente a un número ingresado por el usuario (1 para lunes, 2 para martes, etc.) y muestra el resultado en un Label 
'
Public Class actividad3
    Private Sub actividad3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dias(0) = "Lunes"
        dias(1) = "Martes"
        dias(2) = "Miercoles"
        dias(3) = "Jueves"
        dias(4) = "Viernes"
        dias(5) = "Sabado"
        dias(6) = "Domingo"

    End Sub
    Dim dias(6) As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Val(Me.TextBox1.Text)
        If n >= 1 And n < 7 Then
            Me.Label2.Text = "el numero ingresado representa el dia " + CStr(dias(n - 1))
        Else
            MsgBox("solo numeros del 1 - 7")
            Me.TextBox1.Text = ""
            Me.TextBox1.Focus()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class