Public Class frmFeeling
    Private Sub frmFeeling_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrCover.Start()
    End Sub
    Private Sub tmrCover_Tick(sender As Object, e As EventArgs) Handles tmrCover.Tick
        Static x As Integer

        pctFeelingCover.Top += 10
        x -= 20

        If x = 700 Then
            tmrCover.Stop()
        End If
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If pctSelectedOne.Image Is Nothing Or pctSelectedTwo.Image Is Nothing Or pctSelectedThree.Image Is Nothing Then
            MessageBox.Show("Please select three feelings first!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MessageBox.Show("Are you sure you have selected your chosen THREE feelings?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Select Case strSign
                Case "Aries"
                    Me.Hide()
                    frmAries.Show()
                Case "Taurus"
                    Me.Hide()
                    frmTaurus.Show()
                Case "Gemini"
                    Me.Hide()
                    frmGemini.Show()
                Case "Cancer"
                    Me.Hide()
                    frmCancer.Show()
                Case "Leo"
                    Me.Hide()
                    frmLeo.Show()
                Case "Virgo"
                    Me.Hide()
                    frmVirgo.Show()
                Case "Libra"
                    Me.Hide()
                    frmLibra.Show()
                Case "Scorpio"
                    Me.Hide()
                    frmScorpio.Show()
                Case "Sagittarius"
                    Me.Hide()
                    frmSagittarius.Show()
                Case "Capricorn"
                    Me.Hide()
                    frmCapricorn.Show()
                Case "Aquarius"
                    Me.Hide()
                    frmAquarius.Show()
                Case "Pisces"
                    Me.Hide()
                    frmPisces.Show()
            End Select
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmHoroscopes.Show()
    End Sub
    Private Sub pctExcited_Click(sender As Object, e As EventArgs) Handles pctExcited.Click, pctSilly.Click, pctHysterical.Click,
            pctShocked.Click, pctSad.Click

        Dim pctSender As PictureBox = sender

        Select Case pctSender.Tag
            Case 0
                pctSelectedOne.Image = My.Resources.Wink_Emoji_PNG
            Case 1
                pctSelectedOne.Image = My.Resources._9d11fd8ee1390d452110fbd447e64658
            Case 2
                pctSelectedOne.Image = My.Resources.Face_with_Tears_of_Joy_Emoji_PNG
            Case 3
                pctSelectedOne.Image = My.Resources.persons_0015_large
            Case 4
                pctSelectedOne.Image = My.Resources.Sad_Emoji_PNG_File
        End Select
    End Sub
    Private Sub pctHappy_Click(sender As Object, e As EventArgs) Handles pctHappy.Click, pctMischievous.Click, pctNervous.Click,
            pctLovestruck.Click, pctAngry.Click

        Dim pctSender As PictureBox = sender

        Select Case pctSender.Tag
            Case 5
                pctSelectedTwo.Image = My.Resources._27c6023f36af10bd32d73011fc3c078b
            Case 6
                pctSelectedTwo.Image = My.Resources.Emoji_Face_Transparent_Background
            Case 7
                pctSelectedTwo.Image = My.Resources.persons_0051
            Case 8
                pctSelectedTwo.Image = My.Resources.Love_Hearts_Eyes_Emoji_PNG
            Case 9
                pctSelectedTwo.Image = My.Resources.persons_0035_large
        End Select
    End Sub
    Private Sub pctAngelic_Click(sender As Object, e As EventArgs) Handles pctAngelic.Click, pctTired.Click, pctAnnoyed.Click,
            pctCool.Click, pctSick.Click

        Dim pctSender As PictureBox = sender

        Select Case pctSender.Tag
            Case 10
                pctSelectedThree.Image = My.Resources.persons_0056_large
            Case 11
                pctSelectedThree.Image = My.Resources.persons_0042
            Case 12
                pctSelectedThree.Image = My.Resources.persons_0019_large
            Case 13
                pctSelectedThree.Image = My.Resources.Smiling_Face_with_Sunglasses_Cool_Emoji_PNG
            Case 14
                pctSelectedThree.Image = My.Resources.persons_0040_large
        End Select
    End Sub
    Private Sub pctExcited_MouseHover(sender As Object, e As EventArgs) Handles pctExcited.MouseEnter, pctSilly.MouseEnter, pctHysterical.MouseEnter,
            pctShocked.MouseEnter, pctSad.MouseEnter, pctHappy.MouseEnter, pctMischievous.MouseEnter, pctNervous.MouseEnter, pctLovestruck.MouseEnter,
            pctAngry.MouseEnter, pctAngelic.MouseEnter, pctTired.MouseEnter, pctAnnoyed.MouseEnter, pctCool.MouseEnter, pctSick.MouseEnter

        Dim lblArray As Array = {lblExcited, lblSilly, lblHysterical, lblShocked, lblSad, lblHappy, lblMischievous, lblNervous, lblLoveStruck,
            lblAngry, lblAngelic, lblTired, lblAnnoyed, lblCool, lblSick}
        Dim pctSender As PictureBox = sender

        For i As Integer = 0 To lblArray.Length - 1
            lblArray(i).visible = False
        Next

        Select Case pctSender.Tag
            Case 0
                lblExcited.Visible = True
            Case 1
                lblSilly.Visible = True
            Case 2
                lblHysterical.Visible = True
            Case 3
                lblShocked.Visible = True
            Case 4
                lblSad.Visible = True
            Case 5
                lblHappy.Visible = True
            Case 6
                lblMischievous.Visible = True
            Case 7
                lblNervous.Visible = True
            Case 8
                lblLoveStruck.Visible = True
            Case 9
                lblAngry.Visible = True
            Case 10
                lblAngelic.Visible = True
            Case 11
                lblTired.Visible = True
            Case 12
                lblAnnoyed.Visible = True
            Case 13
                lblCool.Visible = True
            Case 14
                lblSick.Visible = True
        End Select
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class