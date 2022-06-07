<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserInput))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbFui = New System.Windows.Forms.GroupBox()
        Me.checkFuipass = New System.Windows.Forms.CheckBox()
        Me.cbFui = New System.Windows.Forms.ComboBox()
        Me.txtFuikode = New System.Windows.Forms.TextBox()
        Me.txtFuiname = New System.Windows.Forms.TextBox()
        Me.txtFuipass = New System.Windows.Forms.TextBox()
        Me.txtFuiid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFuitutup = New System.Windows.Forms.Button()
        Me.btnFuisimpan = New System.Windows.Forms.Button()
        Me.gbFui.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER ID"
        '
        'gbFui
        '
        Me.gbFui.BackColor = System.Drawing.Color.Transparent
        Me.gbFui.Controls.Add(Me.checkFuipass)
        Me.gbFui.Controls.Add(Me.cbFui)
        Me.gbFui.Controls.Add(Me.txtFuikode)
        Me.gbFui.Controls.Add(Me.txtFuiname)
        Me.gbFui.Controls.Add(Me.txtFuipass)
        Me.gbFui.Controls.Add(Me.txtFuiid)
        Me.gbFui.Controls.Add(Me.Label5)
        Me.gbFui.Controls.Add(Me.Label4)
        Me.gbFui.Controls.Add(Me.Label3)
        Me.gbFui.Controls.Add(Me.Label2)
        Me.gbFui.Controls.Add(Me.Label1)
        Me.gbFui.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFui.Location = New System.Drawing.Point(12, 12)
        Me.gbFui.Name = "gbFui"
        Me.gbFui.Size = New System.Drawing.Size(316, 218)
        Me.gbFui.TabIndex = 1
        Me.gbFui.TabStop = False
        Me.gbFui.Text = "INPUT USER"
        '
        'checkFuipass
        '
        Me.checkFuipass.AutoSize = True
        Me.checkFuipass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFuipass.Location = New System.Drawing.Point(134, 86)
        Me.checkFuipass.Name = "checkFuipass"
        Me.checkFuipass.Size = New System.Drawing.Size(140, 19)
        Me.checkFuipass.TabIndex = 8
        Me.checkFuipass.Text = "Tampilkan password"
        Me.checkFuipass.UseVisualStyleBackColor = True
        '
        'cbFui
        '
        Me.cbFui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFui.FormattingEnabled = True
        Me.cbFui.Items.AddRange(New Object() {"admin", "user"})
        Me.cbFui.Location = New System.Drawing.Point(134, 174)
        Me.cbFui.Name = "cbFui"
        Me.cbFui.Size = New System.Drawing.Size(164, 28)
        Me.cbFui.TabIndex = 7
        '
        'txtFuikode
        '
        Me.txtFuikode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFuikode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuikode.Location = New System.Drawing.Point(134, 145)
        Me.txtFuikode.Name = "txtFuikode"
        Me.txtFuikode.Size = New System.Drawing.Size(164, 23)
        Me.txtFuikode.TabIndex = 6
        '
        'txtFuiname
        '
        Me.txtFuiname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFuiname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuiname.Location = New System.Drawing.Point(134, 116)
        Me.txtFuiname.Name = "txtFuiname"
        Me.txtFuiname.Size = New System.Drawing.Size(164, 23)
        Me.txtFuiname.TabIndex = 5
        '
        'txtFuipass
        '
        Me.txtFuipass.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFuipass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuipass.Location = New System.Drawing.Point(134, 60)
        Me.txtFuipass.Name = "txtFuipass"
        Me.txtFuipass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtFuipass.Size = New System.Drawing.Size(164, 23)
        Me.txtFuipass.TabIndex = 4
        '
        'txtFuiid
        '
        Me.txtFuiid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFuiid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuiid.Location = New System.Drawing.Point(134, 31)
        Me.txtFuiid.Name = "txtFuiid"
        Me.txtFuiid.Size = New System.Drawing.Size(164, 23)
        Me.txtFuiid.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "USER STATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "USER KODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USER PASSWORD"
        '
        'btnFuitutup
        '
        Me.btnFuitutup.BackgroundImage = Global.Reminder.My.Resources.Resources.btnSILANG
        Me.btnFuitutup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFuitutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFuitutup.Location = New System.Drawing.Point(276, 236)
        Me.btnFuitutup.Name = "btnFuitutup"
        Me.btnFuitutup.Size = New System.Drawing.Size(52, 48)
        Me.btnFuitutup.TabIndex = 2
        Me.btnFuitutup.Tag = "TUTUP"
        Me.btnFuitutup.UseVisualStyleBackColor = True
        '
        'btnFuisimpan
        '
        Me.btnFuisimpan.BackgroundImage = Global.Reminder.My.Resources.Resources.btnCHECK
        Me.btnFuisimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFuisimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFuisimpan.Location = New System.Drawing.Point(208, 236)
        Me.btnFuisimpan.Name = "btnFuisimpan"
        Me.btnFuisimpan.Size = New System.Drawing.Size(52, 48)
        Me.btnFuisimpan.TabIndex = 3
        Me.btnFuisimpan.Tag = "SIMPAN"
        Me.btnFuisimpan.UseVisualStyleBackColor = True
        '
        'FormUserInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.forminputuser
        Me.ClientSize = New System.Drawing.Size(356, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFuisimpan)
        Me.Controls.Add(Me.btnFuitutup)
        Me.Controls.Add(Me.gbFui)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(356, 308)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(356, 308)
        Me.Name = "FormUserInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DIVISI / USER"
        Me.TopMost = True
        Me.gbFui.ResumeLayout(False)
        Me.gbFui.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbFui As System.Windows.Forms.GroupBox
    Friend WithEvents cbFui As System.Windows.Forms.ComboBox
    Friend WithEvents txtFuikode As System.Windows.Forms.TextBox
    Friend WithEvents txtFuiname As System.Windows.Forms.TextBox
    Friend WithEvents txtFuipass As System.Windows.Forms.TextBox
    Friend WithEvents txtFuiid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFuitutup As System.Windows.Forms.Button
    Friend WithEvents btnFuisimpan As System.Windows.Forms.Button
    Friend WithEvents checkFuipass As System.Windows.Forms.CheckBox
End Class
