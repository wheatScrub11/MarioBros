Public Class OptionsMenu
    Public screenHeight As Double = 720
    Public screenWidth As Double = 1280

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ' Pass screen dimensions to Form1
        Dim form1 As New Form1()
        form1.Size = New Size(screenWidth, screenHeight)
        form1.ScreenHeight = screenHeight
        form1.ScreenWidth = screenWidth
        form1.scalorX = screenWidth / 1280
        form1.scalorY = screenHeight / 720
        form1.Show()
    End Sub

    Private Sub OptionsMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        screenHeight = Me.Height
        screenWidth = Me.Width
    End Sub

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
