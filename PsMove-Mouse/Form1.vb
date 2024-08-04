Imports System.ComponentModel
Imports System.Speech.Synthesis.TtsEngine
Imports System.Threading
Imports System.Math
Imports PSMoveServiceExCAPI.PSMoveServiceExCAPI
Imports PSMoveServiceExCAPI.PSMoveServiceExCAPI.Constants
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.AxHost

Public Class Form1
    Private WithEvents bgWorker As New BackgroundWorker()
    Public ErrorList As ErrorList = New ErrorList(False, False, False)

    'PsMoveServiceCAPI Related
    Dim mControllers As Controllers() = Nothing
    Dim currentControllerIndex As Integer = 0
    Dim sHost As String = "127.0.0.1"
    Dim hService As Service = New Service(sHost)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            hService.Connect(7000)
        Catch ex As Exception
            MsgBox("PsMoveServiceEx Must Be Open Now Closing.")
            Application.Exit()
        End Try
        mControllers = Controllers.GetControllerList()
        If mControllers Is Nothing OrElse mControllers.Length = 0 Then
            MessageBox.Show("No controllers found")
        End If
        bgWorker.WorkerSupportsCancellation = True
        bgWorker.WorkerReportsProgress = True
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

            ' Fetch controller info
            GetControllerInfo()
            WarningMessage()
            SetCursorMotion()
            If (psButtonData.TriangleButton) Then
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            Else
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            End If
            bgWorker.ReportProgress(0, "E")

            ' Sleep for a bit to avoid excessive CPU usage
            Thread.Sleep(10)
        Loop
    End Sub

    Private Sub GetControllerInfo()
        If mControllers IsNot Nothing AndAlso mControllers.Length > 0 Then
            currentControllerIndex = (currentControllerIndex + 1) Mod mControllers.Length
            mController = mControllers(currentControllerIndex)


            mController.m_DataStreamFlags = PSMStreamFlags.PSMStreamFlags_includeCalibratedSensorData Or
                                             PSMStreamFlags.PSMStreamFlags_includePhysicsData Or
                                             PSMStreamFlags.PSMStreamFlags_includePositionData Or
                                             PSMStreamFlags.PSMStreamFlags_includeRawSensorData Or
                                             PSMStreamFlags.PSMStreamFlags_includeRawTrackerData

            mController.m_Listening = True
            mController.m_DataStreamEnabled = True
            mController.SetTrackerStream(0)

            UpdatePsMoveInfo()
        End If
    End Sub

    Private Sub UpdatePsMoveInfo()
        hService.Update()

        mController.Refresh(Controllers.Info.RefreshFlags.RefreshType_All)

        If mController.m_Info.IsPoseValid() Then
            UpdatePoint3D(mController)
            Dim eulerAngles = QuaternionToEuler.QuaternionToEulerAngles(PoseOrientation.X, PoseOrientation.Y, PoseOrientation.Z, PoseOrientation.W)
            UpdateLabelText(PositionLabel, "Position: " + PoseLocation.X.ToString + " " + PoseLocation.Y.ToString + " " + PoseLocation.Z.ToString)
            UpdateLabelText(OrientationLabel, "Orientation: " + eulerAngles.pitch.ToString + " " + eulerAngles.yaw.ToString + " " + eulerAngles.roll.ToString)
        Else
            ErrorList.PoseError = True
        End If

        If mController.m_Info.IsStateValid() Then
            ErrorList.StateError = False
            SetPsButtonData()
            If mController.m_Info.m_ControllerType = PSMControllerType.PSMController_Move Then
                Dim mPSMoveState = mController.m_Info.GetPSState(Of Controllers.Info.PSMoveState)
                UpdateLabelText(TrackingColorLabel, "Tracking Color: " + mPSMoveState.m_TrackingColorType.ToString().Replace("PSMTrackingColorType_", ""))
                UpdateLabelText(HandRoleLabel, "Hand Role: " + mController.m_Info.m_ControllerHand.ToString.Replace("PSMControllerHand_", ""))
                ErrorList.VirtualControllerError = False

            ElseIf mController.m_Info.m_ControllerType = PSMControllerType.PSMController_Virtual Then
                ErrorList.VirtualControllerError = True
            End If
        Else
            ErrorList.StateError = True
        End If
    End Sub

    Private Sub WarningMessage()
        If (ErrorList.PoseError Or ErrorList.StateError Or ErrorList.VirtualControllerError) Then
            UpdatePanelVisibility(WarningPanel, True)
            If (ErrorList.PoseError) Then
                UpdateLabelText(WarningHeaderLabel, "Warning: Controller Pose Data Invalid.")
            End If
            If (ErrorList.StateError) Then
                UpdateLabelText(WarningHeaderLabel, "Warning: Controller State Invalid")
            End If
            If (ErrorList.VirtualControllerError) Then
                UpdateLabelText(WarningHeaderLabel, "Warning: Virtual Controller Not Fully Supported.")
            End If
        Else
            UpdatePanelVisibility(WarningPanel, False)
        End If
    End Sub

    Private Sub SetPsButtonData()
        Dim mPSMoveState = mController.m_Info.GetPSState(Of Controllers.Info.PSMoveState)

        psButtonData.TriangleButton = GetButtonState(mPSMoveState.m_TriangleButton.ToString)
        psButtonData.CircleButton = GetButtonState(mPSMoveState.m_CircleButton.ToString)
        psButtonData.CrossButton = GetButtonState(mPSMoveState.m_CrossButton.ToString)
        psButtonData.SquareButton = GetButtonState(mPSMoveState.m_SquareButton.ToString)
    End Sub


    Public Function GetButtonState(state As String) As Boolean
        If (state = "PSMButtonState_UP") Then
            Return False
        ElseIf (state = "PSMButtonState_DOWN") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub UpdatePoint3D(mController As Controllers)
        PoseLocation = New Pose3D(mController.m_Info.m_Pose.m_Position.x, mController.m_Info.m_Pose.m_Position.y, mController.m_Info.m_Pose.m_Position.z)
        PoseOrientation = New Quaternion3D(mController.m_Info.m_Pose.m_Orientation.x, mController.m_Info.m_Pose.m_Orientation.y, mController.m_Info.m_Pose.m_Orientation.z, mController.m_Info.m_Pose.m_Orientation.w)
    End Sub

    Public Sub UpdateLabelText(control As Label, text As String)
        If control.InvokeRequired Then
            control.Invoke(New Action(Of Label, String)(AddressOf UpdateLabelText), control, text)
        Else
            control.Text = text
        End If
    End Sub

    Private Sub UpdatePanelVisibility(control As Panel, visible As Boolean)
        If control.InvokeRequired Then
            control.Invoke(New Action(Of Panel, Boolean)(AddressOf UpdatePanelVisibility), control, visible)
        Else
            control.Visible = visible
        End If
    End Sub

    Private Sub SetCursorMotion()
        If (CursorEnabled) Then
            Try
                If (AxisOfDepth) Then
                    SetMouseCursorPosition((PoseLocation.X * PixelsPerPlayspaceX), ((PoseLocation.Y * PixelsPerPlayspaceY) * -1))
                Else
                    SetMouseCursorPosition((PoseLocation.Z * PixelsPerPlayspaceX), ((PoseLocation.Y * PixelsPerPlayspaceY) * -1))
                End If
            Catch ex As Exception
                'Throw ex
                CursorEnabled = False
            End Try
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If (CalibratedForUse) Then
            CursorEnabled = True
        Else
            MsgBox("No Calibration File Found.")
        End If
    End Sub

    Private Sub CalibrateMouseButton_Click(sender As Object, e As EventArgs) Handles CalibrateMouseButton.Click
        MonitorSetup.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ConfigureButton_Click(sender As Object, e As EventArgs) Handles ConfigureButton.Click

    End Sub
End Class
