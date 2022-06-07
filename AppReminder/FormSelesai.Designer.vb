<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelesai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelesai))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFsdivisi = New System.Windows.Forms.TextBox()
        Me.txtFskode = New System.Windows.Forms.TextBox()
        Me.txtFstentang = New System.Windows.Forms.TextBox()
        Me.txtFsdetail = New System.Windows.Forms.TextBox()
        Me.txtFstanggalacara = New System.Windows.Forms.TextBox()
        Me.txtFscatatan = New System.Windows.Forms.TextBox()
        Me.btnFsbatal = New System.Windows.Forms.Button()
        Me.btnFsselesai = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Divisi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Judul"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Detail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Acara"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Catatan Selesai"
        '
        'txtFsdivisi
        '
        Me.txtFsdivisi.BackColor = System.Drawing.Color.White
        Me.txtFsdivisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFsdivisi.Location = New System.Drawing.Point(210, 62)
        Me.txtFsdivisi.Name = "txtFsdivisi"
        Me.txtFsdivisi.ReadOnly = True
        Me.txtFsdivisi.Size = New System.Drawing.Size(218, 23)
        Me.txtFsdivisi.TabIndex = 6
        '
        'txtFskode
        '
        Me.txtFskode.BackColor = System.Drawing.Color.White
        Me.txtFskode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFskode.Location = New System.Drawing.Point(210, 95)
        Me.txtFskode.Name = "txtFskode"
        Me.txtFskode.ReadOnly = True
        Me.txtFskode.Size = New System.Drawing.Size(218, 23)
        Me.txtFskode.TabIndex = 7
        '
        'txtFstentang
        '
        Me.txtFstentang.BackColor = System.Drawing.Color.White
        Me.txtFstentang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFstentang.Location = New System.Drawing.Point(210, 129)
        Me.txtFstentang.Name = "txtFstentang"
        Me.txtFstentang.ReadOnly = True
        Me.txtFstentang.Size = New System.Drawing.Size(218, 23)
        Me.txtFstentang.TabIndex = 8
        '
        'txtFsdetail
        '
        Me.txtFsdetail.BackColor = System.Drawing.Color.White
        Me.txtFsdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFsdetail.Location = New System.Drawing.Point(210, 162)
        Me.txtFsdetail.Multiline = True
        Me.txtFsdetail.Name = "txtFsdetail"
        Me.txtFsdetail.ReadOnly = True
        Me.txtFsdetail.Size = New System.Drawing.Size(361, 64)
        Me.txtFsdetail.TabIndex = 9
        '
        'txtFstanggalacara
        '
        Me.txtFstanggalacara.BackColor = System.Drawing.Color.White
        Me.txtFstanggalacara.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFstanggalacara.Location = New System.Drawing.Point(210, 243)
        Me.txtFstanggalacara.Name = "txtFstanggalacara"
        Me.txtFstanggalacara.ReadOnly = True
        Me.txtFstanggalacara.Size = New System.Drawing.Size(218, 23)
        Me.txtFstanggalacara.TabIndex = 10
        '
        'txtFscatatan
        '
        Me.txtFscatatan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFscatatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFscatatan.Location = New System.Drawing.Point(210, 280)
        Me.txtFscatatan.Multiline = True
        Me.txtFscatatan.Name = "txtFscatatan"
        Me.txtFscatatan.Size = New System.Drawing.Size(361, 84)
        Me.txtFscatatan.TabIndex = 11
        '
        'btnFsbatal
        '
        Me.btnFsbatal.BackgroundImage = Global.Reminder.My.Resources.Resources.btnSILANG
        Me.btnFsbatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFsbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFsbatal.Location = New System.Drawing.Point(521, 370)
        Me.btnFsbatal.Name = "btnFsbatal"
        Me.btnFsbatal.Size = New System.Drawing.Size(50, 48)
        Me.btnFsbatal.TabIndex = 12
        Me.btnFsbatal.Tag = "BATAL"
        Me.btnFsbatal.UseVisualStyleBackColor = True
        '
        'btnFsselesai
        '
        Me.btnFsselesai.BackgroundImage = Global.Reminder.My.Resources.Resources.btnCHECK
        Me.btnFsselesai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFsselesai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFsselesai.Location = New System.Drawing.Point(455, 370)
        Me.btnFsselesai.Name = "btnFsselesai"
        Me.btnFsselesai.Size = New System.Drawing.Size(50, 48)
        Me.btnFsselesai.TabIndex = 13
        Me.btnFsselesai.Tag = "SELESAIKAN"
        Me.btnFsselesai.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("MS PGothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 27)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "SELESAIKAN REMINDER"
        '
        'FormSelesai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formselesai
        Me.ClientSize = New System.Drawing.Size(599, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnFsselesai)
        Me.Controls.Add(Me.btnFsbatal)
        Me.Controls.Add(Me.txtFscatatan)
        Me.Controls.Add(Me.txtFstanggalacara)
        Me.Controls.Add(Me.txtFsdetail)
        Me.Controls.Add(Me.txtFstentang)
        Me.Controls.Add(Me.txtFskode)
        Me.Controls.Add(Me.txtFsdivisi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(599, 430)
        Me.MinimumSize = New System.Drawing.Size(599, 430)
        Me.Name = "FormSelesai"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SELESAIKAN REMINDER"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFsdivisi As System.Windows.Forms.TextBox
    Friend WithEvents txtFskode As System.Windows.Forms.TextBox
    Friend WithEvents txtFstentang As System.Windows.Forms.TextBox
    Friend WithEvents txtFsdetail As System.Windows.Forms.TextBox
    Friend WithEvents txtFstanggalacara As System.Windows.Forms.TextBox
    Friend WithEvents txtFscatatan As System.Windows.Forms.TextBox
    Friend WithEvents btnFsbatal As System.Windows.Forms.Button
    Friend WithEvents btnFsselesai As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
