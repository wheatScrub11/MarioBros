<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timer_moveRight = New System.Windows.Forms.Timer(Me.components)
        Me.timer_moveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timer_gravity = New System.Windows.Forms.Timer(Me.components)
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.col4 = New System.Windows.Forms.PictureBox()
        Me.col3 = New System.Windows.Forms.PictureBox()
        Me.col2 = New System.Windows.Forms.PictureBox()
        Me.col = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timer_jump = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer_moveRight
        '
        Me.timer_moveRight.Interval = 1
        '
        'timer_moveLeft
        '
        Me.timer_moveLeft.Interval = 1
        '
        'timer_gravity
        '
        Me.timer_gravity.Enabled = True
        Me.timer_gravity.Interval = 1
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.DarkRed
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(144, 472)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(51, 87)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 34
        Me.pb1.TabStop = False
        '
        'col4
        '
        Me.col4.BackColor = System.Drawing.Color.SandyBrown
        Me.col4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col4.Location = New System.Drawing.Point(145, 467)
        Me.col4.Name = "col4"
        Me.col4.Size = New System.Drawing.Size(48, 5)
        Me.col4.TabIndex = 38
        Me.col4.TabStop = False
        Me.col4.UseWaitCursor = True
        Me.col4.Visible = False
        '
        'col3
        '
        Me.col3.BackColor = System.Drawing.Color.SandyBrown
        Me.col3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col3.Location = New System.Drawing.Point(145, 559)
        Me.col3.Name = "col3"
        Me.col3.Size = New System.Drawing.Size(48, 8)
        Me.col3.TabIndex = 37
        Me.col3.TabStop = False
        Me.col3.UseWaitCursor = True
        Me.col3.Visible = False
        '
        'col2
        '
        Me.col2.BackColor = System.Drawing.Color.SandyBrown
        Me.col2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col2.Location = New System.Drawing.Point(139, 473)
        Me.col2.Name = "col2"
        Me.col2.Size = New System.Drawing.Size(5, 85)
        Me.col2.TabIndex = 36
        Me.col2.TabStop = False
        Me.col2.UseWaitCursor = True
        Me.col2.Visible = False
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.SandyBrown
        Me.col.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col.Location = New System.Drawing.Point(194, 473)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(5, 85)
        Me.col.TabIndex = 35
        Me.col.TabStop = False
        Me.col.UseWaitCursor = True
        Me.col.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(2, 640)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1278, 77)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "walls"
        '
        'timer_jump
        '
        Me.timer_jump.Interval = 1
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.col4)
        Me.Controls.Add(Me.col3)
        Me.Controls.Add(Me.col2)
        Me.Controls.Add(Me.col)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timer_moveRight As Timer
    Friend WithEvents timer_moveLeft As Timer
    Friend WithEvents timer_gravity As Timer
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents col4 As PictureBox
    Friend WithEvents col3 As PictureBox
    Friend WithEvents col2 As PictureBox
    Friend WithEvents col As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents timer_jump As Timer
End Class
