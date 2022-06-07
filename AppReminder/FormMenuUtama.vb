Imports System.Data.Odbc
Public Class FormMenuUtama
    Public Sub inserttblFmu()
        dgvFmu.ColumnCount = 11
        dgvFmu.Columns(0).Name = "Pembuat"
        dgvFmu.Columns(1).Name = "Divisi"
        dgvFmu.Columns(2).Name = "Kode"
        dgvFmu.Columns(3).Name = "Judul"
        dgvFmu.Columns(4).Name = "Detail"
        dgvFmu.Columns(5).Name = "Tanggal Reminder"
        dgvFmu.Columns(6).Name = "Tanggal Acara"
        dgvFmu.Columns(7).Name = "Tanggal Dibuat"
        dgvFmu.Columns(8).Name = "Status"
        dgvFmu.Columns(9).Name = "Tanggal Selesai"
        dgvFmu.Columns(10).Name = "Catatan Selesai"
    End Sub
    Public Sub updatedgv()
        cbFmudgv.Items.Clear()
        If FormDebug.txtFistatus.Text = "user" Then
            AdminToolStripMenuItem.Visible = False
            Call updatedgvuser()
            Call CheckButtonStatus2()
            Label3.Visible = False
            cbFmudgv.Visible = False
        ElseIf FormDebug.txtFistatus.Text = "admin" Then
            Call updatedgvadmin()
            Label3.Visible = True
            cbFmudgv.Visible = True
            cbFmudgv.Items.Insert(0, "SEMUA")
            cbFmudgv.Text = "SEMUA"
            AdminToolStripMenuItem.Visible = True
            Call CheckButtonStatus2()
        Else
            MsgBox("updatedgv error")
        End If
        Call updatecolor()

        'MsgBox("updatedgv debug")
    End Sub
    Public Sub updatecolor()
        For i = 0 To dgvFmu.RowCount - 1
            If (dgvFmu.Rows(i).Cells("Tanggal Acara").Value <= "" & Now & "") Then
                If dgvFmu.Rows(i).Cells("Status").Value = "SELESAI" Then
                    dgvFmu.Rows(i).DefaultCellStyle.BackColor = Color.White
                    dgvFmu.Rows(i).Cells("Status").Style.BackColor = Color.LightGreen
                Else
                    dgvFmu.Rows(i).DefaultCellStyle.BackColor = Color.LightPink
                End If
            ElseIf dgvFmu.Rows(i).Cells("Status").Value = "SELESAI" Then
                dgvFmu.Rows(i).DefaultCellStyle.BackColor = Color.White
                dgvFmu.Rows(i).Cells("Status").Style.BackColor = Color.LightGreen
            End If
        Next
    End Sub
    Public Sub updatedgvuser()
        cbFmudgv.Visible = False
        cbFmudgv.Items.Add("" & FormInput.txtFipembuat.Text & "")
        cbFmudgv.Text = FormInput.txtFipembuat.Text
        Call dgvtampiluser()

        'MsgBox("updategvuser debug")
        'Call dgvSizeuser()
    End Sub
    Public Sub updatedgvadmin()
        cbFmudgv.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select reminder_untuk from tbl_reminder order by reminder_untuk", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                cbFmudgv.Items.Add(Rd("reminder_untuk"))
            End While
        Catch ex As Exception
        End Try

        Dim ar(cbFmudgv.Items.Count - 1) As Object

        cbFmudgv.Items.CopyTo(ar, 0)
        cbFmudgv.Items.Clear()

        Dim i As Integer
        For i = 0 To UBound(ar)
            If Not cbFmudgv.Items.Contains(ar(i)) Then
                cbFmudgv.Items.Add(ar(i))
            End If
        Next
        Call dgvtampiladmin()

        'debug
        'MsgBox("updatedgvadmin debug")
    End Sub
    Public Sub loadmenu()
        If FormDebug.txtFistatus.Text = "admin" Then
            LaporanUserToolStripMenuItem.Enabled = True
            If txtFmuuser.Text = "ADMINISTRATOR" Then
                If MsgBox("Apakah ingin menampilkan reminder yang ada?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Call reminderout()
                End If
            Else
                Call reminderout()
            End If
        Else
            LaporanUserToolStripMenuItem.Enabled = True
            Call reminderout()
        End If
    End Sub
    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerWaktu.Interval = 1000
        Timer1Menit.Interval = 60000
        Call Terkunci()
        FormLogin.ShowDialog()
        'Call reminderout()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtFmujam.Text = Date.Now.ToString("hh:mm:ss tt")
        txtFmutgl.Text = Format(Now, "dddd, dd MMMM yyyy")
        'TimerReminder.Enabled = Trues
        TimeNow = Format(Now, "yyyy-MM-dd HH:mm")
    End Sub
    Private Sub TimerWaktu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerWaktu.Tick
        Dim time As String
        time = DateTime.Now.ToString("ss")
        If time = "01" Then
            Call remindertick()
            'TimerReminder.Enabled = True
            'TimerReminder.Start()
        End If
    End Sub
    Private Sub remindertick()
        Koneksi()
        If FormDebug.txtFistatus.Text = "admin" Then
            Try
                CMd = New OdbcCommand("Select * From tbl_reminder where reminder_tanggal_acara='" & TimeNow & "'", Conn)
                Rd = CMd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    ReminderOnTime1 = Rd.Item("reminder_kode")
                    FormReminder.gbreminder.Text = "ACARA"
                    FormReminder.label1.Text = "ACARA"
                    'MsgBox(ReminderOnTime1)
                    FormReminder.txtFrkode.Text = ReminderOnTime1
                    FormSelesai.txtFskode.Text = ReminderOnTime1
                    My.Computer.Audio.Play(My.Resources.notif1, AudioPlayMode.Background)
                    If MsgBox("ADA REMINDER, PERIKSA ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        FormReminder.Show()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error Timer Reminder 'admin'")
            End Try
        Else
            Try
                CMd = New OdbcCommand("Select * From tbl_reminder" & txtFmuuser.Text & " where reminder_tanggal_acara='" & TimeNow & "'", Conn)
                Rd = CMd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    ReminderOnTime1 = Rd.Item("reminder_kode")
                    FormReminder.gbreminder.Text = "ACARA"
                    FormReminder.label1.Text = "ACARA"
                    'MsgBox(ReminderOnTime1)
                    FormReminder.txtFrkode.Text = ReminderOnTime1
                    FormSelesai.txtFskode.Text = ReminderOnTime1
                    My.Computer.Audio.Play(My.Resources.notif1, AudioPlayMode.Background)
                    If MsgBox("ADA REMINDER, PERIKSA ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        FormReminder.Show()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error Timer Reminder 'user'")
            End Try
        End If
    End Sub

    Private Sub Timer1Menit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1Menit.Tick
        If FormDebug.txtFistatus.Text = "admin" Then
            Call dgvtampiladmin()
            'MsgBox("refresh timer 1 menit admin")
        Else
            Call dgvtampiluser()
            'MsgBox("refresh timer 1 menit user")
        End If
        Call CheckButtonStatus2()
        Call updatecolor()
        'MsgBox("timer 3")
    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        If LoginToolStripMenuItem.Text = "Login" Then
            FormLogin.txtFluser.Select()
            FormLogin.ShowDialog()
        Else
            Call Terkunci()
            MsgBox("Anda telah logout!")
        End If
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        'splash screen adalah startup
        FormSplashscreen.Close()
        Me.Close()
        Application.Exit()
    End Sub
    
    Private Sub btnFmuinput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmuinput.Click
        FormInput.ShowDialog()
        FormInput.txtFitentang.Focus()
    End Sub
    Private Sub btnFiedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmuedit.Click
        FormEdit.txtFetanggal.Value = Now
        FormEdit.txtFetanggalreminder.Value = Now
        FormEdit.loadfrommenubutton()
        FormEdit.ShowDialog()
    End Sub
    Private Sub btnFmulogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmulogin.Click
        If btnFmulogin.Text = "LOGIN" Then
            FormLogin.ShowDialog()
            FormLogin.txtFluser.Focus()
        Else
            Call Terkunci()
            MsgBox("Anda telah logout!")
            FormLogin.txtFluser.Focus()
        End If
    End Sub
    Public Sub dgvaddbutton()
        'addbutton
        Dim btnedit As New DataGridViewButtonColumn
        dgvFmu.Columns.Add(btnedit)
        btnedit.HeaderText = ""
        btnedit.Text = "Edit"
        btnedit.Name = "btnedit"
        btnedit.UseColumnTextForButtonValue = True
        Dim btndelete As New DataGridViewButtonColumn
        dgvFmu.Columns.Add(btndelete)
        btndelete.HeaderText = ""
        btndelete.Text = "Hapus"
        btndelete.Name = "btndelete"
        btndelete.UseColumnTextForButtonValue = True
        Dim btnselesai As New DataGridViewButtonColumn
        dgvFmu.Columns.Add(btnselesai)
        btnselesai.HeaderText = ""
        btnselesai.Text = "Selesai"
        btnselesai.Name = "btnselesai"
        btnselesai.UseColumnTextForButtonValue = True
        dgvFmu.Columns(11).Width = 40
        dgvFmu.Columns(12).Width = 50
        dgvFmu.Columns(13).Width = 60
    End Sub
    Public Sub dgvsize()
        dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(3).Width = 200
        dgvFmu.Columns(4).Width = 175
        dgvFmu.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFmu.Columns(5).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFmu.Columns(6).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
        dgvFmu.Columns(7).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFmu.Columns(9).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFmu.Columns(0).Visible = False
        dgvFmu.Columns(7).Visible = False
        dgvFmu.Columns(9).Visible = False
        dgvFmu.Columns(10).Visible = False
    End Sub
    Public Sub dgvtampiladmin()
        dgvFmu.Rows.Clear()
        If cbFmudgv.Text = "SEMUA" Then
            Try
                Koneksi()
                Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_status='" & btnFmustatus.Text & "' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara asc", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                Call inserttblFmu()
                For Each row In Dt.Rows
                    dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                Next
                Dt.Rows.Clear()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        Else
            Try
                Koneksi()
                Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFmudgv.Text & " where reminder_status='" & btnFmustatus.Text & "' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara asc", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                Call inserttblFmu()

                For Each row In Dt.Rows
                    dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                Next
                Dt.Rows.Clear()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        Call dgvsize()
        Call dgvaddbutton()
        Call CheckButtonStatus2()
    End Sub
    Public Sub dgvtampiluser()
        dgvFmu.Rows.Clear()
        Try
            Koneksi()
            Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFmudgv.Text & " where reminder_status='" & btnFmustatus.Text & "' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            Call inserttblFmu()
            For Each row In Dt.Rows
                dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Error")
        End Try
        Call dgvsize()
        Call dgvaddbutton()
        Call CheckButtonStatus2()
        'debug
        'MsgBox("dgvtampiluser debug")
    End Sub
    Private Sub cbFmudgv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFmudgv.SelectedIndexChanged
        If cbFmudgv.Text = "SEMUA" Then
            dgvtampiladmin()
            Call CheckButtonStatus2()
        Else
            dgvtampiluser()
            Call CheckButtonStatus2()
        End If
        Call updatecolor()
    End Sub
    Private Sub dgvFmu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFmu.CellClick
        If e.ColumnIndex = 4 Then
            Dim dgvuser As String
            Dim dgvkode As String
            dgvuser = dgvFmu.CurrentRow.Cells(1).Value.ToString
            dgvkode = dgvFmu.CurrentRow.Cells(2).Value.ToString
            FormDebug.txtdgvuserhidden.Text = dgvuser
            FormDebug.txtdgvkodehidden.Text = dgvkode

            FormDebug.txtFmudgvpembuat.Text = dgvFmu.CurrentRow.Cells(0).Value.ToString
            FormDebug.txtFmudgvdivisi.Text = dgvFmu.CurrentRow.Cells(1).Value.ToString
            FormDebug.txtFmudgvkode.Text = dgvFmu.CurrentRow.Cells(2).Value.ToString
            FormDebug.txtFmudgvtentang.Text = dgvFmu.CurrentRow.Cells(3).Value.ToString
            FormDebug.txtFmudgvdetail.Text = dgvFmu.CurrentRow.Cells(4).Value.ToString
            FormDebug.txtFmudgvtglreminder.Text = Format(dgvFmu.CurrentRow.Cells(5).Value, "dddd, dd MMMM yyyy")
            FormDebug.txtFmudgvtglacara.Text = Format(dgvFmu.CurrentRow.Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDebug.txtFmudgvtgldibuat.Text = Format(dgvFmu.CurrentRow.Cells(7).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDebug.txtFmudgvstatus.Text = dgvFmu.CurrentRow.Cells(8).Value.ToString
            FormDebug.txtFmudgvtglselesai.Text = dgvFmu.CurrentRow.Cells(9).Value.ToString
            FormDebug.txtFmudgvselesai.Text = dgvFmu.CurrentRow.Cells(10).Value.ToString

            FormDetail.lblFdpembuat.Text = "PEMBUAT : " & dgvFmu.CurrentRow.Cells(0).Value.ToString & " "
            FormDetail.txtFddivisi.Text = dgvFmu.CurrentRow.Cells(1).Value.ToString
            FormDetail.txtFdkode.Text = dgvFmu.CurrentRow.Cells(2).Value.ToString
            FormDetail.txtFdtentang.Text = dgvFmu.CurrentRow.Cells(3).Value.ToString
            FormDetail.txtFddetail.Text = dgvFmu.CurrentRow.Cells(4).Value.ToString
            FormDetail.txtFdtglreminder.Text = Format(dgvFmu.CurrentRow.Cells(5).Value, "dddd, dd MMMM yyyy")
            FormDetail.txtFdtglacara.Text = Format(dgvFmu.CurrentRow.Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDetail.txtFdtgldibuat.Text = Format(dgvFmu.CurrentRow.Cells(7).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDetail.txtFdstatus.Text = dgvFmu.CurrentRow.Cells(8).Value.ToString
            FormDetail.txtFdtglselesai.Text = dgvFmu.CurrentRow.Cells(9).Value.ToString
            FormDetail.txtFdselesai.Text = dgvFmu.CurrentRow.Cells(10).Value.ToString

            If FormDetail.txtFdstatus.Text = "SELESAI" Then
                FormDebug.txtFmudgvtglselesai.Text = Format(dgvFmu.CurrentRow.Cells(9).Value, "dddd, dd MMMM yyyy HH:mm")
                FormDetail.txtFdtglselesai.Text = Format(dgvFmu.CurrentRow.Cells(9).Value, "dddd, dd MMMM yyyy HH:mm")
            End If
            'MessageBox.Show("" & FormDebug.txtFmudgvdetail.Text & "", "" & FormDebug.txtFmudgvtentang.Text & "")
            'MsgBox(dgvFmu.CurrentRow.Cells(3).Value.ToString)
            'FormDebug.txtFmudgvtentang.Text = ""
            'FormDebug.txtFmudgvdetail.Text = ""
            FormDetail.ShowDialog()
        ElseIf e.ColumnIndex = 11 Then
            'MsgBox("edit")
            FormEdit.cbFekode.Items.Clear()
            FormEdit.cbFeuser.Items.Clear()
            FormEdit.cbFekode.Items.Add("" & dgvFmu.CurrentRow.Cells(2).Value.ToString & "")
            FormEdit.cbFeuser.Items.Add("" & dgvFmu.CurrentRow.Cells(1).Value.ToString & "")
            FormEdit.cbFeuser.SelectedItem = dgvFmu.CurrentRow.Cells(1).Value.ToString
            FormEdit.cbFekode.SelectedItem = dgvFmu.CurrentRow.Cells(2).Value.ToString
            FormEdit.lblFeuser.Visible = True
            FormEdit.cbFeuser.Visible = True
            FormEdit.cbFeuser.Enabled = False
            FormEdit.cbFekode.Enabled = False
            FormEdit.txtFetanggalreminder.Text = Format(dgvFmu.CurrentRow.Cells(5).Value, "dddd, dd MMMM yyyy")
            FormEdit.txtFetanggal.Text = Format(dgvFmu.CurrentRow.Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
            FormEdit.loaddaricbkode()
            FormEdit.ShowDialog()
        ElseIf e.ColumnIndex = 12 Then
            'MsgBox("delete")
            If MsgBox("Anda yakin ingin menghapus data ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Dim hpsuser As String
                Dim hpskode As String
                hpsuser = dgvFmu.CurrentRow.Cells(1).Value.ToString
                hpskode = dgvFmu.CurrentRow.Cells(2).Value.ToString
                Try
                    Call Koneksi()
                    Dim sekarang As String
                    sekarang = Format(Now, "yyyy-MM-dd HH:mm:ss")
                    Dim HapusData1 As String = "Update tbl_reminder" & hpsuser & " set reminder_dihapus='YA', reminder_tanggal_dihapus='" & sekarang & "' where reminder_kode='" & hpskode & "'"
                    CMd = New OdbcCommand(HapusData1, Conn)
                    CMd.ExecuteNonQuery()
                    Conn.Close()
                    Call Koneksi()
                    Dim HapusData2 As String = "Update tbl_reminder set reminder_dihapus='YA', reminder_tanggal_dihapus='" & sekarang & "' where reminder_kode='" & hpskode & "'"
                    CMd = New OdbcCommand(HapusData2, Conn)
                    CMd.ExecuteNonQuery()
                    ' kalau berhasil kita tampilkan alert / message dengan tulisan "hapus data berhasil"
                    MessageBox.Show("Hapus data berhasil", "Hapus Reminder")
                    Call updatedgv()
                Catch ex As Exception
                    MsgBox("Hapus Data Error")
                End Try
            Else
                MessageBox.Show("Membatalkan hapus data", "Hapus Reminder")
            End If

        ElseIf e.ColumnIndex = 13 Then
            FormSelesai.txtFskode.Text = dgvFmu.CurrentRow.Cells(2).Value.ToString
            FormSelesai.ShowDialog()
            FormSelesai.txtFscatatan.Focus()

        End If

    End Sub
    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        FormDebug.ShowDialog()

    End Sub
    Sub dgvselesai()
        dgvFmu.Columns(10).Visible = False
        dgvFmu.Columns(11).Visible = True
        dgvFmu.Columns(12).Visible = True
        dgvFmu.Columns(13).Visible = True
    End Sub
    Sub dgvbelum()
        dgvFmu.Columns(10).Visible = True
        dgvFmu.Columns(11).Visible = False
        dgvFmu.Columns(13).Visible = False
        If FormDebug.txtFistatus.Text = "admin" Then
            dgvFmu.Columns(12).Visible = True
        Else
            dgvFmu.Columns(12).Visible = False
        End If
    End Sub
    Public Sub CheckButtonStatus2()
        If cbFmudgv.Text = "SEMUA" Then
            If btnFmustatus.Text = "BELUM TERLAKSANA" Then
                Call dgvselesai()
            ElseIf btnFmustatus.Text = "SELESAI" Then
                Call dgvbelum()
            End If
        Else
            If btnFmustatus.Text = "BELUM TERLAKSANA" Then
                Call dgvselesai()
            ElseIf btnFmustatus.Text = "SELESAI" Then
                Call dgvbelum()
            End If
        End If
    End Sub
    Public Sub CheckButtonStatus()
        If btnFmustatus.Text = "SELESAI" Then
            btnFmustatus.Text = "BELUM TERLAKSANA"
            If cbFmudgv.Text = "SEMUA" Then
                Call dgvtampiladmin()
            Else
                Call dgvtampiluser()
            End If
            Call dgvselesai()
        ElseIf btnFmustatus.Text = "BELUM TERLAKSANA" Then
            btnFmustatus.Text = "SELESAI"
            If cbFmudgv.Text = "SEMUA" Then
                Call dgvtampiladmin()
            Else
                Call dgvtampiluser()
            End If
            Call dgvbelum()
        End If

    End Sub
    Private Sub btnFmustatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmustatus.Click
        dgvFmu.Rows.Clear()
        If cbFmudgv.Text = "SEMUA" Then
            Call CheckButtonStatus()
            Call dgvtampiladmin()
        Else
            Call CheckButtonStatus()
            Call dgvtampiluser()
        End If
        For i = 0 To dgvFmu.RowCount - 1
            If (dgvFmu.Rows(i).Cells("Tanggal Acara").Value <= "" & Now & "") Then
                If dgvFmu.Rows(i).Cells("Status").Value = "SELESAI" Then
                    dgvFmu.Rows(i).DefaultCellStyle.BackColor = Color.White
                    dgvFmu.Rows(i).Cells("Status").Style.BackColor = Color.LightGreen
                Else
                    dgvFmu.Rows(i).DefaultCellStyle.BackColor = Color.LightPink
                End If
            ElseIf dgvFmu.Rows(i).Cells("Status").Value = "SELESAI" Then
                dgvFmu.Rows(i).DefaultCellStyle.BackColor = Color.White
                dgvFmu.Rows(i).Cells("Status").Style.BackColor = Color.LightGreen
            End If
        Next
    End Sub


    Private Sub btnFmusearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmusearch.Click
        FormPencarian.cbFpdivisi.Text = txtFmuuser.Text
        FormPencarian.Show()
    End Sub

    Private Sub TampilkanUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TampilkanUserToolStripMenuItem.Click
        FormUser.Show()

    End Sub

    Private Sub BuatUserBaruToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuatUserBaruToolStripMenuItem.Click
        FormUserInput.gbFui.Text = "INPUT USER"
        FormUserInput.txtFuiid.ReadOnly = False
        FormUserInput.txtFuiname.ReadOnly = False
        FormUserInput.txtFuikode.ReadOnly = False
        FormUserInput.ShowDialog()
    End Sub

    Private Sub HapusUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusUserToolStripMenuItem.Click
        FormUserHapus.cbFuh.Visible = True
        FormUserHapus.ShowDialog()
    End Sub

    Public Sub reminderout()
        For i = 0 To dgvFmu.RowCount - 1
            If (dgvFmu.Rows(i).Cells("Tanggal Reminder").Value = "" & Now & "") Then
                MessageBox.Show("Ada reminder hari ini", "REMINDER")
                Exit For
            End If
        Next
        For i = 0 To dgvFmu.RowCount - 1
            If (dgvFmu.Rows(i).Cells("Tanggal Reminder").Value = "" & Now & "") Then
                FormReminder.txtFrdivisi.Text = dgvFmu.Rows(i).Cells(1).Value.ToString
                FormReminder.txtFrkode.Text = dgvFmu.Rows(i).Cells(2).Value.ToString
                FormReminder.txtFrtentang.Text = dgvFmu.Rows(i).Cells(3).Value.ToString
                FormReminder.txtFrdetail.Text = dgvFmu.Rows(i).Cells(4).Value.ToString
                FormReminder.txtFrtanggal.Text = Format(dgvFmu.Rows(i).Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
                FormReminder.gbreminder.Text = "REMINDER"
                FormReminder.label1.Text = "REMINDER HARI INI"
                FormSelesai.txtFskode.Text = dgvFmu.Rows(i).Cells(2).Value.ToString
                FormReminder.ShowDialog()
            End If
        Next
        For i = 0 To dgvFmu.RowCount - 1
            If (dgvFmu.Rows(i).Cells("Tanggal Acara").Value <= "" & Now & "") Then
                My.Computer.Audio.Play(My.Resources.notif2, AudioPlayMode.Background)
                MessageBox.Show("Ada acara yang belum terlaksanakan", "REMINDER ACARA")
                Exit For
            End If
        Next
        For i = 0 To dgvFmu.RowCount - 1
            If (dgvFmu.Rows(i).Cells("Tanggal Acara").Value <= "" & Now & "") Then
                FormReminder.txtFrdivisi.Text = dgvFmu.Rows(i).Cells(1).Value.ToString
                FormReminder.txtFrkode.Text = dgvFmu.Rows(i).Cells(2).Value.ToString
                FormReminder.txtFrtentang.Text = dgvFmu.Rows(i).Cells(3).Value.ToString
                FormReminder.txtFrdetail.Text = dgvFmu.Rows(i).Cells(4).Value.ToString
                FormReminder.txtFrtanggal.Text = Format(dgvFmu.Rows(i).Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
                FormReminder.gbreminder.Text = "ACARA"
                FormReminder.label1.Text = "ACARA"
                FormSelesai.txtFskode.Text = dgvFmu.Rows(i).Cells(2).Value.ToString
                dgvFmu.Rows(i).DefaultCellStyle.BackColor = Color.LightPink
                FormReminder.ShowDialog()
            End If
        Next
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        FormDatabase.ShowDialog()

    End Sub

    Private Sub Report1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanUserToolStripMenuItem.Click

        FormReportUser.loadreportuser()
        FormReportUser.Show()

    End Sub

    Private Sub LaporanReminderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanReminderToolStripMenuItem.Click

        FormReportReminder.loadreportreminder()
        FormReportReminder.Show()

    End Sub


    Private Sub btnFmurefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmurefresh.Click
        If FormDebug.txtFistatus.Text = "admin" Then
            cbFmudgv.SelectedItem = "SEMUA?"
        Else
            cbFmudgv.Text = txtFmuuser.Text
            cbFmudgv.SelectedItem = txtFmuuser.Text

        End If
        btnFmustatus.Text = "BELUM TERLAKSANA"
        Call updatedgv()

    End Sub

    Private Sub ReminderTerhapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReminderTerhapusToolStripMenuItem.Click
        FormDihapus.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
