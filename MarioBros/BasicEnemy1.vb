Imports System.Windows.Forms

Public Class BasicEnemy1

    Inherits PictureBox

    Private _mD As String
    Private _tP As String
    Private _mA As Integer
    Private _mB As Integer

    Private _rL As Boolean

    Public Property MovingDirection As String
        Get
            Return _mD
        End Get
        Set(value As String)
            _mD = value
        End Set
    End Property
    Public Property TouchedPoint As String
        Get
            Return _tP
        End Get
        Set(value As String)
            _tP = value
        End Set
    End Property

    Public Property MaxA As Integer
        Get
            Return _mA
        End Get
        Set(value As Integer)
            _mA = value
        End Set
    End Property


    Public Property MaxB As Integer
        Get
            Return _mB
        End Get
        Set(value As Integer)
            _mB = value
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
