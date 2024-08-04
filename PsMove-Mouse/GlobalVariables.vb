Imports PSMoveServiceExCAPI.PSMoveServiceExCAPI

Module GlobalVariables
    Public mController As Controllers = Nothing
    Public psButtonData As ButtonPacket = New ButtonPacket(False, False, False, False, False, False, False, False, False)
    Public leftClickMap As String = ""
    Public rightClickMap As String = ""
    Public PoseLocation As Pose3D
    Public PoseOrientation As Quaternion3D

    Public PixelsPerPlayspaceX As Double
    Public PixelsPerPlayspaceY As Double

    Public CalibratedForUse As Boolean = False
    Public CursorEnabled As Boolean = False
    Public AxisOfDepth As Boolean = Nothing

    Public Points3D As New List(Of Pose3D)()
    Public screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Public screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
End Module

Public Class ButtonPacket
    Public Property TriangleButton As Boolean
    Public Property CircleButton As Boolean
    Public Property CrossButton As Boolean
    Public Property SquareButton As Boolean
    Public Property SelectButton As Boolean
    Public Property StartButton As Boolean
    Public Property PSButton As Boolean
    Public Property MoveButton As Boolean
    Public Property TriggerButton As Boolean

    Public Sub New(triangle As Boolean, circle As Boolean, cross As Boolean, square As Boolean, selectB As Boolean, start As Boolean, ps As Boolean, move As Boolean, trigger As Boolean)
        Me.TriggerButton = triangle
        Me.CircleButton = circle
        Me.CrossButton = cross
        Me.SquareButton = square
        Me.SelectButton = selectB
        Me.StartButton = start
        Me.PSButton = ps
        Me.MoveButton = move
        Me.TriangleButton = trigger
    End Sub
End Class

Public Class Pose3D
    Public Property X As Integer
    Public Property Y As Integer
    Public Property Z As Integer

    Public Sub New(x As Integer, y As Integer, z As Integer)
        Me.X = x
        Me.Y = y
        Me.Z = z
    End Sub
End Class

Public Class Quaternion3D
    Public Property X As Integer
    Public Property Y As Integer
    Public Property Z As Integer
    Public Property W As Integer

    Public Sub New(x As Integer, y As Integer, z As Integer, w As Integer)
        Me.X = x
        Me.Y = y
        Me.Z = z
        Me.W = w
    End Sub
End Class

Public Class ErrorList
    Public Property PoseError As Boolean
    Public Property StateError As Boolean
    Public Property VirtualControllerError As Boolean

    Public Sub New(pose As Boolean, state As Boolean, virtualcontroller As Boolean)
        Me.PoseError = pose
        Me.StateError = state
        Me.VirtualControllerError = virtualcontroller
    End Sub
End Class
