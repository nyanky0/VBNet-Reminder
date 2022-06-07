<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDihapus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDihapus))
        Me.dgvFdh = New System.Windows.Forms.DataGridView()
        Me.btnFdhok = New System.Windows.Forms.Button()
        Me.dtpFdh = New System.Windows.Forms.DateTimePicker()
        Me.btnFdhcari = New System.Windows.Forms.Button()
        Me.btnFdhrefresh = New System.Windows.Forms.Button()
        Me.txtFdhcari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chFdhdetail = New System.Windows.Forms.CheckBox()
        Me.groupboxFdh = New System.Windows.Forms.GroupBox()
        Me.chFdhbtn2 = New System.Windows.Forms.CheckBox()
        Me.chFdhtgl3 = New System.Windows.Forms.CheckBox()
        Me.chFdhbtn1 = New System.Windows.Forms.CheckBox()
        Me.chFdhtgl1 = New System.Windows.Forms.CheckBox()
        Me.chFdhtgl2 = New System.Windows.Forms.CheckBox()
        Me.cbFdhuser = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbFdh = New System.Windows.Forms.ProgressBar()
        Me.Timersearch = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvFdh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxFdh.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFdh
        '
        Me.dgvFdh.AllowUserToAddRows = False
        Me.dgvFdh.AllowUserToDeleteRows = False
        Me.dgvFdh.BackgroundColor = System.Drawing.Color.White
        Me.dgvFdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFdh.Location = New System.Drawing.Point(12, 205)
        Me.dgvFdh.Name = "dgvFdh"
        Me.dgvFdh.RowHeadersVisible = False
        Me.dgvFdh.Size = New System.Drawing.Size(1022, 246)
        Me.dgvFdh.TabIndex = 0
        '
        'btnFdhok
        '
        Me.btnFdhok.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNOK
        Me.btnFdhok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFdhok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFdhok.Location = New System.Drawing.Point(943, 457)
        Me.btnFdhok.Name = "btnFdhok"
        Me.btnFdhok.Size = New System.Drawing.Size(91, 47)
        Me.btnFdhok.TabIndex = 1
        Me.btnFdhok.Tag = "OK"
        Me.btnFdhok.UseVisualStyleBackColor = True
        '
        'dtpFdh
        '
        Me.dtpFdh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFdh.Location = New System.Drawing.Point(161, 76)
        Me.dtpFdh.Name = "dtpFdh"
        Me.dtpFdh.Size = New System.Drawing.Size(238, 27)
        Me.dtpFdh.TabIndex = 2
        '
        'btnFdhcari
        '
        Me.btnFdhcari.BackColor = System.Drawing.Color.Transparent
        Me.btnFdhcari.BackgroundImage = Global.Reminder.My.Resources.Resources.logosearch
        Me.btnFdhcari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFdhcari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFdhcari.Location = New System.Drawing.Point(479, 76)
        Me.btnFdhcari.Name = "btnFdhcari"
        Me.btnFdhcari.Size = New System.Drawing.Size(66, 66)
        Me.btnFdhcari.TabIndex = 3
        Me.btnFdhcari.Tag = "Cari"
        Me.btnFdhcari.UseVisualStyleBackColor = False
        '
        'btnFdhrefresh
        '
        Me.btnFdhrefresh.BackgroundImage = Global.Reminder.My.Resources.Resources.btnrefresh
        Me.btnFdhrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFdhrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFdhrefresh.Location = New System.Drawing.Point(976, 81)
        Me.btnFdhrefresh.Name = "btnFdhrefresh"
        Me.btnFdhrefresh.Size = New System.Drawing.Size(58, 61)
        Me.btnFdhrefresh.TabIndex = 4
        Me.btnFdhrefresh.Tag = "Refresh"
        Me.btnFdhrefresh.UseVisualStyleBackColor = True
        '
        'txtFdhcari
        '
        Me.txtFdhcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFdhcari.Location = New System.Drawing.Point(161, 115)
        Me.txtFdhcari.Name = "txtFdhcari"
        Me.txtFdhcari.Size = New System.Drawing.Size(238, 27)
        Me.txtFdhcari.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tanggal Acara"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Judul Reminder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(645, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DAFTAR REMINDER YANG DIHAPUS"
        '
        'chFdhdetail
        '
        Me.chFdhdetail.AutoSize = True
        Me.chFdhdetail.BackColor = System.Drawing.Color.Transparent
        Me.chFdhdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFdhdetail.Location = New System.Drawing.Point(7, 15)
        Me.chFdhdetail.Name = "chFdhdetail"
        Me.chFdhdetail.Size = New System.Drawing.Size(58, 19)
        Me.chFdhdetail.TabIndex = 9
        Me.chFdhdetail.Text = "Detail"
        Me.chFdhdetail.UseVisualStyleBackColor = False
        '
        'groupboxFdh
        '
        Me.groupboxFdh.BackColor = System.Drawing.Color.Transparent
        Me.groupboxFdh.Controls.Add(Me.chFdhbtn2)
        Me.groupboxFdh.Controls.Add(Me.chFdhtgl3)
        Me.groupboxFdh.Controls.Add(Me.chFdhbtn1)
        Me.groupboxFdh.Controls.Add(Me.chFdhdetail)
        Me.groupboxFdh.Controls.Add(Me.chFdhtgl1)
        Me.groupboxFdh.Controls.Add(Me.chFdhtgl2)
        Me.groupboxFdh.Location = New System.Drawing.Point(14, 159)
        Me.groupboxFdh.Name = "groupboxFdh"
        Me.groupboxFdh.Size = New System.Drawing.Size(685, 40)
        Me.groupboxFdh.TabIndex = 10
        Me.groupboxFdh.TabStop = False
        Me.groupboxFdh.Text = "Tampilkan"
        '
        'chFdhbtn2
        '
        Me.chFdhbtn2.AutoSize = True
        Me.chFdhbtn2.BackColor = System.Drawing.Color.Transparent
        Me.chFdhbtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFdhbtn2.Location = New System.Drawing.Point(537, 15)
        Me.chFdhbtn2.Name = "chFdhbtn2"
        Me.chFdhbtn2.Size = New System.Drawing.Size(137, 19)
        Me.chFdhbtn2.TabIndex = 14
        Me.chFdhbtn2.Text = "Tombol Kembalikan"
        Me.chFdhbtn2.UseVisualStyleBackColor = False
        '
        'chFdhtgl3
        '
        Me.chFdhtgl3.AutoSize = True
        Me.chFdhtgl3.BackColor = System.Drawing.Color.Transparent
        Me.chFdhtgl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFdhtgl3.Location = New System.Drawing.Point(71, 15)
        Me.chFdhtgl3.Name = "chFdhtgl3"
        Me.chFdhtgl3.Size = New System.Drawing.Size(105, 19)
        Me.chFdhtgl3.TabIndex = 10
        Me.chFdhtgl3.Text = "Tanggal Acara"
        Me.chFdhtgl3.UseVisualStyleBackColor = False
        '
        'chFdhbtn1
        '
        Me.chFdhbtn1.AutoSize = True
        Me.chFdhbtn1.BackColor = System.Drawing.Color.Transparent
        Me.chFdhbtn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFdhbtn1.Location = New System.Drawing.Point(424, 15)
        Me.chFdhbtn1.Name = "chFdhbtn1"
        Me.chFdhbtn1.Size = New System.Drawing.Size(107, 19)
        Me.chFdhbtn1.TabIndex = 13
        Me.chFdhbtn1.Text = "Tombol Hapus"
        Me.chFdhbtn1.UseVisualStyleBackColor = False
        '
        'chFdhtgl1
        '
        Me.chFdhtgl1.AutoSize = True
        Me.chFdhtgl1.BackColor = System.Drawing.Color.Transparent
        Me.chFdhtgl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFdhtgl1.Location = New System.Drawing.Point(182, 15)
        Me.chFdhtgl1.Name = "chFdhtgl1"
        Me.chFdhtgl1.Size = New System.Drawing.Size(110, 19)
        Me.chFdhtgl1.TabIndex = 11
        Me.chFdhtgl1.Text = "Tanggal Dibuat"
        Me.chFdhtgl1.UseVisualStyleBackColor = False
        '
        'chFdhtgl2
        '
        Me.chFdhtgl2.AutoSize = True
        Me.chFdhtgl2.BackColor = System.Drawing.Color.Transparent
        Me.chFdhtgl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFdhtgl2.Location = New System.Drawing.Point(298, 15)
        Me.chFdhtgl2.Name = "chFdhtgl2"
        Me.chFdhtgl2.Size = New System.Drawing.Size(120, 19)
        Me.chFdhtgl2.TabIndex = 12
        Me.chFdhtgl2.Text = "Tanggal Dihapus"
        Me.chFdhtgl2.UseVisualStyleBackColor = False
        '
        'cbFdhuser
        '
        Me.cbFdhuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFdhuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFdhuser.FormattingEnabled = True
        Me.cbFdhuser.Location = New System.Drawing.Point(705, 165)
        Me.cbFdhuser.Name = "cbFdhuser"
        Me.cbFdhuser.Size = New System.Drawing.Size(159, 28)
        Me.cbFdhuser.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(701, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "User"
        '
        'pbFdh
        '
        Me.pbFdh.Location = New System.Drawing.Point(405, 81)
        Me.pbFdh.Name = "pbFdh"
        Me.pbFdh.Size = New System.Drawing.Size(68, 12)
        Me.pbFdh.TabIndex = 13
        '
        'Timersearch
        '
        '
        'FormDihapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formpencarian
        Me.ClientSize = New System.Drawing.Size(1046, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbFdh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbFdhuser)
        Me.Controls.Add(Me.groupboxFdh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFdhcari)
        Me.Controls.Add(Me.btnFdhrefresh)
        Me.Controls.Add(Me.btnFdhcari)
        Me.Controls.Add(Me.dtpFdh)
        Me.Controls.Add(Me.btnFdhok)
        Me.Controls.Add(Me.dgvFdh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDihapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REMINDER DIHAPUS"
        CType(Me.dgvFdh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxFdh.ResumeLayout(False)
        Me.groupboxFdh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvFdh As System.Windows.Forms.DataGridView
    Friend WithEvents btnFdhok As System.Windows.Forms.Button
    Friend WithEvents dtpFdh As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFdhcari As System.Windows.Forms.Button
    Friend WithEvents btnFdhrefresh As System.Windows.Forms.Button
    Friend WithEvents txtFdhcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chFdhdetail As System.Windows.Forms.CheckBox
    Friend WithEvents chFdhtgl3 As System.Windows.Forms.CheckBox
    Friend WithEvents chFdhtgl1 As System.Windows.Forms.CheckBox
    Friend WithEvents chFdhtgl2 As System.Windows.Forms.CheckBox
    Friend WithEvents chFdhbtn2 As System.Windows.Forms.CheckBox
    Friend WithEvents chFdhbtn1 As System.Windows.Forms.CheckBox
    Public WithEvents groupboxFdh As System.Windows.Forms.GroupBox
    Friend WithEvents cbFdhuser As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pbFdh As System.Windows.Forms.ProgressBar
    Friend WithEvents Timersearch As System.Windows.Forms.Timer
End Class
