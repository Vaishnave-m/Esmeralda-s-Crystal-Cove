<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLicenseAgreement
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
        Me.lstLicenseAgreement = New System.Windows.Forms.ListBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblAuthorizedOnly = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLicenseTitle = New System.Windows.Forms.Label()
        Me.lblDoYouAgree = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lstLicenseAgreement
        '
        Me.lstLicenseAgreement.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lstLicenseAgreement.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLicenseAgreement.HorizontalScrollbar = True
        Me.lstLicenseAgreement.ItemHeight = 18
        Me.lstLicenseAgreement.Items.AddRange(New Object() {"IMPORTANT, PLEASE READ CAREFULLY, THIS IS A LICENSE AND PRIVACY AGREEMENT ", "", "This SOFTWARE PRODUCT is protected by copyright laws and international copyright " &
                "treaties, as well as other intellectural property laws and treaties. This SOFTWA" &
                "RE PRODUCT is licensed, not sold.", "", "This software is only intended to be used on AUTHORIZED SYSTEMS only under the DI" &
                "RECT jurisdiction of the Government of Canada and its law enforcement agencies.", "", "", "End User License Agreement", "Please read this End-User License Agreement (""Agreement"") carefully before clicki" &
                "ng the ""I Agree"" button, ", "downloading or using Esmeralda's Crystal Cove (""Application""). By clicking the ""I" &
                " Agree"" button, ", "downloading or using the Application, you are agreeing to be bound by the terms a" &
                "nd conditions of this Agreement.", "If you do not agree to the terms of this Agreement, do not click on the ""I Agree""" &
                " button and do not ", "download or use the Application.", "", "License", "N&V inc. grants you a revocable, non-exclusive, non-transferable, limited license" &
                " to download, install and ", "use the Application solely for your personal, non-commercial purposes strictly in" &
                " accordance with the terms of this", "Agreement.", "", "Restrictions", "You agree not to, and you will not permit others to:", "a) license, sell, rent, lease, assign, distribute, transmit, host, outsource, dis" &
                "close or otherwise commercially exploit the ", "App ication or make the Application available to any third party. The Restriction" &
                "s section is for applying certain ", "restrictions on the app usage, e.g. user can't sell app, user can't distribute th" &
                "e app.", "", "Modifications to Application", "N&V inc. reserves the right to modify, suspend or discontinue, temporarily or per" &
                "manently, the Application or any ", "service to which it connects, with or without notice and without liability to you" &
                ". The Modifications to Application ", "section is for apps that will be updated or regularly maintained.", "", "Term and Termination", "This Agreement shall remain in effect until terminated by you or N&V inc. ", "N&V inc. may, in its sole discretion, at any time and for any or no reason, suspe" &
                "nd or terminate this Agreement with or ", "without prior notice. This Agreement will terminate immediately, without prior no" &
                "tice from N&V inc, in the event that you ", "fail to comply with any provision of this Agreement. You may also terminate this " &
                "Agreement by deleting the Application ", "and all copies thereof from your mobile device or from your desktop. Upon termina" &
                "tion of this Agreement, you shall ", "cease all use of the Application and delete all copies of the Application from yo" &
                "ur mobile device or from your desktop.", "", "Severability", "If any provision of this Agreement is held to be unenforceable or invalid, such p" &
                "rovision will be changed and interpreted ", "to accomplish the objectives of such provision to the greatest extent possible un" &
                "der applicable law and the remaining ", "provisions will continue in full force and effect.", "", "Amendments to this Agreement", "N&V inc. reserves the right, at its sole discretion, to modify or replace this Ag" &
                "reement at any time. If a revision is material ", "we will provide at least 30 days' notice prior to any new terms taking effect. Wh" &
                "at constitutes a material change will be ", "determined at our sole discretion.", "", "Contact Information", "If you have any questions about this Agreement, please contact us."})
        Me.lstLicenseAgreement.Location = New System.Drawing.Point(50, 136)
        Me.lstLicenseAgreement.Name = "lstLicenseAgreement"
        Me.lstLicenseAgreement.ScrollAlwaysVisible = True
        Me.lstLicenseAgreement.Size = New System.Drawing.Size(847, 346)
        Me.lstLicenseAgreement.TabIndex = 0
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.Font = New System.Drawing.Font("Blackadder ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.Purple
        Me.lblCompanyName.Location = New System.Drawing.Point(12, 9)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(209, 63)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.Text = "N&&V inc."
        '
        'lblAuthorizedOnly
        '
        Me.lblAuthorizedOnly.AutoSize = True
        Me.lblAuthorizedOnly.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthorizedOnly.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthorizedOnly.Location = New System.Drawing.Point(606, 22)
        Me.lblAuthorizedOnly.Name = "lblAuthorizedOnly"
        Me.lblAuthorizedOnly.Size = New System.Drawing.Size(325, 25)
        Me.lblAuthorizedOnly.TabIndex = 2
        Me.lblAuthorizedOnly.Text = "Authorized Personnel Only"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(-2, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(979, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "_________________________________________________________________________________" &
    "________________________________________________________________________________" &
    "_"
        '
        'lblLicenseTitle
        '
        Me.lblLicenseTitle.AutoSize = True
        Me.lblLicenseTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblLicenseTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicenseTitle.Location = New System.Drawing.Point(12, 89)
        Me.lblLicenseTitle.Name = "lblLicenseTitle"
        Me.lblLicenseTitle.Size = New System.Drawing.Size(236, 25)
        Me.lblLicenseTitle.TabIndex = 4
        Me.lblLicenseTitle.Text = "License Agreement"
        '
        'lblDoYouAgree
        '
        Me.lblDoYouAgree.AutoSize = True
        Me.lblDoYouAgree.BackColor = System.Drawing.Color.Transparent
        Me.lblDoYouAgree.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoYouAgree.Location = New System.Drawing.Point(14, 496)
        Me.lblDoYouAgree.Name = "lblDoYouAgree"
        Me.lblDoYouAgree.Size = New System.Drawing.Size(352, 18)
        Me.lblDoYouAgree.TabIndex = 5
        Me.lblDoYouAgree.Text = "Do You Accept the License Agreement?"
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.purple_backgrounds_18539_19006_hd_wallpapers
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Blackadder ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnNext.Location = New System.Drawing.Point(597, 506)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 59)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.purple_backgrounds_18539_19006_hd_wallpapers
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Blackadder ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnExit.Location = New System.Drawing.Point(771, 506)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 59)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.BackColor = System.Drawing.Color.Transparent
        Me.rdbNo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNo.Location = New System.Drawing.Point(63, 553)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(468, 22)
        Me.rdbNo.TabIndex = 8
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No, I do not Accept the License Agreement Terms."
        Me.rdbNo.UseVisualStyleBackColor = False
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.BackColor = System.Drawing.Color.Transparent
        Me.rdbYes.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbYes.Location = New System.Drawing.Point(63, 525)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(415, 22)
        Me.rdbYes.TabIndex = 9
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes, I Accept the License Agreement Terms."
        Me.rdbYes.UseVisualStyleBackColor = False
        '
        'frmLicenseAgreement
        '
        Me.BackgroundImage = Global.AhmedN_FinalProject.My.Resources.Resources.images2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(955, 589)
        Me.Controls.Add(Me.rdbYes)
        Me.Controls.Add(Me.rdbNo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblDoYouAgree)
        Me.Controls.Add(Me.lblLicenseTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAuthorizedOnly)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.lstLicenseAgreement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLicenseAgreement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLicenseAgreement As ListBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblAuthorizedOnly As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLicenseTitle As Label
    Friend WithEvents lblDoYouAgree As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents rdbYes As RadioButton
End Class

