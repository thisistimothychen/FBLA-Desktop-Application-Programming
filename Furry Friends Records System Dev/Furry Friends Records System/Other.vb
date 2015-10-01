Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class Other
    Private Sub OtherWeightInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OtherWeightInput.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub OtherNumVaccinationsInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OtherNumVaccinationsInput.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub OtherPreviousButton_Click(sender As Object, e As EventArgs) Handles OtherPreviousButton.Click
        New_Arrival.Show()
        Me.Hide()
    End Sub
    Private Sub GenerateClientReport()
        ' Get the Word Application object.
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

        para.Range.Text = "Animal Type: " & vbTab & vbTab & OtherAnimalTypeInput.Text
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Weight: " & vbTab & vbTab & OtherWeightInput.Text
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()

        para.Range.Text = "Animal Appearance Description: " & vbTab & OtherAnimalAppearanceInput.Text
        para.Range.InsertParagraphAfter()

        para.Range.Text = "Number of Vaccinations: " & vbTab & vbTab & OtherNumVaccinationsInput.Text
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Vaccinations: " & vbTab & vbTab & vbTab & vbTab & OtherVaccinationsInput.Text
        para.Range.InsertParagraphAfter()

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
        objSheet.Range("C" & (newCaseNum + 1)).Value = OtherAnimalTypeInput.Text
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
        objSheet.Range("O" & (newCaseNum + 1)).Value = OtherWeightInput.Text

        objSheet.Range("AK" & (newCaseNum + 1)).Value = OtherAnimalAppearanceInput.Text
        objSheet.Range("AL" & (newCaseNum + 1)).Value = OtherNumVaccinationsInput.Text
        objSheet.Range("AM" & (newCaseNum + 1)).Value = OtherVaccinationsInput.Text

        objExcel.ActiveWorkbook.Save()
        reader.Close()
        objExcel.Quit()
    End Sub
    Private Sub OtherNextButton_Click(sender As Object, e As EventArgs) Handles OtherNextButton.Click
        GenerateClientReport()
        UpdateExcel()



        Application.Exit()

        ''Close.
        'Dim save_changes As Object = False
        'clientReport.Close(save_changes)
        'word_app.Quit(save_changes)
    End Sub
End Class