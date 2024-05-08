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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.col3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pb1.Location = New System.Drawing.Point(295, 224)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(50, 50)
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
        Me.timer_jump.Interval = 1
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.SandyBrown
        Me.col.Location = New System.Drawing.Point(345, 224)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(5, 48)
        Me.col.TabIndex = 4
        Me.col.TabStop = False
        '
        'col2
        '
        Me.col2.BackColor = System.Drawing.Color.SandyBrown
        Me.col2.Location = New System.Drawing.Point(290, 225)
        Me.col2.Name = "col2"
        Me.col2.Size = New System.Drawing.Size(5, 48)
        Me.col2.TabIndex = 5
        Me.col2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox2.Location = New System.Drawing.Point(12, 324)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 70)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "walls"
        '
        'col3
        '
        Me.col3.BackColor = System.Drawing.Color.SandyBrown
        Me.col3.Location = New System.Drawing.Point(296, 274)
        Me.col3.Name = "col3"
        Me.col3.Size = New System.Drawing.Size(48, 10)
        Me.col3.TabIndex = 10
        Me.col3.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox3.Location = New System.Drawing.Point(207, 113)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 281)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "walls"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox5.Location = New System.Drawing.Point(732, 225)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 100)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "walls"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox6.Location = New System.Drawing.Point(839, 173)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 100)
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "walls"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox4.Location = New System.Drawing.Point(534, 324)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 100)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "walls"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox7.Location = New System.Drawing.Point(629, 262)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 100)
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "walls"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox8.Location = New System.Drawing.Point(395, 113)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(187, 37)
        Me.PictureBox8.TabIndex = 17
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "walls"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox9.Location = New System.Drawing.Point(161, 281)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox9.TabIndex = 18
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "walls"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox10.Location = New System.Drawing.Point(12, 224)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(40, 19)
        Me.PictureBox10.TabIndex = 19
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "walls"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox11.Location = New System.Drawing.Point(694, 125)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(47, 25)
        Me.PictureBox11.TabIndex = 20
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "walls"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Tomato
        Me.PictureBox12.Location = New System.Drawing.Point(161, 173)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(40, 19)
        Me.PictureBox12.TabIndex = 21
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "walls"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 491)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.col3)
        Me.Controls.Add(Me.PictureBox2)
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents col3 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
End Class
