Public Class OptionsMenu
    Public screenHeight As Double = 720
    Public screenWidth As Double = 1280

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tuto1.Show()


    End Sub

    Private Sub OptionsMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        screenHeight = Me.Height
        screenWidth = Me.Width
    End Sub

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
