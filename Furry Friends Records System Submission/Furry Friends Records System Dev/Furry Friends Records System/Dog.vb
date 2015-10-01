Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop


Public Class Dog
    Private Sub DogPreviousButton_Click(sender As Object, e As EventArgs) Handles DogPreviousButton.Click
        New_Arrival.Show()
        Me.Hide()
    End Sub
    Private Sub DogWeightInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DogWeightInput.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub DogSpayedNoButton_CheckedChanged(sender As Object, e As EventArgs) Handles DogSpayedNoButton.CheckedChanged
        If Me.DogSpayedNoButton.Checked Then
            DogDateofProcedureLabel.Enabled = True
            DogDateofProcedureInput.Enabled = True
        End If
    End Sub

    Private Sub DogSpayedYesButton_CheckedChanged(sender As Object, e As EventArgs) Handles DogSpayedYesButton.CheckedChanged
        If Me.DogSpayedYesButton.Checked Then
            DogDateofProcedureLabel.Enabled = False
            DogDateofProcedureInput.Enabled = False
        End If
    End Sub

    Private Sub DogFleaTestYesButton_CheckedChanged(sender As Object, e As EventArgs) Handles DogFleaTestYesButton.CheckedChanged
        If Me.DogFleaTestYesButton.Checked Then
            DogDateofFirstTreatmentLabel.Enabled = True
            DogDateofFirstTreatmentInput.Enabled = True
        End If
    End Sub

    Private Sub DogFleaTestNoButton_CheckedChanged(sender As Object, e As EventArgs) Handles DogFleaTestNoButton.CheckedChanged
        If Me.DogFleaTestNoButton.Checked Then
            DogDateofFirstTreatmentLabel.Enabled = False
            DogDateofFirstTreatmentInput.Enabled = False
        End If
    End Sub

    Private Sub DogHeartwormTestPositiveButton_CheckedChanged(sender As Object, e As EventArgs) Handles DogHeartwormTestPositiveButton.CheckedChanged
        If Me.DogHeartwormTestPositiveButton.Checked Then
            DogDateMedBeginsLabel.Enabled = True
            DogDateMedBeginsInput.Enabled = True
            DogRetestDateLabel.Enabled = True
            DogRetestDateInput.Enabled = True
        End If
    End Sub

    Private Sub DogHeartwormTestNegativeButton_CheckedChanged(sender As Object, e As EventArgs) Handles DogHeartwormTestNegativeButton.CheckedChanged
        If Me.DogHeartwormTestNegativeButton.Checked Then
            DogDateMedBeginsLabel.Enabled = False
            DogDateMedBeginsInput.Enabled = False
            DogRetestDateLabel.Enabled = False
            DogRetestDateInput.Enabled = False
        End If
    End Sub


    Private Sub DogRabiesLabel_CheckedChanged(sender As Object, e As EventArgs) Handles DogRabiesLabel.CheckedChanged
        If Me.DogRabiesLabel.Checked Then
            DogRabiesVaccinationInput.Enabled = True
        Else
            DogRabiesVaccinationInput.Enabled = False
        End If
    End Sub

    Private Sub DogDistemperLabel_CheckedChanged(sender As Object, e As EventArgs) Handles DogDistemperLabel.CheckedChanged
        If Me.DogDistemperLabel.Checked Then
            DogDistemperVaccinationInput.Enabled = True
        Else
            DogDistemperVaccinationInput.Enabled = False
        End If
    End Sub

    Private Sub DogBordetellaLabel_CheckedChanged(sender As Object, e As EventArgs) Handles DogBordetellaLabel.CheckedChanged
        If Me.DogBordetellaLabel.Checked Then
            DogBordetellaVaccinationInput.Enabled = True
        Else
            DogBordetellaVaccinationInput.Enabled = False
        End If
    End Sub

    Private Sub Dog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub Dog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reader As New System.IO.StreamReader(CurDir() & "\Resources\DogBreeds.txt")

        For counter As Integer = 1 To 100
            Dim tempBreed As String
            tempBreed = reader.ReadLine()

            DogBreedInput.Items.Add(tempBreed)
            DogBreedInput.AutoCompleteCustomSource.Add(tempBreed)
        Next

        'Me.DogBreedInput = New System.Windows.Forms.ComboBox
        reader.Close()
    End Sub
    Private Sub GenerateClientReport()
        ' Get the Word application object.
        Dim word_app As Word._Application = New Word.ApplicationClass()

        ' Make Word visible (optional).
        'word_app.Visible = True

        ' Create the Word document.
        Dim clientReport As Word._Document = word_app.Documents.Add()

        ' Read in all existing case numbers to determine a new case number for current animal
        Dim reader As New System.IO.StreamReader(CurDir() & "\Resources\CaseNumbers.txt")

        Dim lastCaseNum As String = 0

        Do While reader.Peek <> -1
            lastCaseNum = reader.ReadLine()
        Loop
        Dim newCaseNum As Integer = CUInt(lastCaseNum) + 1
        reader.Close()

        My.Computer.FileSystem.WriteAllText(CurDir() & "\Resources\CaseNumbers.txt", vbCrLf & newCaseNum, True)

        ' Create title
        Dim para As Word.Paragraph = clientReport.Paragraphs.Add()
        para.Range.Text = "Furry Friends Animal Shelter"
        para.Range.Style = "Heading 1"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Format.SpaceAfter = 0
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Client Report"
        para.Range.Style = "Heading 2"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()

        ' Add animal information
        para.Range.Text = "Animal Name: " & vbTab & vbTab & New_Arrival.animalName
        para.Format.SpaceAfter = 0
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Animal Age: " & vbTab & vbTab & New_Arrival.animalAge
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Date of Birth: " & vbTab & vbTab & New_Arrival.animalDateofBirth
        para.Range.InsertParagraphAfter()
        If New_Arrival.microchippedYesOrNo Then
            para.Range.Text = "Chip Number: " & vbTab & vbTab & New_Arrival.animalChipNumber
            para.Range.InsertParagraphAfter()
            para.Range.Text = "Owner: " & vbTab & vbTab & vbTab & New_Arrival.animalOwner
            para.Range.InsertParagraphAfter()
            para.Range.Text = "Date Contacted: " & vbTab & New_Arrival.animalDateContacted
            para.Range.InsertParagraphAfter()
        Else
            para.Range.Text = "Chip Number: " & vbTab & vbTab & New_Arrival.animalChipNumber
            para.Range.InsertParagraphAfter()
            para.Range.Text = "Date of Micro-chipping: " & vbTab & New_Arrival.animalDateOfMicrochipping
            para.Range.InsertParagraphAfter()
        End If


        para.Range.Text = "Breed: " & vbTab & vbTab & vbTab & DogBreedInput.Text & " (Dog)"
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Weight: " & vbTab & vbTab & DogWeightInput.Text
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Hair Color: " & vbTab & vbTab & DogHairColorInput.Text
        para.Range.InsertParagraphAfter()

        If DogLongHairButton.Checked Then
            para.Range.Text = "Type of hair: " & vbTab & vbTab & "Long"
            para.Range.InsertParagraphAfter()
        ElseIf DogShortHairButton.Checked Then
            para.Range.Text = "Type of hair: " & vbTab & vbTab & "Short"
            para.Range.InsertParagraphAfter()
        End If

        If DogAnimalSexFemaleButton.Checked Then
            para.Range.Text = "Animal Sex: " & vbTab & vbTab & "Female"
            para.Range.InsertParagraphAfter()
        ElseIf DogAnimalSexMaleButton.Checked Then
            para.Range.Text = "Animal Sex: " & vbTab & vbTab & "Male"
            para.Range.InsertParagraphAfter()
        End If

        para.Range.InsertParagraphAfter()

        If DogSpayedNoButton.Checked Then
            para.Range.Text = "Dog is not spayed or neutered."
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Date chosen for procedure: " & vbTab & DogDateofProcedureInput.Text
            para.Range.InsertParagraphAfter()

        ElseIf DogSpayedYesButton.Checked Then
            para.Range.Text = "Dog is spayed or neutered."
            para.Range.InsertParagraphAfter()
        End If

        If DogFleaTestNoButton.Checked Then
            para.Range.Text = "Dog is not checked for fleas."
            para.Range.InsertParagraphAfter()
        ElseIf DogFleaTestYesButton.Checked Then
            para.Range.Text = "Dog is checked for fleas."
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Date of first treatment: " & vbTab & vbTab & DogDateofFirstTreatmentInput.Text
            para.Range.InsertParagraphAfter()
        End If

        If DogHeartwormTestPositiveButton.Checked Then
            para.Range.Text = "Dog has heartworms."
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Date of heartworm test: " & vbTab & DogDateofHeartwormTestInput.Text
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Date medication begins: " & vbTab & DogDateMedBeginsInput.Text
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Retest date: " & vbTab & vbTab & vbTab & DogRetestDateInput.Text
            para.Range.InsertParagraphAfter()
        ElseIf DogHeartwormTestNegativeButton.Checked Then
            para.Range.Text = "Dog does not have heartworms."
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Date of heartworm test: " & vbTab & vbTab & DogDateofHeartwormTestInput.Text
            para.Range.InsertParagraphAfter()
        End If

        para.Range.InsertParagraphAfter()

        If DogRabiesLabel.Checked Then
            para.Range.Text = "Rabies vaccination administered on: " & vbTab & DogRabiesVaccinationInput.Text
            para.Range.InsertParagraphAfter()
        Else
            para.Range.Text = "Rabies vaccination not administered."
            para.Range.InsertParagraphAfter()
        End If

        If DogDistemperLabel.Checked Then
            para.Range.Text = "Distemper vaccination administered on: " & vbTab & DogDistemperVaccinationInput.Text
            para.Range.InsertParagraphAfter()
        Else
            para.Range.Text = "Distemper vaccination not administered."
            para.Range.InsertParagraphAfter()
        End If

        If DogBordetellaLabel.Checked Then
            para.Range.Text = "Bordetella vaccination administered on: " & vbTab & DogBordetellaVaccinationInput.Text
            para.Range.InsertParagraphAfter()
        Else
            para.Range.Text = "Bordetella vaccination not administered."
            para.Range.InsertParagraphAfter()
        End If


        ' Save the document.
        Dim tempFileName As String = "" & newCaseNum & " Client Report"
        clientReport.SaveAs2(CurDir() & "\Reports\Client Reports\" & tempFileName)
        clientReport.SaveAs2(CurDir() & "\Reports\Client Reports\" & tempFileName & ".pdf", 17)
        clientReport.Close()
        word_app.Quit()
        reader.Close()
        System.Diagnostics.Process.Start(CurDir() & "\Reports\Client Reports\" & tempFileName & ".pdf")
    End Sub
    Private Sub UpdateExcel()
        Dim objExcel As New Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objSheet As Excel.Worksheet
        objWorkbook = objExcel.Workbooks.Open(CurDir() & "\Resources\Furry Friends Records Database.xls")
        objSheet = objWorkbook.ActiveSheet

        ' Read in all existing case numbers to determine a new case number for current animal
        Dim reader As New System.IO.StreamReader(CurDir() & "\Resources\CaseNumbers.txt")

        Dim lastCaseNum As String = 0

        Do While reader.Peek <> -1
            lastCaseNum = reader.ReadLine()
        Loop
        Dim newCaseNum As Integer = CUInt(lastCaseNum)
        reader.Close()

        'Add data to cells of the first worksheet in the new workbook
        Dim currentCaseNum As String = newCaseNum.ToString
        objSheet.Range("A" & (newCaseNum + 1)).Value = "" & currentCaseNum
        objSheet.Range("B" & (newCaseNum + 1)).Value = New_Arrival.animalName
        objSheet.Range("C" & (newCaseNum + 1)).Value = "Dog"
        objSheet.Range("D" & (newCaseNum + 1)).Value = New_Arrival.animalAge
        objSheet.Range("E" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateofBirth
        objSheet.Range("F" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateofArrival

        'Microchipped Info
        If New_Arrival.microchippedYesOrNo Then
            objSheet.Range("G" & (newCaseNum + 1)).Value = "Yes"
            objSheet.Range("I" & (newCaseNum + 1)).Value = New_Arrival.animalOwner
            objSheet.Range("J" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateContacted

        Else
            objSheet.Range("G" & (newCaseNum + 1)).Value = "No"
            objSheet.Range("K" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateOfMicrochipping
        End If

        objSheet.Range("H" & (newCaseNum + 1)).Value = New_Arrival.animalChipNumber
        objSheet.Range("L" & (newCaseNum + 1)).Value = New_Arrival.animalRelinquishingParty
        objSheet.Range("M" & (newCaseNum + 1)).Value = New_Arrival.animalCageNumber
        objSheet.Range("N" & (newCaseNum + 1)).Value = DogBreedInput.Text
        objSheet.Range("O" & (newCaseNum + 1)).Value = DogWeightInput.Text
        objSheet.Range("P" & (newCaseNum + 1)).Value = DogHairColorInput.Text

        'Dog Hair
        If DogLongHairButton.Checked Then
            objSheet.Range("Q" & (newCaseNum + 1)).Value = "Long"
        ElseIf DogShortHairButton.Checked Then
            objSheet.Range("Q" & (newCaseNum + 1)).Value = "Short"
        End If

        'Gender
        If DogAnimalSexFemaleButton.Checked Then
            objSheet.Range("R" & (newCaseNum + 1)).Value = "Female"
        ElseIf DogAnimalSexMaleButton.Checked Then
            objSheet.Range("R" & (newCaseNum + 1)).Value = "Male"
        End If

        'Spayed/Neutered Info
        If DogSpayedNoButton.Checked Then
            objSheet.Range("S" & (newCaseNum + 1)).Value = "No"
            objSheet.Range("T" & (newCaseNum + 1)).Value2 = DogDateofProcedureInput.Text
        ElseIf DogSpayedYesButton.Checked Then
            objSheet.Range("S" & (newCaseNum + 1)).Value = "Yes"
        End If

        'Flea Test Info
        If DogFleaTestNoButton.Checked Then
            objSheet.Range("U" & (newCaseNum + 1)).Value = "No"
        ElseIf DogFleaTestYesButton.Checked Then
            objSheet.Range("U" & (newCaseNum + 1)).Value = "Yes"
            objSheet.Range("V" & (newCaseNum + 1)).Value2 = DogDateofFirstTreatmentInput.Text
        End If

        'Rabies Info
        If DogRabiesLabel.Checked Then
            objSheet.Range("AA" & (newCaseNum + 1)).Value = "Yes"
            objSheet.Range("AB" & (newCaseNum + 1)).Value2 = DogRabiesVaccinationInput.Text
        End If

        'Heartworm Info
        If DogHeartwormTestPositiveButton.Checked Then
            objSheet.Range("W" & (newCaseNum + 1)).Value = "Positive"
        ElseIf DogHeartwormTestNegativeButton.Checked Then
            objSheet.Range("W" & (newCaseNum + 1)).Value = "Negative"
            objSheet.Range("X" & (newCaseNum + 1)).Value2 = DogDateofHeartwormTestInput.Text
            objSheet.Range("Y" & (newCaseNum + 1)).Value2 = DogDateMedBeginsInput.Text
            objSheet.Range("Z" & (newCaseNum + 1)).Value2 = DogRetestDateInput.Text
        End If

        'Distemper Info
        If DogDistemperVaccinationInput.Checked Then
            objSheet.Range("AC" & (newCaseNum + 1)).Value = "Yes"
        Else
            objSheet.Range("AC" & (newCaseNum + 1)).Value = "No"
        End If
        objSheet.Range("AD" & (newCaseNum + 1)).Value2 = DogDistemperVaccinationInput.Text

        'Bordetella Info
        If DogBordetellaVaccinationInput.Checked Then
            objSheet.Range("AE" & (newCaseNum + 1)).Value = "Yes"
        Else
            objSheet.Range("AE" & (newCaseNum + 1)).Value = "No"
        End If
        objSheet.Range("AF" & (newCaseNum + 1)).Value2 = DogBordetellaVaccinationInput.Text

        objExcel.ActiveWorkbook.Save()
        objExcel.Quit()
    End Sub
    Private Sub DogNextButton_Click(sender As Object, e As EventArgs) Handles DogNextButton.Click
        GenerateClientReport()
        UpdateExcel()

        Application.Exit()

        ''Close.
        'Dim save_changes As Object = False
        'clientReport.Close(save_changes)
        'word_app.Quit(save_changes)
    End Sub
End Class