<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pctCurtain = New System.Windows.Forms.PictureBox()
        Me.tmrCurtain = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rdbMusicOff = New System.Windows.Forms.RadioButton()
        Me.lblBackgroundMusicTitle = New System.Windows.Forms.Label()
        Me.lblEsmeraldasCrystalCove = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblAbout2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnMainPage = New System.Windows.Forms.Button()
        Me.rdbMusicOn = New System.Windows.Forms.RadioButton()
        CType(Me.pctCurtain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.background
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Font = New System.Drawing.Font("Parchment", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(46, 307)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(216, 83)
        Me.btnSettings.TabIndex = 0
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        Me.btnSettings.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.background
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbout.Font = New System.Drawing.Font("Parchment", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(46, 207)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(216, 81)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        Me.btnAbout.Visible = False
        '
        'pctCurtain
        '
        Me.pctCurtain.BackColor = System.Drawing.Color.Transparent
        Me.pctCurtain.Image = Global.AhmedN_FinalProject.My.Resources.Resources.HTTP3d3dy50aGVpbnZpc2libGVwYXZpbGlvbi5jb20vYXNzZXRzLzIwMTEvMDYvMDEvY3VydGFpbl92ZW5pY2UuZ2lm
        Me.pctCurtain.Location = New System.Drawing.Point(0, 0)
        Me.pctCurtain.Name = "pctCurtain"
        Me.pctCurtain.Size = New System.Drawing.Size(873, 525)
        Me.pctCurtain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCurtain.TabIndex = 4
        Me.pctCurtain.TabStop = False
        '
        'tmrCurtain
        '
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Parchment", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.lblTitle.Location = New System.Drawing.Point(351, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(168, 102)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Help"
        Me.lblTitle.Visible = False
        '
        'rdbMusicOff
        '
        Me.rdbMusicOff.BackColor = System.Drawing.Color.Transparent
        Me.rdbMusicOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbMusicOff.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMusicOff.ForeColor = System.Drawing.Color.Transparent
        Me.rdbMusicOff.Location = New System.Drawing.Point(297, 228)
        Me.rdbMusicOff.Name = "rdbMusicOff"
        Me.rdbMusicOff.Size = New System.Drawing.Size(110, 47)
        Me.rdbMusicOff.TabIndex = 8
        Me.rdbMusicOff.TabStop = True
        Me.rdbMusicOff.Text = "Background Music Off"
        Me.rdbMusicOff.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdbMusicOff.UseVisualStyleBackColor = False
        Me.rdbMusicOff.Visible = False
        '
        'lblBackgroundMusicTitle
        '
        Me.lblBackgroundMusicTitle.AutoSize = True
        Me.lblBackgroundMusicTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBackgroundMusicTitle.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackgroundMusicTitle.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblBackgroundMusicTitle.Location = New System.Drawing.Point(291, 166)
        Me.lblBackgroundMusicTitle.Name = "lblBackgroundMusicTitle"
        Me.lblBackgroundMusicTitle.Size = New System.Drawing.Size(306, 32)
        Me.lblBackgroundMusicTitle.TabIndex = 12
        Me.lblBackgroundMusicTitle.Text = "BACKGROUND MUSIC"
        Me.lblBackgroundMusicTitle.Visible = False
        '
        'lblEsmeraldasCrystalCove
        '
        Me.lblEsmeraldasCrystalCove.AutoSize = True
        Me.lblEsmeraldasCrystalCove.BackColor = System.Drawing.Color.Transparent
        Me.lblEsmeraldasCrystalCove.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsmeraldasCrystalCove.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.lblEsmeraldasCrystalCove.Location = New System.Drawing.Point(214, 148)
        Me.lblEsmeraldasCrystalCove.Name = "lblEsmeraldasCrystalCove"
        Me.lblEsmeraldasCrystalCove.Size = New System.Drawing.Size(440, 32)
        Me.lblEsmeraldasCrystalCove.TabIndex = 14
        Me.lblEsmeraldasCrystalCove.Text = "ESMERALDA'S CRYSTAL COVE"
        Me.lblEsmeraldasCrystalCove.Visible = False
        '
        'lblAbout
        '
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Gabriola", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAbout.Location = New System.Drawing.Point(19, 121)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(826, 324)
        Me.lblAbout.TabIndex = 15
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        Me.lblAbout.Visible = False
        '
        'lblAbout2
        '
        Me.lblAbout2.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout2.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout2.ForeColor = System.Drawing.Color.Cyan
        Me.lblAbout2.Location = New System.Drawing.Point(80, 460)
        Me.lblAbout2.Name = "lblAbout2"
        Me.lblAbout2.Size = New System.Drawing.Size(723, 43)
        Me.lblAbout2.TabIndex = 16
        Me.lblAbout2.Text = "We hope you enjoy your time in Esmeralda's mysticical Crystal Cove! Don't get tra" &
    "pped forever..."
        Me.lblAbout2.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBack.Location = New System.Drawing.Point(582, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(188, 69)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(834, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(39, 33)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnMainPage
        '
        Me.btnMainPage.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.background
        Me.btnMainPage.FlatAppearance.BorderSize = 0
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainPage.Font = New System.Drawing.Font("Parchment", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainPage.ForeColor = System.Drawing.Color.White
        Me.btnMainPage.Location = New System.Drawing.Point(629, 399)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(216, 81)
        Me.btnMainPage.TabIndex = 30
        Me.btnMainPage.Text = "Main Page"
        Me.btnMainPage.UseVisualStyleBackColor = True
        Me.btnMainPage.Visible = False
        '
        'rdbMusicOn
        '
        Me.rdbMusicOn.BackColor = System.Drawing.Color.Transparent
        Me.rdbMusicOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbMusicOn.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMusicOn.ForeColor = System.Drawing.Color.Transparent
        Me.rdbMusicOn.Location = New System.Drawing.Point(487, 228)
        Me.rdbMusicOn.Name = "rdbMusicOn"
        Me.rdbMusicOn.Size = New System.Drawing.Size(110, 47)
        Me.rdbMusicOn.TabIndex = 31
        Me.rdbMusicOn.TabStop = True
        Me.rdbMusicOn.Text = "Background Music On"
        Me.rdbMusicOn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdbMusicOn.UseVisualStyleBackColor = False
        Me.rdbMusicOn.Visible = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources._11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 528)
        Me.Controls.Add(Me.rdbMusicOn)
        Me.Controls.Add(Me.btnMainPage)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblBackgroundMusicTitle)
        Me.Controls.Add(Me.rdbMusicOff)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.pctCurtain)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblAbout2)
        Me.Controls.Add(Me.lblEsmeraldasCrystalCove)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHelp"
        Me.Text = "Instructions"
        CType(Me.pctCurtain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSettings As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents pctCurtain As PictureBox
    Friend WithEvents tmrCurtain As Timer
    Friend WithEvents lblTitle As Label
    Friend WithEvents rdbMusicOff As RadioButton
    Friend WithEvents lblBackgroundMusicTitle As Label
    Friend WithEvents lblEsmeraldasCrystalCove As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblAbout2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnMainPage As Button
    Friend WithEvents rdbMusicOn As RadioButton
End Class
