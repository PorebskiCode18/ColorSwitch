Public Class Classic2
    Dim firstPress As Boolean
    Dim jump As Boolean
    Dim timeleft As Integer
    Dim labels1() As Label
    Dim labelRight(17) As Boolean
    Dim labelLeft(17) As Boolean
    Dim labelDown(17) As Boolean
    Dim labelUp(17) As Boolean
    Dim labelPass(17) As Boolean
    Dim goUp As Boolean
    Dim finishReady As Boolean
    Dim ballColor As Integer
    Dim rnum As New Random
    Private Sub Classic2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            jump = True
            timeleft = 13
            Timer1.Start()
            If firstPress = False Then
                Timer2.Start()
            End If
            If goUp = True Then
                For i = 0 To 17
                    labels1(i).Top = labels1(i).Top + 10
                Next
                lblLeftEnd1.Top = lblLeftEnd1.Top + 10
                lblBottomEnd1.Top = lblBottomEnd1.Top + 10
                lblTopEnd1.Top = lblTopEnd1.Top + 10
                lblRightEnd1.Top = lblRightEnd1.Top + 10
                lblBall.Top = lblBall.Top + 10
                If finishReady = True Then
                    lblFinishLine.Top = lblFinishLine.Top + 10
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblBall.Top = lblBall.Top - 3.5
        timeleft = timeleft - 1
        If timeleft <= 0 Then
            Timer1.Stop()
            jump = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If jump = False Then
            lblBall.Top = lblBall.Top + 4
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        For i = 0 To 17
            If labelRight(i) = True Then
                labels1(i).Left = labels1(i).Left + 5
                If labels1(i).Bounds.IntersectsWith(lblRightEnd1.Bounds) Then
                    labelRight(i) = False
                    labelDown(i) = True
                End If
            End If
            If labelDown(i) = True Then
                labels1(i).Top = labels1(i).Top + 5
                If labels1(i).Bounds.IntersectsWith(lblBottomEnd1.Bounds) Then
                    labelDown(i) = False
                    labelLeft(i) = True
                End If
            End If
            If labelLeft(i) = True Then
                labels1(i).Left = labels1(i).Left - 5
                If labels1(i).Bounds.IntersectsWith(lblLeftEnd1.Bounds) Then
                    labelLeft(i) = False
                    labelUp(i) = True
                End If
            End If
            If labelUp(i) = True Then
                labels1(i).Top = labels1(i).Top - 5
                If labels1(i).Bounds.IntersectsWith(lblTopEnd1.Bounds) Then
                    labelUp(i) = False
                    labelRight(i) = True
                End If
            End If
            If labels1(i).Bounds.IntersectsWith(lblBoarder.Bounds) Then
                labelPass(i) = True
            End If

        Next
        For i = 0 To 17
            If labelPass(i) = True Then
                lblFinishLine.Visible = True
                finishReady = True
            End If
        Next
        If lblBall.Top <= lblBoarder.Bottom Then
            goUp = True
        ElseIf lblBall.Bottom >= lblBoarder.Top Then
            goUp = False
        End If
        If lblBall.Bounds.IntersectsWith(lblFinishLine.Bounds) And finishReady = True Then
            level2complete = True

            Me.Hide()
            LevelPassed.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
        End If
        If admin = False Then
            For i = 0 To 17
                If lblBall.Bounds.IntersectsWith(labels1(i).Bounds) Then
                    If labels1(i).BackColor <> lblBall.BackColor Then
                        Me.Hide()
                        LevelFailed.Show()
                        Timer1.Stop()
                        Timer2.Stop()
                        Timer3.Stop()
                    End If
                End If
            Next
        End If

        If lblBall.Bottom >= Me.Height Then
            Me.Hide()
            LevelFailed.Show()
        End If
    End Sub
    Private Sub Classic2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For i = 0 To 17
            labelDown(i) = False
            labelUp(i) = False
            labelRight(i) = False
            labelLeft(i) = False
            labelPass(i) = False
        Next
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        firstPress = False
        goUp = False
        finishReady = False
        labels1 = {Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17, Label18, Label19}
        lblRightEnd1.Top = 9
        lblRightEnd1.Left = 491
        lblTopEnd1.Top = 20
        lblTopEnd1.Left = 288
        lblLeftEnd1.Top = 9
        lblLeftEnd1.Left = 271
        lblBottomEnd1.Top = 149
        lblBottomEnd1.Left = 288
        Label2.Left = 288
        Label2.Top = 34
        labelRight(0) = True
        Label3.Left = 318
        Label3.Top = 34
        labelRight(1) = True
        Label4.Left = 348
        Label4.Top = 34
        labelRight(2) = True
        Label5.Left = 378
        Label5.Top = 34
        labelRight(3) = True
        Label6.Left = 408
        Label6.Top = 34
        labelRight(4) = True
        Label7.Left = 438
        Label7.Top = 34
        labelRight(5) = True
        Label8.Left = 468
        Label8.Top = 34
        labelDown(6) = True
        Label9.Left = 468
        Label9.Top = 64
        labelDown(7) = True
        Label10.Left = 468
        Label10.Top = 94
        labelDown(8) = True
        Label11.Left = 468
        Label11.Top = 124
        labelLeft(9) = True
        Label11.Left = 468
        Label11.Top = 124
        labelLeft(9) = True
        Label12.Left = 438
        Label12.Top = 124
        labelLeft(10) = True
        Label13.Left = 408
        Label13.Top = 124
        labelLeft(11) = True
        Label14.Left = 378
        Label14.Top = 124
        labelLeft(12) = True
        Label15.Left = 348
        Label15.Top = 124
        labelLeft(13) = True
        Label16.Left = 318
        Label16.Top = 124
        labelLeft(14) = True
        Label17.Left = 288
        Label17.Top = 124
        labelUp(15) = True
        Label18.Left = 288
        Label18.Top = 94
        labelUp(16) = True
        Label19.Left = 288
        Label19.Top = 64
        labelUp(17) = True
        lblBall.Top = 407
        lblBall.Left = 384
        lblFinishLine.Visible = False
        lblFinishLine.Top = 1
        lblFinishLine.Left = 220
        ballColor = rnum.Next(0, 6)
        If ballColor = 0 Then
            lblBall.BackColor = Color.Red
        ElseIf ballColor = 1 Then
            lblBall.BackColor = Color.Orange
        ElseIf ballColor = 2 Then
            lblBall.BackColor = Color.Yellow
        ElseIf ballColor = 3 Then
            lblBall.BackColor = Color.Green
        ElseIf ballColor = 4 Then
            lblBall.BackColor = Color.Purple
        ElseIf ballColor = 5 Then
            lblBall.BackColor = Color.Blue
        End If
        Timer3.Start()
        level = 2
        levelType = "Classic"
    End Sub
End Class