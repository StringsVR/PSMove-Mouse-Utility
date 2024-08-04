<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitorSetup
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
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel7 = New Panel()
        Panel5 = New Panel()
        Label1 = New Label()
        ProgressBar = New ProgressBar()
        ProgressInstructionLabel = New Label()
        NextButton = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        OrientationLabel = New Label()
        PositionLabel = New Label()
        DoneButton = New Button()
        Panel1 = New Panel()
        SetupCalibration = New Panel()
        DepthDoneButton = New Button()
        Label7 = New Label()
        Label6 = New Label()
        ZAxisCheckbox = New CheckBox()
        XAxisCheckbox = New CheckBox()
        Label5 = New Label()
        Label4 = New Label()
        Panel8 = New Panel()
        Panel6 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        SetupCalibration.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.monitor1
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-18, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(751, 631)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel5)
        Panel2.Location = New Point(-730, -24)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1205, 109)
        Panel2.TabIndex = 1
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Location = New Point(-19, 22)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1188, 86)
        Panel7.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(729, 30)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(436, 631)
        Panel5.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(429, 48)
        Label1.TabIndex = 0
        Label1.Text = "Calibrate Screen Corners"
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(19, 124)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(395, 49)
        ProgressBar.TabIndex = 2
        ' 
        ' ProgressInstructionLabel
        ' 
        ProgressInstructionLabel.AutoSize = True
        ProgressInstructionLabel.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProgressInstructionLabel.Location = New Point(19, 177)
        ProgressInstructionLabel.Name = "ProgressInstructionLabel"
        ProgressInstructionLabel.Size = New Size(395, 56)
        ProgressInstructionLabel.TabIndex = 3
        ProgressInstructionLabel.Text = "Step (1/4): Place Controller To The Top Right" & vbCrLf & " Of Your Screen"
        ' 
        ' NextButton
        ' 
        NextButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NextButton.Location = New Point(19, 284)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(395, 51)
        NextButton.TabIndex = 5
        NextButton.Text = "Next Position"
        NextButton.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(OrientationLabel)
        Panel3.Controls.Add(PositionLabel)
        Panel3.Location = New Point(-730, 374)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1184, 272)
        Panel3.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(-32, 116)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1201, 151)
        Panel4.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(787, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(395, 56)
        Label3.TabIndex = 1
        Label3.Text = "Make sure that your controller and monitor " & vbCrLf & "are fully visible to your trackers."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(769, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 32)
        Label2.TabIndex = 0
        Label2.Text = "Tips:"
        ' 
        ' OrientationLabel
        ' 
        OrientationLabel.AutoSize = True
        OrientationLabel.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OrientationLabel.Location = New Point(736, 48)
        OrientationLabel.Name = "OrientationLabel"
        OrientationLabel.Size = New Size(181, 30)
        OrientationLabel.TabIndex = 1
        OrientationLabel.Text = "Orientation: 0 0 0"
        ' 
        ' PositionLabel
        ' 
        PositionLabel.AutoSize = True
        PositionLabel.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PositionLabel.Location = New Point(736, 10)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New Size(147, 30)
        PositionLabel.TabIndex = 0
        PositionLabel.Text = "Position: 0 0 0"
        ' 
        ' DoneButton
        ' 
        DoneButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DoneButton.Location = New Point(19, 284)
        DoneButton.Name = "DoneButton"
        DoneButton.Size = New Size(395, 51)
        DoneButton.TabIndex = 6
        DoneButton.Text = "Done"
        DoneButton.UseVisualStyleBackColor = True
        DoneButton.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(SetupCalibration)
        Panel1.Controls.Add(DoneButton)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(NextButton)
        Panel1.Controls.Add(ProgressInstructionLabel)
        Panel1.Controls.Add(ProgressBar)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(735, -7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(491, 648)
        Panel1.TabIndex = 1
        ' 
        ' SetupCalibration
        ' 
        SetupCalibration.Controls.Add(DepthDoneButton)
        SetupCalibration.Controls.Add(Label7)
        SetupCalibration.Controls.Add(Label6)
        SetupCalibration.Controls.Add(ZAxisCheckbox)
        SetupCalibration.Controls.Add(XAxisCheckbox)
        SetupCalibration.Controls.Add(Label5)
        SetupCalibration.Controls.Add(Label4)
        SetupCalibration.Controls.Add(Panel8)
        SetupCalibration.Location = New Point(0, 7)
        SetupCalibration.Name = "SetupCalibration"
        SetupCalibration.Size = New Size(440, 631)
        SetupCalibration.TabIndex = 7
        ' 
        ' DepthDoneButton
        ' 
        DepthDoneButton.Location = New Point(30, 412)
        DepthDoneButton.Name = "DepthDoneButton"
        DepthDoneButton.Size = New Size(384, 53)
        DepthDoneButton.TabIndex = 8
        DepthDoneButton.Text = "Done"
        DepthDoneButton.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(29, 260)
        Label7.Name = "Label7"
        Label7.Size = New Size(359, 25)
        Label7.TabIndex = 7
        Label7.Text = "Select Axis Of Depth Compared To Monitor."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(30, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 28)
        Label6.TabIndex = 6
        Label6.Text = "Axis Setup"
        ' 
        ' ZAxisCheckbox
        ' 
        ZAxisCheckbox.AutoSize = True
        ZAxisCheckbox.Location = New Point(44, 339)
        ZAxisCheckbox.Name = "ZAxisCheckbox"
        ZAxisCheckbox.Size = New Size(87, 29)
        ZAxisCheckbox.TabIndex = 5
        ZAxisCheckbox.Text = "Z-Axis"
        ZAxisCheckbox.UseVisualStyleBackColor = True
        ' 
        ' XAxisCheckbox
        ' 
        XAxisCheckbox.AutoSize = True
        XAxisCheckbox.Location = New Point(44, 298)
        XAxisCheckbox.Name = "XAxisCheckbox"
        XAxisCheckbox.Size = New Size(88, 29)
        XAxisCheckbox.TabIndex = 4
        XAxisCheckbox.Text = "X-Axis"
        XAxisCheckbox.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(366, 100)
        Label5.TabIndex = 3
        Label5.Text = "Set Up The Depth Axis Of Your Playspace. " & vbCrLf & "Go Into Config Tool, Click Test Pose And See " & vbCrLf & "What Axis Is Depth Compared To Monitor " & vbCrLf & "Or Screen."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(76, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(283, 48)
        Label4.TabIndex = 1
        Label4.Text = "Calibrate Depth"
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Location = New Point(-744, -4)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1184, 73)
        Panel8.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Location = New Point(-16, -39)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1205, 109)
        Panel6.TabIndex = 5
        ' 
        ' MonitorSetup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1168, 632)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel6)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "MonitorSetup"
        Text = "Monitor Setup"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SetupCalibration.ResumeLayout(False)
        SetupCalibration.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents ProgressInstructionLabel As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OrientationLabel As Label
    Friend WithEvents PositionLabel As Label
    Friend WithEvents DoneButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents SetupCalibration As Panel
    Friend WithEvents DepthDoneButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ZAxisCheckbox As CheckBox
    Friend WithEvents XAxisCheckbox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
End Class
