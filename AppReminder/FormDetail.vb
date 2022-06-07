Public Class FormDetail
    Private Sub reloaddetail()
        If txtFdstatus.Text = "BELUM TERLAKSANA" Then
            Label8.Visible = False
            txtFdtglselesai.Visible = False
            btnFdselesai.Visible = True
            Label10.Visible = False
            txtFdselesai.Visible = False
        Else
            Label8.Visible = True
            txtFdtglselesai.Visible = True
            btnFdselesai.Visible = False
            Label10.Visible = True
            txtFdselesai.Visible = True
        End If
    End Sub
    Private Sub FormDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call reloaddetail()
        If txtFdstatus.Text = "SELESAI" Then
            Size = New Size(582, 586)
            btnFdok.Location = New Point(464, 502)
            btnFdlaporan.Location = New Point(368, 502)
        Else
            Size = New Size(582, 430)
            btnFdok.Location = New Point(464, 357)
            btnFdlaporan.Location = New Point(368, 357)
        End If
    End Sub

    Private Sub btnFdselesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdselesai.Click
        If MsgBox("Selesaikan reminder ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            FormSelesai.txtFskode.Text = txtFdkode.Text
            Me.Close()
            FormSelesai.ShowDialog()

        Else
            MessageBox.Show("Membatalkan penyelesaian reminder", "Reminder Selesai")
        End If
    End Sub

    Private Sub btnFdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdok.Click
        Me.Close()
    End Sub

    Private Sub btnFdlaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFdlaporan.Click

        Call FormReportReminder.detailload()
        FormReportReminder.Show()
    End Sub

End Class