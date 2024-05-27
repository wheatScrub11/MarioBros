<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tuto111
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tuto111))
        Me.timer_moveRight = New System.Windows.Forms.Timer(Me.components)
        Me.timer_moveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timer_jump = New System.Windows.Forms.Timer(Me.components)
        Me.timer_gravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.basicenemy1timer = New System.Windows.Forms.Timer(Me.components)
        Me.basicbullet1timer = New System.Windows.Forms.Timer(Me.components)
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.col4 = New System.Windows.Forms.PictureBox()
        Me.col3 = New System.Windows.Forms.PictureBox()
        Me.col2 = New System.Windows.Forms.PictureBox()
        Me.col = New System.Windows.Forms.PictureBox()
        Me.door = New System.Windows.Forms.PictureBox()
        Me.star3 = New System.Windows.Forms.PictureBox()
        Me.star2 = New System.Windows.Forms.PictureBox()
        Me.star1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox36 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.PictureBox53 = New System.Windows.Forms.PictureBox()
        Me.PictureBox39 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox40 = New System.Windows.Forms.PictureBox()
        Me.PictureBox38 = New System.Windows.Forms.PictureBox()
        Me.PictureBox41 = New System.Windows.Forms.PictureBox()
        Me.PictureBox42 = New System.Windows.Forms.PictureBox()
        Me.PictureBox43 = New System.Windows.Forms.PictureBox()
        Me.PictureBox56 = New System.Windows.Forms.PictureBox()
        Me.PictureBox57 = New System.Windows.Forms.PictureBox()
        Me.PictureBox67 = New System.Windows.Forms.PictureBox()
        Me.PictureBox68 = New System.Windows.Forms.PictureBox()
        Me.PictureBox58 = New System.Windows.Forms.PictureBox()
        Me.PictureBox59 = New System.Windows.Forms.PictureBox()
        Me.PictureBox60 = New System.Windows.Forms.PictureBox()
        Me.PictureBox61 = New System.Windows.Forms.PictureBox()
        Me.PictureBox62 = New System.Windows.Forms.PictureBox()
        Me.PictureBox63 = New System.Windows.Forms.PictureBox()
        Me.PictureBox64 = New System.Windows.Forms.PictureBox()
        Me.PictureBox65 = New System.Windows.Forms.PictureBox()
        Me.PictureBox66 = New System.Windows.Forms.PictureBox()
        Me.PictureBox69 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox33 = New System.Windows.Forms.PictureBox()
        Me.PictureBox34 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.BasicEnemy14 = New MarioBros.BasicEnemy1()
        Me.BasicEnemy13 = New MarioBros.BasicEnemy1()
        Me.BasicEnemy12 = New MarioBros.BasicEnemy1()
        Me.BasicEnemy11 = New MarioBros.BasicEnemy1()
        Me.timeCount = New System.Windows.Forms.Label()
        Me.pausebtn = New System.Windows.Forms.PictureBox()
        Me.deathCount = New System.Windows.Forms.Label()
        Me.timeTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicEnemy14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicEnemy13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicEnemy12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicEnemy11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pausebtn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'timer_jump
        '
        Me.timer_jump.Interval = 1
        '
        'timer_gravity
        '
        Me.timer_gravity.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 579)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1266, 106)
        Me.PictureBox1.TabIndex = 204
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "walls"
        '
        'basicenemy1timer
        '
        Me.basicenemy1timer.Enabled = True
        Me.basicenemy1timer.Interval = 1
        '
        'basicbullet1timer
        '
        Me.basicbullet1timer.Interval = 1
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.DarkRed
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(120, 438)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(51, 87)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 234
        Me.pb1.TabStop = False
        '
        'col4
        '
        Me.col4.BackColor = System.Drawing.Color.SandyBrown
        Me.col4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col4.Location = New System.Drawing.Point(121, 433)
        Me.col4.Name = "col4"
        Me.col4.Size = New System.Drawing.Size(48, 5)
        Me.col4.TabIndex = 238
        Me.col4.TabStop = False
        Me.col4.UseWaitCursor = True
        Me.col4.Visible = False
        '
        'col3
        '
        Me.col3.BackColor = System.Drawing.Color.SandyBrown
        Me.col3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col3.Location = New System.Drawing.Point(121, 525)
        Me.col3.Name = "col3"
        Me.col3.Size = New System.Drawing.Size(48, 8)
        Me.col3.TabIndex = 237
        Me.col3.TabStop = False
        Me.col3.UseWaitCursor = True
        Me.col3.Visible = False
        '
        'col2
        '
        Me.col2.BackColor = System.Drawing.Color.SandyBrown
        Me.col2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col2.Location = New System.Drawing.Point(115, 439)
        Me.col2.Name = "col2"
        Me.col2.Size = New System.Drawing.Size(5, 85)
        Me.col2.TabIndex = 236
        Me.col2.TabStop = False
        Me.col2.UseWaitCursor = True
        Me.col2.Visible = False
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.SandyBrown
        Me.col.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.col.Location = New System.Drawing.Point(170, 439)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(5, 85)
        Me.col.TabIndex = 235
        Me.col.TabStop = False
        Me.col.UseWaitCursor = True
        Me.col.Visible = False
        '
        'door
        '
        Me.door.BackColor = System.Drawing.Color.Transparent
        Me.door.BackgroundImage = Global.MarioBros.My.Resources.Resources.doorClosed
        Me.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.door.Location = New System.Drawing.Point(576, 78)
        Me.door.Name = "door"
        Me.door.Size = New System.Drawing.Size(111, 126)
        Me.door.TabIndex = 242
        Me.door.TabStop = False
        Me.door.Tag = "walls"
        '
        'star3
        '
        Me.star3.BackColor = System.Drawing.Color.Transparent
        Me.star3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.star3.Image = CType(resources.GetObject("star3.Image"), System.Drawing.Image)
        Me.star3.InitialImage = CType(resources.GetObject("star3.InitialImage"), System.Drawing.Image)
        Me.star3.Location = New System.Drawing.Point(673, 529)
        Me.star3.Name = "star3"
        Me.star3.Size = New System.Drawing.Size(30, 28)
        Me.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star3.TabIndex = 241
        Me.star3.TabStop = False
        Me.star3.Tag = "stars"
        Me.star3.UseWaitCursor = True
        '
        'star2
        '
        Me.star2.BackColor = System.Drawing.Color.Transparent
        Me.star2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.star2.Image = CType(resources.GetObject("star2.Image"), System.Drawing.Image)
        Me.star2.InitialImage = CType(resources.GetObject("star2.InitialImage"), System.Drawing.Image)
        Me.star2.Location = New System.Drawing.Point(965, 93)
        Me.star2.Name = "star2"
        Me.star2.Size = New System.Drawing.Size(30, 28)
        Me.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star2.TabIndex = 240
        Me.star2.TabStop = False
        Me.star2.Tag = "stars"
        Me.star2.UseWaitCursor = True
        '
        'star1
        '
        Me.star1.BackColor = System.Drawing.Color.Transparent
        Me.star1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.star1.Image = CType(resources.GetObject("star1.Image"), System.Drawing.Image)
        Me.star1.InitialImage = CType(resources.GetObject("star1.InitialImage"), System.Drawing.Image)
        Me.star1.Location = New System.Drawing.Point(152, 177)
        Me.star1.Name = "star1"
        Me.star1.Size = New System.Drawing.Size(30, 28)
        Me.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star1.TabIndex = 239
        Me.star1.TabStop = False
        Me.star1.Tag = "stars"
        Me.star1.UseWaitCursor = True
        '
        'PictureBox36
        '
        Me.PictureBox36.BackgroundImage = CType(resources.GetObject("PictureBox36.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox36.Location = New System.Drawing.Point(247, 488)
        Me.PictureBox36.Name = "PictureBox36"
        Me.PictureBox36.Size = New System.Drawing.Size(44, 92)
        Me.PictureBox36.TabIndex = 244
        Me.PictureBox36.TabStop = False
        Me.PictureBox36.Tag = "walls"
        '
        'PictureBox32
        '
        Me.PictureBox32.BackgroundImage = CType(resources.GetObject("PictureBox32.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox32.Location = New System.Drawing.Point(512, 525)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(44, 55)
        Me.PictureBox32.TabIndex = 243
        Me.PictureBox32.TabStop = False
        Me.PictureBox32.Tag = "walls"
        '
        'PictureBox53
        '
        Me.PictureBox53.BackgroundImage = CType(resources.GetObject("PictureBox53.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox53.Location = New System.Drawing.Point(536, 204)
        Me.PictureBox53.Name = "PictureBox53"
        Me.PictureBox53.Size = New System.Drawing.Size(193, 49)
        Me.PictureBox53.TabIndex = 246
        Me.PictureBox53.TabStop = False
        Me.PictureBox53.Tag = "walls"
        '
        'PictureBox39
        '
        Me.PictureBox39.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox39.BackgroundImage = Global.MarioBros.My.Resources.Resources.multispike
        Me.PictureBox39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox39.Location = New System.Drawing.Point(512, 389)
        Me.PictureBox39.Name = "PictureBox39"
        Me.PictureBox39.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox39.TabIndex = 254
        Me.PictureBox39.TabStop = False
        Me.PictureBox39.Tag = "spikes"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(619, 470)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(151, 40)
        Me.PictureBox7.TabIndex = 255
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "walls"
        '
        'PictureBox40
        '
        Me.PictureBox40.BackgroundImage = CType(resources.GetObject("PictureBox40.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox40.Location = New System.Drawing.Point(726, 510)
        Me.PictureBox40.Name = "PictureBox40"
        Me.PictureBox40.Size = New System.Drawing.Size(44, 70)
        Me.PictureBox40.TabIndex = 257
        Me.PictureBox40.TabStop = False
        Me.PictureBox40.Tag = "walls"
        '
        'PictureBox38
        '
        Me.PictureBox38.BackgroundImage = CType(resources.GetObject("PictureBox38.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox38.Location = New System.Drawing.Point(552, 368)
        Me.PictureBox38.Name = "PictureBox38"
        Me.PictureBox38.Size = New System.Drawing.Size(79, 55)
        Me.PictureBox38.TabIndex = 259
        Me.PictureBox38.TabStop = False
        Me.PictureBox38.Tag = "walls"
        '
        'PictureBox41
        '
        Me.PictureBox41.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox41.BackgroundImage = Global.MarioBros.My.Resources.Resources.multispike
        Me.PictureBox41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox41.Location = New System.Drawing.Point(404, 278)
        Me.PictureBox41.Name = "PictureBox41"
        Me.PictureBox41.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox41.TabIndex = 261
        Me.PictureBox41.TabStop = False
        Me.PictureBox41.Tag = "spikes"
        '
        'PictureBox42
        '
        Me.PictureBox42.BackgroundImage = CType(resources.GetObject("PictureBox42.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox42.Location = New System.Drawing.Point(146, 211)
        Me.PictureBox42.Name = "PictureBox42"
        Me.PictureBox42.Size = New System.Drawing.Size(44, 100)
        Me.PictureBox42.TabIndex = 262
        Me.PictureBox42.TabStop = False
        Me.PictureBox42.Tag = "walls"
        '
        'PictureBox43
        '
        Me.PictureBox43.BackgroundImage = CType(resources.GetObject("PictureBox43.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox43.Location = New System.Drawing.Point(146, 307)
        Me.PictureBox43.Name = "PictureBox43"
        Me.PictureBox43.Size = New System.Drawing.Size(122, 40)
        Me.PictureBox43.TabIndex = 263
        Me.PictureBox43.TabStop = False
        Me.PictureBox43.Tag = "walls"
        '
        'PictureBox56
        '
        Me.PictureBox56.BackgroundImage = CType(resources.GetObject("PictureBox56.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox56.Location = New System.Drawing.Point(974, 287)
        Me.PictureBox56.Name = "PictureBox56"
        Me.PictureBox56.Size = New System.Drawing.Size(107, 24)
        Me.PictureBox56.TabIndex = 277
        Me.PictureBox56.TabStop = False
        Me.PictureBox56.Tag = "walls"
        '
        'PictureBox57
        '
        Me.PictureBox57.BackgroundImage = CType(resources.GetObject("PictureBox57.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox57.Location = New System.Drawing.Point(868, 287)
        Me.PictureBox57.Name = "PictureBox57"
        Me.PictureBox57.Size = New System.Drawing.Size(107, 24)
        Me.PictureBox57.TabIndex = 278
        Me.PictureBox57.TabStop = False
        Me.PictureBox57.Tag = "walls"
        '
        'PictureBox67
        '
        Me.PictureBox67.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox67.BackgroundImage = CType(resources.GetObject("PictureBox67.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox67.Location = New System.Drawing.Point(962, 259)
        Me.PictureBox67.Name = "PictureBox67"
        Me.PictureBox67.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox67.TabIndex = 280
        Me.PictureBox67.TabStop = False
        Me.PictureBox67.Tag = "spike"
        '
        'PictureBox68
        '
        Me.PictureBox68.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox68.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox68.Location = New System.Drawing.Point(973, 265)
        Me.PictureBox68.Name = "PictureBox68"
        Me.PictureBox68.Size = New System.Drawing.Size(10, 23)
        Me.PictureBox68.TabIndex = 279
        Me.PictureBox68.TabStop = False
        Me.PictureBox68.Tag = "spikes"
        '
        'PictureBox58
        '
        Me.PictureBox58.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox58.BackgroundImage = Global.MarioBros.My.Resources.Resources.todownspike
        Me.PictureBox58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox58.Location = New System.Drawing.Point(958, 49)
        Me.PictureBox58.Name = "PictureBox58"
        Me.PictureBox58.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox58.TabIndex = 281
        Me.PictureBox58.TabStop = False
        Me.PictureBox58.Tag = "spikes"
        '
        'PictureBox59
        '
        Me.PictureBox59.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox59.BackgroundImage = Global.MarioBros.My.Resources.Resources.todownspike
        Me.PictureBox59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox59.Location = New System.Drawing.Point(1000, 49)
        Me.PictureBox59.Name = "PictureBox59"
        Me.PictureBox59.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox59.TabIndex = 282
        Me.PictureBox59.TabStop = False
        Me.PictureBox59.Tag = "spikes"
        '
        'PictureBox60
        '
        Me.PictureBox60.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox60.BackgroundImage = Global.MarioBros.My.Resources.Resources.todownspike
        Me.PictureBox60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox60.Location = New System.Drawing.Point(916, 49)
        Me.PictureBox60.Name = "PictureBox60"
        Me.PictureBox60.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox60.TabIndex = 283
        Me.PictureBox60.TabStop = False
        Me.PictureBox60.Tag = "spikes"
        '
        'PictureBox61
        '
        Me.PictureBox61.BackgroundImage = CType(resources.GetObject("PictureBox61.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox61.Location = New System.Drawing.Point(726, 253)
        Me.PictureBox61.Name = "PictureBox61"
        Me.PictureBox61.Size = New System.Drawing.Size(65, 58)
        Me.PictureBox61.TabIndex = 284
        Me.PictureBox61.TabStop = False
        Me.PictureBox61.Tag = "walls"
        '
        'PictureBox62
        '
        Me.PictureBox62.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox62.BackgroundImage = CType(resources.GetObject("PictureBox62.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox62.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox62.Location = New System.Drawing.Point(726, 225)
        Me.PictureBox62.Name = "PictureBox62"
        Me.PictureBox62.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox62.TabIndex = 286
        Me.PictureBox62.TabStop = False
        Me.PictureBox62.Tag = "spike"
        '
        'PictureBox63
        '
        Me.PictureBox63.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox63.Location = New System.Drawing.Point(737, 231)
        Me.PictureBox63.Name = "PictureBox63"
        Me.PictureBox63.Size = New System.Drawing.Size(10, 23)
        Me.PictureBox63.TabIndex = 285
        Me.PictureBox63.TabStop = False
        Me.PictureBox63.Tag = "spikes"
        '
        'PictureBox64
        '
        Me.PictureBox64.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox64.BackgroundImage = CType(resources.GetObject("PictureBox64.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox64.Location = New System.Drawing.Point(759, 225)
        Me.PictureBox64.Name = "PictureBox64"
        Me.PictureBox64.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox64.TabIndex = 288
        Me.PictureBox64.TabStop = False
        Me.PictureBox64.Tag = "spike"
        '
        'PictureBox65
        '
        Me.PictureBox65.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox65.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox65.Location = New System.Drawing.Point(770, 231)
        Me.PictureBox65.Name = "PictureBox65"
        Me.PictureBox65.Size = New System.Drawing.Size(10, 23)
        Me.PictureBox65.TabIndex = 287
        Me.PictureBox65.TabStop = False
        Me.PictureBox65.Tag = "spikes"
        '
        'PictureBox66
        '
        Me.PictureBox66.BackgroundImage = CType(resources.GetObject("PictureBox66.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox66.Location = New System.Drawing.Point(789, 287)
        Me.PictureBox66.Name = "PictureBox66"
        Me.PictureBox66.Size = New System.Drawing.Size(81, 24)
        Me.PictureBox66.TabIndex = 289
        Me.PictureBox66.TabStop = False
        Me.PictureBox66.Tag = "walls"
        '
        'PictureBox69
        '
        Me.PictureBox69.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox69.BackgroundImage = CType(resources.GetObject("PictureBox69.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox69.InitialImage = CType(resources.GetObject("PictureBox69.InitialImage"), System.Drawing.Image)
        Me.PictureBox69.Location = New System.Drawing.Point(287, 549)
        Me.PictureBox69.Name = "PictureBox69"
        Me.PictureBox69.Size = New System.Drawing.Size(228, 33)
        Me.PictureBox69.TabIndex = 291
        Me.PictureBox69.TabStop = False
        Me.PictureBox69.Tag = "spikes"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(767, 549)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(446, 33)
        Me.PictureBox3.TabIndex = 292
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "spikes"
        '
        'PictureBox33
        '
        Me.PictureBox33.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox33.Location = New System.Drawing.Point(297, 549)
        Me.PictureBox33.Name = "PictureBox33"
        Me.PictureBox33.Size = New System.Drawing.Size(209, 31)
        Me.PictureBox33.TabIndex = 293
        Me.PictureBox33.TabStop = False
        Me.PictureBox33.Tag = "spikes"
        '
        'PictureBox34
        '
        Me.PictureBox34.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox34.Location = New System.Drawing.Point(785, 549)
        Me.PictureBox34.Name = "PictureBox34"
        Me.PictureBox34.Size = New System.Drawing.Size(405, 31)
        Me.PictureBox34.TabIndex = 294
        Me.PictureBox34.TabStop = False
        Me.PictureBox34.Tag = "spikes"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.MarioBros.My.Resources.Resources.b4
        Me.PictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 580)
        Me.PictureBox2.TabIndex = 295
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "walls"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.MarioBros.My.Resources.Resources.b4
        Me.PictureBox4.Location = New System.Drawing.Point(1203, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 580)
        Me.PictureBox4.TabIndex = 296
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "walls"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.MarioBros.My.Resources.Resources.b6
        Me.PictureBox5.Location = New System.Drawing.Point(63, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1150, 67)
        Me.PictureBox5.TabIndex = 297
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "walls"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(190, 278)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox6.TabIndex = 299
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "spike"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(201, 284)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 23)
        Me.PictureBox8.TabIndex = 298
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "spikes"
        '
        'BasicEnemy14
        '
        Me.BasicEnemy14.BackColor = System.Drawing.Color.Transparent
        Me.BasicEnemy14.BackgroundImage = Global.MarioBros.My.Resources.Resources.b1
        Me.BasicEnemy14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BasicEnemy14.Location = New System.Drawing.Point(1159, 318)
        Me.BasicEnemy14.MaxA = 300
        Me.BasicEnemy14.MaxB = 480
        Me.BasicEnemy14.MovingDirection = "vertical"
        Me.BasicEnemy14.Name = "BasicEnemy14"
        Me.BasicEnemy14.ReachedLimit = False
        Me.BasicEnemy14.Size = New System.Drawing.Size(31, 31)
        Me.BasicEnemy14.TabIndex = 290
        Me.BasicEnemy14.TabStop = False
        Me.BasicEnemy14.Tag = "walls"
        Me.BasicEnemy14.TouchedPoint = Nothing
        '
        'BasicEnemy13
        '
        Me.BasicEnemy13.BackColor = System.Drawing.Color.Transparent
        Me.BasicEnemy13.BackgroundImage = Global.MarioBros.My.Resources.Resources.b1
        Me.BasicEnemy13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BasicEnemy13.Location = New System.Drawing.Point(951, 433)
        Me.BasicEnemy13.MaxA = 851
        Me.BasicEnemy13.MaxB = 1000
        Me.BasicEnemy13.MovingDirection = "horizontal"
        Me.BasicEnemy13.Name = "BasicEnemy13"
        Me.BasicEnemy13.ReachedLimit = False
        Me.BasicEnemy13.Size = New System.Drawing.Size(31, 31)
        Me.BasicEnemy13.TabIndex = 266
        Me.BasicEnemy13.TabStop = False
        Me.BasicEnemy13.Tag = "walls"
        Me.BasicEnemy13.TouchedPoint = Nothing
        '
        'BasicEnemy12
        '
        Me.BasicEnemy12.BackColor = System.Drawing.Color.Transparent
        Me.BasicEnemy12.BackgroundImage = Global.MarioBros.My.Resources.Resources.b1
        Me.BasicEnemy12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BasicEnemy12.Location = New System.Drawing.Point(963, 228)
        Me.BasicEnemy12.MaxA = 128
        Me.BasicEnemy12.MaxB = 260
        Me.BasicEnemy12.MovingDirection = "vertical"
        Me.BasicEnemy12.Name = "BasicEnemy12"
        Me.BasicEnemy12.ReachedLimit = False
        Me.BasicEnemy12.Size = New System.Drawing.Size(31, 31)
        Me.BasicEnemy12.TabIndex = 265
        Me.BasicEnemy12.TabStop = False
        Me.BasicEnemy12.Tag = "walls"
        Me.BasicEnemy12.TouchedPoint = Nothing
        '
        'BasicEnemy11
        '
        Me.BasicEnemy11.BackColor = System.Drawing.Color.Transparent
        Me.BasicEnemy11.BackgroundImage = Global.MarioBros.My.Resources.Resources.b1
        Me.BasicEnemy11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BasicEnemy11.Location = New System.Drawing.Point(394, 309)
        Me.BasicEnemy11.MaxA = 301
        Me.BasicEnemy11.MaxB = 501
        Me.BasicEnemy11.MovingDirection = "horizontal"
        Me.BasicEnemy11.Name = "BasicEnemy11"
        Me.BasicEnemy11.ReachedLimit = False
        Me.BasicEnemy11.Size = New System.Drawing.Size(76, 40)
        Me.BasicEnemy11.TabIndex = 260
        Me.BasicEnemy11.TabStop = False
        Me.BasicEnemy11.Tag = "walls"
        Me.BasicEnemy11.TouchedPoint = Nothing
        '
        'timeCount
        '
        Me.timeCount.AutoSize = True
        Me.timeCount.BackColor = System.Drawing.Color.Transparent
        Me.timeCount.Font = New System.Drawing.Font("Roboto Mono", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeCount.Location = New System.Drawing.Point(1064, 78)
        Me.timeCount.Name = "timeCount"
        Me.timeCount.Size = New System.Drawing.Size(133, 43)
        Me.timeCount.TabIndex = 303
        Me.timeCount.Text = "Label2"
        Me.timeCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pausebtn
        '
        Me.pausebtn.BackColor = System.Drawing.Color.Transparent
        Me.pausebtn.BackgroundImage = Global.MarioBros.My.Resources.Resources.saveicon
        Me.pausebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pausebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pausebtn.Location = New System.Drawing.Point(89, 78)
        Me.pausebtn.Name = "pausebtn"
        Me.pausebtn.Size = New System.Drawing.Size(51, 49)
        Me.pausebtn.TabIndex = 302
        Me.pausebtn.TabStop = False
        Me.pausebtn.Tag = ""
        '
        'deathCount
        '
        Me.deathCount.AutoSize = True
        Me.deathCount.BackColor = System.Drawing.Color.Transparent
        Me.deathCount.Font = New System.Drawing.Font("Roboto Mono", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deathCount.Location = New System.Drawing.Point(1064, 127)
        Me.deathCount.Name = "deathCount"
        Me.deathCount.Size = New System.Drawing.Size(133, 43)
        Me.deathCount.TabIndex = 301
        Me.deathCount.Text = "Label2"
        Me.deathCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'timeTimer
        '
        Me.timeTimer.Enabled = True
        '
        'Tuto111
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MarioBros.My.Resources.Resources.Blue
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.timeCount)
        Me.Controls.Add(Me.pausebtn)
        Me.Controls.Add(Me.deathCount)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BasicEnemy14)
        Me.Controls.Add(Me.PictureBox66)
        Me.Controls.Add(Me.PictureBox61)
        Me.Controls.Add(Me.PictureBox57)
        Me.Controls.Add(Me.PictureBox56)
        Me.Controls.Add(Me.BasicEnemy13)
        Me.Controls.Add(Me.BasicEnemy12)
        Me.Controls.Add(Me.PictureBox43)
        Me.Controls.Add(Me.PictureBox42)
        Me.Controls.Add(Me.PictureBox41)
        Me.Controls.Add(Me.BasicEnemy11)
        Me.Controls.Add(Me.PictureBox38)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox39)
        Me.Controls.Add(Me.PictureBox53)
        Me.Controls.Add(Me.PictureBox32)
        Me.Controls.Add(Me.star3)
        Me.Controls.Add(Me.star2)
        Me.Controls.Add(Me.star1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.col4)
        Me.Controls.Add(Me.col3)
        Me.Controls.Add(Me.col2)
        Me.Controls.Add(Me.col)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.door)
        Me.Controls.Add(Me.PictureBox36)
        Me.Controls.Add(Me.PictureBox67)
        Me.Controls.Add(Me.PictureBox68)
        Me.Controls.Add(Me.PictureBox64)
        Me.Controls.Add(Me.PictureBox65)
        Me.Controls.Add(Me.PictureBox62)
        Me.Controls.Add(Me.PictureBox63)
        Me.Controls.Add(Me.PictureBox69)
        Me.Controls.Add(Me.PictureBox40)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox33)
        Me.Controls.Add(Me.PictureBox34)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox60)
        Me.Controls.Add(Me.PictureBox59)
        Me.Controls.Add(Me.PictureBox58)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tuto111"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tuto111"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicEnemy14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicEnemy13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicEnemy12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicEnemy11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pausebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer_moveRight As Timer
    Friend WithEvents timer_moveLeft As Timer
    Friend WithEvents timer_jump As Timer
    Friend WithEvents timer_gravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents basicenemy1timer As Timer
    Friend WithEvents basicbullet1timer As Timer
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents col4 As PictureBox
    Friend WithEvents col3 As PictureBox
    Friend WithEvents col2 As PictureBox
    Friend WithEvents col As PictureBox
    Friend WithEvents door As PictureBox
    Friend WithEvents star3 As PictureBox
    Friend WithEvents star2 As PictureBox
    Friend WithEvents star1 As PictureBox
    Friend WithEvents PictureBox36 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents PictureBox53 As PictureBox
    Friend WithEvents PictureBox39 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox40 As PictureBox
    Friend WithEvents PictureBox38 As PictureBox
    Friend WithEvents PictureBox41 As PictureBox
    Friend WithEvents PictureBox42 As PictureBox
    Friend WithEvents PictureBox43 As PictureBox
    Friend WithEvents PictureBox56 As PictureBox
    Friend WithEvents PictureBox57 As PictureBox
    Friend WithEvents PictureBox67 As PictureBox
    Friend WithEvents PictureBox68 As PictureBox
    Friend WithEvents PictureBox58 As PictureBox
    Friend WithEvents PictureBox59 As PictureBox
    Friend WithEvents PictureBox60 As PictureBox
    Friend WithEvents PictureBox61 As PictureBox
    Friend WithEvents PictureBox62 As PictureBox
    Friend WithEvents PictureBox63 As PictureBox
    Friend WithEvents PictureBox64 As PictureBox
    Friend WithEvents PictureBox65 As PictureBox
    Friend WithEvents PictureBox66 As PictureBox
    Friend WithEvents BasicEnemy11 As BasicEnemy1
    Friend WithEvents BasicEnemy12 As BasicEnemy1
    Friend WithEvents BasicEnemy13 As BasicEnemy1
    Friend WithEvents BasicEnemy14 As BasicEnemy1
    Friend WithEvents PictureBox69 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox33 As PictureBox
    Friend WithEvents PictureBox34 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents timeCount As Label
    Friend WithEvents pausebtn As PictureBox
    Friend WithEvents deathCount As Label
    Friend WithEvents timeTimer As Timer
End Class
