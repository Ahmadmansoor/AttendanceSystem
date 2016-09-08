<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxZKFPEngX1 = New AxZKFPEngXControl.AxZKFPEngX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.La_RegState = New System.Windows.Forms.Label()
        Me.Bu_Reg = New System.Windows.Forms.Button()
        Me.Bu_DisConnect = New System.Windows.Forms.Button()
        Me.Bu_Coonect = New System.Windows.Forms.Button()
        Me.TB_SN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Current = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_SensorNu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PB_finger = New System.Windows.Forms.PictureBox()
        Me.Bu_Ver = New System.Windows.Forms.Button()
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PB_finger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxZKFPEngX1
        '
        Me.AxZKFPEngX1.Enabled = True
        Me.AxZKFPEngX1.Location = New System.Drawing.Point(841, 12)
        Me.AxZKFPEngX1.Name = "AxZKFPEngX1"
        Me.AxZKFPEngX1.OcxState = CType(resources.GetObject("AxZKFPEngX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxZKFPEngX1.Size = New System.Drawing.Size(24, 24)
        Me.AxZKFPEngX1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bu_Ver)
        Me.GroupBox1.Controls.Add(Me.La_RegState)
        Me.GroupBox1.Controls.Add(Me.Bu_Reg)
        Me.GroupBox1.Controls.Add(Me.Bu_DisConnect)
        Me.GroupBox1.Controls.Add(Me.Bu_Coonect)
        Me.GroupBox1.Controls.Add(Me.TB_SN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TB_Current)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TB_SensorNu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 661)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fingerprint Operation"
        '
        'La_RegState
        '
        Me.La_RegState.AutoSize = True
        Me.La_RegState.Location = New System.Drawing.Point(13, 200)
        Me.La_RegState.Name = "La_RegState"
        Me.La_RegState.Size = New System.Drawing.Size(73, 13)
        Me.La_RegState.TabIndex = 9
        Me.La_RegState.Text = "Serial Number"
        '
        'Bu_Reg
        '
        Me.Bu_Reg.Location = New System.Drawing.Point(11, 160)
        Me.Bu_Reg.Name = "Bu_Reg"
        Me.Bu_Reg.Size = New System.Drawing.Size(177, 23)
        Me.Bu_Reg.TabIndex = 8
        Me.Bu_Reg.Text = "Register"
        Me.Bu_Reg.UseVisualStyleBackColor = True
        '
        'Bu_DisConnect
        '
        Me.Bu_DisConnect.Location = New System.Drawing.Point(194, 117)
        Me.Bu_DisConnect.Name = "Bu_DisConnect"
        Me.Bu_DisConnect.Size = New System.Drawing.Size(177, 23)
        Me.Bu_DisConnect.TabIndex = 7
        Me.Bu_DisConnect.Text = "DisConnect"
        Me.Bu_DisConnect.UseVisualStyleBackColor = True
        '
        'Bu_Coonect
        '
        Me.Bu_Coonect.Location = New System.Drawing.Point(11, 117)
        Me.Bu_Coonect.Name = "Bu_Coonect"
        Me.Bu_Coonect.Size = New System.Drawing.Size(177, 23)
        Me.Bu_Coonect.TabIndex = 6
        Me.Bu_Coonect.Text = "Connect"
        Me.Bu_Coonect.UseVisualStyleBackColor = True
        '
        'TB_SN
        '
        Me.TB_SN.Location = New System.Drawing.Point(93, 77)
        Me.TB_SN.Name = "TB_SN"
        Me.TB_SN.Size = New System.Drawing.Size(262, 20)
        Me.TB_SN.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Serial Number"
        '
        'TB_Current
        '
        Me.TB_Current.Location = New System.Drawing.Point(194, 35)
        Me.TB_Current.Name = "TB_Current"
        Me.TB_Current.Size = New System.Drawing.Size(45, 20)
        Me.TB_Current.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current"
        '
        'TB_SensorNu
        '
        Me.TB_SensorNu.Location = New System.Drawing.Point(93, 35)
        Me.TB_SensorNu.Name = "TB_SensorNu"
        Me.TB_SensorNu.Size = New System.Drawing.Size(45, 20)
        Me.TB_SensorNu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sensor Number"
        '
        'PB_finger
        '
        Me.PB_finger.Location = New System.Drawing.Point(413, 25)
        Me.PB_finger.Name = "PB_finger"
        Me.PB_finger.Size = New System.Drawing.Size(422, 648)
        Me.PB_finger.TabIndex = 10
        Me.PB_finger.TabStop = False
        '
        'Bu_Ver
        '
        Me.Bu_Ver.Location = New System.Drawing.Point(194, 160)
        Me.Bu_Ver.Name = "Bu_Ver"
        Me.Bu_Ver.Size = New System.Drawing.Size(177, 23)
        Me.Bu_Ver.TabIndex = 10
        Me.Bu_Ver.Text = "Verify "
        Me.Bu_Ver.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 685)
        Me.Controls.Add(Me.PB_finger)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AxZKFPEngX1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PB_finger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxZKFPEngX1 As AxZKFPEngXControl.AxZKFPEngX
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_SensorNu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Current As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_SN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Bu_DisConnect As Button
    Friend WithEvents Bu_Coonect As Button
    Friend WithEvents Bu_Reg As Button
    Friend WithEvents La_RegState As Label
    Friend WithEvents PB_finger As PictureBox
    Friend WithEvents Bu_Ver As Button
End Class
