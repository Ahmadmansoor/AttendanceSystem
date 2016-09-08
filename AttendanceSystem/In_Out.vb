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
        TopMost = True
        WindowState = 2

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
        If (matchType = 1) Then
            Dim bTemp As String = String.Empty
            sTemp = AxZKFPEngX1.GetTemplateAsString()
            'bTemp = StampTextBox.Text 'sRegTemplate ;here we get the save Templet of the Finger Print we will save it in the data base later 
            Dim CheckifUserReg = From num In UsersTableTableAdapter.GetData Where AxZKFPEngX1.VerFingerFromStr(num.Stamp, sTemp, False, RegChanged) 'num.Stamp
            If CheckifUserReg.Count > 0 Then
                StatusLabel3.Text = "Verfiy Succeed"
                StatusLabel3.ForeColor = Color.Green
                'Dim xx = AttendanceTableTableAdapter.GetData(DateAndTime.DateString)
                Dim isUserHaveRecored = From nun In AttendanceTableTableAdapter.GetData(DateAndTime.DateString) Where nun.UserID = CheckifUserReg.First.UserID 'And nun.LogDate.ToString = La_Date.Text
                If isUserHaveRecored.Count > 0 Then
                    If isUserHaveRecored.First.TimeIn <> TimeSpan.Zero Then ' this mean he reg in time
                        MsgBox("You have been In,you can't enter again in same day", MsgBoxStyle.OkOnly, "Error")
                        StatusLabel3.Text = "Verfiy Failed"
                        StatusLabel3.ForeColor = Color.Red
                    Else    ' this is mean it is the first in in this day 

                    End If
                Else
                    AttendanceTableTableAdapter.Insert(CheckifUserReg.First.UserID, CheckifUserReg.First.Username, La_Date.Text, Date.Now.TimeOfDay, TimeSpan.Zero, TimeSpan.Zero, TimeSpan.Zero, CheckifUserReg.First.Section)
                    Me.AttendanceTableTableAdapter.Fill(Me.DataSetInOut.AttendanceTable, DateAndTime.DateString)
                End If
            Else
                StatusLabel3.Text = "Verfiy Failed"
                StatusLabel3.ForeColor = Color.Red
            End If
            matchType = 0
        End If


    End Sub
    Private Sub Timer_DateCheck_Tick(sender As Object, e As EventArgs) Handles Timer_DateCheck.Tick
        TodayDate = DateAndTime.Today
        La_Date.Text = TodayDate.ToString("d")
        La_Time.Text = DateAndTime.TimeOfDay.ToString("hh:mm tt")
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
End Class