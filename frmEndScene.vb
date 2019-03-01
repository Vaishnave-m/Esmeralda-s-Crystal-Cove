Public Class frmEndScene
    Private Sub btnCauldron_MouseEnter(sender As Object, e As EventArgs) Handles btnCauldron.MouseEnter
        btnCauldron.FlatAppearance.BorderSize = 2
    End Sub
    Private Sub btnCauldron_MouseLeave(sender As Object, e As EventArgs) Handles btnCauldron.MouseLeave
        btnCauldron.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ingredientPictures() As PictureBox = {picMushroom, picFrog, picHeart, picHoney, picPepper}

        For i As Integer = 0 To ingredientPictures.Length - 1
            ingredientPictures(i).AllowDrop = True
        Next
    End Sub
    Private Sub picFrog_MouseDown(sender As Object, e As MouseEventArgs) Handles picFrog.MouseDown, picHeart.MouseDown, picMushroom.MouseDown,
            picPepper.MouseDown, picHoney.MouseDown
        'When the mouse hold on this jigsaw pieces, it will drag a copy to my destination. 
        Dim picture As PictureBox

        picture = CType(sender, PictureBox)
        picture.DoDragDrop(picture, DragDropEffects.Copy)
        picture.Visible = False

        CheckDrag()
    End Sub

    Private Sub btnCauldron_DragEnter(sender As Object, e As DragEventArgs) Handles btnCauldron.DragEnter
        'If my mouse is being clicks and enters any one of the blank puzzle spots, a copy will be made into the blank piece. The original piece
        'disappears.
        Dim picture As PictureBox
        Dim puzzle As PictureBox = sender

        picture = e.Data.GetData(GetType(PictureBox))
        If sender.image Is Nothing Then
            sender.Image = picture.Image
            picture.Visible = False
        End If
    End Sub

    Private Sub CheckDrag()
        If picMushroom.Visible = False And picFrog.Visible = False And picHeart.Visible = False And picPepper.Visible = False And picHoney.Visible = False Then
            Me.BackgroundImage = Nothing
            picPotion.Visible = True
            Me.BackColor = Color.FromArgb(7, 0, 17)
            lblInstruction.Text = "Click on the potion to drink it!"
        End If
    End Sub

    Private Sub picPotion_Click(sender As Object, e As EventArgs) Handles picPotion.Click
        Me.BackgroundImage = My.Resources.introTentScene
        picPotion.Visible = False
        btnCauldron.Visible = False
        My.Computer.Audio.Play(My.Resources.End_Scene_Background_Music, AudioPlayMode.Background)
        lblInstruction.Text = "You've escaped Esmeralda this time!"
        btnMainMenu.Visible = True
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        frog = False
        heart = False
        honey = False
        pepper = False
        mushroom = False
        Application.Restart()
    End Sub
End Class
