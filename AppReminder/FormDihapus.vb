Imports System.Data.Odbc
Public Class FormDihapus
    Private Sub loadcombobox()
        cbFdhuser.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select reminder_untuk from tbl_reminder order by reminder_untuk", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                cbFdhuser.Items.Add(Rd("reminder_untuk"))
                cbFdhuser.Items.Remove("ADMINISTRATOR")
                cbFdhuser.Items.Insert(0, "SEMUA")
            End While
            Dim ar(cbFdhuser.Items.Count - 1) As Object
            cbFdhuser.Items.CopyTo(ar, 0)
            cbFdhuser.Items.Clear()
            Dim i As Integer
            For i = 0 To UBound(ar)
                If Not cbFdhuser.Items.Contains(ar(i)) Then
                    cbFdhuser.Items.Add(ar(i))
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub isikolom()
        dgvFdh.ColumnCount = 13
        dgvFdh.Columns(0).Name = "Pembuat"
        dgvFdh.Columns(1).Name = "Divisi"
        dgvFdh.Columns(2).Name = "Kode"
        dgvFdh.Columns(3).Name = "Judul"
        dgvFdh.Columns(4).Name = "Detail"
        dgvFdh.Columns(5).Name = "Tanggal Reminder"
        dgvFdh.Columns(6).Name = "Tanggal Acara"
        dgvFdh.Columns(7).Name = "Tanggal Dibuat"
        dgvFdh.Columns(8).Name = "Status"
        dgvFdh.Columns(9).Name = "Tanggal Selesai"
        dgvFdh.Columns(10).Name = "Catatan Selesai"
        dgvFdh.Columns(11).Name = "Reminder Dihapus"
        dgvFdh.Columns(12).Name = "Tanggal Reminder Dihapus"
    End Sub
    Private Sub btndansize()
        Dim btndelete As New DataGridViewButtonColumn
        dgvFdh.Columns.Add(btndelete)
        btndelete.HeaderText = ""
        btndelete.Text = "Hapus"
        btndelete.Name = "btndelete"
        btndelete.UseColumnTextForButtonValue = True
        Dim btnkembali As New DataGridViewButtonColumn
        dgvFdh.Columns.Add(btnkembali)
        btnkembali.HeaderText = ""
        btnkembali.Text = "Kembalikan"
        btnkembali.Name = "btnkembali"
        btnkembali.UseColumnTextForButtonValue = True
        dgvFdh.Columns(13).Width = 60
        dgvFdh.Columns(14).Width = 80
        dgvFdh.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(3).Width = 200
        dgvFdh.Columns(4).Width = 175
        dgvFdh.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvFdh.Columns(5).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFdh.Columns(6).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
        dgvFdh.Columns(7).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFdh.Columns(9).DefaultCellStyle.Format = "dddd, dd MMMM yyyy"
        dgvFdh.Columns(12).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
    End Sub
    Sub updatefdh()
        If FormDebug.txtFistatus.Text = "admin" Then
            dgvFdh.Rows.Clear()
            If cbFdhuser.SelectedItem = "SEMUA" Then
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_dihapus='YA' order by reminder_kode asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call isikolom()
                    For Each row In Dt.Rows
                        dgvFdh.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Else
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFdhuser.SelectedItem & " where reminder_dihapus='YA' order by reminder_kode asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call isikolom()
                    For Each row In Dt.Rows
                        dgvFdh.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
            Call btndansize()
            dgvFdh.Columns(0).Visible = False
            dgvFdh.Columns(4).Visible = False
            dgvFdh.Columns(5).Visible = False
            dgvFdh.Columns(6).Visible = False
            dgvFdh.Columns(7).Visible = False
            dgvFdh.Columns(8).Visible = False
            dgvFdh.Columns(9).Visible = False
            dgvFdh.Columns(10).Visible = False
            dgvFdh.Columns(11).Visible = False
            dgvFdh.Columns(12).Visible = True
            dgvFdh.Columns(13).Visible = True
            dgvFdh.Columns(14).Visible = True
            chFdhtgl2.Checked = True
            chFdhbtn1.Checked = True
            chFdhbtn2.Checked = True
        Else
            MsgBox("updatedgv error")
        End If
    End Sub
    Private Sub FormDihapus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbFdh.Location = New Point(405, 81)
        Timersearch.Enabled = True
        Call loadcombobox()
        cbFdhuser.SelectedItem = "SEMUA"
        Call updatefdh()
    End Sub

    Private Sub btnFdhok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdhok.Click
        Timersearch.Enabled = True
        pbFdh.Location = New Point(405, 81)
        Me.Close()
        Call FormMenuUtama.updatedgv()
        Call FormMenuUtama.updatecolor()

    End Sub
    Private Sub dgvFdh_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFdh.CellClick
        If e.ColumnIndex = 4 Then
            Dim dgvuser As String
            Dim dgvkode As String
            dgvuser = dgvFdh.CurrentRow.Cells(1).Value.ToString
            dgvkode = dgvFdh.CurrentRow.Cells(2).Value.ToString
            FormDebug.txtdgvuserhidden.Text = dgvuser
            FormDebug.txtdgvkodehidden.Text = dgvkode

            FormDebug.txtFmudgvpembuat.Text = dgvFdh.CurrentRow.Cells(0).Value.ToString
            FormDebug.txtFmudgvdivisi.Text = dgvFdh.CurrentRow.Cells(1).Value.ToString
            FormDebug.txtFmudgvkode.Text = dgvFdh.CurrentRow.Cells(2).Value.ToString
            FormDebug.txtFmudgvtentang.Text = dgvFdh.CurrentRow.Cells(3).Value.ToString
            FormDebug.txtFmudgvdetail.Text = dgvFdh.CurrentRow.Cells(4).Value.ToString
            FormDebug.txtFmudgvtglreminder.Text = Format(dgvFdh.CurrentRow.Cells(5).Value, "dddd, dd MMMM yyyy")
            FormDebug.txtFmudgvtglacara.Text = Format(dgvFdh.CurrentRow.Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDebug.txtFmudgvtgldibuat.Text = Format(dgvFdh.CurrentRow.Cells(7).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDebug.txtFmudgvstatus.Text = dgvFdh.CurrentRow.Cells(8).Value.ToString
            FormDebug.txtFmudgvtglselesai.Text = dgvFdh.CurrentRow.Cells(9).Value.ToString
            FormDebug.txtFmudgvselesai.Text = dgvFdh.CurrentRow.Cells(10).Value.ToString

            FormDetail.lblFdpembuat.Text = "PEMBUAT : " & dgvFdh.CurrentRow.Cells(0).Value.ToString & " "
            FormDetail.txtFddivisi.Text = dgvFdh.CurrentRow.Cells(1).Value.ToString
            FormDetail.txtFdkode.Text = dgvFdh.CurrentRow.Cells(2).Value.ToString
            FormDetail.txtFdtentang.Text = dgvFdh.CurrentRow.Cells(3).Value.ToString
            FormDetail.txtFddetail.Text = dgvFdh.CurrentRow.Cells(4).Value.ToString
            FormDetail.txtFdtglreminder.Text = Format(dgvFdh.CurrentRow.Cells(5).Value, "dddd, dd MMMM yyyy")
            FormDetail.txtFdtglacara.Text = Format(dgvFdh.CurrentRow.Cells(6).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDetail.txtFdtgldibuat.Text = Format(dgvFdh.CurrentRow.Cells(7).Value, "dddd, dd MMMM yyyy HH:mm")
            FormDetail.txtFdstatus.Text = dgvFdh.CurrentRow.Cells(8).Value.ToString
            FormDetail.txtFdtglselesai.Text = dgvFdh.CurrentRow.Cells(9).Value.ToString
            FormDetail.txtFdselesai.Text = dgvFdh.CurrentRow.Cells(10).Value.ToString

            If FormDetail.txtFdstatus.Text = "SELESAI" Then
                FormDebug.txtFmudgvtglselesai.Text = Format(dgvFdh.CurrentRow.Cells(9).Value, "dddd, dd MMMM yyyy HH:mm")
                FormDetail.txtFdtglselesai.Text = Format(dgvFdh.CurrentRow.Cells(9).Value, "dddd, dd MMMM yyyy HH:mm")
            End If
            'MessageBox.Show("" & FormDebug.txtFmudgvdetail.Text & "", "" & FormDebug.txtFmudgvtentang.Text & "")
            'MsgBox(dgvFmu.CurrentRow.Cells(3).Value.ToString)
            'FormDebug.txtFmudgvtentang.Text = ""
            'FormDebug.txtFmudgvdetail.Text = ""
            FormDetail.ShowDialog()
        ElseIf e.ColumnIndex = 13 Then
            If MsgBox("Anda yakin ingin menghapus reminder secara permanen ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Dim hpsuser As String
                Dim hpskode As String
                hpsuser = dgvFdh.CurrentRow.Cells(1).Value.ToString
                hpskode = dgvFdh.CurrentRow.Cells(2).Value.ToString
                Try
                    Call Koneksi()
                    Dim Hapus1 As String = "delete from tbl_reminder" & hpsuser & " where reminder_kode='" & hpskode & "'"
                    CMd = New OdbcCommand(Hapus1, Conn)
                    CMd.ExecuteNonQuery()
                    Conn.Close()
                    Call Koneksi()
                    'lalu kita panggil table mahasiswa lalu dia bilang "tolongin aku dong, aku mau hapus dengan nim xxx tolong di bantu ya. makasih:)"
                    Dim Hapus2 As String = "delete from tbl_reminder where reminder_kode='" & hpskode & "'"
                    CMd = New OdbcCommand(Hapus2, Conn)
                    CMd.ExecuteNonQuery()
                    ' kalau berhasil kita tampilkan alert / message dengan tulisan "hapus data berhasil"
                    MessageBox.Show("Hapus data berhasil", "Hapus Reminder")
                    Call updatefdh()
                Catch ex As Exception
                    MsgBox("Menghapus Reminder Error")
                End Try
            Else
                MessageBox.Show("Membatalkan hapus data", "Hapus Reminder")
            End If
        ElseIf e.ColumnIndex = 14 Then
            If MsgBox("Anda yakin ingin mengembalikan reminder ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Dim hpsuser As String
                Dim hpskode As String
                hpsuser = dgvFdh.CurrentRow.Cells(1).Value.ToString
                hpskode = dgvFdh.CurrentRow.Cells(2).Value.ToString
                Try
                    Call Koneksi()
                    Dim Kembali1 As String = "Update tbl_reminder" & hpsuser & " set reminder_dihapus='TIDAK', reminder_tanggal_dihapus='0000-00-00 00:00:00' where reminder_kode='" & hpskode & "'"
                    CMd = New OdbcCommand(Kembali1, Conn)
                    CMd.ExecuteNonQuery()
                    Conn.Close()
                    Call Koneksi()
                    'lalu kita panggil table mahasiswa lalu dia bilang "tolongin aku dong, aku mau hapus dengan nim xxx tolong di bantu ya. makasih:)"
                    Dim Kembali2 As String = "Update tbl_reminder set reminder_dihapus='TIDAK', reminder_tanggal_dihapus='0000-00-00 00:00:00' where reminder_kode='" & hpskode & "'"
                    CMd = New OdbcCommand(Kembali2, Conn)
                    CMd.ExecuteNonQuery()
                    ' kalau berhasil kita tampilkan alert / message dengan tulisan "hapus data berhasil"
                    MessageBox.Show("Berhasil mengembalikan reminder", "Kembalikan Reminder")
                    Call updatefdh()
                Catch ex As Exception
                    MsgBox("Mengembalikan Reminder Error")
                End Try
            Else
                MsgBox("Reminder batal dikembalikan")
            End If
        End If
    End Sub

    Private Sub btnFdhcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdhcari.Click
        dgvFdh.Rows.Clear()
        Dim dtptgl As String
        dtptgl = dtpFdh.Value.ToString("yyyy-MM-dd")
        If dtpFdh.Visible = True Then
            If cbFdhuser.SelectedItem = "SEMUA" Then
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_dihapus='YA' and reminder_tanggal_acara like '%" & dtptgl & "%' order by reminder_tanggal_acara asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call isikolom()
                    For Each row In Dt.Rows
                        dgvFdh.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Else
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFdhuser.SelectedItem & " where reminder_dihapus='YA' and reminder_tanggal_acara like '%" & dtptgl & "%' order by reminder_tanggal_acara asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call isikolom()
                    For Each row In Dt.Rows
                        dgvFdh.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        Else
            If cbFdhuser.SelectedItem = "SEMUA" Then

                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder where reminder_dihapus='YA' and reminder_tentang like '%" & txtFdhcari.Text & "%' order by reminder_tanggal_acara asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call isikolom()
                    For Each row In Dt.Rows
                        dgvFdh.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Else
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_reminder" & cbFdhuser.SelectedItem & " where reminder_dihapus='YA' and reminder_tentang like '%" & txtFdhcari.Text & "%' order by reminder_tanggal_acara asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    Call isikolom()
                    For Each row In Dt.Rows
                        dgvFdh.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        End If
        Call btndansize()
    End Sub

    Private Sub btnFdhrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdhrefresh.Click
        chFdhtgl3.Checked = False
        chFdhdetail.Checked = False
        chFdhtgl1.Checked = False
        dtpFdh.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        txtFdhcari.Visible = True
        txtFdhcari.Text = ""
        dtpFdh.Value = Now
        cbFdhuser.SelectedItem = "SEMUA"
        Call updatefdh()
    End Sub

    Private Sub txtFdhcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFdhcari.TextChanged
        If txtFdhcari.Text = "" Then
            dtpFdh.Visible = True
            Label1.Visible = True
            pbFdh.Location = New Point(405, 81)
        Else
            pbFdh.Location = New Point(405, 126)
            dtpFdh.Visible = False
            Label1.Visible = False
            dtpFdh.Value = Now
        End If
    End Sub

    Private Sub chFdhdetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFdhdetail.CheckedChanged
        If chFdhdetail.Checked = True Then
            dgvFdh.Columns(4).Visible = True
        Else
            dgvFdh.Columns(4).Visible = False
        End If
    End Sub

    Private Sub chFdhtgl3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFdhtgl3.CheckedChanged
        If chFdhtgl3.Checked = True Then
            dgvFdh.Columns(6).Visible = True
        Else
            dgvFdh.Columns(6).Visible = False
        End If
    End Sub

    Private Sub chFdhtgl1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFdhtgl1.CheckedChanged
        If chFdhtgl1.Checked = True Then
            dgvFdh.Columns(7).Visible = True
        Else
            dgvFdh.Columns(7).Visible = False
        End If
    End Sub

    Private Sub chFdhtgl2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFdhtgl2.CheckedChanged
        If chFdhtgl2.Checked = True Then
            dgvFdh.Columns(12).Visible = True
        Else
            dgvFdh.Columns(12).Visible = False
        End If
    End Sub

    Private Sub chFdhbtn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFdhbtn1.CheckedChanged
        If chFdhbtn1.Checked = True Then
            dgvFdh.Columns(13).Visible = True
        Else
            dgvFdh.Columns(13).Visible = False
        End If
    End Sub

    Private Sub chFdhbtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFdhbtn2.CheckedChanged
        If chFdhbtn2.Checked = True Then
            dgvFdh.Columns(14).Visible = True
        Else
            dgvFdh.Columns(14).Visible = False
        End If
    End Sub
    Private Sub cbFdhuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFdhuser.SelectedIndexChanged
        txtFdhcari.Text = ""
        dtpFdh.Value = Now
        Label1.Visible = True
        dtpFdh.Visible = True
        chFdhdetail.Checked = False
        chFdhtgl1.Checked = False
        chFdhtgl3.Checked = False
        Call updatefdh()
    End Sub

    Private Sub Timersearch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timersearch.Tick
        pbFdh.Value += 10
        If pbFdh.Value = 100 Then
            pbFdh.Value = 0
        End If
    End Sub

End Class