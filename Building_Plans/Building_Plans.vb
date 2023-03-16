Public Class Building_Plans
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        radInchesToMeters.Checked = True
        radMetersToInches.Checked = False
        txtInput.Focus()
        lblAnswer.Text = ""

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declare variables
        Dim intNumber As Integer = 0
        Dim decInches As Decimal = 0.0254D
        Dim decMeters As Decimal = 39.3701D
        Dim decTotal As Decimal

        'Checks to see is the input is a number value
        If IsNumeric(txtInput.Text) Then
            intNumber = Convert.ToInt32(txtInput.Text)
            'checks to see if the number is positive
            If intNumber > 0 Then
                'calcualtes the conversions
                If radInchesToMeters.Checked Then
                    'displays conversion from inches to meters
                    decTotal = (intNumber * decInches)
                    lblAnswer.Text = intNumber & " inches is " & decTotal & " meters."
                    lblAnswer.Visible = True
                ElseIf radMetersToInches.Checked Then
                    'displays conversion from meters to inches
                    decTotal = (intNumber * decMeters)
                    lblAnswer.Text = intNumber & " meters is " & decTotal & " inches."
                    lblAnswer.Visible = True
                End If
            Else
                'Displays error message if user enterd a negative value
                MsgBox("Enter a positive number", , "Input Error")
                lblAnswer.Visible = False
            End If
        Else
            'Displays error message if user entered a nonnumeric value
            MsgBox("Enter a positive number", , "Input Error")
            lblAnswer.Visible = False
        End If

    End Sub
End Class
