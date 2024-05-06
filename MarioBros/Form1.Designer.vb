<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.timer_moveRight = New System.Windows.Forms.Timer(Me.components)
        Me.timer_moveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timer_gravity = New System.Windows.Forms.Timer(Me.components)
        Me.timer_jump = New System.Windows.Forms.Timer(Me.components)
        Me.col = New System.Windows.Forms.PictureBox()
        Me.col2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pb1.Location = New System.Drawing.Point(320, 283)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(100, 100)
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'timer_moveRight
        '
        Me.timer_moveRight.Interval = 1
        '
        'timer_moveLeft
        '
        Me.timer_moveLeft.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox1.Location = New System.Drawing.Point(0, 400)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(923, 92)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'timer_gravity
        '
        Me.timer_gravity.Interval = 1
        '
        'timer_jump
        '
        Me.timer_jump.Interval = 10
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.Transparent
        Me.col.Location = New System.Drawing.Point(420, 283)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(5, 100)
        Me.col.TabIndex = 4
        Me.col.TabStop = False
        Me.col.Visible = False
        '
        'col2
        '
        Me.col2.BackColor = System.Drawing.Color.Transparent
        Me.col2.Location = New System.Drawing.Point(320, 283)
        Me.col2.Name = "col2"
        Me.col2.Size = New System.Drawing.Size(5, 100)
        Me.col2.TabIndex = 5
        Me.col2.TabStop = False
        Me.col2.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox4.Location = New System.Drawing.Point(486, 271)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "walls"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox2.Location = New System.Drawing.Point(103, 271)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "walls"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 491)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.col2)
        Me.Controls.Add(Me.col)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pb1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb1 As PictureBox
    Friend WithEvents timer_moveRight As Timer
    Friend WithEvents timer_moveLeft As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents timer_gravity As Timer
    Friend WithEvents timer_jump As Timer
    Friend WithEvents col As PictureBox
    Friend WithEvents col2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
