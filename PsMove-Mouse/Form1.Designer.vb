<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PSMove_Color = New PictureBox()
        Label1 = New Label()
        PositionLabel = New Label()
        OrientationLabel = New Label()
        HandRoleLabel = New Label()
        TrackingColorLabel = New Label()
        Panel3 = New Panel()
        SettingsButton = New Button()
        WarningPanel = New Panel()
        WarningHeaderLabel = New Label()
        CalibrateMouseButton = New Button()
        ConfigureButton = New Button()
        StartButton = New Button()
        Panel1.SuspendLayout()
        CType(PSMove_Color, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        WarningPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PSMove_Color)
        Panel1.Location = New Point(-5, -10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(229, 586)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(227, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(425, 466)
        Panel2.TabIndex = 1
        ' 
        ' PSMove_Color
        ' 
        PSMove_Color.BackgroundImage = My.Resources.Resources.cyan_controller1
        PSMove_Color.BackgroundImageLayout = ImageLayout.Stretch
        PSMove_Color.Location = New Point(0, 14)
        PSMove_Color.Name = "PSMove_Color"
        PSMove_Color.Size = New Size(221, 534)
        PSMove_Color.TabIndex = 0
        PSMove_Color.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(252, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 25)
        Label1.TabIndex = 0
        Label1.Text = "Controller Info"
        ' 
        ' PositionLabel
        ' 
        PositionLabel.AutoSize = True
        PositionLabel.Location = New Point(252, 103)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New Size(124, 25)
        PositionLabel.TabIndex = 1
        PositionLabel.Text = "Position: 0 0 0"
        ' 
        ' OrientationLabel
        ' 
        OrientationLabel.AutoSize = True
        OrientationLabel.Location = New Point(252, 159)
        OrientationLabel.Name = "OrientationLabel"
        OrientationLabel.Size = New Size(150, 25)
        OrientationLabel.TabIndex = 2
        OrientationLabel.Text = "Orientation: 0 0 0"
        ' 
        ' HandRoleLabel
        ' 
        HandRoleLabel.AutoSize = True
        HandRoleLabel.Location = New Point(252, 216)
        HandRoleLabel.Name = "HandRoleLabel"
        HandRoleLabel.Size = New Size(103, 25)
        HandRoleLabel.TabIndex = 3
        HandRoleLabel.Text = "Hand Role: "
        ' 
        ' TrackingColorLabel
        ' 
        TrackingColorLabel.AutoSize = True
        TrackingColorLabel.Location = New Point(252, 270)
        TrackingColorLabel.Name = "TrackingColorLabel"
        TrackingColorLabel.Size = New Size(128, 25)
        TrackingColorLabel.TabIndex = 4
        TrackingColorLabel.Text = "Tracking Color:"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(SettingsButton)
        Panel3.Controls.Add(TrackingColorLabel)
        Panel3.Controls.Add(HandRoleLabel)
        Panel3.Controls.Add(OrientationLabel)
        Panel3.Controls.Add(PositionLabel)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(WarningPanel)
        Panel3.Location = New Point(0, -14)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(663, 468)
        Panel3.TabIndex = 1
        ' 
        ' SettingsButton
        ' 
        SettingsButton.BackColor = SystemColors.Control
        SettingsButton.BackgroundImage = My.Resources.Resources.settings
        SettingsButton.BackgroundImageLayout = ImageLayout.Stretch
        SettingsButton.FlatAppearance.BorderSize = 0
        SettingsButton.FlatStyle = FlatStyle.Flat
        SettingsButton.Location = New Point(597, 22)
        SettingsButton.Name = "SettingsButton"
        SettingsButton.Size = New Size(50, 50)
        SettingsButton.TabIndex = 6
        SettingsButton.UseVisualStyleBackColor = False
        ' 
        ' WarningPanel
        ' 
        WarningPanel.BackColor = Color.Firebrick
        WarningPanel.Controls.Add(WarningHeaderLabel)
        WarningPanel.Location = New Point(-18, 431)
        WarningPanel.Name = "WarningPanel"
        WarningPanel.Size = New Size(680, 39)
        WarningPanel.TabIndex = 5
        ' 
        ' WarningHeaderLabel
        ' 
        WarningHeaderLabel.AutoSize = True
        WarningHeaderLabel.ForeColor = Color.White
        WarningHeaderLabel.Location = New Point(247, 5)
        WarningHeaderLabel.Name = "WarningHeaderLabel"
        WarningHeaderLabel.Size = New Size(223, 25)
        WarningHeaderLabel.TabIndex = 0
        WarningHeaderLabel.Text = "Warning: Pose Data Invalid"
        ' 
        ' CalibrateMouseButton
        ' 
        CalibrateMouseButton.BackColor = SystemColors.Control
        CalibrateMouseButton.FlatAppearance.BorderSize = 200
        CalibrateMouseButton.ForeColor = SystemColors.ControlText
        CalibrateMouseButton.Location = New Point(257, 468)
        CalibrateMouseButton.Name = "CalibrateMouseButton"
        CalibrateMouseButton.Size = New Size(174, 34)
        CalibrateMouseButton.TabIndex = 2
        CalibrateMouseButton.Text = "Calibrate Mouse"
        CalibrateMouseButton.UseVisualStyleBackColor = False
        ' 
        ' ConfigureButton
        ' 
        ConfigureButton.BackColor = SystemColors.Control
        ConfigureButton.FlatAppearance.BorderSize = 200
        ConfigureButton.ForeColor = SystemColors.ControlText
        ConfigureButton.Location = New Point(451, 468)
        ConfigureButton.Name = "ConfigureButton"
        ConfigureButton.Size = New Size(174, 34)
        ConfigureButton.TabIndex = 3
        ConfigureButton.Text = "Configure"
        ConfigureButton.UseVisualStyleBackColor = False
        ' 
        ' StartButton
        ' 
        StartButton.BackColor = SystemColors.Control
        StartButton.FlatAppearance.BorderSize = 200
        StartButton.ForeColor = SystemColors.ControlText
        StartButton.Location = New Point(355, 507)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(174, 38)
        StartButton.TabIndex = 4
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 551)
        Controls.Add(StartButton)
        Controls.Add(ConfigureButton)
        Controls.Add(CalibrateMouseButton)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "PSMove Mouse Utility"
        Panel1.ResumeLayout(False)
        CType(PSMove_Color, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        WarningPanel.ResumeLayout(False)
        WarningPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PSMove_Color As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PositionLabel As Label
    Friend WithEvents OrientationLabel As Label
    Friend WithEvents HandRoleLabel As Label
    Friend WithEvents TrackingColorLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CalibrateMouseButton As Button
    Friend WithEvents ConfigureButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents WarningPanel As Panel
    Friend WithEvents WarningHeaderLabel As Label
    Friend WithEvents SettingsButton As Button

End Class
