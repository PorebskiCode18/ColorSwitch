Public Class Classic4
    Dim labels1() As Label
    Dim labels2() As Label
    Dim labelRight1(17) As Boolean
    Dim labelLeft1(17) As Boolean
    Dim labelDown1(17) As Boolean
    Dim labelUp1(17) As Boolean
    Dim labelRight2(17) As Boolean
    Dim labelLeft2(17) As Boolean
    Dim labelDown2(17) As Boolean
    Dim labelUp2(17) As Boolean
    Dim labelRight3(17) As Boolean
    Dim labelLeft3(17) As Boolean
    Dim labelDown3(17) As Boolean
    Dim labelUp3(17) As Boolean
    Dim ballColor As Integer
    Dim rnum As New Random
    Dim firstPress As Boolean
    Dim goUp As Boolean
    Dim finishReady As Boolean
    Dim changeDone As Boolean
    Dim changeReady As Boolean
    Dim jump As Boolean
    Dim timeleft As Integer
    Dim colorNum As Integer
    Dim labels() As Label
    Dim ready As Boolean
    Dim labels3() As Label
    Dim labels4() As Label
    Dim labels5() As Label
    Private Sub Classic3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            jump = True
            timeleft = 13
            Timer1.Start()
            If firstPress = False Then
                Timer2.Start()
            End If
            If goUp = True Then
                lblColorChange.Top = lblColorChange.Top + 10
                For i = 0 To 14
                    labels1(i).Top = labels1(i).Top + 10
                    labels2(i).Top = labels2(i).Top + 10
                Next
                lblTopReturn.Top = lblTopReturn.Top + 10
                lblBottomReturn.Top = lblBottomReturn.Top + 10
                lblBall.Top = lblBall.Top + 10

                lblLeftEnd1.Top = lblLeftEnd1.Top + 10
                lblRightEnd1.Top = lblRightEnd1.Top + 10
                lblTopEnd1.Top = lblTopEnd1.Top + 10
                lblBottomEnd1.Top = lblBottomEnd1.Top + 10
                For i = 0 To 17
                    labels3(i).Top = labels3(i).Top + 10
                Next
                If ready = True Then
                    For i = 0 To 17
                        labels4(i).Top = labels4(i).Top + 10
                        labels5(i).Top = labels5(i).Top + 10
                    Next
                    lblLeftEnd2.Top = lblLeftEnd2.Top + 10
                    lblRightEnd2.Top = lblRightEnd2.Top + 10
                    lblTopEnd2.Top = lblTopEnd2.Top + 10
                    lblBottomEnd2.Top = lblBottomEnd2.Top + 10
                    lblMiddleEnd2.Top = lblMiddleEnd2.Top + 10
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
            If labelRight1(i) = True Then
                labels3(i).Left = labels3(i).Left + 5
                If labels3(i).Bounds.IntersectsWith(lblRightEnd1.Bounds) Then
                    labelRight1(i) = False
                    labelUp1(i) = True
                End If
            End If
            If labelDown1(i) = True Then
                labels3(i).Top = labels3(i).Top + 5
                If labels3(i).Bounds.IntersectsWith(lblBottomEnd1.Bounds) Then
                    labelDown1(i) = False
                    labelRight1(i) = True
                End If
            End If
            If labelLeft1(i) = True Then
                labels3(i).Left = labels3(i).Left - 5
                If labels3(i).Bounds.IntersectsWith(lblLeftEnd1.Bounds) Then
                    labelLeft1(i) = False
                    labelDown1(i) = True
                End If
            End If
            If labelUp1(i) = True Then
                labels3(i).Top = labels3(i).Top - 5
                If labels3(i).Bounds.IntersectsWith(lblTopEnd1.Bounds) Then
                    labelUp1(i) = False
                    labelLeft1(i) = True
                End If
            End If



            If ready = True Then
                If labelRight2(i) = True Then
                    labels4(i).Left = labels4(i).Left + 5
                    If labels4(i).Bounds.IntersectsWith(lblRightEnd2.Bounds) Then
                        labelRight2(i) = False
                        labelDown2(i) = True
                    End If
                End If
                If labelDown2(i) = True Then
                    labels4(i).Top = labels4(i).Top + 5
                    If labels4(i).Bounds.IntersectsWith(lblBottomEnd2.Bounds) Then
                        labelDown2(i) = False
                        labelLeft2(i) = True
                    End If
                End If
                If labelLeft2(i) = True Then
                    labels4(i).Left = labels4(i).Left - 5
                    If labels4(i).Bounds.IntersectsWith(lblMiddleEnd2.Bounds) Then
                        labelLeft2(i) = False
                        labelUp2(i) = True
                    End If
                End If
                If labelUp2(i) = True Then
                    labels4(i).Top = labels4(i).Top - 5
                    If labels4(i).Bounds.IntersectsWith(lblTopEnd2.Bounds) Then
                        labelUp2(i) = False
                        labelRight2(i) = True
                    End If
                End If



                If labelRight3(i) = True Then
                    labels5(i).Left = labels5(i).Left + 5
                    If labels5(i).Bounds.IntersectsWith(lblMiddleEnd2.Bounds) Then
                        labelRight3(i) = False
                        labelUp3(i) = True
                    End If
                End If
                If labelDown3(i) = True Then
                    labels5(i).Top = labels5(i).Top + 5
                    If labels5(i).Bounds.IntersectsWith(lblBottomEnd2.Bounds) Then
                        labelDown3(i) = False
                        labelRight3(i) = True
                    End If
                End If
                If labelLeft3(i) = True Then
                    labels5(i).Left = labels5(i).Left - 5
                    If labels5(i).Bounds.IntersectsWith(lblLeftEnd2.Bounds) Then
                        labelLeft3(i) = False
                        labelDown3(i) = True
                    End If
                End If
                If labelUp3(i) = True Then
                    labels5(i).Top = labels5(i).Top - 5
                    If labels5(i).Bounds.IntersectsWith(lblTopEnd2.Bounds) Then
                        labelUp3(i) = False
                        labelLeft3(i) = True
                    End If
                End If
            End If
        Next
        For i = 0 To 14
            labels1(i).Left = labels1(i).Left - 4
            labels1(i).Top = labels1(i).Top - 4
            labels2(i).Left = labels2(i).Left - 4
            labels2(i).Top = labels2(i).Top + 4

            If labels2(i).Left < 219 Then
                labels2(i).Left = 553
                labels2(i).Top = lblTopReturn.Top
            End If
            If labels1(i).Left < 219 Then
                labels1(i).Left = 553
                labels1(i).Top = lblBottomReturn.Bottom - 24
            End If
        Next
        For i = 0 To 17
            If labels3(i).Bottom > lblPass.Top Then
                ready = True
                labels4(i).Visible = True
                labels5(i).Visible = True
            End If
            If labels4(i).Bottom > lblPass.Top Then
                finishReady = True
                lblFinishLine.Visible = True
            End If

        Next
        If lblBall.Top <= lblBoarder.Bottom Then
            goUp = True
        ElseIf lblBall.Bottom >= lblBoarder.Top Then
            goUp = False
        End If
        If lblBall.Bounds.IntersectsWith(lblFinishLine.Bounds) And finishReady = True Then
            level4complete = True
            Me.Hide()
            LevelPassed.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
        End If

        If lblBall.Bounds.IntersectsWith(lblColorChange.Bounds) And changeDone = False Then
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

        End If

        If admin = False Then
            For i = 0 To 47
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
    Private Sub Classic4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For i = 0 To 17
            labelDown1(i) = False
            labelUp1(i) = False
            labelRight1(i) = False
            labelLeft1(i) = False
            labelDown2(i) = False
            labelUp2(i) = False
            labelRight2(i) = False
            labelLeft2(i) = False
            labelDown3(i) = False
            labelUp3(i) = False
            labelRight3(i) = False
            labelLeft3(i) = False
        Next
        labels1 = {Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16}
        labels2 = {Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label24, Label25, Label26, Label27, Label28, Label29, Label30, Label31}
        labels3 = {Label32, Label33, Label34, Label35, Label36, Label37, Label38, Label39, Label40, Label41, Label42, Label43, Label44, Label45, Label46, Label47, Label48, Label49}
        labels4 = {Label50, Label51, Label52, Label53, Label54, Label55, Label56, Label57, Label58, Label59, Label60, Label61, Label62, Label63, Label64, Label65, Label66, Label67}
        labels5 = {Label68, Label69, Label70, Label71, Label72, Label73, Label74, Label75, Label76, Label77, Label78, Label79, Label80, Label81, Label82, Label83, Label84, Label85}
        labels = {Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label24, Label25, Label26, Label27, Label28, Label29, Label30, Label31, Label32, Label33, Label34, Label35, Label36, Label37, Label38, Label39, Label40, Label41, Label42, Label43, Label44, Label45, Label46, Label47, Label48, Label49, Label50, Label51, Label52, Label53, Label54, Label55, Label56, Label57, Label58, Label59, Label60, Label61, Label62, Label63, Label64, Label65, Label66, Label67, Label68, Label69, Label70, Label71, Label72, Label73, Label74, Label75, Label76, Label77, Label78, Label79, Label80, Label81, Label82, Label83, Label84, Label85}
        Label2.Left = 553
        Label2.Top = 363
        Label3.Left = 529
        Label3.Top = 339
        Label4.Left = 505
        Label4.Top = 315
        Label5.Left = 481
        Label5.Top = 291
        Label6.Left = 457
        Label6.Top = 267
        Label7.Left = 433
        Label7.Top = 243
        Label8.Left = 409
        Label8.Top = 219
        Label9.Left = 385
        Label9.Top = 195
        Label10.Left = 361
        Label10.Top = 171
        Label11.Left = 337
        Label11.Top = 147
        Label12.Left = 313
        Label12.Top = 123
        Label13.Left = 289
        Label13.Top = 99
        Label14.Left = 265
        Label14.Top = 75
        Label15.Left = 241
        Label15.Top = 51
        Label16.Left = 217
        Label16.Top = 27
        lblBottomReturn.Top = 377
        lblBottomReturn.Left = 217
        lblTopReturn.Top = 27
        lblTopReturn.Left = 217
        Label17.Left = 217
        Label17.Top = 363
        Label18.Left = 241
        Label18.Top = 339
        Label19.Left = 265
        Label19.Top = 315
        Label20.Left = 289
        Label20.Top = 291
        Label21.Left = 313
        Label21.Top = 267
        Label22.Left = 337
        Label22.Top = 243
        Label23.Left = 361
        Label23.Top = 219
        Label24.Left = 385
        Label24.Top = 195
        Label25.Left = 409
        Label25.Top = 171
        Label26.Left = 433
        Label26.Top = 147
        Label27.Left = 457
        Label27.Top = 123
        Label28.Left = 481
        Label28.Top = 99
        Label29.Left = 505
        Label29.Top = 75
        Label30.Left = 529
        Label30.Top = 51
        Label31.Left = 553
        Label31.Top = 27

        Label32.Left = 299
        Label32.Top = -9
        labelDown1(0) = True
        Label33.Left = 299
        Label33.Top = 21
        labelDown1(1) = True
        Label34.Left = 299
        Label34.Top = 51
        labelRight1(2) = True
        Label35.Left = 329
        Label35.Top = 51
        labelRight1(3) = True
        Label36.Left = 359
        Label36.Top = 51
        labelRight1(4) = True
        Label37.Left = 389
        Label37.Top = 51
        labelRight1(5) = True
        Label38.Left = 419
        Label38.Top = 51
        labelRight1(6) = True
        Label39.Left = 449
        Label39.Top = 51
        labelRight1(7) = True
        Label40.Left = 479
        Label40.Top = 51
        labelUp1(8) = True
        Label41.Left = 479
        Label41.Top = 21
        labelUp1(9) = True
        Label42.Left = 479
        Label42.Top = -9
        labelUp1(10) = True
        Label43.Left = 479
        Label43.Top = -39
        labelLeft1(11) = True
        Label44.Left = 449
        Label44.Top = -39
        labelLeft1(12) = True
        Label45.Left = 419
        Label45.Top = -39
        labelLeft1(13) = True
        Label46.Left = 389
        Label46.Top = -39
        labelLeft1(14) = True
        Label47.Left = 359
        Label47.Top = -39
        labelLeft1(15) = True
        Label48.Left = 329
        Label48.Top = -39
        labelLeft1(16) = True
        Label49.Left = 299
        Label49.Top = -39
        labelDown1(17) = True

        Label50.Top = 13
        Label50.Left = 523
        labelLeft2(0) = True
        Label51.Top = 13
        Label51.Left = 493
        labelLeft2(1) = True
        Label52.Top = 13
        Label52.Left = 463
        labelLeft2(2) = True
        Label53.Top = 13
        Label53.Left = 433
        labelLeft2(3) = True
        Label54.Top = 13
        Label54.Left = 403
        labelUp2(4) = True
        Label55.Top = -17
        Label55.Left = 403
        labelUp2(5) = True
        Label56.Top = -47
        Label56.Left = 403
        labelUp2(6) = True
        Label57.Top = -77
        Label57.Left = 403
        labelUp2(7) = True
        Label58.Top = -107
        Label58.Left = 403
        labelUp2(8) = True
        Label59.Top = -137
        Label59.Left = 403
        labelRight2(9) = True
        Label60.Top = -137
        Label60.Left = 433
        labelRight2(10) = True
        Label61.Top = -137
        Label61.Left = 463
        labelRight2(11) = True
        Label62.Top = -137
        Label62.Left = 493
        labelRight2(12) = True
        Label63.Top = -137
        Label63.Left = 523
        labelDown2(13) = True
        Label64.Top = -107
        Label64.Left = 523
        labelDown2(14) = True
        Label65.Top = -77
        Label65.Left = 523
        labelDown2(15) = True
        Label66.Top = -47
        Label66.Left = 523
        labelDown2(16) = True
        Label67.Top = -17
        Label67.Left = 523
        labelDown2(17) = True

        Label68.Top = -17
        Label68.Left = 249
        labelDown3(0) = True
        Label69.Top = -47
        Label69.Left = 249
        labelDown3(1) = True
        Label70.Top = -77
        Label70.Left = 249
        labelDown3(2) = True
        Label71.Top = -107
        Label71.Left = 249
        labelDown3(3) = True
        Label72.Top = -137
        Label72.Left = 249
        labelDown3(4) = True
        Label73.Top = -137
        Label73.Left = 279
        labelLeft3(5) = True
        Label74.Top = -137
        Label74.Left = 309
        labelLeft3(6) = True
        Label75.Top = -137
        Label75.Left = 339
        labelLeft3(7) = True
        Label76.Top = -137
        Label76.Left = 369
        labelLeft3(8) = True
        Label77.Top = -107
        Label77.Left = 369
        labelUp3(9) = True
        Label78.Top = -77
        Label78.Left = 369
        labelUp3(10) = True
        Label79.Top = -47
        Label79.Left = 369
        labelUp3(11) = True
        Label80.Top = -17
        Label80.Left = 369
        labelUp3(12) = True
        Label81.Top = 13
        Label81.Left = 369
        labelRight3(13) = True
        Label82.Top = 13
        Label82.Left = 339
        labelRight3(14) = True
        Label83.Top = 13
        Label83.Left = 309
        labelRight3(15) = True
        Label84.Top = 13
        Label84.Left = 279
        labelRight3(16) = True
        Label85.Top = 13
        Label85.Left = 249
        labelRight3(17) = True

        lblBottomEnd1.Top = 75
        lblBottomEnd1.Left = 299
        lblRightEnd1.Top = -64
        lblRightEnd1.Left = 502
        lblLeftEnd1.Top = -64
        lblLeftEnd1.Left = 282
        lblTopEnd1.Top = -53
        lblTopEnd1.Left = 299
        lblRightEnd2.Top = -186
        lblRightEnd2.Left = 547
        lblLeftEnd2.Top = -177
        lblLeftEnd2.Left = 239
        lblBottomEnd2.Top = 37
        lblBottomEnd2.Left = 241
        lblMiddleEnd2.Top = -177
        lblMiddleEnd2.Left = 393
        lblTopEnd2.Top = -147
        lblTopEnd2.Left = 230
        lblColorChange.Top = 123
        lblColorChange.Left = 389
        For i = 0 To 17
            labels3(i).Visible = True
            labels4(i).Visible = False
            labels5(i).Visible = False
        Next
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        firstPress = False
        goUp = False
        finishReady = False
        ready = False
        changeDone = False
        changeReady = False
        lblColorChange.Visible = True
        lblFinishLine.Visible = False
        lblFinishLine.Top = 2
        lblFinishLine.Left = 219
        lblBall.Top = 412
        Timer3.Start()
        level = 4
        levelType = "Classic"
        ballColor = rnum.Next(1, 6)
        If ballColor = 1 Then
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