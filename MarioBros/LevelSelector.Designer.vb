<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelSelector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lvlname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deathcount = New System.Windows.Forms.Label()
        Me.besttime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.behaviour = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.previewimg = New System.Windows.Forms.PictureBox()
        Me.closebtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pressenter = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvlname
        '
        Me.lvlname.AutoSize = True
        Me.lvlname.BackColor = System.Drawing.Color.Transparent
        Me.lvlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlname.ForeColor = System.Drawing.Color.White
        Me.lvlname.Location = New System.Drawing.Point(621, 85)
        Me.lvlname.Name = "lvlname"
        Me.lvlname.Size = New System.Drawing.Size(162, 37)
        Me.lvlname.TabIndex = 2
        Me.lvlname.Text = "Lvlnamee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(418, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Muertes:"
        '
        'deathcount
        '
        Me.deathcount.AutoSize = True
        Me.deathcount.BackColor = System.Drawing.Color.Transparent
        Me.deathcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deathcount.ForeColor = System.Drawing.Color.GreenYellow
        Me.deathcount.Location = New System.Drawing.Point(583, 424)
        Me.deathcount.Name = "deathcount"
        Me.deathcount.Size = New System.Drawing.Size(36, 37)
        Me.deathcount.TabIndex = 4
        Me.deathcount.Text = "0"
        '
        'besttime
        '
        Me.besttime.AutoSize = True
        Me.besttime.BackColor = System.Drawing.Color.Transparent
        Me.besttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.besttime.ForeColor = System.Drawing.Color.GreenYellow
        Me.besttime.Location = New System.Drawing.Point(681, 467)
        Me.besttime.Name = "besttime"
        Me.besttime.Size = New System.Drawing.Size(120, 37)
        Me.besttime.TabIndex = 6
        Me.besttime.Text = "24.23s"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(418, 467)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mejor tiempo:"
        '
        'behaviour
        '
        Me.behaviour.AutoSize = True
        Me.behaviour.BackColor = System.Drawing.Color.Yellow
        Me.behaviour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.behaviour.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.behaviour.ForeColor = System.Drawing.Color.Black
        Me.behaviour.Location = New System.Drawing.Point(476, 533)
        Me.behaviour.Name = "behaviour"
        Me.behaviour.Size = New System.Drawing.Size(162, 37)
        Me.behaviour.TabIndex = 10
        Me.behaviour.Text = "Lvlnamee"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.MarioBros.My.Resources.Resources.opacitybg
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(1102, 131)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(402, 270)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.MarioBros.My.Resources.Resources.arrowselection
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(865, 246)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 59)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.MarioBros.My.Resources.Resources.arrowselectionleft
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(317, 246)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 59)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'previewimg
        '
        Me.previewimg.BackColor = System.Drawing.Color.White
        Me.previewimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.previewimg.Location = New System.Drawing.Point(426, 131)
        Me.previewimg.Name = "previewimg"
        Me.previewimg.Size = New System.Drawing.Size(402, 270)
        Me.previewimg.TabIndex = 1
        Me.previewimg.TabStop = False
        '
        'closebtn
        '
        Me.closebtn.BackColor = System.Drawing.Color.Transparent
        Me.closebtn.BackgroundImage = Global.MarioBros.My.Resources.Resources.closebtn
        Me.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closebtn.Location = New System.Drawing.Point(21, 12)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(54, 52)
        Me.closebtn.TabIndex = 0
        Me.closebtn.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.MarioBros.My.Resources.Resources.opacitybg
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(-248, 131)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(402, 270)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(501, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nivel"
        '
        'pressenter
        '
        Me.pressenter.AutoSize = True
        Me.pressenter.BackColor = System.Drawing.Color.Transparent
        Me.pressenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pressenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pressenter.ForeColor = System.Drawing.Color.Linen
        Me.pressenter.Location = New System.Drawing.Point(466, 581)
        Me.pressenter.Name = "pressenter"
        Me.pressenter.Size = New System.Drawing.Size(302, 37)
        Me.pressenter.TabIndex = 14
        Me.pressenter.Text = "> Presiona Enter <"
        Me.pressenter.Visible = False
        '
        'LevelSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.pressenter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.behaviour)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.besttime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.deathcount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvlname)
        Me.Controls.Add(Me.previewimg)
        Me.Controls.Add(Me.closebtn)
        Me.DoubleBuffered = True
        Me.Name = "LevelSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "t"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closebtn As PictureBox
    Friend WithEvents previewimg As PictureBox
    Friend WithEvents lvlname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents deathcount As Label
    Friend WithEvents besttime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents behaviour As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pressenter As Label
End Class
