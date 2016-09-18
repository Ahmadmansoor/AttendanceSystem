Imports AxZKFPEngXControl
Public Class In_Out
    Dim TodayDate As Date
    'Dim TimeSpanX As TimeSpan = Date.Now.TimeOfDay
    Dim matchType As Integer = 0
    Dim sRegTemplate As String = String.Empty
    Dim sRegTemplate10 As String = String.Empty
    Private Sub In_Out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetInOut.UsersTable' table. You can move, or remove it, as needed.
        Me.UsersTableTableAdapter.Fill(Me.DataSetInOut.UsersTable)
        'TODO: This line of code loads data into the 'DataSetInOut.AttendanceTable' table. You can move, or remove it, as needed.
        Me.AttendanceTableTableAdapter.Fill(Me.DataSetInOut.AttendanceTable, DateAndTime.DateString)
        TodayDate = DateAndTime.Today
        La_Date.Text = TodayDate.ToString("d")
        La_Time.Text = DateAndTime.TimeOfDay.ToString("hh:mm tt")
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Location = New Point(0, 0)
        Size = SystemInformation.PrimaryMonitorMaximizedWindowSize
        'TopMost = True
        'WindowState = 2

        If (AxZKFPEngX1.InitEngine = 0) Then
            AxZKFPEngX1.FPEngineVersion = "9"
            Dim fpcHandle As Integer = AxZKFPEngX1.CreateFPCacheDBEx()
            StatusLabel2.Text = "Serial Number: " + AxZKFPEngX1.SensorSN() + "   /   "
            StatusLabel1.Text = "Sensor Number: " + AxZKFPEngX1.SensorCount().ToString + "  /   "
            StatusLabel3.Text = "Initial Succeed"
        Else
            AxZKFPEngX1.EndEngine()
            StatusLabel3.Text = "Initial Failed"
        End If
    End Sub
    Private Sub AxZKFPEngX1_OnCapture(sender As Object, e As IZKFPEngXEvents_OnCaptureEvent) Handles AxZKFPEngX1.OnCapture
        Dim id As Integer = 0
        Dim Score As Integer = 0
        Dim ProcessNum As Integer = 0
        Dim buffer(63) As SByte
        Dim sTemp As String = String.Empty
        Dim RegChanged As Boolean = False
        Select Case matchType
            Case 1  ' enter user
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
                Dim CheckifUserReg = From num In UsersTableTableAdapter.GetData Where AxZKFPEngX1.VerFingerFromStr(num.Stamp, sTemp, False, RegChanged) ' stamp have't valid user
                If CheckifUserReg.Count > 0 Then ' check it user have recored at this day 
                    Dim isUserHaveRecored = From nun In AttendanceTableTableAdapter.GetData(DateAndTime.DateString) Where nun.UserID = CheckifUserReg.First.UserID 'And nun.LogDate.ToString = La_Date.Text
                    If isUserHaveRecored.Count > 0 Then
                        If (isUserHaveRecored.First.TimeIn = TimeSpan.Zero And isUserHaveRecored.First.TimeOut = TimeSpan.Zero) Then 'Or isUserHaveRecored.First.LanchIn = TimeSpan.Zero Or isUserHaveRecored.First.LanchOut = TimeSpan.Zero) Then
                            AttendanceTableTableAdapter.Insert(CheckifUserReg.First.UserID, CheckifUserReg.First.Username, La_Date.Text, Date.Now.TimeOfDay, TimeSpan.Zero, TimeSpan.Zero, TimeSpan.Zero, CheckifUserReg.First.Section)
                            Me.AttendanceTableTableAdapter.Fill(Me.DataSetInOut.AttendanceTable, DateAndTime.DateString)
                            StatusLabel3.Text = "Verfiy Succeed-you have reg in : " & CheckifUserReg.First.Username
                            StatusLabel3.ForeColor = Color.Green
                        Else
                            MsgBox("You have been reg In ,you can't enter again in same day ... or something wrong!!", MsgBoxStyle.OkOnly, "Error")
                            StatusLabel3.Text = "Verfiy Failed-have been reg in : " & isUserHaveRecored.First.Username
                            StatusLabel3.ForeColor = Color.Red
                        End If
                        '    If isUserHaveRecored.First.TimeIn <> TimeSpan.Zero Then ' this mean he come early and stamp
                        '        MsgBox("You have been reg In,you can't enter again in same day", MsgBoxStyle.OkOnly, "Error")
                        '        StatusLabel3.Text = "Verfiy Failed-have been reg in : " & isUserHaveRecored.First.Username
                        '        StatusLabel3.ForeColor = Color.Red
                        '    End If
                        'ElseIf isUserHaveRecored.First.TimeOut = TimeSpan.Zero Or isUserHaveRecored.First.LanchIn = TimeSpan.Zero Or isUserHaveRecored.First.LanchOut = TimeSpan.Zero Then
                        '    AttendanceTableTableAdapter.Insert(CheckifUserReg.First.UserID, CheckifUserReg.First.Username, La_Date.Text, Date.Now.TimeOfDay, TimeSpan.Zero, TimeSpan.Zero, TimeSpan.Zero, CheckifUserReg.First.Section)
                        '    Me.AttendanceTableTableAdapter.Fill(Me.DataSetInOut.AttendanceTable, DateAndTime.DateString)
                        '    StatusLabel3.Text = "Verfiy Succeed-you have reg in : " & CheckifUserReg.First.Username
                        '    StatusLabel3.ForeColor = Color.Green
                        'Else
                        '    MsgBox("You have been reg In,you can't enter again in same day", MsgBoxStyle.OkOnly, "Error")
                        '    StatusLabel3.Text = "Verfiy Failed-have been reg in : " & isUserHaveRecored.First.Username
                        '    StatusLabel3.ForeColor = Color.Red
                    End If
                    Else
                    StatusLabel3.Text = "Wrong stamp or No User name for this stamp in Data base pls try again,Thanks or Connect IT Support section !!"
                    StatusLabel3.ForeColor = Color.Red
                End If
                matchType = 0
            Case 2  ' user go out  
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
                Dim CheckifUserReg = From num In UsersTableTableAdapter.GetData Where AxZKFPEngX1.VerFingerFromStr(num.Stamp, sTemp, False, RegChanged) 'num.Stamp
                If CheckifUserReg.Count > 0 Then 'check if user in data base
                    Dim isUserHaveRecored = From nun In AttendanceTableTableAdapter.GetData(DateAndTime.DateString) Where nun.UserID = CheckifUserReg.First.UserID 'And nun.LogDate.ToString = La_Date.Text
                    If isUserHaveRecored.Count > 0 Then ' check if user have recored at this day
                        If (isUserHaveRecored.First.TimeOut = TimeSpan.Zero And isUserHaveRecored.First.TimeIn <> TimeSpan.Zero) Then ' this mean he go out and stamp
                            StatusLabel3.Text = "Verfiy Succeed-you have reg out : " & isUserHaveRecored.First.Username
                            StatusLabel3.ForeColor = Color.Green
                            AttendanceTableTableAdapter.Update_TimeOut_UserID(Date.Now.TimeOfDay.ToString, CheckifUserReg.First.UserID)
                            Me.AttendanceTableTableAdapter.Fill(Me.DataSetInOut.AttendanceTable, DateAndTime.DateString)
                        Else
                            MsgBox("You have been reg out or not Log in ,you can't out again in same day", MsgBoxStyle.OkOnly, "Error")
                            StatusLabel3.Text = "Verfiy Failed-have been reg out : " & isUserHaveRecored.First.Username
                            StatusLabel3.ForeColor = Color.Red
                        End If
                    End If
                    Else
                    StatusLabel3.Text = "Wrong stamp or No User name for this stamp in Data base pls try again,Thanks or Connect IT Support section !!"
                    StatusLabel3.ForeColor = Color.Red
                End If
                matchType = 0
            Case 3  ' go to Lansh out
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
                Dim CheckifUserReg = From num In UsersTableTableAdapter.GetData Where AxZKFPEngX1.VerFingerFromStr(num.Stamp, sTemp, False, RegChanged) 'num.Stamp
                If CheckifUserReg.Count > 0 Then 'check if user in data base
                    Dim isUserHaveRecored = From nun In AttendanceTableTableAdapter.GetData(DateAndTime.DateString) Where nun.UserID = CheckifUserReg.First.UserID 'And nun.LogDate.ToString = La_Date.Text
                    If isUserHaveRecored.Count > 0 Then ' check if user have recored at this day
                        If (isUserHaveRecored.First.LanchOut = TimeSpan.Zero And isUserHaveRecored.First.LanchIn = TimeSpan.Zero) Then ' this mean he go out and stamp
                            StatusLabel3.Text = "Verfiy Succeed-you have reg out : " & isUserHaveRecored.First.Username
                            StatusLabel3.ForeColor = Color.Green
                            AttendanceTableTableAdapter.Update_LanchOut_UserID(Date.Now.TimeOfDay.ToString, CheckifUserReg.First.UserID)
                            Me.AttendanceTableTableAdapter.Fill(Me.DataSetInOut.AttendanceTable, DateAndTime.DateString)
                        Else
                            MsgBox("You have been reg Lansh out or not Log in ,you can't out again in same day", MsgBoxStyle.OkOnly, "Error")
                            StatusLabel3.Text = "Verfiy Failed-have been reg out : " & isUserHaveRecored.First.Username
                            StatusLabel3.ForeColor = Color.Red
                        End If
                    End If
                Else
                    StatusLabel3.Text = "Wrong stamp or No User name for this stamp in Data base pls try again,Thanks or Connect IT Support section !!"
                    StatusLabel3.ForeColor = Color.Red
                End If
                matchType = 0
            Case 4  ' back form lansh (in)
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
                Dim CheckifUserReg = From num In UsersTableTableAdapter.GetData Where AxZKFPEngX1.VerFingerFromStr(num.Stamp, sTemp, False, RegChanged) 'num.Stamp
                If CheckifUserReg.Count > 0 Then 'check if user in data base
                    Dim isUserHaveRecored = From nun In AttendanceTableTableAdapter.GetData(DateAndTime.DateString) Where nun.UserID = CheckifUserReg.First.UserID 'And nun.LogDate.ToString = La_Date.Text
                    If isUserHaveRecored.Count > 0 Then ' check if user have recored at this day
                        If (isUserHaveRecored.First.LanchIn = TimeSpan.Zero And isUserHaveRecored.First.LanchOut <> TimeSpan.Zero) Then ' this mean he go out and stamp
                            StatusLabel3.Text = "Verfiy Succeed-you have reg out : " & isUserHaveRecored.First.Username
                            StatusLabel3.ForeColor = Color.Green
                            AttendanceTableTableAdapter.Update_LanchIn_UserID(Date.Now.TimeOfDay.ToString, CheckifUserReg.First.UserID)
                            Me.AttendanceTableTableAdapter.Fill(Me.DataSetInOut.AttendanceTable, DateAndTime.DateString)
                        Else
                            MsgBox("You have been reg Lansh in or not Log in ,you can't out again in same day", MsgBoxStyle.OkOnly, "Error")
                            StatusLabel3.Text = "Verfiy Failed-have been reg out : " & isUserHaveRecored.First.Username
                            StatusLabel3.ForeColor = Color.Red
                        End If
                    End If
                Else
                    StatusLabel3.Text = "Wrong stamp or No User name for this stamp in Data base pls try again,Thanks or Connect IT Support section !!"
                    StatusLabel3.ForeColor = Color.Red
                End If
                matchType = 0
        End Select

    End Sub
    Private Sub Timer_DateCheck_Tick(sender As Object, e As EventArgs) Handles Timer_DateCheck.Tick
        TodayDate = DateAndTime.Today
        La_Date.Text = TodayDate.ToString("d")
        La_Time.Text = DateAndTime.TimeOfDay.ToString("hh:mm tt")
        Dim myTime As Date = Now
        Dim s As Integer = Hour(myTime)
        If (Hour(myTime) > 12 And Hour(myTime) < 15) Then
            Bu_BreakIn.Enabled = True
            Bu_BreakOut.Enabled = True
        ElseIf (Hour(myTime) < 12 And Hour(myTime) > 15) Then
            Bu_BreakIn.Enabled = False
            Bu_BreakOut.Enabled = False
        End If
    End Sub

    Private Sub AttendanceTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendanceTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetInOut)

    End Sub

    Private Sub Bu_In_Click(sender As Object, e As EventArgs) Handles Bu_In.Click
        If (AxZKFPEngX1.IsRegister()) Then
            AxZKFPEngX1.CancelEnroll()
        End If
        StatusLabel3.Text = "Verify In"
        matchType = 1
    End Sub

    Private Sub In_Out_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AxZKFPEngX1.EndEngine()
    End Sub
    Private Sub AxZKFPEngX1_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent) Handles AxZKFPEngX1.OnImageReceived
        Dim HDC As Long = PB_Stamp.CreateGraphics.GetHdc.ToInt32
        If (e.aImageValid) Then
            AxZKFPEngX1.PrintImageAt(HDC, 0, 0, AxZKFPEngX1.ImageWidth / 2.5, AxZKFPEngX1.ImageHeight / 2.5)
        End If
    End Sub

    Private Sub Bu_Out_Click(sender As Object, e As EventArgs) Handles Bu_Out.Click
        If (AxZKFPEngX1.IsRegister()) Then
            AxZKFPEngX1.CancelEnroll()
        End If
        StatusLabel3.Text = "Verify Out"
        matchType = 2
    End Sub

    Private Sub Bu_BreakOut_Click(sender As Object, e As EventArgs) Handles Bu_BreakOut.Click
        If (AxZKFPEngX1.IsRegister()) Then
            AxZKFPEngX1.CancelEnroll()
        End If
        StatusLabel3.Text = "Verify Lansh Out"
        matchType = 3
    End Sub

    Private Sub Bu_BreakIn_Click(sender As Object, e As EventArgs) Handles Bu_BreakIn.Click
        If (AxZKFPEngX1.IsRegister()) Then
            AxZKFPEngX1.CancelEnroll()
        End If
        StatusLabel3.Text = "Verify Lansh In"
        matchType = 4
    End Sub
End Class