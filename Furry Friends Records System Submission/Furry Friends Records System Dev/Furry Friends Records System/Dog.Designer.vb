<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dog
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
        Me.DogNextButton = New System.Windows.Forms.Button()
        Me.DogLabel = New System.Windows.Forms.Label()
        Me.DogDateofProcedureLabel = New System.Windows.Forms.Label()
        Me.DogHeartwormTestLabel = New System.Windows.Forms.Label()
        Me.DogTitleLabel = New System.Windows.Forms.Label()
        Me.DogPanel = New System.Windows.Forms.Panel()
        Me.DogHairTypeLabel = New System.Windows.Forms.Label()
        Me.DogHairColorInput = New System.Windows.Forms.TextBox()
        Me.DogHairColorLabel = New System.Windows.Forms.Label()
        Me.DogWeightInput = New System.Windows.Forms.TextBox()
        Me.DogWeightLabel = New System.Windows.Forms.Label()
        Me.DogBreedInput = New System.Windows.Forms.ComboBox()
        Me.DogDateMedBeginsLabel = New System.Windows.Forms.Label()
        Me.DogBordetellaVaccinationInput = New System.Windows.Forms.DateTimePicker()
        Me.DogDateMedBeginsInput = New System.Windows.Forms.DateTimePicker()
        Me.DogBordetellaLabel = New System.Windows.Forms.CheckBox()
        Me.DogDistemperVaccinationInput = New System.Windows.Forms.DateTimePicker()
        Me.DogDistemperLabel = New System.Windows.Forms.CheckBox()
        Me.DogRabiesLabel = New System.Windows.Forms.CheckBox()
        Me.DogRabiesVaccinationInput = New System.Windows.Forms.DateTimePicker()
        Me.DogVaccinationsLabel = New System.Windows.Forms.Label()
        Me.DogRetestDateLabel = New System.Windows.Forms.Label()
        Me.DogRetestDateInput = New System.Windows.Forms.DateTimePicker()
        Me.DogDateofHeartwormTestLabel = New System.Windows.Forms.Label()
        Me.DogDateofFirstTreatmentLabel = New System.Windows.Forms.Label()
        Me.DogDateofHeartwormTestInput = New System.Windows.Forms.DateTimePicker()
        Me.DogDateofFirstTreatmentInput = New System.Windows.Forms.DateTimePicker()
        Me.DogSpayedGroupBox = New System.Windows.Forms.GroupBox()
        Me.DogSpayedYesButton = New System.Windows.Forms.RadioButton()
        Me.DogSpayedNoButton = New System.Windows.Forms.RadioButton()
        Me.DogFleaTest = New System.Windows.Forms.Label()
        Me.DogPreviousButton = New System.Windows.Forms.Button()
        Me.DogDateofProcedureInput = New System.Windows.Forms.DateTimePicker()
        Me.DogSpayedLabel = New System.Windows.Forms.Label()
        Me.DogAnimalSexLabel = New System.Windows.Forms.Label()
        Me.DogBreedLabel = New System.Windows.Forms.Label()
        Me.DogFleaTestGroupBox = New System.Windows.Forms.GroupBox()
        Me.DogFleaTestYesButton = New System.Windows.Forms.RadioButton()
        Me.DogFleaTestNoButton = New System.Windows.Forms.RadioButton()
        Me.DogHeartwormTestGroupBox = New System.Windows.Forms.GroupBox()
        Me.DogHeartwormTestPositiveButton = New System.Windows.Forms.RadioButton()
        Me.DogHeartwormTestNegativeButton = New System.Windows.Forms.RadioButton()
        Me.DogHairTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DogLongHairButton = New System.Windows.Forms.RadioButton()
        Me.DogShortHairButton = New System.Windows.Forms.RadioButton()
        Me.DogAnimalSexGroupBox = New System.Windows.Forms.GroupBox()
        Me.DogAnimalSexMaleButton = New System.Windows.Forms.RadioButton()
        Me.DogAnimalSexFemaleButton = New System.Windows.Forms.RadioButton()
        Me.DogLogo = New System.Windows.Forms.PictureBox()
        Me.DogSpayedDateofProcedureToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DogRabiesVaccinationToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DogDistemperVaccinationToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DogBordetellaVaccinationToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DogNextToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DogPanel.SuspendLayout()
        Me.DogSpayedGroupBox.SuspendLayout()
        Me.DogFleaTestGroupBox.SuspendLayout()
        Me.DogHeartwormTestGroupBox.SuspendLayout()
        Me.DogHairTypeGroupBox.SuspendLayout()
        Me.DogAnimalSexGroupBox.SuspendLayout()
        CType(Me.DogLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DogNextButton
        '
        Me.DogNextButton.Location = New System.Drawing.Point(536, 694)
        Me.DogNextButton.Name = "DogNextButton"
        Me.DogNextButton.Size = New System.Drawing.Size(120, 34)
        Me.DogNextButton.TabIndex = 24
        Me.DogNextButton.Text = "Next"
        Me.DogNextToolTip.SetToolTip(Me.DogNextButton, "Generate client report.")
        Me.DogNextButton.UseVisualStyleBackColor = True
        '
        'DogLabel
        '
        Me.DogLabel.AutoSize = True
        Me.DogLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DogLabel.Location = New System.Drawing.Point(312, 15)
        Me.DogLabel.Name = "DogLabel"
        Me.DogLabel.Size = New System.Drawing.Size(237, 24)
        Me.DogLabel.TabIndex = 14
        Me.DogLabel.Text = "Animal Information: Dog"
        '
        'DogDateofProcedureLabel
        '
        Me.DogDateofProcedureLabel.AutoSize = True
        Me.DogDateofProcedureLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DogDateofProcedureLabel.Location = New System.Drawing.Point(392, 320)
        Me.DogDateofProcedureLabel.Name = "DogDateofProcedureLabel"
        Me.DogDateofProcedureLabel.Size = New System.Drawing.Size(127, 17)
        Me.DogDateofProcedureLabel.TabIndex = 12
        Me.DogDateofProcedureLabel.Text = "Date of Procedure"
        '
        'DogHeartwormTestLabel
        '
        Me.DogHeartwormTestLabel.AutoSize = True
        Me.DogHeartwormTestLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogHeartwormTestLabel.Location = New System.Drawing.Point(185, 440)
        Me.DogHeartwormTestLabel.Name = "DogHeartwormTestLabel"
        Me.DogHeartwormTestLabel.Size = New System.Drawing.Size(156, 24)
        Me.DogHeartwormTestLabel.TabIndex = 7
        Me.DogHeartwormTestLabel.Text = "Heartworm Test"
        '
        'DogTitleLabel
        '
        Me.DogTitleLabel.AutoSize = True
        Me.DogTitleLabel.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DogTitleLabel.Location = New System.Drawing.Point(358, 32)
        Me.DogTitleLabel.Name = "DogTitleLabel"
        Me.DogTitleLabel.Size = New System.Drawing.Size(345, 34)
        Me.DogTitleLabel.TabIndex = 7
        Me.DogTitleLabel.Text = "Animal Records System"
        Me.DogTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DogPanel
        '
        Me.DogPanel.Controls.Add(Me.DogHairTypeLabel)
        Me.DogPanel.Controls.Add(Me.DogHairColorInput)
        Me.DogPanel.Controls.Add(Me.DogHairColorLabel)
        Me.DogPanel.Controls.Add(Me.DogWeightInput)
        Me.DogPanel.Controls.Add(Me.DogWeightLabel)
        Me.DogPanel.Controls.Add(Me.DogBreedInput)
        Me.DogPanel.Controls.Add(Me.DogDateMedBeginsLabel)
        Me.DogPanel.Controls.Add(Me.DogBordetellaVaccinationInput)
        Me.DogPanel.Controls.Add(Me.DogDateMedBeginsInput)
        Me.DogPanel.Controls.Add(Me.DogBordetellaLabel)
        Me.DogPanel.Controls.Add(Me.DogDistemperVaccinationInput)
        Me.DogPanel.Controls.Add(Me.DogDistemperLabel)
        Me.DogPanel.Controls.Add(Me.DogRabiesLabel)
        Me.DogPanel.Controls.Add(Me.DogRabiesVaccinationInput)
        Me.DogPanel.Controls.Add(Me.DogVaccinationsLabel)
        Me.DogPanel.Controls.Add(Me.DogRetestDateLabel)
        Me.DogPanel.Controls.Add(Me.DogRetestDateInput)
        Me.DogPanel.Controls.Add(Me.DogDateofHeartwormTestLabel)
        Me.DogPanel.Controls.Add(Me.DogDateofFirstTreatmentLabel)
        Me.DogPanel.Controls.Add(Me.DogDateofHeartwormTestInput)
        Me.DogPanel.Controls.Add(Me.DogDateofFirstTreatmentInput)
        Me.DogPanel.Controls.Add(Me.DogSpayedGroupBox)
        Me.DogPanel.Controls.Add(Me.DogFleaTest)
        Me.DogPanel.Controls.Add(Me.DogPreviousButton)
        Me.DogPanel.Controls.Add(Me.DogNextButton)
        Me.DogPanel.Controls.Add(Me.DogLabel)
        Me.DogPanel.Controls.Add(Me.DogDateofProcedureLabel)
        Me.DogPanel.Controls.Add(Me.DogDateofProcedureInput)
        Me.DogPanel.Controls.Add(Me.DogHeartwormTestLabel)
        Me.DogPanel.Controls.Add(Me.DogSpayedLabel)
        Me.DogPanel.Controls.Add(Me.DogAnimalSexLabel)
        Me.DogPanel.Controls.Add(Me.DogBreedLabel)
        Me.DogPanel.Controls.Add(Me.DogFleaTestGroupBox)
        Me.DogPanel.Controls.Add(Me.DogHeartwormTestGroupBox)
        Me.DogPanel.Controls.Add(Me.DogHairTypeGroupBox)
        Me.DogPanel.Controls.Add(Me.DogAnimalSexGroupBox)
        Me.DogPanel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogPanel.Location = New System.Drawing.Point(17, 86)
        Me.DogPanel.Name = "DogPanel"
        Me.DogPanel.Size = New System.Drawing.Size(849, 764)
        Me.DogPanel.TabIndex = 8
        '
        'DogHairTypeLabel
        '
        Me.DogHairTypeLabel.AutoSize = True
        Me.DogHairTypeLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogHairTypeLabel.Location = New System.Drawing.Point(185, 180)
        Me.DogHairTypeLabel.Name = "DogHairTypeLabel"
        Me.DogHairTypeLabel.Size = New System.Drawing.Size(123, 24)
        Me.DogHairTypeLabel.TabIndex = 34
        Me.DogHairTypeLabel.Text = "Type of Hair"
        '
        'DogHairColorInput
        '
        Me.DogHairColorInput.Location = New System.Drawing.Point(394, 133)
        Me.DogHairColorInput.Name = "DogHairColorInput"
        Me.DogHairColorInput.Size = New System.Drawing.Size(226, 32)
        Me.DogHairColorInput.TabIndex = 2
        '
        'DogHairColorLabel
        '
        Me.DogHairColorLabel.AutoSize = True
        Me.DogHairColorLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogHairColorLabel.Location = New System.Drawing.Point(185, 136)
        Me.DogHairColorLabel.Name = "DogHairColorLabel"
        Me.DogHairColorLabel.Size = New System.Drawing.Size(104, 24)
        Me.DogHairColorLabel.TabIndex = 32
        Me.DogHairColorLabel.Text = "Hair Color"
        '
        'DogWeightInput
        '
        Me.DogWeightInput.Location = New System.Drawing.Point(394, 92)
        Me.DogWeightInput.MaxLength = 3
        Me.DogWeightInput.Name = "DogWeightInput"
        Me.DogWeightInput.Size = New System.Drawing.Size(49, 32)
        Me.DogWeightInput.TabIndex = 1
        '
        'DogWeightLabel
        '
        Me.DogWeightLabel.AutoSize = True
        Me.DogWeightLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogWeightLabel.Location = New System.Drawing.Point(185, 95)
        Me.DogWeightLabel.Name = "DogWeightLabel"
        Me.DogWeightLabel.Size = New System.Drawing.Size(76, 24)
        Me.DogWeightLabel.TabIndex = 30
        Me.DogWeightLabel.Text = "Weight"
        '
        'DogBreedInput
        '
        Me.DogBreedInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DogBreedInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.DogBreedInput.DropDownHeight = 240
        Me.DogBreedInput.FormattingEnabled = True
        Me.DogBreedInput.IntegralHeight = False
        Me.DogBreedInput.Location = New System.Drawing.Point(394, 50)
        Me.DogBreedInput.MaxDropDownItems = 100
        Me.DogBreedInput.Name = "DogBreedInput"
        Me.DogBreedInput.Size = New System.Drawing.Size(274, 32)
        Me.DogBreedInput.TabIndex = 0
        '
        'DogDateMedBeginsLabel
        '
        Me.DogDateMedBeginsLabel.AutoSize = True
        Me.DogDateMedBeginsLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DogDateMedBeginsLabel.Location = New System.Drawing.Point(392, 506)
        Me.DogDateMedBeginsLabel.Name = "DogDateMedBeginsLabel"
        Me.DogDateMedBeginsLabel.Size = New System.Drawing.Size(161, 17)
        Me.DogDateMedBeginsLabel.TabIndex = 27
        Me.DogDateMedBeginsLabel.Text = "Date Medication Begins"
        '
        'DogBordetellaVaccinationInput
        '
        Me.DogBordetellaVaccinationInput.Enabled = False
        Me.DogBordetellaVaccinationInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogBordetellaVaccinationInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogBordetellaVaccinationInput.Location = New System.Drawing.Point(561, 645)
        Me.DogBordetellaVaccinationInput.Name = "DogBordetellaVaccinationInput"
        Me.DogBordetellaVaccinationInput.Size = New System.Drawing.Size(104, 23)
        Me.DogBordetellaVaccinationInput.TabIndex = 23
        '
        'DogDateMedBeginsInput
        '
        Me.DogDateMedBeginsInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogDateMedBeginsInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogDateMedBeginsInput.Location = New System.Drawing.Point(561, 503)
        Me.DogDateMedBeginsInput.Name = "DogDateMedBeginsInput"
        Me.DogDateMedBeginsInput.Size = New System.Drawing.Size(104, 23)
        Me.DogDateMedBeginsInput.TabIndex = 16
        '
        'DogBordetellaLabel
        '
        Me.DogBordetellaLabel.AutoSize = True
        Me.DogBordetellaLabel.Location = New System.Drawing.Point(394, 643)
        Me.DogBordetellaLabel.Name = "DogBordetellaLabel"
        Me.DogBordetellaLabel.Size = New System.Drawing.Size(123, 28)
        Me.DogBordetellaLabel.TabIndex = 22
        Me.DogBordetellaLabel.Text = "Bordetella"
        Me.DogBordetellaVaccinationToolTip.SetToolTip(Me.DogBordetellaLabel, "If the dog has been vaccinated, please include the date of the Bordetella vaccina" & _
        "tion.")
        Me.DogBordetellaLabel.UseVisualStyleBackColor = True
        '
        'DogDistemperVaccinationInput
        '
        Me.DogDistemperVaccinationInput.Enabled = False
        Me.DogDistemperVaccinationInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogDistemperVaccinationInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogDistemperVaccinationInput.Location = New System.Drawing.Point(561, 609)
        Me.DogDistemperVaccinationInput.Name = "DogDistemperVaccinationInput"
        Me.DogDistemperVaccinationInput.Size = New System.Drawing.Size(104, 23)
        Me.DogDistemperVaccinationInput.TabIndex = 21
        '
        'DogDistemperLabel
        '
        Me.DogDistemperLabel.AutoSize = True
        Me.DogDistemperLabel.Location = New System.Drawing.Point(394, 607)
        Me.DogDistemperLabel.Name = "DogDistemperLabel"
        Me.DogDistemperLabel.Size = New System.Drawing.Size(124, 28)
        Me.DogDistemperLabel.TabIndex = 20
        Me.DogDistemperLabel.Text = "Distemper"
        Me.DogDistemperVaccinationToolTip.SetToolTip(Me.DogDistemperLabel, "If the dog has been vaccinated, please include the date of the Distemper vaccinat" & _
        "ion.")
        Me.DogDistemperLabel.UseVisualStyleBackColor = True
        '
        'DogRabiesLabel
        '
        Me.DogRabiesLabel.AutoSize = True
        Me.DogRabiesLabel.Location = New System.Drawing.Point(395, 571)
        Me.DogRabiesLabel.Name = "DogRabiesLabel"
        Me.DogRabiesLabel.Size = New System.Drawing.Size(95, 28)
        Me.DogRabiesLabel.TabIndex = 18
        Me.DogRabiesLabel.Text = "Rabies"
        Me.DogRabiesVaccinationToolTip.SetToolTip(Me.DogRabiesLabel, "If the dog has been vaccinated, please include the date of the Rabies vaccination" & _
        ".")
        Me.DogRabiesLabel.UseVisualStyleBackColor = True
        '
        'DogRabiesVaccinationInput
        '
        Me.DogRabiesVaccinationInput.Enabled = False
        Me.DogRabiesVaccinationInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogRabiesVaccinationInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogRabiesVaccinationInput.Location = New System.Drawing.Point(561, 573)
        Me.DogRabiesVaccinationInput.Name = "DogRabiesVaccinationInput"
        Me.DogRabiesVaccinationInput.Size = New System.Drawing.Size(104, 23)
        Me.DogRabiesVaccinationInput.TabIndex = 19
        '
        'DogVaccinationsLabel
        '
        Me.DogVaccinationsLabel.AutoSize = True
        Me.DogVaccinationsLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogVaccinationsLabel.Location = New System.Drawing.Point(185, 572)
        Me.DogVaccinationsLabel.Name = "DogVaccinationsLabel"
        Me.DogVaccinationsLabel.Size = New System.Drawing.Size(128, 24)
        Me.DogVaccinationsLabel.TabIndex = 9
        Me.DogVaccinationsLabel.Text = "Vaccinations"
        '
        'DogRetestDateLabel
        '
        Me.DogRetestDateLabel.AutoSize = True
        Me.DogRetestDateLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DogRetestDateLabel.Location = New System.Drawing.Point(392, 534)
        Me.DogRetestDateLabel.Name = "DogRetestDateLabel"
        Me.DogRetestDateLabel.Size = New System.Drawing.Size(86, 17)
        Me.DogRetestDateLabel.TabIndex = 16
        Me.DogRetestDateLabel.Text = "Retest Date"
        '
        'DogRetestDateInput
        '
        Me.DogRetestDateInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogRetestDateInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogRetestDateInput.Location = New System.Drawing.Point(561, 531)
        Me.DogRetestDateInput.Name = "DogRetestDateInput"
        Me.DogRetestDateInput.Size = New System.Drawing.Size(104, 23)
        Me.DogRetestDateInput.TabIndex = 17
        '
        'DogDateofHeartwormTestLabel
        '
        Me.DogDateofHeartwormTestLabel.AutoSize = True
        Me.DogDateofHeartwormTestLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DogDateofHeartwormTestLabel.Location = New System.Drawing.Point(392, 479)
        Me.DogDateofHeartwormTestLabel.Name = "DogDateofHeartwormTestLabel"
        Me.DogDateofHeartwormTestLabel.Size = New System.Drawing.Size(86, 17)
        Me.DogDateofHeartwormTestLabel.TabIndex = 14
        Me.DogDateofHeartwormTestLabel.Text = "Date of Test"
        '
        'DogDateofFirstTreatmentLabel
        '
        Me.DogDateofFirstTreatmentLabel.AutoSize = True
        Me.DogDateofFirstTreatmentLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.DogDateofFirstTreatmentLabel.Location = New System.Drawing.Point(391, 399)
        Me.DogDateofFirstTreatmentLabel.Name = "DogDateofFirstTreatmentLabel"
        Me.DogDateofFirstTreatmentLabel.Size = New System.Drawing.Size(158, 17)
        Me.DogDateofFirstTreatmentLabel.TabIndex = 14
        Me.DogDateofFirstTreatmentLabel.Text = "Date of First Treatment"
        '
        'DogDateofHeartwormTestInput
        '
        Me.DogDateofHeartwormTestInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogDateofHeartwormTestInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogDateofHeartwormTestInput.Location = New System.Drawing.Point(561, 476)
        Me.DogDateofHeartwormTestInput.Name = "DogDateofHeartwormTestInput"
        Me.DogDateofHeartwormTestInput.Size = New System.Drawing.Size(104, 23)
        Me.DogDateofHeartwormTestInput.TabIndex = 15
        '
        'DogDateofFirstTreatmentInput
        '
        Me.DogDateofFirstTreatmentInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogDateofFirstTreatmentInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogDateofFirstTreatmentInput.Location = New System.Drawing.Point(561, 397)
        Me.DogDateofFirstTreatmentInput.Name = "DogDateofFirstTreatmentInput"
        Me.DogDateofFirstTreatmentInput.Size = New System.Drawing.Size(104, 23)
        Me.DogDateofFirstTreatmentInput.TabIndex = 12
        '
        'DogSpayedGroupBox
        '
        Me.DogSpayedGroupBox.Controls.Add(Me.DogSpayedYesButton)
        Me.DogSpayedGroupBox.Controls.Add(Me.DogSpayedNoButton)
        Me.DogSpayedGroupBox.Location = New System.Drawing.Point(394, 262)
        Me.DogSpayedGroupBox.Name = "DogSpayedGroupBox"
        Me.DogSpayedGroupBox.Size = New System.Drawing.Size(274, 51)
        Me.DogSpayedGroupBox.TabIndex = 7
        Me.DogSpayedGroupBox.TabStop = False
        '
        'DogSpayedYesButton
        '
        Me.DogSpayedYesButton.AutoSize = True
        Me.DogSpayedYesButton.Location = New System.Drawing.Point(12, 18)
        Me.DogSpayedYesButton.Name = "DogSpayedYesButton"
        Me.DogSpayedYesButton.Size = New System.Drawing.Size(63, 28)
        Me.DogSpayedYesButton.TabIndex = 7
        Me.DogSpayedYesButton.Text = "Yes"
        Me.DogSpayedYesButton.UseVisualStyleBackColor = True
        '
        'DogSpayedNoButton
        '
        Me.DogSpayedNoButton.AutoSize = True
        Me.DogSpayedNoButton.Checked = True
        Me.DogSpayedNoButton.Location = New System.Drawing.Point(132, 18)
        Me.DogSpayedNoButton.Name = "DogSpayedNoButton"
        Me.DogSpayedNoButton.Size = New System.Drawing.Size(54, 28)
        Me.DogSpayedNoButton.TabIndex = 8
        Me.DogSpayedNoButton.TabStop = True
        Me.DogSpayedNoButton.Text = "No"
        Me.DogSpayedDateofProcedureToolTip.SetToolTip(Me.DogSpayedNoButton, "If not, the procedure must be scheduled.")
        Me.DogSpayedNoButton.UseVisualStyleBackColor = True
        '
        'DogFleaTest
        '
        Me.DogFleaTest.AutoSize = True
        Me.DogFleaTest.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogFleaTest.Location = New System.Drawing.Point(185, 360)
        Me.DogFleaTest.Name = "DogFleaTest"
        Me.DogFleaTest.Size = New System.Drawing.Size(96, 24)
        Me.DogFleaTest.TabIndex = 19
        Me.DogFleaTest.Text = "Flea Test"
        '
        'DogPreviousButton
        '
        Me.DogPreviousButton.Location = New System.Drawing.Point(189, 694)
        Me.DogPreviousButton.Name = "DogPreviousButton"
        Me.DogPreviousButton.Size = New System.Drawing.Size(120, 34)
        Me.DogPreviousButton.TabIndex = 25
        Me.DogPreviousButton.Text = "Previous"
        Me.DogPreviousButton.UseVisualStyleBackColor = True
        '
        'DogDateofProcedureInput
        '
        Me.DogDateofProcedureInput.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DogDateofProcedureInput.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DogDateofProcedureInput.Location = New System.Drawing.Point(561, 318)
        Me.DogDateofProcedureInput.Name = "DogDateofProcedureInput"
        Me.DogDateofProcedureInput.Size = New System.Drawing.Size(104, 23)
        Me.DogDateofProcedureInput.TabIndex = 9
        '
        'DogSpayedLabel
        '
        Me.DogSpayedLabel.AutoSize = True
        Me.DogSpayedLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogSpayedLabel.Location = New System.Drawing.Point(185, 279)
        Me.DogSpayedLabel.Name = "DogSpayedLabel"
        Me.DogSpayedLabel.Size = New System.Drawing.Size(172, 24)
        Me.DogSpayedLabel.TabIndex = 7
        Me.DogSpayedLabel.Text = "Spayed/Neutered"
        '
        'DogAnimalSexLabel
        '
        Me.DogAnimalSexLabel.AutoSize = True
        Me.DogAnimalSexLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogAnimalSexLabel.Location = New System.Drawing.Point(185, 229)
        Me.DogAnimalSexLabel.Name = "DogAnimalSexLabel"
        Me.DogAnimalSexLabel.Size = New System.Drawing.Size(113, 24)
        Me.DogAnimalSexLabel.TabIndex = 7
        Me.DogAnimalSexLabel.Text = "Animal Sex"
        '
        'DogBreedLabel
        '
        Me.DogBreedLabel.AutoSize = True
        Me.DogBreedLabel.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogBreedLabel.Location = New System.Drawing.Point(185, 58)
        Me.DogBreedLabel.Name = "DogBreedLabel"
        Me.DogBreedLabel.Size = New System.Drawing.Size(66, 24)
        Me.DogBreedLabel.TabIndex = 2
        Me.DogBreedLabel.Text = "Breed"
        '
        'DogFleaTestGroupBox
        '
        Me.DogFleaTestGroupBox.Controls.Add(Me.DogFleaTestYesButton)
        Me.DogFleaTestGroupBox.Controls.Add(Me.DogFleaTestNoButton)
        Me.DogFleaTestGroupBox.Location = New System.Drawing.Point(394, 339)
        Me.DogFleaTestGroupBox.Name = "DogFleaTestGroupBox"
        Me.DogFleaTestGroupBox.Size = New System.Drawing.Size(274, 51)
        Me.DogFleaTestGroupBox.TabIndex = 10
        Me.DogFleaTestGroupBox.TabStop = False
        '
        'DogFleaTestYesButton
        '
        Me.DogFleaTestYesButton.AutoSize = True
        Me.DogFleaTestYesButton.Checked = True
        Me.DogFleaTestYesButton.Location = New System.Drawing.Point(12, 18)
        Me.DogFleaTestYesButton.Name = "DogFleaTestYesButton"
        Me.DogFleaTestYesButton.Size = New System.Drawing.Size(63, 28)
        Me.DogFleaTestYesButton.TabIndex = 10
        Me.DogFleaTestYesButton.TabStop = True
        Me.DogFleaTestYesButton.Text = "Yes"
        Me.DogFleaTestYesButton.UseVisualStyleBackColor = True
        '
        'DogFleaTestNoButton
        '
        Me.DogFleaTestNoButton.AutoSize = True
        Me.DogFleaTestNoButton.Location = New System.Drawing.Point(132, 18)
        Me.DogFleaTestNoButton.Name = "DogFleaTestNoButton"
        Me.DogFleaTestNoButton.Size = New System.Drawing.Size(54, 28)
        Me.DogFleaTestNoButton.TabIndex = 11
        Me.DogFleaTestNoButton.Text = "No"
        Me.DogFleaTestNoButton.UseVisualStyleBackColor = True
        '
        'DogHeartwormTestGroupBox
        '
        Me.DogHeartwormTestGroupBox.Controls.Add(Me.DogHeartwormTestPositiveButton)
        Me.DogHeartwormTestGroupBox.Controls.Add(Me.DogHeartwormTestNegativeButton)
        Me.DogHeartwormTestGroupBox.Location = New System.Drawing.Point(394, 421)
        Me.DogHeartwormTestGroupBox.Name = "DogHeartwormTestGroupBox"
        Me.DogHeartwormTestGroupBox.Size = New System.Drawing.Size(262, 51)
        Me.DogHeartwormTestGroupBox.TabIndex = 13
        Me.DogHeartwormTestGroupBox.TabStop = False
        '
        'DogHeartwormTestPositiveButton
        '
        Me.DogHeartwormTestPositiveButton.AutoSize = True
        Me.DogHeartwormTestPositiveButton.Checked = True
        Me.DogHeartwormTestPositiveButton.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogHeartwormTestPositiveButton.Location = New System.Drawing.Point(12, 17)
        Me.DogHeartwormTestPositiveButton.Name = "DogHeartwormTestPositiveButton"
        Me.DogHeartwormTestPositiveButton.Size = New System.Drawing.Size(104, 28)
        Me.DogHeartwormTestPositiveButton.TabIndex = 13
        Me.DogHeartwormTestPositiveButton.TabStop = True
        Me.DogHeartwormTestPositiveButton.Text = "Positive"
        Me.DogHeartwormTestPositiveButton.UseVisualStyleBackColor = True
        '
        'DogHeartwormTestNegativeButton
        '
        Me.DogHeartwormTestNegativeButton.AutoSize = True
        Me.DogHeartwormTestNegativeButton.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.DogHeartwormTestNegativeButton.Location = New System.Drawing.Point(132, 17)
        Me.DogHeartwormTestNegativeButton.Name = "DogHeartwormTestNegativeButton"
        Me.DogHeartwormTestNegativeButton.Size = New System.Drawing.Size(111, 28)
        Me.DogHeartwormTestNegativeButton.TabIndex = 14
        Me.DogHeartwormTestNegativeButton.Text = "Negative"
        Me.DogHeartwormTestNegativeButton.UseVisualStyleBackColor = True
        '
        'DogHairTypeGroupBox
        '
        Me.DogHairTypeGroupBox.Controls.Add(Me.DogLongHairButton)
        Me.DogHairTypeGroupBox.Controls.Add(Me.DogShortHairButton)
        Me.DogHairTypeGroupBox.Location = New System.Drawing.Point(394, 162)
        Me.DogHairTypeGroupBox.Name = "DogHairTypeGroupBox"
        Me.DogHairTypeGroupBox.Size = New System.Drawing.Size(274, 51)
        Me.DogHairTypeGroupBox.TabIndex = 3
        Me.DogHairTypeGroupBox.TabStop = False
        '
        'DogLongHairButton
        '
        Me.DogLongHairButton.AutoSize = True
        Me.DogLongHairButton.Checked = True
        Me.DogLongHairButton.Location = New System.Drawing.Point(12, 17)
        Me.DogLongHairButton.Name = "DogLongHairButton"
        Me.DogLongHairButton.Size = New System.Drawing.Size(74, 28)
        Me.DogLongHairButton.TabIndex = 3
        Me.DogLongHairButton.TabStop = True
        Me.DogLongHairButton.Text = "Long"
        Me.DogLongHairButton.UseVisualStyleBackColor = True
        '
        'DogShortHairButton
        '
        Me.DogShortHairButton.AutoSize = True
        Me.DogShortHairButton.Location = New System.Drawing.Point(132, 17)
        Me.DogShortHairButton.Name = "DogShortHairButton"
        Me.DogShortHairButton.Size = New System.Drawing.Size(78, 28)
        Me.DogShortHairButton.TabIndex = 4
        Me.DogShortHairButton.Text = "Short"
        Me.DogShortHairButton.UseVisualStyleBackColor = True
        '
        'DogAnimalSexGroupBox
        '
        Me.DogAnimalSexGroupBox.Controls.Add(Me.DogAnimalSexMaleButton)
        Me.DogAnimalSexGroupBox.Controls.Add(Me.DogAnimalSexFemaleButton)
        Me.DogAnimalSexGroupBox.Location = New System.Drawing.Point(394, 211)
        Me.DogAnimalSexGroupBox.Name = "DogAnimalSexGroupBox"
        Me.DogAnimalSexGroupBox.Size = New System.Drawing.Size(274, 51)
        Me.DogAnimalSexGroupBox.TabIndex = 5
        Me.DogAnimalSexGroupBox.TabStop = False
        '
        'DogAnimalSexMaleButton
        '
        Me.DogAnimalSexMaleButton.AutoSize = True
        Me.DogAnimalSexMaleButton.Checked = True
        Me.DogAnimalSexMaleButton.Location = New System.Drawing.Point(12, 17)
        Me.DogAnimalSexMaleButton.Name = "DogAnimalSexMaleButton"
        Me.DogAnimalSexMaleButton.Size = New System.Drawing.Size(73, 28)
        Me.DogAnimalSexMaleButton.TabIndex = 5
        Me.DogAnimalSexMaleButton.TabStop = True
        Me.DogAnimalSexMaleButton.Text = "Male"
        Me.DogAnimalSexMaleButton.UseVisualStyleBackColor = True
        '
        'DogAnimalSexFemaleButton
        '
        Me.DogAnimalSexFemaleButton.AutoSize = True
        Me.DogAnimalSexFemaleButton.Location = New System.Drawing.Point(132, 17)
        Me.DogAnimalSexFemaleButton.Name = "DogAnimalSexFemaleButton"
        Me.DogAnimalSexFemaleButton.Size = New System.Drawing.Size(97, 28)
        Me.DogAnimalSexFemaleButton.TabIndex = 6
        Me.DogAnimalSexFemaleButton.Text = "Female"
        Me.DogAnimalSexFemaleButton.UseVisualStyleBackColor = True
        '
        'DogLogo
        '
        Me.DogLogo.Image = Global.FurryFriendsRecordsDatabase.My.Resources.Resources.FFLogo
        Me.DogLogo.Location = New System.Drawing.Point(136, 5)
        Me.DogLogo.Name = "DogLogo"
        Me.DogLogo.Size = New System.Drawing.Size(225, 98)
        Me.DogLogo.TabIndex = 26
        Me.DogLogo.TabStop = False
        '
        'Dog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(884, 862)
        Me.Controls.Add(Me.DogLogo)
        Me.Controls.Add(Me.DogTitleLabel)
        Me.Controls.Add(Me.DogPanel)
        Me.Name = "Dog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Furry Friends Animal Records System | Dog Information"
        Me.DogPanel.ResumeLayout(False)
        Me.DogPanel.PerformLayout()
        Me.DogSpayedGroupBox.ResumeLayout(False)
        Me.DogSpayedGroupBox.PerformLayout()
        Me.DogFleaTestGroupBox.ResumeLayout(False)
        Me.DogFleaTestGroupBox.PerformLayout()
        Me.DogHeartwormTestGroupBox.ResumeLayout(False)
        Me.DogHeartwormTestGroupBox.PerformLayout()
        Me.DogHairTypeGroupBox.ResumeLayout(False)
        Me.DogHairTypeGroupBox.PerformLayout()
        Me.DogAnimalSexGroupBox.ResumeLayout(False)
        Me.DogAnimalSexGroupBox.PerformLayout()
        CType(Me.DogLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DogNextButton As System.Windows.Forms.Button
    Friend WithEvents DogLabel As System.Windows.Forms.Label
    Friend WithEvents DogDateofProcedureLabel As System.Windows.Forms.Label
    Friend WithEvents DogHeartwormTestLabel As System.Windows.Forms.Label
    Friend WithEvents DogTitleLabel As System.Windows.Forms.Label
    Friend WithEvents DogPanel As System.Windows.Forms.Panel
    Friend WithEvents DogSpayedGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DogSpayedYesButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogSpayedNoButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogSpayedLabel As System.Windows.Forms.Label
    Friend WithEvents DogAnimalSexLabel As System.Windows.Forms.Label
    Friend WithEvents DogBreedLabel As System.Windows.Forms.Label
    Friend WithEvents DogFleaTestGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DogFleaTestYesButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogFleaTestNoButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogFleaTest As System.Windows.Forms.Label
    Friend WithEvents DogDateofFirstTreatmentLabel As System.Windows.Forms.Label
    Friend WithEvents DogDateofFirstTreatmentInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogAnimalSexGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DogAnimalSexMaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogAnimalSexFemaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogHeartwormTestGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DogHeartwormTestPositiveButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogHeartwormTestNegativeButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogDateofHeartwormTestLabel As System.Windows.Forms.Label
    Friend WithEvents DogDateofHeartwormTestInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogRabiesLabel As System.Windows.Forms.CheckBox
    Friend WithEvents DogVaccinationsLabel As System.Windows.Forms.Label
    Friend WithEvents DogRetestDateLabel As System.Windows.Forms.Label
    Friend WithEvents DogRetestDateInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogBordetellaVaccinationInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogDistemperVaccinationInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogDistemperLabel As System.Windows.Forms.CheckBox
    Friend WithEvents DogRabiesVaccinationInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogBordetellaLabel As System.Windows.Forms.CheckBox
    Friend WithEvents DogPreviousButton As System.Windows.Forms.Button
    Friend WithEvents DogDateofProcedureInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogLogo As System.Windows.Forms.PictureBox
    Friend WithEvents DogDateMedBeginsLabel As System.Windows.Forms.Label
    Friend WithEvents DogDateMedBeginsInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents DogSpayedDateofProcedureToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DogBordetellaVaccinationToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DogDistemperVaccinationToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DogRabiesVaccinationToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents DogBreedInput As System.Windows.Forms.ComboBox
    Friend WithEvents DogWeightInput As System.Windows.Forms.TextBox
    Friend WithEvents DogWeightLabel As System.Windows.Forms.Label
    Friend WithEvents DogHairTypeLabel As System.Windows.Forms.Label
    Friend WithEvents DogHairColorInput As System.Windows.Forms.TextBox
    Friend WithEvents DogHairColorLabel As System.Windows.Forms.Label
    Friend WithEvents DogHairTypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DogLongHairButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogShortHairButton As System.Windows.Forms.RadioButton
    Friend WithEvents DogNextToolTip As System.Windows.Forms.ToolTip
End Class
