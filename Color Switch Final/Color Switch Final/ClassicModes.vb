Public Class ClassicModes
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        ModesMenu.Show()
    End Sub

    Private Sub btnLevel1_Click(sender As Object, e As EventArgs) Handles btnLevel1.Click
        Me.Hide()
        Classic1.Show()
    End Sub

    Private Sub btnLevel2_Click(sender As Object, e As EventArgs) Handles btnLevel2.Click
        Me.Hide()
        Classic2.Show()
    End Sub

    Private Sub btnLevel3_Click(sender As Object, e As EventArgs) Handles btnLevel3.Click
        Me.Hide()
        Classic3.Show()
    End Sub

    Private Sub btnLevel4_Click(sender As Object, e As EventArgs) Handles btnLevel4.Click
        Me.Hide()
        Classic4.Show()
    End Sub

    Private Sub btnLevel5_Click(sender As Object, e As EventArgs) Handles btnLevel5.Click
        Me.Hide()
        Classic5.Show()
    End Sub

    Private Sub ClassicModes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If level1Complete = True Then
            btnLevel2.Enabled = True
        End If
        If level2complete = True Then
            btnLevel3.Enabled = True
        ElseIf level3complete = True Then
            btnLevel4.Enabled = True
        ElseIf level4complete = True Then
            btnLevel5.Enabled = True
        End If
    End Sub
End Class