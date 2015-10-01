<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat
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
        Me.CatSpayedYesButton = New System.Windows.Forms.RadioButton()
        Me.CatSpayedNoButton = New System.Windows.Forms.RadioButton()
        Me.CatAnimalSexMaleButton = New System.Windows.Forms.RadioButton()
        Me.CatFleaTestYesButton = New System.Windows.Forms.RadioButton()
        Me.CatFleaTestNoButton = New System.Windows.Forms.RadioButton()
        Me.CatFelineLeukemiaTestPositiveButton = New System.Windows.Forms.RadioButton()
        Me.CatRabiesLabel = New System.Windows.Forms.CheckBox()
        Me.CatRabiesVaccinationInput = New System.Windows.Forms.DateTimePicker()
        Me.CatVaccinationsLabel = New System.Windows.Forms.Label()
        Me.CatDateoFelineLeukemiaTestLabel = New System.Windows.Forms.Label()
        Me.CatDateofFirstTreatmentLabel = New System.Windows.Forms.Label()
        Me.CatAnimalSexFemaleButton = New System.Windows.Forms.RadioButton()
        Me.CatDateofProcedureLabel = New System.Windows.Forms.Label()
        Me.CatDateofFelineLeukemiaTestInput = New System.Windows.Forms.DateTimePicker()
        Me.CatSpayedGroupBox = New System.Windows.Forms.GroupBox()
        Me.CatTitleLabel = New System.Windows.Forms.Label()
        Me.CatDateofFirstTreatmentInput = New System.Windows.Forms.DateTimePicker()
        Me.CatFleaTest = New System.Windows.Forms.Label()
        Me.CatNextButton = New System.Windows.Forms.Button()
        Me.CatAnimalSexLabel = New System.Windows.Forms.Label()
        Me.CatBreedLabel = New System.Windows.Forms.Label()
        Me.CatPanel = New System.Windows.Forms.Panel()
        Me.CatHairTypeLabel = New System.Windows.Forms.Label()
        Me.CatHairColorInput = New System.Windows.Forms.TextBox()
        Me.CatHairColorLabel = New System.Windows.Forms.Label()
        Me.CatWeightInput = New System.Windows.Forms.TextBox()
        Me.CatWeightLabel = New System.Windows.Forms.Label()
        Me.CatHairTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.CatLongHairButton = New System.Windows.Forms.RadioButton()
        Me.CatShortHairButton = New System.Windows.Forms.RadioButton()
        Me.CatBreedInput = New System.Windows.Forms.ComboBox()
        Me.CatPreviousButton = New System.Windows.Forms.Button()
        Me.CatDeclawedGroupBox = New System.Windows.Forms.GroupBox()
        Me.CatDeclawedYesButton = New System.Windows.Forms.RadioButton()
        Me.CatDeclawedNoButton = New System.Windows.Forms.RadioButton()
        Me.CatDeclawingGroupBox = New System.Windows.Forms.GroupBox()
        Me.CatDeclawingTwoButton = New System.Windows.Forms.RadioButton()
        Me.CatDeclawingFourButton = New System.Windows.Forms.RadioButton()
        Me.CatDeclawingLabel = New System.Windows.Forms.Label()
        Me.CatDeclawedLabel = New System.Windows.Forms.Label()
        Me.CatLabel = New System.Windows.Forms.Label()
        Me.CatDateofProcedureInput = New System.Windows.Forms.DateTimePicker()
        Me.CatFelineLeukemiaTestLabel = New System.Windows.Forms.Label()
        Me.CatSpayedLabel = New System.Windows.Forms.Label()
        Me.CatAnimalSexGroupBox = New System.Windows.Forms.GroupBox()
        Me.CatFleaTestGroupBox = New System.Windows.Forms.GroupBox()
        Me.CatFelineLeukemiaTestGroupBox = New System.Windows.Forms.GroupBox()
        Me.CatFelineLeukemiaTestNegativeButton = New System.Windows.Forms.RadioButton()
        Me.CatLogo = New System.Windows.Forms.PictureBox()
        Me.CatSpayedDateofProcedureToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CatDeclawedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CatRabiesVaccinationToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CatNextToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CatSpayedGroupBox.SuspendLayout()
        Me.CatPanel.SuspendLayout()
        Me.CatHairTypeGroupBox.SuspendLayout()
        Me.CatDeclawedGroupBox.SuspendLayout()
        Me.CatDeclawingGroupBox.SuspendLayout()
        Me.CatAnimalSexGroupBox.SuspendLayout()
        Me.CatFleaTestGroupBox.SuspendLayout()
        Me.CatFelineLeukemiaTestGroupBox.SuspendLayout()
        CType(Me.CatLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CatSpayedYesButton
        '
        Me.CatSpayedYesButton.AutoSize = True
        Me.CatSpayedYesButton.Location = New System.Drawing.Point(12, 18)
        Me.CatSpayedYesButton.Name = "CatSpayedYesButton"
        Me.CatSpayedYesButton.Size = New System.Drawing.Size(63, 28)
        Me.CatSpayedYesButton.TabIndex = 10
        Me.CatSpayedYesButton.Text = "Yes"
        Me.CatSpayedYesButton.UseVisualStyleBackColor = True
        '
        'CatSpayedNoButton
        '
        Me.CatSpayedNoButton.AutoSize = True
        Me.CatSpayedNoButton.Checked = True
        Me.CatSpayedNoButton.Location = New System.Drawing.Point(132, 18)
        Me.CatSpayedNoButton.Name = "CatSpayedNoButton"
        Me.CatSpayedNoButton.Size = New System.Drawing.Size(54, 28)
        Me.CatSpayedNoButton.TabIndex = 11
        Me.CatSpayedNoButton.TabStop = True
        Me.CatSpayedNoButton.Text = "No"
        Me.CatSpayedDateofProcedureToolTip.SetToolTip(Me.CatSpayedNoButton, "If not, the procedure must be scheduled.")
        Me.CatSpayedNoButton.UseVisualStyleBackColor = True
        '
        'CatAnimalSexMaleButton
        '
        Me.CatAnimalSexMaleButton.AutoSize = True
        Me.CatAnimalSexMaleButton.Checked = True
        Me.CatAnimalSexMaleButton.Location = New System.Drawing.Point(12, 17)
        Me.CatAnimalSexMaleButton.Name = "CatAnimalSexMaleButton"
        Me.CatAnimalSexMaleButton.Size = New System.Drawing.Size(73, 28)
        Me.CatAnimalSexMaleButton.TabIndex = 7
        Me.CatAnimalSexMaleButton.TabStop = True
        Me.CatAnimalSexMaleButton.Text = "Male"
        Me.CatAnimalSexMaleButton.UseVisualStyleBackColor = True
        '
        'CatFleaTestYesButton
        '
        Me.CatFleaTestYesButton.AutoSize = True
        Me.CatFleaTestYesButton.Checked = True
        Me.CatFleaTestYesButton.Location = New System.Drawing.Point(12, 18)
        Me.CatFleaTestYesButton.Name = "CatFleaTestYesButton"
        Me.CatFleaTestYesButton.Size = New System.Drawing.Size(63, 28)
        Me.CatFleaTestYesButton.TabIndex = 14
        Me.CatFleaTestYesButton.TabStop = True
        Me.CatFleaTestYesButton.Text = "Yes"
        Me.CatFleaTestYesButton.UseVisualStyleBackColor = True
        '
        'CatFleaTestNoButton
        '
        Me.CatFleaTestNoButton.AutoSize = True
        Me.CatFleaTestNoButton.Location = New System.Drawing.Point(132, 18)
        Me.CatFleaTestNoButton.Name = "CatFleaTestNoButton"
        Me.CatFleaTestNoButton.Size = New System.Drawing.Size(54, 28)
        Me.CatFleaTestNoButton.TabIndex = 15
        Me.CatFleaTestNoButton.Text = "No"
        Me.CatFleaTestNoButton.UseVisualStyleBackColor = True
        '
        'CatFelineLeukemiaTestPositiveButton
        '
        Me.CatFelineLeukemiaTestPositiveButton.AutoSize = True
        Me.CatFelineLeukemiaTestPositiveButton.Checked = True
        Me.CatFelineLeukemiaTestPositiveButton.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatFelineLeukemiaTestPositiveButton.Location = New System.Drawing.Point(12, 17)
        Me.CatFelineLeukemiaTestPositiveButton.Name = "CatFelineLeukemiaTestPositiveButton"
        Me.CatFelineLeukemiaTestPositiveButton.Size = New System.Drawing.Size(104, 28)
        Me.CatFelineLeukemiaTestPositiveButton.TabIndex = 24
        Me.CatFelineLeukemiaTestPositiveButton.TabStop = True
        Me.CatFelineLeukemiaTestPositiveButton.Text = "Positive"
        Me.CatFelineLeukemiaTestPositiveButton.UseVisualStyleBackColor = True
        '
        'CatRabiesLabel
        '
        Me.CatRabiesLabel.AutoSize = True
        Me.CatRabiesLabel.Location = New System.Drawing.Point(374, 605)
        Me.CatRabiesLabel.Name = "CatRabiesLabel"
        Me.CatRabiesLabel.Size = New System.Drawing.Size(95, 28)
        Me.CatRabiesLabel.TabIndex = 27
        Me.CatRabiesLabel.Text = "Rabies"
        Me.CatRabiesVaccinationToolTip.SetToolTip(Me.CatRabiesLabel, "If the cat has been vaccinated, please include the date of the Rabies vaccination" & _
        ".")
        Me.CatRabiesLabel.UseVisualStyleBackColor = True
        '
        'CatRabiesVaccinationInput
        '
        Me.CatRabiesVaccinationInput.Enabled = False
        Me.CatRabiesVaccinationInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.CatRabiesVaccinationInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CatRabiesVaccinationInput.Location = New System.Drawing.Point(534, 607)
        Me.CatRabiesVaccinationInput.Name = "CatRabiesVaccinationInput"
        Me.CatRabiesVaccinationInput.Size = New System.Drawing.Size(104, 23)
        Me.CatRabiesVaccinationInput.TabIndex = 28
        '
        'CatVaccinationsLabel
        '
        Me.CatVaccinationsLabel.AutoSize = True
        Me.CatVaccinationsLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatVaccinationsLabel.Location = New System.Drawing.Point(147, 606)
        Me.CatVaccinationsLabel.Name = "CatVaccinationsLabel"
        Me.CatVaccinationsLabel.Size = New System.Drawing.Size(128, 24)
        Me.CatVaccinationsLabel.TabIndex = 9
        Me.CatVaccinationsLabel.Text = "Vaccinations"
        '
        'CatDateoFelineLeukemiaTestLabel
        '
        Me.CatDateoFelineLeukemiaTestLabel.AutoSize = True
        Me.CatDateoFelineLeukemiaTestLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.CatDateoFelineLeukemiaTestLabel.Location = New System.Drawing.Point(371, 570)
        Me.CatDateoFelineLeukemiaTestLabel.Name = "CatDateoFelineLeukemiaTestLabel"
        Me.CatDateoFelineLeukemiaTestLabel.Size = New System.Drawing.Size(86, 17)
        Me.CatDateoFelineLeukemiaTestLabel.TabIndex = 14
        Me.CatDateoFelineLeukemiaTestLabel.Text = "Date of Test"
        '
        'CatDateofFirstTreatmentLabel
        '
        Me.CatDateofFirstTreatmentLabel.AutoSize = True
        Me.CatDateofFirstTreatmentLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.CatDateofFirstTreatmentLabel.Location = New System.Drawing.Point(370, 400)
        Me.CatDateofFirstTreatmentLabel.Name = "CatDateofFirstTreatmentLabel"
        Me.CatDateofFirstTreatmentLabel.Size = New System.Drawing.Size(158, 17)
        Me.CatDateofFirstTreatmentLabel.TabIndex = 14
        Me.CatDateofFirstTreatmentLabel.Text = "Date of First Treatment"
        '
        'CatAnimalSexFemaleButton
        '
        Me.CatAnimalSexFemaleButton.AutoSize = True
        Me.CatAnimalSexFemaleButton.Location = New System.Drawing.Point(132, 17)
        Me.CatAnimalSexFemaleButton.Name = "CatAnimalSexFemaleButton"
        Me.CatAnimalSexFemaleButton.Size = New System.Drawing.Size(97, 28)
        Me.CatAnimalSexFemaleButton.TabIndex = 8
        Me.CatAnimalSexFemaleButton.Text = "Female"
        Me.CatAnimalSexFemaleButton.UseVisualStyleBackColor = True
        '
        'CatDateofProcedureLabel
        '
        Me.CatDateofProcedureLabel.AutoSize = True
        Me.CatDateofProcedureLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.CatDateofProcedureLabel.Location = New System.Drawing.Point(371, 320)
        Me.CatDateofProcedureLabel.Name = "CatDateofProcedureLabel"
        Me.CatDateofProcedureLabel.Size = New System.Drawing.Size(127, 17)
        Me.CatDateofProcedureLabel.TabIndex = 12
        Me.CatDateofProcedureLabel.Text = "Date of Procedure"
        '
        'CatDateofFelineLeukemiaTestInput
        '
        Me.CatDateofFelineLeukemiaTestInput.CalendarTitleBackColor = System.Drawing.SystemColors.WindowText
        Me.CatDateofFelineLeukemiaTestInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.CatDateofFelineLeukemiaTestInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CatDateofFelineLeukemiaTestInput.Location = New System.Drawing.Point(534, 567)
        Me.CatDateofFelineLeukemiaTestInput.Name = "CatDateofFelineLeukemiaTestInput"
        Me.CatDateofFelineLeukemiaTestInput.Size = New System.Drawing.Size(104, 23)
        Me.CatDateofFelineLeukemiaTestInput.TabIndex = 26
        '
        'CatSpayedGroupBox
        '
        Me.CatSpayedGroupBox.Controls.Add(Me.CatSpayedYesButton)
        Me.CatSpayedGroupBox.Controls.Add(Me.CatSpayedNoButton)
        Me.CatSpayedGroupBox.Location = New System.Drawing.Point(373, 264)
        Me.CatSpayedGroupBox.Name = "CatSpayedGroupBox"
        Me.CatSpayedGroupBox.Size = New System.Drawing.Size(201, 51)
        Me.CatSpayedGroupBox.TabIndex = 9
        Me.CatSpayedGroupBox.TabStop = False
        '
        'CatTitleLabel
        '
        Me.CatTitleLabel.AutoSize = True
        Me.CatTitleLabel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatTitleLabel.Location = New System.Drawing.Point(358, 32)
        Me.CatTitleLabel.Name = "CatTitleLabel"
        Me.CatTitleLabel.Size = New System.Drawing.Size(345, 34)
        Me.CatTitleLabel.TabIndex = 9
        Me.CatTitleLabel.Text = "Animal Records System"
        Me.CatTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CatDateofFirstTreatmentInput
        '
        Me.CatDateofFirstTreatmentInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.CatDateofFirstTreatmentInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CatDateofFirstTreatmentInput.Location = New System.Drawing.Point(534, 396)
        Me.CatDateofFirstTreatmentInput.Name = "CatDateofFirstTreatmentInput"
        Me.CatDateofFirstTreatmentInput.Size = New System.Drawing.Size(104, 23)
        Me.CatDateofFirstTreatmentInput.TabIndex = 16
        '
        'CatFleaTest
        '
        Me.CatFleaTest.AutoSize = True
        Me.CatFleaTest.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatFleaTest.Location = New System.Drawing.Point(147, 362)
        Me.CatFleaTest.Name = "CatFleaTest"
        Me.CatFleaTest.Size = New System.Drawing.Size(96, 24)
        Me.CatFleaTest.TabIndex = 19
        Me.CatFleaTest.Text = "Flea Test"
        '
        'CatNextButton
        '
        Me.CatNextButton.Location = New System.Drawing.Point(576, 682)
        Me.CatNextButton.Name = "CatNextButton"
        Me.CatNextButton.Size = New System.Drawing.Size(120, 34)
        Me.CatNextButton.TabIndex = 29
        Me.CatNextButton.Text = "Next"
        Me.CatNextToolTip.SetToolTip(Me.CatNextButton, "Generate client report.")
        Me.CatNextButton.UseVisualStyleBackColor = True
        '
        'CatAnimalSexLabel
        '
        Me.CatAnimalSexLabel.AutoSize = True
        Me.CatAnimalSexLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatAnimalSexLabel.Location = New System.Drawing.Point(147, 232)
        Me.CatAnimalSexLabel.Name = "CatAnimalSexLabel"
        Me.CatAnimalSexLabel.Size = New System.Drawing.Size(113, 24)
        Me.CatAnimalSexLabel.TabIndex = 7
        Me.CatAnimalSexLabel.Text = "Animal Sex"
        '
        'CatBreedLabel
        '
        Me.CatBreedLabel.AutoSize = True
        Me.CatBreedLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatBreedLabel.Location = New System.Drawing.Point(147, 57)
        Me.CatBreedLabel.Name = "CatBreedLabel"
        Me.CatBreedLabel.Size = New System.Drawing.Size(66, 24)
        Me.CatBreedLabel.TabIndex = 2
        Me.CatBreedLabel.Text = "Breed"
        '
        'CatPanel
        '
        Me.CatPanel.Controls.Add(Me.CatHairTypeLabel)
        Me.CatPanel.Controls.Add(Me.CatHairColorInput)
        Me.CatPanel.Controls.Add(Me.CatHairColorLabel)
        Me.CatPanel.Controls.Add(Me.CatWeightInput)
        Me.CatPanel.Controls.Add(Me.CatWeightLabel)
        Me.CatPanel.Controls.Add(Me.CatHairTypeGroupBox)
        Me.CatPanel.Controls.Add(Me.CatBreedInput)
        Me.CatPanel.Controls.Add(Me.CatPreviousButton)
        Me.CatPanel.Controls.Add(Me.CatDeclawedGroupBox)
        Me.CatPanel.Controls.Add(Me.CatDeclawingGroupBox)
        Me.CatPanel.Controls.Add(Me.CatDeclawingLabel)
        Me.CatPanel.Controls.Add(Me.CatDeclawedLabel)
        Me.CatPanel.Controls.Add(Me.CatRabiesLabel)
        Me.CatPanel.Controls.Add(Me.CatRabiesVaccinationInput)
        Me.CatPanel.Controls.Add(Me.CatVaccinationsLabel)
        Me.CatPanel.Controls.Add(Me.CatDateoFelineLeukemiaTestLabel)
        Me.CatPanel.Controls.Add(Me.CatDateofFirstTreatmentLabel)
        Me.CatPanel.Controls.Add(Me.CatDateofFelineLeukemiaTestInput)
        Me.CatPanel.Controls.Add(Me.CatDateofFirstTreatmentInput)
        Me.CatPanel.Controls.Add(Me.CatSpayedGroupBox)
        Me.CatPanel.Controls.Add(Me.CatFleaTest)
        Me.CatPanel.Controls.Add(Me.CatNextButton)
        Me.CatPanel.Controls.Add(Me.CatLabel)
        Me.CatPanel.Controls.Add(Me.CatDateofProcedureLabel)
        Me.CatPanel.Controls.Add(Me.CatDateofProcedureInput)
        Me.CatPanel.Controls.Add(Me.CatFelineLeukemiaTestLabel)
        Me.CatPanel.Controls.Add(Me.CatSpayedLabel)
        Me.CatPanel.Controls.Add(Me.CatAnimalSexLabel)
        Me.CatPanel.Controls.Add(Me.CatBreedLabel)
        Me.CatPanel.Controls.Add(Me.CatAnimalSexGroupBox)
        Me.CatPanel.Controls.Add(Me.CatFleaTestGroupBox)
        Me.CatPanel.Controls.Add(Me.CatFelineLeukemiaTestGroupBox)
        Me.CatPanel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatPanel.Location = New System.Drawing.Point(17, 86)
        Me.CatPanel.Name = "CatPanel"
        Me.CatPanel.Size = New System.Drawing.Size(849, 764)
        Me.CatPanel.TabIndex = 10
        '
        'CatHairTypeLabel
        '
        Me.CatHairTypeLabel.AutoSize = True
        Me.CatHairTypeLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatHairTypeLabel.Location = New System.Drawing.Point(147, 181)
        Me.CatHairTypeLabel.Name = "CatHairTypeLabel"
        Me.CatHairTypeLabel.Size = New System.Drawing.Size(123, 24)
        Me.CatHairTypeLabel.TabIndex = 40
        Me.CatHairTypeLabel.Text = "Type of Hair"
        '
        'CatHairColorInput
        '
        Me.CatHairColorInput.Location = New System.Drawing.Point(373, 134)
        Me.CatHairColorInput.Name = "CatHairColorInput"
        Me.CatHairColorInput.Size = New System.Drawing.Size(226, 32)
        Me.CatHairColorInput.TabIndex = 2
        '
        'CatHairColorLabel
        '
        Me.CatHairColorLabel.AutoSize = True
        Me.CatHairColorLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatHairColorLabel.Location = New System.Drawing.Point(147, 137)
        Me.CatHairColorLabel.Name = "CatHairColorLabel"
        Me.CatHairColorLabel.Size = New System.Drawing.Size(104, 24)
        Me.CatHairColorLabel.TabIndex = 38
        Me.CatHairColorLabel.Text = "Hair Color"
        '
        'CatWeightInput
        '
        Me.CatWeightInput.Location = New System.Drawing.Point(373, 93)
        Me.CatWeightInput.MaxLength = 3
        Me.CatWeightInput.Name = "CatWeightInput"
        Me.CatWeightInput.Size = New System.Drawing.Size(49, 32)
        Me.CatWeightInput.TabIndex = 1
        '
        'CatWeightLabel
        '
        Me.CatWeightLabel.AutoSize = True
        Me.CatWeightLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatWeightLabel.Location = New System.Drawing.Point(147, 96)
        Me.CatWeightLabel.Name = "CatWeightLabel"
        Me.CatWeightLabel.Size = New System.Drawing.Size(76, 24)
        Me.CatWeightLabel.TabIndex = 36
        Me.CatWeightLabel.Text = "Weight"
        '
        'CatHairTypeGroupBox
        '
        Me.CatHairTypeGroupBox.Controls.Add(Me.CatLongHairButton)
        Me.CatHairTypeGroupBox.Controls.Add(Me.CatShortHairButton)
        Me.CatHairTypeGroupBox.Location = New System.Drawing.Point(373, 163)
        Me.CatHairTypeGroupBox.Name = "CatHairTypeGroupBox"
        Me.CatHairTypeGroupBox.Size = New System.Drawing.Size(274, 51)
        Me.CatHairTypeGroupBox.TabIndex = 3
        Me.CatHairTypeGroupBox.TabStop = False
        '
        'CatLongHairButton
        '
        Me.CatLongHairButton.AutoSize = True
        Me.CatLongHairButton.Checked = True
        Me.CatLongHairButton.Location = New System.Drawing.Point(12, 17)
        Me.CatLongHairButton.Name = "CatLongHairButton"
        Me.CatLongHairButton.Size = New System.Drawing.Size(74, 28)
        Me.CatLongHairButton.TabIndex = 4
        Me.CatLongHairButton.TabStop = True
        Me.CatLongHairButton.Text = "Long"
        Me.CatLongHairButton.UseVisualStyleBackColor = True
        '
        'CatShortHairButton
        '
        Me.CatShortHairButton.AutoSize = True
        Me.CatShortHairButton.Location = New System.Drawing.Point(132, 17)
        Me.CatShortHairButton.Name = "CatShortHairButton"
        Me.CatShortHairButton.Size = New System.Drawing.Size(78, 28)
        Me.CatShortHairButton.TabIndex = 5
        Me.CatShortHairButton.Text = "Short"
        Me.CatShortHairButton.UseVisualStyleBackColor = True
        '
        'CatBreedInput
        '
        Me.CatBreedInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CatBreedInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CatBreedInput.DropDownHeight = 240
        Me.CatBreedInput.FormattingEnabled = True
        Me.CatBreedInput.IntegralHeight = False
        Me.CatBreedInput.Location = New System.Drawing.Point(374, 49)
        Me.CatBreedInput.Name = "CatBreedInput"
        Me.CatBreedInput.Size = New System.Drawing.Size(261, 32)
        Me.CatBreedInput.TabIndex = 0
        '
        'CatPreviousButton
        '
        Me.CatPreviousButton.Location = New System.Drawing.Point(151, 682)
        Me.CatPreviousButton.Name = "CatPreviousButton"
        Me.CatPreviousButton.Size = New System.Drawing.Size(120, 34)
        Me.CatPreviousButton.TabIndex = 30
        Me.CatPreviousButton.Text = "Previous"
        Me.CatPreviousButton.UseVisualStyleBackColor = True
        '
        'CatDeclawedGroupBox
        '
        Me.CatDeclawedGroupBox.Controls.Add(Me.CatDeclawedYesButton)
        Me.CatDeclawedGroupBox.Controls.Add(Me.CatDeclawedNoButton)
        Me.CatDeclawedGroupBox.Location = New System.Drawing.Point(373, 423)
        Me.CatDeclawedGroupBox.Name = "CatDeclawedGroupBox"
        Me.CatDeclawedGroupBox.Size = New System.Drawing.Size(201, 51)
        Me.CatDeclawedGroupBox.TabIndex = 17
        Me.CatDeclawedGroupBox.TabStop = False
        '
        'CatDeclawedYesButton
        '
        Me.CatDeclawedYesButton.AutoSize = True
        Me.CatDeclawedYesButton.Location = New System.Drawing.Point(12, 18)
        Me.CatDeclawedYesButton.Name = "CatDeclawedYesButton"
        Me.CatDeclawedYesButton.Size = New System.Drawing.Size(63, 28)
        Me.CatDeclawedYesButton.TabIndex = 18
        Me.CatDeclawedYesButton.Text = "Yes"
        Me.CatDeclawedYesButton.UseVisualStyleBackColor = True
        '
        'CatDeclawedNoButton
        '
        Me.CatDeclawedNoButton.AutoSize = True
        Me.CatDeclawedNoButton.Checked = True
        Me.CatDeclawedNoButton.Location = New System.Drawing.Point(132, 18)
        Me.CatDeclawedNoButton.Name = "CatDeclawedNoButton"
        Me.CatDeclawedNoButton.Size = New System.Drawing.Size(54, 28)
        Me.CatDeclawedNoButton.TabIndex = 19
        Me.CatDeclawedNoButton.TabStop = True
        Me.CatDeclawedNoButton.Text = "No"
        Me.CatDeclawedToolTip.SetToolTip(Me.CatDeclawedNoButton, "When a cat is adopted, the new owners are given the option of having the cat decl" & _
        "awed.")
        Me.CatDeclawedNoButton.UseVisualStyleBackColor = True
        '
        'CatDeclawingGroupBox
        '
        Me.CatDeclawingGroupBox.Controls.Add(Me.CatDeclawingTwoButton)
        Me.CatDeclawingGroupBox.Controls.Add(Me.CatDeclawingFourButton)
        Me.CatDeclawingGroupBox.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.CatDeclawingGroupBox.Location = New System.Drawing.Point(453, 469)
        Me.CatDeclawingGroupBox.Name = "CatDeclawingGroupBox"
        Me.CatDeclawingGroupBox.Size = New System.Drawing.Size(152, 41)
        Me.CatDeclawingGroupBox.TabIndex = 20
        Me.CatDeclawingGroupBox.TabStop = False
        '
        'CatDeclawingTwoButton
        '
        Me.CatDeclawingTwoButton.AutoSize = True
        Me.CatDeclawingTwoButton.Checked = True
        Me.CatDeclawingTwoButton.Location = New System.Drawing.Point(15, 14)
        Me.CatDeclawingTwoButton.Name = "CatDeclawingTwoButton"
        Me.CatDeclawingTwoButton.Size = New System.Drawing.Size(53, 21)
        Me.CatDeclawingTwoButton.TabIndex = 21
        Me.CatDeclawingTwoButton.TabStop = True
        Me.CatDeclawingTwoButton.Text = "Two"
        Me.CatDeclawingTwoButton.UseVisualStyleBackColor = True
        '
        'CatDeclawingFourButton
        '
        Me.CatDeclawingFourButton.AutoSize = True
        Me.CatDeclawingFourButton.Location = New System.Drawing.Point(84, 14)
        Me.CatDeclawingFourButton.Name = "CatDeclawingFourButton"
        Me.CatDeclawingFourButton.Size = New System.Drawing.Size(56, 21)
        Me.CatDeclawingFourButton.TabIndex = 22
        Me.CatDeclawingFourButton.Text = "Four"
        Me.CatDeclawingFourButton.UseVisualStyleBackColor = True
        '
        'CatDeclawingLabel
        '
        Me.CatDeclawingLabel.AutoSize = True
        Me.CatDeclawingLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.CatDeclawingLabel.Location = New System.Drawing.Point(370, 484)
        Me.CatDeclawingLabel.Name = "CatDeclawingLabel"
        Me.CatDeclawingLabel.Size = New System.Drawing.Size(76, 17)
        Me.CatDeclawingLabel.TabIndex = 23
        Me.CatDeclawingLabel.Text = "Declawing"
        '
        'CatDeclawedLabel
        '
        Me.CatDeclawedLabel.AutoSize = True
        Me.CatDeclawedLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatDeclawedLabel.Location = New System.Drawing.Point(147, 444)
        Me.CatDeclawedLabel.Name = "CatDeclawedLabel"
        Me.CatDeclawedLabel.Size = New System.Drawing.Size(102, 24)
        Me.CatDeclawedLabel.TabIndex = 21
        Me.CatDeclawedLabel.Text = "Declawed"
        '
        'CatLabel
        '
        Me.CatLabel.AutoSize = True
        Me.CatLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatLabel.Location = New System.Drawing.Point(328, 12)
        Me.CatLabel.Name = "CatLabel"
        Me.CatLabel.Size = New System.Drawing.Size(230, 24)
        Me.CatLabel.TabIndex = 14
        Me.CatLabel.Text = "Animal Information: Cat"
        '
        'CatDateofProcedureInput
        '
        Me.CatDateofProcedureInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.CatDateofProcedureInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CatDateofProcedureInput.Location = New System.Drawing.Point(534, 317)
        Me.CatDateofProcedureInput.Name = "CatDateofProcedureInput"
        Me.CatDateofProcedureInput.Size = New System.Drawing.Size(104, 23)
        Me.CatDateofProcedureInput.TabIndex = 12
        '
        'CatFelineLeukemiaTestLabel
        '
        Me.CatFelineLeukemiaTestLabel.AutoSize = True
        Me.CatFelineLeukemiaTestLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatFelineLeukemiaTestLabel.Location = New System.Drawing.Point(147, 533)
        Me.CatFelineLeukemiaTestLabel.Name = "CatFelineLeukemiaTestLabel"
        Me.CatFelineLeukemiaTestLabel.Size = New System.Drawing.Size(208, 24)
        Me.CatFelineLeukemiaTestLabel.TabIndex = 7
        Me.CatFelineLeukemiaTestLabel.Text = "Feline Leukemia Test"
        '
        'CatSpayedLabel
        '
        Me.CatSpayedLabel.AutoSize = True
        Me.CatSpayedLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatSpayedLabel.Location = New System.Drawing.Point(147, 281)
        Me.CatSpayedLabel.Name = "CatSpayedLabel"
        Me.CatSpayedLabel.Size = New System.Drawing.Size(172, 24)
        Me.CatSpayedLabel.TabIndex = 7
        Me.CatSpayedLabel.Text = "Spayed/Neutered"
        '
        'CatAnimalSexGroupBox
        '
        Me.CatAnimalSexGroupBox.Controls.Add(Me.CatAnimalSexMaleButton)
        Me.CatAnimalSexGroupBox.Controls.Add(Me.CatAnimalSexFemaleButton)
        Me.CatAnimalSexGroupBox.Location = New System.Drawing.Point(373, 214)
        Me.CatAnimalSexGroupBox.Name = "CatAnimalSexGroupBox"
        Me.CatAnimalSexGroupBox.Size = New System.Drawing.Size(262, 51)
        Me.CatAnimalSexGroupBox.TabIndex = 6
        Me.CatAnimalSexGroupBox.TabStop = False
        '
        'CatFleaTestGroupBox
        '
        Me.CatFleaTestGroupBox.Controls.Add(Me.CatFleaTestYesButton)
        Me.CatFleaTestGroupBox.Controls.Add(Me.CatFleaTestNoButton)
        Me.CatFleaTestGroupBox.Location = New System.Drawing.Point(373, 341)
        Me.CatFleaTestGroupBox.Name = "CatFleaTestGroupBox"
        Me.CatFleaTestGroupBox.Size = New System.Drawing.Size(201, 51)
        Me.CatFleaTestGroupBox.TabIndex = 13
        Me.CatFleaTestGroupBox.TabStop = False
        '
        'CatFelineLeukemiaTestGroupBox
        '
        Me.CatFelineLeukemiaTestGroupBox.Controls.Add(Me.CatFelineLeukemiaTestPositiveButton)
        Me.CatFelineLeukemiaTestGroupBox.Controls.Add(Me.CatFelineLeukemiaTestNegativeButton)
        Me.CatFelineLeukemiaTestGroupBox.Location = New System.Drawing.Point(373, 514)
        Me.CatFelineLeukemiaTestGroupBox.Name = "CatFelineLeukemiaTestGroupBox"
        Me.CatFelineLeukemiaTestGroupBox.Size = New System.Drawing.Size(262, 51)
        Me.CatFelineLeukemiaTestGroupBox.TabIndex = 23
        Me.CatFelineLeukemiaTestGroupBox.TabStop = False
        '
        'CatFelineLeukemiaTestNegativeButton
        '
        Me.CatFelineLeukemiaTestNegativeButton.AutoSize = True
        Me.CatFelineLeukemiaTestNegativeButton.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.CatFelineLeukemiaTestNegativeButton.Location = New System.Drawing.Point(132, 17)
        Me.CatFelineLeukemiaTestNegativeButton.Name = "CatFelineLeukemiaTestNegativeButton"
        Me.CatFelineLeukemiaTestNegativeButton.Size = New System.Drawing.Size(111, 28)
        Me.CatFelineLeukemiaTestNegativeButton.TabIndex = 25
        Me.CatFelineLeukemiaTestNegativeButton.Text = "Negative"
        Me.CatFelineLeukemiaTestNegativeButton.UseVisualStyleBackColor = True
        '
        'CatLogo
        '
        Me.CatLogo.Image = Global.FurryFriendsRecordsDatabase.My.Resources.Resources.FFLogo
        Me.CatLogo.Location = New System.Drawing.Point(130, -4)
        Me.CatLogo.Name = "CatLogo"
        Me.CatLogo.Size = New System.Drawing.Size(225, 98)
        Me.CatLogo.TabIndex = 11
        Me.CatLogo.TabStop = False
        '
        'Cat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(884, 862)
        Me.Controls.Add(Me.CatLogo)
        Me.Controls.Add(Me.CatTitleLabel)
        Me.Controls.Add(Me.CatPanel)
        Me.Name = "Cat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Furry Friends Animal Records System | Cat Information"
        Me.CatSpayedGroupBox.ResumeLayout(False)
        Me.CatSpayedGroupBox.PerformLayout()
        Me.CatPanel.ResumeLayout(False)
        Me.CatPanel.PerformLayout()
        Me.CatHairTypeGroupBox.ResumeLayout(False)
        Me.CatHairTypeGroupBox.PerformLayout()
        Me.CatDeclawedGroupBox.ResumeLayout(False)
        Me.CatDeclawedGroupBox.PerformLayout()
        Me.CatDeclawingGroupBox.ResumeLayout(False)
        Me.CatDeclawingGroupBox.PerformLayout()
        Me.CatAnimalSexGroupBox.ResumeLayout(False)
        Me.CatAnimalSexGroupBox.PerformLayout()
        Me.CatFleaTestGroupBox.ResumeLayout(False)
        Me.CatFleaTestGroupBox.PerformLayout()
        Me.CatFelineLeukemiaTestGroupBox.ResumeLayout(False)
        Me.CatFelineLeukemiaTestGroupBox.PerformLayout()
        CType(Me.CatLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CatSpayedYesButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatSpayedNoButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatAnimalSexMaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatFleaTestYesButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatFleaTestNoButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatFelineLeukemiaTestPositiveButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatRabiesLabel As System.Windows.Forms.CheckBox
    Friend WithEvents CatRabiesVaccinationInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents CatVaccinationsLabel As System.Windows.Forms.Label
    Friend WithEvents CatDateoFelineLeukemiaTestLabel As System.Windows.Forms.Label
    Friend WithEvents CatDateofFirstTreatmentLabel As System.Windows.Forms.Label
    Friend WithEvents CatAnimalSexFemaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatDateofFelineLeukemiaTestInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents CatSpayedGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatTitleLabel As System.Windows.Forms.Label
    Friend WithEvents CatDateofFirstTreatmentInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents CatFleaTest As System.Windows.Forms.Label
    Friend WithEvents CatNextButton As System.Windows.Forms.Button
    Friend WithEvents CatAnimalSexLabel As System.Windows.Forms.Label
    Friend WithEvents CatBreedLabel As System.Windows.Forms.Label
    Friend WithEvents CatPanel As System.Windows.Forms.Panel
    Friend WithEvents CatLabel As System.Windows.Forms.Label
    Friend WithEvents CatDateofProcedureLabel As System.Windows.Forms.Label
    Friend WithEvents CatDateofProcedureInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents CatFelineLeukemiaTestLabel As System.Windows.Forms.Label
    Friend WithEvents CatSpayedLabel As System.Windows.Forms.Label
    Friend WithEvents CatAnimalSexGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatFleaTestGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatFelineLeukemiaTestGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatFelineLeukemiaTestNegativeButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatDeclawingLabel As System.Windows.Forms.Label
    Friend WithEvents CatDeclawingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatDeclawingTwoButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatDeclawingFourButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatDeclawedLabel As System.Windows.Forms.Label
    Friend WithEvents CatDeclawedGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatDeclawedYesButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatDeclawedNoButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatPreviousButton As System.Windows.Forms.Button
    Friend WithEvents CatLogo As System.Windows.Forms.PictureBox
    Friend WithEvents CatSpayedDateofProcedureToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CatDeclawedToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CatRabiesVaccinationToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CatBreedInput As System.Windows.Forms.ComboBox
    Friend WithEvents CatHairTypeLabel As System.Windows.Forms.Label
    Friend WithEvents CatHairColorInput As System.Windows.Forms.TextBox
    Friend WithEvents CatHairColorLabel As System.Windows.Forms.Label
    Friend WithEvents CatWeightInput As System.Windows.Forms.TextBox
    Friend WithEvents CatWeightLabel As System.Windows.Forms.Label
    Friend WithEvents CatHairTypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CatLongHairButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatShortHairButton As System.Windows.Forms.RadioButton
    Friend WithEvents CatNextToolTip As System.Windows.Forms.ToolTip
End Class
