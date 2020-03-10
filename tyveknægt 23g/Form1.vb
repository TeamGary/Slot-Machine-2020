Public Class Form1
    Dim billede1, billede2, billede3, timerTæller1 As Byte
    Dim saldo, gevinst As Integer


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        My.Computer.Audio.Play("C:\Users\gm\source\repos\tyveknægt 23g\tyveknægt 23g\Resources\Cha_Ching_Register-Muska666-173262285.wav", AudioPlayMode.Background)
        saldo -= 2
        gevinst = 0
        Lbl_Saldo.Text = saldo
        Lbl_Saldo.Refresh()

        If saldo >= 2 Then
            TimerR1.Enabled = True
            Arm()
        Else
            MsgBox("FALLIT!!!")
            saldo = 100
            Lbl_Saldo.Text = saldo
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PboxR1.Image = Imglistbilleder.Images(5)
        PboxR2.Image = Imglistbilleder.Images(5)
        PboxR3.Image = Imglistbilleder.Images(5)
        For i = 0 To 49
            ImglistRuller.Images.Add(Imglistbilleder.Images(0))
            ImglistRuller.Images.SetKeyName(i, "kirsebær")
        Next
        For i = 50 To 89
            ImglistRuller.Images.Add(Imglistbilleder.Images(1))
            ImglistRuller.Images.SetKeyName(i, "appelsin")
        Next
        For i = 90 To 119
            ImglistRuller.Images.Add(Imglistbilleder.Images(2))
            ImglistRuller.Images.SetKeyName(i, "blomme")
        Next
        For i = 120 To 139
            ImglistRuller.Images.Add(Imglistbilleder.Images(3))
            ImglistRuller.Images.SetKeyName(i, "jordbær")
        Next
        For i = 140 To 159
            ImglistRuller.Images.Add(Imglistbilleder.Images(4))
            ImglistRuller.Images.SetKeyName(i, "klokke")
        Next
        For i = 160 To 170
            ImglistRuller.Images.Add(Imglistbilleder.Images(5))
            ImglistRuller.Images.SetKeyName(i, "JACKPOT")
        Next
        saldo = 100
        Lbl_Saldo.Text = saldo
    End Sub

    Private Sub TimerR1_Tick(sender As Object, e As EventArgs) Handles TimerR1.Tick
        timerTæller1 += 1
        If timerTæller1 < 18 Then
            Randomize()
            billede1 = 170 * Rnd()
            PboxR1.Image = ImglistRuller.Images(billede1)

        End If
        If timerTæller1 < 26 Then
            Randomize()
            billede2 = 170 * Rnd()
            PboxR2.Image = ImglistRuller.Images(billede2)

        End If
        If timerTæller1 < 36 Then
            Randomize()
            billede3 = 170 * Rnd()
            PboxR3.Image = ImglistRuller.Images(billede3)
        Else
            timerTæller1 = 0
            TimerR1.Enabled = False
            Check()



        End If


    End Sub
    Private Sub Check()
        Me.Text = ImglistRuller.Images.Keys(billede1) & " " & ImglistRuller.Images.Keys(billede2) & " " & ImglistRuller.Images.Keys(billede3) & " "
        If ImglistRuller.Images.Keys(billede3) = ImglistRuller.Images.Keys(billede2) And ImglistRuller.Images.Keys(billede2) = ImglistRuller.Images.Keys(billede1) Then
            Select Case ImglistRuller.Images.Keys(billede1)
                Case "kirsebær"
                    gevinst = 10
                Case = "appelsin"
                    gevinst = 15
                Case = "klokke"
                    gevinst = 20
                Case = "blomme"
                    gevinst = 50
                Case = "jordbær"
                    gevinst = 100
                Case = "JACKPOT"
                    gevinst = 500
            End Select
        ElseIf ImglistRuller.Images.Keys(billede1) = "kirsebær" Then
            If ImglistRuller.Images.Keys(billede2) = "kirsebær" Then
                gevinst = 5
            Else
                gevinst = 2
            End If

            'My.Computer.Audio.Play("C:\Users\gm\source\repos\tyveknægt 23g\tyveknægt 23g\Resources\yabba dabba doo-1.wav", AudioPlayMode.WaitToComplete)
            'My.Computer.Audio.Play("C:\Users\gm\source\repos\tyveknægt 23g\tyveknægt 23g\Resources\Bender-03.wav ", AudioPlayMode.Background)
        End If
        saldo += gevinst
        Lbl_Saldo.Text = saldo
    End Sub

    Private Sub Arm()
        Threading.Thread.Sleep(80) '80 milisekunders delay
        Label1.Image = My.Resources.frame_0_delay_0_1s
        Label1.Refresh()
        Threading.Thread.Sleep(80)
        Label1.Image = My.Resources.frame_1_delay_0_5s
        Label1.Refresh()
        Threading.Thread.Sleep(80)
        Label1.Image = My.Resources.frame_2_delay_0_5s
        Label1.Refresh()
        Threading.Thread.Sleep(400)
        Label1.Image = My.Resources.frame_3_delay_s
        Label1.Refresh()
    End Sub

End Class
