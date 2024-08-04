Imports System.ComponentModel
Imports System.Threading
Imports PSMoveServiceExCAPI.PSMoveServiceExCAPI

Public Class MonitorSetup
    Private WithEvents bgWorker As New BackgroundWorker()
    Private currentStep As Integer = 0

    Private Sub MonitorSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupCalibration.Show()
        If (Points3D IsNot Nothing) Then
            Points3D.Clear()
        End If
        NextButton.Show()
        DoneButton.Hide()
        bgWorker.WorkerSupportsCancellation = True
        bgWorker.WorkerReportsProgress = True
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub MonitorSetup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If bgWorker.IsBusy Then
            bgWorker.CancelAsync()
            ' Wait for the background worker to finish
            While bgWorker.IsBusy
                Application.DoEvents()
            End While
        End If
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Do
            If bgWorker.CancellationPending Then
                e.Cancel = True
                Exit Do
            End If

            ManageProgressBar()
            SetCurrentPose()
            bgWorker.ReportProgress(0, "E")

            ' Sleep for a bit to avoid excessive CPU usage
            Thread.Sleep(150)
        Loop
    End Sub

    Private Sub ManageProgressBar()
        If (currentStep = 0) Then
            UpdateProgressBar(25)
            Form1.UpdateLabelText(ProgressInstructionLabel, "Step (1/4): Place Controller To The Top 
Left Of Your Screen")
        ElseIf (currentStep = 1) Then
            UpdateProgressBar(50)
            Form1.UpdateLabelText(ProgressInstructionLabel, "Step (2/4): Place Controller To The Top 
Right Of Your Screen")
        ElseIf (currentStep = 2) Then
            UpdateProgressBar(75)
            Form1.UpdateLabelText(ProgressInstructionLabel, "Step (3/4): Place Controller To The 
Bottom Left Of Your Screen")
        ElseIf (currentStep = 3) Then
            UpdateProgressBar(100)
            Form1.UpdateLabelText(ProgressInstructionLabel, "Step (4/4): Place Controller To The 
Bottom Right Of Your Screen")
        ElseIf (currentStep = 4) Then
            UpdateProgressBar(100)
            Form1.UpdateLabelText(ProgressInstructionLabel, "Complete. Now Press Done And Configure 
Offsets.")
        End If
    End Sub

    Public Sub SetCurrentPose()
        Dim eulerAngles = QuaternionToEuler.QuaternionToEulerAngles(PoseOrientation.X, PoseOrientation.Y, PoseOrientation.Z, PoseOrientation.W)
        Form1.UpdateLabelText(PositionLabel, "Position: " + PoseLocation.X.ToString + " " + PoseLocation.Y.ToString + " " + PoseLocation.Z.ToString)
        Form1.UpdateLabelText(OrientationLabel, "Orientation: " + eulerAngles.pitch.ToString + " " + eulerAngles.yaw.ToString + " " + eulerAngles.roll.ToString)
    End Sub


    Public Sub ReplacePose3D(index As Integer, newPose As Pose3D)
        If index >= 0 AndAlso index < Points3D.Count Then
            Points3D(index) = newPose
        Else
            Throw New ArgumentOutOfRangeException("Index is out of range.")
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If currentStep < 4 Then
            currentStep = currentStep + 1
            Points3D.Add(PoseLocation)
            If (currentStep = 4) Then
                NextButton.Hide()
                DoneButton.Show()
            End If
        End If
    End Sub

    Private Sub UpdateProgressBar(value As Integer)
        If ProgressBar.InvokeRequired Then
            ProgressBar.Invoke(New Action(Of Integer)(AddressOf UpdateProgressBar), value)
        Else
            If value > ProgressBar.Maximum Then
                ProgressBar.Value = ProgressBar.Minimum
            Else
                ProgressBar.Value = value
            End If
        End If
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        CalculateValues()
    End Sub

    Private Sub CalculateValues()
        Dim XLength As Double
        Dim YLength As Double
        If (AxisOfDepth) Then
            XLength = Math.Abs(Points3D(2).X - Points3D(1).X)
        Else
            XLength = Math.Abs(Points3D(2).Z - Points3D(1).Z)
        End If
        YLength = Math.Abs(Points3D(1).Y - Points3D(3).Y)

        PixelsPerPlayspaceX = Math.Abs((screenWidth / XLength))
        PixelsPerPlayspaceY = Math.Abs((screenHeight / YLength))

        CalibratedForUse = True
        Me.Close()
    End Sub

    Private Sub DepthDoneButton_Click(sender As Object, e As EventArgs) Handles DepthDoneButton.Click
        If (XAxisCheckbox.Checked = False And ZAxisCheckbox.Checked = False) Then
            MsgBox("One Checkbox Must Be Checked!")
        Else
            If (XAxisCheckbox.Checked) Then
                AxisOfDepth = True
            Else
                AxisOfDepth = False
            End If
            SetupCalibration.Hide()
        End If
    End Sub

    Private Sub XAxisCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles XAxisCheckbox.CheckedChanged
        If (XAxisCheckbox.Checked And ZAxisCheckbox.Checked) Then
            ZAxisCheckbox.Checked = False
        End If
    End Sub

    Private Sub ZAxisCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles ZAxisCheckbox.CheckedChanged
        If (ZAxisCheckbox.Checked And XAxisCheckbox.Checked) Then
            XAxisCheckbox.Checked = False
        End If
    End Sub
End Class