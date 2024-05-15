Imports System.Windows.Forms

Public Class BasicEnemy1

    Inherits PictureBox

    Private _mD As String
    Private _rL As Boolean
    Public Property MovingDirection As String
        Get
            Return _mD
        End Get
        Set(value As String)
            _mD = value
        End Set
    End Property

    Public Property ReachedLimit As Boolean
        Get
            Return _rL
        End Get
        Set(value As Boolean)
            _rL = value
        End Set
    End Property
End Class
