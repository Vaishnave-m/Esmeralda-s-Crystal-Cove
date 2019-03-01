<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPuzzle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.tmrZoomChili = New System.Windows.Forms.Timer(Me.components)
        Me.picChiliPepper = New System.Windows.Forms.PictureBox()
        Me.picPotion = New System.Windows.Forms.PictureBox()
        Me.picPuzzle5 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle4 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle3 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle2 = New System.Windows.Forms.PictureBox()
        Me.picChakra9 = New System.Windows.Forms.PictureBox()
        Me.picChakra8 = New System.Windows.Forms.PictureBox()
        Me.picChakra7 = New System.Windows.Forms.PictureBox()
        Me.picChakra6 = New System.Windows.Forms.PictureBox()
        Me.picChakra5 = New System.Windows.Forms.PictureBox()
        Me.picChakra4 = New System.Windows.Forms.PictureBox()
        Me.picChakra3 = New System.Windows.Forms.PictureBox()
        Me.picChakra2 = New System.Windows.Forms.PictureBox()
        Me.picChakra1 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle9 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle8 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle7 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle6 = New System.Windows.Forms.PictureBox()
        Me.picPuzzle1 = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.picChiliPepper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChakra1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPuzzle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRestart.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(386, 569)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(182, 43)
        Me.btnRestart.TabIndex = 18
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'lblWin
        '
        Me.lblWin.BackColor = System.Drawing.Color.Transparent
        Me.lblWin.Font = New System.Drawing.Font("Colonna MT", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblWin.Location = New System.Drawing.Point(26, 9)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(936, 160)
        Me.lblWin.TabIndex = 19
        Me.lblWin.Text = "You've received a potion item!"
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblWin.Visible = False
        '
        'tmrZoomChili
        '
        '
        'picChiliPepper
        '
        Me.picChiliPepper.BackColor = System.Drawing.Color.Transparent
        Me.picChiliPepper.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chili_pepper11
        Me.picChiliPepper.Location = New System.Drawing.Point(63, 196)
        Me.picChiliPepper.Name = "picChiliPepper"
        Me.picChiliPepper.Size = New System.Drawing.Size(18, 30)
        Me.picChiliPepper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChiliPepper.TabIndex = 20
        Me.picChiliPepper.TabStop = False
        Me.picChiliPepper.Visible = False
        '
        'picPotion
        '
        Me.picPotion.Image = Global.AhmedN_FinalProject.My.Resources.Resources.potion
        Me.picPotion.Location = New System.Drawing.Point(471, 127)
        Me.picPotion.Name = "picPotion"
        Me.picPotion.Size = New System.Drawing.Size(631, 592)
        Me.picPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPotion.TabIndex = 21
        Me.picPotion.TabStop = False
        Me.picPotion.Visible = False
        '
        'picPuzzle5
        '
        Me.picPuzzle5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle5.Location = New System.Drawing.Point(403, 224)
        Me.picPuzzle5.Name = "picPuzzle5"
        Me.picPuzzle5.Size = New System.Drawing.Size(182, 170)
        Me.picPuzzle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle5.TabIndex = 4
        Me.picPuzzle5.TabStop = False
        '
        'picPuzzle4
        '
        Me.picPuzzle4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle4.Location = New System.Drawing.Point(222, 224)
        Me.picPuzzle4.Name = "picPuzzle4"
        Me.picPuzzle4.Size = New System.Drawing.Size(181, 170)
        Me.picPuzzle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle4.TabIndex = 3
        Me.picPuzzle4.TabStop = False
        '
        'picPuzzle3
        '
        Me.picPuzzle3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle3.Location = New System.Drawing.Point(584, 55)
        Me.picPuzzle3.Name = "picPuzzle3"
        Me.picPuzzle3.Size = New System.Drawing.Size(173, 171)
        Me.picPuzzle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle3.TabIndex = 2
        Me.picPuzzle3.TabStop = False
        '
        'picPuzzle2
        '
        Me.picPuzzle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle2.Location = New System.Drawing.Point(403, 55)
        Me.picPuzzle2.Name = "picPuzzle2"
        Me.picPuzzle2.Size = New System.Drawing.Size(182, 172)
        Me.picPuzzle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle2.TabIndex = 1
        Me.picPuzzle2.TabStop = False
        '
        'picChakra9
        '
        Me.picChakra9.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra9
        Me.picChakra9.Location = New System.Drawing.Point(785, 423)
        Me.picChakra9.Name = "picChakra9"
        Me.picChakra9.Size = New System.Drawing.Size(90, 91)
        Me.picChakra9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra9.TabIndex = 17
        Me.picChakra9.TabStop = False
        '
        'picChakra8
        '
        Me.picChakra8.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra8
        Me.picChakra8.Location = New System.Drawing.Point(37, 512)
        Me.picChakra8.Name = "picChakra8"
        Me.picChakra8.Size = New System.Drawing.Size(99, 91)
        Me.picChakra8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra8.TabIndex = 16
        Me.picChakra8.TabStop = False
        '
        'picChakra7
        '
        Me.picChakra7.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra7
        Me.picChakra7.Location = New System.Drawing.Point(97, 402)
        Me.picChakra7.Name = "picChakra7"
        Me.picChakra7.Size = New System.Drawing.Size(99, 91)
        Me.picChakra7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra7.TabIndex = 15
        Me.picChakra7.TabStop = False
        '
        'picChakra6
        '
        Me.picChakra6.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra6
        Me.picChakra6.Location = New System.Drawing.Point(838, 78)
        Me.picChakra6.Name = "picChakra6"
        Me.picChakra6.Size = New System.Drawing.Size(90, 91)
        Me.picChakra6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra6.TabIndex = 14
        Me.picChakra6.TabStop = False
        '
        'picChakra5
        '
        Me.picChakra5.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra5
        Me.picChakra5.Location = New System.Drawing.Point(37, 282)
        Me.picChakra5.Name = "picChakra5"
        Me.picChakra5.Size = New System.Drawing.Size(99, 92)
        Me.picChakra5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra5.TabIndex = 13
        Me.picChakra5.TabStop = False
        '
        'picChakra4
        '
        Me.picChakra4.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra4
        Me.picChakra4.Location = New System.Drawing.Point(97, 166)
        Me.picChakra4.Name = "picChakra4"
        Me.picChakra4.Size = New System.Drawing.Size(99, 90)
        Me.picChakra4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra4.TabIndex = 12
        Me.picChakra4.TabStop = False
        '
        'picChakra3
        '
        Me.picChakra3.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra31
        Me.picChakra3.Location = New System.Drawing.Point(838, 314)
        Me.picChakra3.Name = "picChakra3"
        Me.picChakra3.Size = New System.Drawing.Size(90, 89)
        Me.picChakra3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChakra3.TabIndex = 11
        Me.picChakra3.TabStop = False
        '
        'picChakra2
        '
        Me.picChakra2.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra2
        Me.picChakra2.Location = New System.Drawing.Point(776, 196)
        Me.picChakra2.Name = "picChakra2"
        Me.picChakra2.Size = New System.Drawing.Size(99, 92)
        Me.picChakra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra2.TabIndex = 10
        Me.picChakra2.TabStop = False
        '
        'picChakra1
        '
        Me.picChakra1.Image = Global.AhmedN_FinalProject.My.Resources.Resources.chakra1
        Me.picChakra1.Location = New System.Drawing.Point(37, 55)
        Me.picChakra1.Name = "picChakra1"
        Me.picChakra1.Size = New System.Drawing.Size(99, 92)
        Me.picChakra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChakra1.TabIndex = 9
        Me.picChakra1.TabStop = False
        '
        'picPuzzle9
        '
        Me.picPuzzle9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle9.Location = New System.Drawing.Point(584, 394)
        Me.picPuzzle9.Name = "picPuzzle9"
        Me.picPuzzle9.Size = New System.Drawing.Size(173, 169)
        Me.picPuzzle9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle9.TabIndex = 8
        Me.picPuzzle9.TabStop = False
        '
        'picPuzzle8
        '
        Me.picPuzzle8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle8.Location = New System.Drawing.Point(403, 392)
        Me.picPuzzle8.Name = "picPuzzle8"
        Me.picPuzzle8.Size = New System.Drawing.Size(182, 171)
        Me.picPuzzle8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle8.TabIndex = 7
        Me.picPuzzle8.TabStop = False
        '
        'picPuzzle7
        '
        Me.picPuzzle7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle7.Location = New System.Drawing.Point(222, 392)
        Me.picPuzzle7.Name = "picPuzzle7"
        Me.picPuzzle7.Size = New System.Drawing.Size(181, 171)
        Me.picPuzzle7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle7.TabIndex = 6
        Me.picPuzzle7.TabStop = False
        '
        'picPuzzle6
        '
        Me.picPuzzle6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle6.Location = New System.Drawing.Point(584, 224)
        Me.picPuzzle6.Name = "picPuzzle6"
        Me.picPuzzle6.Size = New System.Drawing.Size(173, 170)
        Me.picPuzzle6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle6.TabIndex = 5
        Me.picPuzzle6.TabStop = False
        '
        'picPuzzle1
        '
        Me.picPuzzle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPuzzle1.Location = New System.Drawing.Point(222, 55)
        Me.picPuzzle1.Name = "picPuzzle1"
        Me.picPuzzle1.Size = New System.Drawing.Size(181, 172)
        Me.picPuzzle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPuzzle1.TabIndex = 0
        Me.picPuzzle1.TabStop = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMainMenu.Location = New System.Drawing.Point(319, 575)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(123, 37)
        Me.btnMainMenu.TabIndex = 31
        Me.btnMainMenu.Text = "Main Room"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        Me.btnMainMenu.Visible = False
        '
        'frmPuzzle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 642)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.picChiliPepper)
        Me.Controls.Add(Me.picPotion)
        Me.Controls.Add(Me.picPuzzle5)
        Me.Controls.Add(Me.picPuzzle4)
        Me.Controls.Add(Me.picPuzzle3)
        Me.Controls.Add(Me.picPuzzle2)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.picChakra9)
        Me.Controls.Add(Me.picChakra8)
        Me.Controls.Add(Me.picChakra7)
        Me.Controls.Add(Me.picChakra6)
        Me.Controls.Add(Me.picChakra5)
        Me.Controls.Add(Me.picChakra4)
        Me.Controls.Add(Me.picChakra3)
        Me.Controls.Add(Me.picChakra2)
        Me.Controls.Add(Me.picChakra1)
        Me.Controls.Add(Me.picPuzzle9)
        Me.Controls.Add(Me.picPuzzle8)
        Me.Controls.Add(Me.picPuzzle7)
        Me.Controls.Add(Me.picPuzzle6)
        Me.Controls.Add(Me.picPuzzle1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPuzzle"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picChiliPepper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChakra1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPuzzle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPuzzle1 As PictureBox
    Friend WithEvents picPuzzle2 As PictureBox
    Friend WithEvents picPuzzle3 As PictureBox
    Friend WithEvents picPuzzle6 As PictureBox
    Friend WithEvents picPuzzle5 As PictureBox
    Friend WithEvents picPuzzle4 As PictureBox
    Friend WithEvents picPuzzle9 As PictureBox
    Friend WithEvents picPuzzle8 As PictureBox
    Friend WithEvents picPuzzle7 As PictureBox
    Friend WithEvents picChakra9 As PictureBox
    Friend WithEvents picChakra8 As PictureBox
    Friend WithEvents picChakra7 As PictureBox
    Friend WithEvents picChakra6 As PictureBox
    Friend WithEvents picChakra5 As PictureBox
    Friend WithEvents picChakra4 As PictureBox
    Friend WithEvents picChakra3 As PictureBox
    Friend WithEvents picChakra2 As PictureBox
    Friend WithEvents picChakra1 As PictureBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblWin As Label
    Friend WithEvents picChiliPepper As PictureBox
    Friend WithEvents picPotion As PictureBox
    Friend WithEvents tmrZoomChili As Timer
    Friend WithEvents btnMainMenu As Button
End Class
