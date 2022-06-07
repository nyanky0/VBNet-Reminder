<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserHapus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserHapus))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFuhid = New System.Windows.Forms.TextBox()
        Me.checksavedb = New System.Windows.Forms.CheckBox()
        Me.cbFuh = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER ID"
        '
        'txtFuhid
        '
        Me.txtFuhid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFuhid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuhid.Location = New System.Drawing.Point(112, 50)
        Me.txtFuhid.Name = "txtFuhid"
        Me.txtFuhid.ReadOnly = True
        Me.txtFuhid.Size = New System.Drawing.Size(148, 21)
        Me.txtFuhid.TabIndex = 1
        '
        'checksavedb
        '
        Me.checksavedb.AutoSize = True
        Me.checksavedb.BackColor = System.Drawing.Color.Transparent
        Me.checksavedb.Location = New System.Drawing.Point(73, 87)
        Me.checksavedb.Name = "checksavedb"
        Me.checksavedb.Size = New System.Drawing.Size(187, 17)
        Me.checksavedb.TabIndex = 4
        Me.checksavedb.Text = "Biarkan database masih tersimpan"
        Me.checksavedb.UseVisualStyleBackColor = False
        '
        'cbFuh
        '
        Me.cbFuh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFuh.FormattingEnabled = True
        Me.cbFuh.Location = New System.Drawing.Point(112, 12)
        Me.cbFuh.Name = "cbFuh"
        Me.cbFuh.Size = New System.Drawing.Size(148, 25)
        Me.cbFuh.TabIndex = 6
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImage = Global.Reminder.My.Resources.Resources.btnCHECK
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.Location = New System.Drawing.Point(164, 104)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(45, 41)
        Me.btnHapus.TabIndex = 9
        Me.btnHapus.Tag = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImage = Global.Reminder.My.Resources.Resources.btnSILANG
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatal.Location = New System.Drawing.Point(220, 104)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(45, 41)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Tag = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Reminder.My.Resources.Resources.formhaoususer
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-51, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 151)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FormUserHapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(282, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.cbFuh)
        Me.Controls.Add(Me.checksavedb)
        Me.Controls.Add(Me.txtFuhid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(298, 191)
        Me.MinimumSize = New System.Drawing.Size(298, 191)
        Me.Name = "FormUserHapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MENGHAPUS USER"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFuhid As System.Windows.Forms.TextBox
    Friend WithEvents checksavedb As System.Windows.Forms.CheckBox
    Friend WithEvents cbFuh As System.Windows.Forms.ComboBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
