Public Class frmHelp
    Private count As Integer = 0
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrCurtain.Start()
        btnBack.Visible = False
    End Sub
    'Timer set for curtain animation at the beginning
    'of form load.
    Private Sub tmrCurtain_Tick(sender As Object, e As EventArgs) Handles tmrCurtain.Tick
        count += 1

        If count = 12 Then
            tmrCurtain.Stop()
            pctCurtain.Visible = False
            btnSettings.Visible = True
            btnMainPage.Visible = True
            btnAbout.Visible = True
            lblTitle.Visible = True
        End If
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        btnAbout.Visible = False
        btnSettings.Visible = False
        btnMainPage.Visible = False
        btnBack.Visible = True
        lblAbout.Visible = True
        lblAbout2.Visible = True
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        btnAbout.Visible = False
        btnSettings.Visible = False
        btnMainPage.Visible = False
        btnBack.Visible = True
        lblBackgroundMusicTitle.Visible = True
        rdbMusicOff.Visible = True
        rdbMusicOn.Visible = True
    End Sub
    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs)
        btnAbout.Visible = False
        btnSettings.Visible = False
        btnMainPage.Visible = False
        btnBack.Visible = True
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        btnAbout.Visible = True
        btnSettings.Visible = True
        btnMainPage.Visible = True
        btnBack.Visible = False
        lblAbout.Visible = False
        lblAbout2.Visible = False
        lblBackgroundMusicTitle.Visible = False
        lblEsmeraldasCrystalCove.Visible = False
        rdbMusicOff.Visible = False
        rdbMusicOn.Visible = False
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        Me.Hide()
        frmMainPage.Show()
    End Sub
    Private Sub rdbMusicOff_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMusicOff.CheckedChanged
        If rdbMusicOff.Checked = True Then
            My.Computer.Audio.Stop()
        End If
    End Sub
    Private Sub rdbMusicOn_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMusicOn.CheckedChanged
        If rdbMusicOn.Checked = True Then
            My.Computer.Audio.Play(My.Resources.FortuneTellingMusic, AudioPlayMode.Background)
        End If
    End Sub
End Class
