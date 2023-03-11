'Author: Julie Rapson
'Date: 3/11/2023
'Program Description: This program will allow you to enter up to 10 numeric values
'and then do an average calculation to display your average internet speed.
Public Class frmSpeed
    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        'Variables created here are for storing numbers/calcs/entries
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D
        'These are the variables for the user messages and error messages
        Dim strInputBoxMsg As String = "Enter the number of Mbps of your home internet speed"
        Dim strInputBoxTitle As String = "Internet Speed"
        Dim strNonNumericError As String = "Error - Please enter the numeric value of your internet speed."
        Dim strNegativeMsg As String = "Error - Please enter a valid number for your speed"
        'These variables will be used for controlling the loop behavior and setting
        'boundries on how the decisions are made
        Dim intMaxInputs As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strInputBoxMsg & Space(3) & intEntries, strInputBoxTitle)

        'This Do Until statement will iterate through a loop to check to see if the 
        'max entries were reached or there was a blank.  Will also check for non numeric and negative numbers.
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
        'This is now setting the label that displays the average to visable
        lblAvgSpeed.Visible = True
        'below is an if statement to make sure the entries are more than 1 in order to do the caluculation
        'then deisplay the average, else it will display a message.
        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAvgSpeed.Text = "Average Internet Speed:   " &
                decAverage.ToString("F2") & " Mbps "
        Else
            lblAvgSpeed.Text = "No speed values were entered."
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'I created the clear not only because it was in the demo video, but I noticed if you don't have a
        'clear option, you can start entering more than 10 speed numbers.
        lstBoxSpeed.Items.Clear()
        lblAvgSpeed.Visible = False

    End Sub

    Private Sub frmSpeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.ForeColor = Color.DarkBlue
    End Sub
End Class
