Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.Odbc
Imports System.Globalization

'https://stackoverflow.com/questions/15727339/change-text-object-value-of-crystal-report-dynamically-in-vb-net
Public Class FormReportUser



    Private Sub filter_user()
        Koneksi()
        Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_dihapus='TIDAK' ", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        crUser1.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = crUser1
        CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub loadheaderuser()
        Dim pUser As TextObject
        pUser = crUser1.ReportDefinition.ReportObjects("crtxtuser")
        ' display the value for the report
        pUser.Text = FormMenuUtama.txtFmuuser.Text

        Dim pParameter As TextObject
        pParameter = crUser1.ReportDefinition.ReportObjects("crtxtparameter")
        ' display the value for the report
        If rbFrubetween.Checked = True Then
            pParameter.Text = rbFrubetween.Text
        ElseIf rbFrubulan.Checked = True Then
            pParameter.Text = rbFrubulan.Text
        ElseIf rbFruhari.Checked = True Then
            pParameter.Text = rbFruhari.Text
        ElseIf rbFrusemua.Checked = True Then
            pParameter.Text = rbFrusemua.Text
        ElseIf rbFrutahun.Checked = True Then
            pParameter.Text = rbFrutahun.Text
        End If

        Dim pStatus As TextObject
        pStatus = crUser1.ReportDefinition.ReportObjects("crtxtstatus")
        ' display the value for the report
        pStatus.Text = cbFrustatus.Text

        Dim pUrutan As TextObject
        pUrutan = crUser1.ReportDefinition.ReportObjects("crtxturutan")
        pUrutan.Text = cbFruurutan.Text

    End Sub
    Public Sub loadreportuser()
        Label1.Text = "USER = " & FormMenuUtama.txtFmuuser.Text & ""
        rbFrusemua.Checked = True
        panelbulantahun.Visible = False
        paneldate.Visible = False
        panelmenu.Visible = True
        cbFrustatus.SelectedItem = "SEMUA"
        cbFruurutan.SelectedItem = "KODE"
        checkFruhide.Visible = True
        For a As Integer = 0 To 11
            Dim b As DateTime
            cbFrubulan.Items.Add(Format(b.AddMonths(a), "MMMM"))
        Next
        '0 = januari
        cbFrubulan.SelectedIndex = DateTime.Now.Month - 1
        If FormDebug.txtFistatus.Text = "admin" Then
            cbFruuser.Items.Clear()
            cbFruuser.Enabled = True
            Koneksi()
            Try
                CMd = New OdbcCommand("select user_name from tbl_user order by user_name", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    cbFruuser.Items.Add(Rd.Item("user_name"))
                    cbFruuser.Items.Remove("ADMINISTRATOR")
                    cbFruuser.Text = "PILIH USER"
                End While
                Dim ar(cbFruuser.Items.Count - 1) As Object

                cbFruuser.Items.CopyTo(ar, 0)
                cbFruuser.Items.Clear()

                Dim i As Integer
                For i = 0 To UBound(ar)
                    If Not cbFruuser.Items.Contains(ar(i)) Then
                        cbFruuser.Items.Add(ar(i))
                    End If
                Next
            Catch ex As Exception
            End Try
        Else
            cbFruuser.Items.Clear()
            cbFruuser.Enabled = False
            cbFruuser.Items.Add("" & FormMenuUtama.txtFmuuser.Text & "")
            cbFruuser.SelectedItem = "" & FormMenuUtama.txtFmuuser.Text & ""
        End If
        Call loadheaderuser()
        Call filter_user()
    End Sub

    Private Sub loadblnthn()
        'nudFrubln.Minimum = 1
        'nudFrubln.Maximum = 12
        'nudFrubln.Text = DateTime.Now.Month
        nudFruthn.Minimum = DateTime.Now.Year - 5
        nudFruthn.Maximum = DateTime.Now.Year + 2
        nudFruthn.Text = DateTime.Now.Year
    End Sub
    Private Sub checkrb()
        If rbFrusemua.Checked = True Then
            paneldate.Visible = False
            panelbulantahun.Visible = False
        ElseIf rbFruhari.Checked = True Then
            lblsmpedgn.Visible = False
            DateTimePicker2.Visible = False
            paneldate.Visible = True
            panelbulantahun.Visible = False
        ElseIf rbFrubulan.Checked = True Then
            cbFrubulan.Visible = True
            Label3.Visible = True
            Call loadblnthn()
            paneldate.Visible = False
            panelbulantahun.Visible = True
        ElseIf rbFrutahun.Checked = True Then
            DateTimePicker1.CustomFormat = "yyyy"
            cbFrubulan.Visible = False
            Label3.Visible = False
            Call loadblnthn()
            paneldate.Visible = False
            panelbulantahun.Visible = True
        ElseIf rbFrubetween.Checked = True Then
            lblsmpedgn.Visible = True
            DateTimePicker2.Visible = True
            paneldate.Visible = True
            panelbulantahun.Visible = False
        End If
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
    End Sub
    Private Sub rbFruhari_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFruhari.CheckedChanged
        Call checkrb()
    End Sub
    Private Sub rbFrubulan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrubulan.CheckedChanged
        Call checkrb()
    End Sub
    Private Sub rbFrutahun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrutahun.CheckedChanged
        Call checkrb()
    End Sub
    Private Sub rbFrubetween_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrubetween.CheckedChanged
        Call checkrb()
    End Sub
    Private Sub rbFrusemua_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrusemua.CheckedChanged
        Call checkrb()
    End Sub
    Private Sub cari()
        If cbFruurutan.SelectedItem = "KODE" Then
            If rbFrusemua.Checked = True Then
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFruhari.Checked = True Then
                Dim tanggal As String
                tanggal = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara like '%" & tanggal & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara like '%" & tanggal & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara like '%" & tanggal & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFrubulan.Checked = True Then
                Dim tahun As String
                Dim bln1 As String
                Dim bulan = DateTime.ParseExact("" & cbFrubulan.Text & "", "MMMM", CultureInfo.CurrentCulture).Month
                tahun = nudFruthn.Text
                If bulan >= 10 Then
                    bln1 = "" & tahun & "-" & bulan & ""
                Else
                    bln1 = "" & tahun & "-0" & bulan & ""
                End If
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara like '%" & bln1 & "%' and reminder_dihapus='TIDAK'", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara like '%" & bln1 & "%' and reminder_dihapus='TIDAK'", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara like '%" & bln1 & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFrutahun.Checked = True Then
                Dim tahun As String
                tahun = nudFruthn.Text
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara like '%" & tahun & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara like '%" & tahun & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara like '%" & tahun & "%' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFrubetween.Checked = True Then
                Koneksi()
                Dim tanggal As String
                Dim tanggal2 As String
                Dim tgl1 As String
                Dim tgl2 As String
                tgl1 = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                tgl2 = Format(DateTimePicker2.Value, "yyyy-MM-dd")
                tanggal = "" & tgl1 & " 00:00:00"
                tanggal2 = "" & tgl2 & " 23:59:59"
                If cbFrustatus.Text = "SEMUA" Then
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara>='" & tanggal & "' and reminder_tanggal_acara<='" & tanggal2 & "' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara>='" & tanggal & "' and reminder_tanggal_acara<='" & tanggal2 & "' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara>='" & tanggal & "' and reminder_tanggal_acara<='" & tanggal2 & "' and reminder_dihapus='TIDAK' ", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
                If tanggal > tanggal2 Then
                    MsgBox("Input Tanggal Error / Terbalik")
                End If
            End If
            '======================================================================
        ElseIf cbFruurutan.SelectedItem = "TANGGAL" Then
            If rbFrusemua.Checked = True Then
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFruhari.Checked = True Then
                Dim tanggal As String
                tanggal = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara like '%" & tanggal & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara like '%" & tanggal & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara like '%" & tanggal & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFrubulan.Checked = True Then
                Dim tahun As String
                Dim bln1 As String
                Dim bulan = DateTime.ParseExact("" & cbFrubulan.Text & "", "MMMM", CultureInfo.CurrentCulture).Month
                tahun = nudFruthn.Text
                If bulan >= 10 Then
                    bln1 = "" & tahun & "-" & bulan & ""
                Else
                    bln1 = "" & tahun & "-0" & bulan & ""
                End If
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara like '%" & bln1 & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara like '%" & bln1 & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara like '%" & bln1 & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFrutahun.Checked = True Then
                Dim tahun As String
                tahun = nudFruthn.Text
                If cbFrustatus.Text = "SEMUA" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara like '%" & tahun & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara like '%" & tahun & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Koneksi()
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara like '%" & tahun & "%' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
            ElseIf rbFrubetween.Checked = True Then
                Koneksi()
                Dim tanggal As String
                Dim tanggal2 As String
                Dim tgl1 As String
                Dim tgl2 As String
                tgl1 = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                tgl2 = Format(DateTimePicker2.Value, "yyyy-MM-dd")
                tanggal = "" & tgl1 & " 00:00:00"
                tanggal2 = "" & tgl2 & " 23:59:59"
                If cbFrustatus.Text = "SEMUA" Then
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_tanggal_acara>='" & tanggal & "' and reminder_tanggal_acara<='" & tanggal2 & "' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                ElseIf cbFrustatus.Text = "SELESAI" Then
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='SELESAI' and reminder_tanggal_acara>='" & tanggal & "' and reminder_tanggal_acara<='" & tanggal2 & "' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                Else
                    Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_untuk='" & cbFruuser.Text & "' and reminder_status='BELUM TERLAKSANA' and reminder_tanggal_acara>='" & tanggal & "' and reminder_tanggal_acara<='" & tanggal2 & "' and reminder_dihapus='TIDAK' order by reminder_tanggal_acara", Conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    crUser1.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = crUser1
                    Call loadheaderuser()
                    CrystalReportViewer1.RefreshReport()
                End If
                If tanggal > tanggal2 Then
                    MsgBox("Input Tanggal Error / Terbalik")
                End If
            End If
        End If
    End Sub
    Private Sub btnFrucari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrucari.Click
        If cbFruuser.SelectedItem = "" Then
            MsgBox("Pilih divisi terlebih dahulu!")
        ElseIf rbFrubulan.Checked = True Or rbFrubetween.Checked = True Or rbFruhari.Checked = True Or rbFrusemua.Checked = True Or rbFrutahun.Checked = True Then
            Call cari()
        Else
            MsgBox("Pilih parameter terlebih dahulu!")
        End If
        
    End Sub
    Private Sub checkFruhide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFruhide.CheckedChanged
        If checkFruhide.Checked = True Then
            panelmenu.Visible = False
            panelbulantahun.Visible = False
            paneldate.Visible = False
        Else
            rbFrusemua.Checked = False
            rbFrubetween.Checked = False
            rbFrubulan.Checked = False
            rbFruhari.Checked = False
            rbFrutahun.Checked = False
            panelmenu.Visible = True
        End If
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class