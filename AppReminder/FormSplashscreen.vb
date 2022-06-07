Public Class FormSplashscreen

    
    Private Sub timerSS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerSS.Tick
        pbSSbar.Value += 5
        If pbSSbar.Value = 100 Then
            timerSS.Enabled = False
            Me.Hide()
            FormMenuUtama.Show()
        End If
    End Sub

   
End Class