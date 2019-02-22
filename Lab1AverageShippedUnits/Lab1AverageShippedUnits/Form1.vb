'Name: Alan Carruthers
'Date : 1/25/2019
'Description: This file will take 7 inputs (one per day) for the number of units shipped on a given day over a week. It will store the values
'in an array, sum them, and then calculate and display the average number of units shipped per week to the user.
Public Class frmAverageUnitsShipped
    'Variable Declaration
    Dim sum As Integer                      'Integer to hold the calculated sum of shipped units
    Dim average As Double                   'Double to hold the calculated average units shipped
    Dim unitsArray(6) As Integer            'Array to store the units shipped for each day
    Dim currentDay As Integer = 1           'Integer for storing the current day for the array and textbox

    ''' <summary>
    ''' This button will accept the current text in the input textbox as an input
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Variables for input
        Dim userInput As String = String.Empty  'String to contain user's input
        Dim inputInteger As Integer             'Integer to be put into array
        Const NUMBER_OF_DAYS As Integer = 7     'Constant for the number of days that will recieve an input

        userInput = txtInput.Text               'Apply input textbox entry to userInput variable

        'If input is valid and not the final input
        If (Integer.TryParse(userInput, inputInteger)) AndAlso (inputInteger >= 0) AndAlso (inputInteger <= 1000) AndAlso (currentDay < 7) Then
            unitsArray(currentDay - 1) = inputInteger 'Enter the user's input into the appropriate array slot for the day
            txtInput.Text = ""                        'Clear the input textbox
            txtInput.Focus()                          'Return focus to the input textbox
            currentDay += 1                           'Increment the day counter
            'Below adjusts the entryDisplay label
            txtEntryDisplay.Text += unitsArray(currentDay - 2) & vbCrLf
            lblDay.Text = "Day " & currentDay         'Update the day label

        ElseIf (Not Integer.TryParse(userInput, inputInteger)) Then 'If the input is not an integer
            MessageBox.Show("Invalid Input. Input must be a whole number between 0 and 1000 inclusive. Please try again.") 'Display error message
            txtInput.Text = ""      'Clear the input textbox
            txtInput.Focus()        'Return focus to the input textbox

        ElseIf (Not Integer.TryParse(userInput, inputInteger)) AndAlso (inputInteger < 0) Or (inputInteger > 1000) Then 'If the input is outside of the valid range
            MessageBox.Show("Invalid Input. Number must be between 0 and 1000 inclusive. Please try again.")            'Display error message
            txtInput.Text = ""       'Clear the input textbox
            txtInput.Focus()         'Return focus to the input textbox

        ElseIf (Integer.TryParse(userInput, inputInteger)) AndAlso (inputInteger >= 0) AndAlso (inputInteger <= 1000) AndAlso (currentDay = 7) Then 'If the input if valid and the final input
            unitsArray(currentDay - 1) = inputInteger               'Assign the user's input into the appropriate array slot for the day
            'Below adjusts the entry display label
            txtEntryDisplay.Text += unitsArray(currentDay - 1) & vbCrLf
            txtInput.Text = ""                                      'Clear the input textbox
            txtInput.ReadOnly = True                                'Set the input textbox to ReadOnly
            txtInput.Enabled = False                                'Disable the input textbox
            btnEnter.Enabled = False                                'Disable the Enter button
            btnReset.Focus()                                        'Set focus to the reset button
            For arrayCounter As Integer = 0 To NUMBER_OF_DAYS - 1   'For loop to loop through the array and sum its elements
                sum += unitsArray(arrayCounter)
            Next arrayCounter
            average = Math.Round(sum / 7, 2)                        'Calculate the average
            lblResults.Text = "Average per day: " & average & ""    'Display the average in the Results label
        End If
    End Sub

    ''' <summary>
    ''' This button will reset the entire form to its default state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset all fields to empty text and make sure input textbox and enter button are both active, then reset appropriate variables
        txtInput.ReadOnly = False
        txtInput.Text = ""
        btnEnter.Enabled = True
        txtInput.Enabled = True
        txtEntryDisplay.Text = ""
        lblResults.Text = ""
        txtInput.Focus()
        currentDay = 1
        lblDay.Text = "Day 1"
        sum = 0
        average = 0
        Array.Clear(unitsArray, 0, 7)
    End Sub

    ''' <summary>
    ''' This button will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Application.Exit()
    End Sub
End Class
