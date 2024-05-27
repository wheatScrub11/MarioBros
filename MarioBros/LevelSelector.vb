Imports System.Reflection
Public Class LevelSelector
    Dim options() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
    Dim currentOptionsIndex As Integer = 0
    Dim move As Boolean = False
    Public Property isOpeningLevelSelectorMenu As Boolean = False

    Private Function moveIndex(direction As String, i As Integer) As Boolean
        If move = False Then
            If direction = "right" Then
                If i = 9 Then
                    currentOptionsIndex = 0
                Else
                    currentOptionsIndex = i + 1
                End If
                'resetSelectArrows(currentOptionsIndex)
            ElseIf direction = "left" Then
                If i = 0 Then
                    currentOptionsIndex = 9
                Else
                    currentOptionsIndex = i - 1
                End If
                'resetSelectArrows(currentOptionsIndex)
            End If
            move = True
        End If

        System.Console.WriteLine(currentOptionsIndex)
        lvlname.Text = SaveData.levelsInfo(currentOptionsIndex).name
        previewimg.BackgroundImage = SaveData.levelsInfo(currentOptionsIndex).backgroundPreview
        If SaveData.levelsInfo(currentOptionsIndex).completed = True Then
            behaviour.Text = "¡Jugar de nuevo!"
            behaviour.ForeColor = Color.Yellow

            deathcount.Text = SaveData.levelsInfo(currentOptionsIndex).deaths
            besttime.Text = SaveData.levelsInfo(currentOptionsIndex).time
        Else
            behaviour.Text = "No completado"
            behaviour.ForeColor = Color.Red
            deathcount.Text = "???"
            besttime.Text = "???"
        End If




        Return False
    End Function

    Private Sub Options_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter

            Case Keys.Escape
                Me.Close()

            Case Keys.Right
                moveIndex("right", currentOptionsIndex)

            Case Keys.Left
                moveIndex("left", currentOptionsIndex)
            Case Keys.Up

        End Select
    End Sub

    Private Sub Options_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                move = False
            Case Keys.Left
                move = False
        End Select
    End Sub

    Private Sub LevelSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.isOpeningLevelSelectorMenu = True
        lvlname.Text = SaveData.levelsInfo(currentOptionsIndex).name
        previewimg.BackgroundImage = SaveData.levelsInfo(currentOptionsIndex).backgroundPreview
        If SaveData.levelsInfo(currentOptionsIndex).completed = True Then
            behaviour.Text = "¡Jugar de nuevo!"
            behaviour.ForeColor = Color.Yellow

            deathcount.Text = SaveData.levelsInfo(currentOptionsIndex).deaths
            besttime.Text = SaveData.levelsInfo(currentOptionsIndex).time
        Else
            behaviour.Text = "No completado"
            behaviour.ForeColor = Color.Red
            deathcount.Text = "???"
            besttime.Text = "???"
        End If
    End Sub
    Private Sub LevelSelector_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.isOpeningLevelSelectorMenu = False
        OptionsM.isOpeningOptionsMenu = False
    End Sub

    Public Function closeAllForms(exception As Integer)
        Dim frmname As String = "Tuto" & exception

        For Each form As Form In Application.OpenForms.OfType(Of Form)().ToArray()
            System.Console.WriteLine(form.Name)
            If form.Name = "Options" Or form.Name = "LevelSelector" Then
                form.Close()
            End If
        Next
    End Function
    '' ?????????????
    Public Function LoopThroughForms(id As Integer) As Form
        Dim frmname As String = "Tuto" & id
        Dim currentAssembly As Assembly = Assembly.GetExecutingAssembly()


        For Each type As Type In currentAssembly.GetTypes()

            If type.IsSubclassOf(GetType(Form)) Then

                Dim formInstance As Form = CType(Activator.CreateInstance(type), Form)

                If formInstance.Name = frmname Then
                    Return formInstance
                End If
            End If
        Next
    End Function

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub behaviour_Click(sender As Object, e As EventArgs) Handles behaviour.Click
        If behaviour.Text = "¡Jugar de nuevo!" Then


            Dim newform = LoopThroughForms(SaveData.levelsInfo(currentOptionsIndex).id)
            If newform IsNot Nothing Then
                'closeAllForms(SaveData.levelsInfo(currentOptionsIndex).id)

                Me.Close()
                OptionsM.Close()
                SaveData.openedForm.Close()
                newform.Show()
            End If
        End If
    End Sub

End Class