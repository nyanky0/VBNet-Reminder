<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDatabase))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFddb = New System.Windows.Forms.TextBox()
        Me.txtFdserver = New System.Windows.Forms.TextBox()
        Me.txtFdpw = New System.Windows.Forms.TextBox()
        Me.txtFduser = New System.Windows.Forms.TextBox()
        Me.btnFdbatal = New System.Windows.Forms.Button()
        Me.btnFdsimpan = New System.Windows.Forms.Button()
        Me.btnFdcek = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkFdpw = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'txtFddb
        '
        Me.txtFddb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFddb.Location = New System.Drawing.Point(179, 53)
        Me.txtFddb.Name = "txtFddb"
        Me.txtFddb.Size = New System.Drawing.Size(219, 27)
        Me.txtFddb.TabIndex = 4
        '
        'txtFdserver
        '
        Me.txtFdserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFdserver.Location = New System.Drawing.Point(179, 99)
        Me.txtFdserver.Name = "txtFdserver"
        Me.txtFdserver.Size = New System.Drawing.Size(219, 27)
        Me.txtFdserver.TabIndex = 5
        '
        'txtFdpw
        '
        Me.txtFdpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFdpw.Location = New System.Drawing.Point(179, 189)
        Me.txtFdpw.Name = "txtFdpw"
        Me.txtFdpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtFdpw.Size = New System.Drawing.Size(219, 27)
        Me.txtFdpw.TabIndex = 7
        '
        'txtFduser
        '
        Me.txtFduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFduser.Location = New System.Drawing.Point(179, 144)
        Me.txtFduser.Name = "txtFduser"
        Me.txtFduser.Size = New System.Drawing.Size(219, 27)
        Me.txtFduser.TabIndex = 6
        '
        'btnFdbatal
        '
        Me.btnFdbatal.BackgroundImage = Global.Reminder.My.Resources.Resources.btnSILANG
        Me.btnFdbatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFdbatal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFdbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFdbatal.Location = New System.Drawing.Point(344, 266)
        Me.btnFdbatal.Name = "btnFdbatal"
        Me.btnFdbatal.Size = New System.Drawing.Size(54, 51)
        Me.btnFdbatal.TabIndex = 8
        Me.btnFdbatal.Tag = "BATAL"
        Me.btnFdbatal.UseVisualStyleBackColor = True
        '
        'btnFdsimpan
        '
        Me.btnFdsimpan.BackgroundImage = Global.Reminder.My.Resources.Resources.btnCHECK
        Me.btnFdsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFdsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFdsimpan.Location = New System.Drawing.Point(274, 266)
        Me.btnFdsimpan.Name = "btnFdsimpan"
        Me.btnFdsimpan.Size = New System.Drawing.Size(54, 51)
        Me.btnFdsimpan.TabIndex = 9
        Me.btnFdsimpan.Tag = "SIMPAN"
        Me.btnFdsimpan.UseVisualStyleBackColor = True
        '
        'btnFdcek
        '
        Me.btnFdcek.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNCEKKONEKSI
        Me.btnFdcek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFdcek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFdcek.Location = New System.Drawing.Point(25, 281)
        Me.btnFdcek.Name = "btnFdcek"
        Me.btnFdcek.Size = New System.Drawing.Size(74, 36)
        Me.btnFdcek.TabIndex = 10
        Me.btnFdcek.Tag = "CEK KONEKSI"
        Me.btnFdcek.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Myriad Pro", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(370, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 22)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'checkFdpw
        '
        Me.checkFdpw.AutoSize = True
        Me.checkFdpw.BackColor = System.Drawing.Color.Transparent
        Me.checkFdpw.Location = New System.Drawing.Point(179, 222)
        Me.checkFdpw.Name = "checkFdpw"
        Me.checkFdpw.Size = New System.Drawing.Size(123, 17)
        Me.checkFdpw.TabIndex = 12
        Me.checkFdpw.Text = "Tampilkan password"
        Me.checkFdpw.UseVisualStyleBackColor = False
        '
        'FormDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.IMG_20211204_WA0022
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btnFdbatal
        Me.ClientSize = New System.Drawing.Size(434, 329)
        Me.Controls.Add(Me.checkFdpw)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFdcek)
        Me.Controls.Add(Me.btnFdsimpan)
        Me.Controls.Add(Me.btnFdbatal)
        Me.Controls.Add(Me.txtFdpw)
        Me.Controls.Add(Me.txtFduser)
        Me.Controls.Add(Me.txtFdserver)
        Me.Controls.Add(Me.txtFddb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 368)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 368)
        Me.Name = "FormDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Database"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFddb As System.Windows.Forms.TextBox
    Friend WithEvents txtFdserver As System.Windows.Forms.TextBox
    Friend WithEvents txtFdpw As System.Windows.Forms.TextBox
    Friend WithEvents txtFduser As System.Windows.Forms.TextBox
    Friend WithEvents btnFdbatal As System.Windows.Forms.Button
    Friend WithEvents btnFdsimpan As System.Windows.Forms.Button
    Friend WithEvents btnFdcek As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents checkFdpw As System.Windows.Forms.CheckBox
End Class
