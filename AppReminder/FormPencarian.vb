Imports System.Data.Odbc

Public Class FormPencarian
    Sub checkstatuscolour()
        For i = 0 To dgvFp.RowCount - 1
            If (dgvFp.Rows(i).Cells("Tanggal Acara").Value <= "" & FormDebug.txtTanggal.Text & "") Then
                If dgvFp.Rows(i).Cells("Status").Value = "SELESAI" Then
                    dgvFp.Rows(i).DefaultCellStyle.BackColor = Color.White
                    dgvFp.Rows(i).Cells("Status").Style.BackColor = Color.LightGreen
                Else
                    dgvFp.Rows(i).DefaultCellStyle.BackColor = Color.LightPink
                End If
            ElseIf dgvFp.Rows(i).Cells("Status").Value = "SELESAI" Then
                dgvFp.Rows(i).DefaultCellStyle.BackColor = Color.White
                dgvFp.Rows(i).Cells("Status").Style.BackColor = Color.LightGreen
            End If
        Next
    End Sub
    Sub inserttblfp()
        dgvFp.ColumnCount = 11
        dgvFp.Columns(0).Name = "Pembuat"
        dgvFp.Columns(1).Name = "Divisi"
        dgvFp.Columns(2).Name = "Kode"
        dgvFp.Columns(3).Name = "Judul"
        dgvFp.Columns(4).Name = "Detail"
        dgvFp.Columns(5).Name = "Tanggal Reminder"
        dgvFp.Columns(6).Name = "Tanggal Acara"
        dgvFp.Columns(7).Name = "Tanggal Dibuat"
        dgvFp.Columns(8).Name = "Status"
        dgvFp.Columns(9).Name = "Tanggal Selesai"
        dgvFp.Columns(10).Name = "Catatan Selesai"
    End Sub
    Public Sub updatesearchtabel()
        dgvFp.Rows.Clear()
    End Sub
    Sub updatecb()
        If FormDebug.txtFistatus.Text = "user" Then
            cbFpdivisi.Items.Clear()
            cbFpdivisi.Items.Insert(0, "" & FormMenuUtama.txtFmuuser.Text & "")
            cbFpdivisi.Text = FormMenuUtama.txtFmuuser.Text
            cbFpdivisi.Enabled = False
            'Call updatepencarianuser()
        ElseIf FormDebug.txtFistatus.Text = "admin" Then
            cbFpdivisi.Items.Clear()
            Call comboboxkodeinputload()
            cbFpdivisi.Items.Insert(0, "SEMUA")
            cbFpdivisi.Text = "SEMUA"
            cbFpdivisi.Enabled = True
        Else
            MsgBox("updatecb error")
        End If
    End Sub
    Sub tabeladdbtnp()
        'addbutton
        Dim btnedit As New DataGridViewButtonColumn
        dgvFp.Columns.Add(btnedit)
        btnedit.HeaderText = ""
        btnedit.Text = "Edit"
        btnedit.Name = "btnedit"
        btnedit.UseColumnTextForButtonValue = True
        Dim btndelete As New DataGridViewButtonColumn
        dgvFp.Columns.Add(btndelete)
        btndelete.HeaderText = ""
        btndelete.Text = "Hapus"
        btndelete.Name = "btndelete"
        btndelete.UseColumnTextForButtonValue = True
        Dim btnselesai As New DataGridViewButtonColumn
        dgvFp.Columns.Add(btnselesai)
        btnselesai.HeaderText = ""
        btnselesai.Text = "Selesai"
        btnselesai.Name = "btnselesai"
        btnselesai.UseColumnTextForButtonValue = True
        dgvFp.Columns(11).Width = 40
        dgvFp.Columns(12).Width = 50
        dgvFp.Columns(13).Width = 60
    End Sub
    Sub tabelsize()
        dgvFp.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(3).Width = 200
        dgvFp.Columns(4).Width = 175
        dgvFp.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFp.Columns(5).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFp.Columns(6).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
        dgvFp.Columns(7).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFp.Columns(9).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
        dgvFp.Columns(0).Visible = False
        dgvFp.Columns(7).Visible = False
        dgvFp.Columns(9).Visible = False
        dgvFp.Columns(10).Visible = False
    End Sub
    Private Sub FormPencarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbFpstatus.Text = "SEMUA"
        Call updatecb()
        dgvFp.Columns.Clear()
        dgvFp.Rows.Clear()
        btnFpstentang.Visible = False
    End Sub
    Private Sub btnFpskode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFpskode.Click
        dgvFp.Columns.Clear()
        dgvFp.Rows.Clear()
        'status semua (selesai dan belum)
        'where kode
        If cbFpstatus.Text = "SEMUA" Then
            'divisi semua / tbl_reminder
            If cbFpdivisi.Text = "SEMUA" Then
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_kode like '%" & txtFpskode.Text & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Tidak ada reminder")
                End Try
            Else
                'divisi dipilih / user
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFpdivisi.Text & " where reminder_kode like '%" & txtFpskode.Text & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Tidak ada reminder")
                End Try
            End If
        Else
            'status dipilih
            'where kode
            'where status
            If cbFpdivisi.Text = "SEMUA" Then
                'divisi semua / tbl_reminder
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_kode like '%" & txtFpskode.Text & "%' and reminder_status like '%" & cbFpstatus.Text & "%' and reminder_dihapus='TIDAK'", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Tidak ada reminder")
                End Try
            Else
                'divisi dipilih / user
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFpdivisi.Text & " where reminder_kode like '%" & txtFpskode.Text & "%' and reminder_status like '%" & cbFpstatus.Text & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Tidak ada reminder")
                End Try
            End If
        End If
        Call tabeladdbtnp()
        Call tabelsize()
        If cbFpstatus.Text = "SELESAI" Then
            dgvFp.Columns(5).Visible = False
            dgvFp.Columns(10).Visible = True
            dgvFp.Columns(9).Visible = True
            dgvFp.Columns(11).Visible = False
            dgvFp.Columns(13).Visible = False
        ElseIf cbFpstatus.Text = "BELUM TERLAKSANA" Then
            dgvFp.Columns(5).Visible = True
            dgvFp.Columns(10).Visible = False
            dgvFp.Columns(9).Visible = False
            dgvFp.Columns(11).Visible = True
            dgvFp.Columns(13).Visible = True
        ElseIf cbFpstatus.Text = "SEMUA" Then
            dgvFp.Columns(5).Visible = True
            dgvFp.Columns(10).Visible = True
            dgvFp.Columns(9).Visible = True
            dgvFp.Columns(11).Visible = True
            dgvFp.Columns(13).Visible = True
        End If
        Call checkstatuscolour()
    End Sub
    Private Sub btnFpstentang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFpstentang.Click
        dgvFp.Columns.Clear()
        dgvFp.Rows.Clear()
        'status semua (selesai dan belum)
        'where tentang
        If cbFpstatus.Text = "SEMUA" Then
            'divisi semua / tbl_reminder
            If cbFpdivisi.Text = "SEMUA" Then
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_tentang like '%" & txtFpstentang.Text & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Else
                'divisi dipilih / user
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFpdivisi.Text & " where reminder_tentang like '%" & txtFpstentang.Text & "%' and reminder_dihapus='TIDAK'", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        Else
            'status dipilih
            'where kode
            'where status
            If cbFpdivisi.Text = "SEMUA" Then
                'divisi semua / tbl_reminder
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_tentang like '%" & txtFpstentang.Text & "%' and reminder_status like '%" & cbFpstatus.Text & "%' and reminder_dihapus='TIDAK'", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Else
                'divisi dipilih / user
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFpdivisi.Text & " where reminder_tentang like '%" & txtFpstentang.Text & "%' and reminder_status like '%" & cbFpstatus.Text & "%' and reminder_dihapus='TIDAK'", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call inserttblfp()
                    For Each row In Dt.Rows
                        dgvFp.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        End If
        Call tabeladdbtnp()
        Call tabelsize()
        If cbFpstatus.Text = "SELESAI" Then
            dgvFp.Columns(5).Visible = False
            dgvFp.Columns(10).Visible = True
            dgvFp.Columns(9).Visible = True
            dgvFp.Columns(11).Visible = False
            dgvFp.Columns(13).Visible = False
        ElseIf cbFpstatus.Text = "BELUM TERLAKSANA" Then
            dgvFp.Columns(5).Visible = True
            dgvFp.Columns(10).Visible = False
            dgvFp.Columns(9).Visible = False
            dgvFp.Columns(11).Visible = True
            dgvFp.Columns(13).Visible = True
        ElseIf cbFpstatus.Text = "SEMUA" Then
            dgvFp.Columns(5).Visible = True
            dgvFp.Columns(10).Visible = True
            dgvFp.Columns(9).Visible = True
            dgvFp.Columns(11).Visible = True
            dgvFp.Columns(13).Visible = True
        End If
        Call checkstatuscolour()

    End Sub
    Private Sub btnFptutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFptutup.Click
        dgvFp.Columns.Clear()
        dgvFp.Rows.Clear()
        txtFpskode.Select()
        Me.Close()
    End Sub
    Private Sub txtFpskode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFpskode.TextChanged
        If txtFpskode.Text = "" Then
            paneltentang.Visible = True
            btnFpstentang.Visible = False
        Else
            paneltentang.Visible = False
            btnFpstentang.Visible = True
        End If
    End Sub
    Private Sub txtFpstentang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFpstentang.TextChanged
        If txtFpstentang.Text = "" Then
            panelkode.Visible = True
            btnFpstentang.Visible = False
        Else
            panelkode.Visible = False
            btnFpstentang.Visible = True
        End If
    End Sub
    Private Sub dgvFp_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFp.CellClick
        If e.ColumnIndex = 4 Then
            If dgvFp.CurrentRow.Cells(4).Value.ToString = "" Then
                MsgBox("Data Kosong")
            Else
                Dim tglreminder As String
                Dim tglacara As String
                Dim tgldibuat As String
                Dim dgvuser As String
                Dim dgvkode As String
                tglreminder = Format(dgvFp.CurrentRow.Cells(5).Value, "dddd, dd MMMM yyyy")
                tglacara = Format(dgvFp.CurrentRow.Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
                tgldibuat = Format(dgvFp.CurrentRow.Cells(7).Value, "dddd, dd MMMM yyyy")
                'tglreminder = Convert.ToDateTime(dgvFp.CurrentRow.Cells(5).Value)
                'tglacara = Convert.ToDateTime(dgvFp.CurrentRow.Cells(6).Value)
                dgvuser = dgvFp.CurrentRow.Cells(1).Value.ToString
                dgvkode = dgvFp.CurrentRow.Cells(2).Value.ToString
                FormDebug.txtdgvuserhidden.Text = dgvuser
                FormDebug.txtdgvkodehidden.Text = dgvkode
                FormDebug.txtFmudgvpembuat.Text = dgvFp.CurrentRow.Cells(0).Value.ToString
                FormDebug.txtFmudgvdivisi.Text = dgvFp.CurrentRow.Cells(1).Value.ToString
                FormDebug.txtFmudgvkode.Text = dgvFp.CurrentRow.Cells(2).Value.ToString
                FormDebug.txtFmudgvtentang.Text = dgvFp.CurrentRow.Cells(3).Value.ToString
                FormDebug.txtFmudgvdetail.Text = dgvFp.CurrentRow.Cells(4).Value.ToString
                FormDebug.txtFmudgvtglreminder.Text = tglreminder
                FormDebug.txtFmudgvtglacara.Text = tglacara
                FormDebug.txtFmudgvtgldibuat.Text = dgvFp.CurrentRow.Cells(7).Value.ToString
                FormDebug.txtFmudgvstatus.Text = dgvFp.CurrentRow.Cells(8).Value.ToString
                FormDebug.txtFmudgvtglselesai.Text = dgvFp.CurrentRow.Cells(9).Value.ToString
                FormDebug.txtFmudgvselesai.Text = dgvFp.CurrentRow.Cells(10).Value.ToString

                FormDetail.lblFdpembuat.Text = "PEMBUAT : " & dgvFp.CurrentRow.Cells(0).Value.ToString & " "
                FormDetail.txtFddivisi.Text = dgvFp.CurrentRow.Cells(1).Value.ToString
                FormDetail.txtFdkode.Text = dgvFp.CurrentRow.Cells(2).Value.ToString
                FormDetail.txtFdtentang.Text = dgvFp.CurrentRow.Cells(3).Value.ToString
                FormDetail.txtFddetail.Text = dgvFp.CurrentRow.Cells(4).Value.ToString
                FormDetail.txtFdtglreminder.Text = tglreminder
                FormDetail.txtFdtglacara.Text = tglacara
                FormDetail.txtFdtgldibuat.Text = tgldibuat
                FormDetail.txtFdstatus.Text = dgvFp.CurrentRow.Cells(8).Value.ToString
                FormDetail.txtFdtglselesai.Text = dgvFp.CurrentRow.Cells(9).Value.ToString
                FormDebug.txtFmudgvselesai.Text = dgvFp.CurrentRow.Cells(10).Value.ToString

                If dgvFp.CurrentRow.Cells(8).Value.ToString = "SELESAI" Then
                    FormDetail.txtFdtglselesai.Text = Format(dgvFp.CurrentRow.Cells(9).Value, "dddd, dd MMMM yyyy HH:mm")
                    FormDebug.txtFmudgvtglselesai.Text = Format(dgvFp.CurrentRow.Cells(9).Value, "dddd, dd MMMM yyyy HH:mm")
                End If
                'MessageBox.Show("" & FormDebug.txtFmudgvdetail.Text & "", "" & FormDebug.txtFmudgvtentang.Text & "")
                'MsgBox(dgvFmu.CurrentRow.Cells(3).Value.ToString)
                'FormDebug.txtFmudgvtentang.Text = ""
                'FormDebug.txtFmudgvdetail.Text = ""
                FormDetail.ShowDialog()
            End If
        ElseIf e.ColumnIndex = 11 Then
            'MsgBox("edit")
            If dgvFp.CurrentRow.Cells(8).Value.ToString = "SELESAI" Then
                MessageBox.Show("Reminder sudah berstatus selesai, tidak dapat diedit", "Edit Reminder")
            Else
                FormEdit.cbFekode.Items.Clear()
                FormEdit.cbFeuser.Items.Clear()
                FormEdit.cbFekode.Items.Add("" & dgvFp.CurrentRow.Cells(2).Value.ToString & "")
                FormEdit.cbFeuser.Items.Add("" & dgvFp.CurrentRow.Cells(1).Value.ToString & "")
                FormEdit.cbFeuser.SelectedItem = dgvFp.CurrentRow.Cells(1).Value.ToString
                FormEdit.cbFekode.SelectedItem = dgvFp.CurrentRow.Cells(2).Value.ToString
                FormEdit.lblFeuser.Visible = True
                FormEdit.cbFeuser.Visible = True
                FormEdit.loaddaricbkode()
                FormEdit.cbFekode.Enabled = False
                FormEdit.cbFeuser.Enabled = False
                FormEdit.ShowDialog()
            End If
        ElseIf e.ColumnIndex = 12 Then
            If dgvFp.CurrentRow.Cells(8).Value.ToString = "SELESAI" Then
                MessageBox.Show("Reminder sudah berstatus selesai", "Hapus Reminder")
            Else
                'MsgBox("delete")
                If MsgBox("Anda yakin ingin menghapus data ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then

                    Dim hpsuser As String
                    Dim hpskode As String
                    Dim sekarang As String
                    hpsuser = dgvFp.CurrentRow.Cells(1).Value.ToString
                    hpskode = dgvFp.CurrentRow.Cells(2).Value.ToString
                    sekarang = Format(Now, "yyyy-MM-dd HH:mm:ss")
                    Try
                        Call Koneksi()
                        Dim HapusData1 As String = "Update tbl_reminder set reminder_dihapus='YA', reminder_tanggal_dihapus='" & sekarang & "' where reminder_kode='" & hpskode & "'"
                        'Dim HapusData1 As String = "delete from tbl_reminder" & FormDebug.txtdgvuserhidden.Text & " where reminder_kode='" & FormDebug.txtdgvkodehidden.Text & "'"
                        CMd = New OdbcCommand(HapusData1, Conn)
                        CMd.ExecuteNonQuery()
                        Conn.Close()
                        Call Koneksi()
                        Dim HapusData2 As String = "Update tbl_reminder" & hpsuser & " set reminder_dihapus='YA', reminder_tanggal_dihapus='" & sekarang & "' where reminder_kode='" & hpskode & "'"
                        'Dim HapusData2 As String = "delete from tbl_reminder where reminder_kode='" & FormDebug.txtdgvkodehidden.Text & "'"
                        CMd = New OdbcCommand(HapusData2, Conn)
                        CMd.ExecuteNonQuery()
                        ' kalau berhasil kita tampilkan alert / message dengan tulisan "hapus data berhasil"
                        MessageBox.Show("Hapus data berhasil", "Hapus Reminder")
                        dgvFp.Rows.Clear()
                    Catch ex As Exception
                        MsgBox("Hapus Data Error")
                    End Try
                Else
                    MessageBox.Show("Membatalkan hapus data", "Hapus Reminder")
                End If
            End If
        ElseIf e.ColumnIndex = 13 Then
                If dgvFp.CurrentRow.Cells(8).Value.ToString = "SELESAI" Then
                    MessageBox.Show("Reminder sudah berstatus selesai", "Reminder Selesai")
                Else
                    If MsgBox("Selesaikan reminder ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        FormSelesai.txtFskode.Text = dgvFp.CurrentRow.Cells(2).Value.ToString
                        FormSelesai.ShowDialog()
                        dgvFp.Rows.Clear()
                    Else
                        MessageBox.Show("Membatalkan penyelesaian reminder", "Reminder Selesai")
                    End If
                End If
            End If

    End Sub
    Private Sub btnFpreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFpreset.Click
        If FormDebug.txtFistatus.Text = "admin" Then
            cbFpdivisi.Text = "SEMUA"
        End If
        dgvFp.Columns.Clear()
        dgvFp.Rows.Clear()
        cbFpstatus.Text = "SEMUA"
        txtFpskode.Text = ""
        txtFpstentang.Text = ""
        txtFpskode.Select()
    End Sub

End Class