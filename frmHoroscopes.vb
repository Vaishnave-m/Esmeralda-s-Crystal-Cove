Public Class frmHoroscopes
    Private count As Integer = 0
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim btnArray() As Button = {btnAries, btnTaurus, btnGemini, btnCancer, btnLeo, btnVirgo, btnLibra, btnScorpio, btnSagittarius,
        btnCapricorn, btnAquarius, btnPisces}

        My.Computer.Audio.Play(My.Resources.HoroscopeBackground1, AudioPlayMode.Background)

        Call btnBackground(btnArray)

        btnAries.Visible = False
        btnTaurus.Visible = False
        btnGemini.Visible = False
        btnCancer.Visible = False
        btnLeo.Visible = False
        btnVirgo.Visible = False
        btnLibra.Visible = False
        btnScorpio.Visible = False
        btnSagittarius.Visible = False
        btnCapricorn.Visible = False
        btnAquarius.Visible = False
        btnPisces.Visible = False
        tmrRotate.Start()

        If storyMode = True Then
            btnMainMenu.Visible = False
        End If
    End Sub
    'Use to show horoscope wheel rotate animation
    'at the beginning of the form.
    Private Sub tmrRotate_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrRotate.Tick
        pctFullWheel.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        count += 1
        pctFullWheel.Refresh()

        If count = 16 Then
            tmrRotate.Stop()
            pctTitleOne.Visible = True
            pctTitleTwo.Visible = True
            btnAries.Visible = True
            btnTaurus.Visible = True
            btnGemini.Visible = True
            btnCancer.Visible = True
            btnLeo.Visible = True
            btnVirgo.Visible = True
            btnLibra.Visible = True
            btnScorpio.Visible = True
            btnSagittarius.Visible = True
            btnCapricorn.Visible = True
            btnAquarius.Visible = True
            btnPisces.Visible = True
            lblHover.Visible = True
        End If
    End Sub
    'Procedure used to change the background of 
    'each horoscope button to the background of 
    'the desired circle piece.
    Private Sub btnBackground(button() As Button)

        For i As Integer = 0 To button.Length - 1
            Dim buttonLocation As Point = pctFullWheel.PointToClient(PointToScreen(button(i).Location))

            button(i).Parent = pctFullWheel
            button(i).Location = buttonLocation

            Dim buttonBackground As New Bitmap(button(i).Width, button(i).Height)

            Using g As Graphics = Graphics.FromImage(buttonBackground)
                g.DrawImage(pctFullWheel.Image,
                            New Rectangle(0,
                                          0,
                                          buttonBackground.Width,
                                          buttonBackground.Height),
                           button(i).Bounds,
                            GraphicsUnit.Pixel)
            End Using

            button(i).BackgroundImage = buttonBackground
        Next
    End Sub
    'Hover for the name of the horoscope sign
    Private Sub btnAries_MouseHover(sender As Object, e As EventArgs) Handles btnAries.MouseHover, btnTaurus.MouseHover, btnGemini.MouseHover,
            btnCancer.MouseHover, btnLeo.MouseHover, btnVirgo.MouseHover, btnLibra.MouseHover, btnScorpio.MouseHover, btnSagittarius.MouseHover,
            btnCapricorn.MouseHover, btnAquarius.MouseHover, btnPisces.MouseHover

        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 0
                lblHover.Text = "Aries"
            Case 1
                lblHover.Text = "Taurus"
            Case 2
                lblHover.Text = "Gemini"
            Case 3
                lblHover.Text = "Cancer"
            Case 4
                lblHover.Text = "Leo"
            Case 5
                lblHover.Text = "Virgo"
            Case 6
                lblHover.Text = "Libra"
            Case 7
                lblHover.Text = "Scorpio"
            Case 8
                lblHover.Text = "Sagittarius"
            Case 9
                lblHover.Text = "Capricorn"
            Case 10
                lblHover.Text = "Aquarius"
            Case 11
                lblHover.Text = "Pisces"
        End Select
    End Sub
    'If a zodiac sign is chosen and the button of 
    'the chosen zodiac sign is clicked, then the 
    'string variable equals the name of the zodiac
    'sign which will be referenced throughout.
    Private Sub btnAries_Click(sender As Object, e As EventArgs) Handles btnAries.Click, btnTaurus.Click, btnGemini.Click,
            btnCancer.Click, btnLeo.Click, btnVirgo.Click, btnLibra.Click, btnScorpio.Click, btnSagittarius.Click, btnCapricorn.Click,
            btnAquarius.Click, btnPisces.Click

        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 0
                strSign = "Aries"
            Case 1
                strSign = "Taurus"
            Case 2
                strSign = "Gemini"
            Case 3
                strSign = "Cancer"
            Case 4
                strSign = "Leo"
            Case 5
                strSign = "Virgo"
            Case 6
                strSign = "Libra"
            Case 7
                strSign = "Scorpio"
            Case 8
                strSign = "Sagittarius"
            Case 9
                strSign = "Capricorn"
            Case 10
                strSign = "Aquarius"
            Case 11
                strSign = "Pisces"
        End Select

        Me.Hide()
        frmFeeling.Show()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmRegularTopics.Show()

    End Sub
End Class