Public Class SaveData

    Public Class Level
        Public Property name As String
        Public Property id As Integer
        Public Property completed As Boolean

        Public Property backgroundPreview As Image
        Public Property deaths As Integer
        Public Property time As Double

        Public Sub New(Name As String, Id As Integer, Completed As Boolean, BackgroundPreview As Image, Deaths As Integer, Time As Double)
            Me.name = Name
            Me.id = Id
            Me.completed = Completed
            Me.backgroundPreview = BackgroundPreview
            Me.deaths = Deaths
            Me.time = Time
        End Sub
    End Class

    Public Property openedForm As Form
    Public Property deathCount As Integer = 0
    'Public Property deathCount1 As Integer = 0
    'Public Property deathCount11 As Integer = 0
    'Public Property deathCount111 As Integer = 0
    'Public Property deathCount2 As Integer = 0
    'Public Property deathCount22 As Integer = 0
    'Public Property deathCount222 As Integer = 0
    'Public Property deathCount3 As Integer = 0
    'Public Property deathCount33 As Integer = 0
    'Public Property deathCount333 As Integer = 0
    'Public Property deathCount4 As Integer = 0

    Public Property totalBestTime As Double = 0
    'Public Property bestTimeTuto1 As Double = 0
    'Public Property bestTimeTuto11 As Double = 0
    'Public Property bestTimeTuto111 As Double = 0
    'Public Property bestTimeTuto2 As Double = 0
    'Public Property bestTimeTuto22 As Double = 0
    'Public Property bestTimeTuto222 As Double = 0
    'Public Property bestTimeTuto3 As Double = 0
    'Public Property bestTimeTuto33 As Double = 0
    'Public Property bestTimeTuto333 As Double = 0
    'Public Property bestTimeTuto4 As Double = 0


    Public Property levelsInfo As New List(Of Level) From {
        New Level("1.", 1, False, My.Resources._1preview, 0, 0),
        New Level("1.1", 11, False, My.Resources._11preview, 0, 0),
        New Level("1.1.1", 111, False, My.Resources._111preview, 0, 0),
        New Level("2.", 2, False, My.Resources._111preview, 0, 0),
        New Level("2.2", 22, False, My.Resources._111preview, 0, 0),
        New Level("2.2.2", 222, False, My.Resources._111preview, 0, 0),
        New Level("3.", 3, False, My.Resources._111preview, 0, 0),
        New Level("3.3", 33, False, My.Resources._111preview, 0, 0),
        New Level("3.3.3", 333, False, My.Resources._111preview, 0, 0),
        New Level("4", 4, False, My.Resources._111preview, 0, 0)
    }




    Private Sub SaveData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class