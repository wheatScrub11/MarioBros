Public Class Form1
    Dim y As Integer = 300
    Dim velocityY As Double = 0
    Dim gravity As Double = 9.8
    Dim jumpSpeed As Double = -300
    Dim isJumping As Boolean = False

    Dim yAxeGroundPosition As Int64
    Dim moveVal As Int64 = 5
    Dim moveRight As Boolean = True
    Dim moveLeft As Boolean = True

    Private Sub timer_jump_Tick(sender As Object, e As EventArgs) Handles timer_jump.Tick
        If isJumping Then
            velocityY += gravity
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + velocityY * 0.02)
            col.Location = New Point(col.Location.X, col.Location.Y + velocityY * 0.02)
            col2.Location = New Point(col2.Location.X, col2.Location.Y + velocityY * 0.02)
            col3.Location = New Point(col3.Location.X, col3.Location.Y + velocityY * 0.02)

            Dim res As Tuple(Of Boolean, PictureBox) = checkGround(col3)
            If res IsNot Nothing AndAlso res.Item1 = True = True Then
                System.Console.WriteLine(res.Item2.Location.Y)
                yAxeGroundPosition = res.Item2.Location.Y
            End If

            If pb1.Location.Y >= yAxeGroundPosition - 50 Then
                movePlayerToPoint(pb1.Location.X, yAxeGroundPosition - 50)
                movePlayerHitboxes(moveVal, "jump")
                y = 400
                velocityY = 0
                isJumping = False
                timer_gravity.Start()

            End If
        End If


    End Sub

    Public Function checkGround(collider As PictureBox) As Tuple(Of Boolean, PictureBox)
        Dim isCollision As Boolean = False
        Dim collisionMatch As PictureBox = New PictureBox

        For Each ctrl As PictureBox In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If collider.Bounds.IntersectsWith(wall.Bounds) Then
                    isCollision = True
                    collisionMatch = wall
                    Return Tuple.Create(isCollision, wall)
                    'System.Console.WriteLine(wall.Location.Y)
                    'yAxeGroundPosition = wall.Location.Y
                End If
            End If
        Next
    End Function



    Public Function applyGravity() As Boolean
        If (pb1.Location.Y + 50) >= yAxeGroundPosition Then ''when reaches the ground
            System.Console.WriteLine("XDD")
            'timer_gravity.Stop()
        Else
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + 5)
            col.Location = New Point(col.Location.X, pb1.Location.Y)
            col2.Location = New Point(col2.Location.X, pb1.Location.Y)
            col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Width)

            Dim res As Tuple(Of Boolean, PictureBox) = checkGround(col3)
            If res IsNot Nothing AndAlso res.Item1 = True = True Then
                System.Console.WriteLine(res.Item2.Location.Y)
                yAxeGroundPosition = res.Item2.Location.Y
            End If
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
                    timer_gravity.Stop()
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
        ElseIf direction = "jump" Then
            col.Location = New Point(col.Location.X, pb1.Location.Y + 1)
            col2.Location = New Point(col2.Location.X, pb1.Location.Y + 1)
            col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Width)
        End If
    End Function



    Public Function movePlayerToRight() As Boolean
        Dim isThereCollision As Boolean
        Dim collisionMatch As PictureBox
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If col.Bounds.IntersectsWith(wall.Bounds) Then
                    isThereCollision = True
                    collisionMatch = wall
                End If


            End If
        Next

        If moveRight Then
            If isThereCollision Then
                Dim distance = collisionMatch.Location.X - (pb1.Location.X + pb1.Width)
                movePlayerToPoint(pb1.Location.X + distance, pb1.Location.Y)
                movePlayerHitboxes(distance, "right")
                'moveRight = False

            Else
                movePlayerToPoint(pb1.Location.X + moveVal, pb1.Location.Y)
                movePlayerHitboxes(moveVal, "right")
                'moveLeft = True

            End If
        End If
    End Function

    Public Function movePlayerToLeft() As Boolean
        Dim isThereCollision As Boolean
        Dim collisionMatch As PictureBox
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)
                If col2.Bounds.IntersectsWith(wall.Bounds) Then
                    isThereCollision = True
                    collisionMatch = wall
                End If

            End If
        Next

        If moveLeft Then
            If isThereCollision Then
                Dim distance = pb1.Location.X - (collisionMatch.Location.X + collisionMatch.Width)
                movePlayerToPoint(pb1.Location.X - distance, pb1.Location.Y)
                movePlayerHitboxes(distance, "left")
                'moveLeft = False

            Else
                movePlayerToPoint(pb1.Location.X - moveVal, pb1.Location.Y)
                movePlayerHitboxes(moveVal, "left")
                'moveRight = True



            End If
        End If
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

    Public Function kk3() As Boolean
        Dim isCollision As Boolean = False
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If col3.Bounds.IntersectsWith(wall.Bounds) Then
                    isCollision = True
                End If
            End If
        Next

        If isCollision = False Then
            yAxeGroundPosition = 400
        End If
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


    Private Sub col2_LocationChanged(sender As Object, e As EventArgs) Handles col2.LocationChanged
        bca()
    End Sub

    Private Sub col3_LocationChanged(sender As Object, e As EventArgs) Handles col3.LocationChanged
        kk3()
    End Sub
End Class



