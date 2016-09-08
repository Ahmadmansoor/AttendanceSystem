Imports AxZKFPEngXControl
Imports ZKFPEngXControl
Public Class Form1
    Dim matchType As Integer = 0
    Dim sRegTemplate As String = String.Empty
    Dim sRegTemplate10 As String = String.Empty
    Private Sub AxZKFPEngX1_OnEnroll(sender As Object, e As IZKFPEngXEvents_OnEnrollEvent) Handles AxZKFPEngX1.OnEnroll
        Dim FPID As Integer
        Dim fpcHandle As Integer
        If (Not e.actionResult) Then
            MsgBox("Register Faild")
        Else
            sRegTemplate = AxZKFPEngX1.GetTemplateAsStringEx("9")
            sRegTemplate10 = AxZKFPEngX1.GetTemplateAsStringEx("10")
            If (sRegTemplate.Length > 0) Then
                If (sRegTemplate10.Length > 0) Then
                    AxZKFPEngX1.AddRegTemplateStrToFPCacheDBEx(fpcHandle, FPID, sRegTemplate, sRegTemplate10)
                Else
                    MsgBox("Register 10.0 Faild,Template length is Zero")
                End If
                e.aTemplate = AxZKFPEngX1.DecodeTemplate1(sRegTemplate)
                AxZKFPEngX1.SetTemplateLen(e.aTemplate, 602)
                AxZKFPEngX1.SaveTemplate("fingerprint.tpl", e.aTemplate)
                FPID = FPID + 1
                MsgBox("Register Succeed")
            Else
                MsgBox("Register Faild ,Template length is zero")
            End If
        End If
    End Sub

    Private Sub AxZKFPEngX1_OnFeatureInfo(sender As Object, e As IZKFPEngXEvents_OnFeatureInfoEvent) Handles AxZKFPEngX1.OnFeatureInfo
        Dim str As String = String.Empty
        Dim buffer As String = String.Empty
        Dim t As Integer
        If (AxZKFPEngX1.IsRegister()) Then
            t = AxZKFPEngX1.EnrollIndex()
            str = str + "Register Status: still press finger " + t.ToString + " times"
        End If
        str += "Fingerprint quality"
        Dim Q As Integer = AxZKFPEngX1.LastQuality()
        If (Q <> 0) Then
            str = str + " not good, quality=" + Q.ToString
        Else
            str = str + " good, quality=" + Q.ToString
        End If
        La_RegState.Text = str
    End Sub

    Private Sub AxZKFPEngX1_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent) Handles AxZKFPEngX1.OnImageReceived
        Dim HDC As Long = PB_finger.CreateGraphics.GetHdc.ToInt32
        If (e.aImageValid) Then
            AxZKFPEngX1.PrintImageAt(HDC, 0, 0, AxZKFPEngX1.ImageWidth, AxZKFPEngX1.ImageHeight)
        End If
    End Sub

    Private Sub Bu_Coonect_Click(sender As Object, e As EventArgs) Handles Bu_Coonect.Click
        'Dim buffer As String = String.Empty
        If (AxZKFPEngX1.InitEngine = 0) Then
            AxZKFPEngX1.FPEngineVersion = "9"
            Dim fpcHandle As Integer = AxZKFPEngX1.CreateFPCacheDBEx()
            TB_SN.Text = AxZKFPEngX1.SensorSN()
            TB_Current.Text = AxZKFPEngX1.SensorIndex()
            TB_SensorNu.Text = AxZKFPEngX1.SensorCount()
            MsgBox("Initial Succeed")
        Else
            AxZKFPEngX1.EndEngine()
            MsgBox("Initial Failed")
        End If
    End Sub

    Private Sub Bu_DisConnect_Click(sender As Object, e As EventArgs) Handles Bu_DisConnect.Click
        AxZKFPEngX1.EndEngine()
        MsgBox("Disconnect Succeed")
    End Sub

    Private Sub Bu_Reg_Click(sender As Object, e As EventArgs) Handles Bu_Reg.Click
        AxZKFPEngX1.CancelEnroll()
        AxZKFPEngX1.EnrollCount = 3
        AxZKFPEngX1.BeginEnroll()
        La_RegState.Text = "Start Register"
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        AxZKFPEngX1.EndEngine()
    End Sub

    Private Sub Bu_Ver_Click(sender As Object, e As EventArgs) Handles Bu_Ver.Click
        If (AxZKFPEngX1.IsRegister()) Then
            AxZKFPEngX1.CancelEnroll()
        End If
        La_RegState.Text = "Verifying"
        matchType = 1
    End Sub

    Private Sub AxZKFPEngX1_OnCapture(sender As Object, e As IZKFPEngXEvents_OnCaptureEvent) Handles AxZKFPEngX1.OnCapture
        Dim id As Integer = 0
        Dim Score As Integer = 0
        Dim ProcessNum As Integer = 0
        Dim buffer(63) As SByte
        Dim sTemp As String = String.Empty
        Dim RegChanged As Boolean = False
        If (matchType = 1) Then
            Dim bTemp As String = String.Empty
            sTemp = AxZKFPEngX1.GetTemplateAsString()
            bTemp = sRegTemplate
            If (AxZKFPEngX1.VerFingerFromStr(bTemp, sTemp, False, RegChanged)) Then
                La_RegState.Text = "Verfiy Succeed"
            Else
                La_RegState.Text = "Verfiy Failed"
            End If
        End If
    End Sub
End Class
