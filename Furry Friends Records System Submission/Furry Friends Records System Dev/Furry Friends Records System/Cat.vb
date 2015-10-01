Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class Cat
    Private Sub CatPreviousButton_Click(sender As Object, e As EventArgs) Handles CatPreviousButton.Click
        New_Arrival.Show()
        Me.Hide()
    End Sub
    Private Sub CatWeightInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CatWeightInput.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub CatSpayedNoButton_CheckedChanged(sender As Object, e As EventArgs) Handles CatSpayedNoButton.CheckedChanged
        If Me.CatSpayedNoButton.Checked Then
            CatDateofProcedureLabel.Enabled = True
            CatDateofProcedureInput.Enabled = True
        End If
    End Sub

    Private Sub CatSpayedYesButton_CheckedChanged(sender As Object, e As EventArgs) Handles CatSpayedYesButton.CheckedChanged
        If Me.CatSpayedYesButton.Checked Then
            CatDateofProcedureLabel.Enabled = False
            CatDateofProcedureInput.Enabled = False
        End If
    End Sub

    Private Sub CatFleaTestYesButton_CheckedChanged(sender As Object, e As EventArgs) Handles CatFleaTestYesButton.CheckedChanged
        If Me.CatFleaTestYesButton.Checked Then
            CatDateofFirstTreatmentLabel.Enabled = True
            CatDateofFirstTreatmentInput.Enabled = True
        End If
    End Sub

    Private Sub CatFleaTestNoButton_CheckedChanged(sender As Object, e As EventArgs) Handles CatFleaTestNoButton.CheckedChanged
        If Me.CatFleaTestNoButton.Checked Then
            CatDateofFirstTreatmentLabel.Enabled = False
            CatDateofFirstTreatmentInput.Enabled = False
        End If
    End Sub

    Private Sub CatDeclawedYesButton_CheckedChanged(sender As Object, e As EventArgs) Handles CatDeclawedYesButton.CheckedChanged
        If Me.CatDeclawedYesButton.Checked Then
            CatDeclawingLabel.Enabled = False
            CatDeclawingTwoButton.Enabled = False
            CatDeclawingFourButton.Enabled = False
            CatDeclawingGroupBox.Enabled = False
        End If
    End Sub

    Private Sub CatDeclawedNoButton_CheckedChanged(sender As Object, e As EventArgs) Handles CatDeclawedNoButton.CheckedChanged
        If Me.CatDeclawedNoButton.Checked Then
            CatDeclawingLabel.Enabled = True
            CatDeclawingTwoButton.Enabled = True
            CatDeclawingFourButton.Enabled = True
            CatDeclawingGroupBox.Enabled = True
        End If
    End Sub

    Private Sub CatRabiesLabel_CheckedChanged(sender As Object, e As EventArgs) Handles CatRabiesLabel.CheckedChanged
        If Me.CatRabiesLabel.Checked Then
            CatRabiesVaccinationInput.Enabled = True
        Else
            CatRabiesVaccinationInput.Enabled = False
        End If
    End Sub

    Private Sub Cat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub Cat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reader As New System.IO.StreamReader(CurDir() & "\Resources\CatBreeds.txt")

        For counter As Integer = 1 To 100
            Dim tempBreed As String
            tempBreed = reader.ReadLine()

            CatBreedInput.Items.Add(tempBreed)
            CatBreedInput.AutoCompleteCustomSource.Add(tempBreed)
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

        para.Range.Text = "Breed: " & vbTab & vbTab & vbTab & CatBreedInput.Text & " (Cat)"
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Weight: " & vbTab & vbTab & CatWeightInput.Text
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Hair Color: " & vbTab & vbTab & CatHairColorInput.Text
        para.Range.InsertParagraphAfter()

        If CatLongHairButton.Checked Then
            para.Range.Text = "Type of hair: " & vbTab & vbTab & "Long"
            para.Range.InsertParagraphAfter()
        ElseIf CatShortHairButton.Checked Then
            para.Range.Text = "Type of hair: " & vbTab & vbTab & "Short"
            para.Range.InsertParagraphAfter()
        End If

        If CatAnimalSexFemaleButton.Checked Then
            para.Range.Text = "Animal Sex: " & vbTab & vbTab & "Female"
            para.Range.InsertParagraphAfter()
        ElseIf CatAnimalSexMaleButton.Checked Then
            para.Range.Text = "Animal Sex: " & vbTab & vbTab & "Male"
            para.Range.InsertParagraphAfter()
        End If

        para.Range.InsertParagraphAfter()

        If CatSpayedNoButton.Checked Then
            para.Range.Text = "Cat is not spayed or neutered."
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Date chosen for procedure: " & vbTab & CatDateofProcedureInput.Text
            para.Range.InsertParagraphAfter()

        ElseIf CatSpayedYesButton.Checked Then
            para.Range.Text = "Cat is spayed or neutered."
            para.Range.InsertParagraphAfter()
        End If

        If CatFleaTestNoButton.Checked Then
            para.Range.Text = "Cat is not checked for fleas."
            para.Range.InsertParagraphAfter()
        ElseIf CatFleaTestYesButton.Checked Then
            para.Range.Text = "Cat is checked for fleas."
            para.Range.InsertParagraphAfter()
            para.Range.Text = vbTab & "Date of first treatment: " & vbTab & vbTab & CatDateofFirstTreatmentInput.Text
            para.Range.InsertParagraphAfter()
        End If

        If CatFelineLeukemiaTestPositiveButton.Checked Then
            para.Range.Text = "Positive Feline Leukemia test."
            para.Range.InsertParagraphAfter()
        ElseIf CatFelineLeukemiaTestNegativeButton.Checked Then
            para.Range.Text = "Negative Feline Leukemia test."
            para.Range.InsertParagraphAfter()
        End If

        If CatRabiesLabel.Checked Then
            para.Range.Text = "Rabies vaccination administered on: " & vbTab & CatRabiesVaccinationInput.Text
            para.Range.InsertParagraphAfter()
        Else
            para.Range.Text = "Rabies vaccination not administered."
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
        objSheet.Range("C" & (newCaseNum + 1)).Value = "Cat"
        objSheet.Range("D" & (newCaseNum + 1)).Value = New_Arrival.animalAge
        objSheet.Range("E" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateofBirth
        objSheet.Range("F" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateofArrival

        'Microchipped Info
        If New_Arrival.microchippedYesOrNo Then
            objSheet.Range("G" & (newCaseNum + 1)).Value = "Yes"
        Else
            objSheet.Range("G" & (newCaseNum + 1)).Value = "No"
        End If

        objSheet.Range("H" & (newCaseNum + 1)).Value = New_Arrival.animalChipNumber
        objSheet.Range("I" & (newCaseNum + 1)).Value = New_Arrival.animalOwner
        objSheet.Range("J" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateContacted
        objSheet.Range("K" & (newCaseNum + 1)).Value2 = New_Arrival.animalDateOfMicrochipping
        objSheet.Range("L" & (newCaseNum + 1)).Value = New_Arrival.animalRelinquishingParty
        objSheet.Range("M" & (newCaseNum + 1)).Value = New_Arrival.animalCageNumber
        objSheet.Range("N" & (newCaseNum + 1)).Value = CatBreedInput.Text
        objSheet.Range("O" & (newCaseNum + 1)).Value = CatWeightInput.Text
        objSheet.Range("P" & (newCaseNum + 1)).Value = CatHairColorInput.Text

        'Cat Hair
        If CatLongHairButton.Checked Then
            objSheet.Range("Q" & (newCaseNum + 1)).Value = "Long"
        ElseIf CatShortHairButton.Checked Then
            objSheet.Range("Q" & (newCaseNum + 1)).Value = "Short"
        End If

        'Gender
        If CatAnimalSexFemaleButton.Checked Then
            objSheet.Range("R" & (newCaseNum + 1)).Value = "Female"
        ElseIf CatAnimalSexMaleButton.Checked Then
            objSheet.Range("R" & (newCaseNum + 1)).Value = "Male"
        End If

        'Spayed/Neutered Info
        If CatSpayedNoButton.Checked Then
            objSheet.Range("S" & (newCaseNum + 1)).Value = "No"
            objSheet.Range("T" & (newCaseNum + 1)).Value2 = CatDateofProcedureInput.Text
        ElseIf CatSpayedYesButton.Checked Then
            objSheet.Range("S" & (newCaseNum + 1)).Value = "Yes"
        End If

        'Flea Test Info
        If CatFleaTestNoButton.Checked Then
            objSheet.Range("U" & (newCaseNum + 1)).Value = "No"
        ElseIf CatFleaTestYesButton.Checked Then
            objSheet.Range("U" & (newCaseNum + 1)).Value = "Yes"
            objSheet.Range("V" & (newCaseNum + 1)).Value2 = CatDateofFirstTreatmentInput.Text
        End If

        'Rabies Info
        If CatRabiesLabel.Checked Then
            objSheet.Range("AA" & (newCaseNum + 1)).Value = "Yes"
            objSheet.Range("AB" & (newCaseNum + 1)).Value2 = CatRabiesVaccinationInput.Text
        End If

        'Cat Declawing Info
        If CatDeclawedYesButton.Checked Then
            objSheet.Range("AG" & (newCaseNum + 1)).Value = "Yes"
        ElseIf CatDeclawedNoButton.Checked Then
            objSheet.Range("AG" & (newCaseNum + 1)).Value = "No"
            If CatDeclawingTwoButton.Checked Then
                objSheet.Range("AH" & (newCaseNum + 1)).Value = "Two"
            ElseIf CatDeclawingFourButton.Checked Then
                objSheet.Range("AH" & (newCaseNum + 1)).Value = "Four"
            End If
        End If

        'Cat Feline Leukemia Test Info
        If CatFelineLeukemiaTestPositiveButton.Checked Then
            objSheet.Range("AI" & (newCaseNum + 1)).Value = "Positive"
            objSheet.Range("AJ" & (newCaseNum + 1)).Value2 = CatDateofFelineLeukemiaTestInput.Text
        ElseIf CatFelineLeukemiaTestNegativeButton.Checked Then
            objSheet.Range("AI" & (newCaseNum + 1)).Value = "Negative"
        End If

        objExcel.ActiveWorkbook.Save()
        objExcel.Quit()
    End Sub
    Private Sub CatNextButton_Click(sender As Object, e As EventArgs) Handles CatNextButton.Click
        GenerateClientReport()
        UpdateExcel()



        Application.Exit()

        ''Close.
        'Dim save_changes As Object = False
        'clientReport.Close(save_changes)
        'word_app.Quit(save_changes)
    End Sub
End Class