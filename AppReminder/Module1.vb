Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module Module1
    Public Function RubahHari(ByVal hari As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(hari, "Sunday", "Minggu"), "Monday", "Senin"), "Tuesday", "Selasa"), "Wednesday", "Rabu"), "Thursday", "Kamis"), "Friday", "Jumat"), "Saturday", "Sabtu")
    End Function
    Public Function RubahBulan(ByVal bulan As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(bulan, "January", "Januari"), "Febuary", "Febuari"), "March", "Maret"), "May", "Mei"), "June", "Juni"), "July", "Juli"), "August", "Agustus"), "October", "Oktober"), "November", "November")
    End Function

    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Dt As DataTable
    Public CMd As OdbcCommand
    Public Rd As OdbcDataReader
    Public MyDB As String
    Public txtFitanggalsekarang As String

    Public defaultdbuser As String = "root"
    Public defaultdbpw As String = ""
    Public defaultdb As String = "dbreminder"
    Public defaultdbserver As String = "localhost"
    Public dbuser As String = "root"
    Public dbpw As String = ""
    Public db As String = "dbreminder"
    Public dbserver As String = "localhost"
    Public TimeNow As String

    Public ReminderOnTime1 As String
    Public ReminderOnTime2 As String
    Public ReminderOnTime3 As String

    Public Sub Koneksi()
        Try
            MyDB = "Driver={Mysql odbc 3.51 driver};database=" & db & ";server=" & dbserver & ";uid=" & dbuser & ";pwd=" & dbpw & ""
            Conn = New OdbcConnection(MyDB)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            Else
                MsgBox("Koneksi error")
            End If
        Catch ex As Exception
            MsgBox("Error Database")
        End Try
    End Sub

    Public Sub Terbuka()
        FormMenuUtama.Timer1Menit.Enabled = True
        'FormMenuUtama.TimerReminder.Enabled = True
        FormMenuUtama.TimerWaktu.Enabled = True
        FormMenuUtama.btnFmulogin.Text = "LOGOUT"
        FormMenuUtama.btnFmulogin.Visible = False
        FormMenuUtama.LoginToolStripMenuItem.Text = "Logout"
        FormMenuUtama.btnFmuinput.Visible = True
        FormMenuUtama.btnFmuedit.Visible = True
        FormMenuUtama.btnFmustatus.Visible = True
        FormMenuUtama.Label2.Visible = True
        FormMenuUtama.Label1.Visible = True
        FormMenuUtama.cbFmudgv.Visible = True
        FormMenuUtama.Label3.Visible = True
        FormMenuUtama.btnFmusearch.Visible = True
        FormMenuUtama.LaporanToolStripMenuItem.Visible = True
        FormDebug.txtTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
        FormDebug.txtTanggalangka.Text = Format(Now, "yyyy-MM-dd")
        FormDebug.txtAngkatgl.Text = Format(Now, "dd")
        FormDebug.txtAngkabulan.Text = Format(Now, "MM")
        FormDebug.txtAngkatahun.Text = Format(Now, "yyyy")
        FormMenuUtama.btnFmurefresh.Visible = True
        FormMenuUtama.Show()
    End Sub

    Public Sub Terkunci()
        FormMenuUtama.Timer1Menit.Enabled = False
        FormMenuUtama.TimerWaktu.Enabled = False
        FormMenuUtama.btnFmulogin.Text = "LOGIN"
        FormMenuUtama.btnFmulogin.Visible = True
        FormMenuUtama.LoginToolStripMenuItem.Text = "Login"
        FormMenuUtama.txtFmuuser.Text = "WAJIB LOGIN UNTUK MENGGUNAKAN APLIKASI"
        FormMenuUtama.txtFmuuser.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        FormMenuUtama.btnFmuinput.Visible = False
        FormMenuUtama.btnFmuedit.Visible = False
        FormMenuUtama.Label2.Visible = False
        FormMenuUtama.Label1.Visible = False
        FormMenuUtama.btnFmustatus.Visible = False
        FormMenuUtama.cbFmudgv.Visible = False
        FormMenuUtama.Label3.Visible = False
        FormMenuUtama.btnFmusearch.Visible = False
        FormMenuUtama.AdminToolStripMenuItem.Visible = False
        FormMenuUtama.LaporanToolStripMenuItem.Visible = False
        FormMenuUtama.btnFmurefresh.Visible = False
        FormMenuUtama.Show()
        FormLogin.txtFluser.Text = ""
        FormLogin.txtFlpass.Text = ""
        FormLogin.cbFlpass.Checked = False
        FormInput.cbFikode.Items.Clear()
        FormInput.txtFidetail.Text = ""
        FormInput.txtFikode.Text = ""
        FormInput.txtFitentang.Text = ""
        FormInput.txtFipembuat.Text = ""
        FormMenuUtama.dgvFmu.Rows.Clear()
        'FormEdit.clearisiedit()
        FormPencarian.dgvFp.Columns.Clear()
        FormPencarian.dgvFp.Rows.Clear()
        FormDebug.txtTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
        FormDebug.txtTanggalangka.Text = Format(Now, "yyyy-MM-dd")
        FormDebug.txtAngkatgl.Text = Format(Now, "dd")
        FormDebug.txtAngkabulan.Text = Format(Now, "MM")
        FormDebug.txtAngkatahun.Text = Format(Now, "yyyy")
    End Sub


    Public Sub comboboxkodeinputload()
        Koneksi()
        Try
            CMd = New OdbcCommand("select user_name from tbl_user order by user_name", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                FormInput.cbFikode.Items.Add(Rd("user_name"))
                'menghilangkan admin karena admin  bukan user tapi superuser
                FormInput.cbFikode.Items.Remove("ADMINISTRATOR")
                FormPencarian.cbFpdivisi.Items.Add(Rd("user_name"))
                FormPencarian.cbFpdivisi.Items.Remove("ADMINISTRATOR")
            End While
        Catch ex As Exception

        End Try
    End Sub





End Module

