Public Class ModesMenu
    Dim levelsCompleted As String
    Dim Percent As String
    Private Sub btnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        Me.Hide()
        ClassicModes.Show()
    End Sub

    Private Sub btnBreaker_Click(sender As Object, e As EventArgs) Handles btnBreaker.Click
        Me.Hide()
        BrickBreakerModes.Show()
    End Sub

    Private Sub btnFlappy_Click(sender As Object, e As EventArgs) Handles btnFlappy.Click
        Me.Hide()
        FlappyBirdModes.Show()
    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        Me.Hide()
        BlackOutModes.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub ModesMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If level1Complete = True Then
            levelsCompleted = 1
        ElseIf level2complete = True Then
            levelsCompleted = 2
        ElseIf level3complete = True Then
            levelsCompleted = 3
        ElseIf level4complete = True Then
            levelsCompleted = 4
        ElseIf level5complete = True Then
            levelsCompleted = 5
        Else
            levelsCompleted = 0
        End If
        Percent = levelsCompleted / 5 * 100
        lblClassicPerc.Text = Percent + "%"
        lblClassicComplete.Text = levelsCompleted + "/5"
    End Sub
End Class