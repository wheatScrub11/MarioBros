Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Enabled = True
        Timer_inicio.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub Timer_inicio_Tick(sender As Object, e As EventArgs) Handles Timer_inicio.Tick

        ProgressBar1.Value = ProgressBar1.Value = +5

        If ProgressBar1.Value >= 100 Then
            personaje_inicio.Visible = True
            personaje_inicio.Location = New Point(personaje_inicio.Location.Y, personaje_inicio.Location.X + 5)

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles personaje_inicio.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class