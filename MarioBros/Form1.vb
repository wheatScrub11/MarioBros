﻿Public Class Form1

    Dim yAxeGroundPosition As Int64
    Dim moveVal As Int64 = 5
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
        'System.Console.WriteLine(pb2.Location.X)
        System.Console.WriteLine(pb1.Location.X + pb1.Width)
    End Sub


    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ' Sets Handled to true to prevent other controls from
        ' receiving the key if an arrow key was pressed



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

        System.Console.WriteLine("PASO")
        If timer_moveRight.Enabled = True And timer_moveLeft.Enabled = True Then
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y)
        Else

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is PictureBox AndAlso ctrl IsNot pb1 AndAlso ctrl IsNot PictureBox1 Then
                    Dim picBox As PictureBox = DirectCast(ctrl, PictureBox)

                    If pb1.Location.X + pb1.Width + moveVal >= picBox.Location.X AndAlso pb1.Location.X + pb1.Width + moveVal <= picBox.Location.X + picBox.Width Then
                        System.Console.WriteLine("JAJJAJJA")
                        System.Console.WriteLine(picBox.Location.X)
                        System.Console.WriteLine(pb1.Location.X + pb1.Width)
                        moveVal = picBox.Location.X - (pb1.Location.X + pb1.Width)
                        System.Console.WriteLine(moveVal)
                        pb1.Location = New Point(pb1.Location.X + moveVal, pb1.Location.Y)


                        moveVal = 5

                    ElseIf pb1.Location.X + pb1.Width = picBox.Location.X Then

                    Else
                        pb1.Location = New Point(pb1.Location.X + moveVal, pb1.Location.Y)

                    End If
                End If
            Next


            'pb1.Location = New Point(pb1.Location.X + 15, pb1.Location.Y)
        End If



    End Sub
    Private Sub timer_moveLeft_Tick(sender As Object, e As EventArgs) Handles timer_moveLeft.Tick

        If timer_moveRight.Enabled = True And timer_moveLeft.Enabled = True Then
            pb1.Location = New Point(pb1.Location.X, pb1.Location.Y)
        Else
            pb1.Location = New Point(pb1.Location.X - 5, pb1.Location.Y)
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




End Class
