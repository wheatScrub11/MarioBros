Public Class Tuto11
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
  Dim isTouchinMovingPlatform As Boolean = False

  Dim isTouchingStickyWall As Boolean = False

  Dim moveVal As Int64 = 5
  Dim moveRight As Boolean = True
  Dim moveLeft As Boolean = True

  Dim initialFormSize As Size

  Dim starCount As Integer = 0
  Dim collectedAllStar As Boolean = False

  ' settings
  Public Property ScreenHeight As Double
  Public Property ScreenWidth As Double

  Public Property scalorX As Double
  Public Property scalorY As Double
  Dim spawnX As Integer = 133
  Dim spanwY As Integer = 501

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


  Dim deathc As Integer = 0
  Dim timec As Double = 0




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

  Public Function setBasicEnemy1Properties(obj As BasicEnemy1, count As Integer, size As Size, location As Point, ma As Integer, mb As Integer, movingD As String, tg As String, img As Image) As Boolean
    Dim objName As String = "basicEnemy" & count


    obj.MovingDirection = movingD
    obj.MaxA = ma
    obj.MaxB = mb
    obj.ReachedLimit = False
    obj.Size = New Size(size.Width, size.Height)
    obj.Location = New Point(location.X, location.Y - obj.Height)
    obj.Image = img
    obj.SizeMode = PictureBoxSizeMode.StretchImage
    obj.Name = objName
    obj.Tag = tg
    obj.BackColor = Color.Transparent




    Me.Controls.Add(obj)
    Return False
  End Function




  Private Sub timer_jump_Tick(sender As Object, e As EventArgs) Handles timer_jump.Tick
    If isJumping Then
      velocityY += gravity
      If isTouchingStickyWall Then
        System.Console.WriteLine("sfdjsfdjklsfkl")
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
        If groundCollision.Tag = "walls" Or groundCollision.Tag = "walls2" Then
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
      ElseIf res IsNot Nothing AndAlso (res.Item2.Tag = "walls" Or res.Item2.Tag = "walls2") Then
        incrementalFallingValue = res.Item2.Location.Y - (pb1.Location.Y + pb1.Height)

      End If

      If isTouchingStickyWall Then
        incrementalFallingValue = 0.7
      End If

      createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X, pb1.Location.Y + incrementalFallingValue))
      'pb1.Location = New Point(pb1.Location.X, pb1.Location.Y + incrementalFallingValue)
      'col.Location = New Point(col.Location.X, pb1.Location.Y)
      'col2.Location = New Point(col2.Location.X, pb1.Location.Y)
      'col3.Location = New Point(col3.Location.X, pb1.Location.Y + pb1.Height)
      'col4.Location = New Point(col4.Location.X, pb1.Location.Y - 5)


      If isTouchingGround Then
        yAxeGroundPosition = groundCollision.Location.Y
      End If
    End If

    Return False
  End Function

  Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    SaveData.openedForm = Me
    deathCount.Text = SaveData.deathCount
    createCharacterAndItsHitboxes(New Size(30, 40), New Point(spawnX, spanwY))
    'setBasicEnemy1Properties(enemy1, 1, New Size(50, 50), New Point(200, 300), 100, 300, "horizontal", "walls", My.Resources.Undertale)

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
      Case Keys.Escape
        If OptionsM.isOpeningOptionsMenu = False Then
          OptionsM.isOpeningOptionsMenu = True
          OptionsM.ShowDialog()
        End If



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
      createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X - distance, pb1.Location.Y))
    Else
      createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X - moveVal, pb1.Location.Y))

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

      If rightCollision.Name = "door" AndAlso collectedAllStar Then
        moveToNextLvl()
      End If
    Else
      isTouchingStickyWall = False
      isTouchingRight = False
      rightCollision = Nothing
    End If


    If isTouchingRight Then
      If rightCollision.Tag = "stars" Then
        starCount += 1
        rightCollision.Location = New Point(rightCollision.Location.X + 5000, rightCollision.Location.Y + 5000)
        If starCount >= 3 Then
          door.BackgroundImage = My.Resources.doorOpened
          'door.Location = New Point(1082, 467)
          collectedAllStar = True
        End If
      ElseIf rightCollision.Tag = "walls" Then
        moveRight = True
      ElseIf rightCollision.Tag = "walls2" Then
        moveRight = True
        isTouchingStickyWall = True
      ElseIf rightCollision.Tag = "spikes" Then
        movePlayerToSpawnPoint()
      End If


    End If

    Return False
  End Function
  Public Function checkLeftCollision() As Boolean
    Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col2)
    If res IsNot Nothing Then
      isTouchingLeft = True
      leftCollision = res.Item2

      If leftCollision.Name = "door" AndAlso collectedAllStar Then
        moveToNextLvl()
      End If
    Else
      isTouchingStickyWall = False
      isTouchingLeft = False
      leftCollision = Nothing
    End If

    If isTouchingLeft Then
      If leftCollision.Tag = "stars" Then
        starCount += 1
        leftCollision.Location = New Point(leftCollision.Location.X + 5000, leftCollision.Location.Y + 5000)
        If starCount >= 3 Then
          door.BackgroundImage = My.Resources.doorOpened
          'door.Location = New Point(1082, 467)
          collectedAllStar = True
        End If
      ElseIf leftCollision.Tag = "walls" Then
        isTouchingLeft = True
      ElseIf leftCollision.Tag = "walls2" Then
        isTouchingLeft = True
        isTouchingStickyWall = True
      ElseIf leftCollision.Tag = "spikes" Then
        movePlayerToSpawnPoint()
      End If

    End If
    Return False
  End Function

  Public Function checkGroundCollision() As Boolean
    Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col3)

    If res IsNot Nothing Then
      isTouchingGround = True
      groundCollision = res.Item2

      If groundCollision.Name = "door" AndAlso collectedAllStar Then
        moveToNextLvl()
      End If
    Else
      isTouchingGround = False
      groundCollision = Nothing
      yAxeGroundPosition = PictureBox1.Location.Y
    End If

    If isTouchingGround Then
      If groundCollision.Tag = "stars" Then
        starCount += 1
        groundCollision.Location = New Point(groundCollision.Location.X + 5000, groundCollision.Location.Y + 5000)
        If starCount >= 3 Then
          door.BackgroundImage = My.Resources.doorOpened
          'door.Location = New Point(1082, 467)
          collectedAllStar = True
        End If
      ElseIf groundCollision.Tag = "spikes" Then
        movePlayerToSpawnPoint()
      ElseIf groundCollision.Tag = "walls" Or groundCollision.Tag = "walls2" Then
        yAxeGroundPosition = groundCollision.Location.Y
      End If

    End If
    Return False
  End Function

  Public Function checkCeilingCollision() As Boolean
    'Label1.Text = col4.Location.Y
    Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(col4)

    If res IsNot Nothing AndAlso res.Item1 = True Then
      isTouchingCeiling = True
      ceilingCollision = res.Item2
      If ceilingCollision.Name = "door" AndAlso collectedAllStar Then
        moveToNextLvl()
      End If



      If ceilingCollision.Tag = "walls2" Then
        isTouchingStickyCeiling = True
      End If
      ' si la colision del techo es un pincho me caigo
      If timer_gravity.Enabled = False AndAlso isTouchingStickyCeiling = True AndAlso ceilingCollision.Tag = "spikes" Then
        timer_gravity.Start()
        isTouchingStickyCeiling = False
      End If



    ElseIf res Is Nothing Then
      '' if i move to the left or right when im sticked to a ceiling and then i stopped touching the ceiling, i will drop
      If timer_gravity.Enabled = False AndAlso isTouchingStickyCeiling = True Then
        timer_gravity.Start()
        isTouchingStickyCeiling = False
      End If
      isTouchingCeiling = False
      isTouchingStickyCeiling = False
      ceilingCollision = Nothing
    End If

    If isTouchingCeiling Then
      If ceilingCollision.Tag = "stars" Then
        starCount += 1
        ceilingCollision.Location = New Point(ceilingCollision.Location.X + 5000, ceilingCollision.Location.Y + 5000)
        If starCount >= 3 Then
          collectedAllStar = True
          door.BackgroundImage = My.Resources.doorOpened
          'door.Location = New Point(1082, 467)
        End If
      ElseIf ceilingCollision.Tag = "spikes" Then
        movePlayerToSpawnPoint()
      End If

    End If

    Return False
  End Function


  Private Sub timer_gravity_Tick(sender As Object, e As EventArgs) Handles timer_gravity.Tick
    applyGravity()
  End Sub


  'HITBOX COLLISIONS
  '
  '
  '
  '
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

        If enemy.Tag = "walls" Then
          If col3.Bounds.IntersectsWith(enemy.Bounds) Then
            If enemy.ReachedLimit = False AndAlso enemy.MovingDirection = "horizontal" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X - 1, pb1.Location.Y))
            ElseIf enemy.ReachedLimit = True AndAlso enemy.MovingDirection = "horizontal" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X + 1, pb1.Location.Y))
            End If

            If enemy.ReachedLimit = False AndAlso enemy.MovingDirection = "vertical" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X, pb1.Location.Y - 1))
            ElseIf enemy.ReachedLimit = True AndAlso enemy.MovingDirection = "vertical" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X, pb1.Location.Y + 1))
            End If
          End If
        End If
        If enemy.Tag = "walls2" Then
          If col4.Bounds.IntersectsWith(enemy.Bounds) Or col3.Bounds.IntersectsWith(enemy.Bounds) Then
            If enemy.ReachedLimit = False AndAlso enemy.MovingDirection = "horizontal" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X - 1, pb1.Location.Y))
            ElseIf enemy.ReachedLimit = True AndAlso enemy.MovingDirection = "horizontal" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X + 1, pb1.Location.Y))
            End If

            If enemy.ReachedLimit = False AndAlso enemy.MovingDirection = "vertical" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X, pb1.Location.Y - 1))
            ElseIf enemy.ReachedLimit = True AndAlso enemy.MovingDirection = "vertical" Then
              createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(pb1.Location.X, pb1.Location.Y + 1))
            End If
          End If
        End If
        If enemy.Tag = "spikes" Then
          Dim res As Tuple(Of Boolean, PictureBox) = checkCollision(enemy)
          If res IsNot Nothing AndAlso res.Item2.Name = "pb1" Then
            movePlayerToSpawnPoint()
          End If
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
      If TypeOf ctrl Is PictureBox AndAlso (ctrl.Tag = "walls" Or ctrl.Tag = "spikes" Or ctrl.Tag = "walls2" Or ctrl.Name = "pb1" Or ctrl.tag = "stars" Or ctrl.name = "door") Then
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
    deathc += 1
    SaveData.deathCount += 1
    deathCount.Text = SaveData.deathCount
    If starCount < 4 AndAlso collectedAllStar = False Then
      starCount = 0
      System.Console.WriteLine(door.BackgroundImage Is My.Resources.doorClosed)


      For Each ctrl As Control In Me.Controls
        If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "stars" Then
          Dim a As PictureBox = DirectCast(ctrl, PictureBox)
          If a.Location.X >= 4999 Then
            a.Location = New Point(a.Location.X - 5000, a.Location.Y - 5000)
          End If
        End If
      Next


    End If

    createCharacterAndItsHitboxes(New Size(pb1.Width, pb1.Height), New Point(spawnX, spanwY))

    ' reset
    velocityY = 0
    isJumping = False
    timer_gravity.Start()
    isTouchingCeiling = False
    ceilingCollision = Nothing
    isTouchingGround = False
    groundCollision = Nothing
    isTouchingLeft = False
    leftCollision = Nothing
    isTouchingRight = False
    rightCollision = Nothing
    moveLeft = False
    moveRight = False
    System.Console.WriteLine(yAxeGroundPosition)
    System.Console.WriteLine(velocityY)




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

  Public Function moveToNextLvl() As Boolean
    SaveData.levelsInfo(1) = New SaveData.Level("1.1", 11, True, My.Resources._11preview, deathc, timec)
    Tuto111.Show()
    Me.Close()
  End Function

  Private Sub pausebtn_Click(sender As Object, e As EventArgs) Handles pausebtn.Click
    If OptionsM.isOpeningOptionsMenu = False Then
      OptionsM.isOpeningOptionsMenu = True
      OptionsM.ShowDialog()
    End If
  End Sub

  Private Sub timeTimer_Tick(sender As Object, e As EventArgs) Handles timeTimer.Tick
    timec = Math.Round(timec + 0.1, 2)
    timeCount.Text = timec & "s"
  End Sub
End Class
