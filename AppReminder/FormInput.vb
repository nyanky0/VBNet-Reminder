Imports System.Data.Odbc
Public Class FormInput
    'DataGridView1.Rows.Clear()
    Private Sub loadifadmin()
        If txtFipembuat.Text = "ADMINISTRATOR" Then
            txtFikode.Text = "KODE OTOMATIS"
        End If
    End Sub
    Private Sub cleardata()
        txtFidetail.Text = ""
        txtFikode.Text = ""
        txtFitentang.Text = ""
        cbFikode.Items.Clear()
    End Sub
    Private Sub FormInput_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Call comboboxkodeinputload()
        If FormDebug.txtFistatus.Text = "admin" Then
            cbFikode.Visible = True
            Label7.Visible = True
            cbFikode.Text = "PILIH DIVISI"
        Else
            cbFikode.Visible = False
            Label7.Visible = False
            cbFikode.Text = txtFipembuat.Text
        End If
    End Sub
    Private Sub gbFiinput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        txtFitanggalsekarang = Format(Now, "yyyy-MM-dd HH:mm:ss")
        ' Format(Now, "dddd, dd MMMM yyyy")
        txtFitentang.Focus()
    End Sub
    Private Sub btnFisimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFisimpan.Click
        If txtFipembuat.Text = "" Or txtFikode.Text = "" Or txtFitentang.Text = "" Or txtFidetail.Text = "" Or txtFitanggal.Text = "" Then
            MessageBox.Show("Pastikan semua field terisi", "Error Input Reminder")
        Else
            Call InputFix()
        End If
        'If FormDebug.txtFistatus.Text = "user" Then
        'Call FormMenuUtama.updatedgv()
        ''Call FormMenuUtama.dgvtampiluser()
        ''Call FormMenuUtama.dgvSizeuser()
        'End If
    End Sub
    Private Sub btnFibatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFibatal.Click
        cleardata()
        Call FormMenuUtama.CheckButtonStatus2()
        txtFitanggal.Text = Now
        txtFitanggalreminder.Text = Now
        Conn.Close()
        Me.Close()

    End Sub
    Private Sub InputFix()
        Dim TanggalReminder As String
        Dim TanggalAcara As String
        TanggalReminder = txtFitanggalreminder.Value.ToString("yyyy-MM-dd")
        TanggalAcara = txtFitanggal.Value.ToString("yyyy-MM-dd HH:mm")
        Call autonumber()
        Call Koneksi()
        Dim InputData01 As String = "Insert into tbl_reminder" & FormDebug.txtFiuntuk.Text & " values('" & txtFipembuat.Text & "','" & cbFikode.Text & "','" & txtFikode.Text & "','" & txtFitentang.Text & "','" & txtFidetail.Text & "','" & TanggalReminder & "','" & TanggalAcara & "','" & txtFitanggalsekarang & "','BELUM TERLAKSANA','','','TIDAK','')"
        CMd = New OdbcCommand(InputData01, Conn)
        CMd.ExecuteNonQuery()
        'MsgBox("Input data01 berhasil")
        Conn.Close()
        Call Koneksi()
        Dim InputData02 As String = "Insert into tbl_reminder values('" & txtFipembuat.Text & "','" & cbFikode.Text & "','" & txtFikode.Text & "','" & txtFitentang.Text & "','" & txtFidetail.Text & "','" & TanggalReminder & "','" & TanggalAcara & "','" & txtFitanggalsekarang & "','BELUM TERLAKSANA','','','TIDAK','')"
        CMd = New OdbcCommand(InputData02, Conn)
        CMd.ExecuteNonQuery()
        'MsgBox("Input data02 berhasil")
        MessageBox.Show("Input data reminder baru berhasil!", "Input Reminder")

        Call cleardata()
        Call FormMenuUtama.updatedgv()
        Call FormMenuUtama.CheckButtonStatus2()
        Me.Close()
        txtFitanggal.Value = Format(Now)
        txtFitanggalreminder.Value = Format(Now)
    End Sub
    Private Sub autonumber()
        Koneksi()
        CMd = New OdbcCommand("select * from tbl_reminder" & FormDebug.txtFiuntuk.Text & " where reminder_kode='RMD." & FormDebug.txtFikodehidden.Text & "." & FormDebug.txtAngkatahun.Text & "." & FormDebug.txtAngkabulan.Text & ".0001' order by reminder_kode", Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            txtFikode.Text = "RMD" + "." & FormDebug.txtFikodehidden.Text & "" + "." & FormDebug.txtAngkatahun.Text & "" + "." & FormDebug.txtAngkabulan.Text & "" + ".0001"
        Else
            Conn.Close()
            Koneksi()
            Try
                CMd = New OdbcCommand("SELECT CONCAT( 'RMD." & FormDebug.txtFikodehidden.Text & "." & FormDebug.txtAngkatahun.Text & "." & FormDebug.txtAngkabulan.Text & ".' ,LPAD(( RIGHT( MAX(reminder_kode),3)+1),4,'0')) as reminder_kode FROM tbl_reminder" & FormDebug.txtFiuntuk.Text & "", Conn)
                Rd = CMd.ExecuteReader
                If Rd.Read Then
                    txtFikode.Text = Rd.Item("reminder_kode")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            Conn.Close()
        End If
    End Sub
    Private Sub cbFikode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFikode.SelectedIndexChanged
        FormDebug.txtFiuntuk.Text = cbFikode.Text
        Try
            Call Koneksi()
            CMd = New OdbcCommand("Select * From tbl_user where user_name='" & cbFikode.Text & "'", Conn)
            Rd = CMd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                FormDebug.txtFikodehidden.Text = Rd.Item("user_kode")
            End If
        Catch ex As Exception
            MsgBox("Kode Error")
        End Try
        Call autonumber()
    End Sub
    Private Sub txtFipembuat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not txtFipembuat.Text = "ADMINISTRATOR" Then
            FormDebug.txtFiuntuk.Text = txtFipembuat.Text
        Else
            FormDebug.txtFiuntuk.Text = ""
            FormDebug.txtFikodehidden.Text = ""
        End If
        Call autonumber()
        Call loadifadmin()
    End Sub
End Class