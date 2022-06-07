Imports System.Data.Odbc
Public Class FormLogin
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFluser.Focus()
    End Sub
    Private Sub btnFlbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlbatal.Click
        txtFluser.Focus()
        Me.Close()
        Call Terkunci()
    End Sub
    Private Sub btnFllogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFllogin.Click
        If txtFluser.Text = "" Or txtFlpass.Text = "" Then
            MsgBox("Kode Admin atau Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            Try
                CMd = New OdbcCommand("Select * From tbl_user where user_id='" & txtFluser.Text & "' and user_pass='" & txtFlpass.Text & "'", Conn)
                Rd = CMd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Me.Hide()
                    MessageBox.Show("Login berhasil!", "Login")
                    FormMenuUtama.txtFmuuser.Text = Rd.Item("user_name")
                    FormMenuUtama.txtFmuuser.Font = New Font("Microsoft Sans Serif", 13, FontStyle.Regular)
                    FormInput.txtFipembuat.Text = Rd.Item("user_name")
                    FormDebug.txtFistatus.Text = Rd.Item("user_status")
                    FormDebug.txtFikodehidden.Text = Rd.Item("user_kode")
                    FormPencarian.cbFpdivisi.Text = Rd.Item("user_name")
                    If FormDebug.txtFistatus.Text = "admin" Then
                        FormMenuUtama.cbFmudgv.Items.Remove("ADMINISTRATOR")
                        FormEdit.cbFeuser.Text = "USER"
                    End If
                    Call Terbuka()
                    txtFluser.Select()
                    Call FormMenuUtama.updatedgv()
                    Call FormMenuUtama.loadmenu()
                    'Call FormMenuUtama.reminderout()
                    Me.Close()
                Else
                    MessageBox.Show("Kode Admin atau Password Salah!", "Login")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub txtFlpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlpass.TextChanged
        txtFlpass.PasswordChar = "*"
    End Sub
    Private Sub txtFlpass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnFllogin_Click(sender, e)
        End If
    End Sub
    Private Sub cbFlpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFlpass.CheckedChanged
        If cbFlpass.Checked = True Then
            txtFlpass.PasswordChar = ""
        Else
            txtFlpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormDatabase.ShowDialog()
    End Sub
End Class