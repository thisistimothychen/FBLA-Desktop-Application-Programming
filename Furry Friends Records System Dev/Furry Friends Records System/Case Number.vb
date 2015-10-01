Imports Word = Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class CaseNumber
    Private Sub NewArrivalButton_Click(sender As Object, e As EventArgs) Handles NewArrivalButton.Click
        Dim newArrivalForm As New_Arrival
        newArrivalForm = New New_Arrival
        newArrivalForm.Show()
        newArrivalForm = Nothing
        Me.Hide()
    End Sub
    Private Sub CostReportButton_Click(sender As Object, e As EventArgs) Handles CostReportButton.Click
        Dim objExcel As New Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objSheet As Excel.Worksheet
        objWorkbook = objExcel.Workbooks.Open(CurDir() & "\Resources\Furry Friends Records Database.xls")
        objSheet = objWorkbook.ActiveSheet

        ' Get the Word application object.
        Dim word_app As Word._Application = New Word.ApplicationClass()

        ' Make Word visible (optional).
        'word_app.Visible = True

        ' Create the Word document.
        Dim costReport As Word._Document = word_app.Documents.Add()

        Dim costs, testCosts, totalCosts As Integer
        Dim caseNum As Integer = CUInt(CaseNumberInput.Text)
        Dim currentDate As Date = Today 'Today's Date

        Dim rowNum As Integer = caseNum + 1

        Dim arrivalDate As Date = DateValue(objSheet.Range("F" & rowNum).Text) ''''''''''''''''''''''
        Dim yearsInShelter As Integer = DateDiff(DateInterval.Year, arrivalDate, currentDate)
        Dim monthsInShelter As Integer = DateDiff(DateInterval.Month, arrivalDate, currentDate)
        Dim daysInShelter As Integer = DateDiff(DateInterval.Day, arrivalDate, currentDate)

        ' Create title
        Dim para As Word.Paragraph = costReport.Paragraphs.Add()
        para.Range.Text = "Furry Friends Animal Shelter"
        para.Range.Style = "Heading 1"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Format.SpaceAfter = 0
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Cost Report"
        para.Range.Style = "Heading 2"
        para.Range.Text = "Generated on " & currentDate
        para.Range.Style = "Heading 2"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()

        'Animal Info
        para.Range.Text = "Case Number:   " & objSheet.Range("A" & rowNum).Text & vbTab & vbTab & vbTab _
                        & "Animal Name:   " & objSheet.Range("B" & rowNum).Text
        para.Format.SpaceAfter = 0
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Date of Arrival:   " & objSheet.Range("F" & rowNum).Text & vbTab & vbTab & "Animal Type:   " & objSheet.Range("C" & rowNum).Text
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()

        'Microchipping
        If objSheet.Range("G" & rowNum).Text = "No" Then
            costs += 5
            para.Range.Text = "Micro-chipping" & vbTab & vbTab & vbTab & "$5.00"
            para.Range.InsertParagraphAfter()
        End If

        'Once a Month Flea Treatments
        If monthsInShelter > 0 Then
            costs += 10 * monthsInShelter + 10 '+10 is the initial treatment upon arrival
            para.Range.Text = "Flea Treatments" & vbTab & vbTab & vbTab & "$" & (10 * monthsInShelter + 10) & ".00"
            para.Range.InsertParagraphAfter()
        End If

        'Vaccinations
        If objSheet.Range("AA" & rowNum).Text = "Yes" Then
            costs += 15
            para.Range.Text = "Rabies Vaccination" & vbTab & vbTab & "$15.00"
            para.Range.InsertParagraphAfter()
        End If
        If objSheet.Range("AB" & rowNum).Text = "Yes" Then
            costs += 15
            para.Range.Text = "Distemper Vaccination" & vbTab & vbTab & vbTab & "$15.00"
            para.Range.InsertParagraphAfter()
        End If
        If objSheet.Range("AC" & rowNum).Text = "Yes" Then
            costs += 15
            para.Range.Text = "Bordetella Vaccination" & vbTab & vbTab & "$15.00"
            para.Range.InsertParagraphAfter()
        End If

        'Other Vaccinations
        If objSheet.Range("AL" & rowNum).Value > "0" Then
            Dim numVaccinations As Integer = CUInt(objSheet.Range("AL" & rowNum).Value) ''''''''''''''''''''''''''''''''''''''''''
            costs += numVaccinations * 15
            para.Range.Text = "Other vaccinations" & vbTab & vbTab & "$" & (numVaccinations * 15) & ".00" & vbNewLine & vbTab & "(" & objSheet.Range("AM" & rowNum).Text & ")"
            para.Range.InsertParagraphAfter()
        End If

        'Heartworm Test
        If Not objSheet.Range("W" & rowNum).Text = "" Then
            testCosts += 10
            para.Range.Text = "Heartworm Test" & vbTab & vbTab & vbTab & "$10.00"
            para.Range.InsertParagraphAfter()
        End If

        'Feline Leukemia Test
        If objSheet.Range("AI" & rowNum).Text = "Positive" Then
            testCosts += 15
            para.Range.Text = "Feline Leukemia Test" & vbTab & vbTab & "$15.00"
            para.Range.InsertParagraphAfter()
        End If

        'Yearly Rabies Tests (state law)
        Dim dateOfRabiesTest As Date = DateValue(objSheet.Range("F" & rowNum).Text)

        Dim yearsSinceRabiesTest As Integer = DateDiff(DateInterval.Year, dateOfRabiesTest, currentDate)
        If yearsSinceRabiesTest > 0 Then
            testCosts += (30 * yearsSinceRabiesTest) + 1
            para.Range.Text = "Yearly Rabies Tests" & vbTab & vbTab & "$" & (30 * (yearsSinceRabiesTest + 1)) & ".00"
            para.Range.InsertParagraphAfter()
        End If

        'Daily Tests
        If daysInShelter > 0 Then
            testCosts += 10 * daysInShelter
            para.Range.Text = "Daily Tests" & vbTab & vbTab & vbTab & "$" & (10 * daysInShelter) & ".00"
            para.Range.InsertParagraphAfter()
        End If

        'Once a month flea preventions
        If monthsInShelter > 0 Then
            testCosts += 3 * monthsInShelter
            para.Range.Text = "Flea Preventions" & vbTab & vbTab & "$" & (3 * monthsInShelter) & ".00"
            para.Range.InsertParagraphAfter()
        End If

        'Spay/Neutered
        If objSheet.Range("S" & rowNum).Text = "No" Then
            testCosts += 75
            para.Range.Text = "Spay/Neuter Procedure" & vbTab & vbTab & "$75.00"
            para.Range.InsertParagraphAfter()
        End If

        totalCosts = costs + testCosts

        totalCosts = costs + testCosts
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()

        para.Range.Text = "General Costs" & vbTab & vbTab & vbTab & "$" & costs & ".00"
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Test Costs" & vbTab & vbTab & vbTab & "$" & testCosts & ".00"
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Total Costs" & vbTab & vbTab & vbTab & "$" & totalCosts & ".00"
        para.Range.InsertParagraphAfter()
        para.Range.Font.Bold = True

        ' Save the document.
        Dim tempFileName As String = "" & caseNum & " Cost Report"
        costReport.SaveAs2(CurDir() & "\Reports\Cost Reports\" & tempFileName)
        costReport.SaveAs2(CurDir() & "\Reports\Cost Reports\" & tempFileName & ".pdf", 17)
        costReport.Close()
        word_app.Quit()
        objExcel.Quit()
        System.Diagnostics.Process.Start(CurDir() & "\Reports\Cost Reports\" & tempFileName & ".pdf")
    End Sub
    Private Sub CaseNumber_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub InventoryReportButton_Click(sender As Object, e As EventArgs) Handles InventoryReportButton.Click
        Dim objExcel As New Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objSheet As Excel.Worksheet
        objWorkbook = objExcel.Workbooks.Open(CurDir() & "\Resources\Furry Friends Records Database.xls")
        objSheet = objWorkbook.ActiveSheet


        ' Get the Word application object.
        Dim word_app As Word._Application = New Word.ApplicationClass()

        ' Make Word visible (optional).
        'word_app.Visible = True

        ' Create the Word document.
        Dim inventoryReport As Word._Document = word_app.Documents.Add()

        ' Create title
        Dim para As Word.Paragraph = inventoryReport.Paragraphs.Add()
        para.Range.Text = "Furry Friends Animal Shelter"
        para.Range.Style = "Heading 1"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Format.SpaceAfter = 0
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Inventory Report"
        para.Range.Style = "Heading 2"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()

        Dim caseNum As Integer = 2

        'Create "table" header
        para.Range.Text = "Case Number" & vbTab & vbTab & "Animal Name" & vbTab & vbTab & "Animal Type" & vbTab & vbTab & "Cage Number"
        para.Range.Font.Bold = True
        para.Range.InsertParagraphAfter()

        para.Range.Font.Bold = False

        While Not (objSheet.Range("A" & caseNum).Text = "")
            'objSheet.Range("A" & caseNum).Value() == Case Number == (caseNum+1)
            'objSheet.Range("C" & caseNum).Value() == Animal Type
            'objSheet.Range("M" & caseNum).Value() == Cage Number/Location
            para.Range.Text = objSheet.Range("A" & caseNum).Value() & vbTab & vbTab & vbTab _
                            & objSheet.Range("B" & caseNum).Value() & vbTab & vbTab & vbTab _
                            & objSheet.Range("C" & caseNum).Value() & vbTab & vbTab & vbTab _
                            & objSheet.Range("M" & caseNum).Value()
            para.Range.InsertParagraphAfter()
            caseNum = caseNum + 1
        End While

        objExcel.ActiveWorkbook.Close()
        objExcel.Quit()

        ' Save the document.
        Dim tempFileName As String = "Inventory Report"
        inventoryReport.SaveAs2(CurDir() & "\Reports\" & tempFileName)
        inventoryReport.SaveAs2(CurDir() & "\Reports\" & tempFileName & ".pdf", 17)
        inventoryReport.Close()
        word_app.Quit()
        objExcel.Quit()
        System.Diagnostics.Process.Start(CurDir() & "\Reports\" & tempFileName & ".pdf")
    End Sub
    Private Sub ClientReportButton_Click(sender As Object, e As EventArgs) Handles ClientReportButton.Click
        Dim caseNum As Integer = CUInt(CaseNumberInput.Text)
        System.Diagnostics.Process.Start(CurDir() & "\Reports\Client Reports\" & caseNum & " Client Report.pdf")
    End Sub
    Private Function generateCost(ByVal caseNum As Integer) As Integer
        Dim objExcel As New Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objSheet As Excel.Worksheet
        objWorkbook = objExcel.Workbooks.Open(CurDir() & "\Resources\Furry Friends Records Database.xls")
        objSheet = objWorkbook.ActiveSheet

        Dim costs, testCosts, totalCosts As Integer
        Dim currentDate As Date = Today 'Today's Date
        Dim rowNum As Integer = caseNum + 1

        Dim arrivalDate As Date = DateValue(objSheet.Range("F" & rowNum).Text)
        Dim yearsInShelter As Integer = DateDiff(DateInterval.Year, arrivalDate, currentDate)
        Dim monthsInShelter As Integer = DateDiff(DateInterval.Month, arrivalDate, currentDate)
        Dim daysInShelter As Integer = DateDiff(DateInterval.Day, arrivalDate, currentDate)

        'Microchipping
        If objSheet.Range("G" & rowNum).Text = "No" Then
            costs += 5
        End If

        'Once a Month Flea Treatments
        If monthsInShelter > 0 Then
            costs += 10 * monthsInShelter + 10 '+10 is the initial treatment upon arrival
        End If

        'Vaccinations
        If objSheet.Range("AA" & rowNum).Text = "Yes" Then
            costs += 15
        End If
        If objSheet.Range("AB" & rowNum).Text = "Yes" Then
            costs += 15
        End If
        If objSheet.Range("AC" & rowNum).Text = "Yes" Then
            costs += 15
        End If

        'Other Vaccinations
        If objSheet.Range("AL" & rowNum).Value > "0" Then
            Dim numVaccinations As Integer = CUInt(objSheet.Range("AL" & rowNum).Value) ''''''''''''''''''''''''''''''''''''''''''
            costs += numVaccinations * 15
        End If

        'Heartworm Test
        If Not objSheet.Range("W" & rowNum).Text = "" Then
            testCosts += 10
        End If

        'Feline Leukemia Test
        If objSheet.Range("AI" & rowNum).Text = "Positive" Then
            testCosts += 15
        End If

        'Yearly Rabies Tests (state law)
        Dim dateOfRabiesTest As Date = DateValue(objSheet.Range("F" & rowNum).Text)

        Dim yearsSinceRabiesTest As Integer = DateDiff(DateInterval.Year, dateOfRabiesTest, currentDate)
        If yearsSinceRabiesTest > 0 Then
            testCosts += (30 * yearsSinceRabiesTest) + 1
        End If

        'Daily Tests
        If daysInShelter > 0 Then
            testCosts += 10 * daysInShelter
        End If

        'Once a month flea preventions
        If monthsInShelter > 0 Then
            testCosts += 3 * monthsInShelter
        End If

        'Spay/Neutered
        If objSheet.Range("S" & rowNum).Text = "No" Then
            testCosts += 75
        End If

        totalCosts = costs + testCosts

        objExcel.Quit()

        Return (totalCosts)
    End Function
    Private Sub ExpenseReportButton_Click(sender As Object, e As EventArgs) Handles ExpenseReportButton.Click
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
        Dim intLastCaseNum As Integer = CUInt(lastCaseNum)
        reader.Close()


        ' Get the Word application object.
        Dim word_app As Word._Application = New Word.ApplicationClass()

        ' Make Word visible (optional).
        'word_app.Visible = True

        ' Create the Word document.
        Dim inventoryReport As Word._Document = word_app.Documents.Add()

        ' Create title
        Dim para As Word.Paragraph = inventoryReport.Paragraphs.Add()
        para.Range.Text = "Furry Friends Animal Shelter"
        para.Range.Style = "Heading 1"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Format.SpaceAfter = 0
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Expenses Report"
        para.Range.Style = "Heading 2"
        para.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()

        'Create "table" header
        para.Range.Text = "Case Number" & vbTab & "Animal Name" & vbTab & vbTab & "Animal Type" & vbTab & vbTab & "Cost"
        para.Range.Font.Bold = True
        para.Range.InsertParagraphAfter()
        para.Range.Font.Bold = False



        Dim totalExpenses As Integer = 0

        For currentCaseNum As Integer = 1 To intLastCaseNum
            'objSheet.Range("A" & caseNum).Value() == Case Number == (caseNum+1)
            'objSheet.Range("C" & caseNum).Value() == Animal Type
            'objSheet.Range("M" & caseNum).Value() == Cage Number/Location
            para.Range.Text = objSheet.Range("A" & (currentCaseNum + 1)).Value() & vbTab & vbTab _
                            & objSheet.Range("B" & (currentCaseNum + 1)).Value() & vbTab & vbTab & vbTab _
                            & objSheet.Range("C" & (currentCaseNum + 1)).Value() & vbTab & vbTab & vbTab _
                            & "$" & generateCost(currentCaseNum) & ".00"
            para.Range.InsertParagraphAfter()
            totalExpenses += generateCost(currentCaseNum)
        Next

        para.Range.InsertParagraphAfter()
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Total Expenses: " & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "$" & totalExpenses & ".00"
        para.Range.Font.Bold = True
        para.Range.InsertParagraphAfter()
        para.Range.Text = "Average Animal Expense: " & vbTab & vbTab & vbTab & vbTab & vbTab & "$" & (totalExpenses / intLastCaseNum)


        ' Save the document.
        Dim tempFileName As String = "Expenses Report"
        inventoryReport.SaveAs2(CurDir() & "\Reports\" & tempFileName)
        inventoryReport.SaveAs2(CurDir() & "\Reports\" & tempFileName & ".pdf", 17)
        inventoryReport.Close()
        word_app.Quit()
        objExcel.Quit()
        System.Diagnostics.Process.Start(CurDir() & "\Reports\" & tempFileName & ".pdf")
    End Sub
End Class