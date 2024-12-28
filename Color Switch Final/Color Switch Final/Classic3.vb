

Public Class Classic3
    Dim firstPress As Boolean
    Dim jump As Boolean
    Dim timeleft As Integer
    Dim labels1() As Label
    Dim labels3() As Label
    Dim labels()
    Dim labelRight(17) As Boolean
    Dim labelLeft(17) As Boolean
    Dim labelDown(17) As Boolean
    Dim labelUp(17) As Boolean
    Dim goUp As Boolean
    Dim finishReady As Boolean
    Dim labels2() As Label
    Dim ready As Boolean
    Dim changeReady As Boolean
    Dim rnum As New Random
    Dim colorNum As New Integer
    Dim changeDone As Boolean
    Dim ballColor As Integer
    Private Sub Classic3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            jump = True
            timeleft = 13
            Timer1.Start()
            If firstPress = False Then
                Timer2.Start()
            End If
            If goUp = True Then

                If changeReady = True Then
                    lblColorChange.Top = lblColorChange.Top + 10
                End If
                For i = 0 To 11
                    labels1(i).Top = labels1(i).Top + 10
                    labels2(i).Top = labels2(i).Top + 10
                Next
                lblBall.Top = lblBall.Top + 10
                If ready = True Then
                    lblLeftEnd1.Top = lblLeftEnd1.Top + 10
                    lblRightEnd1.Top = lblRightEnd1.Top + 10
                    lblTopEnd1.Top = lblTopEnd1.Top + 10
                    lblBottomEnd1.Top = lblBottomEnd1.Top + 10
                    For i = 0 To 17
                        labels3(i).Top = labels3(i).Top + 10
                    Next

                End If
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
            If ready = True Then
                If labelRight(i) = True Then
                    labels3(i).Left = labels3(i).Left + 5
                    If labels3(i).Bounds.IntersectsWith(lblRightEnd1.Bounds) Then
                        labelRight(i) = False
                        labelDown(i) = True
                    End If
                End If
                If labelDown(i) = True Then
                    labels3(i).Top = labels3(i).Top + 5
                    If labels3(i).Bounds.IntersectsWith(lblBottomEnd1.Bounds) Then
                        labelDown(i) = False
                        labelLeft(i) = True
                    End If
                End If
                If labelLeft(i) = True Then
                    labels3(i).Left = labels3(i).Left - 5
                    If labels3(i).Bounds.IntersectsWith(lblLeftEnd1.Bounds) Then
                        labelLeft(i) = False
                        labelUp(i) = True
                    End If
                End If
                If labelUp(i) = True Then
                    labels3(i).Top = labels3(i).Top - 5
                    If labels3(i).Bounds.IntersectsWith(lblTopEnd1.Bounds) Then
                        labelUp(i) = False
                        labelRight(i) = True
                    End If
                End If
            End If

        Next
        For i = 0 To 11
            labels1(i).Left = labels1(i).Left + 5
            labels2(i).Left = labels2(i).Left - 5
            If labels2(i).Bounds.IntersectsWith(lblBoarder.Bounds) Then
                ready = True
            End If
            If labels1(i).Right > 594 Then
                labels1(i).Left = 237
            End If
            If labels2(i).Left < 237 Then
                labels2(i).Left = 570
            End If
        Next
        For i = 0 To 17
            If labels3(i).Bottom > lblBoarder.Top Then
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
            level3complete = True

            Me.Hide()
            LevelPassed.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
        End If

        For i = 0 To 11

            If labels2(i).Bounds.IntersectsWith(lblPass.Bounds) Then
                ready = True
                For f = 0 To 17
                    labels3(f).Visible = True
                Next
            End If
            If labels1(i).Bounds.IntersectsWith(lblBoarder.Bounds) And changeDone = False Then
                changeReady = True
                lblColorChange.Visible = True
            End If
        Next
        If lblBall.Bounds.IntersectsWith(lblColorChange.Bounds) And changeReady = True Then
            colorNum = rnum.Next(0, 6)
            If colorNum = 0 Then
                lblBall.BackColor = Color.Red
            ElseIf colorNum = 1 Then
                lblBall.BackColor = Color.Orange
            ElseIf colorNum = 2 Then
                lblBall.BackColor = Color.Yellow
            ElseIf colorNum = 3 Then
                lblBall.BackColor = Color.Green
            ElseIf colorNum = 4 Then
                lblBall.BackColor = Color.Purple
            ElseIf colorNum = 5 Then
                lblBall.BackColor = Color.Blue
            End If
            lblColorChange.Visible = False
            changeDone = True
            changeReady = False
        End If
        If admin = False Then
            For i = 0 To 41
                If lblBall.Bounds.IntersectsWith(labels(i).Bounds) Then
                    If labels(i).BackColor <> lblBall.BackColor Then
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
    Private Sub Classic3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For i = 0 To 17
            labelDown(i) = False
            labelUp(i) = False
            labelRight(i) = False
            labelLeft(i) = False
        Next
        ready = False
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        firstPress = False
        goUp = False
        finishReady = False
        Label24.Top = 30
        Label24.Left = 324
        labelUp(0) = True
        Label25.Top = 60
        Label25.Left = 324
        labelUp(1) = True
        Label26.Top = 90
        Label26.Left = 324
        labelUp(2) = True
        Label27.Top = 120
        Label27.Left = 324
        labelUp(3) = True
        Label28.Top = 120
        Label28.Left = 354
        labelLeft(4) = True
        Label29.Top = 120
        Label29.Left = 384
        labelLeft(5) = True
        Label30.Top = 120
        Label30.Left = 414
        labelLeft(6) = True
        Label31.Top = 120
        Label31.Left = 444
        labelLeft(7) = True
        Label32.Top = 120
        Label32.Left = 474
        labelLeft(8) = True
        Label33.Top = 90
        Label33.Left = 474
        labelDown(9) = True
        Label34.Top = 60
        Label34.Left = 474
        labelDown(10) = True
        Label35.Top = 30
        Label35.Left = 474
        labelDown(11) = True
        Label36.Top = 2
        Label36.Left = 474
        labelDown(12) = True
        Label37.Top = 2
        Label37.Left = 444
        labelRight(13) = True
        Label38.Top = 2
        Label38.Left = 414
        labelRight(14) = True
        Label39.Top = 2
        Label39.Left = 384
        labelRight(15) = True
        Label40.Top = 2
        Label40.Left = 354
        labelRight(16) = True
        Label41.Top = 2
        Label41.Left = 324
        labelRight(17) = True
        lblLeftEnd1.Left = 307
        lblLeftEnd1.Top = -15
        lblRightEnd1.Top = -15
        lblRightEnd1.Left = 498
        lblBottomEnd1.Left = 314
        lblBottomEnd1.Top = 144
        lblTopEnd1.Top = -12
        lblTopEnd1.Left = 308
        lblColorChange.Visible = False
        changeDone = False
        changeReady = False
        labels1 = {Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label42}
        labels2 = {Label13, Label14, Label15, Label16, Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label43}
        labels3 = {Label24, Label25, Label26, Label27, Label28, Label29, Label30, Label31, Label32, Label33, Label34, Label35, Label36, Label37, Label38, Label39, Label40, Label41}
        labels = {Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label42, Label13, Label14, Label15, Label16, Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label43, Label24, Label25, Label26, Label27, Label28, Label29, Label30, Label31, Label32, Label33, Label34, Label35, Label36, Label37, Label38, Label39, Label40, Label41}
        For i = 0 To 17
            labels3(i).Visible = False
        Next
        For i = 0 To 11
            labels1(i).Top = 249
            labels2(i).Top = 153
        Next

        lblFinishLine.Visible = False
        lblFinishLine.Top = 2
        lblFinishLine.Left = 240
        lblBall.Top = 407
        Timer3.Start()
        level = 3
        levelType = "Classic"
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
    End Sub
End Class