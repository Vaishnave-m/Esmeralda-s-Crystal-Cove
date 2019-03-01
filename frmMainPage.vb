'*******************************************************
' PROGRAMME	    :	Esmeralda's Crystal Cove
'  
' OUTLINE		:	This programme is a fortune telling 
'                   game that allows the user to play
'                   regular or story mode and has multiple
'                   different activities throughout.
' 
' PROGRAMMER	:	Nujaimah Ahmed and Vaishnave Manoharan
'
' DATE		    :	December 18, 2017
' ******************************************************
Public Class frmMainPage
    'Used to open slide in panel on the main page
    Private Sub frmMainPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.FortuneTellingMusic, AudioPlayMode.Background)
    End Sub
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        btnOpen.Visible = False
        pnlMainPage.Location = New Point(-156, -1)

        Do Until pnlMainPage.Location.X = -1
            pnlMainPage.Location = New Point(pnlMainPage.Location.X + 1, -1)
        Loop
        Refresh()
    End Sub
    'Used to close slide in panel on the main page
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnOpen.Visible = True
        pnlMainPage.Location = New Point(-1, -1)

        Do Until pnlMainPage.Location.X = -156
            pnlMainPage.Location = New Point(pnlMainPage.Location.X - 1, -1)
        Loop
        Refresh()
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Hide()
        frmHelp.Show()
    End Sub
    Private Sub btnRegularMode_Click(sender As Object, e As EventArgs) Handles btnRegularMode.Click
        Me.Hide()
        frmRegularTopics.Show()
    End Sub
    Private Sub btnStoryMode_Click(sender As Object, e As EventArgs) Handles btnStoryMode.Click
        storyMode = True
        Me.Hide()
        frmBooth.Show()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter, btnRegularMode.MouseEnter, btnStoryMode.MouseEnter,
            btnHelp.MouseEnter

        Dim btnSender As Button = sender

        btnSender.BackgroundImage = Nothing
        btnSender.BackColor = Color.Purple
    End Sub
    Private Sub btnClose_MouseDown(sender As Object, e As EventArgs) Handles btnClose.MouseLeave, btnRegularMode.MouseLeave, btnStoryMode.MouseLeave,
           btnHelp.MouseLeave

        Dim btnSender As Button = sender

        btnSender.BackgroundImage = My.Resources._5c208f1b14219901b3320d706d24c216__ombre_watercolor_background_purple_watercolor
        btnSender.BackColor = Nothing
    End Sub
End Class