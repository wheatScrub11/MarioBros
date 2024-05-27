Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer_inicio.Start()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub Timer_inicio_Tick(sender As Object, e As EventArgs) Handles Timer_inicio.Tick
        If ProgressBar1.Value >= 100 Then
            personaje_inicio.Visible = True
            ProgressBar1.Visible = False
            personaje_inicio.Location = New Point(personaje_inicio.Location.X + 10 
                     , personaje_inicio.Location.Y)
            If personaje_inicio.Location.X >= 390 Then
                Me.Hide()
                OptionsMenu.Show()
                Timer_inicio.Stop()
            End If
        Else
            ProgressBar1.Value = ProgressBar1.Value + 2.5
        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles personaje_inicio.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class