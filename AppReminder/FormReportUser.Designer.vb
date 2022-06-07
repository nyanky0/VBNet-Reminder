<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkFruhide = New System.Windows.Forms.CheckBox()
        Me.crReminder1 = New Reminder.crReminder()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crUser1 = New Reminder.crUser()
        Me.ra = New Reminder.crUser()
        Me.crUser2 = New Reminder.crUser()
        Me.panelbulantahun = New System.Windows.Forms.Panel()
        Me.cbFrubulan = New System.Windows.Forms.ComboBox()
        Me.nudFruthn = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbFruuser = New System.Windows.Forms.ComboBox()
        Me.btnFrucari = New System.Windows.Forms.Button()
        Me.Parameter = New System.Windows.Forms.GroupBox()
        Me.cbFruurutan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbFrusemua = New System.Windows.Forms.RadioButton()
        Me.cbFrustatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbFruhari = New System.Windows.Forms.RadioButton()
        Me.rbFrubulan = New System.Windows.Forms.RadioButton()
        Me.rbFrutahun = New System.Windows.Forms.RadioButton()
        Me.rbFrubetween = New System.Windows.Forms.RadioButton()
        Me.paneldate = New System.Windows.Forms.Panel()
        Me.lblsmpedgn = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.panelbulantahun.SuspendLayout()
        CType(Me.nudFruthn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelmenu.SuspendLayout()
        Me.Parameter.SuspendLayout()
        Me.paneldate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER : "
        '
        'checkFruhide
        '
        Me.checkFruhide.AutoSize = True
        Me.checkFruhide.Location = New System.Drawing.Point(648, 32)
        Me.checkFruhide.Name = "checkFruhide"
        Me.checkFruhide.Size = New System.Drawing.Size(141, 17)
        Me.checkFruhide.TabIndex = 7
        Me.checkFruhide.Text = "Sembunyikan Parameter"
        Me.checkFruhide.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.crUser1
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1364, 749)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel
        '
        'panelbulantahun
        '
        Me.panelbulantahun.BackgroundImage = Global.Reminder.My.Resources.Resources.formmenuutama
        Me.panelbulantahun.Controls.Add(Me.cbFrubulan)
        Me.panelbulantahun.Controls.Add(Me.nudFruthn)
        Me.panelbulantahun.Controls.Add(Me.Label4)
        Me.panelbulantahun.Controls.Add(Me.Label3)
        Me.panelbulantahun.Location = New System.Drawing.Point(15, 416)
        Me.panelbulantahun.Name = "panelbulantahun"
        Me.panelbulantahun.Size = New System.Drawing.Size(184, 58)
        Me.panelbulantahun.TabIndex = 6
        '
        'cbFrubulan
        '
        Me.cbFrubulan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbFrubulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrubulan.FormattingEnabled = True
        Me.cbFrubulan.Location = New System.Drawing.Point(12, 24)
        Me.cbFrubulan.Name = "cbFrubulan"
        Me.cbFrubulan.Size = New System.Drawing.Size(79, 21)
        Me.cbFrubulan.TabIndex = 10
        '
        'nudFruthn
        '
        Me.nudFruthn.Location = New System.Drawing.Point(100, 24)
        Me.nudFruthn.Name = "nudFruthn"
        Me.nudFruthn.Size = New System.Drawing.Size(66, 20)
        Me.nudFruthn.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(97, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bulan"
        '
        'panelmenu
        '
        Me.panelmenu.BackgroundImage = Global.Reminder.My.Resources.Resources.formdetail
        Me.panelmenu.Controls.Add(Me.Label7)
        Me.panelmenu.Controls.Add(Me.cbFruuser)
        Me.panelmenu.Controls.Add(Me.btnFrucari)
        Me.panelmenu.Controls.Add(Me.Parameter)
        Me.panelmenu.Location = New System.Drawing.Point(0, 91)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(202, 319)
        Me.panelmenu.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Divisi :"
        '
        'cbFruuser
        '
        Me.cbFruuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFruuser.FormattingEnabled = True
        Me.cbFruuser.Items.AddRange(New Object() {"SEMUA", "SELESAI", "BELUM TERLAKSANA"})
        Me.cbFruuser.Location = New System.Drawing.Point(60, 7)
        Me.cbFruuser.Name = "cbFruuser"
        Me.cbFruuser.Size = New System.Drawing.Size(127, 21)
        Me.cbFruuser.TabIndex = 7
        '
        'btnFrucari
        '
        Me.btnFrucari.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNCARI
        Me.btnFrucari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFrucari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFrucari.Location = New System.Drawing.Point(125, 276)
        Me.btnFrucari.Name = "btnFrucari"
        Me.btnFrucari.Size = New System.Drawing.Size(56, 31)
        Me.btnFrucari.TabIndex = 6
        Me.btnFrucari.Tag = "CARI"
        Me.btnFrucari.UseVisualStyleBackColor = True
        '
        'Parameter
        '
        Me.Parameter.BackColor = System.Drawing.Color.Transparent
        Me.Parameter.Controls.Add(Me.cbFruurutan)
        Me.Parameter.Controls.Add(Me.Label5)
        Me.Parameter.Controls.Add(Me.rbFrusemua)
        Me.Parameter.Controls.Add(Me.cbFrustatus)
        Me.Parameter.Controls.Add(Me.Label2)
        Me.Parameter.Controls.Add(Me.rbFruhari)
        Me.Parameter.Controls.Add(Me.rbFrubulan)
        Me.Parameter.Controls.Add(Me.rbFrutahun)
        Me.Parameter.Controls.Add(Me.rbFrubetween)
        Me.Parameter.Location = New System.Drawing.Point(6, 34)
        Me.Parameter.Name = "Parameter"
        Me.Parameter.Size = New System.Drawing.Size(193, 214)
        Me.Parameter.TabIndex = 5
        Me.Parameter.TabStop = False
        Me.Parameter.Text = "Parameter"
        '
        'cbFruurutan
        '
        Me.cbFruurutan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFruurutan.FormattingEnabled = True
        Me.cbFruurutan.Items.AddRange(New Object() {"KODE", "TANGGAL"})
        Me.cbFruurutan.Location = New System.Drawing.Point(60, 170)
        Me.cbFruurutan.Name = "cbFruurutan"
        Me.cbFruurutan.Size = New System.Drawing.Size(121, 21)
        Me.cbFruurutan.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Urutan :"
        '
        'rbFrusemua
        '
        Me.rbFrusemua.AutoSize = True
        Me.rbFrusemua.Location = New System.Drawing.Point(45, 27)
        Me.rbFrusemua.Name = "rbFrusemua"
        Me.rbFrusemua.Size = New System.Drawing.Size(63, 17)
        Me.rbFrusemua.TabIndex = 6
        Me.rbFrusemua.TabStop = True
        Me.rbFrusemua.Text = "SEMUA"
        Me.rbFrusemua.UseVisualStyleBackColor = True
        '
        'cbFrustatus
        '
        Me.cbFrustatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrustatus.FormattingEnabled = True
        Me.cbFrustatus.Items.AddRange(New Object() {"SEMUA", "SELESAI", "BELUM TERLAKSANA"})
        Me.cbFrustatus.Location = New System.Drawing.Point(60, 142)
        Me.cbFrustatus.Name = "cbFrustatus"
        Me.cbFrustatus.Size = New System.Drawing.Size(121, 21)
        Me.cbFrustatus.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status :"
        '
        'rbFruhari
        '
        Me.rbFruhari.AutoSize = True
        Me.rbFruhari.Checked = True
        Me.rbFruhari.Location = New System.Drawing.Point(45, 50)
        Me.rbFruhari.Name = "rbFruhari"
        Me.rbFruhari.Size = New System.Drawing.Size(76, 17)
        Me.rbFruhari.TabIndex = 0
        Me.rbFruhari.TabStop = True
        Me.rbFruhari.Text = "TANGGAL"
        Me.rbFruhari.UseVisualStyleBackColor = True
        '
        'rbFrubulan
        '
        Me.rbFrubulan.AutoSize = True
        Me.rbFrubulan.Location = New System.Drawing.Point(45, 73)
        Me.rbFrubulan.Name = "rbFrubulan"
        Me.rbFrubulan.Size = New System.Drawing.Size(61, 17)
        Me.rbFrubulan.TabIndex = 1
        Me.rbFrubulan.TabStop = True
        Me.rbFrubulan.Text = "BULAN"
        Me.rbFrubulan.UseVisualStyleBackColor = True
        '
        'rbFrutahun
        '
        Me.rbFrutahun.AutoSize = True
        Me.rbFrutahun.Location = New System.Drawing.Point(45, 96)
        Me.rbFrutahun.Name = "rbFrutahun"
        Me.rbFrutahun.Size = New System.Drawing.Size(63, 17)
        Me.rbFrutahun.TabIndex = 2
        Me.rbFrutahun.TabStop = True
        Me.rbFrutahun.Text = "TAHUN"
        Me.rbFrutahun.UseVisualStyleBackColor = True
        '
        'rbFrubetween
        '
        Me.rbFrubetween.AutoSize = True
        Me.rbFrubetween.Location = New System.Drawing.Point(45, 119)
        Me.rbFrubetween.Name = "rbFrubetween"
        Me.rbFrubetween.Size = New System.Drawing.Size(130, 17)
        Me.rbFrubetween.TabIndex = 3
        Me.rbFrubetween.TabStop = True
        Me.rbFrubetween.Text = "2 PILIHAN TANGGAL"
        Me.rbFrubetween.UseVisualStyleBackColor = True
        '
        'paneldate
        '
        Me.paneldate.BackgroundImage = Global.Reminder.My.Resources.Resources.formpencarian
        Me.paneldate.Controls.Add(Me.lblsmpedgn)
        Me.paneldate.Controls.Add(Me.DateTimePicker2)
        Me.paneldate.Controls.Add(Me.DateTimePicker1)
        Me.paneldate.Location = New System.Drawing.Point(3, 431)
        Me.paneldate.Name = "paneldate"
        Me.paneldate.Size = New System.Drawing.Size(202, 118)
        Me.paneldate.TabIndex = 3
        '
        'lblsmpedgn
        '
        Me.lblsmpedgn.AutoSize = True
        Me.lblsmpedgn.BackColor = System.Drawing.Color.Transparent
        Me.lblsmpedgn.Location = New System.Drawing.Point(57, 46)
        Me.lblsmpedgn.Name = "lblsmpedgn"
        Me.lblsmpedgn.Size = New System.Drawing.Size(81, 13)
        Me.lblsmpedgn.TabIndex = 5
        Me.lblsmpedgn.Text = "Sampai dengan"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(12, 75)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'FormReportUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.checkFruhide)
        Me.Controls.Add(Me.panelbulantahun)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.paneldate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReportUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelbulantahun.ResumeLayout(False)
        Me.panelbulantahun.PerformLayout()
        CType(Me.nudFruthn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelmenu.ResumeLayout(False)
        Me.panelmenu.PerformLayout()
        Me.Parameter.ResumeLayout(False)
        Me.Parameter.PerformLayout()
        Me.paneldate.ResumeLayout(False)
        Me.paneldate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crUser1 As Reminder.crUser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents paneldate As System.Windows.Forms.Panel
    Friend WithEvents ra As Reminder.crUser
    Friend WithEvents panelmenu As System.Windows.Forms.Panel
    Friend WithEvents rbFruhari As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrubulan As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrubetween As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrutahun As System.Windows.Forms.RadioButton
    Friend WithEvents Parameter As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFrustatus As System.Windows.Forms.ComboBox
    Friend WithEvents rbFrusemua As System.Windows.Forms.RadioButton
    Friend WithEvents btnFrucari As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblsmpedgn As System.Windows.Forms.Label
    Friend WithEvents panelbulantahun As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudFruthn As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbFrubulan As System.Windows.Forms.ComboBox
    Friend WithEvents checkFruhide As System.Windows.Forms.CheckBox
    Friend WithEvents crReminder1 As Reminder.crReminder
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbFruuser As System.Windows.Forms.ComboBox
    Friend WithEvents cbFruurutan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents crUser2 As Reminder.crUser
End Class
