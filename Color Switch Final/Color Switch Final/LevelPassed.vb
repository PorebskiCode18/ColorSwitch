Public Class LevelPassed
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If levelType = "Classic" And level = 1 Then
            Classic2.Show()
        ElseIf levelType = "Classic" And level = 2 Then
            Classic3.Show()
        ElseIf levelType = "Classic" And level = 3 Then
            Classic4.Show()
        ElseIf levelType = "Classic" And level = 4 Then
            Classic5.Show()
        End If
    End Sub

    Private Sub LevelPassed_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblLevel.Text = "Level " & level
        lblLevelType.Text = levelType
    End Sub
End Class