<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportReminder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportReminder))
        Me.checkFrureminder = New System.Windows.Forms.CheckBox()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crReminder1 = New Reminder.crReminder()
        Me.panelreminder = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbFru1status = New System.Windows.Forms.ComboBox()
        Me.btnFrureminder = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbFru1kode = New System.Windows.Forms.ComboBox()
        Me.cbFru1user = New System.Windows.Forms.ComboBox()
        Me.panelreminder.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkFrureminder
        '
        Me.checkFrureminder.AutoSize = True
        Me.checkFrureminder.Location = New System.Drawing.Point(523, 32)
        Me.checkFrureminder.Name = "checkFrureminder"
        Me.checkFrureminder.Size = New System.Drawing.Size(163, 17)
        Me.checkFrureminder.TabIndex = 10
        Me.checkFrureminder.Text = "Sembunyikan Filter Reminder"
        Me.checkFrureminder.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = 0
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ReportSource = Me.crReminder1
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1025, 749)
        Me.CrystalReportViewer2.TabIndex = 0
        '
        'panelreminder
        '
        Me.panelreminder.BackgroundImage = Global.Reminder.My.Resources.Resources.formpencarian
        Me.panelreminder.Controls.Add(Me.Label9)
        Me.panelreminder.Controls.Add(Me.cbFru1status)
        Me.panelreminder.Controls.Add(Me.btnFrureminder)
        Me.panelreminder.Controls.Add(Me.Label8)
        Me.panelreminder.Controls.Add(Me.label6)
        Me.panelreminder.Controls.Add(Me.Label5)
        Me.panelreminder.Controls.Add(Me.ComboBox1)
        Me.panelreminder.Controls.Add(Me.cbFru1kode)
        Me.panelreminder.Controls.Add(Me.cbFru1user)
        Me.panelreminder.Location = New System.Drawing.Point(0, 89)
        Me.panelreminder.Name = "panelreminder"
        Me.panelreminder.Size = New System.Drawing.Size(202, 136)
        Me.panelreminder.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(9, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Kode"
        '
        'cbFru1status
        '
        Me.cbFru1status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFru1status.FormattingEnabled = True
        Me.cbFru1status.Location = New System.Drawing.Point(47, 39)
        Me.cbFru1status.Name = "cbFru1status"
        Me.cbFru1status.Size = New System.Drawing.Size(140, 21)
        Me.cbFru1status.TabIndex = 9
        '
        'btnFrureminder
        '
        Me.btnFrureminder.BackgroundImage = Global.Reminder.My.Resources.Resources.BTNCARI
        Me.btnFrureminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFrureminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFrureminder.Location = New System.Drawing.Point(130, 95)
        Me.btnFrureminder.Name = "btnFrureminder"
        Me.btnFrureminder.Size = New System.Drawing.Size(57, 30)
        Me.btnFrureminder.TabIndex = 8
        Me.btnFrureminder.Tag = "CARI"
        Me.btnFrureminder.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, -80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kode"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Location = New System.Drawing.Point(9, 42)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(37, 13)
        Me.label6.TabIndex = 7
        Me.label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(9, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "User"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(257, -83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'cbFru1kode
        '
        Me.cbFru1kode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFru1kode.FormattingEnabled = True
        Me.cbFru1kode.Location = New System.Drawing.Point(47, 66)
        Me.cbFru1kode.Name = "cbFru1kode"
        Me.cbFru1kode.Size = New System.Drawing.Size(140, 21)
        Me.cbFru1kode.TabIndex = 1
        '
        'cbFru1user
        '
        Me.cbFru1user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFru1user.FormattingEnabled = True
        Me.cbFru1user.Location = New System.Drawing.Point(47, 12)
        Me.cbFru1user.Name = "cbFru1user"
        Me.cbFru1user.Size = New System.Drawing.Size(140, 21)
        Me.cbFru1user.TabIndex = 0
        '
        'FormReportReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 749)
        Me.Controls.Add(Me.checkFrureminder)
        Me.Controls.Add(Me.panelreminder)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReportReminder"
        Me.Text = "REPORT REMINDER"
        Me.panelreminder.ResumeLayout(False)
        Me.panelreminder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents panelreminder As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbFru1status As System.Windows.Forms.ComboBox
    Friend WithEvents btnFrureminder As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbFru1kode As System.Windows.Forms.ComboBox
    Friend WithEvents cbFru1user As System.Windows.Forms.ComboBox
    Friend WithEvents checkFrureminder As System.Windows.Forms.CheckBox
    Friend WithEvents crReminder1 As Reminder.crReminder
End Class
