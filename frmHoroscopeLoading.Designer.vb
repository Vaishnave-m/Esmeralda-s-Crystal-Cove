<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoroscopeLoading
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
        Me.prgLoading = New System.Windows.Forms.ProgressBar()
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'prgLoading
        '
        Me.prgLoading.Location = New System.Drawing.Point(130, 386)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.Size = New System.Drawing.Size(553, 47)
        Me.prgLoading.TabIndex = 1
        '
        'tmrLoading
        '
        '
        'lblLoading
        '
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Font = New System.Drawing.Font("Modern No. 20", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblLoading.Location = New System.Drawing.Point(12, 29)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(788, 116)
        Me.lblLoading.TabIndex = 2
        Me.lblLoading.Text = "Esmeralda is aligning the constellations in the sun..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHoroscopeLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 454)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.prgLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHoroscopeLoading"
        Me.Text = "frmHoroscopeLoading"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prgLoading As ProgressBar
    Friend WithEvents tmrLoading As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblLoading As Label
End Class
