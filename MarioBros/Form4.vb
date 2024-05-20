Public Class Form4
    Dim velocityY As Double = 0
    Dim gravity As Double = 25.8
    Dim jumpSpeed As Double = -550
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
    Dim isTouchingStickyCeiling As Boolean = False

    Dim isTouchingStickyWall As Boolean = False

    Dim moveVal As Int64 = 5
    Dim moveRight As Boolean = True
    Dim moveLeft As Boolean = True

    Dim initialFormSize As Size

    Dim starCount As Integer = 0

    ' settings
    Public Property ScreenHeight As Double
    Public Property ScreenWidth As Double

    Public Property scalorX As Double
    Public Property scalorY As Double
    Dim spawnX As Integer = 20
    Dim spanwY As Integer = 230

    'Sprites

    Dim beeIdle As Image = My.Resources.beeidle
    Dim sansWalkingRight As Image = My.Resources.sansMovingRight
    Dim sansWalkingLeft As Image = My.Resources.sansMovingLeft
    Dim sansidle As Image = My.Resources.sansIdle


    ' custom objects
    Private enemy1 As New BasicEnemy1
    Private enemy2 As New BasicEnemy1

    Private bullet1 As New BasicBullet1
    Private bullet2 As New BasicBullet1
    Private bullet3 As New BasicBullet1


    Public Function setBasicBullet1Properties(obj As BasicBullet1, count As Integer, size As Size, location As Point, bulletDirection As String) As Boolean
        Dim objName As String = "basicBullet" & count
        obj.bulletDirection = bulletDirection
        obj.xPosition = location.X
        obj.yPosition = location.Y
        obj.Size = New Size(size.Width, size.Height)
        obj.Location = New Point(location.X, location.Y - obj.Height)
        obj.Image = beeIdle
        obj.SizeMode = PictureBoxSizeMode.StretchImage
        obj.Name = objName
        obj.Tag = "spikes"
        obj.BackColor = Color.Transparent

        Me.Controls.Add(obj)


        Return False

    End Function

    Public Function setBasicEnemy1Properties(obj As BasicEnemy1, count As Integer, size As Size, location As Point, ma As Integer, mb As Integer, movingD As String) As Boolean
        Dim objName As String = "basicEnemy" & count


        obj.MovingDirection = movingD
        obj.MaxA = ma
        obj.MaxB = mb
        obj.ReachedLimit = False
        obj.Size = New Size(size.Width, size.Height)
        obj.Location = New Point(location.X, location.Y - obj.Height)
        obj.Image = beeIdle
        obj.SizeMode = PictureBoxSizeMode.StretchImage
        obj.Name = objName
        obj.Tag = "spikes"
        obj.BackColor = Color.Transparent




        Me.Controls.Add(obj)
        Return False
    End Function




    Private Sub timer_jump_Tick(sender As Object, e As EventArgs) Handles timer_jump.Tick
        If isJumping Then
            velocityY += gravity
            If isTouchingStickyWall Then
                velocityY = 0
                isJumping = False
                timer_gravity.Start()
            End If
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + velocityY * 0.02)
            col.Location = New Point(col.Location.X, col.Location.Y + velocityY * 0.02)
            col2.Location = New Point(col2.Location.X, col2.Location.Y + velocityY * 0.02)
            col3.Location = New Point(col3.Location.X, col3.Location.Y + velocityY * 0.02)
            col4.Location = New Point(col4.Location.X, col4.Location.Y + velocityY * 0.02)

            If isTouchingGround Then
                If groundCollision.Tag = "walls" Then
                    yAxeGroundPosition = groundCollision.Location.Y
                ElseIf groundCollision.Tag = "spikes" Then
                    movePlayerToSpawnPoint()
                End If
            End If


            If isTouchingCeiling Then
                If ceilingCollision.Tag = "walls2" Then
                    isTouchingStickyCeiling = True
                    velocityY = 0
                    yAxeGroundPosition = ceilingCollision.Location.Y + ceilingCollision.Height
                    ' micro position ajustment to the ceiling
                    movePlayerToPoint(pb1.Location.X, yAxeGroundPosition)
                    movePlayerHitboxes(moveVal, "jump")
                    isJumping = False

                ElseIf ceilingCollision.Tag = "walls" Then
                    velocityY = ceilingCollision.Location.Y
                End If

            End If




            If pb1.Location.Y >= yAxeGroundPosition - pb1.Height AndAlso isTouchingStickyCeiling = False AndAlso isTouchingStickyWall = False Then
                movePlayerToPoint(pb1.Location.X, yAxeGroundPosition - pb1.Height)
                movePlayerHitboxes(moveVal, "jump")
                velocityY = 0
                isJumping = False
                timer_gravity.Start()

            End If
        End If


    End Sub


    Public Function applyGravity() As Boolean
        If (pb1.Location.Y + pb1.Height) >= yAxeGroundPosition Then ''Cuando llega al suelo pues no hace nada, lo dejo acá por si acaso
            'System.Console.WriteLine("fghfghf")
            'timer_gravity.Stop()
        Else
            Dim incrementalFallingValue As Double = 6

            ' calcula la colision más próxima para que el valor de caída no sobrepase la estructura.
            ' la caída incrementa cada 5, pero si en algun momento la posicion del jugador + 5 es mayor a
            ' la de la altura del suelo pues lo traspasa. Este cálculo arregla eso para que en vez de ser 5,
            ' sea la distancia menor posible
            Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col3)

            If res IsNot Nothing AndAlso res.Item2.Tag = "spikes" Then
                movePlayerToSpawnPoint()
            ElseIf res IsNot Nothing AndAlso res.Item2.Tag = "walls" Then
                incrementalFallingValue = res.Item2.Location.Y - (pb1.Location.Y + pb1.Height)

            End If

            If isTouchingStickyWall Then
                incrementalFallingValue = 0.9
            End If


            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + incrementalFallingValue)
            col.Location = New Point(col.Location.X, pb1.Location.Y)
            col2.Location = New Point(col2.Location.X, pb1.Location.Y)
            col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Height)
            col4.Location = New Point(col4.Location.X, pb1.Location.Y - 5)


            If isTouchingGround Then
                yAxeGroundPosition = groundCollision.Location.Y
            End If
        End If

        Return False
    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createCharacterAndItsHitboxes(New Size(30, 40), New Point(spawnX, spanwY))


        'ResizeAllControls(Me)
        pb1.Image = sansidle
        yAxeGroundPosition = PictureBox1.Location.Y
        timer_gravity.Start()
        timer_jump.Start()
    End Sub


    Private Sub Form4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Dim bHandled As Boolean = False

        Select Case e.KeyCode
            Case Keys.Right
                enableXAxesCubeMovement("right")
                e.Handled = True
            Case Keys.Left
                enableXAxesCubeMovement("left")
                e.Handled = True
            Case Keys.Up
                If Not isJumping AndAlso isTouchingStickyCeiling = False Then
                    timer_gravity.Stop() ' we want to disable the falling gravity timer so it doesnt disturb the jump gravity
                    isJumping = True
                    velocityY = jumpSpeed
                End If
            Case Keys.Space
                If isTouchingStickyCeiling Then
                    yAxeGroundPosition = PictureBox1.Location.Y ' intentará caer a el suelo base, a menos que se encuentre con otro muro en applyGravity()
                    timer_gravity.Start()
                    isTouchingStickyCeiling = False

                End If
            Case Keys.Down



        End Select
    End Sub

    Private Sub Form4_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
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
            pb1.Image = sansidle
            timer_moveRight.Stop()
        ElseIf direction = "left" Then
            pb1.Image = sansidle
            timer_moveLeft.Stop()
        End If
        Return False
    End Function



    Private Sub timer_moveRight_Tick(sender As Object, e As EventArgs) Handles timer_moveRight.Tick
        If timer_moveRight.Enabled = True And timer_moveLeft.Enabled = True Then
            pb1.Image = sansidle
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
            col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Height)
            col4.Location = New Point(col4.Location.X, pb1.Location.Y - 5)
        End If
    End Function



    Public Function movePlayerToRight() As Boolean

        checkRightCollision()

        If pb1.Image IsNot sansWalkingRight Then
            pb1.Image = sansWalkingRight
        End If




        If isTouchingRight Then
            If rightCollision.Tag = "spikes" Then
                movePlayerToSpawnPoint()
            ElseIf rightCollision.Tag = "walls" Or rightCollision.Tag = "walls2" Then
                moveRight = True
                If rightCollision.Tag = "walls2" Then
                    isTouchingStickyWall = True
                End If
            Else
                moveRight = False
            End If
        Else
            moveRight = False
            isTouchingStickyWall = False
            isTouchingRight = False
            rightCollision = Nothing
        End If





        If isTouchingRight AndAlso (rightCollision.Tag = "walls" Or rightCollision.Tag = "walls2") AndAlso moveRight Then
            Dim distance = rightCollision.Location.X - (pb1.Location.X + pb1.Width)
            movePlayerToPoint(pb1.Location.X + distance, pb1.Location.Y)
            movePlayerHitboxes(distance, "right")

        Else
            movePlayerToPoint(pb1.Location.X + moveVal, pb1.Location.Y)
            movePlayerHitboxes(moveVal, "right")

        End If
    End Function

    Public Function movePlayerToLeft() As Boolean
        checkLeftCollision()

        If pb1.Image IsNot sansWalkingLeft Then
            pb1.Image = sansWalkingLeft
        End If

        'Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col2)
        If isTouchingLeft Then
            If leftCollision.Tag = "spikes" Then
                movePlayerToSpawnPoint()
            ElseIf leftCollision.Tag = "walls" Or leftCollision.Tag = "walls2" Then
                moveLeft = True
                If leftCollision.Tag = "walls2" Then
                    isTouchingStickyWall = True
                End If
            End If
        Else
            moveLeft = False
            isTouchingStickyWall = False
            isTouchingLeft = False
            leftCollision = Nothing
        End If




        '' move left is just a way to say "lets do the proximity move"
        If isTouchingLeft AndAlso (leftCollision.Tag = "walls" Or leftCollision.Tag = "walls2") AndAlso moveLeft Then
            Dim distance = pb1.Location.X - (leftCollision.Location.X + leftCollision.Width)
            movePlayerToPoint(pb1.Location.X - distance, pb1.Location.Y)
            movePlayerHitboxes(distance, "left")
        Else
            movePlayerToPoint(pb1.Location.X - moveVal, pb1.Location.Y)
            movePlayerHitboxes(moveVal, "left")
        End If

    End Function
    Private Sub timer_moveLeft_Tick(sender As Object, e As EventArgs) Handles timer_moveLeft.Tick

        If timer_moveRight.Enabled = True And timer_moveLeft.Enabled = True Then
            pb1.Image = sansidle
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y)
        Else
            movePlayerToLeft()
        End If
    End Sub

    Public Function checkRightCollision() As Boolean

        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col)
        If res IsNot Nothing Then
            isTouchingRight = True
            rightCollision = res.Item2
        Else
            isTouchingRight = False
            rightCollision = Nothing
        End If

        Return False
    End Function
    Public Function checkLeftCollision() As Boolean
        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col2)
        If res IsNot Nothing Then
            isTouchingLeft = True
            leftCollision = res.Item2
        Else
            isTouchingLeft = False
            leftCollision = Nothing
        End If
        Return False
    End Function

    Public Function checkGroundCollision() As Boolean
        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col3)

        If res IsNot Nothing AndAlso res.Item1 = True AndAlso (res.Item2.Tag = "walls" Or res.Item2.Tag = "spikes") Then
            isTouchingGround = True
            groundCollision = res.Item2
        Else
            isTouchingGround = False
            groundCollision = Nothing
            yAxeGroundPosition = PictureBox1.Location.Y
        End If
        Return False
    End Function

    Public Function checkCeilingCollision() As Boolean
        'Label1.Text = col4.Location.Y
        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col4)

        If res IsNot Nothing AndAlso res.Item1 = True Then
            isTouchingCeiling = True
            ceilingCollision = res.Item2

            'velocityY = ceilingCollision.Location.Y
        Else
            '' if i move to the left or right when im sticked to a ceiling and then i stopped touching the ceiling, i will drop
            If timer_gravity.Enabled = False AndAlso isTouchingStickyCeiling = True Then
                timer_gravity.Start()
                isTouchingStickyCeiling = False
            End If
            isTouchingCeiling = False
            ceilingCollision = Nothing
        End If
        Return False
    End Function


    Private Sub timer_gravity_Tick(sender As Object, e As EventArgs) Handles timer_gravity.Tick
        applyGravity()
    End Sub

    'Private Sub col_LocationChanged(sender As Object, e As EventArgs) Handles col.LocationChanged
    '    checkRightCollision()
    'End Sub

    'Private Sub col2_LocationChanged(sender As Object, e As EventArgs) Handles col2.LocationChanged
    '    checkLeftCollision()
    'End Sub

    Private Sub col3_LocationChanged(sender As Object, e As EventArgs) Handles col3.LocationChanged
        checkGroundCollision()
    End Sub

    Private Sub col4_LocationChanged(sender As Object, e As EventArgs) Handles col4.LocationChanged
        checkCeilingCollision()
    End Sub


    Private Sub basicenemy1timer_Tick(sender As Object, e As EventArgs) Handles basicenemy1timer.Tick
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is BasicEnemy1 Then
                Dim enemy As BasicEnemy1 = DirectCast(ctrl, BasicEnemy1)

                If enemy.ReachedLimit = False Then
                    If enemy.MovingDirection = "horizontal" Then
                        enemy.Location = New Point(enemy.Location.X - 1, enemy.Location.Y)
                    Else
                        enemy.Location = New Point(enemy.Location.X, enemy.Location.Y - 1)
                    End If
                ElseIf enemy.ReachedLimit = True Then

                    If enemy.MovingDirection = "horizontal" Then
                        enemy.Location = New Point(enemy.Location.X + 1, enemy.Location.Y)
                    Else
                        enemy.Location = New Point(enemy.Location.X, enemy.Location.Y + 1)
                    End If

                End If

                Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(enemy)
                If res IsNot Nothing AndAlso res.Item2.Name = "pb1" Then
                    movePlayerToSpawnPoint()
                End If

                If enemy.MovingDirection = "horizontal" Then
                    If enemy.Location.X <= enemy.MaxA Then
                        enemy.ReachedLimit = True
                    ElseIf enemy.Location.X + enemy.Width >= enemy.MaxB Then
                        enemy.ReachedLimit = False
                    End If
                ElseIf enemy.MovingDirection = "vertical" Then
                    If enemy.Location.Y <= enemy.MaxA Then
                        enemy.ReachedLimit = True
                    ElseIf enemy.Location.Y + enemy.Height >= enemy.MaxB Then
                        enemy.ReachedLimit = False
                    End If
                End If



            End If
        Next
    End Sub


    Private Sub basicbullet1timer_Tick(sender As Object, e As EventArgs) Handles basicbullet1timer.Tick
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is BasicBullet1 Then
                Dim b As BasicBullet1 = DirectCast(ctrl, BasicBullet1)


                If b.bulletDirection = "right" Then
                    b.Location = New Point(b.Location.X + 3, b.Location.Y)
                ElseIf b.bulletDirection = "left" Then
                    b.Location = New Point(b.Location.X - 3, b.Location.Y)
                ElseIf b.bulletDirection = "up" Then
                    b.Location = New Point(b.Location.X, b.Location.Y - 3)
                ElseIf b.bulletDirection = "down" Then
                    b.Location = New Point(b.Location.X, b.Location.Y + 3)

                End If


                Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(b)

                If res IsNot Nothing AndAlso res.Item2.Tag = "walls" Then
                    b.Location = New Point(b.xPosition, b.yPosition)
                ElseIf res IsNot Nothing AndAlso res.Item2.Name = "pb1" Then
                    movePlayerToSpawnPoint()
                End If



            End If
        Next
    End Sub



    ' UTILITY FUNCTIONS

    Public Function checkCollision(collider As PictureBox) As Tuple(Of Boolean, PictureBox)
        Dim isCollision As Boolean = False
        Dim collisionMatch As PictureBox = New PictureBox

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso (ctrl.Tag = "walls" Or ctrl.Tag = "spikes" Or ctrl.tag = "walls2" Or ctrl.Name = "pb1" Or ctrl.tag = "stars" Or ctrl.name = "door") Then
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

    Public Function getPictureBoxByName(name As String) As PictureBox
        For Each ctrl As Control In Me.Controls
            ' Check if the control's name matches the given name
            If ctrl.Name = name Then
                Dim a As PictureBox = DirectCast(ctrl, PictureBox)
                Return a
            End If
        Next
        ' If no control is found, return Nothing
        Return Nothing
    End Function

    Public Function movePlayerToSpawnPoint() As Boolean
        If starCount > 0 Then
            starCount = 0
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "stars" Then
                    Dim a As PictureBox = DirectCast(ctrl, PictureBox)
                    If a.Location.X >= 4999 Then
                        a.Location = New Point(a.Location.X - 5000, a.Location.Y - 5000)
                    End If
                End If
            Next
        End If

        pb1.Location = New Point(spawnX, spanwY)

        col.Location = New Point(pb1.Location.X + pb1.Width, pb1.Location.Y + 1)
        col2.Location = New Point(pb1.Location.X - 5, pb1.Location.Y + 1)
        col3.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + pb1.Height)
        col4.Location = New Point(pb1.Location.X + 1, pb1.Location.Y - 5)

        Return False
    End Function

    Public Function createCharacterAndItsHitboxes(size As Size, loc As Point) As Boolean

        pb1.Name = "pb1"
        pb1.BackColor = Color.Transparent
        pb1.Size = New Size(size.Width, size.Height)
        pb1.Location = New Point(loc.X, loc.Y)

        col.Name = "col"
        col.BackColor = Color.Orange
        col.Size = New Size(5, pb1.Height - 2)
        col.Location = New Point(pb1.Location.X + pb1.Width, pb1.Location.Y + 1)

        col2.Name = "col2"
        col2.BackColor = Color.Orange
        col2.Size = New Size(5, pb1.Height - 2)
        col2.Location = New Point(pb1.Location.X - 5, pb1.Location.Y + 1)

        col3.Name = "col3"
        col3.BackColor = Color.Orange
        col3.Size = New Size(pb1.Width - 2, 5)
        col3.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + pb1.Height)

        col4.Name = "col4"
        col4.BackColor = Color.Orange
        col4.Size = New Size(pb1.Width - 2, 5)
        col4.Location = New Point(pb1.Location.X + 1, pb1.Location.Y - 5)

        'Me.Controls.Add(pb1)
        'Me.Controls.Add(col)
        'Me.Controls.Add(col2)
        'Me.Controls.Add(col3)
        'Me.Controls.Add(col4)


        Return False

    End Function

End Class