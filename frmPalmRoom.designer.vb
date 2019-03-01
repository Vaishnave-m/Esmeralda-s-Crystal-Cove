<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPalmRoom
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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblLineSelection = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNextLine = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picPalm = New System.Windows.Forms.PictureBox()
        Me.tmrPalm = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.picPalm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoEllipsis = True
        Me.lblInstruction.BackColor = System.Drawing.Color.Transparent
        Me.lblInstruction.Font = New System.Drawing.Font("Blackadder ITC", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.Gold
        Me.lblInstruction.Location = New System.Drawing.Point(32, 25)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(1085, 406)
        Me.lblInstruction.TabIndex = 20
        Me.lblInstruction.Text = "Welcome to Esmeralda's Palm Reading Room. Please give me your hand to see your de" &
    "stiny. "
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(26, 81)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(1111, 144)
        Me.lblDescription.TabIndex = 22
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblDescription.Visible = False
        '
        'lblLineSelection
        '
        Me.lblLineSelection.BackColor = System.Drawing.Color.Transparent
        Me.lblLineSelection.Font = New System.Drawing.Font("Bradley Hand ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineSelection.ForeColor = System.Drawing.Color.Gold
        Me.lblLineSelection.Location = New System.Drawing.Point(40, 215)
        Me.lblLineSelection.Name = "lblLineSelection"
        Me.lblLineSelection.Size = New System.Drawing.Size(1055, 49)
        Me.lblLineSelection.TabIndex = 25
        Me.lblLineSelection.Text = "Please select your head line"
        Me.lblLineSelection.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblLineSelection.Visible = False
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Purple
        Me.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnYes.Font = New System.Drawing.Font("Blackadder ITC", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.Gold
        Me.btnYes.Location = New System.Drawing.Point(427, 267)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(116, 55)
        Me.btnYes.TabIndex = 28
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        Me.btnYes.Visible = False
        '
        'btnNextLine
        '
        Me.btnNextLine.BackColor = System.Drawing.Color.Purple
        Me.btnNextLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextLine.Font = New System.Drawing.Font("Blackadder ITC", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextLine.ForeColor = System.Drawing.Color.Gold
        Me.btnNextLine.Location = New System.Drawing.Point(586, 267)
        Me.btnNextLine.Name = "btnNextLine"
        Me.btnNextLine.Size = New System.Drawing.Size(117, 55)
        Me.btnNextLine.TabIndex = 27
        Me.btnNextLine.Tag = ""
        Me.btnNextLine.Text = "Next"
        Me.btnNextLine.UseVisualStyleBackColor = False
        Me.btnNextLine.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Gold
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Blackadder ITC", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Purple
        Me.btnNext.Location = New System.Drawing.Point(481, 333)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(158, 57)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'picPalm
        '
        Me.picPalm.BackColor = System.Drawing.Color.Transparent
        Me.picPalm.Image = Global.AhmedN_FinalProject.My.Resources.Resources.basePalm
        Me.picPalm.Location = New System.Drawing.Point(168, 763)
        Me.picPalm.Name = "picPalm"
        Me.picPalm.Size = New System.Drawing.Size(710, 569)
        Me.picPalm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPalm.TabIndex = 29
        Me.picPalm.TabStop = False
        '
        'tmrPalm
        '
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
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmPalmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.woodentable
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1149, 758)
        Me.Controls.Add(Me.btnNextLine)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblLineSelection)
        Me.Controls.Add(Me.picPalm)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblInstruction)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPalmRoom"
        Me.Text = "Esmeralda's Crystal Cove"
        CType(Me.picPalm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblLineSelection As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNextLine As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents picPalm As PictureBox
    Friend WithEvents tmrPalm As Timer
    Friend WithEvents btnCancel As Button
End Class
