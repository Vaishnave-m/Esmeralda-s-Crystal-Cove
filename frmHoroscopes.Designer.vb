<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoroscopes
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
        Me.tmrRotate = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancer = New System.Windows.Forms.Button()
        Me.btnTaurus = New System.Windows.Forms.Button()
        Me.btnGemini = New System.Windows.Forms.Button()
        Me.btnLeo = New System.Windows.Forms.Button()
        Me.btnVirgo = New System.Windows.Forms.Button()
        Me.btnLibra = New System.Windows.Forms.Button()
        Me.btnScorpio = New System.Windows.Forms.Button()
        Me.btnSagittarius = New System.Windows.Forms.Button()
        Me.btnCapricorn = New System.Windows.Forms.Button()
        Me.btnAries = New System.Windows.Forms.Button()
        Me.btnPisces = New System.Windows.Forms.Button()
        Me.btnAquarius = New System.Windows.Forms.Button()
        Me.tlpRange = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblHover = New System.Windows.Forms.Label()
        Me.pctTitleTwo = New System.Windows.Forms.PictureBox()
        Me.pctTitleOne = New System.Windows.Forms.PictureBox()
        Me.pctFullWheel = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.pctTitleTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTitleOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctFullWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRotate
        '
        '
        'btnCancer
        '
        Me.btnCancer.BackColor = System.Drawing.Color.Transparent
        Me.btnCancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancer.FlatAppearance.BorderSize = 0
        Me.btnCancer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancer.Location = New System.Drawing.Point(755, 307)
        Me.btnCancer.Name = "btnCancer"
        Me.btnCancer.Size = New System.Drawing.Size(117, 132)
        Me.btnCancer.TabIndex = 15
        Me.btnCancer.Tag = "3"
        Me.tlpRange.SetToolTip(Me.btnCancer, "June 21 - July 22" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cardinal water; ruled by the Moon")
        Me.btnCancer.UseVisualStyleBackColor = False
        '
        'btnTaurus
        '
        Me.btnTaurus.BackColor = System.Drawing.Color.Transparent
        Me.btnTaurus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTaurus.FlatAppearance.BorderSize = 0
        Me.btnTaurus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTaurus.Location = New System.Drawing.Point(607, 69)
        Me.btnTaurus.Name = "btnTaurus"
        Me.btnTaurus.Size = New System.Drawing.Size(122, 101)
        Me.btnTaurus.TabIndex = 18
        Me.btnTaurus.Tag = "1"
        Me.tlpRange.SetToolTip(Me.btnTaurus, "April 20 - May 20" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fixed earth; ruled by Venus")
        Me.btnTaurus.UseVisualStyleBackColor = False
        '
        'btnGemini
        '
        Me.btnGemini.BackColor = System.Drawing.Color.Transparent
        Me.btnGemini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGemini.FlatAppearance.BorderSize = 0
        Me.btnGemini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGemini.Location = New System.Drawing.Point(723, 176)
        Me.btnGemini.Name = "btnGemini"
        Me.btnGemini.Size = New System.Drawing.Size(111, 113)
        Me.btnGemini.TabIndex = 19
        Me.btnGemini.Tag = "2"
        Me.tlpRange.SetToolTip(Me.btnGemini, "May 21 - June 20" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mutable air; ruled by Mercury")
        Me.btnGemini.UseVisualStyleBackColor = False
        '
        'btnLeo
        '
        Me.btnLeo.BackColor = System.Drawing.Color.Transparent
        Me.btnLeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLeo.FlatAppearance.BorderSize = 0
        Me.btnLeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeo.Location = New System.Drawing.Point(723, 458)
        Me.btnLeo.Name = "btnLeo"
        Me.btnLeo.Size = New System.Drawing.Size(111, 112)
        Me.btnLeo.TabIndex = 20
        Me.btnLeo.Tag = "4"
        Me.tlpRange.SetToolTip(Me.btnLeo, "July 23 - August 22" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fixed fire; ruled by the Sun")
        Me.btnLeo.UseVisualStyleBackColor = False
        '
        'btnVirgo
        '
        Me.btnVirgo.BackColor = System.Drawing.Color.Transparent
        Me.btnVirgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVirgo.FlatAppearance.BorderSize = 0
        Me.btnVirgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVirgo.Location = New System.Drawing.Point(607, 576)
        Me.btnVirgo.Name = "btnVirgo"
        Me.btnVirgo.Size = New System.Drawing.Size(132, 100)
        Me.btnVirgo.TabIndex = 21
        Me.btnVirgo.Tag = "5"
        Me.tlpRange.SetToolTip(Me.btnVirgo, "August 23 - September 23" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mutable earth; ruled by Mercury")
        Me.btnVirgo.UseVisualStyleBackColor = False
        '
        'btnLibra
        '
        Me.btnLibra.BackColor = System.Drawing.Color.Transparent
        Me.btnLibra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLibra.FlatAppearance.BorderSize = 0
        Me.btnLibra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibra.Location = New System.Drawing.Point(465, 603)
        Me.btnLibra.Name = "btnLibra"
        Me.btnLibra.Size = New System.Drawing.Size(123, 117)
        Me.btnLibra.TabIndex = 22
        Me.btnLibra.Tag = "6"
        Me.tlpRange.SetToolTip(Me.btnLibra, "September 24 - October 23" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cardinal air; ruled by Venus")
        Me.btnLibra.UseVisualStyleBackColor = False
        '
        'btnScorpio
        '
        Me.btnScorpio.BackColor = System.Drawing.Color.Transparent
        Me.btnScorpio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnScorpio.FlatAppearance.BorderSize = 0
        Me.btnScorpio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScorpio.Location = New System.Drawing.Point(310, 576)
        Me.btnScorpio.Name = "btnScorpio"
        Me.btnScorpio.Size = New System.Drawing.Size(134, 91)
        Me.btnScorpio.TabIndex = 23
        Me.btnScorpio.Tag = "7"
        Me.tlpRange.SetToolTip(Me.btnScorpio, "October 24 - November 22" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fixed water; ruled by Pluto")
        Me.btnScorpio.UseVisualStyleBackColor = False
        '
        'btnSagittarius
        '
        Me.btnSagittarius.BackColor = System.Drawing.Color.Transparent
        Me.btnSagittarius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSagittarius.FlatAppearance.BorderSize = 0
        Me.btnSagittarius.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSagittarius.Location = New System.Drawing.Point(221, 458)
        Me.btnSagittarius.Name = "btnSagittarius"
        Me.btnSagittarius.Size = New System.Drawing.Size(113, 112)
        Me.btnSagittarius.TabIndex = 24
        Me.btnSagittarius.Tag = "8"
        Me.tlpRange.SetToolTip(Me.btnSagittarius, "November 23 - December 21" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mutable fire; ruled by Jupiter")
        Me.btnSagittarius.UseVisualStyleBackColor = False
        '
        'btnCapricorn
        '
        Me.btnCapricorn.BackColor = System.Drawing.Color.Transparent
        Me.btnCapricorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCapricorn.FlatAppearance.BorderSize = 0
        Me.btnCapricorn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapricorn.Location = New System.Drawing.Point(175, 307)
        Me.btnCapricorn.Name = "btnCapricorn"
        Me.btnCapricorn.Size = New System.Drawing.Size(127, 132)
        Me.btnCapricorn.TabIndex = 25
        Me.btnCapricorn.Tag = "9"
        Me.tlpRange.SetToolTip(Me.btnCapricorn, "December 22 - January 19" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cardinal earth; ruled by Saturn")
        Me.btnCapricorn.UseVisualStyleBackColor = False
        '
        'btnAries
        '
        Me.btnAries.BackColor = System.Drawing.Color.Transparent
        Me.btnAries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAries.FlatAppearance.BorderSize = 0
        Me.btnAries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAries.Location = New System.Drawing.Point(465, 20)
        Me.btnAries.Name = "btnAries"
        Me.btnAries.Size = New System.Drawing.Size(123, 134)
        Me.btnAries.TabIndex = 26
        Me.btnAries.Tag = "0"
        Me.tlpRange.SetToolTip(Me.btnAries, "March 21 - April 19" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cardinal fire; ruled by Mars")
        Me.btnAries.UseVisualStyleBackColor = False
        '
        'btnPisces
        '
        Me.btnPisces.BackColor = System.Drawing.Color.Transparent
        Me.btnPisces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPisces.FlatAppearance.BorderSize = 0
        Me.btnPisces.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPisces.Location = New System.Drawing.Point(310, 79)
        Me.btnPisces.Name = "btnPisces"
        Me.btnPisces.Size = New System.Drawing.Size(134, 91)
        Me.btnPisces.TabIndex = 27
        Me.btnPisces.Tag = "11"
        Me.tlpRange.SetToolTip(Me.btnPisces, "February 19 - March 20" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mutable water; ruled by Neptune")
        Me.btnPisces.UseVisualStyleBackColor = False
        '
        'btnAquarius
        '
        Me.btnAquarius.BackColor = System.Drawing.Color.Transparent
        Me.btnAquarius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAquarius.FlatAppearance.BorderSize = 0
        Me.btnAquarius.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAquarius.Location = New System.Drawing.Point(221, 175)
        Me.btnAquarius.Name = "btnAquarius"
        Me.btnAquarius.Size = New System.Drawing.Size(113, 114)
        Me.btnAquarius.TabIndex = 28
        Me.btnAquarius.Tag = "10"
        Me.tlpRange.SetToolTip(Me.btnAquarius, "January 20 - February 18" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fixed air; ruled by Uranus")
        Me.btnAquarius.UseVisualStyleBackColor = False
        '
        'tlpRange
        '
        Me.tlpRange.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tlpRange.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tlpRange.IsBalloon = True
        Me.tlpRange.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tlpRange.ToolTipTitle = "Zodiac Sign"
        '
        'lblHover
        '
        Me.lblHover.BackColor = System.Drawing.Color.Transparent
        Me.lblHover.Font = New System.Drawing.Font("Parchment", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHover.Location = New System.Drawing.Point(382, 421)
        Me.lblHover.Name = "lblHover"
        Me.lblHover.Size = New System.Drawing.Size(298, 100)
        Me.lblHover.TabIndex = 29
        Me.lblHover.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pctTitleTwo
        '
        Me.pctTitleTwo.BackColor = System.Drawing.Color.Transparent
        Me.pctTitleTwo.Image = Global.AhmedN_FinalProject.My.Resources.Resources.dtvDywKl
        Me.pctTitleTwo.Location = New System.Drawing.Point(367, 324)
        Me.pctTitleTwo.Name = "pctTitleTwo"
        Me.pctTitleTwo.Size = New System.Drawing.Size(313, 94)
        Me.pctTitleTwo.TabIndex = 17
        Me.pctTitleTwo.TabStop = False
        Me.pctTitleTwo.Visible = False
        '
        'pctTitleOne
        '
        Me.pctTitleOne.BackColor = System.Drawing.Color.Transparent
        Me.pctTitleOne.Image = Global.AhmedN_FinalProject.My.Resources.Resources.sRgxgZUM
        Me.pctTitleOne.Location = New System.Drawing.Point(399, 239)
        Me.pctTitleOne.Name = "pctTitleOne"
        Me.pctTitleOne.Size = New System.Drawing.Size(260, 69)
        Me.pctTitleOne.TabIndex = 16
        Me.pctTitleOne.TabStop = False
        Me.pctTitleOne.Visible = False
        '
        'pctFullWheel
        '
        Me.pctFullWheel.BackColor = System.Drawing.Color.Transparent
        Me.pctFullWheel.Image = Global.AhmedN_FinalProject.My.Resources.Resources.FullWheel
        Me.pctFullWheel.Location = New System.Drawing.Point(124, -25)
        Me.pctFullWheel.Name = "pctFullWheel"
        Me.pctFullWheel.Size = New System.Drawing.Size(797, 775)
        Me.pctFullWheel.TabIndex = 14
        Me.pctFullWheel.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(-1, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(39, 33)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(28, 669)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(167, 51)
        Me.btnMainMenu.TabIndex = 31
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmHoroscopes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources._3d_cubes_vector_wallpapers_photo_pinterest_d_wallpapers_and_3d
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1054, 750)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblHover)
        Me.Controls.Add(Me.btnAquarius)
        Me.Controls.Add(Me.btnPisces)
        Me.Controls.Add(Me.btnAries)
        Me.Controls.Add(Me.btnCapricorn)
        Me.Controls.Add(Me.btnSagittarius)
        Me.Controls.Add(Me.btnScorpio)
        Me.Controls.Add(Me.btnLibra)
        Me.Controls.Add(Me.btnVirgo)
        Me.Controls.Add(Me.btnLeo)
        Me.Controls.Add(Me.btnGemini)
        Me.Controls.Add(Me.btnTaurus)
        Me.Controls.Add(Me.pctTitleTwo)
        Me.Controls.Add(Me.pctTitleOne)
        Me.Controls.Add(Me.btnCancer)
        Me.Controls.Add(Me.pctFullWheel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHoroscopes"
        Me.Text = "Horoscopes"
        CType(Me.pctTitleTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTitleOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctFullWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrRotate As Timer
    Friend WithEvents pctFullWheel As PictureBox
    Friend WithEvents btnCancer As Button
    Friend WithEvents pctTitleOne As PictureBox
    Friend WithEvents pctTitleTwo As PictureBox
    Friend WithEvents btnTaurus As Button
    Friend WithEvents btnGemini As Button
    Friend WithEvents btnLeo As Button
    Friend WithEvents btnVirgo As Button
    Friend WithEvents btnLibra As Button
    Friend WithEvents btnSagittarius As Button
    Friend WithEvents btnCapricorn As Button
    Friend WithEvents btnAries As Button
    Friend WithEvents btnPisces As Button
    Friend WithEvents btnAquarius As Button
    Friend WithEvents btnScorpio As Button
    Friend WithEvents tlpRange As ToolTip
    Friend WithEvents lblHover As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnMainMenu As Button
End Class
