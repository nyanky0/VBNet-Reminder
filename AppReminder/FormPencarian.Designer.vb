<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPencarian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPencarian))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.paneltentang = New System.Windows.Forms.Panel()
        Me.btnFpstentang = New System.Windows.Forms.Button()
        Me.txtFpstentang = New System.Windows.Forms.TextBox()
        Me.dgvFp = New System.Windows.Forms.DataGridView()
        Me.cbFpstatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelkode = New System.Windows.Forms.Panel()
        Me.btnFpskode = New System.Windows.Forms.Button()
        Me.txtFpskode = New System.Windows.Forms.TextBox()
        Me.Labeldivisi = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFptutup = New System.Windows.Forms.Button()
        Me.labelstatus = New System.Windows.Forms.Label()
        Me.cbFpdivisi = New System.Windows.Forms.ComboBox()
        Me.btnFpreset = New System.Windows.Forms.Button()
        Me.paneltentang.SuspendLayout()
        CType(Me.dgvFp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelkode.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Kolom Pencarian (JUDUL)"
        '
        'paneltentang
        '
        Me.paneltentang.BackColor = System.Drawing.Color.Transparent
        Me.paneltentang.Controls.Add(Me.btnFpstentang)
        Me.paneltentang.Controls.Add(Me.txtFpstentang)
        Me.paneltentang.Controls.Add(Me.Label3)
        Me.paneltentang.Location = New System.Drawing.Point(740, 56)
        Me.paneltentang.Name = "paneltentang"
        Me.paneltentang.Size = New System.Drawing.Size(282, 46)
        Me.paneltentang.TabIndex = 18
        '
        'btnFpstentang
        '
        Me.btnFpstentang.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNCARI
        Me.btnFpstentang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFpstentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFpstentang.Location = New System.Drawing.Point(204, 4)
        Me.btnFpstentang.Name = "btnFpstentang"
        Me.btnFpstentang.Size = New System.Drawing.Size(75, 37)
        Me.btnFpstentang.TabIndex = 15
        Me.btnFpstentang.Tag = "CARI"
        Me.btnFpstentang.UseVisualStyleBackColor = True
        '
        'txtFpstentang
        '
        Me.txtFpstentang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFpstentang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFpstentang.Location = New System.Drawing.Point(3, 20)
        Me.txtFpstentang.Name = "txtFpstentang"
        Me.txtFpstentang.Size = New System.Drawing.Size(195, 21)
        Me.txtFpstentang.TabIndex = 13
        '
        'dgvFp
        '
        Me.dgvFp.AllowUserToAddRows = False
        Me.dgvFp.AllowUserToDeleteRows = False
        Me.dgvFp.AllowUserToResizeColumns = False
        Me.dgvFp.AllowUserToResizeRows = False
        Me.dgvFp.BackgroundColor = System.Drawing.Color.White
        Me.dgvFp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFp.Location = New System.Drawing.Point(12, 108)
        Me.dgvFp.MultiSelect = False
        Me.dgvFp.Name = "dgvFp"
        Me.dgvFp.ReadOnly = True
        Me.dgvFp.RowHeadersVisible = False
        Me.dgvFp.Size = New System.Drawing.Size(1010, 326)
        Me.dgvFp.TabIndex = 20
        '
        'cbFpstatus
        '
        Me.cbFpstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFpstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFpstatus.FormattingEnabled = True
        Me.cbFpstatus.Items.AddRange(New Object() {"SEMUA", "SELESAI", "BELUM TERLAKSANA"})
        Me.cbFpstatus.Location = New System.Drawing.Point(213, 79)
        Me.cbFpstatus.Name = "cbFpstatus"
        Me.cbFpstatus.Size = New System.Drawing.Size(179, 23)
        Me.cbFpstatus.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Kolom Pencarian (KODE)"
        '
        'panelkode
        '
        Me.panelkode.BackColor = System.Drawing.Color.Transparent
        Me.panelkode.Controls.Add(Me.btnFpskode)
        Me.panelkode.Controls.Add(Me.Label1)
        Me.panelkode.Controls.Add(Me.txtFpskode)
        Me.panelkode.Location = New System.Drawing.Point(452, 56)
        Me.panelkode.Name = "panelkode"
        Me.panelkode.Size = New System.Drawing.Size(282, 46)
        Me.panelkode.TabIndex = 22
        '
        'btnFpskode
        '
        Me.btnFpskode.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNCARI
        Me.btnFpskode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFpskode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFpskode.Location = New System.Drawing.Point(204, 4)
        Me.btnFpskode.Name = "btnFpskode"
        Me.btnFpskode.Size = New System.Drawing.Size(75, 36)
        Me.btnFpskode.TabIndex = 15
        Me.btnFpskode.Tag = "CARI"
        Me.btnFpskode.UseVisualStyleBackColor = True
        '
        'txtFpskode
        '
        Me.txtFpskode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFpskode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFpskode.Location = New System.Drawing.Point(3, 19)
        Me.txtFpskode.Name = "txtFpskode"
        Me.txtFpskode.Size = New System.Drawing.Size(195, 21)
        Me.txtFpskode.TabIndex = 13
        '
        'Labeldivisi
        '
        Me.Labeldivisi.AutoSize = True
        Me.Labeldivisi.BackColor = System.Drawing.Color.Transparent
        Me.Labeldivisi.Location = New System.Drawing.Point(9, 59)
        Me.Labeldivisi.Name = "Labeldivisi"
        Me.Labeldivisi.Size = New System.Drawing.Size(38, 13)
        Me.Labeldivisi.TabIndex = 24
        Me.Labeldivisi.Text = "DIVISI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Myriad Pro Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 33)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "PENCARIAN DATA REMINDER"
        '
        'btnFptutup
        '
        Me.btnFptutup.BackgroundImage = Global.Reminder.My.Resources.Resources.btntutup
        Me.btnFptutup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFptutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFptutup.Location = New System.Drawing.Point(935, 444)
        Me.btnFptutup.Name = "btnFptutup"
        Me.btnFptutup.Size = New System.Drawing.Size(87, 46)
        Me.btnFptutup.TabIndex = 26
        Me.btnFptutup.Tag = "TUTUP"
        Me.btnFptutup.UseVisualStyleBackColor = True
        '
        'labelstatus
        '
        Me.labelstatus.AutoSize = True
        Me.labelstatus.BackColor = System.Drawing.Color.Transparent
        Me.labelstatus.Location = New System.Drawing.Point(210, 59)
        Me.labelstatus.Name = "labelstatus"
        Me.labelstatus.Size = New System.Drawing.Size(50, 13)
        Me.labelstatus.TabIndex = 27
        Me.labelstatus.Text = "STATUS"
        '
        'cbFpdivisi
        '
        Me.cbFpdivisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFpdivisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFpdivisi.FormattingEnabled = True
        Me.cbFpdivisi.Items.AddRange(New Object() {"SEMUA", "SELESAI", "BELUM TERLAKSANA"})
        Me.cbFpdivisi.Location = New System.Drawing.Point(12, 79)
        Me.cbFpdivisi.Name = "cbFpdivisi"
        Me.cbFpdivisi.Size = New System.Drawing.Size(179, 23)
        Me.cbFpdivisi.TabIndex = 28
        '
        'btnFpreset
        '
        Me.btnFpreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFpreset.Font = New System.Drawing.Font("Myriad Pro", 10.0!)
        Me.btnFpreset.Location = New System.Drawing.Point(968, 27)
        Me.btnFpreset.Name = "btnFpreset"
        Me.btnFpreset.Size = New System.Drawing.Size(56, 23)
        Me.btnFpreset.TabIndex = 29
        Me.btnFpreset.Text = "RESET"
        Me.btnFpreset.UseVisualStyleBackColor = True
        '
        'FormPencarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formpencarian
        Me.ClientSize = New System.Drawing.Size(1044, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFpreset)
        Me.Controls.Add(Me.cbFpdivisi)
        Me.Controls.Add(Me.labelstatus)
        Me.Controls.Add(Me.btnFptutup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Labeldivisi)
        Me.Controls.Add(Me.panelkode)
        Me.Controls.Add(Me.cbFpstatus)
        Me.Controls.Add(Me.dgvFp)
        Me.Controls.Add(Me.paneltentang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1050, 528)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1050, 528)
        Me.Name = "FormPencarian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian"
        Me.paneltentang.ResumeLayout(False)
        Me.paneltentang.PerformLayout()
        CType(Me.dgvFp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelkode.ResumeLayout(False)
        Me.panelkode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents paneltentang As System.Windows.Forms.Panel
    Friend WithEvents btnFpstentang As System.Windows.Forms.Button
    Friend WithEvents txtFpstentang As System.Windows.Forms.TextBox
    Friend WithEvents dgvFp As System.Windows.Forms.DataGridView
    Friend WithEvents cbFpstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelkode As System.Windows.Forms.Panel
    Friend WithEvents btnFpskode As System.Windows.Forms.Button
    Friend WithEvents txtFpskode As System.Windows.Forms.TextBox
    Friend WithEvents Labeldivisi As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFptutup As System.Windows.Forms.Button
    Friend WithEvents labelstatus As System.Windows.Forms.Label
    Friend WithEvents cbFpdivisi As System.Windows.Forms.ComboBox
    Friend WithEvents btnFpreset As System.Windows.Forms.Button
End Class
