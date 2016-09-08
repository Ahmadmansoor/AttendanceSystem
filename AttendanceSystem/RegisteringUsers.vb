Imports AxZKFPEngXControl
Public Class RegisteringUsers
    Dim matchType As Integer = 0
    Dim sRegTemplate As String = String.Empty
    Dim sRegTemplate10 As String = String.Empty

    Private Sub UsersTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersTableBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.UsersTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSheetDataSet)

    End Sub

    Private Sub RegisteringUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSheetDataSet.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.DataSheetDataSet.UsersTable)
        If (AxZKFPEngX1.InitEngine = 0) Then
            AxZKFPEngX1.FPEngineVersion = "9"
            Dim fpcHandle As Integer = AxZKFPEngX1.CreateFPCacheDBEx()
            StatusLabel2.Text = StatusLabel2.Text + AxZKFPEngX1.SensorSN() + "   /   "
            StatusLabel1.Text = StatusLabel1.Text + AxZKFPEngX1.SensorCount().ToString + "  /   "
            StatusLabel3.Text = "Initial Succeed"
        Else
            AxZKFPEngX1.EndEngine()
            StatusLabel3.Text = "Initial Failed"
        End If
    End Sub

    Private Sub RegisteringUsers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AxZKFPEngX1.EndEngine()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If (UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or SectionComboBox.Text = "" Or UserLevelComboBox.Text = "") Then
            MsgBox("Error adding recored before save the previus one")
            Exit Sub
        End If
        UsersTableBindingNavigator.BindingSource.AddNew()
        UsersTableBindingNavigator.BindingSource.MoveLast()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim s As Integer = MsgBox("Are u sure to delete this ??!", MsgBoxStyle.OkCancel, "Warrning")
        If s = 1 Then
            UsersTableBindingNavigator.BindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub Bu_Reg_Click(sender As Object, e As EventArgs) Handles Bu_Reg.Click
        AxZKFPEngX1.CancelEnroll()
        AxZKFPEngX1.EnrollCount = 3
        AxZKFPEngX1.BeginEnroll()
        StatusLabel3.Text = "Start Register"
    End Sub
    Private Sub AxZKFPEngX1_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent) Handles AxZKFPEngX1.OnImageReceived
        Dim HDC As Long = PB_finger.CreateGraphics.GetHdc.ToInt32
        If (e.aImageValid) Then
            AxZKFPEngX1.PrintImageAt(HDC, 0, 0, AxZKFPEngX1.ImageWidth, AxZKFPEngX1.ImageHeight)
        End If
    End Sub
    Private Sub AxZKFPEngX1_OnFeatureInfo(sender As Object, e As IZKFPEngXEvents_OnFeatureInfoEvent) Handles AxZKFPEngX1.OnFeatureInfo
        Dim str As String = String.Empty
        Dim buffer As String = String.Empty
        Dim t As Integer
        If (AxZKFPEngX1.IsRegister()) Then
            t = AxZKFPEngX1.EnrollIndex()
            str = str + "still press finger " + t.ToString + " times"
        End If
        str += "Fingerprint quality"
        Dim Q As Integer = AxZKFPEngX1.LastQuality()
        If (Q < 50) Then
            str = str + " not good,quality=" + Q.ToString
        Else
            str = str + " good,quality=" + Q.ToString
        End If
        StatusLabel3.Text = str
    End Sub
    Private Sub AxZKFPEngX1_OnEnroll(sender As Object, e As IZKFPEngXEvents_OnEnrollEvent) Handles AxZKFPEngX1.OnEnroll
        Dim FPID As Integer
        Dim fpcHandle As Integer
        If (Not e.actionResult) Then
            MsgBox("Register Faild")
        Else
            sRegTemplate = AxZKFPEngX1.GetTemplateAsStringEx("9")
            If (UserIDTextBox.Text <> "") Then
                StampTextBox.Text = sRegTemplate
            End If
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
                    StatusLabel3.Text = "Wait"
                Else
                    MsgBox("Register Faild ,Template length is zero")
                End If
            End If
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
            bTemp = StampTextBox.Text 'sRegTemplate ;here we get the save Templet of the Finger Print we will save it in the data base later 
            If (AxZKFPEngX1.VerFingerFromStr(bTemp, sTemp, False, RegChanged)) Then
                StatusLabel3.Text = "Verfiy Succeed"
            Else
                StatusLabel3.Text = "Verfiy Failed"
            End If
        End If
    End Sub

    Private Sub Bu_Ver_Click(sender As Object, e As EventArgs) Handles Bu_Ver.Click
        If (AxZKFPEngX1.IsRegister()) Then
            AxZKFPEngX1.CancelEnroll()
        End If
        StatusLabel3.Text = "Verify"
        matchType = 1
    End Sub
End Class