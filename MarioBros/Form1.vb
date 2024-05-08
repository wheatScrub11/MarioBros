Public Class Form1
    Dim velocityY As Double = 0
    Dim gravity As Double = 9.8
    Dim jumpSpeed As Double = -300
    Dim isJumping As Boolean = False

    Dim yAxeGroundPosition As Int64
    Dim isTouchingCeiling As Boolean = False
    Dim ceilingCollision As PictureBox
    Dim isTouchingGround As Boolean = False
    Dim groundCollision As PictureBox
    Dim isTouchingRight As Boolean = False
    Dim rightCollision As PictureBox
    Dim isTouchingLeft As Boolean = False
    Dim leftCollision As PictureBox

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
            col4.Location = New Point(col4.Location.X, col4.Location.Y + velocityY * 0.02)

            If isTouchingGround Then
                yAxeGroundPosition = groundCollision.Location.Y
            End If


            If isTouchingCeiling Then
                velocityY = ceilingCollision.Location.Y
            End If


            If pb1.Location.Y >= yAxeGroundPosition - 50 Then
                movePlayerToPoint(pb1.Location.X, yAxeGroundPosition - 50)
                movePlayerHitboxes(moveVal, "jump")
                velocityY = 0
                isJumping = False
                timer_gravity.Start()

            End If
        End If


    End Sub

    Public Function checkCollision(collider As PictureBox) As Tuple(Of Boolean, PictureBox)
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
        If (pb1.Location.Y + 50) >= yAxeGroundPosition Then ''Cuando llega al suelo pues no hace nada, lo dejo acá por si acaso
            'System.Console.WriteLine("fghfghf")
            'timer_gravity.Stop()
        Else
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + 5)
            col.Location = New Point(col.Location.X, pb1.Location.Y)
            col2.Location = New Point(col2.Location.X, pb1.Location.Y)
            col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Width)
            col4.Location = New Point(col4.Location.X, pb1.Location.Y - 5)


            If isTouchingGround Then
                yAxeGroundPosition = groundCollision.Location.Y
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
            col.Location = New Point(col.Location.X + val, col.Location.Y)
            col2.Location = New Point(col2.Location.X + val, col2.Location.Y)
            col3.Location = New Point(col3.Location.X + val, col3.Location.Y)
            col4.Location = New Point(col4.Location.X + val, col4.Location.Y)
        ElseIf direction = "left" Then
            col2.Location = New Point(col2.Location.X - val, col2.Location.Y)
            col.Location = New Point(col.Location.X - val, col.Location.Y)
            col3.Location = New Point(col3.Location.X - val, col3.Location.Y)
            col4.Location = New Point(col4.Location.X - val, col4.Location.Y)
        ElseIf direction = "jump" Then
            col.Location = New Point(col.Location.X, pb1.Location.Y + 1)
            col2.Location = New Point(col2.Location.X, pb1.Location.Y + 1)
            col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Width)
            col4.Location = New Point(col4.Location.X, pb1.Location.Y - 5)
        End If
    End Function



    Public Function movePlayerToRight() As Boolean

        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col)
        If res IsNot Nothing AndAlso res.Item1 = True Then
            isTouchingRight = True
            rightCollision = res.Item2
        Else
            isTouchingRight = False
            rightCollision = Nothing
        End If



        If moveRight Then
            If isTouchingRight Then
                Dim distance = rightCollision.Location.X - (pb1.Location.X + pb1.Width)
                movePlayerToPoint(pb1.Location.X + distance, pb1.Location.Y)
                movePlayerHitboxes(distance, "right")

            Else
                movePlayerToPoint(pb1.Location.X + moveVal, pb1.Location.Y)
                movePlayerHitboxes(moveVal, "right")

            End If
        End If
    End Function

    Public Function movePlayerToLeft() As Boolean
        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col2)
        If res IsNot Nothing AndAlso res.Item1 = True Then
            isTouchingLeft = True
            leftCollision = res.Item2
        Else
            isTouchingLeft = False
            leftCollision = Nothing
        End If


        If moveLeft Then
            If isTouchingLeft Then
                Dim distance = pb1.Location.X - (leftCollision.Location.X + leftCollision.Width)
                movePlayerToPoint(pb1.Location.X - distance, pb1.Location.Y)
                movePlayerHitboxes(distance, "left")
            Else
                movePlayerToPoint(pb1.Location.X - moveVal, pb1.Location.Y)
                movePlayerHitboxes(moveVal, "left")
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

    Public Function checkRightCollision() As Boolean
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If col.Bounds.IntersectsWith(wall.Bounds) AndAlso wall.Bounds.IntersectsWith(col.Bounds) Then

                    moveRight = False
                Else
                    moveRight = True

                End If

            End If
        Next
        Return False
    End Function
    Public Function checkLeftCollision() As Boolean
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
                Dim wall As PictureBox = DirectCast(ctrl, PictureBox)

                If col2.Bounds.IntersectsWith(wall.Bounds) AndAlso wall.Bounds.IntersectsWith(col2.Bounds) Then

                    moveLeft = False
                Else
                    moveLeft = True

                End If
            End If
        Next
        Return False
    End Function

    Public Function checkGroundCollision() As Boolean
        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col3)

        If res IsNot Nothing AndAlso res.Item1 = True Then
            isTouchingGround = True
            groundCollision = res.Item2
        Else
            isTouchingGround = False
            groundCollision = Nothing
            yAxeGroundPosition = 400
        End If
        Return False
    End Function

    Public Function checkCeilingCollision() As Boolean
        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col4)

        If res IsNot Nothing AndAlso res.Item1 = True Then
            isTouchingCeiling = True
            ceilingCollision = res.Item2
            'velocityY = ceilingCollision.Location.Y
        Else
            isTouchingCeiling = False
        End If
        Return False
    End Function


    Private Sub timer_gravity_Tick(sender As Object, e As EventArgs) Handles timer_gravity.Tick
        applyGravity()
    End Sub

    Private Sub col_LocationChanged(sender As Object, e As EventArgs) Handles col.LocationChanged
        checkRightCollision()
    End Sub

    Private Sub col2_LocationChanged(sender As Object, e As EventArgs) Handles col2.LocationChanged
        checkLeftCollision()
    End Sub

    Private Sub col3_LocationChanged(sender As Object, e As EventArgs) Handles col3.LocationChanged
        checkGroundCollision()
    End Sub

    Private Sub col4_LocationChanged(sender As Object, e As EventArgs) Handles col4.LocationChanged
        checkCeilingCollision()
    End Sub
End Class



