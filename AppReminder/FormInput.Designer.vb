<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInput))
        Me.gbFiinput = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFitanggalreminder = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbFikode = New System.Windows.Forms.ComboBox()
        Me.txtFitanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtFidetail = New System.Windows.Forms.TextBox()
        Me.txtFitentang = New System.Windows.Forms.TextBox()
        Me.txtFikode = New System.Windows.Forms.TextBox()
        Me.txtFipembuat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFisimpan = New System.Windows.Forms.Button()
        Me.btnFibatal = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbFiinput.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFiinput
        '
        Me.gbFiinput.BackColor = System.Drawing.Color.Transparent
        Me.gbFiinput.Controls.Add(Me.Label7)
        Me.gbFiinput.Controls.Add(Me.txtFitanggalreminder)
        Me.gbFiinput.Controls.Add(Me.Label5)
        Me.gbFiinput.Controls.Add(Me.cbFikode)
        Me.gbFiinput.Controls.Add(Me.txtFitanggal)
        Me.gbFiinput.Controls.Add(Me.txtFidetail)
        Me.gbFiinput.Controls.Add(Me.txtFitentang)
        Me.gbFiinput.Controls.Add(Me.txtFikode)
        Me.gbFiinput.Controls.Add(Me.txtFipembuat)
        Me.gbFiinput.Controls.Add(Me.Label6)
        Me.gbFiinput.Controls.Add(Me.Label4)
        Me.gbFiinput.Controls.Add(Me.Label3)
        Me.gbFiinput.Controls.Add(Me.Label2)
        Me.gbFiinput.Controls.Add(Me.Label1)
        Me.gbFiinput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFiinput.Location = New System.Drawing.Point(35, 29)
        Me.gbFiinput.Name = "gbFiinput"
        Me.gbFiinput.Size = New System.Drawing.Size(668, 374)
        Me.gbFiinput.TabIndex = 0
        Me.gbFiinput.TabStop = False
        Me.gbFiinput.Text = "Masukkan Reminder Baru"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(447, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "DIVISI"
        '
        'txtFitanggalreminder
        '
        Me.txtFitanggalreminder.CustomFormat = "yyyy-MM-dd"
        Me.txtFitanggalreminder.Location = New System.Drawing.Point(185, 265)
        Me.txtFitanggalreminder.Name = "txtFitanggalreminder"
        Me.txtFitanggalreminder.Size = New System.Drawing.Size(284, 29)
        Me.txtFitanggalreminder.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "TGL. REMINDER"
        '
        'cbFikode
        '
        Me.cbFikode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFikode.FormattingEnabled = True
        Me.cbFikode.Location = New System.Drawing.Point(451, 74)
        Me.cbFikode.Name = "cbFikode"
        Me.cbFikode.Size = New System.Drawing.Size(172, 32)
        Me.cbFikode.TabIndex = 10
        '
        'txtFitanggal
        '
        Me.txtFitanggal.CustomFormat = "dddd, dd MMMM yyyy HH:mm"
        Me.txtFitanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFitanggal.Location = New System.Drawing.Point(185, 300)
        Me.txtFitanggal.Name = "txtFitanggal"
        Me.txtFitanggal.Size = New System.Drawing.Size(336, 29)
        Me.txtFitanggal.TabIndex = 4
        '
        'txtFidetail
        '
        Me.txtFidetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFidetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFidetail.Location = New System.Drawing.Point(185, 147)
        Me.txtFidetail.Multiline = True
        Me.txtFidetail.Name = "txtFidetail"
        Me.txtFidetail.Size = New System.Drawing.Size(455, 108)
        Me.txtFidetail.TabIndex = 9
        Me.txtFidetail.Tag = ""
        '
        'txtFitentang
        '
        Me.txtFitentang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFitentang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFitentang.Location = New System.Drawing.Point(185, 112)
        Me.txtFitentang.Name = "txtFitentang"
        Me.txtFitentang.Size = New System.Drawing.Size(455, 26)
        Me.txtFitentang.TabIndex = 8
        '
        'txtFikode
        '
        Me.txtFikode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFikode.Location = New System.Drawing.Point(185, 80)
        Me.txtFikode.Name = "txtFikode"
        Me.txtFikode.ReadOnly = True
        Me.txtFikode.Size = New System.Drawing.Size(235, 26)
        Me.txtFikode.TabIndex = 7
        '
        'txtFipembuat
        '
        Me.txtFipembuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFipembuat.Location = New System.Drawing.Point(185, 45)
        Me.txtFipembuat.Name = "txtFipembuat"
        Me.txtFipembuat.ReadOnly = True
        Me.txtFipembuat.Size = New System.Drawing.Size(185, 26)
        Me.txtFipembuat.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TGL. ACARA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DETAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JUDUL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PEMBUAT"
        '
        'btnFisimpan
        '
        Me.btnFisimpan.BackgroundImage = Global.Reminder.My.Resources.Resources.btnCHECK
        Me.btnFisimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFisimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFisimpan.Location = New System.Drawing.Point(550, 409)
        Me.btnFisimpan.Name = "btnFisimpan"
        Me.btnFisimpan.Size = New System.Drawing.Size(64, 62)
        Me.btnFisimpan.TabIndex = 1
        Me.btnFisimpan.Tag = "SIMPAN"
        Me.btnFisimpan.UseVisualStyleBackColor = True
        '
        'btnFibatal
        '
        Me.btnFibatal.BackgroundImage = Global.Reminder.My.Resources.Resources.btnSILANG
        Me.btnFibatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFibatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFibatal.Location = New System.Drawing.Point(639, 409)
        Me.btnFibatal.Name = "btnFibatal"
        Me.btnFibatal.Size = New System.Drawing.Size(64, 62)
        Me.btnFibatal.TabIndex = 2
        Me.btnFibatal.Tag = "BATAL"
        Me.btnFibatal.UseVisualStyleBackColor = True
        '
        'FormInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formedit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFibatal)
        Me.Controls.Add(Me.btnFisimpan)
        Me.Controls.Add(Me.gbFiinput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(756, 500)
        Me.MinimumSize = New System.Drawing.Size(756, 500)
        Me.Name = "FormInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUT REMINDER BARU"
        Me.gbFiinput.ResumeLayout(False)
        Me.gbFiinput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiinput As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFidetail As System.Windows.Forms.TextBox
    Friend WithEvents txtFitentang As System.Windows.Forms.TextBox
    Friend WithEvents txtFikode As System.Windows.Forms.TextBox
    Friend WithEvents txtFipembuat As System.Windows.Forms.TextBox
    Friend WithEvents btnFisimpan As System.Windows.Forms.Button
    Friend WithEvents btnFibatal As System.Windows.Forms.Button
    Friend WithEvents txtFitanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFikode As System.Windows.Forms.ComboBox
    Friend WithEvents txtFitanggalreminder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
