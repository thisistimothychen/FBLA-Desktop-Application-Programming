<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Arrival
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AnimalNameInput = New System.Windows.Forms.TextBox()
        Me.AnimalNameLabel = New System.Windows.Forms.Label()
        Me.NewArrivalPanel = New System.Windows.Forms.Panel()
        Me.NewArrivalPreviousButton = New System.Windows.Forms.Button()
        Me.NewArrivalNextButton = New System.Windows.Forms.Button()
        Me.MicrochippedGroupBox = New System.Windows.Forms.GroupBox()
        Me.MicrochippedYesButton = New System.Windows.Forms.RadioButton()
        Me.MicrochippedNoButton = New System.Windows.Forms.RadioButton()
        Me.NewArrivalLabel = New System.Windows.Forms.Label()
        Me.DateofMicrochippingLabel = New System.Windows.Forms.Label()
        Me.DateofMicrochippingInput = New System.Windows.Forms.DateTimePicker()
        Me.CageNumberInput = New System.Windows.Forms.TextBox()
        Me.RelinqPartyInput = New System.Windows.Forms.TextBox()
        Me.CageNumberLabel = New System.Windows.Forms.Label()
        Me.RelinqPartyLabel = New System.Windows.Forms.Label()
        Me.DateContactedLabel = New System.Windows.Forms.Label()
        Me.DateContactedInput = New System.Windows.Forms.DateTimePicker()
        Me.OwnerInput = New System.Windows.Forms.TextBox()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.ChipNumberInput = New System.Windows.Forms.TextBox()
        Me.ChipNumberLabel = New System.Windows.Forms.Label()
        Me.MicrochippedLabel = New System.Windows.Forms.Label()
        Me.DateofArrivalInput = New System.Windows.Forms.DateTimePicker()
        Me.DateofArrivalLabel = New System.Windows.Forms.Label()
        Me.DateofBirthInput = New System.Windows.Forms.DateTimePicker()
        Me.DateofBirthLabel = New System.Windows.Forms.Label()
        Me.AnimalAgeInput = New System.Windows.Forms.TextBox()
        Me.AnimalTypeInput = New System.Windows.Forms.ComboBox()
        Me.AnimalAgeLabel = New System.Windows.Forms.Label()
        Me.AnimalTypeLabel = New System.Windows.Forms.Label()
        Me.NewArrivalLogo = New System.Windows.Forms.PictureBox()
        Me.NewArrivalPanel.SuspendLayout()
        Me.MicrochippedGroupBox.SuspendLayout()
        CType(Me.NewArrivalLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(358, 53)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(345, 34)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "Animal Records System"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnimalNameInput
        '
        Me.AnimalNameInput.Location = New System.Drawing.Point(242, 52)
        Me.AnimalNameInput.Name = "AnimalNameInput"
        Me.AnimalNameInput.Size = New System.Drawing.Size(226, 32)
        Me.AnimalNameInput.TabIndex = 0
        '
        'AnimalNameLabel
        '
        Me.AnimalNameLabel.AutoSize = True
        Me.AnimalNameLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.AnimalNameLabel.Location = New System.Drawing.Point(15, 56)
        Me.AnimalNameLabel.Name = "AnimalNameLabel"
        Me.AnimalNameLabel.Size = New System.Drawing.Size(131, 24)
        Me.AnimalNameLabel.TabIndex = 2
        Me.AnimalNameLabel.Text = "Animal Name"
        '
        'NewArrivalPanel
        '
        Me.NewArrivalPanel.Controls.Add(Me.NewArrivalPreviousButton)
        Me.NewArrivalPanel.Controls.Add(Me.NewArrivalNextButton)
        Me.NewArrivalPanel.Controls.Add(Me.MicrochippedGroupBox)
        Me.NewArrivalPanel.Controls.Add(Me.NewArrivalLabel)
        Me.NewArrivalPanel.Controls.Add(Me.DateofMicrochippingLabel)
        Me.NewArrivalPanel.Controls.Add(Me.DateofMicrochippingInput)
        Me.NewArrivalPanel.Controls.Add(Me.CageNumberInput)
        Me.NewArrivalPanel.Controls.Add(Me.RelinqPartyInput)
        Me.NewArrivalPanel.Controls.Add(Me.CageNumberLabel)
        Me.NewArrivalPanel.Controls.Add(Me.RelinqPartyLabel)
        Me.NewArrivalPanel.Controls.Add(Me.DateContactedLabel)
        Me.NewArrivalPanel.Controls.Add(Me.DateContactedInput)
        Me.NewArrivalPanel.Controls.Add(Me.OwnerInput)
        Me.NewArrivalPanel.Controls.Add(Me.OwnerLabel)
        Me.NewArrivalPanel.Controls.Add(Me.ChipNumberInput)
        Me.NewArrivalPanel.Controls.Add(Me.ChipNumberLabel)
        Me.NewArrivalPanel.Controls.Add(Me.MicrochippedLabel)
        Me.NewArrivalPanel.Controls.Add(Me.DateofArrivalInput)
        Me.NewArrivalPanel.Controls.Add(Me.DateofArrivalLabel)
        Me.NewArrivalPanel.Controls.Add(Me.DateofBirthInput)
        Me.NewArrivalPanel.Controls.Add(Me.DateofBirthLabel)
        Me.NewArrivalPanel.Controls.Add(Me.AnimalAgeInput)
        Me.NewArrivalPanel.Controls.Add(Me.AnimalTypeInput)
        Me.NewArrivalPanel.Controls.Add(Me.AnimalAgeLabel)
        Me.NewArrivalPanel.Controls.Add(Me.AnimalNameInput)
        Me.NewArrivalPanel.Controls.Add(Me.AnimalTypeLabel)
        Me.NewArrivalPanel.Controls.Add(Me.AnimalNameLabel)
        Me.NewArrivalPanel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.NewArrivalPanel.Location = New System.Drawing.Point(17, 107)
        Me.NewArrivalPanel.Name = "NewArrivalPanel"
        Me.NewArrivalPanel.Size = New System.Drawing.Size(849, 532)
        Me.NewArrivalPanel.TabIndex = 6
        '
        'NewArrivalPreviousButton
        '
        Me.NewArrivalPreviousButton.Location = New System.Drawing.Point(19, 470)
        Me.NewArrivalPreviousButton.Name = "NewArrivalPreviousButton"
        Me.NewArrivalPreviousButton.Size = New System.Drawing.Size(120, 34)
        Me.NewArrivalPreviousButton.TabIndex = 14
        Me.NewArrivalPreviousButton.Text = "Previous"
        Me.NewArrivalPreviousButton.UseVisualStyleBackColor = True
        '
        'NewArrivalNextButton
        '
        Me.NewArrivalNextButton.Location = New System.Drawing.Point(722, 470)
        Me.NewArrivalNextButton.Name = "NewArrivalNextButton"
        Me.NewArrivalNextButton.Size = New System.Drawing.Size(120, 31)
        Me.NewArrivalNextButton.TabIndex = 13
        Me.NewArrivalNextButton.Text = "Next"
        Me.NewArrivalNextButton.UseVisualStyleBackColor = True
        '
        'MicrochippedGroupBox
        '
        Me.MicrochippedGroupBox.Controls.Add(Me.MicrochippedYesButton)
        Me.MicrochippedGroupBox.Controls.Add(Me.MicrochippedNoButton)
        Me.MicrochippedGroupBox.Location = New System.Drawing.Point(241, 244)
        Me.MicrochippedGroupBox.Name = "MicrochippedGroupBox"
        Me.MicrochippedGroupBox.Size = New System.Drawing.Size(201, 51)
        Me.MicrochippedGroupBox.TabIndex = 5
        Me.MicrochippedGroupBox.TabStop = False
        '
        'MicrochippedYesButton
        '
        Me.MicrochippedYesButton.AutoSize = True
        Me.MicrochippedYesButton.Checked = True
        Me.MicrochippedYesButton.Location = New System.Drawing.Point(22, 18)
        Me.MicrochippedYesButton.Name = "MicrochippedYesButton"
        Me.MicrochippedYesButton.Size = New System.Drawing.Size(63, 28)
        Me.MicrochippedYesButton.TabIndex = 5
        Me.MicrochippedYesButton.TabStop = True
        Me.MicrochippedYesButton.Text = "Yes"
        Me.MicrochippedYesButton.UseVisualStyleBackColor = True
        '
        'MicrochippedNoButton
        '
        Me.MicrochippedNoButton.AutoSize = True
        Me.MicrochippedNoButton.Location = New System.Drawing.Point(110, 18)
        Me.MicrochippedNoButton.Name = "MicrochippedNoButton"
        Me.MicrochippedNoButton.Size = New System.Drawing.Size(54, 28)
        Me.MicrochippedNoButton.TabIndex = 6
        Me.MicrochippedNoButton.Text = "No"
        Me.MicrochippedNoButton.UseVisualStyleBackColor = True
        '
        'NewArrivalLabel
        '
        Me.NewArrivalLabel.AutoSize = True
        Me.NewArrivalLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewArrivalLabel.Location = New System.Drawing.Point(406, 11)
        Me.NewArrivalLabel.Name = "NewArrivalLabel"
        Me.NewArrivalLabel.Size = New System.Drawing.Size(117, 24)
        Me.NewArrivalLabel.TabIndex = 14
        Me.NewArrivalLabel.Text = "New Arrival"
        '
        'DateofMicrochippingLabel
        '
        Me.DateofMicrochippingLabel.AutoSize = True
        Me.DateofMicrochippingLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DateofMicrochippingLabel.Location = New System.Drawing.Point(77, 350)
        Me.DateofMicrochippingLabel.Name = "DateofMicrochippingLabel"
        Me.DateofMicrochippingLabel.Size = New System.Drawing.Size(153, 17)
        Me.DateofMicrochippingLabel.TabIndex = 12
        Me.DateofMicrochippingLabel.Text = "Date of Micro-chipping"
        '
        'DateofMicrochippingInput
        '
        Me.DateofMicrochippingInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DateofMicrochippingInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateofMicrochippingInput.Location = New System.Drawing.Point(242, 346)
        Me.DateofMicrochippingInput.Name = "DateofMicrochippingInput"
        Me.DateofMicrochippingInput.Size = New System.Drawing.Size(104, 23)
        Me.DateofMicrochippingInput.TabIndex = 9
        '
        'CageNumberInput
        '
        Me.CageNumberInput.Location = New System.Drawing.Point(242, 428)
        Me.CageNumberInput.Name = "CageNumberInput"
        Me.CageNumberInput.Size = New System.Drawing.Size(226, 32)
        Me.CageNumberInput.TabIndex = 12
        '
        'RelinqPartyInput
        '
        Me.RelinqPartyInput.Location = New System.Drawing.Point(242, 385)
        Me.RelinqPartyInput.Name = "RelinqPartyInput"
        Me.RelinqPartyInput.Size = New System.Drawing.Size(226, 32)
        Me.RelinqPartyInput.TabIndex = 11
        '
        'CageNumberLabel
        '
        Me.CageNumberLabel.AutoSize = True
        Me.CageNumberLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CageNumberLabel.Location = New System.Drawing.Point(15, 432)
        Me.CageNumberLabel.Name = "CageNumberLabel"
        Me.CageNumberLabel.Size = New System.Drawing.Size(137, 24)
        Me.CageNumberLabel.TabIndex = 7
        Me.CageNumberLabel.Text = "Cage Number"
        '
        'RelinqPartyLabel
        '
        Me.RelinqPartyLabel.AutoSize = True
        Me.RelinqPartyLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.RelinqPartyLabel.Location = New System.Drawing.Point(15, 389)
        Me.RelinqPartyLabel.Name = "RelinqPartyLabel"
        Me.RelinqPartyLabel.Size = New System.Drawing.Size(189, 24)
        Me.RelinqPartyLabel.TabIndex = 7
        Me.RelinqPartyLabel.Text = "Relinquishing Party"
        '
        'DateContactedLabel
        '
        Me.DateContactedLabel.AutoSize = True
        Me.DateContactedLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DateContactedLabel.Location = New System.Drawing.Point(491, 350)
        Me.DateContactedLabel.Name = "DateContactedLabel"
        Me.DateContactedLabel.Size = New System.Drawing.Size(110, 17)
        Me.DateContactedLabel.TabIndex = 10
        Me.DateContactedLabel.Text = "Date Contacted"
        '
        'DateContactedInput
        '
        Me.DateContactedInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DateContactedInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateContactedInput.Location = New System.Drawing.Point(616, 346)
        Me.DateContactedInput.Name = "DateContactedInput"
        Me.DateContactedInput.Size = New System.Drawing.Size(104, 23)
        Me.DateContactedInput.TabIndex = 10
        '
        'OwnerInput
        '
        Me.OwnerInput.Location = New System.Drawing.Point(616, 300)
        Me.OwnerInput.Name = "OwnerInput"
        Me.OwnerInput.Size = New System.Drawing.Size(226, 32)
        Me.OwnerInput.TabIndex = 8
        '
        'OwnerLabel
        '
        Me.OwnerLabel.AutoSize = True
        Me.OwnerLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.OwnerLabel.Location = New System.Drawing.Point(491, 307)
        Me.OwnerLabel.Name = "OwnerLabel"
        Me.OwnerLabel.Size = New System.Drawing.Size(52, 17)
        Me.OwnerLabel.TabIndex = 9
        Me.OwnerLabel.Text = "Owner"
        '
        'ChipNumberInput
        '
        Me.ChipNumberInput.Location = New System.Drawing.Point(242, 301)
        Me.ChipNumberInput.Name = "ChipNumberInput"
        Me.ChipNumberInput.Size = New System.Drawing.Size(226, 32)
        Me.ChipNumberInput.TabIndex = 7
        '
        'ChipNumberLabel
        '
        Me.ChipNumberLabel.AutoSize = True
        Me.ChipNumberLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ChipNumberLabel.Location = New System.Drawing.Point(77, 308)
        Me.ChipNumberLabel.Name = "ChipNumberLabel"
        Me.ChipNumberLabel.Size = New System.Drawing.Size(94, 17)
        Me.ChipNumberLabel.TabIndex = 7
        Me.ChipNumberLabel.Text = "Chip Number"
        '
        'MicrochippedLabel
        '
        Me.MicrochippedLabel.AutoSize = True
        Me.MicrochippedLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.MicrochippedLabel.Location = New System.Drawing.Point(15, 264)
        Me.MicrochippedLabel.Name = "MicrochippedLabel"
        Me.MicrochippedLabel.Size = New System.Drawing.Size(141, 24)
        Me.MicrochippedLabel.TabIndex = 11
        Me.MicrochippedLabel.Text = "Micro-chipped"
        '
        'DateofArrivalInput
        '
        Me.DateofArrivalInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DateofArrivalInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateofArrivalInput.Location = New System.Drawing.Point(242, 225)
        Me.DateofArrivalInput.Name = "DateofArrivalInput"
        Me.DateofArrivalInput.Size = New System.Drawing.Size(104, 23)
        Me.DateofArrivalInput.TabIndex = 4
        '
        'DateofArrivalLabel
        '
        Me.DateofArrivalLabel.AutoSize = True
        Me.DateofArrivalLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DateofArrivalLabel.Location = New System.Drawing.Point(15, 225)
        Me.DateofArrivalLabel.Name = "DateofArrivalLabel"
        Me.DateofArrivalLabel.Size = New System.Drawing.Size(143, 24)
        Me.DateofArrivalLabel.TabIndex = 10
        Me.DateofArrivalLabel.Text = "Date of Arrival"
        '
        'DateofBirthInput
        '
        Me.DateofBirthInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DateofBirthInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateofBirthInput.Location = New System.Drawing.Point(242, 186)
        Me.DateofBirthInput.Name = "DateofBirthInput"
        Me.DateofBirthInput.Size = New System.Drawing.Size(104, 23)
        Me.DateofBirthInput.TabIndex = 3
        '
        'DateofBirthLabel
        '
        Me.DateofBirthLabel.AutoSize = True
        Me.DateofBirthLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DateofBirthLabel.Location = New System.Drawing.Point(15, 186)
        Me.DateofBirthLabel.Name = "DateofBirthLabel"
        Me.DateofBirthLabel.Size = New System.Drawing.Size(128, 24)
        Me.DateofBirthLabel.TabIndex = 7
        Me.DateofBirthLabel.Text = "Date of Birth"
        '
        'AnimalAgeInput
        '
        Me.AnimalAgeInput.Location = New System.Drawing.Point(242, 142)
        Me.AnimalAgeInput.MaxLength = 3
        Me.AnimalAgeInput.Name = "AnimalAgeInput"
        Me.AnimalAgeInput.Size = New System.Drawing.Size(49, 32)
        Me.AnimalAgeInput.TabIndex = 2
        '
        'AnimalTypeInput
        '
        Me.AnimalTypeInput.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.AnimalTypeInput.DisplayMember = "0"
        Me.AnimalTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AnimalTypeInput.FormattingEnabled = True
        Me.AnimalTypeInput.Items.AddRange(New Object() {"Dog", "Cat", "Other"})
        Me.AnimalTypeInput.Location = New System.Drawing.Point(242, 97)
        Me.AnimalTypeInput.MaxDropDownItems = 3
        Me.AnimalTypeInput.Name = "AnimalTypeInput"
        Me.AnimalTypeInput.Size = New System.Drawing.Size(121, 32)
        Me.AnimalTypeInput.TabIndex = 1
        Me.AnimalTypeInput.UseWaitCursor = True
        '
        'AnimalAgeLabel
        '
        Me.AnimalAgeLabel.AutoSize = True
        Me.AnimalAgeLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.AnimalAgeLabel.Location = New System.Drawing.Point(15, 146)
        Me.AnimalAgeLabel.Name = "AnimalAgeLabel"
        Me.AnimalAgeLabel.Size = New System.Drawing.Size(112, 24)
        Me.AnimalAgeLabel.TabIndex = 7
        Me.AnimalAgeLabel.Text = "Animal Age"
        '
        'AnimalTypeLabel
        '
        Me.AnimalTypeLabel.AutoSize = True
        Me.AnimalTypeLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.AnimalTypeLabel.Location = New System.Drawing.Point(15, 97)
        Me.AnimalTypeLabel.Name = "AnimalTypeLabel"
        Me.AnimalTypeLabel.Size = New System.Drawing.Size(122, 24)
        Me.AnimalTypeLabel.TabIndex = 7
        Me.AnimalTypeLabel.Text = "Animal Type"
        '
        'NewArrivalLogo
        '
        Me.NewArrivalLogo.Image = Global.FurryFriendsRecordsDatabase.My.Resources.Resources.FFLogo
        Me.NewArrivalLogo.Location = New System.Drawing.Point(134, 16)
        Me.NewArrivalLogo.Name = "NewArrivalLogo"
        Me.NewArrivalLogo.Size = New System.Drawing.Size(225, 98)
        Me.NewArrivalLogo.TabIndex = 14
        Me.NewArrivalLogo.TabStop = False
        '
        'New_Arrival
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(884, 666)
        Me.Controls.Add(Me.NewArrivalLogo)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.NewArrivalPanel)
        Me.Name = "New_Arrival"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Furry Friends Animal Records System | New Arrival Information"
        Me.NewArrivalPanel.ResumeLayout(False)
        Me.NewArrivalPanel.PerformLayout()
        Me.MicrochippedGroupBox.ResumeLayout(False)
        Me.MicrochippedGroupBox.PerformLayout()
        CType(Me.NewArrivalLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents AnimalNameInput As System.Windows.Forms.TextBox
    Friend WithEvents AnimalNameLabel As System.Windows.Forms.Label
    Friend WithEvents NewArrivalPanel As System.Windows.Forms.Panel
    Friend WithEvents AnimalTypeLabel As System.Windows.Forms.Label
    Friend WithEvents AnimalTypeInput As System.Windows.Forms.ComboBox
    Friend WithEvents AnimalAgeInput As System.Windows.Forms.TextBox
    Friend WithEvents AnimalAgeLabel As System.Windows.Forms.Label
    Friend WithEvents DateofBirthLabel As System.Windows.Forms.Label
    Friend WithEvents DateofArrivalInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateofArrivalLabel As System.Windows.Forms.Label
    Friend WithEvents DateofBirthInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents MicrochippedLabel As System.Windows.Forms.Label
    Friend WithEvents OwnerInput As System.Windows.Forms.TextBox
    Friend WithEvents OwnerLabel As System.Windows.Forms.Label
    Friend WithEvents ChipNumberInput As System.Windows.Forms.TextBox
    Friend WithEvents ChipNumberLabel As System.Windows.Forms.Label
    Friend WithEvents DateContactedLabel As System.Windows.Forms.Label
    Friend WithEvents DateContactedInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents RelinqPartyInput As System.Windows.Forms.TextBox
    Friend WithEvents RelinqPartyLabel As System.Windows.Forms.Label
    Friend WithEvents CageNumberInput As System.Windows.Forms.TextBox
    Friend WithEvents CageNumberLabel As System.Windows.Forms.Label
    Friend WithEvents DateofMicrochippingLabel As System.Windows.Forms.Label
    Friend WithEvents DateofMicrochippingInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents NewArrivalLabel As System.Windows.Forms.Label
    Friend WithEvents MicrochippedGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MicrochippedYesButton As System.Windows.Forms.RadioButton
    Friend WithEvents MicrochippedNoButton As System.Windows.Forms.RadioButton
    Friend WithEvents NewArrivalNextButton As System.Windows.Forms.Button
    Friend WithEvents NewArrivalPreviousButton As System.Windows.Forms.Button
    Friend WithEvents NewArrivalLogo As System.Windows.Forms.PictureBox
End Class
