Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.Odbc
Imports System.Globalization

Public Class FormReportReminder

    Public Sub loadreportreminder()
        cbFru1kode.Items.Clear()
        cbFru1user.Items.Clear()
        checkFrureminder.Visible = True
        panelreminder.Visible = True
        cbFru1kode.Enabled = False
        cbFru1status.Items.Add("SELESAI")
        cbFru1status.Items.Add("BELUM TERLAKSANA")
        cbFru1status.Items.Add("SEMUA")
        cbFru1status.SelectedItem = "SEMUA"
        Call filter_reminderuser()
    End Sub
    Private Sub filter_reminderuser()
        cbFru1user.Enabled = True
        cbFru1user.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select user_name from tbl_user order by user_name", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                cbFru1user.Items.Add(Rd.Item("user_name"))
                cbFru1user.Items.Remove("ADMINISTRATOR")
            End While
        Catch ex As Exception
        End Try
        If FormDebug.txtFistatus.Text = "user" Then
            cbFru1user.SelectedItem = "" & FormMenuUtama.txtFmuuser.Text & ""
            cbFru1user.Enabled = False
            Call filter_reminderkode()
        End If
        'Dim ar(cbFmudgv.Items.Count - 1) As Object

        'cbFmudgv.Items.CopyTo(ar, 0)
        'cbFmudgv.Items.Clear()

        'Dim i As Integer
        'For i = 0 To UBound(ar)
        '    If Not cbFmudgv.Items.Contains(ar(i)) Then
        '        cbFmudgv.Items.Add(ar(i))
        '    End If
        'Next
    End Sub
    Private Sub filter_reminderkode()
        If FormDebug.txtFistatus.Text = "user" Then
            cbFru1kode.Visible = True
            cbFru1kode.Items.Clear()
            Koneksi()
            Try
                CMd = New OdbcCommand("select reminder_kode from tbl_reminder" & cbFru1user.Text & " where reminder_dihapus='TIDAK' order by reminder_kode", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    'cbFekode.Text = Rd.Item("reminder_kode")
                    cbFru1kode.Items.Add(Rd.Item("reminder_kode"))
                End While
            Catch ex As Exception
            End Try
        ElseIf FormDebug.txtFistatus.Text = "admin" Then
            cbFru1kode.Items.Clear()
            Koneksi()
            Try
                CMd = New OdbcCommand("select reminder_kode from tbl_reminder" & cbFru1user.Text & " where reminder_dihapus='TIDAK' order by reminder_kode", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    'cbFekode.Text = Rd.Item("reminder_kode")
                    cbFru1kode.Items.Add(Rd.Item("reminder_kode"))
                End While
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub checkFrureminder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If checkFrureminder.Checked = True Then
            panelreminder.Visible = False
        Else
            panelreminder.Visible = True
        End If
    End Sub

    
    Public Sub detailload()
        panelreminder.Visible = False
        checkFrureminder.Visible = False
        Koneksi()
        Dim da As New OdbcDataAdapter("select * from tbl_reminder where reminder_kode='" & FormDetail.txtFdkode.Text & "' and reminder_dihapus='TIDAK'", Conn)
        Dim dt As New DataTable
        da.Fill(dt)
        crReminder1.SetDataSource(dt)
        CrystalReportViewer2.ReportSource = crReminder1
        CrystalReportViewer2.RefreshReport()
    End Sub

    Private Sub cbFru1status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFru1status.SelectedIndexChanged
        If cbFru1status.Text = "SEMUA" Then
            cbFru1kode.Items.Clear()
            Try
                Koneksi()
                CMd = New OdbcCommand("select reminder_kode from tbl_reminder" & cbFru1user.Text & " where reminder_dihapus='TIDAK' order by reminder_kode", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    'cbFekode.Text = Rd.Item("reminder_kode")
                    cbFru1kode.Items.Add(Rd.Item("reminder_kode"))
                End While
            Catch ex As Exception
            End Try
        Else
            cbFru1kode.Items.Clear()
            Try
                Koneksi()
                CMd = New OdbcCommand("select reminder_kode from tbl_reminder" & cbFru1user.Text & " where reminder_status='" & cbFru1status.Text & "' and reminder_dihapus='TIDAK' order by reminder_kode", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    'cbFekode.Text = Rd.Item("reminder_kode")
                    cbFru1kode.Items.Add(Rd.Item("reminder_kode"))
                End While
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnFrureminder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrureminder.Click
        If cbFru1kode.SelectedItem = "" Or cbFru1status.SelectedItem = "" Or cbFru1user.SelectedItem = "" Then
            If cbFru1user.SelectedItem = "" Then
                MsgBox("Pilih divisi terlebih dahulu!")
            ElseIf cbFru1kode.SelectedItem = "" Then
                MsgBox("Pilih kode terlebih dahulu!")
            End If
        Else
            If cbFru1status.Text = "SEMUA" Then
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_reminder" & cbFru1user.Text & " where reminder_kode='" & cbFru1kode.Text & "' and reminder_dihapus='TIDAK' ", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                crReminder1.SetDataSource(dt)
                CrystalReportViewer2.ReportSource = crReminder1
                CrystalReportViewer2.RefreshReport()
            Else
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_reminder" & cbFru1user.Text & " where reminder_kode='" & cbFru1kode.Text & "' and reminder_status='" & cbFru1status.Text & "' and reminder_dihapus='TIDAK'", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                crReminder1.SetDataSource(dt)
                CrystalReportViewer2.ReportSource = crReminder1
                CrystalReportViewer2.RefreshReport()
            End If
        End If
    End Sub

    Private Sub cbFru1user_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFru1user.SelectedIndexChanged
        cbFru1kode.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select reminder_kode from tbl_reminder" & cbFru1user.Text & " where reminder_dihapus='TIDAK' order by reminder_kode", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                'cbFekode.Text = Rd.Item("reminder_kode")
                cbFru1kode.Items.Add(Rd.Item("reminder_kode"))
            End While
        Catch ex As Exception
        End Try
        If cbFru1kode.Enabled = False Then
            cbFru1kode.Enabled = True
        End If
    End Sub

    Private Sub checkFrureminder_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFrureminder.CheckedChanged
        If checkFrureminder.Checked = True Then
            panelreminder.Visible = False
        Else
            panelreminder.Visible = True
        End If
    End Sub
End Class