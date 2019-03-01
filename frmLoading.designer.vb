<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoading
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
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.btnReadMyFortune = New System.Windows.Forms.Button()
        Me.lblInstructionTarot = New System.Windows.Forms.Label()
        Me.tmrZoom = New System.Windows.Forms.Timer(Me.components)
        Me.btnShuffle = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDeck
        '
        Me.picDeck.BackColor = System.Drawing.Color.Transparent
        Me.picDeck.Image = Global.AhmedN_FinalProject.My.Resources.Resources.deckofcard
        Me.picDeck.Location = New System.Drawing.Point(439, 180)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(83, 87)
        Me.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeck.TabIndex = 0
        Me.picDeck.TabStop = False
        '
        'btnReadMyFortune
        '
        Me.btnReadMyFortune.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnReadMyFortune.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReadMyFortune.Font = New System.Drawing.Font("Blackadder ITC", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadMyFortune.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReadMyFortune.Location = New System.Drawing.Point(364, 561)
        Me.btnReadMyFortune.Name = "btnReadMyFortune"
        Me.btnReadMyFortune.Size = New System.Drawing.Size(283, 55)
        Me.btnReadMyFortune.TabIndex = 2
        Me.btnReadMyFortune.Text = "Read My Fortune"
        Me.btnReadMyFortune.UseVisualStyleBackColor = False
        '
        'lblInstructionTarot
        '
        Me.lblInstructionTarot.BackColor = System.Drawing.Color.Black
        Me.lblInstructionTarot.Font = New System.Drawing.Font("Old English Text MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionTarot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblInstructionTarot.Location = New System.Drawing.Point(68, 20)
        Me.lblInstructionTarot.Name = "lblInstructionTarot"
        Me.lblInstructionTarot.Size = New System.Drawing.Size(901, 144)
        Me.lblInstructionTarot.TabIndex = 3
        Me.lblInstructionTarot.Text = "Welcome to the Tarot Reading Room. I will reveal your past, present and future. M" &
    "ay the alignment of stars give power to these cards and reveal all!"
        Me.lblInstructionTarot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrZoom
        '
        '
        'btnShuffle
        '
        Me.btnShuffle.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShuffle.Font = New System.Drawing.Font("Blackadder ITC", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShuffle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnShuffle.Location = New System.Drawing.Point(364, 47)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(283, 55)
        Me.btnShuffle.TabIndex = 5
        Me.btnShuffle.Text = "Shuffle"
        Me.btnShuffle.UseVisualStyleBackColor = False
        Me.btnShuffle.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(-1, -2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(39, 33)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.bluetable
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1024, 685)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnShuffle)
        Me.Controls.Add(Me.lblInstructionTarot)
        Me.Controls.Add(Me.btnReadMyFortune)
        Me.Controls.Add(Me.picDeck)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoading"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picDeck As PictureBox
    Private WithEvents btnReadMyFortune As Button
    Friend WithEvents lblInstructionTarot As Label
    Friend WithEvents tmrZoom As Timer
    Private WithEvents btnShuffle As Button
    Friend WithEvents btnCancel As Button
End Class
