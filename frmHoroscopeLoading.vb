Public Class frmHoroscopeLoading
    Private Sub frmHoroscopeLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrLoading.Start()
    End Sub
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        prgLoading.Increment(3)
        If prgLoading.Value = 100 Then
            tmrLoading.Stop()
            Me.Hide()
            frmHoroscopes.Show()
        End If
    End Sub
End Class