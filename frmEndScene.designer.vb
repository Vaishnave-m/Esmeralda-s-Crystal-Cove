<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndScene
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picFrog = New System.Windows.Forms.PictureBox()
        Me.picHeart = New System.Windows.Forms.PictureBox()
        Me.picMushroom = New System.Windows.Forms.PictureBox()
        Me.btnCauldron = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.picPotion = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.picHoney = New System.Windows.Forms.PictureBox()
        Me.picPepper = New System.Windows.Forms.PictureBox()
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMushroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPepper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFrog
        '
        Me.picFrog.BackColor = System.Drawing.Color.Transparent
        Me.picFrog.Image = Global.AhmedN_FinalProject.My.Resources.Resources.frog
        Me.picFrog.Location = New System.Drawing.Point(946, 419)
        Me.picFrog.Name = "picFrog"
        Me.picFrog.Size = New System.Drawing.Size(56, 50)
        Me.picFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFrog.TabIndex = 0
        Me.picFrog.TabStop = False
        '
        'picHeart
        '
        Me.picHeart.BackColor = System.Drawing.Color.Transparent
        Me.picHeart.Image = Global.AhmedN_FinalProject.My.Resources.Resources.humanHeart
        Me.picHeart.Location = New System.Drawing.Point(1069, 397)
        Me.picHeart.Name = "picHeart"
        Me.picHeart.Size = New System.Drawing.Size(62, 80)
        Me.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeart.TabIndex = 1
        Me.picHeart.TabStop = False
        '
        'picMushroom
        '
        Me.picMushroom.BackColor = System.Drawing.Color.Transparent
        Me.picMushroom.Image = Global.AhmedN_FinalProject.My.Resources.Resources.mushroom
        Me.picMushroom.Location = New System.Drawing.Point(1002, 337)
        Me.picMushroom.Name = "picMushroom"
        Me.picMushroom.Size = New System.Drawing.Size(69, 199)
        Me.picMushroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMushroom.TabIndex = 2
        Me.picMushroom.TabStop = False
        '
        'btnCauldron
        '
        Me.btnCauldron.BackColor = System.Drawing.Color.Transparent
        Me.btnCauldron.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.cauldron1
        Me.btnCauldron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCauldron.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCauldron.FlatAppearance.BorderSize = 0
        Me.btnCauldron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCauldron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCauldron.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCauldron.Location = New System.Drawing.Point(576, 270)
        Me.btnCauldron.Name = "btnCauldron"
        Me.btnCauldron.Size = New System.Drawing.Size(96, 108)
        Me.btnCauldron.TabIndex = 3
        Me.btnCauldron.UseVisualStyleBackColor = False
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruction.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblInstruction.Location = New System.Drawing.Point(166, 21)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(817, 50)
        Me.lblInstruction.TabIndex = 4
        Me.lblInstruction.Text = "Drag the ingredients into the cauldron!"
        '
        'picPotion
        '
        Me.picPotion.BackColor = System.Drawing.Color.Transparent
        Me.picPotion.Image = Global.AhmedN_FinalProject.My.Resources.Resources.potion
        Me.picPotion.Location = New System.Drawing.Point(243, 123)
        Me.picPotion.Name = "picPotion"
        Me.picPotion.Size = New System.Drawing.Size(631, 528)
        Me.picPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPotion.TabIndex = 5
        Me.picPotion.TabStop = False
        Me.picPotion.Visible = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Maroon
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Blackadder ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMainMenu.Location = New System.Drawing.Point(443, 522)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(202, 45)
        Me.btnMainMenu.TabIndex = 6
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        Me.btnMainMenu.Visible = False
        '
        'picHoney
        '
        Me.picHoney.BackColor = System.Drawing.Color.Transparent
        Me.picHoney.Image = Global.AhmedN_FinalProject.My.Resources.Resources.honey
        Me.picHoney.Location = New System.Drawing.Point(1069, 322)
        Me.picHoney.Name = "picHoney"
        Me.picHoney.Size = New System.Drawing.Size(56, 69)
        Me.picHoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHoney.TabIndex = 7
        Me.picHoney.TabStop = False
        '
        'picPepper
        '
        Me.picPepper.BackColor = System.Drawing.Color.Transparent
        Me.picPepper.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chili_pepper11
        Me.picPepper.Location = New System.Drawing.Point(946, 341)
        Me.picPepper.Name = "picPepper"
        Me.picPepper.Size = New System.Drawing.Size(56, 72)
        Me.picPepper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPepper.TabIndex = 8
        Me.picPepper.TabStop = False
        '
        'frmEndScene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.PotionMix
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1129, 616)
        Me.Controls.Add(Me.picPepper)
        Me.Controls.Add(Me.picHoney)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.picPotion)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.btnCauldron)
        Me.Controls.Add(Me.picHeart)
        Me.Controls.Add(Me.picFrog)
        Me.Controls.Add(Me.picMushroom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEndScene"
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMushroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPepper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFrog As PictureBox
    Friend WithEvents picHeart As PictureBox
    Friend WithEvents picMushroom As PictureBox
    Friend WithEvents btnCauldron As Button
    Friend WithEvents lblInstruction As Label
    Friend WithEvents picPotion As PictureBox
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents picHoney As PictureBox
    Friend WithEvents picPepper As PictureBox
End Class
