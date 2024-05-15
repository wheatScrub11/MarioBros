Imports System.Windows.Forms

Public Class BasicBullet1

    Inherits PictureBox

    Private _xP As Integer
    Private _yP As Integer
    Private _bD As String

    Public Property xPosition As Integer
        Get
            Return _xP
        End Get
        Set(value As Integer)
            _xP = value
        End Set
    End Property

    Public Property yPosition As Integer
        Get
            Return _yP
        End Get
        Set(value As Integer)
            _yP = value
        End Set
    End Property

    Public Property bulletDirection As String
        Get
            Return _bD
        End Get
        Set(value As String)
            _bD = value
        End Set
    End Property
End Class