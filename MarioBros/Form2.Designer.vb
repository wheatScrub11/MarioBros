<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioBrayan
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
        Me.personaje_principal = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.celador = New System.Windows.Forms.PictureBox()
        Me.cuadro_texto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.personaje_principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.celador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cuadro_texto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'personaje_principal
        '
        Me.personaje_principal.BackColor = System.Drawing.Color.Transparent
        Me.personaje_principal.Image = Global.MarioBros.My.Resources.Resources.git
        Me.personaje_principal.Location = New System.Drawing.Point(-32, 360)
        Me.personaje_principal.Name = "personaje_principal"
        Me.personaje_principal.Size = New System.Drawing.Size(111, 126)
        Me.personaje_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.personaje_principal.TabIndex = 0
        Me.personaje_principal.TabStop = False
        '
        'Timer1
        '
        '
        'celador
        '
        Me.celador.BackColor = System.Drawing.Color.Transparent
        Me.celador.Image = Global.MarioBros.My.Resources.Resources.Bibi_sin_fondo__1_
        Me.celador.Location = New System.Drawing.Point(605, 51)
        Me.celador.Name = "celador"
        Me.celador.Size = New System.Drawing.Size(363, 478)
        Me.celador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.celador.TabIndex = 1
        Me.celador.TabStop = False
        Me.celador.Visible = False
        '
        'cuadro_texto
        '
        Me.cuadro_texto.BackColor = System.Drawing.Color.Transparent
        Me.cuadro_texto.Image = Global.MarioBros.My.Resources.Resources.empty_speech_bubble_pixel_art_600nw_2199782829_Photoroom_png_Photoroom
        Me.cuadro_texto.Location = New System.Drawing.Point(39, 74)
        Me.cuadro_texto.Name = "cuadro_texto"
        Me.cuadro_texto.Size = New System.Drawing.Size(560, 313)
        Me.cuadro_texto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cuadro_texto.TabIndex = 2
        Me.cuadro_texto.TabStop = False
        Me.cuadro_texto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'FormularioBrayan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MarioBros.My.Resources.Resources.Portería_2__1_
        Me.ClientSize = New System.Drawing.Size(1069, 681)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cuadro_texto)
        Me.Controls.Add(Me.celador)
        Me.Controls.Add(Me.personaje_principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormularioBrayan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarioMakerSiiuu"
        CType(Me.personaje_principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.celador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cuadro_texto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents personaje_principal As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents celador As PictureBox
    Friend WithEvents cuadro_texto As PictureBox
    Friend WithEvents Label1 As Label
End Class
