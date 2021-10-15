<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.b1 = New System.Windows.Forms.PictureBox()
        Me.coins = New System.Windows.Forms.PictureBox()
        Me.gun = New System.Windows.Forms.PictureBox()
        Me.armor = New System.Windows.Forms.PictureBox()
        Me.Monster = New System.Windows.Forms.PictureBox()
        Me.shell = New System.Windows.Forms.PictureBox()
        Me.Ammo = New System.Windows.Forms.PictureBox()
        Me.Monster2 = New System.Windows.Forms.PictureBox()
        Me.gun1 = New System.Windows.Forms.PictureBox()
        Me.healthbar = New System.Windows.Forms.ProgressBar()
        Me.Monster_health = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.armor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ammo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monster2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gun1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.dirt
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.dirt
        Me.PictureBox2.Location = New System.Drawing.Point(-63, 388)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1846, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Avatar
        '
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.Image = Global.WindowsApp1.My.Resources.Resources.sitama
        Me.Avatar.Location = New System.Drawing.Point(70, 247)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(118, 141)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 10
        Me.Avatar.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.Transparent
        Me.b1.Image = Global.WindowsApp1.My.Resources.Resources.gamebullet
        Me.b1.Location = New System.Drawing.Point(593, 4)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(25, 25)
        Me.b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.b1.TabIndex = 16
        Me.b1.TabStop = False
        Me.b1.Visible = False
        '
        'coins
        '
        Me.coins.BackColor = System.Drawing.Color.Transparent
        Me.coins.Image = Global.WindowsApp1.My.Resources.Resources.boost21
        Me.coins.Location = New System.Drawing.Point(1180, 82)
        Me.coins.Name = "coins"
        Me.coins.Size = New System.Drawing.Size(187, 141)
        Me.coins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coins.TabIndex = 17
        Me.coins.TabStop = False
        Me.coins.Visible = False
        '
        'gun
        '
        Me.gun.BackColor = System.Drawing.Color.Transparent
        Me.gun.Image = Global.WindowsApp1.My.Resources.Resources.gun1
        Me.gun.Location = New System.Drawing.Point(1110, 34)
        Me.gun.Name = "gun"
        Me.gun.Size = New System.Drawing.Size(118, 141)
        Me.gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gun.TabIndex = 11
        Me.gun.TabStop = False
        Me.gun.Visible = False
        '
        'armor
        '
        Me.armor.BackColor = System.Drawing.Color.Transparent
        Me.armor.Image = Global.WindowsApp1.My.Resources.Resources.armour1
        Me.armor.Location = New System.Drawing.Point(1249, 4)
        Me.armor.Name = "armor"
        Me.armor.Size = New System.Drawing.Size(118, 141)
        Me.armor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.armor.TabIndex = 12
        Me.armor.TabStop = False
        Me.armor.Visible = False
        '
        'Monster
        '
        Me.Monster.BackColor = System.Drawing.Color.Transparent
        Me.Monster.Image = Global.WindowsApp1.My.Resources.Resources.monster1
        Me.Monster.Location = New System.Drawing.Point(555, 200)
        Me.Monster.Name = "Monster"
        Me.Monster.Size = New System.Drawing.Size(180, 188)
        Me.Monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Monster.TabIndex = 13
        Me.Monster.TabStop = False
        '
        'shell
        '
        Me.shell.BackColor = System.Drawing.Color.Transparent
        Me.shell.Image = Global.WindowsApp1.My.Resources.Resources.shell
        Me.shell.Location = New System.Drawing.Point(960, 101)
        Me.shell.Name = "shell"
        Me.shell.Size = New System.Drawing.Size(25, 25)
        Me.shell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shell.TabIndex = 18
        Me.shell.TabStop = False
        Me.shell.Visible = False
        '
        'Ammo
        '
        Me.Ammo.BackColor = System.Drawing.Color.Transparent
        Me.Ammo.Image = Global.WindowsApp1.My.Resources.Resources.amo1
        Me.Ammo.Location = New System.Drawing.Point(1067, -11)
        Me.Ammo.Name = "Ammo"
        Me.Ammo.Size = New System.Drawing.Size(50, 50)
        Me.Ammo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ammo.TabIndex = 15
        Me.Ammo.TabStop = False
        Me.Ammo.Visible = False
        '
        'Monster2
        '
        Me.Monster2.BackColor = System.Drawing.Color.Transparent
        Me.Monster2.Image = Global.WindowsApp1.My.Resources.Resources.monster2
        Me.Monster2.Location = New System.Drawing.Point(638, -74)
        Me.Monster2.Name = "Monster2"
        Me.Monster2.Size = New System.Drawing.Size(118, 141)
        Me.Monster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Monster2.TabIndex = 14
        Me.Monster2.TabStop = False
        Me.Monster2.Visible = False
        '
        'gun1
        '
        Me.gun1.BackColor = System.Drawing.Color.Transparent
        Me.gun1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.gun1.Image = Global.WindowsApp1.My.Resources.Resources.gun1
        Me.gun1.Location = New System.Drawing.Point(247, 318)
        Me.gun1.Name = "gun1"
        Me.gun1.Size = New System.Drawing.Size(64, 64)
        Me.gun1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gun1.TabIndex = 20
        Me.gun1.TabStop = False
        '
        'healthbar
        '
        Me.healthbar.Location = New System.Drawing.Point(70, 153)
        Me.healthbar.Name = "healthbar"
        Me.healthbar.Size = New System.Drawing.Size(100, 23)
        Me.healthbar.TabIndex = 26
        Me.healthbar.Value = 100
        '
        'Monster_health
        '
        Me.Monster_health.Location = New System.Drawing.Point(616, 153)
        Me.Monster_health.Name = "Monster_health"
        Me.Monster_health.Size = New System.Drawing.Size(100, 23)
        Me.Monster_health.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(759, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.gamebackground1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(821, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Monster_health)
        Me.Controls.Add(Me.healthbar)
        Me.Controls.Add(Me.gun1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.shell)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Ammo)
        Me.Controls.Add(Me.Monster2)
        Me.Controls.Add(Me.Monster)
        Me.Controls.Add(Me.armor)
        Me.Controls.Add(Me.gun)
        Me.Controls.Add(Me.coins)
        Me.Controls.Add(Me.Avatar)
        Me.Controls.Add(Me.b1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = " "
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.armor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ammo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monster2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gun1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents b1 As PictureBox
    Friend WithEvents coins As PictureBox
    Friend WithEvents gun As PictureBox
    Friend WithEvents armor As PictureBox
    Friend WithEvents Monster As PictureBox
    Friend WithEvents shell As PictureBox
    Friend WithEvents Ammo As PictureBox
    Friend WithEvents Monster2 As PictureBox
    Friend WithEvents gun1 As PictureBox
    Friend WithEvents healthbar As ProgressBar
    Friend WithEvents Monster_health As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
