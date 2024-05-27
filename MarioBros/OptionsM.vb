Public Class OptionsM
  Dim options() As Integer = {1, 2, 3}
  Dim currentOptionsIndex As Integer = 1
  Dim move As Boolean = False
  Public Property isOpeningOptionsMenu As Boolean = False




  Private Function resetSelectArrows(excluded As Integer) As Boolean
    Dim excludedLabelName As String = "op" & excluded


    For Each ctrl In Me.Controls
      If TypeOf ctrl Is PictureBox Then
        Dim lbl As PictureBox = DirectCast(ctrl, PictureBox)

        If lbl.Tag = excludedLabelName Or lbl.Name = "closebtn" Then
          lbl.Visible = True
        Else
          lbl.Visible = False
        End If
      End If
    Next
  End Function

  Private Function moveIndex(direction As String, i As Integer) As Boolean
    If move = False Then
      If direction = "down" Then
        If i = 3 Then
          currentOptionsIndex = 1
        Else
          currentOptionsIndex = i + 1
        End If
        resetSelectArrows(currentOptionsIndex)
      ElseIf direction = "up" Then
        If i = 1 Then
          currentOptionsIndex = 3
        Else
          currentOptionsIndex = i - 1
        End If
        resetSelectArrows(currentOptionsIndex)
      End If
      move = True
    End If

    Return False
  End Function

  Private Sub Options_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    Select Case e.KeyCode
      Case Keys.Enter
        If currentOptionsIndex = 1 Then

          Me.Close()
        ElseIf currentOptionsIndex = 2 Then
          If LevelSelector.isOpeningLevelSelectorMenu = False Then
            Dim a As New LevelSelector
            a.ShowDialog()
          End If
        ElseIf currentOptionsIndex = 3 Then
          Tuto1.Show()
          Me.Close()
        End If
      Case Keys.Escape
        Me.Close()
      Case Keys.Down
        moveIndex("down", currentOptionsIndex)

      Case Keys.Up
        moveIndex("up", currentOptionsIndex)
    End Select
  End Sub

  Private Sub Options_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
    Select Case e.KeyCode
      Case Keys.Down
        move = False
      Case Keys.Up
        move = False
    End Select
  End Sub

  Private Sub op1_MouseMove(sender As Object, e As EventArgs) Handles op1.MouseMove
    currentOptionsIndex = 1
    resetSelectArrows(currentOptionsIndex)
  End Sub

  Private Sub op2_MouseMove(sender As Object, e As EventArgs) Handles op2.MouseMove
    currentOptionsIndex = 2
    resetSelectArrows(currentOptionsIndex)
  End Sub
  Private Sub op3_MouseMove(sender As Object, e As EventArgs) Handles op3.MouseMove
    currentOptionsIndex = 3
    resetSelectArrows(currentOptionsIndex)
  End Sub

  Private Sub op1_Click(sender As Object, e As EventArgs) Handles op1.Click
    Me.Close()
  End Sub

  Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    currentOptionsIndex = 1
    resetSelectArrows(1)
    Me.isOpeningOptionsMenu = True
  End Sub

  Private Sub Options_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    Me.isOpeningOptionsMenu = False
    LevelSelector.isOpeningLevelSelectorMenu = False
  End Sub

  Private Sub op2_Click(sender As Object, e As EventArgs) Handles op2.Click
    If LevelSelector.isOpeningLevelSelectorMenu = False Then
      Dim a As New LevelSelector
      a.ShowDialog()
    End If
  End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

  Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
    Me.Close()
  End Sub
End Class
