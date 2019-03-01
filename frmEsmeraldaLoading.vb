Public Class frmEsmeraldaLoading
    Private Sub frmReadingResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrWait.Enabled = True
        lblWait.Text = "Esmeralda is channeling power from the metaphysical realm to see into your destiny."
    End Sub
    Private Sub tmrCalculating_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        Static x As Integer

        x += 20

        If x = 1000 Then
            tmrWait.Enabled = False

            lblWait.Visible = False
            picCandle.Visible = False
            picSmoke1.Visible = False
            picSmoke2.Visible = False
            Me.Hide()
            frmPalmResults.Show()
        End If
    End Sub
End Class