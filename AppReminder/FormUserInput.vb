Imports System.Data.Odbc
Public Class FormUserInput

    Sub CloseUserInput()
        txtFuiid.Text = ""
        txtFuikode.Text = ""
        txtFuiname.Text = ""
        txtFuipass.Text = ""
        checkFuipass.Checked = False
        cbFui.Text = ""
    End Sub
    Private Sub FormUserInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnFuisimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuisimpan.Click
        If gbFui.Text = "INPUT USER" Then
            If txtFuiid.Text = "" Or txtFuikode.Text = "" Or txtFuiname.Text = "" Or txtFuipass.Text = "" Or cbFui.Text = "" Then
                MessageBox.Show("Pastikan semua field terisi", "Error Input User")
            Else
                Call Koneksi()
                Dim InputUser As String = "Insert into tbl_user values('" & txtFuiid.Text & "','" & txtFuiname.Text & "','" & txtFuipass.Text & "','" & cbFui.Text & "','" & txtFuikode.Text & "')"
                CMd = New OdbcCommand(InputUser, Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Input data01 berhasil")
                Conn.Close()
                Call Koneksi()
                Dim BuatTabel As String = "Create table tbl_reminder" & txtFuiname.Text & " like tbl_reminder"
                CMd = New OdbcCommand(BuatTabel, Conn)
                CMd.ExecuteNonQuery()
                'MsgBox("Input data02 berhasil")
                MessageBox.Show("Input user baru berhasil!", "Input User")
                Call CloseUserInput()
                Me.Close()
            End If
        ElseIf gbFui.Text = "EDIT USER" Then


        End If

        Call FormUser.dgvload()
        Call FormMenuUtama.updatedgv()
    End Sub

    Private Sub checkFuipass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFuipass.CheckedChanged
        If checkFuipass.Checked = True Then
            txtFuipass.PasswordChar = ""
        Else
            txtFuipass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnFuitutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuitutup.Click
        Call CloseUserInput()
        Me.Close()
        Call FormMenuUtama.updatedgv()
        Call FormUser.dgvload()

    End Sub
End Class