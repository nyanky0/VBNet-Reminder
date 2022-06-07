<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisiUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilkanUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatUserBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReminderTerhapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFmutgl = New System.Windows.Forms.Label()
        Me.selamatdatang = New System.Windows.Forms.Label()
        Me.btnFmulogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFmusearch = New System.Windows.Forms.Button()
        Me.btnFmuedit = New System.Windows.Forms.Button()
        Me.btnFmuinput = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFmustatus = New System.Windows.Forms.Button()
        Me.dgvFmu = New System.Windows.Forms.DataGridView()
        Me.cbFmudgv = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFmujam = New System.Windows.Forms.Label()
        Me.TimerWaktu = New System.Windows.Forms.Timer(Me.components)
        Me.btnFmurefresh = New System.Windows.Forms.Button()
        Me.Timer1Menit = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtFmuuser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvFmu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MaximumSize = New System.Drawing.Size(1298, 24)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(1298, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1298, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FileToolStripMenuItem.Text = "Menu"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DivisiUserToolStripMenuItem, Me.ReminderTerhapusToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'DivisiUserToolStripMenuItem
        '
        Me.DivisiUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TampilkanUserToolStripMenuItem, Me.BuatUserBaruToolStripMenuItem, Me.HapusUserToolStripMenuItem})
        Me.DivisiUserToolStripMenuItem.Name = "DivisiUserToolStripMenuItem"
        Me.DivisiUserToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DivisiUserToolStripMenuItem.Text = "Divisi / User"
        '
        'TampilkanUserToolStripMenuItem
        '
        Me.TampilkanUserToolStripMenuItem.Name = "TampilkanUserToolStripMenuItem"
        Me.TampilkanUserToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TampilkanUserToolStripMenuItem.Text = "Tampilkan User"
        '
        'BuatUserBaruToolStripMenuItem
        '
        Me.BuatUserBaruToolStripMenuItem.Name = "BuatUserBaruToolStripMenuItem"
        Me.BuatUserBaruToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.BuatUserBaruToolStripMenuItem.Text = "Buat User Baru"
        '
        'HapusUserToolStripMenuItem
        '
        Me.HapusUserToolStripMenuItem.Name = "HapusUserToolStripMenuItem"
        Me.HapusUserToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.HapusUserToolStripMenuItem.Text = "Hapus User"
        '
        'ReminderTerhapusToolStripMenuItem
        '
        Me.ReminderTerhapusToolStripMenuItem.Name = "ReminderTerhapusToolStripMenuItem"
        Me.ReminderTerhapusToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ReminderTerhapusToolStripMenuItem.Text = "Reminder Terhapus"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanUserToolStripMenuItem, Me.LaporanReminderToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanUserToolStripMenuItem
        '
        Me.LaporanUserToolStripMenuItem.Name = "LaporanUserToolStripMenuItem"
        Me.LaporanUserToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LaporanUserToolStripMenuItem.Text = "Laporan Divisi"
        '
        'LaporanReminderToolStripMenuItem
        '
        Me.LaporanReminderToolStripMenuItem.Name = "LaporanReminderToolStripMenuItem"
        Me.LaporanReminderToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LaporanReminderToolStripMenuItem.Text = "Laporan Reminder"
        '
        'txtFmutgl
        '
        Me.txtFmutgl.BackColor = System.Drawing.Color.Transparent
        Me.txtFmutgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFmutgl.Location = New System.Drawing.Point(1160, 21)
        Me.txtFmutgl.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFmutgl.Name = "txtFmutgl"
        Me.txtFmutgl.Size = New System.Drawing.Size(190, 35)
        Me.txtFmutgl.TabIndex = 1
        Me.txtFmutgl.Text = "Minggu, 99 Desember 2022"
        Me.txtFmutgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selamatdatang
        '
        Me.selamatdatang.AutoSize = True
        Me.selamatdatang.BackColor = System.Drawing.Color.Transparent
        Me.selamatdatang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selamatdatang.Location = New System.Drawing.Point(89, 29)
        Me.selamatdatang.Name = "selamatdatang"
        Me.selamatdatang.Size = New System.Drawing.Size(155, 20)
        Me.selamatdatang.TabIndex = 2
        Me.selamatdatang.Text = "SELAMAT DATANG"
        '
        'btnFmulogin
        '
        Me.btnFmulogin.BackColor = System.Drawing.Color.Transparent
        Me.btnFmulogin.BackgroundImage = Global.Reminder.My.Resources.Resources.login
        Me.btnFmulogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFmulogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFmulogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFmulogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnFmulogin.Location = New System.Drawing.Point(1208, 130)
        Me.btnFmulogin.Name = "btnFmulogin"
        Me.btnFmulogin.Size = New System.Drawing.Size(102, 50)
        Me.btnFmulogin.TabIndex = 5
        Me.btnFmulogin.Tag = "LOGIN"
        Me.btnFmulogin.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnFmulogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnFmusearch)
        Me.Panel1.Controls.Add(Me.btnFmuedit)
        Me.Panel1.Controls.Add(Me.btnFmuinput)
        Me.Panel1.Location = New System.Drawing.Point(1198, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 201)
        Me.Panel1.TabIndex = 6
        '
        'btnFmusearch
        '
        Me.btnFmusearch.BackgroundImage = Global.Reminder.My.Resources.Resources.logosearch
        Me.btnFmusearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFmusearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFmusearch.Location = New System.Drawing.Point(32, 129)
        Me.btnFmusearch.Name = "btnFmusearch"
        Me.btnFmusearch.Size = New System.Drawing.Size(57, 57)
        Me.btnFmusearch.TabIndex = 7
        Me.btnFmusearch.Tag = "CARI REMINDER"
        Me.btnFmusearch.UseVisualStyleBackColor = True
        '
        'btnFmuedit
        '
        Me.btnFmuedit.BackgroundImage = Global.Reminder.My.Resources.Resources.logoedit
        Me.btnFmuedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFmuedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFmuedit.Location = New System.Drawing.Point(32, 66)
        Me.btnFmuedit.Name = "btnFmuedit"
        Me.btnFmuedit.Size = New System.Drawing.Size(57, 57)
        Me.btnFmuedit.TabIndex = 4
        Me.btnFmuedit.Tag = "EDIT REMINDER"
        Me.btnFmuedit.UseVisualStyleBackColor = True
        Me.btnFmuedit.Visible = False
        '
        'btnFmuinput
        '
        Me.btnFmuinput.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFmuinput.BackgroundImage = Global.Reminder.My.Resources.Resources.logoplus
        Me.btnFmuinput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFmuinput.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFmuinput.Location = New System.Drawing.Point(32, 3)
        Me.btnFmuinput.Name = "btnFmuinput"
        Me.btnFmuinput.Size = New System.Drawing.Size(57, 57)
        Me.btnFmuinput.TabIndex = 3
        Me.btnFmuinput.Tag = "TAMBAH REMINDER"
        Me.btnFmuinput.UseVisualStyleBackColor = False
        Me.btnFmuinput.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Status"
        '
        'btnFmustatus
        '
        Me.btnFmustatus.BackColor = System.Drawing.Color.White
        Me.btnFmustatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFmustatus.Font = New System.Drawing.Font("Myriad Pro", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFmustatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFmustatus.Location = New System.Drawing.Point(325, 87)
        Me.btnFmustatus.Name = "btnFmustatus"
        Me.btnFmustatus.Size = New System.Drawing.Size(86, 37)
        Me.btnFmustatus.TabIndex = 5
        Me.btnFmustatus.Text = "BELUM TERLAKSANA"
        Me.btnFmustatus.UseVisualStyleBackColor = False
        Me.btnFmustatus.Visible = False
        '
        'dgvFmu
        '
        Me.dgvFmu.AllowUserToAddRows = False
        Me.dgvFmu.AllowUserToDeleteRows = False
        Me.dgvFmu.AllowUserToResizeRows = False
        Me.dgvFmu.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFmu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFmu.Location = New System.Drawing.Point(16, 130)
        Me.dgvFmu.Name = "dgvFmu"
        Me.dgvFmu.ReadOnly = True
        Me.dgvFmu.RowHeadersVisible = False
        Me.dgvFmu.Size = New System.Drawing.Size(1141, 395)
        Me.dgvFmu.TabIndex = 7
        '
        'cbFmudgv
        '
        Me.cbFmudgv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFmudgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFmudgv.FormattingEnabled = True
        Me.cbFmudgv.Location = New System.Drawing.Point(92, 87)
        Me.cbFmudgv.Name = "cbFmudgv"
        Me.cbFmudgv.Size = New System.Drawing.Size(145, 28)
        Me.cbFmudgv.TabIndex = 8
        Me.cbFmudgv.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(416, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Klik 'Detail' untuk informasi lebih lanjut"
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(1301, 473)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(38, 35)
        Me.btnDebug.TabIndex = 12
        Me.btnDebug.Text = "/"
        Me.btnDebug.UseVisualStyleBackColor = True
        Me.btnDebug.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Divisi"
        '
        'txtFmujam
        '
        Me.txtFmujam.BackColor = System.Drawing.Color.Transparent
        Me.txtFmujam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFmujam.Location = New System.Drawing.Point(1209, 47)
        Me.txtFmujam.Name = "txtFmujam"
        Me.txtFmujam.Size = New System.Drawing.Size(101, 20)
        Me.txtFmujam.TabIndex = 16
        Me.txtFmujam.Text = "99.99.99 MM"
        Me.txtFmujam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerWaktu
        '
        Me.TimerWaktu.Interval = 1000
        '
        'btnFmurefresh
        '
        Me.btnFmurefresh.BackgroundImage = Global.Reminder.My.Resources.Resources.btnrefresh
        Me.btnFmurefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFmurefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFmurefresh.Location = New System.Drawing.Point(1230, 130)
        Me.btnFmurefresh.Name = "btnFmurefresh"
        Me.btnFmurefresh.Size = New System.Drawing.Size(57, 57)
        Me.btnFmurefresh.TabIndex = 17
        Me.btnFmurefresh.Tag = "REFRESH DATA"
        Me.btnFmurefresh.UseVisualStyleBackColor = True
        '
        'Timer1Menit
        '
        Me.Timer1Menit.Interval = 60000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Reminder.My.Resources.Resources.KOP_SURAT_4g
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(609, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(550, 110)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtFmuuser
        '
        Me.txtFmuuser.BackColor = System.Drawing.Color.Transparent
        Me.txtFmuuser.Location = New System.Drawing.Point(88, 49)
        Me.txtFmuuser.Name = "txtFmuuser"
        Me.txtFmuuser.Size = New System.Drawing.Size(158, 31)
        Me.txtFmuuser.TabIndex = 19
        Me.txtFmuuser.Text = "WAJIB LOGIN UNTUK MENGGUNAKAN APLIKASI"
        Me.txtFmuuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Reminder.My.Resources.Resources._icon4
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Reminder.My.Resources.Resources.logominus
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(1321, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 23
        Me.Button1.Tag = "Minimize"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formmenuutama1
        Me.ClientSize = New System.Drawing.Size(1347, 551)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtFmuuser)
        Me.Controls.Add(Me.btnFmurefresh)
        Me.Controls.Add(Me.txtFmujam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFmutgl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.btnFmustatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFmudgv)
        Me.Controls.Add(Me.dgvFmu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFmulogin)
        Me.Controls.Add(Me.selamatdatang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1353, 580)
        Me.MinimumSize = New System.Drawing.Size(1353, 580)
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Reminder"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvFmu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFmutgl As System.Windows.Forms.Label
    Friend WithEvents selamatdatang As System.Windows.Forms.Label
    Friend WithEvents btnFmulogin As System.Windows.Forms.Button
    Friend WithEvents btnFmuinput As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvFmu As System.Windows.Forms.DataGridView
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbFmudgv As System.Windows.Forms.ComboBox
    Friend WithEvents btnFmuedit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents btnFmustatus As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFmusearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DivisiUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuatUserBaruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TampilkanUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanReminderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFmujam As System.Windows.Forms.Label
    Friend WithEvents TimerWaktu As System.Windows.Forms.Timer
    Friend WithEvents btnFmurefresh As System.Windows.Forms.Button
    Friend WithEvents Timer1Menit As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ReminderTerhapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtFmuuser As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
