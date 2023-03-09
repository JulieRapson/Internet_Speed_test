Public Class frmSpeed
    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        'Variables created here
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strInputBoxMsg As String = "Enter the number of Mbps of your home internet speed"
        Dim strInputBoxTitle As String = "Internet Speed"
        Dim strNonNumericError As String = "Error - Please enter the numeric value of your internet speed."
        Dim strNegativeMsg As String = "Error - Please enter a valid number for your speed"

        Dim intMaxInputs As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strInputBoxMsg & Space(3) & intEntries, strInputBoxTitle)

        'This Do Until statement will iterate through a loop to check to see if the 
        'max entries were reached or there was a blank
        Do Until intEntries > intMaxInputs Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstBoxSpeed.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strInputBoxMsg = strInputBoxMsg
                Else
                    strInputBoxMsg = strNonNumericError
                End If
            Else
                strInputBoxMsg = strNegativeMsg
            End If
            If intEntries <= intMaxInputs Then
                strSpeed = InputBox(strInputBoxMsg & Space(3) & intEntries, strInputBoxTitle)
            End If
        Loop

        lblAvgSpeed.Visible = True

        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAvgSpeed.Text = "Average Internet Speed:   " &
                decAverage.ToString("F2") & " Mbps "
        Else
            lblAvgSpeed.Text = "No speed values were entered."
        End If
    End Sub
End Class
