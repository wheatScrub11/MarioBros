Public Class Form1

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
        End If

        Return False
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yAxeGroundPosition = 400
    timer_gravity.Start()
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

      For Each ctrl As Control In Me.Controls
        If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
          Dim picBox As PictureBox = DirectCast(ctrl, PictureBox)

          If moveRight Then
            If col.Bounds.IntersectsWith(picBox.Bounds) Then
              Dim distance = picBox.Location.X - (pb1.Location.X + pb1.Width)
              pb1.Location = New Point(pb1.Location.X + distance, pb1.Location.Y)
              moveRight = False

            Else
              pb1.Location = New Point(pb1.Location.X + moveVal, pb1.Location.Y)
              col.Location = New Point(col.Location.X + moveVal, col.Location.Y)
              col2.Location = New Point(col2.Location.X + moveVal, col2.Location.Y)
              moveLeft = True

            End If
          Else
            System.Console.WriteLine("NO SE PUEDE MOVER")
          End If


        End If
      Next

      'pb1.Location = New Point(pb1.Location.X + moveVal, pb1.Location.Y)
    End If



  End Sub
  Private Sub timer_moveLeft_Tick(sender As Object, e As EventArgs) Handles timer_moveLeft.Tick

    If timer_moveRight.Enabled = True And timer_moveLeft.Enabled = True Then
      pb1.Location = New Point(pb1.Location.X, pb1.Location.Y)
    Else
      For Each ctrl As Control In Me.Controls
        If TypeOf ctrl Is PictureBox AndAlso ctrl.Tag = "walls" Then
          Dim picBox As PictureBox = DirectCast(ctrl, PictureBox)

          If moveLeft Then
            If col2.Bounds.IntersectsWith(picBox.Bounds) Then
              Dim distance = pb1.Location.X - (picBox.Location.X + picBox.Width)
              pb1.Location = New Point(pb1.Location.X - distance, pb1.Location.Y)

              moveLeft = False
            Else
              pb1.Location = New Point(pb1.Location.X - moveVal, pb1.Location.Y)
              col2.Location = New Point(col2.Location.X - moveVal, col2.Location.Y)
              col.Location = New Point(col.Location.X - moveVal, col.Location.Y)
              moveRight = True

            End If
          Else
            System.Console.WriteLine("No sep uede mover")
          End If
        End If
      Next

    End If


    End Sub
    Private Sub timer_jump_Tick(sender As Object, e As EventArgs) Handles timer_jump.Tick

    End Sub

    Private Sub pb1_LocationChanged(sender As Object, e As EventArgs) Handles pb1.LocationChanged
        'If pb1.Bounds.IntersectsWith(pb2.Bounds) Then
        'pb1.Location = New Point(pb1.Location.X - 1, pb1.Location.Y)
        'End If
    End Sub

    Private Sub timer_gravity_Tick(sender As Object, e As EventArgs) Handles timer_gravity.Tick
        applyGravity()
    End Sub

    Private Sub col_Click(sender As Object, e As EventArgs) Handles col.Click

    End Sub
End Class
