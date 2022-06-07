Imports System.Data.Odbc
Public Class FormSelesai

    Sub selesaiclear()
        txtFscatatan.Text = ""
        txtFsdetail.Text = ""
        txtFsdivisi.Text = ""
        txtFskode.Text = ""
        txtFstanggalacara.Text = ""
        txtFstentang.Text = ""
    End Sub
    Private Sub btnFsbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFsbatal.Click
        Me.Close()
        selesaiclear()
    End Sub

    Private Sub btnFsselesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFsselesai.Click
        Call Koneksi()
        txtFitanggalsekarang = Format(Now, "yyyy-MM-dd HH:mm:ss")
        'lalu kita panggil table mahasiswa lalu dia bilang "tolongin aku dong, aku mau hapus dengan nim xxx tolong di bantu ya. makasih:)"
        Dim Selesai1 As String = "Update tbl_reminder" & txtFsdivisi.Text & " set reminder_status='SELESAI',reminder_tanggal_statusselesai='" & txtFitanggalsekarang & "', reminder_selesai_note='" & txtFscatatan.Text & "' where reminder_kode='" & txtFskode.Text & "'"
        CMd = New OdbcCommand(Selesai1, Conn)
        CMd.ExecuteNonQuery()
        Conn.Close()
        Call Koneksi()
        'lalu kita panggil table mahasiswa lalu dia bilang "tolongin aku dong, aku mau hapus dengan nim xxx tolong di bantu ya. makasih:)"
        Dim Selesai2 As String = "Update tbl_reminder set reminder_status='SELESAI',reminder_tanggal_statusselesai='" & txtFitanggalsekarang & "', reminder_selesai_note='" & txtFscatatan.Text & "' where reminder_kode='" & txtFskode.Text & "'"
        CMd = New OdbcCommand(Selesai2, Conn)
        CMd.ExecuteNonQuery()
        ' kalau berhasil kita tampilkan alert / message dengan tulisan "hapus data berhasil"
        MessageBox.Show("Reminder Acara telah diselesaikan", "Reminder selesai")
        Me.Close()
        selesaiclear()
        FormReminder.Close()
        FormMenuUtama.updatedgv()

    End Sub

    Private Sub FormSelesai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tgl As Date
        Koneksi()
        CMd = New OdbcCommand("select * from tbl_reminder where reminder_kode='" & txtFskode.Text & "'", Conn)
        Rd = CMd.ExecuteReader
        While Rd.Read
            txtFstentang.Text = Rd.Item("reminder_tentang")
            txtFsdetail.Text = Rd.Item("reminder_detail")
            tgl = Rd.Item("reminder_tanggal_acara")
            txtFsdivisi.Text = Rd.Item("reminder_untuk")
            txtFstanggalacara.Text = Format(tgl, "dddd, dd MMMM yyyy HH:mm")
        End While
        txtFscatatan.Focus()
        txtFscatatan.Select()


    End Sub

End Class