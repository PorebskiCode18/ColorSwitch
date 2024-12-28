Public Class HomePage
    Dim firstClick As Boolean
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModes.Click
        Me.Hide()
        ModesMenu.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.Hide()
        If level5complete = True Then
            Classic5.Show()
        ElseIf level4complete = True Then
            Classic5.Show()
        ElseIf level3complete = True Then
            Classic4.Show()
        ElseIf level2complete = True Then
            Classic3.Show()
        ElseIf level1Complete = True Then
            Classic2.Show()
        Else
            Classic1.Show()
        End If
    End Sub
    Private Sub HomePage_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If level5complete = True Then
            lblClassicLevel.Text = "5"
        ElseIf level4complete = True Then
            lblClassicLevel.Text = "5"
        ElseIf level3complete = True Then
            lblClassicLevel.Text = "4"
        ElseIf level2complete = True Then
            lblClassicLevel.Text = "3"
        ElseIf level1Complete = True Then
            lblClassicLevel.Text = "2"
        Else
            lblClassicLevel.Text = "1"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If firstClick = False Then
            admin = True
            firstClick = True
        ElseIf firstClick = True Then
            admin = False
            firstClick = False
        End If
    End Sub
End Class
