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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.timer_moveRight = New System.Windows.Forms.Timer(Me.components)
        Me.timer_moveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timer_gravity = New System.Windows.Forms.Timer(Me.components)
        Me.timer_jump = New System.Windows.Forms.Timer(Me.components)
        Me.col = New System.Windows.Forms.PictureBox()
        Me.col2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.col3 = New System.Windows.Forms.PictureBox()
        Me.col4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.basicenemy1timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Transparent
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(26, 429)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(51, 87)
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
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 597)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1264, 82)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "walls"
        '
        'timer_gravity
        '
        Me.timer_gravity.Interval = 1
        '
        'timer_jump
        '
        Me.timer_jump.Interval = 1
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.SandyBrown
        Me.col.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col.Location = New System.Drawing.Point(76, 430)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(5, 85)
        Me.col.TabIndex = 4
        Me.col.TabStop = False
        Me.col.UseWaitCursor = True
        '
        'col2
        '
        Me.col2.BackColor = System.Drawing.Color.SandyBrown
        Me.col2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col2.Location = New System.Drawing.Point(21, 430)
        Me.col2.Name = "col2"
        Me.col2.Size = New System.Drawing.Size(5, 85)
        Me.col2.TabIndex = 5
        Me.col2.TabStop = False
        Me.col2.UseWaitCursor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox2.Location = New System.Drawing.Point(967, 409)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 20)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "walls"
        '
        'col3
        '
        Me.col3.BackColor = System.Drawing.Color.SandyBrown
        Me.col3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col3.Location = New System.Drawing.Point(27, 516)
        Me.col3.Name = "col3"
        Me.col3.Size = New System.Drawing.Size(48, 8)
        Me.col3.TabIndex = 10
        Me.col3.TabStop = False
        Me.col3.UseWaitCursor = True
        Me.col3.Visible = False
        '
        'col4
        '
        Me.col4.BackColor = System.Drawing.Color.SandyBrown
        Me.col4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col4.Location = New System.Drawing.Point(27, 424)
        Me.col4.Name = "col4"
        Me.col4.Size = New System.Drawing.Size(48, 5)
        Me.col4.TabIndex = 22
        Me.col4.TabStop = False
        Me.col4.UseWaitCursor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(260, 561)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(44, 48)
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "visual"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox7.Location = New System.Drawing.Point(214, 424)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox7.TabIndex = 27
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "walls"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox17.Location = New System.Drawing.Point(230, 218)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(100, 19)
        Me.PictureBox17.TabIndex = 37
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "walls"
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox18.Location = New System.Drawing.Point(392, 251)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(23, 58)
        Me.PictureBox18.TabIndex = 38
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Tag = "walls"
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox21.Location = New System.Drawing.Point(445, 330)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(137, 47)
        Me.PictureBox21.TabIndex = 42
        Me.PictureBox21.TabStop = False
        Me.PictureBox21.Tag = "walls"
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox23.Location = New System.Drawing.Point(358, 129)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox23.TabIndex = 44
        Me.PictureBox23.TabStop = False
        Me.PictureBox23.Tag = "walls"
        '
        'PictureBox24
        '
        Me.PictureBox24.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox24.Location = New System.Drawing.Point(512, 112)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox24.TabIndex = 45
        Me.PictureBox24.TabStop = False
        Me.PictureBox24.Tag = "walls"
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox25.Location = New System.Drawing.Point(755, 54)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox25.TabIndex = 46
        Me.PictureBox25.TabStop = False
        Me.PictureBox25.Tag = "walls"
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox20.Location = New System.Drawing.Point(650, 533)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(59, 58)
        Me.PictureBox20.TabIndex = 47
        Me.PictureBox20.TabStop = False
        Me.PictureBox20.Tag = "walls"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, 597)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1264, 98)
        Me.PictureBox6.TabIndex = 48
        Me.PictureBox6.TabStop = False
        '
        'basicenemy1timer
        '
        Me.basicenemy1timer.Enabled = True
        Me.basicenemy1timer.Interval = 10
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox19.Location = New System.Drawing.Point(736, 490)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(137, 34)
        Me.PictureBox19.TabIndex = 40
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Tag = "walls"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox5.Location = New System.Drawing.Point(291, 516)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 58)
        Me.PictureBox5.TabIndex = 49
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "walls"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox8.Location = New System.Drawing.Point(214, 317)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(60, 10)
        Me.PictureBox8.TabIndex = 50
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "walls"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PictureBox3.Location = New System.Drawing.Point(4, 232)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 77)
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "walls"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Location = New System.Drawing.Point(274, 580)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(17, 29)
        Me.PictureBox9.TabIndex = 52
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "spikes"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox10.Location = New System.Drawing.Point(892, 279)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(15, 20)
        Me.PictureBox10.TabIndex = 53
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "walls"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox11.Location = New System.Drawing.Point(1087, 317)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(63, 20)
        Me.PictureBox11.TabIndex = 53
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "walls"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox12.Location = New System.Drawing.Point(601, 330)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(63, 20)
        Me.PictureBox12.TabIndex = 54
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "walls"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.col4)
        Me.Controls.Add(Me.col3)
        Me.Controls.Add(Me.col2)
        Me.Controls.Add(Me.col)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox19)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb1 As PictureBox
    Friend WithEvents timer_moveRight As Timer
    Friend WithEvents timer_moveLeft As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents timer_gravity As Timer
    Friend WithEvents timer_jump As Timer
    Friend WithEvents col As PictureBox
    Friend WithEvents col2 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents col3 As PictureBox
    Friend WithEvents col4 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents basicenemy1timer As Timer
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label1 As Label
End Class
