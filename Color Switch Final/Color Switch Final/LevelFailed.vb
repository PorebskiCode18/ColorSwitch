Public Class LevelFailed
    Private Sub LevelFailed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLevel.Text = "Level " & level
        lblLevelType.Text = levelType
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If level = 1 Then
            Me.Hide()
            Classic1.Show()
        ElseIf level = 2 Then
            Me.Hide()
            Classic2.Show()
        ElseIf level = 3 Then
            Me.Hide()
            Classic3.Show()
        ElseIf level = 4 Then
            Me.Hide()
            Classic4.Show()
        ElseIf level = 5 Then
            Me.Hide()
            Classic5.Show()
        End If
    End Sub
End Class