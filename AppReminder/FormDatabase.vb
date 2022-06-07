Imports System.Data.Odbc
Public Class FormDatabase

    Private Sub FormDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFddb.Text = db
        txtFdserver.Text = dbserver
        txtFduser.Text = dbuser
        txtFdpw.Text = dbpw
    End Sub

    Private Sub btnFdbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdbatal.Click
        Me.Close()
        FormMenuUtama.updatedgv()
    End Sub

    Public Sub btnFdsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdsimpan.Click
        db = "" & txtFddb.Text & ""
        dbserver = "" & txtFdserver.Text & ""
        dbuser = "" & txtFduser.Text & ""
        dbpw = "" & txtFdpw.Text & ""
        Try
            Koneksi()
            If Conn.State = ConnectionState.Open Then
                MsgBox("Koneksi sukses, berhasil disimpan")
                Me.Close()
                FormMenuUtama.updatedgv()
            Else
                txtFddb.Focus()
            End If
        Catch ex As Exception
            MsgBox("Koneksi error")
        End Try
    End Sub

    Private Sub btnFdcek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdcek.Click
        
        Try
            MyDB = "Driver={Mysql odbc 3.51 driver};database=" & txtFddb.Text & ";server=" & txtFdserver.Text & ";uid=" & txtFduser.Text & ";pwd=" & txtFdpw.Text & ";"
            Conn = New OdbcConnection(MyDB)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

            If Conn.State = ConnectionState.Open Then
                MsgBox("Koneksi berhasil")
            End If
        Catch ex As Exception
            MsgBox("Koneksi error")
        End Try
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtFddb.Text = defaultdb
        txtFdserver.Text = defaultdbserver
        txtFduser.Text = defaultdbuser
        txtFdpw.Text = defaultdbpw
    End Sub

    Private Sub checkFdpw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFdpw.CheckedChanged
        If checkFdpw.Checked = True Then
            txtFdpw.PasswordChar = ""
        Else
            txtFdpw.PasswordChar = "*"
        End If
    End Sub
End Class