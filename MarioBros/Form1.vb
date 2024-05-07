Public Class Form1
    Dim y As Integer = 300
    Dim velocityY As Double = 0
    Dim gravity As Double = 9.8
    Dim jumpSpeed As Double = -500 ' Timer tick in seconds
    Dim isJumping As Boolean = False

    Private Sub timer_jump_Tick(sender As Object, e As EventArgs) Handles timer_jump.Tick
        If isJumping Then
            velocityY += gravity
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + velocityY * 0.02)
            col.Location = New Point(col.Location.X, col.Location.Y + velocityY * 0.02)
            col2.Location = New Point(col2.Location.X, col2.Location.Y + velocityY * 0.02)
            col3.Location = New Point(col3.Location.X, col3.Location.Y + velocityY * 0.02)

            If pb1.Location.Y >= 300 Then
                y = 400
                velocityY = 0
                isJumping = False
            End If
        End If


    End Sub


    Dim yAxeGroundPosition As Int64
    Dim moveVal As Int64 = 5
    Dim moveRight As Boolean = True
    Dim moveLeft As Boolean = True
    Public Function applyGravity() As Boolean
        If (pb1.Location.Y + 100) >= yAxeGroundPosition Then ''when reaches the ground
            System.Console.WriteLine("XDD")
            timer_gravity.Stop()
        Else
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + 10)
            col.Location = New Point(col.Location.X, pb1.Location.Y)
            col2.Location = New Point(col2.Location.X, pb1.Location.Y)
            col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Width)

            For Each ctrl As PictureBox In Me.Controls
                If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                    Dim wall As PictureBox = DirectCast(ctrl, PictureBox)
                    If col3.Bounds.IntersectsWith(wall.Bounds) Then
                        'yAxeGroundPosition = wall.Location.Y
                    End If

                End If
            Next
        End If

        Return False
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yAxeGroundPosition = 400
        timer_gravity.Start()
        timer_jump.Start()
    End Sub


    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Dim bHandled As Boolean = False
        System.Console.WriteLine(e.KeyData)
        Select Case e.KeyCode
            Case Keys.Right
                enableXAxesCubeMovement("right")
                e.Handled = True
            Case Keys.Left
                enableXAxesCubeMovement("left")
                e.Handled = True
            Case Keys.Up
                If Not isJumping Then
                    isJumping = True
                    velocityY = jumpSpeed
                End If
            Case Keys.Down



        End Select
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        ' Sets Handled to true to prevent other controls from
        ' receiving the key if an arrow key was pressed
        Dim bHandled As Boolean = False
        If e.KeyCode = Keys.Right Then

            cleanXAxesCubeMovement("right")
        ElseIf e.KeyCode = Keys.Left Then

            cleanXAxesCubeMovement("left")

        ElseIf e.KeyCode = Keys.Up Then

        End If

    End Sub

    Public Function enableXAxesCubeMovement(direction As String) As Boolean

        If direction = "right" Then
            timer_moveRight.Start()
        ElseIf direction = "left" Then
            timer_moveLeft.Start()
        End If
        Return False
    End Function

    Public Function cleanXAxesCubeMovement(direction As String) As Boolean
        If direction = "right" Then
            timer_moveRight.Stop()
        ElseIf direction = "left" Then
            timer_moveLeft.Stop()
        End If
        Return False
    End Function



    Private Sub timer_moveRight_Tick(sender As Object, e As EventArgs) Handles timer_moveRight.Tick
        If timer_moveRight.Enabled = True And timer_moveLeft.Enabled = True Then
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y)
        Else
            movePlayerToRight()
        End If
    End Sub



    Public Function movePlayerToPoint(x, y) As Boolean
        pb1.Location = New Point(x, y)
        Return False
    End Function

    Public Function movePlayerHitboxes(val, direction) As Boolean
        If direction = "right" Then
            System.Console.Write("se mueve al a derecha")
            col.Location = New Point(col.Location.X + val, col.Location.Y)
            col2.Location = New Point(col2.Location.X + val, col2.Location.Y)
            col3.Location = New Point(col3.Location.X + val, col3.Location.Y)
        ElseIf direction = "left" Then
            col2.Location = New Point(col2.Location.X - val, col2.Location.Y)
            col.Location = New Point(col.Location.X - val, col.Location.Y)
            col3.Location = New Point(col3.Location.X - val, col3.Location.Y)
        End If
    End Function

    Public Function movePlayerToRight() As Boolean
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If moveRight Then
                    If col.Bounds.IntersectsWith(wall.Bounds) Then
                        Dim distance = wall.Location.X - (pb1.Location.X + pb1.Width)
                        movePlayerToPoint(pb1.Location.X + distance, pb1.Location.Y)
                        movePlayerHitboxes(distance, "right")
                        moveRight = False

                    Else
                        movePlayerToPoint(pb1.Location.X + moveVal, pb1.Location.Y)
                        movePlayerHitboxes(moveVal, "right")
                        moveLeft = True

                    End If
                End If
            End If
        Next
    End Function

    Public Function movePlayerToLeft() As Boolean
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)
                If moveLeft Then
                    If col2.Bounds.IntersectsWith(wall.Bounds) Then
                        Dim distance = pb1.Location.X - (wall.Location.X + wall.Width)
                        movePlayerToPoint(pb1.Location.X - distance, pb1.Location.Y)
                        movePlayerHitboxes(distance, "left")
                        moveLeft = False

                    Else
                        movePlayerToPoint(pb1.Location.X - moveVal, pb1.Location.Y)
                        movePlayerHitboxes(moveVal, "left")
                        moveRight = True

                    End If
                End If

            End If
        Next
    End Function
    Private Sub timer_moveLeft_Tick(sender As Object, e As EventArgs) Handles timer_moveLeft.Tick

        If timer_moveRight.Enabled = True And timer_moveLeft.Enabled = True Then
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y)
        Else
            movePlayerToLeft()
        End If
    End Sub

    Public Function abc() As Boolean
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If col.Bounds.IntersectsWith(wall.Bounds) AndAlso wall.Bounds.IntersectsWith(col.Bounds) Then
                    System.Console.WriteLine("PAPAPAPA")
                    moveRight = False
                Else
                    moveRight = True

                End If

            End If
        Next
        Return False
    End Function
    Public Function bca() As Boolean
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If col2.Bounds.IntersectsWith(wall.Bounds) AndAlso wall.Bounds.IntersectsWith(col2.Bounds) Then
                    System.Console.WriteLine("PAPAPAPA")
                    moveLeft = False
                Else
                    moveLeft = True

                End If
            End If
        Next
        Return False
    End Function

    Private Sub pb1_LocationChanged(sender As Object, e As EventArgs) Handles pb1.LocationChanged
        System.Console.WriteLine(moveRight)
        System.Console.WriteLine(moveLeft)
    End Sub

    Private Sub timer_gravity_Tick(sender As Object, e As EventArgs) Handles timer_gravity.Tick
        applyGravity()
    End Sub

    Private Sub col_LocationChanged(sender As Object, e As EventArgs) Handles col.LocationChanged
        abc()
    End Sub

    Private Sub col2_Click(sender As Object, e As EventArgs) Handles col2.Click

    End Sub

    Private Sub col2_LocationChanged(sender As Object, e As EventArgs) Handles col2.LocationChanged
        bca()
    End Sub

    Private Sub col3_Click(sender As Object, e As EventArgs) Handles col3.Click

    End Sub
End Class



