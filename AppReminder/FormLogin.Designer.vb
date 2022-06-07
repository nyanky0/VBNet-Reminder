<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFluser = New System.Windows.Forms.TextBox()
        Me.txtFlpass = New System.Windows.Forms.TextBox()
        Me.btnFllogin = New System.Windows.Forms.Button()
        Me.btnFlbatal = New System.Windows.Forms.Button()
        Me.cbFlpass = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(58, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(58, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtFluser
        '
        Me.txtFluser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFluser.Location = New System.Drawing.Point(61, 137)
        Me.txtFluser.Name = "txtFluser"
        Me.txtFluser.Size = New System.Drawing.Size(194, 20)
        Me.txtFluser.TabIndex = 2
        '
        'txtFlpass
        '
        Me.txtFlpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFlpass.Location = New System.Drawing.Point(61, 194)
        Me.txtFlpass.Name = "txtFlpass"
        Me.txtFlpass.Size = New System.Drawing.Size(194, 20)
        Me.txtFlpass.TabIndex = 3
        '
        'btnFllogin
        '
        Me.btnFllogin.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNlogin
        Me.btnFllogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFllogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFllogin.Location = New System.Drawing.Point(61, 238)
        Me.btnFllogin.Name = "btnFllogin"
        Me.btnFllogin.Size = New System.Drawing.Size(81, 39)
        Me.btnFllogin.TabIndex = 4
        Me.btnFllogin.Tag = "LOGIN"
        Me.btnFllogin.UseVisualStyleBackColor = True
        '
        'btnFlbatal
        '
        Me.btnFlbatal.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNBATAL
        Me.btnFlbatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFlbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFlbatal.Location = New System.Drawing.Point(174, 238)
        Me.btnFlbatal.Name = "btnFlbatal"
        Me.btnFlbatal.Size = New System.Drawing.Size(81, 39)
        Me.btnFlbatal.TabIndex = 5
        Me.btnFlbatal.Tag = "BATAL"
        Me.btnFlbatal.UseVisualStyleBackColor = True
        '
        'cbFlpass
        '
        Me.cbFlpass.AutoSize = True
        Me.cbFlpass.BackColor = System.Drawing.Color.Transparent
        Me.cbFlpass.Location = New System.Drawing.Point(61, 220)
        Me.cbFlpass.Name = "cbFlpass"
        Me.cbFlpass.Size = New System.Drawing.Size(127, 17)
        Me.cbFlpass.TabIndex = 6
        Me.cbFlpass.Text = "Perlihatkan password"
        Me.cbFlpass.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 37)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LOGIN"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(2, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "DATABASE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Reminder.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(114, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AcceptButton = Me.btnFllogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(314, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbFlpass)
        Me.Controls.Add(Me.btnFlbatal)
        Me.Controls.Add(Me.btnFllogin)
        Me.Controls.Add(Me.txtFlpass)
        Me.Controls.Add(Me.txtFluser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(320, 345)
        Me.MinimumSize = New System.Drawing.Size(320, 345)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFluser As System.Windows.Forms.TextBox
    Friend WithEvents txtFlpass As System.Windows.Forms.TextBox
    Friend WithEvents btnFllogin As System.Windows.Forms.Button
    Friend WithEvents btnFlbatal As System.Windows.Forms.Button
    Friend WithEvents cbFlpass As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
