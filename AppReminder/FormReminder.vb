Imports System.Data.Odbc

Public Class FormReminder

    Sub textclear()
        txtFrdetail.Text = ""
        txtFrdivisi.Text = ""
        txtFrkode.Text = ""
        txtFrtentang.Text = ""
        txtFrtanggal.Text = ""
    End Sub
    Private Sub btnFrselesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrselesai.Click
        FormSelesai.ShowDialog()
        FormSelesai.txtFskode.Text = txtFrkode.Text
        FormSelesai.txtFscatatan.Focus()
    End Sub
    Private Sub btnFrok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrok.Click
        MessageBox.Show("REMINDER MASIH BERSTATUS BELUM TERLAKSANAKAN!", "REMINDER")
        Call textclear()
        'Call FormMenuUtama.CheckButtonStatus2()
        Call FormMenuUtama.updatecolor()
        Me.Close()
    End Sub
    Private Sub FormReminder_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnFrok_Click(sender, e)
        End If
    End Sub
    Private Sub txtFrdetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFrdetail.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnFrok_Click(sender, e)
        End If
    End Sub
    Private Sub FormReminder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tgl As Date
        'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
        label6.Text = FormDebug.txtTanggal.Text
        Koneksi()
        CMd = New OdbcCommand("select * from tbl_reminder where reminder_kode='" & txtFrkode.Text & "'", Conn)
        Rd = CMd.ExecuteReader
        While Rd.Read
            txtFrtentang.Text = Rd.Item("reminder_tentang")
            txtFrdetail.Text = Rd.Item("reminder_detail")
            txtFrdivisi.Text = Rd.Item("reminder_untuk")
            'txtFrtanggal.Text = Rd.Item("reminder_tanggal_acara")
            tgl = Rd.Item("reminder_tanggal_acara")
            txtFrtanggal.Text = Format(tgl, "dddd, dd MMMM yyyy HH:mm")
        End While
    End Sub
End Class