﻿Public Class FormularioBrayan
    Private Sub Label1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FormularioBrayan_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormularioBrayan_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub personaje_principal_Click(sender As Object, e As EventArgs) Handles personaje_principal.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If personaje_principal.Location.X >= 360 Then
            personaje_principal.Visible = False
            celador.Visible = True
            cuadro_texto.Visible = True
        Else
            personaje_principal.Location = New Point(personaje_principal.Location.X + 5, personaje_principal.Location.Y)

        End If
    End Sub
End Class