<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEdit))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.gbFeedit = New System.Windows.Forms.GroupBox()
        Me.txtFetanggalreminder = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFeuser = New System.Windows.Forms.Label()
        Me.cbFeuser = New System.Windows.Forms.ComboBox()
        Me.cbFekode = New System.Windows.Forms.ComboBox()
        Me.txtFetanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtFedetail = New System.Windows.Forms.TextBox()
        Me.txtFetentang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFebatal = New System.Windows.Forms.Button()
        Me.btnFesimpan = New System.Windows.Forms.Button()
        Me.gbFeedit.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'gbFeedit
        '
        Me.gbFeedit.BackColor = System.Drawing.Color.Transparent
        Me.gbFeedit.Controls.Add(Me.txtFetanggalreminder)
        Me.gbFeedit.Controls.Add(Me.Label1)
        Me.gbFeedit.Controls.Add(Me.lblFeuser)
        Me.gbFeedit.Controls.Add(Me.cbFeuser)
        Me.gbFeedit.Controls.Add(Me.cbFekode)
        Me.gbFeedit.Controls.Add(Me.txtFetanggal)
        Me.gbFeedit.Controls.Add(Me.txtFedetail)
        Me.gbFeedit.Controls.Add(Me.txtFetentang)
        Me.gbFeedit.Controls.Add(Me.Label6)
        Me.gbFeedit.Controls.Add(Me.Label4)
        Me.gbFeedit.Controls.Add(Me.Label3)
        Me.gbFeedit.Controls.Add(Me.Label2)
        Me.gbFeedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFeedit.Location = New System.Drawing.Point(19, 28)
        Me.gbFeedit.Name = "gbFeedit"
        Me.gbFeedit.Size = New System.Drawing.Size(714, 381)
        Me.gbFeedit.TabIndex = 1
        Me.gbFeedit.TabStop = False
        Me.gbFeedit.Text = "Edit Reminder"
        '
        'txtFetanggalreminder
        '
        Me.txtFetanggalreminder.CustomFormat = "yyyy-MM-dd"
        Me.txtFetanggalreminder.Location = New System.Drawing.Point(211, 285)
        Me.txtFetanggalreminder.Name = "txtFetanggalreminder"
        Me.txtFetanggalreminder.Size = New System.Drawing.Size(301, 29)
        Me.txtFetanggalreminder.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "TGL REMINDER"
        '
        'lblFeuser
        '
        Me.lblFeuser.AutoSize = True
        Me.lblFeuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeuser.Location = New System.Drawing.Point(46, 66)
        Me.lblFeuser.Name = "lblFeuser"
        Me.lblFeuser.Size = New System.Drawing.Size(58, 20)
        Me.lblFeuser.TabIndex = 21
        Me.lblFeuser.Text = "DIVISI"
        '
        'cbFeuser
        '
        Me.cbFeuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFeuser.Location = New System.Drawing.Point(211, 60)
        Me.cbFeuser.Name = "cbFeuser"
        Me.cbFeuser.Size = New System.Drawing.Size(132, 32)
        Me.cbFeuser.TabIndex = 20
        '
        'cbFekode
        '
        Me.cbFekode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFekode.FormattingEnabled = True
        Me.cbFekode.Location = New System.Drawing.Point(211, 97)
        Me.cbFekode.Name = "cbFekode"
        Me.cbFekode.Size = New System.Drawing.Size(261, 32)
        Me.cbFekode.TabIndex = 18
        '
        'txtFetanggal
        '
        Me.txtFetanggal.CustomFormat = "dddd, dd MMMM yyyy HH:mm"
        Me.txtFetanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFetanggal.Location = New System.Drawing.Point(211, 324)
        Me.txtFetanggal.Name = "txtFetanggal"
        Me.txtFetanggal.Size = New System.Drawing.Size(329, 29)
        Me.txtFetanggal.TabIndex = 14
        '
        'txtFedetail
        '
        Me.txtFedetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFedetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFedetail.Location = New System.Drawing.Point(211, 166)
        Me.txtFedetail.Multiline = True
        Me.txtFedetail.Name = "txtFedetail"
        Me.txtFedetail.Size = New System.Drawing.Size(455, 108)
        Me.txtFedetail.TabIndex = 17
        Me.txtFedetail.Tag = ""
        '
        'txtFetentang
        '
        Me.txtFetentang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFetentang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFetentang.Location = New System.Drawing.Point(211, 131)
        Me.txtFetentang.Name = "txtFetentang"
        Me.txtFetentang.Size = New System.Drawing.Size(455, 26)
        Me.txtFetentang.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "TGL ACARA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DETAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "JUDUL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "KODE"
        '
        'btnFebatal
        '
        Me.btnFebatal.BackgroundImage = Global.Reminder.My.Resources.Resources.btnSILANG
        Me.btnFebatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFebatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFebatal.Location = New System.Drawing.Point(662, 399)
        Me.btnFebatal.Name = "btnFebatal"
        Me.btnFebatal.Size = New System.Drawing.Size(65, 62)
        Me.btnFebatal.TabIndex = 4
        Me.btnFebatal.Tag = "BATAL"
        Me.btnFebatal.UseVisualStyleBackColor = True
        '
        'btnFesimpan
        '
        Me.btnFesimpan.BackgroundImage = Global.Reminder.My.Resources.Resources.btnCHECK
        Me.btnFesimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFesimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFesimpan.Location = New System.Drawing.Point(578, 399)
        Me.btnFesimpan.Name = "btnFesimpan"
        Me.btnFesimpan.Size = New System.Drawing.Size(65, 62)
        Me.btnFesimpan.TabIndex = 5
        Me.btnFesimpan.Tag = "SIMPAN"
        Me.btnFesimpan.UseVisualStyleBackColor = True
        '
        'FormEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formedit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(755, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFesimpan)
        Me.Controls.Add(Me.btnFebatal)
        Me.Controls.Add(Me.gbFeedit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(755, 483)
        Me.MinimumSize = New System.Drawing.Size(755, 483)
        Me.Name = "FormEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Edit"
        Me.gbFeedit.ResumeLayout(False)
        Me.gbFeedit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents gbFeedit As System.Windows.Forms.GroupBox
    Friend WithEvents txtFetanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFedetail As System.Windows.Forms.TextBox
    Friend WithEvents txtFetentang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFebatal As System.Windows.Forms.Button
    Friend WithEvents cbFeuser As System.Windows.Forms.ComboBox
    Friend WithEvents cbFekode As System.Windows.Forms.ComboBox
    Friend WithEvents btnFesimpan As System.Windows.Forms.Button
    Friend WithEvents lblFeuser As System.Windows.Forms.Label
    Friend WithEvents txtFetanggalreminder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
