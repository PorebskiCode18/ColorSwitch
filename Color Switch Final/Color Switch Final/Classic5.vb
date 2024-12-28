Public Class Classic5
    Dim labels1() As Label
    Dim labels2() As Label
    Dim labelRight1(23) As Boolean
    Dim labelLeft1(23) As Boolean
    Dim labelDown1(23) As Boolean
    Dim labelUp1(23) As Boolean
    Dim labelRight2(17) As Boolean
    Dim labelLeft2(17) As Boolean
    Dim labelDown2(17) As Boolean
    Dim labelUp2(17) As Boolean
    Dim labelRight3(17) As Boolean
    Dim labelLeft3(17) As Boolean
    Dim labelDown3(17) As Boolean
    Dim labelUp3(17) As Boolean

    Dim labelRight4(11) As Boolean
    Dim labelLeft4(11) As Boolean
    Dim labelDown4(11) As Boolean
    Dim labelUp4(11) As Boolean
    Dim labelRight5(11) As Boolean
    Dim labelLeft5(11) As Boolean
    Dim labelDown5(11) As Boolean
    Dim labelUp5(11) As Boolean
    Dim labelRight6(3) As Boolean
    Dim labelLeft6(3) As Boolean
    Dim labelDown6(3) As Boolean
    Dim labelUp6(3) As Boolean
    Dim labelRight7(3) As Boolean
    Dim labelLeft7(3) As Boolean
    Dim labelDown7(3) As Boolean
    Dim labelUp7(3) As Boolean
    Dim ballColor As Integer
    Dim rnum As New Random
    Dim firstPress As Boolean
    Dim goUp As Boolean
    Dim finishReady As Boolean
    Dim changeDone As Boolean
    Dim changeDone2 As Boolean
    Dim jump As Boolean
    Dim timeleft As Integer
    Dim colorNum As Integer
    Dim labels() As Label
    Dim ready As Boolean
    Dim labels3() As Label
    Dim labels4() As Label
    Dim labels5() As Label
    Dim ready2 As Boolean
    Dim labels6() As Label
    Dim labels7() As Label
    Dim labels8() As Label
    Dim changeReady2 As Boolean
    Private Sub Classic3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            jump = True
            timeleft = 13
            Timer1.Start()
            If firstPress = False Then
                Timer2.Start()
            End If
            If goUp = True Then
                lblColorChange.Top = lblColorChange.Top + 14
                For i = 0 To 23
                    labels1(i).Top = labels1(i).Top + 14
                Next
                For i = 0 To 11
                    labels2(i).Top = labels2(i).Top + 14
                Next
                lblBall.Top = lblBall.Top + 14
                If ready = True Then
                    For i = 0 To 17
                        labels3(i).Top = labels3(i).Top + 14
                        labels4(i).Top = labels4(i).Top + 14
                    Next
                    lblLeftEnd2.Top = lblLeftEnd2.Top + 14
                    lblRightEnd2.Top = lblRightEnd2.Top + 14
                    lblTopEnd2.Top = lblTopEnd2.Top + 14
                    lblBottomEnd2.Top = lblBottomEnd2.Top + 14
                    lblMiddleEnd2.Top = lblMiddleEnd2.Top + 14
                End If
                If ready2 = True Then
                    For i = 0 To 14
                        labels5(i).Top = labels5(i).Top + 14
                        labels6(i).Top = labels6(i).Top + 14
                        labels7(i).Top = labels7(i).Top + 14
                        labels8(i).Top = labels8(i).Top + 14
                    Next
                    lblTopReturn1.Top = lblTopReturn1.Top + 14
                    lblTopReturn2.Top = lblTopReturn2.Top + 14
                    lblBottomReturn1.Top = lblBottomReturn1.Top + 14
                    lblBottomReturn2.Top = lblBottomReturn2.Top + 14
                    lblColorChange2.Top = lblColorChange2.Top + 14
                End If
                lblLeftEnd1.Top = lblLeftEnd1.Top + 14
                lblRightEnd1.Top = lblRightEnd1.Top + 14
                lblTopEnd1.Top = lblTopEnd1.Top + 14
                lblBottomEnd1.Top = lblBottomEnd1.Top + 14

                If finishReady = True Then
                    lblFinishLine.Top = lblFinishLine.Top + 14
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

        For i = 0 To 23
            If labelRight1(i) = True Then
                labels1(i).Left = labels1(i).Left + 5
                If labels1(i).Bounds.IntersectsWith(lblRightEnd1.Bounds) Then
                    labelRight1(i) = False
                    labelDown1(i) = True
                End If
            End If
            If labelDown1(i) = True Then
                labels1(i).Top = labels1(i).Top + 5
                If labels1(i).Bounds.IntersectsWith(lblBottomEnd1.Bounds) Then
                    labelDown1(i) = False
                    labelLeft1(i) = True
                End If
            End If
            If labelLeft1(i) = True Then
                labels1(i).Left = labels1(i).Left - 5
                If labels1(i).Bounds.IntersectsWith(lblLeftEnd1.Bounds) Then
                    labelLeft1(i) = False
                    labelUp1(i) = True
                End If
            End If
            If labelUp1(i) = True Then
                labels1(i).Top = labels1(i).Top - 5
                If labels1(i).Bounds.IntersectsWith(lblTopEnd1.Bounds) Then
                    labelUp1(i) = False
                    labelRight1(i) = True
                End If
            End If
            If labels1(i).Top > lblPass.Bottom Then
                ready = True
            End If
        Next
        For i = 0 To 17
            If ready = True Then
                labels3(i).Visible = True
                labels4(i).Visible = True
                If labelRight2(i) = True Then
                    labels3(i).Left = labels3(i).Left + 5
                    If labels3(i).Bounds.IntersectsWith(lblMiddleEnd2.Bounds) Then
                        labelRight2(i) = False
                        labelUp2(i) = True
                    End If
                End If
                If labelDown2(i) = True Then
                    labels3(i).Top = labels3(i).Top + 5
                    If labels3(i).Bounds.IntersectsWith(lblBottomEnd2.Bounds) Then
                        labelDown2(i) = False
                        labelRight2(i) = True
                    End If
                End If
                If labelLeft2(i) = True Then
                    labels3(i).Left = labels3(i).Left - 5
                    If labels3(i).Bounds.IntersectsWith(lblLeftEnd2.Bounds) Then
                        labelLeft2(i) = False
                        labelDown2(i) = True
                    End If
                End If
                If labelUp2(i) = True Then
                    labels3(i).Top = labels3(i).Top - 5
                    If labels3(i).Bounds.IntersectsWith(lblTopEnd2.Bounds) Then
                        labelUp2(i) = False
                        labelLeft2(i) = True
                    End If
                End If



                If labelRight3(i) = True Then
                    labels4(i).Left = labels4(i).Left + 5
                    If labels4(i).Bounds.IntersectsWith(lblRightEnd2.Bounds) Then
                        labelRight3(i) = False
                        labelDown3(i) = True
                    End If
                End If
                If labelDown3(i) = True Then
                    labels4(i).Top = labels4(i).Top + 5
                    If labels4(i).Bounds.IntersectsWith(lblBottomEnd2.Bounds) Then
                        labelDown3(i) = False
                        labelLeft3(i) = True
                    End If
                End If
                If labelLeft3(i) = True Then
                    labels4(i).Left = labels4(i).Left - 5
                    If labels4(i).Bounds.IntersectsWith(lblMiddleEnd2.Bounds) Then
                        labelLeft3(i) = False
                        labelUp3(i) = True
                    End If
                End If
                If labelUp3(i) = True Then
                    labels4(i).Top = labels4(i).Top - 5
                    If labels4(i).Bounds.IntersectsWith(lblTopEnd2.Bounds) Then
                        labelUp3(i) = False
                        labelRight3(i) = True
                    End If
                End If
                If labels3(i).Top > lblPass.Top Then
                    ready2 = True
                End If
            End If
        Next
        For i = 0 To 14
            If ready2 = True Then
                labels5(i).Visible = True
                labels6(i).Visible = True
                labels7(i).Visible = True
                labels8(i).Visible = True
                labels5(i).Left = labels5(i).Left - 4
                labels5(i).Top = labels5(i).Top - 4
                labels6(i).Left = labels6(i).Left + 4
                labels6(i).Top = labels6(i).Top - 4
                labels7(i).Left = labels7(i).Left - 4
                labels7(i).Top = labels7(i).Top - 4
                labels8(i).Left = labels8(i).Left + 4
                labels8(i).Top = labels8(i).Top - 4
                If labels5(i).Left < 225 Then
                    labels5(i).Left = 559
                    labels5(i).Top = lblBottomReturn1.Top
                End If
                If labels6(i).Right > 583 Then
                    labels6(i).Left = 225
                    labels6(i).Top = lblBottomReturn1.Bottom - 24
                End If
                If labels7(i).Left < 225 Then
                    labels7(i).Left = 559
                    labels7(i).Top = lblBottomReturn2.Top
                End If
                If labels8(i).Right > 583 Then
                    labels8(i).Left = 225
                    labels8(i).Top = lblBottomReturn2.Bottom - 24
                End If
                If labels7(i).Top > lblPass.Top Then
                    finishReady = True
                    lblFinishLine.Visible = True
                End If
            End If
        Next
        For i = 0 To 11
            labels2(i).Left = labels2(i).Left - 5
            If labels2(i).Left < 225 Then
                labels2(i).Left = 559
            End If


        Next

        If lblBall.Top <= lblBoarder.Bottom Then
            goUp = True
        ElseIf lblBall.Bottom >= lblBoarder.Top Then
            goUp = False
        End If
        If lblBall.Bounds.IntersectsWith(lblFinishLine.Bounds) And finishReady = True Then
            level5complete = True
            Me.Hide()
            LevelPassed.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
        End If
        If lblBall.Bounds.IntersectsWith(lblFinishLine.Bounds) And finishReady = True Then
            Me.Hide()
            level5complete = True
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

        If ready2 = True And changeReady2 = False Then
            changeReady2 = True
            lblColorChange2.Visible = True
        End If
        If lblBall.Bounds.IntersectsWith(lblColorChange2.Bounds) And changeDone2 = False And changeReady2 = True Then
            colorNum = rnum.Next(0, 5)
            If colorNum = 0 Then
                lblBall.BackColor = Color.Red
            ElseIf colorNum = 1 Then
                lblBall.BackColor = Color.Yellow
            ElseIf colorNum = 2 Then
                lblBall.BackColor = Color.Green
            ElseIf colorNum = 3 Then
                lblBall.BackColor = Color.Purple
            ElseIf colorNum = 4 Then
                lblBall.BackColor = Color.Blue
            End If
            lblColorChange2.Visible = False
            changeDone2 = True
        End If


        If admin = False Then
            For i = 0 To 131
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
        '-186
        '-330
        For i = 0 To 23
            labelDown1(i) = False
            labelUp1(i) = False
            labelRight1(i) = False
            labelLeft1(i) = False
        Next
        For i = 0 To 17
            labelDown2(i) = False
            labelUp2(i) = False
            labelRight2(i) = False
            labelLeft2(i) = False
            labelDown3(i) = False
            labelUp3(i) = False
            labelRight3(i) = False
            labelLeft3(i) = False
        Next
        labels1 = {Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label24, Label25}
        labels2 = {Label26, Label27, Label28, Label29, Label30, Label31, Label32, Label33, Label34, Label35, Label36, Label37}
        labels3 = {Label38, Label39, Label40, Label41, Label42, Label43, Label44, Label45, Label46, Label47, Label48, Label49, Label50, Label51, Label52, Label53, Label54, Label55}
        labels4 = {Label56, Label57, Label58, Label59, Label60, Label61, Label62, Label63, Label64, Label65, Label66, Label67, Label68, Label69, Label70, Label71, Label72, Label73}
        labels5 = {Label74, Label75, Label76, Label77, Label78, Label79, Label80, Label81, Label82, Label83, Label84, Label85, Label86, Label87, Label88}
        labels6 = {Label89, Label90, Label91, Label92, Label93, Label94, Label95, Label96, Label97, Label98, Label99, Label100, Label101, Label102, Label103}
        labels7 = {Label104, Label105, Label106, Label107, Label108, Label109, Label110, Label111, Label112, Label113, Label114, Label115, Label116, Label117, Label118}
        labels8 = {Label119, Label120, Label121, Label122, Label123, Label124, Label125, Label126, Label127, Label128, Label129, Label130, Label131, Label132, Label133}

        labels = {Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17, Label18, Label19, Label20, Label21, Label22, Label23, Label24, Label25, Label26, Label27, Label28, Label29, Label30, Label31, Label32, Label33, Label34, Label35, Label36, Label37, Label38, Label39, Label40, Label41, Label42, Label43, Label44, Label45, Label46, Label47, Label48, Label49, Label50, Label51, Label52, Label53, Label54, Label55, Label56, Label57, Label58, Label59, Label60, Label61, Label62, Label63, Label64, Label65, Label66, Label67, Label68, Label69, Label70, Label71, Label72, Label73, Label74, Label75, Label76, Label77, Label78, Label79, Label80, Label81, Label82, Label83, Label84, Label85, Label86, Label87, Label88, Label89, Label90, Label91, Label92, Label93, Label94, Label95, Label96, Label97, Label98, Label99, Label100, Label101, Label102, Label103, Label104, Label105, Label106, Label107, Label108, Label109, Label110, Label111, Label112, Label113, Label114, Label115, Label116, Label117, Label118, Label119, Label120, Label121, Label122, Label123, Label124, Label125, Label126, Label127, Label128, Label129, Label130, Label131, Label132, Label133}
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Label2.Left = 357
        Label2.Top = 122
        labelRight1(0) = True
        Label3.Left = 387
        Label3.Top = 122
        labelRight1(1) = True
        Label4.Left = 417
        Label4.Top = 122
        labelRight1(2) = True
        Label5.Left = 447
        Label5.Top = 122
        labelRight1(3) = True
        Label6.Left = 477
        Label6.Top = 122
        labelDown1(4) = True
        Label7.Left = 477
        Label7.Top = 152
        labelDown1(5) = True
        Label8.Left = 477
        Label8.Top = 182
        labelDown1(6) = True
        Label9.Left = 477
        Label9.Top = 212
        labelDown1(7) = True
        Label10.Left = 477
        Label10.Top = 242
        labelDown1(8) = True
        Label11.Left = 477
        Label11.Top = 272
        labelDown1(9) = True
        Label12.Left = 477
        Label12.Top = 302
        labelLeft1(10) = True
        Label13.Left = 447
        Label13.Top = 302
        labelLeft1(11) = True
        Label14.Left = 417
        Label14.Top = 302
        labelLeft1(12) = True
        Label15.Left = 387
        Label15.Top = 302
        labelLeft1(13) = True
        Label16.Left = 357
        Label16.Top = 302
        labelLeft1(14) = True
        Label17.Left = 327
        Label17.Top = 302
        labelLeft1(15) = True
        Label18.Left = 297
        Label18.Top = 302
        labelUp1(16) = True
        Label19.Left = 297
        Label19.Top = 272
        labelUp1(17) = True
        Label20.Left = 297
        Label20.Top = 242
        labelUp1(18) = True
        Label21.Left = 297
        Label21.Top = 212
        labelUp1(19) = True
        Label22.Left = 297
        Label22.Top = 182
        labelUp1(20) = True
        Label23.Left = 297
        Label23.Top = 152
        labelUp1(21) = True
        Label24.Left = 297
        Label24.Top = 122
        labelRight1(22) = True
        Label25.Left = 327
        Label25.Top = 122
        labelRight1(23) = True

        Label38.Left = 282
        Label38.Top = 19
        labelRight2(0) = True
        Label39.Left = 312
        Label39.Top = 19
        labelRight2(1) = True
        Label40.Left = 342
        Label40.Top = 19
        labelRight2(2) = True
        Label41.Left = 372
        Label41.Top = 19
        labelUp2(3) = True
        Label42.Left = 372
        Label42.Top = -11
        labelUp2(4) = True
        Label43.Left = 372
        Label43.Top = -41
        labelUp2(5) = True
        Label44.Left = 372
        Label44.Top = -71
        labelUp2(6) = True
        Label45.Left = 372
        Label45.Top = -101
        labelUp2(7) = True
        Label46.Left = 372
        Label46.Top = -131
        labelUp2(8) = True
        Label47.Left = 372
        Label47.Top = -161
        labelLeft2(9) = True
        Label48.Left = 342
        Label48.Top = -161
        labelLeft2(10) = True
        Label49.Left = 312
        Label49.Top = -161
        labelLeft2(11) = True
        Label50.Left = 282
        Label50.Top = -161
        labelDown2(12) = True
        Label51.Left = 282
        Label51.Top = -131
        labelDown2(13) = True
        Label52.Left = 282
        Label52.Top = -101
        labelDown2(14) = True
        Label53.Left = 282
        Label53.Top = -71
        labelDown2(15) = True
        Label54.Left = 282
        Label54.Top = -41
        labelDown2(16) = True
        Label55.Left = 282
        Label55.Top = -11
        labelDown2(17) = True

        Label56.Left = 403
        Label56.Top = -11
        labelUp3(0) = True
        Label57.Left = 403
        Label57.Top = -41
        labelUp3(1) = True
        Label58.Left = 403
        Label58.Top = -71
        labelUp3(2) = True
        Label59.Left = 403
        Label59.Top = -101
        labelUp3(3) = True
        Label60.Left = 403
        Label60.Top = -131
        labelUp3(4) = True
        Label61.Left = 403
        Label61.Top = -161
        labelRight3(5) = True
        Label62.Left = 433
        Label62.Top = -161
        labelRight3(6) = True
        Label63.Left = 463
        Label63.Top = -161
        labelRight3(7) = True
        Label64.Left = 493
        Label64.Top = -161
        labelDown3(8) = True
        Label65.Left = 493
        Label65.Top = -131
        labelDown3(9) = True
        Label66.Left = 493
        Label66.Top = -101
        labelDown3(10) = True
        Label67.Left = 493
        Label67.Top = -71
        labelDown3(11) = True
        Label68.Left = 493
        Label68.Top = -41
        labelDown3(12) = True
        Label69.Left = 493
        Label69.Top = -11
        labelDown3(13) = True
        Label70.Left = 493
        Label70.Top = 19
        labelLeft3(14) = True
        Label71.Left = 463
        Label71.Top = 19
        labelLeft3(15) = True
        Label72.Left = 433
        Label72.Top = 19
        labelLeft3(16) = True
        Label73.Left = 403
        Label73.Top = 19
        labelUp3(17) = True

        Label74.Left = 559
        Label74.Top = 152
        Label75.Left = 535
        Label75.Top = 128
        Label76.Left = 511
        Label76.Top = 104
        Label77.Left = 487
        Label77.Top = 80
        Label78.Left = 463
        Label78.Top = 56
        Label79.Left = 439
        Label79.Top = 32
        Label80.Left = 415
        Label80.Top = 8
        Label81.Left = 391
        Label81.Top = -16
        Label82.Left = 367
        Label82.Top = -40
        Label83.Left = 343
        Label83.Top = -64
        Label84.Left = 319
        Label84.Top = -88
        Label85.Left = 295
        Label85.Top = -112
        Label86.Left = 271
        Label86.Top = -136
        Label87.Left = 247
        Label87.Top = -160
        Label88.Left = 223
        Label88.Top = -184

        Label89.Left = 223
        Label89.Top = 152
        Label90.Left = 247
        Label90.Top = 128
        Label91.Left = 271
        Label91.Top = 104
        Label92.Left = 295
        Label92.Top = 80
        Label93.Left = 319
        Label93.Top = 56
        Label94.Left = 343
        Label94.Top = 32
        Label95.Left = 367
        Label95.Top = 8
        Label96.Left = 391
        Label96.Top = -16
        Label97.Left = 415
        Label97.Top = -40
        Label98.Left = 439
        Label98.Top = -64
        Label99.Left = 463
        Label99.Top = -88
        Label100.Left = 487
        Label100.Top = -112
        Label101.Left = 511
        Label101.Top = -136
        Label102.Left = 535
        Label102.Top = -160
        Label103.Left = 559
        Label103.Top = -184

        Label104.Left = 559
        Label104.Top = -328
        Label105.Left = 535
        Label105.Top = -304
        Label106.Left = 511
        Label106.Top = -280
        Label107.Left = 487
        Label107.Top = -256
        Label108.Left = 463
        Label108.Top = -232
        Label109.Left = 439
        Label109.Top = -208
        Label110.Left = 415
        Label110.Top = -184
        Label111.Left = 391
        Label111.Top = -160
        Label112.Left = 367
        Label112.Top = -136
        Label113.Left = 343
        Label113.Top = -112
        Label114.Left = 319
        Label114.Top = -88
        Label115.Left = 295
        Label115.Top = -64
        Label116.Left = 271
        Label116.Top = -40
        Label117.Left = 247
        Label117.Top = -16
        Label118.Left = 223
        Label118.Top = 8

        Label119.Left = 223
        Label119.Top = -328
        Label120.Left = 247
        Label120.Top = -304
        Label121.Left = 271
        Label121.Top = -280
        Label122.Left = 295
        Label122.Top = -256
        Label123.Left = 319
        Label123.Top = -232
        Label124.Left = 343
        Label124.Top = -208
        Label125.Left = 367
        Label125.Top = -184
        Label126.Left = 391
        Label126.Top = -160
        Label127.Left = 415
        Label127.Top = -136
        Label128.Left = 439
        Label128.Top = -112
        Label129.Left = 463
        Label129.Top = -88
        Label130.Left = 487
        Label130.Top = -64
        Label131.Left = 511
        Label131.Top = -40
        Label132.Left = 535
        Label132.Top = -16
        Label133.Left = 559
        Label133.Top = 8

        For i = 0 To 11
            labels2(i).Top = 212

        Next

        For i = 0 To 17
            labels3(i).Visible = False
            labels4(i).Visible = False
        Next
        For i = 0 To 14
            labels5(i).Visible = False
            labels6(i).Visible = False
            labels7(i).Visible = False
            labels8(i).Visible = False
        Next
        lblLeftEnd1.Left = 287
        lblLeftEnd1.Top = 112
        lblTopEnd1.Left = 286
        lblTopEnd1.Top = 112
        lblRightEnd1.Left = 501
        lblRightEnd1.Top = 110
        lblBottomEnd1.Left = 290
        lblBottomEnd1.Top = 326
        lblLeftEnd2.Left = 273
        lblLeftEnd2.Top = -247
        lblBottomEnd2.Left = 225
        lblBottomEnd2.Top = 43
        lblMiddleEnd2.Left = 393
        lblMiddleEnd2.Top = -267
        lblRightEnd2.Left = 516
        lblRightEnd2.Top = -273
        lblTopEnd2.Left = 283
        lblTopEnd2.Top = -171
        firstPress = False
        goUp = False
        finishReady = False
        ready = False
        ready2 = False
        changeDone = False
        changeDone2 = False
        changeReady2 = False
        lblColorChange.Visible = True
        lblFinishLine.Visible = False
        lblColorChange.Top = 43
        lblFinishLine.Top = 2
        lblFinishLine.Left = 219
        lblBall.Top = 412
        Timer3.Start()
        lblColorChange2.Top = 60
        lblColorChange2.Visible = False
        level = 5
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