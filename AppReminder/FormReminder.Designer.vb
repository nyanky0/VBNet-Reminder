<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReminder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReminder))
        Me.gbreminder = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFrdetail = New System.Windows.Forms.TextBox()
        Me.txtFrtentang = New System.Windows.Forms.Label()
        Me.txtFrkode = New System.Windows.Forms.Label()
        Me.txtFrdivisi = New System.Windows.Forms.Label()
        Me.txtFrtanggal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFrok = New System.Windows.Forms.Button()
        Me.btnFrselesai = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.TextBox()
        Me.gbreminder.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbreminder
        '
        Me.gbreminder.BackColor = System.Drawing.Color.Transparent
        Me.gbreminder.Controls.Add(Me.Label12)
        Me.gbreminder.Controls.Add(Me.Label11)
        Me.gbreminder.Controls.Add(Me.Label10)
        Me.gbreminder.Controls.Add(Me.Label9)
        Me.gbreminder.Controls.Add(Me.Label8)
        Me.gbreminder.Controls.Add(Me.txtFrdetail)
        Me.gbreminder.Controls.Add(Me.txtFrtentang)
        Me.gbreminder.Controls.Add(Me.txtFrkode)
        Me.gbreminder.Controls.Add(Me.txtFrdivisi)
        Me.gbreminder.Controls.Add(Me.txtFrtanggal)
        Me.gbreminder.Controls.Add(Me.Label7)
        Me.gbreminder.Controls.Add(Me.Label5)
        Me.gbreminder.Controls.Add(Me.Label4)
        Me.gbreminder.Controls.Add(Me.Label3)
        Me.gbreminder.Controls.Add(Me.Label2)
        Me.gbreminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbreminder.Location = New System.Drawing.Point(12, 89)
        Me.gbreminder.Name = "gbreminder"
        Me.gbreminder.Size = New System.Drawing.Size(455, 269)
        Me.gbreminder.TabIndex = 1
        Me.gbreminder.TabStop = False
        Me.gbreminder.Text = "REMINDER"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(157, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(157, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(157, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = ":"
        '
        'txtFrdetail
        '
        Me.txtFrdetail.BackColor = System.Drawing.Color.White
        Me.txtFrdetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFrdetail.Location = New System.Drawing.Point(178, 124)
        Me.txtFrdetail.Multiline = True
        Me.txtFrdetail.Name = "txtFrdetail"
        Me.txtFrdetail.ReadOnly = True
        Me.txtFrdetail.Size = New System.Drawing.Size(261, 80)
        Me.txtFrdetail.TabIndex = 13
        '
        'txtFrtentang
        '
        Me.txtFrtentang.AutoSize = True
        Me.txtFrtentang.BackColor = System.Drawing.Color.White
        Me.txtFrtentang.Location = New System.Drawing.Point(175, 93)
        Me.txtFrtentang.Name = "txtFrtentang"
        Me.txtFrtentang.Size = New System.Drawing.Size(0, 17)
        Me.txtFrtentang.TabIndex = 12
        '
        'txtFrkode
        '
        Me.txtFrkode.AutoSize = True
        Me.txtFrkode.BackColor = System.Drawing.Color.White
        Me.txtFrkode.Location = New System.Drawing.Point(175, 60)
        Me.txtFrkode.Name = "txtFrkode"
        Me.txtFrkode.Size = New System.Drawing.Size(0, 17)
        Me.txtFrkode.TabIndex = 11
        '
        'txtFrdivisi
        '
        Me.txtFrdivisi.AutoSize = True
        Me.txtFrdivisi.BackColor = System.Drawing.Color.White
        Me.txtFrdivisi.Location = New System.Drawing.Point(175, 30)
        Me.txtFrdivisi.Name = "txtFrdivisi"
        Me.txtFrdivisi.Size = New System.Drawing.Size(0, 17)
        Me.txtFrdivisi.TabIndex = 10
        '
        'txtFrtanggal
        '
        Me.txtFrtanggal.AutoSize = True
        Me.txtFrtanggal.BackColor = System.Drawing.Color.White
        Me.txtFrtanggal.Location = New System.Drawing.Point(175, 220)
        Me.txtFrtanggal.Name = "txtFrtanggal"
        Me.txtFrtanggal.Size = New System.Drawing.Size(0, 17)
        Me.txtFrtanggal.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "TANGGAL ACARA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "DETAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "JUDUL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "KODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DIVISI"
        '
        'btnFrok
        '
        Me.btnFrok.Location = New System.Drawing.Point(370, 364)
        Me.btnFrok.Name = "btnFrok"
        Me.btnFrok.Size = New System.Drawing.Size(97, 36)
        Me.btnFrok.TabIndex = 5
        Me.btnFrok.Text = "OK"
        Me.btnFrok.UseVisualStyleBackColor = True
        '
        'btnFrselesai
        '
        Me.btnFrselesai.Location = New System.Drawing.Point(267, 364)
        Me.btnFrselesai.Name = "btnFrselesai"
        Me.btnFrselesai.Size = New System.Drawing.Size(97, 36)
        Me.btnFrselesai.TabIndex = 6
        Me.btnFrselesai.Text = "SELESAIKAN"
        Me.btnFrselesai.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.White
        Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.label6.Location = New System.Drawing.Point(141, 58)
        Me.label6.Name = "label6"
        Me.label6.ReadOnly = True
        Me.label6.Size = New System.Drawing.Size(193, 13)
        Me.label6.TabIndex = 7
        Me.label6.Text = "text"
        Me.label6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(97, 21)
        Me.label1.Name = "label1"
        Me.label1.ReadOnly = True
        Me.label1.Size = New System.Drawing.Size(281, 31)
        Me.label1.TabIndex = 8
        Me.label1.Text = "/"
        Me.label1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formreminder
        Me.ClientSize = New System.Drawing.Size(495, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnFrselesai)
        Me.Controls.Add(Me.btnFrok)
        Me.Controls.Add(Me.gbreminder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(495, 423)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(495, 423)
        Me.Name = "FormReminder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REMINDER"
        Me.gbreminder.ResumeLayout(False)
        Me.gbreminder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbreminder As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFrok As System.Windows.Forms.Button
    Friend WithEvents btnFrselesai As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFrtanggal As System.Windows.Forms.Label
    Friend WithEvents txtFrdetail As System.Windows.Forms.TextBox
    Friend WithEvents txtFrtentang As System.Windows.Forms.Label
    Friend WithEvents txtFrkode As System.Windows.Forms.Label
    Friend WithEvents txtFrdivisi As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.TextBox
End Class
