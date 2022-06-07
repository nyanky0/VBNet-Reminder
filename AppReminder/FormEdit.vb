Imports System.Data.Odbc
Public Class FormEdit
    Public Sub loadfrommenubutton()
        If FormDebug.txtFistatus.Text = "admin" Then
            cbFeuser.Items.Clear()
            cbFekode.Items.Clear()
            txtFedetail.Text = ""
            'txtFetanggal.Text = ""
            txtFetentang.Text = ""
            'txtFetanggalreminder.Text = ""
            Try
                Koneksi()
                CMd = New OdbcCommand("select user_name from tbl_user order by user_name", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    'cbFekode.Text = Rd.Item("reminder_kode")
                    cbFeuser.Items.Add(Rd.Item("user_name"))
                    cbFeuser.Items.Remove("ADMINISTRATOR")
                End While
            Catch ex As Exception
            End Try
            cbFeuser.Enabled = True
            cbFekode.Enabled = False
            Dim ar(cbFeuser.Items.Count - 1) As Object
            cbFeuser.Items.CopyTo(ar, 0)
            cbFeuser.Items.Clear()
            Dim i As Integer
            For i = 0 To UBound(ar)
                If Not cbFeuser.Items.Contains(ar(i)) Then
                    cbFeuser.Items.Add(ar(i))
                End If
            Next
        Else
            cbFeuser.Items.Clear()
            cbFeuser.Items.Add("" & FormMenuUtama.txtFmuuser.Text & "")
            cbFeuser.Text = FormMenuUtama.txtFmuuser.Text
            cbFeuser.Enabled = False
            cbFekode.Enabled = True
            Call loadcbkodeuser()
        End If
    End Sub
    Sub loadcbkodeuser()
        cbFekode.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select reminder_kode from tbl_reminder" & cbFeuser.Text & " where reminder_status='BELUM TERLAKSANA' and reminder_dihapus='TIDAK' order by reminder_kode", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                'cbFekode.Text = Rd.Item("reminder_kode")
                cbFekode.Items.Add(Rd.Item("reminder_kode"))
            End While
        Catch ex As Exception
        End Try
    End Sub
    
    Private Sub btnFesimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFesimpan.Click
        If txtFedetail.Text = "" Or txtFetentang.Text = "" Then
            MessageBox.Show("Pastikan semua field terisi", "Error Edit Reminder")
        ElseIf cbFeuser.Text = "" Then
            MessageBox.Show("Pilih user terlebih dahulu", "Error Edit Reminder")
        Else
            ' jika semua terisi panggil Koneksi()
            Dim TanggalReminder As String
            Dim TanggalAcara As String
            TanggalReminder = txtFetanggalreminder.Value.ToString("yyyy-MM-dd")
            TanggalAcara = txtFetanggal.Value.ToString("yyyy-MM-dd HH:mm")
            Call Koneksi()
            ' kita update table mahasiswa
            Dim EditData As String = "Update tbl_reminder set reminder_tentang='" & txtFetentang.Text & "',reminder_detail='" & txtFedetail.Text & "',reminder_tanggal='" & TanggalReminder & "',reminder_tanggal_acara='" & TanggalAcara & "' where reminder_kode='" & cbFekode.Text & "'"
            CMd = New OdbcCommand(EditData, Conn)
            CMd.ExecuteNonQuery()
            ' jika berhasil tampilkan alert / message ("edit data berhasil")
            'MsgBox("Edit data1 berhasil")
            Conn.Close()
            Call Koneksi()
            ' kita update table mahasiswa
            Dim EditData1 As String = "Update tbl_reminder" & cbFeuser.Text & " set reminder_tentang='" & txtFetentang.Text & "',reminder_detail='" & txtFedetail.Text & "',reminder_tanggal='" & TanggalReminder & "',reminder_tanggal_acara='" & TanggalAcara & "' where reminder_kode='" & cbFekode.Text & "'"
            CMd = New OdbcCommand(EditData1, Conn)
            CMd.ExecuteNonQuery()
            ' jika berhasil tampilkan alert / message ("edit data berhasil")
            'MsgBox("Edit data2 berhasil")
            MessageBox.Show("Edit data berhasil", "Edit Reminder")
            'Call clearisiedit()
            Me.Close()
            FormDebug.txtdgvuserhidden.Text = ""
            FormDebug.txtdgvkodehidden.Text = ""
            FormMenuUtama.updatedgv()

            FormMenuUtama.CheckButtonStatus2()

            'txtFetanggal.Text = FormDebug.txtTanggalangka.Text
            'txtFetanggalreminder.Text = FormDebug.txtTanggalangka.Text
            'txtFetanggal.Value = Format(Now)
            'txtFetanggalreminder.Value = Format(Now)
        End If
    End Sub

    Private Sub btnFebatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFebatal.Click
        Me.Close()
    End Sub
    Public Sub loaddaricbkode()
        Try
            Koneksi()
            CMd = New OdbcCommand("select * from tbl_reminder" & cbFeuser.Text & " where reminder_kode='" & cbFekode.Text & "'", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                txtFetentang.Text = Rd.Item("reminder_tentang")
                txtFedetail.Text = Rd.Item("reminder_detail")
                txtFetanggalreminder.Text = Rd.Item("reminder_tanggal")
                txtFetanggal.Text = Rd.Item("reminder_tanggal_acara")
            End While
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cbFekode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFekode.SelectedIndexChanged
        txtFedetail.Text = ""
        'txtFetanggal.Text = Now
        'txtFetanggalreminder.Text = Now
        txtFetentang.Text = ""
        Call loaddaricbkode()
    End Sub

    Private Sub cbFeuser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFeuser.SelectedIndexChanged
        cbFekode.Items.Clear()
        Try
            Koneksi()
            CMd = New OdbcCommand("select reminder_kode from tbl_reminder" & cbFeuser.Text & " where reminder_status='BELUM TERLAKSANA' and reminder_dihapus='TIDAK' order by reminder_kode", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                cbFekode.Items.Add(Rd.Item("reminder_kode"))
            End While
        Catch ex As Exception
        End Try
        cbFekode.Enabled = True
    End Sub

End Class