<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Other
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
        Me.OtherNextButton = New System.Windows.Forms.Button()
        Me.OtherLabel = New System.Windows.Forms.Label()
        Me.OtherAnimalTypeInput = New System.Windows.Forms.TextBox()
        Me.OtherBreedLabel = New System.Windows.Forms.Label()
        Me.OtherTitleLabel = New System.Windows.Forms.Label()
        Me.OtherPanel = New System.Windows.Forms.Panel()
        Me.OtherNumVaccinationsInput = New System.Windows.Forms.TextBox()
        Me.OtherNumVaccinationsLabel = New System.Windows.Forms.Label()
        Me.OtherPreviousButton = New System.Windows.Forms.Button()
        Me.OtherVaccinationsInput = New System.Windows.Forms.TextBox()
        Me.OtherVaccinationsLabel = New System.Windows.Forms.Label()
        Me.OtherAnimalAppearanceLabel2 = New System.Windows.Forms.Label()
        Me.OtherAnimalAppearanceInput = New System.Windows.Forms.RichTextBox()
        Me.OtherAnimalAppearanceLabel1 = New System.Windows.Forms.Label()
        Me.OtherWeightInput = New System.Windows.Forms.TextBox()
        Me.OtherWeightLabel = New System.Windows.Forms.Label()
        Me.OtherLogo = New System.Windows.Forms.PictureBox()
        Me.OtherVaccinationsInputToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OtherNextToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OtherPanel.SuspendLayout()
        CType(Me.OtherLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OtherNextButton
        '
        Me.OtherNextButton.Location = New System.Drawing.Point(550, 463)
        Me.OtherNextButton.Name = "OtherNextButton"
        Me.OtherNextButton.Size = New System.Drawing.Size(120, 34)
        Me.OtherNextButton.TabIndex = 5
        Me.OtherNextButton.Text = "Next"
        Me.OtherNextToolTip.SetToolTip(Me.OtherNextButton, "Generate client report.")
        Me.OtherNextButton.UseVisualStyleBackColor = True
        '
        'OtherLabel
        '
        Me.OtherLabel.AutoSize = True
        Me.OtherLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherLabel.Location = New System.Drawing.Point(314, 12)
        Me.OtherLabel.Name = "OtherLabel"
        Me.OtherLabel.Size = New System.Drawing.Size(250, 24)
        Me.OtherLabel.TabIndex = 14
        Me.OtherLabel.Text = "Animal Information: Other"
        '
        'OtherAnimalTypeInput
        '
        Me.OtherAnimalTypeInput.Location = New System.Drawing.Point(444, 59)
        Me.OtherAnimalTypeInput.Name = "OtherAnimalTypeInput"
        Me.OtherAnimalTypeInput.Size = New System.Drawing.Size(226, 32)
        Me.OtherAnimalTypeInput.TabIndex = 0
        '
        'OtherBreedLabel
        '
        Me.OtherBreedLabel.AutoSize = True
        Me.OtherBreedLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherBreedLabel.Location = New System.Drawing.Point(200, 63)
        Me.OtherBreedLabel.Name = "OtherBreedLabel"
        Me.OtherBreedLabel.Size = New System.Drawing.Size(122, 24)
        Me.OtherBreedLabel.TabIndex = 2
        Me.OtherBreedLabel.Text = "Animal Type"
        '
        'OtherTitleLabel
        '
        Me.OtherTitleLabel.AutoSize = True
        Me.OtherTitleLabel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherTitleLabel.Location = New System.Drawing.Point(358, 32)
        Me.OtherTitleLabel.Name = "OtherTitleLabel"
        Me.OtherTitleLabel.Size = New System.Drawing.Size(345, 34)
        Me.OtherTitleLabel.TabIndex = 11
        Me.OtherTitleLabel.Text = "Animal Records System"
        Me.OtherTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OtherPanel
        '
        Me.OtherPanel.Controls.Add(Me.OtherNumVaccinationsInput)
        Me.OtherPanel.Controls.Add(Me.OtherNumVaccinationsLabel)
        Me.OtherPanel.Controls.Add(Me.OtherPreviousButton)
        Me.OtherPanel.Controls.Add(Me.OtherVaccinationsInput)
        Me.OtherPanel.Controls.Add(Me.OtherVaccinationsLabel)
        Me.OtherPanel.Controls.Add(Me.OtherAnimalAppearanceLabel2)
        Me.OtherPanel.Controls.Add(Me.OtherAnimalAppearanceInput)
        Me.OtherPanel.Controls.Add(Me.OtherAnimalAppearanceLabel1)
        Me.OtherPanel.Controls.Add(Me.OtherWeightInput)
        Me.OtherPanel.Controls.Add(Me.OtherWeightLabel)
        Me.OtherPanel.Controls.Add(Me.OtherNextButton)
        Me.OtherPanel.Controls.Add(Me.OtherLabel)
        Me.OtherPanel.Controls.Add(Me.OtherAnimalTypeInput)
        Me.OtherPanel.Controls.Add(Me.OtherBreedLabel)
        Me.OtherPanel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherPanel.Location = New System.Drawing.Point(17, 86)
        Me.OtherPanel.Name = "OtherPanel"
        Me.OtherPanel.Size = New System.Drawing.Size(849, 532)
        Me.OtherPanel.TabIndex = 12
        '
        'OtherNumVaccinationsInput
        '
        Me.OtherNumVaccinationsInput.Location = New System.Drawing.Point(444, 336)
        Me.OtherNumVaccinationsInput.Name = "OtherNumVaccinationsInput"
        Me.OtherNumVaccinationsInput.Size = New System.Drawing.Size(64, 32)
        Me.OtherNumVaccinationsInput.TabIndex = 3
        '
        'OtherNumVaccinationsLabel
        '
        Me.OtherNumVaccinationsLabel.AutoSize = True
        Me.OtherNumVaccinationsLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherNumVaccinationsLabel.Location = New System.Drawing.Point(200, 339)
        Me.OtherNumVaccinationsLabel.Name = "OtherNumVaccinationsLabel"
        Me.OtherNumVaccinationsLabel.Size = New System.Drawing.Size(229, 24)
        Me.OtherNumVaccinationsLabel.TabIndex = 16
        Me.OtherNumVaccinationsLabel.Text = "Number of Vaccinations"
        '
        'OtherPreviousButton
        '
        Me.OtherPreviousButton.Location = New System.Drawing.Point(204, 463)
        Me.OtherPreviousButton.Name = "OtherPreviousButton"
        Me.OtherPreviousButton.Size = New System.Drawing.Size(120, 34)
        Me.OtherPreviousButton.TabIndex = 6
        Me.OtherPreviousButton.Text = "Previous"
        Me.OtherPreviousButton.UseVisualStyleBackColor = True
        '
        'OtherVaccinationsInput
        '
        Me.OtherVaccinationsInput.Location = New System.Drawing.Point(444, 387)
        Me.OtherVaccinationsInput.Name = "OtherVaccinationsInput"
        Me.OtherVaccinationsInput.Size = New System.Drawing.Size(226, 32)
        Me.OtherVaccinationsInput.TabIndex = 4
        Me.OtherVaccinationsInputToolTip.SetToolTip(Me.OtherVaccinationsInput, "Enter vaccination names, each separated by commas.")
        '
        'OtherVaccinationsLabel
        '
        Me.OtherVaccinationsLabel.AutoSize = True
        Me.OtherVaccinationsLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherVaccinationsLabel.Location = New System.Drawing.Point(200, 391)
        Me.OtherVaccinationsLabel.Name = "OtherVaccinationsLabel"
        Me.OtherVaccinationsLabel.Size = New System.Drawing.Size(128, 24)
        Me.OtherVaccinationsLabel.TabIndex = 13
        Me.OtherVaccinationsLabel.Text = "Vaccinations"
        '
        'OtherAnimalAppearanceLabel2
        '
        Me.OtherAnimalAppearanceLabel2.AutoSize = True
        Me.OtherAnimalAppearanceLabel2.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherAnimalAppearanceLabel2.Location = New System.Drawing.Point(200, 226)
        Me.OtherAnimalAppearanceLabel2.Name = "OtherAnimalAppearanceLabel2"
        Me.OtherAnimalAppearanceLabel2.Size = New System.Drawing.Size(116, 24)
        Me.OtherAnimalAppearanceLabel2.TabIndex = 14
        Me.OtherAnimalAppearanceLabel2.Text = "Description"
        '
        'OtherAnimalAppearanceInput
        '
        Me.OtherAnimalAppearanceInput.Location = New System.Drawing.Point(444, 201)
        Me.OtherAnimalAppearanceInput.Name = "OtherAnimalAppearanceInput"
        Me.OtherAnimalAppearanceInput.Size = New System.Drawing.Size(226, 114)
        Me.OtherAnimalAppearanceInput.TabIndex = 2
        Me.OtherAnimalAppearanceInput.Text = ""
        '
        'OtherAnimalAppearanceLabel1
        '
        Me.OtherAnimalAppearanceLabel1.AutoSize = True
        Me.OtherAnimalAppearanceLabel1.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherAnimalAppearanceLabel1.Location = New System.Drawing.Point(200, 201)
        Me.OtherAnimalAppearanceLabel1.Name = "OtherAnimalAppearanceLabel1"
        Me.OtherAnimalAppearanceLabel1.Size = New System.Drawing.Size(188, 24)
        Me.OtherAnimalAppearanceLabel1.TabIndex = 13
        Me.OtherAnimalAppearanceLabel1.Text = "Animal Appearance"
        '
        'OtherWeightInput
        '
        Me.OtherWeightInput.Location = New System.Drawing.Point(444, 126)
        Me.OtherWeightInput.Name = "OtherWeightInput"
        Me.OtherWeightInput.Size = New System.Drawing.Size(64, 32)
        Me.OtherWeightInput.TabIndex = 1
        '
        'OtherWeightLabel
        '
        Me.OtherWeightLabel.AutoSize = True
        Me.OtherWeightLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.OtherWeightLabel.Location = New System.Drawing.Point(200, 129)
        Me.OtherWeightLabel.Name = "OtherWeightLabel"
        Me.OtherWeightLabel.Size = New System.Drawing.Size(76, 24)
        Me.OtherWeightLabel.TabIndex = 13
        Me.OtherWeightLabel.Text = "Weight"
        '
        'OtherLogo
        '
        Me.OtherLogo.Image = Global.FurryFriendsRecordsDatabase.My.Resources.Resources.FFLogo
        Me.OtherLogo.Location = New System.Drawing.Point(131, -1)
        Me.OtherLogo.Name = "OtherLogo"
        Me.OtherLogo.Size = New System.Drawing.Size(225, 98)
        Me.OtherLogo.TabIndex = 13
        Me.OtherLogo.TabStop = False
        '
        'Other
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(884, 648)
        Me.Controls.Add(Me.OtherLogo)
        Me.Controls.Add(Me.OtherTitleLabel)
        Me.Controls.Add(Me.OtherPanel)
        Me.Name = "Other"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Furry Friends Animal Records System | Animal Information"
        Me.OtherPanel.ResumeLayout(False)
        Me.OtherPanel.PerformLayout()
        CType(Me.OtherLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OtherNextButton As System.Windows.Forms.Button
    Friend WithEvents OtherLabel As System.Windows.Forms.Label
    Friend WithEvents OtherAnimalTypeInput As System.Windows.Forms.TextBox
    Friend WithEvents OtherBreedLabel As System.Windows.Forms.Label
    Friend WithEvents OtherTitleLabel As System.Windows.Forms.Label
    Friend WithEvents OtherPanel As System.Windows.Forms.Panel
    Friend WithEvents OtherWeightInput As System.Windows.Forms.TextBox
    Friend WithEvents OtherWeightLabel As System.Windows.Forms.Label
    Friend WithEvents OtherAnimalAppearanceInput As System.Windows.Forms.RichTextBox
    Friend WithEvents OtherAnimalAppearanceLabel1 As System.Windows.Forms.Label
    Friend WithEvents OtherVaccinationsInput As System.Windows.Forms.TextBox
    Friend WithEvents OtherVaccinationsLabel As System.Windows.Forms.Label
    Friend WithEvents OtherAnimalAppearanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents OtherPreviousButton As System.Windows.Forms.Button
    Friend WithEvents OtherLogo As System.Windows.Forms.PictureBox
    Friend WithEvents OtherNumVaccinationsInput As System.Windows.Forms.TextBox
    Friend WithEvents OtherNumVaccinationsLabel As System.Windows.Forms.Label
    Friend WithEvents OtherVaccinationsInputToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents OtherNextToolTip As System.Windows.Forms.ToolTip
End Class
