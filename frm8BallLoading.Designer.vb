<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm8BallLoading
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
        Me.prgLoading = New System.Windows.Forms.ProgressBar()
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.lblTip = New System.Windows.Forms.Label()
        Me.pctLoading = New System.Windows.Forms.PictureBox()
        CType(Me.pctLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prgLoading
        '
        Me.prgLoading.Location = New System.Drawing.Point(98, 314)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.Size = New System.Drawing.Size(639, 47)
        Me.prgLoading.TabIndex = 0
        '
        'tmrLoading
        '
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.BackColor = System.Drawing.Color.Transparent
        Me.lblTip.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblTip.Location = New System.Drawing.Point(187, 373)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(464, 23)
        Me.lblTip.TabIndex = 1
        Me.lblTip.Text = "Ask any Yes or No questions for the 8 Ball to answer!"
        '
        'pctLoading
        '
        Me.pctLoading.Image = Global.AhmedN_FinalProject.My.Resources.Resources._8pool_load
        Me.pctLoading.Location = New System.Drawing.Point(1, -90)
        Me.pctLoading.Name = "pctLoading"
        Me.pctLoading.Size = New System.Drawing.Size(824, 584)
        Me.pctLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLoading.TabIndex = 2
        Me.pctLoading.TabStop = False
        '
        'frm8BallLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources._8pool_load
        Me.ClientSize = New System.Drawing.Size(810, 433)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.prgLoading)
        Me.Controls.Add(Me.pctLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm8BallLoading"
        Me.Text = "frm8BallLoading"
        CType(Me.pctLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prgLoading As ProgressBar
    Friend WithEvents tmrLoading As Timer
    Friend WithEvents lblTip As Label
    Friend WithEvents pctLoading As PictureBox
End Class
