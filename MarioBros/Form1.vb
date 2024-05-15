Public Class Form1
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

    Dim moveVal As Int64 = 5
    Dim moveRight As Boolean = True
    Dim moveLeft As Boolean = True

    Dim initialFormSize As Size

    ' settings
    Public Property ScreenHeight As Double
    Public Property ScreenWidth As Double
    Dim spawnX As Integer = 26
    Dim spanwY As Integer = 429

    'Sprites

    Dim beeIdle As Image = My.Resources.beeidle
    Dim sansWalkingRight As Image = My.Resources.sansMovingRight
    Dim sansWalkingLeft As Image = My.Resources.sansMovingLeft
    Dim sansidle As Image = My.Resources.sansIdle


    ' custom objects
    Private enemy1 As New BasicEnemy1
    Private enemy2 As New BasicEnemy1

    Public Function setBasicEnemy1Properties(obj As BasicEnemy1, count As Integer, size As Size, location As Point) As Boolean
        Dim objName As String = "basicEnemy" & count
        Dim hitboxName As String = objName & "Hitbox"

        obj.MovingDirection = "left"
        obj.ReachedLimit = False
        obj.Size = New Size(size.Width, size.Height)
        obj.Location = New Point(location.X, location.Y - obj.Height)
        obj.Image = beeIdle
        obj.SizeMode = PictureBoxSizeMode.StretchImage
        obj.Name = objName
        obj.Tag = "spikes"
        obj.BackColor = Color.Transparent


        Dim hitbox As New PictureBox

        hitbox.Size = New Size(5, 20)
        hitbox.Location = New Point(obj.Location.X + (obj.Width / 2), obj.Location.Y + obj.Height)
        hitbox.Name = hitboxName
        hitbox.BackColor = Color.Red
        hitbox.BringToFront()

        Me.Controls.Add(obj)
        Me.Controls.Add(hitbox)

    End Function



    Private Sub timer_jump_Tick(sender As Object, e As EventArgs) Handles timer_jump.Tick
        If isJumping Then
            velocityY += gravity
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + velocityY * 0.02)
            col.Location = New Point(col.Location.X, col.Location.Y + velocityY * 0.02)
            col2.Location = New Point(col2.Location.X, col2.Location.Y + velocityY * 0.02)
            col3.Location = New Point(col3.Location.X, col3.Location.Y + velocityY * 0.02)
            col4.Location = New Point(col4.Location.X, col4.Location.Y + velocityY * 0.02)

            If isTouchingGround Then
                If groundCollision.Tag = "walls" Then
                    yAxeGroundPosition = groundCollision.Location.Y
                ElseIf groundCollision.Tag = "spikes" Then
                    pb1.Location = New Point(spawnX, spanwY)
                    col.Location = New Point(pb1.Location.X + pb1.Width, pb1.Location.Y + 1)
                    col2.Location = New Point(pb1.Location.X - 5, pb1.Location.Y + 1)
                    col3.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + pb1.Height)
                    col4.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + 5)
                End If
            End If


            If isTouchingCeiling Then
                velocityY = ceilingCollision.Location.Y
            End If


            If pb1.Location.Y >= yAxeGroundPosition - pb1.Height Then
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
            Dim incrementalFallingValue As Double = 5

            ' calcula la colision más próxima para que el valor de caída no sobrepase la estructura.
            ' la caída incrementa cada 5, pero si en algun momento la posicion del jugador + 5 es mayor a
            ' la de la altura del suelo pues lo traspasa. Este cálculo arregla eso para que en vez de ser 5,
            ' sea la distancia menor posible
            Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col3)
            If res IsNot Nothing Then
                System.Console.WriteLine(res.Item2.Tag)
            End If

            If res IsNot Nothing AndAlso res.Item2.Tag = "spikes" Then
                pb1.Location = New Point(spawnX, spanwY)
                col.Location = New Point(pb1.Location.X + pb1.Width, pb1.Location.Y + 1)
                col2.Location = New Point(pb1.Location.X - 5, pb1.Location.Y + 1)
                col3.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + pb1.Height)
                col4.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + 5)
            ElseIf res IsNot Nothing AndAlso res.Item2.Tag = "walls" Then
                incrementalFallingValue = res.Item2.Location.Y - (pb1.Location.Y + pb1.Height)

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setBasicEnemy1Properties(enemy1, 1, New Size(50, 50), New Point(800, 490))
        setBasicEnemy1Properties(enemy2, 2, New Size(30, 30), New Point(470, 330))
        ResizeAllControls(Me)
        pb1.Image = sansidle
        yAxeGroundPosition = PictureBox1.Location.Y
        timer_gravity.Start()
        timer_jump.Start()
    End Sub
    Private Sub ResizeAllControls(parentControl As Control)
        System.Console.WriteLine(OptionsMenu.screenWidth.GetType())
        System.Console.WriteLine(initialFormSize.Width.GetType())
        ' Calculate the scale factors
        Dim scaleFactorX As Double = ScreenWidth / 1280 ' Assuming 1280 is the original width
        Dim scaleFactorY As Double = ScreenHeight / 720 ' Assuming 720 is the original height


        For Each ctrl As Control In parentControl.Controls
            ' Apply the scale factors to each control's location and size
            ctrl.Location = New Point(CInt(ctrl.Location.X * scaleFactorX), CInt(ctrl.Location.Y * scaleFactorY))
            ctrl.Size = New Size(CInt(ctrl.Size.Width * scaleFactorX), CInt(ctrl.Size.Height * scaleFactorY))

            ' Recursively apply to child controls (e.g., controls within a GroupBox or Panel)
            ResizeAllControls(ctrl)
        Next
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
                    timer_gravity.Stop() ' we want to disable the falling gravity timer so it doesnt disturb the jump gravity
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

        If pb1.Image IsNot sansWalkingRight Then
            pb1.Image = sansWalkingRight
        End If




        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col)

        If res IsNot Nothing AndAlso res.Item2.Tag = "spikes" Then
            pb1.Location = New Point(spawnX, spanwY)
            col.Location = New Point(pb1.Location.X + pb1.Width, pb1.Location.Y + 1)
            col2.Location = New Point(pb1.Location.X - 5, pb1.Location.Y + 1)
            col3.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + pb1.Height)
            col4.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + 5)

        ElseIf res IsNot Nothing AndAlso res.Item2.Tag = "walls" Then
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

        If pb1.Image IsNot sansWalkingLeft Then
            pb1.Image = sansWalkingLeft
        End If

        Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col2)

        If res IsNot Nothing AndAlso res.Item2.Tag = "spikes" Then
            pb1.Location = New Point(spawnX, spanwY)
            col.Location = New Point(pb1.Location.X + pb1.Width, pb1.Location.Y + 1)
            col2.Location = New Point(pb1.Location.X - 5, pb1.Location.Y + 1)
            col3.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + pb1.Height)
            col4.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + 5)

        ElseIf res IsNot Nothing AndAlso res.Item1 = True Then
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
            pb1.Image = sansidle
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
            yAxeGroundPosition = PictureBox1.Location.Y
        End If
        Return False
    End Function

    Public Function checkCeilingCollision() As Boolean
        Label1.Text = col4.Location.Y
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


    ''enemy timers
    Private Sub basicenemy1timer_Tick(sender As Object, e As EventArgs) Handles basicenemy1timer.Tick
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is BasicEnemy1 Then
                Dim enemy As BasicEnemy1 = DirectCast(ctrl, BasicEnemy1)
                Dim enemyHitboxName As String = enemy.Name & "Hitbox"
                Dim enemyHitbox As PictureBox = getPictureBoxByName(enemyHitboxName)
                ' System.Console.WriteLine(enemyHitboxName)

                If enemy.ReachedLimit = False Then

                    If enemy.MovingDirection = "left" Then
                        enemy.Location = New Point(enemy.Location.X - 1, enemy.Location.Y)
                        enemyHitbox.Location = New Point(enemyHitbox.Location.X - 1, enemyHitbox.Location.Y)
                    Else
                        enemy.Location = New Point(enemy.Location.X + 1, enemy.Location.Y)
                        enemyHitbox.Location = New Point(enemyHitbox.Location.X + 1, enemyHitbox.Location.Y)


                    End If

                    Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(enemyHitbox)
                    Dim res2 As Tuple(Of Boolean, PictureBox) = checkCollision(enemy)

                    If res2 IsNot Nothing AndAlso res2.Item2.Name = "pb1" Then
                        pb1.Location = New Point(spawnX, spanwY)
                        col.Location = New Point(pb1.Location.X + pb1.Width, pb1.Location.Y + 1)
                        col2.Location = New Point(pb1.Location.X - 5, pb1.Location.Y + 1)
                        col3.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + pb1.Height)
                        col4.Location = New Point(pb1.Location.X + 1, pb1.Location.Y + 5)
                    End If

                    If res IsNot Nothing AndAlso res.Item2.Tag = "walls" Then
                        enemy.ReachedLimit = False
                    Else
                        enemy.ReachedLimit = True
                    End If


                ElseIf enemy.ReachedLimit = True Then

                    If enemy.MovingDirection = "left" Then
                        enemy.ReachedLimit = False
                        enemy.MovingDirection = "right"
                        enemy.Location = New Point(enemy.Location.X + 1, enemy.Location.Y)
                        enemyHitbox.Location = New Point(enemyHitbox.Location.X + 1, enemyHitbox.Location.Y)

                    ElseIf enemy.MovingDirection = "right" Then
                        enemy.ReachedLimit = False
                        enemy.MovingDirection = "left"
                        enemy.Location = New Point(enemy.Location.X - 1, enemy.Location.Y)
                        enemyHitbox.Location = New Point(enemyHitbox.Location.X - 1, enemyHitbox.Location.Y)
                    End If
                End If
            End If












        Next
    End Sub


    ' UTILITY FUNCTIONS

    Public Function checkCollision(collider As PictureBox) As Tuple(Of Boolean, PictureBox)
        Dim isCollision As Boolean = False
        Dim collisionMatch As PictureBox = New PictureBox

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is PictureBox AndAlso (ctrl.Tag = "walls" Or ctrl.Tag = "spikes" Or ctrl.Name = "pb1") Then
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
End Class



