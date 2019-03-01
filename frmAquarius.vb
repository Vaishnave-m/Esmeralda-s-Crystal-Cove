Public Class frmAquarius
    'Displays the current date
    Private Sub frmAquarius_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim thisdate As Date
        thisdate = Format(Date.Now(), "ddMMMyyyy")
        lblDate.Text = thisdate

        pnlTitle.Visible = True
        pnlBriefInfo.Visible = False
        pnlSlide.Visible = False

        If storyMode = True Then
            btnMainMenu.Text = "Main Room"
        End If
    End Sub
    Private Sub btnBriefInfo_Click(sender As Object, e As EventArgs) Handles btnBriefInfo.Click
        pnlTitle.Visible = False
        pnlReadings.Visible = False
        pnlBriefInfo.Visible = True
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlBriefInfo.Visible = False
        pnlReadings.Visible = False
        pnlTitle.Visible = True
    End Sub
    Private Sub btnShowPanel_Click(sender As Object, e As EventArgs) Handles btnShowPanel.Click
        pnlSlide.Visible = True
        btnShowPanel.Visible = False
    End Sub
    Private Sub btnHidePanel_Click(sender As Object, e As EventArgs) Handles btnHidePanel.Click
        pnlSlide.Visible = False
        btnShowPanel.Visible = True
    End Sub
    Private Sub btnAries_Click(sender As Object, e As EventArgs) Handles btnAries.Click
        Me.Hide()
        frmAries.Show()
    End Sub
    Private Sub btnTaurus_Click(sender As Object, e As EventArgs) Handles btnTaurus.Click
        Me.Hide()
        frmTaurus.Show()
    End Sub
    Private Sub btnGemini_Click(sender As Object, e As EventArgs) Handles btnGemini.Click
        Me.Hide()
        frmGemini.Show()
    End Sub
    Private Sub btnLeo_Click(sender As Object, e As EventArgs) Handles btnLeo.Click
        Me.Hide()
        frmLeo.Show()
    End Sub
    Private Sub btnCancer_Click(sender As Object, e As EventArgs) Handles btnCancer.Click
        Me.Hide()
        frmCancer.Show()
    End Sub
    Private Sub btnCapricorn_Click(sender As Object, e As EventArgs) Handles btnCapricorn.Click
        Me.Hide()
        frmCapricorn.Show()
    End Sub
    Private Sub btnLibra_Click(sender As Object, e As EventArgs) Handles btnLibra.Click
        Me.Hide()
        frmLibra.Show()
    End Sub
    Private Sub btnPisces_Click(sender As Object, e As EventArgs) Handles btnPisces.Click
        Me.Hide()
        frmPisces.Show()
    End Sub
    Private Sub btnSagittarius_Click(sender As Object, e As EventArgs) Handles btnSagittarius.Click
        Me.Hide()
        frmSagittarius.Show()
    End Sub
    Private Sub btnScorpio_Click(sender As Object, e As EventArgs) Handles btnScorpio.Click
        Me.Hide()
        frmScorpio.Show()
    End Sub
    Private Sub btnVirgo_Click(sender As Object, e As EventArgs) Handles btnVirgo.Click
        Me.Hide()
        frmVirgo.Show()
    End Sub
    Private Sub btnReadings_Click(sender As Object, e As EventArgs) Handles btnReadings.Click
        pnlReadings.Visible = True
        pnlTitle.Visible = False
        pnlBriefInfo.Visible = False
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        pnlBriefInfo.Visible = False
        pnlReadings.Visible = False
        pnlTitle.Visible = True
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        If storyMode = True Then
            Me.Hide()
            frmHumanHeart.Show()
        Else
            Me.Hide()
            frmRegularTopics.Show()
        End If
    End Sub
End Class