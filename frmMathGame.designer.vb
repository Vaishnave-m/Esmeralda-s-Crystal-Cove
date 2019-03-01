<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathGame
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMathProblem = New System.Windows.Forms.Label()
        Me.lblRightOrWrong = New System.Windows.Forms.Label()
        Me.txtUserAnswer = New System.Windows.Forms.TextBox()
        Me.lblIInstruction = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.tmrCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.lblCountDown = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.picPotion = New System.Windows.Forms.PictureBox()
        Me.picFrog = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMathProblem
        '
        Me.lblMathProblem.AutoSize = True
        Me.lblMathProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMathProblem.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblMathProblem.Location = New System.Drawing.Point(363, 12)
        Me.lblMathProblem.Name = "lblMathProblem"
        Me.lblMathProblem.Size = New System.Drawing.Size(337, 108)
        Me.lblMathProblem.TabIndex = 1
        Me.lblMathProblem.Text = "Label1"
        Me.lblMathProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRightOrWrong
        '
        Me.lblRightOrWrong.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightOrWrong.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblRightOrWrong.Location = New System.Drawing.Point(346, 355)
        Me.lblRightOrWrong.Name = "lblRightOrWrong"
        Me.lblRightOrWrong.Size = New System.Drawing.Size(374, 37)
        Me.lblRightOrWrong.TabIndex = 3
        Me.lblRightOrWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserAnswer
        '
        Me.txtUserAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAnswer.Location = New System.Drawing.Point(366, 210)
        Me.txtUserAnswer.Name = "txtUserAnswer"
        Me.txtUserAnswer.Size = New System.Drawing.Size(334, 47)
        Me.txtUserAnswer.TabIndex = 4
        '
        'lblIInstruction
        '
        Me.lblIInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIInstruction.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblIInstruction.Location = New System.Drawing.Point(278, 117)
        Me.lblIInstruction.Name = "lblIInstruction"
        Me.lblIInstruction.Size = New System.Drawing.Size(509, 90)
        Me.lblIInstruction.TabIndex = 5
        Me.lblIInstruction.Text = "Enter 10 correct answers or else suffer the wrath of Esmeralda!"
        Me.lblIInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Transparent
        Me.btnEnter.Location = New System.Drawing.Point(489, 288)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(108, 47)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "OK"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'tmrCountDown
        '
        Me.tmrCountDown.Interval = 1200
        '
        'lblCountDown
        '
        Me.lblCountDown.AutoSize = True
        Me.lblCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountDown.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCountDown.Location = New System.Drawing.Point(13, 12)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(2, 75)
        Me.lblCountDown.TabIndex = 8
        '
        'lblWin
        '
        Me.lblWin.Font = New System.Drawing.Font("Colonna MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblWin.Location = New System.Drawing.Point(-3, -2)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(302, 171)
        Me.lblWin.TabIndex = 11
        Me.lblWin.Text = "You've received a potion item!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWin.Visible = False
        '
        'picPotion
        '
        Me.picPotion.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.picPotion.Image = Global.AhmedN_FinalProject.My.Resources.Resources.potion
        Me.picPotion.Location = New System.Drawing.Point(305, -2)
        Me.picPotion.Name = "picPotion"
        Me.picPotion.Size = New System.Drawing.Size(778, 472)
        Me.picPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPotion.TabIndex = 9
        Me.picPotion.TabStop = False
        Me.picPotion.Visible = False
        '
        'picFrog
        '
        Me.picFrog.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.picFrog.Image = Global.AhmedN_FinalProject.My.Resources.Resources.frog
        Me.picFrog.Location = New System.Drawing.Point(16, 360)
        Me.picFrog.Name = "picFrog"
        Me.picFrog.Size = New System.Drawing.Size(16, 16)
        Me.picFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFrog.TabIndex = 10
        Me.picFrog.TabStop = False
        Me.picFrog.Visible = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMainMenu.Location = New System.Drawing.Point(73, 172)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(126, 32)
        Me.btnMainMenu.TabIndex = 31
        Me.btnMainMenu.Text = "Main Room"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        Me.btnMainMenu.Visible = False
        '
        'frmMathGame
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(976, 442)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.picPotion)
        Me.Controls.Add(Me.picFrog)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblCountDown)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblIInstruction)
        Me.Controls.Add(Me.txtUserAnswer)
        Me.Controls.Add(Me.lblRightOrWrong)
        Me.Controls.Add(Me.lblMathProblem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMathGame"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picPotion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMathProblem As Label
    Friend WithEvents lblRightOrWrong As Label
    Friend WithEvents txtUserAnswer As TextBox
    Friend WithEvents lblIInstruction As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents tmrCountDown As Timer
    Friend WithEvents lblCountDown As Label
    Friend WithEvents picPotion As PictureBox
    Friend WithEvents picFrog As PictureBox
    Friend WithEvents lblWin As Label
    Friend WithEvents btnMainMenu As Button
End Class
