Public Class OptionsMenu
    Public screenHeight As Double = 720
    Public screenWidth As Double = 1280

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tuto1.Show()
        Me.Hide()
    End Sub

    Private Sub OptionsMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        screenHeight = Me.Height
        screenWidth = Me.Width
    End Sub

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FormularioBrayan.Show()
    End Sub
End Class
