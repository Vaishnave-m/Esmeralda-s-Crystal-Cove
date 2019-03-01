Public Class frm8BallLoading
    Private Sub frm8BallLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrLoading.Start()
    End Sub
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        prgLoading.Increment(2)
        If prgLoading.Value = 100 Then
            tmrLoading.Stop()
            Me.Hide()
            frm8Ball.Show()
        End If
    End Sub
End Class