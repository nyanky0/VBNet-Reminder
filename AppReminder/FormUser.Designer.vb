<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.dgvFu = New System.Windows.Forms.DataGridView()
        Me.btnFuinput = New System.Windows.Forms.Button()
        Me.btnFuhapus = New System.Windows.Forms.Button()
        Me.btnFututup = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnPass = New System.Windows.Forms.Button()
        CType(Me.dgvFu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFu
        '
        Me.dgvFu.AllowUserToAddRows = False
        Me.dgvFu.AllowUserToDeleteRows = False
        Me.dgvFu.AllowUserToResizeColumns = False
        Me.dgvFu.AllowUserToResizeRows = False
        Me.dgvFu.BackgroundColor = System.Drawing.Color.White
        Me.dgvFu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFu.Location = New System.Drawing.Point(12, 50)
        Me.dgvFu.MultiSelect = False
        Me.dgvFu.Name = "dgvFu"
        Me.dgvFu.ReadOnly = True
        Me.dgvFu.RowHeadersVisible = False
        Me.dgvFu.Size = New System.Drawing.Size(716, 315)
        Me.dgvFu.TabIndex = 0
        '
        'btnFuinput
        '
        Me.btnFuinput.BackgroundImage = Global.Reminder.My.Resources.Resources.btnusertambah
        Me.btnFuinput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFuinput.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFuinput.Location = New System.Drawing.Point(765, 124)
        Me.btnFuinput.Name = "btnFuinput"
        Me.btnFuinput.Size = New System.Drawing.Size(73, 68)
        Me.btnFuinput.TabIndex = 1
        Me.btnFuinput.Tag = "BUAT USER BARU"
        Me.btnFuinput.UseVisualStyleBackColor = True
        '
        'btnFuhapus
        '
        Me.btnFuhapus.BackgroundImage = Global.Reminder.My.Resources.Resources.btnuserdelete1
        Me.btnFuhapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFuhapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFuhapus.Location = New System.Drawing.Point(765, 198)
        Me.btnFuhapus.Name = "btnFuhapus"
        Me.btnFuhapus.Size = New System.Drawing.Size(73, 68)
        Me.btnFuhapus.TabIndex = 3
        Me.btnFuhapus.Tag = "HAPUS USER"
        Me.btnFuhapus.UseVisualStyleBackColor = True
        '
        'btnFututup
        '
        Me.btnFututup.BackgroundImage = Global.Reminder.My.Resources.Resources.btntutup
        Me.btnFututup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFututup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFututup.Location = New System.Drawing.Point(765, 350)
        Me.btnFututup.Name = "btnFututup"
        Me.btnFututup.Size = New System.Drawing.Size(95, 50)
        Me.btnFututup.TabIndex = 4
        Me.btnFututup.Tag = "TUTUP"
        Me.btnFututup.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(211, 29)
        Me.label1.TabIndex = 5
        Me.label1.Text = "ADMINISTRATOR"
        '
        'btnPass
        '
        Me.btnPass.BackgroundImage = Global.Reminder.My.Resources.Resources.btnuserpassword
        Me.btnPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.Location = New System.Drawing.Point(765, 50)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(73, 68)
        Me.btnPass.TabIndex = 6
        Me.btnPass.Tag = "TAMPILKAN PASSWORD"
        Me.btnPass.Text = "TAMPILKAN PASSWORD"
        Me.btnPass.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnPass.UseVisualStyleBackColor = True
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.formuser
        Me.ClientSize = New System.Drawing.Size(878, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnFututup)
        Me.Controls.Add(Me.btnFuhapus)
        Me.Controls.Add(Me.btnFuinput)
        Me.Controls.Add(Me.dgvFu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(878, 416)
        Me.MinimumSize = New System.Drawing.Size(878, 416)
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "v"
        Me.TopMost = True
        CType(Me.dgvFu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvFu As System.Windows.Forms.DataGridView
    Friend WithEvents btnFuinput As System.Windows.Forms.Button
    Friend WithEvents btnFuhapus As System.Windows.Forms.Button
    Friend WithEvents btnFututup As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents btnPass As System.Windows.Forms.Button
End Class
