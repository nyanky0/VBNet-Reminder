Imports System.Data.Odbc

Public Class FormUserHapus
    Sub comboboxhapusload()
        cbFuh.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select user_name from tbl_user order by user_name", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                cbFuh.Items.Add(Rd("user_name"))
                cbFuh.Items.Remove("ADMINISTRATOR")
                cbFuh.Items.Remove("" & FormMenuUtama.txtFmuuser.Text & "")
            End While
        Catch ex As Exception
        End Try
    End Sub
    Sub clearformhapus()
        txtFuhid.Text = ""
        checksavedb.Checked = False
    End Sub
    Private Sub FormUserHapus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call comboboxhapusload()
    End Sub
    Sub deleteuserid()
        Call Koneksi()
        Dim hapususer As String = "delete from tbl_user where user_name='" & txtFuhid.Text & "'"
        CMd = New OdbcCommand(hapususer, Conn)
        CMd.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Sub deletereminderuser()
        Call Koneksi()
        Dim hapusdb1 As String = "DROP TABLE tbl_reminder" & txtFuhid.Text & ""
        CMd = New OdbcCommand(hapusdb1, Conn)
        CMd.ExecuteNonQuery()
        Conn.Close()
        Call Koneksi()
        Dim hapusdb2 As String = "delete from tbl_reminder where reminder_untuk='" & txtFuhid.Text & "'"
        CMd = New OdbcCommand(hapusdb2, Conn)
        CMd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Anda yakin ingin menghapus user ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            If checksavedb.Checked = True Then
                Call deleteuserid()
                MessageBox.Show("Hapus data berhasil", "Hapus User")
            Else
                Call deleteuserid()
                Call deletereminderuser()
                MessageBox.Show("Hapus data berhasil", "Hapus User")
            End If
            Call clearformhapus()
            Call comboboxhapusload()
        Else
            MessageBox.Show("Membatalkan hapus data", "Hapus Reminder")
        End If
        Call clearformhapus()
        Me.Close()
        FormMenuUtama.updatedgv()
        FormUser.dgvload()

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call clearformhapus()
        Me.Close()
    End Sub

    Private Sub cbFuh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFuh.SelectedIndexChanged
        txtFuhid.Text = cbFuh.Text
    End Sub
End Class