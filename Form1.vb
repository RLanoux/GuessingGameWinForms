Public Class Form1

    'Declare global variables
    Dim bStart As [Boolean] = False
    Dim iTries As Int32 = 0
    Dim rnd As New Random()
    Dim iHighValue As Int32 = 0
    Dim iMaxNumber As Int32 = 0
    Dim iMyNum As Int32 = 0
    Dim iGuess As Int32 = 0
    Dim iMyGuess As Int32 = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboHighValue.Focus()
    End Sub

    Private Sub DoWork()
        If bStart Then
            iTries += 1
            tslGuesses.Text = "Number of Guesses: " + Convert.ToString(iTries)
            'Start the loop for his guesses
            For i As Int32 = 0 To iMaxNumber - 1
                'Obtain a guess
                iGuess = iMyGuess

                'Check guess against computer's number and give appropriate response
                If iMyNum < iGuess Then
                    tslStatus.Text = "That number is too high!"
                ElseIf iMyNum > iGuess Then
                    tslStatus.Text = "That number is too low!"
                Else
                    tslStatus.Text = "That number is correct! It took you " + iTries.ToString + " tries to figure it out!"
                End If
            Next
        End If
    End Sub

    Private Sub txtSetHighValue_Click(sender As System.Object, e As System.EventArgs) Handles btnSetHighValue.Click
        iHighValue = iMaxNumber
        'Determine the number to be guessed
        iMyNum = rnd.[Next](iMaxNumber)
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        iMyGuess = Convert.ToInt32(txtGuess.Text)
        DoWork()
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        bStart = True
        btnStart.Enabled = False
        btnExit.Enabled = False
        lblHighValue.Visible = False
        cboHighValue.Visible = False
        btnSetHighValue.Visible = False
    End Sub

    Private Sub btnRestart_Click(sender As System.Object, e As System.EventArgs) Handles btnRestart.Click
        bStart = False
        btnStart.Enabled = True
        btnExit.Enabled = True
        lblHighValue.Visible = True
        cboHighValue.Visible = True
        btnSetHighValue.Visible = True
        tslStatus.Text = "Ready!"
        tslGuesses.Text = " "
        iHighValue = 0
        iMyNum = 0
        iMaxNumber = 0
        iTries = 0
        iGuess = 0
        cboHighValue.Focus()
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        MessageBox.Show("Awwww. Can't figure it out, dummy?",
                        "Guessing Game",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop)
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboHighValue_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboHighValue.SelectedIndexChanged
        Select Case (cboHighValue.Text)
            Case "1000"
                iMaxNumber = 1000
            Case "10,000"
                iMaxNumber = 10000
            Case "100,000"
                iMaxNumber = 100000
            Case "1,000,000"
                iMaxNumber = 1000000
        End Select
    End Sub
End Class
