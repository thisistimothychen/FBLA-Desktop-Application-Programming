Public Class New_Arrival
    Public Shared animalName As String
    Public Shared animalAge As Integer
    Public Shared animalDateofBirth As Date
    Public Shared microchippedYesOrNo As Boolean
    Public Shared animalChipNumber As Integer
    Public Shared animalOwner As String
    Public Shared animalDateOfMicrochipping As Date
    Public Shared animalDateContacted As Date
    Public Shared animalDateofArrival As Date
    Public Shared animalRelinquishingParty As String
    Public Shared animalCageNumber As String
    Private Sub AnimalAgeInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AnimalAgeInput.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub ChipNumberInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChipNumberInput.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub MicrochippedYesButton_CheckedChanged(sender As Object, e As EventArgs) Handles MicrochippedYesButton.CheckedChanged
        If Me.MicrochippedYesButton.Checked Then
            OwnerLabel.Enabled = True
            OwnerInput.Enabled = True
            DateContactedLabel.Enabled = True
            DateContactedInput.Enabled = True
            DateofMicrochippingLabel.Enabled = False
            DateofMicrochippingInput.Enabled = False
        End If
    End Sub
    Private Sub MicrochippedNoButton_CheckedChanged(sender As Object, e As EventArgs) Handles MicrochippedNoButton.CheckedChanged
        If Me.MicrochippedNoButton.Checked Then
            OwnerLabel.Enabled = False
            OwnerInput.Enabled = False
            OwnerInput.Text = ""
            DateContactedLabel.Enabled = False
            DateContactedInput.Enabled = False
            DateofMicrochippingLabel.Enabled = True
            DateofMicrochippingInput.Enabled = True
        End If
    End Sub
    Private Sub NewArrivalNextButton_Click(sender As Object, e As EventArgs) Handles NewArrivalNextButton.Click

        animalName = AnimalNameInput.Text
        animalAge = AnimalAgeInput.Text
        animalDateofBirth = DateofBirthInput.Text

        If MicrochippedYesButton.Checked Then
            microchippedYesOrNo = True
        ElseIf MicrochippedNoButton.Checked Then
            microchippedYesOrNo = False
        End If

        animalChipNumber = ChipNumberInput.Text
        animalOwner = OwnerInput.Text
        animalDateOfMicrochipping = DateofMicrochippingInput.Text
        animalDateContacted = DateContactedInput.Text
        animalDateofArrival = DateofArrivalInput.Text
        animalRelinquishingParty = RelinqPartyInput.Text
        animalCageNumber = CageNumberInput.Text


        If AnimalTypeInput.Text.CompareTo("Dog") = 0 Then
            Dim dogInformationForm As Dog
            dogInformationForm = New Dog
            dogInformationForm.Show()
            dogInformationForm = Nothing
            Me.Hide()
        ElseIf AnimalTypeInput.Text.CompareTo("Cat") = 0 Then
            Dim catInformationForm As Cat
            catInformationForm = New Cat
            catInformationForm.Show()
            catInformationForm = Nothing
            Me.Hide()
        ElseIf AnimalTypeInput.Text.CompareTo("Other") = 0 Then
            Dim otherInformationForm As Other
            otherInformationForm = New Other
            otherInformationForm.Show()
            otherInformationForm = Nothing
            Me.Hide()
        End If
    End Sub
    Private Sub NewArrivalPreviousButton_Click(sender As Object, e As EventArgs) Handles NewArrivalPreviousButton.Click
        Dim newCaseNumberForm As CaseNumber
        newCaseNumberForm = New CaseNumber
        newCaseNumberForm.Show()
        newCaseNumberForm = Nothing
        Me.Hide()
    End Sub

    Private Sub New_Arrival_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class